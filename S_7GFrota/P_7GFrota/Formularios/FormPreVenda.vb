'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data

Public Partial Class FormPreVenda
	
	Dim venda As New EntPDV
	Dim cadPDV As New CadPDV
	Dim opcaoPDV As Integer ' 1 insere cliente, 2 insere produto - usado para controlar oq o pnl_produto irá exibir (1 cliente / 2 produto)
	Dim v_updateItem As Integer ' 1 inserir, 2 atualizar, 3 deletar, realiza o calculo do vt e preçoUnit
	Dim v_updateVenda As Integer '1 insere venda , 2 atualiza idCliente ou idFormaPagamento ou os dois
	Dim FormaPagamento As MySqlDataReader
	Dim v_Finaliza As Boolean = False ' tem por finalidade evitar que outras teclas de função sejam ativadas na hora de finalizar a venda(false permite utilização das teclas de função, true não permite)
	Dim v_valorTotal As Double
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		lbl_rodape.Visible = True
		pnl_principal.Visible = True
		pnl_lateral.Visible = True
		pnl_produto.Visible = False
		dgv_Itens.Visible = False
		lbl_idVenda.Visible = False
		
		'carrega cb_formaPagamento
		FormaPagamento = cadPDV.CarregaFormaPagamento
		While FormaPagamento.Read
			cb_formaPagamento.Items.Add(FormaPagamento(0))
		End While
		FormaPagamento.Close
		
		v_updateVenda = 1
		
	End Sub
	
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
		If MsgBox("Deseja fechar a tela de Pré Venda?",vbYesNo,"FECHAR PRÉ VENDA") = vbYes Then
			Me.Close
		Else
			Exit Sub
		End If
	End Sub
	
	
	
Sub FormPreVenda_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1  And v_updateVenda = 2 And v_Finaliza = False Then
			
			If txt_cliente.Text = "" Then 'verifica se existe um cliente
				MsgBox("Escolha um cliente",vbInformation,"ATENÇÃO")
					txt_cliente.Focus
					
			ElseIf cb_formaPagamento.Text = "" Then
				MsgBox("Escolha a forma de pagamento",vbInformation,"ATENÇÃO")
				cb_formaPagamento.Focus
					
			 ElseIf pnl_produto.Visible = False And pnl_qtd.Visible = False And txt_FormaPagamento.Visible = True'mostra pnl_produto
			 		lbl_cliente.Visible = False
			 		pnl_produto.Visible = True
					gb_Nomeproduto.Visible = True
					pnl_qtd.Visible = False
					txt_produto.Clear
					txt_produto.Focus
					
					dgv_produtos.DataSource = ""
					opcaoPDV = 2 'dgv_produto exibirá os produtos
			 ElseIf pnl_produto.Visible = True 'caso pnl_produto esteja visivel, esta opção limpa txt_produto
					txt_produto.Clear
					txt_produto.Focus
			 End If
				
		End If
		
		
		If e.KeyCode = Keys.Escape And pnl_produto.Visible = True  And v_Finaliza = False Then
				pnl_produto.Visible = False
				dgv_Itens.Focus
		End If
		
		
		If e.KeyCode = Keys.F5 And pnl_produto.Visible = False  And v_Finaliza = False And dgv_Itens.RowCount > 0  And dgv_Itens.Visible = True Then
			venda.IdProduto = CInt(dgv_Itens.SelectedCells(5).Value.ToString)
			venda.IdFornecedor = CInt(dgv_Itens.SelectedCells(6).Value.ToString)
			venda.QTD = CInt(dgv_Itens.SelectedCells(2).Value.ToString)
			
			'Procedimentos para atualizar o estoque (campo qtd da tabela prod_for)
			venda.Estoque = cadPDV.SelecionaEstoque(venda.IdProduto,venda.IdFornecedor)'pega o valor atual do estoque
			venda.Estoque += venda.QTD 'soma o valor que esta no campo qtd do grid com o que ta no estoque
			cadPDV.AtualizaEstoque(venda.Estoque,venda.IdProduto,venda.IdFornecedor)'devolve ao estoque o valor antigo
			
			venda.Precovenda = CDbl(dgv_Itens.SelectedCells(3).Value.ToString)
			txt_qtd.Text = CStr(dgv_Itens.SelectedCells(2).Value.ToString)
			v_updateItem = 2
			pnl_qtd.Visible = True
			txt_qtd.Focus
			
		End If
		
		
		If e.KeyCode = Keys.F7  And pnl_qtd.Visible = False And v_updateVenda = 2  And v_Finaliza = False Then
			
			pnl_produto.Visible = False
			dgv_Itens.Visible = False
			txt_cliente.ReadOnly = False
			txt_FormaPagamento.Visible = False
			cb_formaPagamento.Visible = True
			txt_cliente.Focus
			
		End If
		
		
		
		If e.KeyCode = Keys.F3 And v_Finaliza = False And txt_FormaPagamento.Visible = True Then
			
				If dgv_Itens.RowCount < 1    Then
					MsgBox("Você não pode finalizar uma compra sem adicionar no minimo um item , adicione um item pressionando a tecla (F1).",vbOKOnly,"ATENÇÃO")
					Exit Sub
				ElseIf dgv_Itens.RowCount > 0 And pnl_qtd.Visible = False  Then
						pnl_produto.Visible = False
						If	MsgBox("Deseja finalizar esta compra?",vbYesNo,"Finalizar Compra") = vbYes Then
							v_Finaliza = True ' venda sendo finalizada, nenhuma tecla de função poderá ser usada
							txt_desconto.ReadOnly = False
							txt_desconto.Focus
							v_valorTotal = CDbl(txt_valorTotal.Text)
						Else
							Exit Sub	
						End If
					
				End If
			
		End If
		
	End Sub
	

	
	
	Sub Txt_produto_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
			Dim dt As New DataTable
			Dim bs As New BindingSource	
			
			dt = cadPDV.ExibeProdutos(txt_produto.Text)
			bs.DataSource = dt
			dgv_produtos.DataSource = bs
			
			dgv_produtos.Columns(0).HeaderText = "PRODUTO"
			dgv_produtos.Columns(1).HeaderText = "FORNECEDOR"
			dgv_produtos.Columns(4).HeaderText = "ESTOQUE"
			dgv_produtos.Columns(6).HeaderText = "PREÇO"
			
			dgv_produtos.Columns(6).DefaultCellStyle.Format = ("c2")
			
			dgv_produtos.Columns(0).Visible = True  'Nome Produto
			dgv_produtos.Columns(1).Visible = True  'Nome Fantasia
			dgv_produtos.Columns(2).Visible = False 'IdProduto
			dgv_produtos.Columns(3).Visible = False 'IdFornecedor
			dgv_produtos.Columns(4).Visible = True  'QTD (Estoque)
			dgv_produtos.Columns(5).Visible = False  'Preço custo
			dgv_produtos.Columns(6).Visible = True 'Preço venda
			
			dgv_produtos.Columns(0).Width = 190
			dgv_produtos.Columns(1).Width = 190
			dgv_produtos.Columns(4).Width = 100
			dgv_produtos.Columns(6).Width = 110	
			
			
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_produtos.Focus
		End If
		
	End Sub
	
	
	
	
	
	
    Sub Dgv_produtos_KeyDown(sender As Object, e As KeyEventArgs)
    	If e.KeyCode = Keys.Enter Then
    		
				If opcaoPDV = 1 Then 'processa informações do cliente
					txt_cliente.Text = dgv_produtos.SelectedCells(1).Value.ToString
					venda.IdCliente = CInt(dgv_produtos.SelectedCells(0).Value.ToString)
					pnl_produto.Visible = False
					lbl_cliente.Visible = False
					cb_formaPagamento.Focus
				ElseIf opcaoPDV = 2 Then 'processa informações dos produtos
						If dgv_produtos.RowCount < 1 Then
							MsgBox("Digite o nome do produto desejado",vbOKOnly,"Escolha um Produto")
							txt_produto.Clear
							txt_produto.Focus
							Exit Sub
							
						Else
								   venda.Estoque = CInt(dgv_produtos.SelectedCells(4).Value.ToString)
								If venda.Estoque < 1 Then
									MsgBox("Não tem estoque para o este produto!",vbInformation,"ESTOQUE ZERADO")
									Exit Sub
								Else
									venda.NomeProduto = dgv_produtos.SelectedCells(0).Value.ToString
									venda.NomeFantasia = dgv_produtos.SelectedCells(1).Value.ToString
									venda.IdProduto = CInt(dgv_produtos.SelectedCells(2).Value.ToString)
									venda.IdFornecedor = CInt(dgv_produtos.SelectedCells(3).Value.ToString)
									venda.Precovenda = CDbl(dgv_produtos.SelectedCells(6).Value.ToString)
									v_updateItem = 1
									
									pnl_produto.Visible = False
									pnl_qtd.Visible = True
									txt_qtd.Clear
									txt_qtd.Text = "1"
									txt_qtd.Focus
								End If
								
						End If
				End If
				
		End If
	End Sub
	
		
	
	
	
	Sub Dgv_Itens_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_cliente.Focus
		End If
		
		
		If e.KeyCode = Keys.Delete Then
			v_updateItem = 3
			venda.IdProduto = CInt(dgv_Itens.SelectedCells(5).Value.ToString)
			venda.IdFornecedor = CInt(dgv_Itens.SelectedCells(6).Value.ToString)
			venda.QTD = CInt(dgv_Itens.SelectedCells(2).Value.ToString)
			venda.ValorTotal = CDbl(txt_valorTotal.Text)
			venda.Valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString)
			calculoPDV(venda.QTD,venda.Precovenda,venda.ValorTotal)
		End If
	End Sub
	
	
	Sub Txt_qtd_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
				If(txt_qtd.Text = "")
					MsgBox("Digite um valor valido", vbOKOnly,"Erro")
					txt_qtd.Text = "1"
					txt_qtd.Focus
				elseIf Not IsNumeric(txt_qtd.Text)  Then
					MsgBox("Digite um valor valido", vbOKOnly,"Erro")
					txt_qtd.Text = "1"
					txt_qtd.Focus
				ElseIf	(txt_qtd.Text < 1) Then
					MsgBox("Digite um valor valido", vbOKOnly,"Erro")
					txt_qtd.Text = "1"
					txt_qtd.Focus
				Else
						If venda.Estoque < txt_qtd.Text Then
							MsgBox("A quantidade desejada é maior do que a quantidade disponivel para o referido produto",vbInformation,"ESTOQUE INSUFICIENTE")
							pnl_qtd.Visible = False
							pnl_produto.Visible = True
							txt_produto.Focus
							Exit Sub
						Else
							
							venda.ValorTotal =  CDbl(txt_valorTotal.Text)
							venda.QTD = CInt(txt_qtd.Text)
							calculoPDV(venda.QTD,venda.Precovenda,venda.ValorTotal)
							pnl_qtd.Visible = False
							
						End If
					
			  End If
			
		End If
	End Sub    
	
	'utilizado para calcular o valor do item(qtd x preçoUnit)  e valor total
	Public Sub calculoPDV (qtd As Integer, precoUnit As Double, vt As Double)
		Dim valor As Double
		
		If v_updateItem = 1 Then 'em caso de insert
			Dim insere As Boolean = cadPDV.AdicionarItensVenda(venda)
			Select Case insere 'select usado pra evitar q seja inserida uma linha no gride Itens em caso de erro, pois quando o usuario insere um item que ja existe da erro e não é inserido no banco mas é inserido no gride
				
					Case False
						pnl_qtd.Visible = False
						Exit Sub
					Case True	
						valor  = qtd * precoUnit
						vt = vt + valor
						venda.Valor = valor
						venda.ValorTotal = vt
						txt_valorTotal.Text = CStr(FormatCurrency(venda.ValorTotal,2))
						dgv_Itens.Rows.Add(venda.NomeProduto,venda.NomeFantasia,venda.QTD,venda.Precovenda,venda.Valor, venda.IdProduto, venda.IdFornecedor)
						cadPDV.AtualizaItemVenda(venda)
						venda.Estoque -= qtd
						cadPDV.AtualizaEstoque(venda.Estoque,venda.IdProduto,venda.IdFornecedor)
						pnl_produto.Visible = True
						txt_produto.Clear
						txt_produto.Focus
						dgv_produtos.DataSource = ""
					End Select	
			
		ElseIf v_updateItem = 2 'em caso de alteração
			
				'1º subtrair do vt o valor
				valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString)
				vt = vt - valor
				
				'2º calcular o novo valor total
				vt = vt + (qtd * precoUnit)
				
				dgv_Itens.SelectedCells(2).Value = txt_qtd.Text 'QTD
				dgv_Itens.SelectedCells(4).Value = CStr(FormatCurrency(qtd * precoUnit,2)) 'valor
				txt_valorTotal.Text = CStr(FormatCurrency(vt,2))
				venda.Valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString) 'qtd * precoUnit
				dgv_Itens.Focus
				cadPDV.AtualizaItemVenda(venda)
				
				'Procedimentos para atualizar o estoque (campo qtd da tabela prod_for)
				venda.Estoque = cadPDV.SelecionaEstoque(venda.IdProduto, venda.IdFornecedor)
				venda.Estoque -= qtd
				cadPDV.AtualizaEstoque(venda.Estoque,venda.IdProduto,venda.IdFornecedor)
							
		ElseIf v_updateItem = 3 Then 'Em caso de subtração
				
				valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString)
				txt_valorTotal.Text  = CStr(FormatCurrency(vt - valor)) 	
				cadPDV.ExcluirItenVenda(venda.IdVenda, venda.IdProduto, venda.IdFornecedor)
				venda.Estoque = cadPDV.SelecionaEstoque(venda.IdProduto,venda.IdFornecedor)
				venda.Estoque += qtd
				cadPDV.AtualizaEstoque(venda.Estoque,venda.IdProduto,venda.IdFornecedor)
		End If
			
	End Sub
	
	
	
	Sub Txt_cliente_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter And cb_formaPagamento.Visible = True Then
			Dim dt As New DataTable
			Dim bs As New BindingSource	
			
			dt = cadPDV.SelecionaCliente(txt_cliente.Text)
			bs.DataSource = dt
			pnl_produto.Visible = True
			lbl_cliente.Visible = True
			
			dgv_produtos.DataSource = bs
			
			gb_Nomeproduto.Visible = False
			dgv_produtos.Columns(1).HeaderText = "CLIENTE"
			dgv_produtos.Columns(2).HeaderText = "CPF/CNPJ"
			
			dgv_produtos.Columns(0).Visible = False  'Id Cliente
			dgv_produtos.Columns(1).Visible = True  'Nome Cliente
			dgv_produtos.Columns(2).Visible = True 'Cpf/Cnpj
			
			dgv_produtos.Columns(1).Width = 350
			dgv_produtos.Columns(2).Width = 210
			
			opcaoPDV = 1 'dgv_produtos exibirá os clientes
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_produtos.Focus
		End If
		
	End Sub
	
	
	
	Sub Cb_formaPagamento_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Escape Then
			txt_cliente.Focus
		End If
		
		
		
		If e.KeyCode = Keys.Enter Then
				If txt_cliente.Text = "" Then
					MsgBox("Escolha um cliente",vbOKOnly,"ATENÇÃO")
					txt_cliente.Focus
					Exit Sub
					
				ElseIf cb_formaPagamento.Text = "" Then
					MsgBox("Escolha a forma de pagamento",vbOKOnly,"ATENÇÃO")
					cb_formaPagamento.Focus
					Exit Sub
					
				Else
					Select Case v_updateVenda
						Case 1
							
							lbl_rodape.Visible = True
							pnl_principal.Visible = True
							dgv_Itens.Visible = True
							pnl_lateral.Visible = True
							venda.DataVenda = CStr(Today)
							lbl_data.Text = venda.DataVenda
							lbl_data.Visible = True
							lbl_status.Text = "Aberta"
							lbl_status.ForeColor = Color.Lime
							lbl_status.Visible = True
							txt_valorTotal.Text = "0"
							txt_desconto.Text = "0"
							
							lbl_cliente.Visible = False
					 		pnl_produto.Visible = True
							gb_Nomeproduto.Visible = True
							pnl_qtd.Visible = False
							txt_FormaPagamento.Visible = True
							txt_FormaPagamento.Text = cb_formaPagamento.Text
							cb_formaPagamento.Visible = False
							txt_cliente.ReadOnly = True
							txt_FormaPagamento.ReadOnly = True
							
							txt_produto.Clear
							txt_produto.Focus
						
							dgv_produtos.DataSource = ""
							opcaoPDV = 2 'dgv_produto exibirá os produtos
							
							venda.Desconto = CDbl(txt_desconto.Text)
							venda.ValorTotal = CDbl(txt_valorTotal.Text)
							venda.Aberta = True
							
							venda.IdFormaPagamento = cadPDV.SelecionaIdFormaPagamento(cb_formaPagamento.Text)
							venda.IdCliente = cadPDV.SelecionaIdCliente(txt_cliente.Text)
							cadPDV.AdicionarVenda(venda)
							venda.IdVenda = cadPDV.RetornaIdVenda
							lbl_idVenda.Text = CStr(venda.IdVenda)
							lbl_idVenda.Visible = True
							v_updateVenda = 2
							
						Case 2
							venda.IdFormaPagamento = cadPDV.SelecionaIdFormaPagamento(cb_formaPagamento.Text)
							venda.IdCliente = cadPDV.SelecionaIdCliente(txt_cliente.Text)
							
							dgv_Itens.Visible = True
							lbl_cliente.Visible = False
					 		pnl_produto.Visible = True
							gb_Nomeproduto.Visible = True
							pnl_qtd.Visible = False
							txt_FormaPagamento.Visible = True
							txt_FormaPagamento.Text = cb_formaPagamento.Text
							cb_formaPagamento.Visible = False
							txt_cliente.ReadOnly = True
							txt_FormaPagamento.ReadOnly = True
							
							txt_produto.Clear
							txt_produto.Focus
						
							dgv_produtos.DataSource = ""
							opcaoPDV = 2 'dgv_produto exibirá os produtos
							cadPDV.AtualizarInfoVendas(venda.IdCliente,venda.IdFormaPagamento,venda.IdVenda)
							
					End Select
						
				End If
		End If
		
	End Sub
	
	
	
	Sub Txt_desconto_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter And txt_desconto.ReadOnly = False Then
			
			txt_valorTotal.Text = FormatCurrency(CalculoDesconto,2)
			If MsgBox("Confirme a finalização da Pré Venda", vbYesNo,"FINALIZAÇÃO DA PRÉ VENDA") = vbYes Then
						
						v_Finaliza = False
						txt_cliente.Clear
						txt_FormaPagamento.Clear
						txt_valorTotal.Clear
						txt_desconto.Clear
						txt_FormaPagamento.Visible = False
						
						cb_formaPagamento.Items.Clear
						cb_formaPagamento.Visible = True
						
						dgv_itens.Rows.Clear
						dgv_Itens.Visible = False
						
						lbl_data.Visible = False
						lbl_status.Visible = False
						lbl_rodape.Visible = True
						lbl_idVenda.Visible = False
						
						pnl_principal.Visible = True
						pnl_lateral.Visible = True
						pnl_produto.Visible = False
						
						venda.Aberta = True
						cadPDV.AtualizarVenda(venda)
						
						
						'carrega cb_formaPagamento
						FormaPagamento = cadPDV.CarregaFormaPagamento
						While FormaPagamento.Read
							cb_formaPagamento.Items.Add(FormaPagamento(0))
						End While
						FormaPagamento.Close
		
						v_updateVenda = 1
						
						txt_cliente.Focus
						
					Else
						txt_valorTotal.Text = CStr(FormatCurrency(v_valorTotal,2))
						txt_desconto.Clear
						
						txt_desconto.ReadOnly = False
						txt_desconto.Focus
						
					End If
			
			
		End If
		
		
		If e.KeyCode = keys.Back And txt_desconto.ReadOnly = False Then
			txt_desconto.ReadOnly = False
			txt_desconto.Clear
			txt_desconto.Focus
		End If
	End Sub
	
	
	Public Function CalculoDesconto As Double
		If Not IsNumeric(txt_desconto.Text) Then
		   txt_desconto.Text = "0"	
		End If
		
		venda.ValorTotal = CDbl(txt_valorTotal.Text)
		venda.Desconto = CDbl(txt_desconto.Text)
		txt_desconto.Text = CStr(FormatCurrency (txt_desconto.Text,2))
		
		If venda.Desconto > venda.ValorTotal Then
			MsgBox("O valor do desconto não pode ser maior do que o valor total", vbInformation,"ATENÇÃO")
			txt_desconto.ReadOnly = False
			txt_desconto.Clear
			txt_desconto.Focus
			
		Else
			venda.ValorTotal = venda.ValorTotal - venda.Desconto
			txt_desconto.ReadOnly = True
		End If
		Return venda.ValorTotal
	End Function
	

	
	Sub Txt_desconto_KeyPress(sender As Object, e As KeyPressEventArgs)

		If Not Char.IsNumber(e.KeyChar)  And Not  e.KeyChar = "," Then
    		 e.Handled = True
		End If

	End Sub
	
	
	
	Sub FormPreVenda_Load(sender As Object, e As EventArgs)
		txt_cliente.Focus
	End Sub
End Class
