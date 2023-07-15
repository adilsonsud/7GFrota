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

Public Partial Class FormOrcamento
	
	Dim compra As New EntPDV
	Dim cadcompra As New CadPDV
	'Dim opcaoPDV As Integer ' 1 insere cliente, 2 insere produto - usado para controlar oq o pnl_produto irá exibir (1 cliente / 2 produto)
	Dim v_updateItem As Integer ' 1 inserir, 2 atualizar, 3 deletar, realiza o calculo do vt e preçoUnit
	Dim v_valorTotal As Double
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		lbl_rodape.Visible = True
		pnl_principal.Visible = True
		pnl_lateral.Visible = True
		pnl_produto.Visible = False
		dgv_Itens.Visible = False
		lbl_rodape.Visible = True
		pnl_principal.Visible = True
		dgv_Itens.Visible = True
		pnl_lateral.Visible = True
		txt_valorTotal.Text = "0"
		
	End Sub
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
			Me.Close
	End Sub
	
	
Sub FormOrcamento_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1   Then
					
			 If pnl_produto.Visible = False And pnl_qtd.Visible = False 'mostra pnl_produto
			 		lbl_cliente.Visible = False
			 		pnl_produto.Visible = True
					gb_Nomeproduto.Visible = True
					pnl_qtd.Visible = False
					txt_produto.Clear
					txt_produto.Focus
					
					dgv_produtos.DataSource = ""
					'opcaoPDV = 2 'dgv_produto exibirá os produtos
			 ElseIf pnl_produto.Visible = True 'caso pnl_produto esteja visivel, esta opção limpa txt_produto
					txt_produto.Clear
					txt_produto.Focus
			 End If
		End If
		
		
		If e.KeyCode = Keys.Escape And pnl_produto.Visible = True  Then
			pnl_produto.Visible = False
			dgv_Itens.Focus
		End If
		
		
		If e.KeyCode = Keys.F5 And pnl_produto.Visible = False  And dgv_Itens.RowCount > 0  And dgv_Itens.Visible = True Then
			txt_qtd.Text = CStr(dgv_Itens.SelectedCells(2).Value.ToString)
			v_updateItem = 2
			pnl_qtd.Visible = True
			txt_qtd.Focus
		End If
	End Sub

	Sub Txt_produto_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
			Dim dt As New DataTable
			Dim bs As New BindingSource	
			
			dt = cadcompra.ExibeProdutos(txt_produto.Text)
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

			If dgv_produtos.RowCount < 1 Then
				MsgBox("Digite o nome do produto desejado",vbOKOnly,"Escolha um Produto")
				txt_produto.Clear
				txt_produto.Focus
				Exit Sub
				
			Else
				   compra.Estoque = CInt(dgv_produtos.SelectedCells(4).Value.ToString)
				If compra.Estoque < 1 Then
					MsgBox("Não tem estoque para o este produto!",vbInformation,"ESTOQUE ZERADO")
					Exit Sub
				Else
					compra.NomeProduto = dgv_produtos.SelectedCells(0).Value.ToString
					compra.NomeFantasia = dgv_produtos.SelectedCells(1).Value.ToString
					compra.IdProduto = CInt(dgv_produtos.SelectedCells(2).Value.ToString)
					compra.IdFornecedor = CInt(dgv_produtos.SelectedCells(3).Value.ToString)
					compra.Precovenda = CDbl(dgv_produtos.SelectedCells(6).Value.ToString)
					v_updateItem = 1
					
					pnl_produto.Visible = False
					pnl_qtd.Visible = True
					txt_qtd.Clear
					txt_qtd.Text = "1"
					txt_qtd.Focus
				End If
					
			End If
			
		End If
	End Sub
	
	
	
	Sub Dgv_Itens_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Delete Then
			v_updateItem = 3
			compra.IdProduto = CInt(dgv_Itens.SelectedCells(5).Value.ToString)
			compra.IdFornecedor = CInt(dgv_Itens.SelectedCells(6).Value.ToString)
			compra.QTD = CInt(dgv_Itens.SelectedCells(2).Value.ToString)
			compra.ValorTotal = CDbl(txt_valorTotal.Text)
			compra.Valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString)
			calculoPDV(compra.QTD,compra.Precovenda,compra.ValorTotal)
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
					compra.Estoque = cadcompra.SelecionaEstoque(compra.IdProduto,compra.IdFornecedor)'pega o valor atual do estoque
					If compra.Estoque < txt_qtd.Text Then
						MsgBox("A quantidade desejada é maior do que a quantidade disponivel para o referido produto",vbInformation,"ESTOQUE INSUFICIENTE")
						pnl_qtd.Visible = False
						pnl_produto.Visible = True
						txt_produto.Focus
						Exit Sub
					Else
						compra.ValorTotal =  CDbl(txt_valorTotal.Text)
						compra.QTD = CInt(txt_qtd.Text)
						calculoPDV(compra.QTD,compra.Precovenda,compra.ValorTotal)
						pnl_qtd.Visible = False
						
					End If
			  End If
		End If
	End Sub    
	
	
	
	'utilizado para calcular o valor do item(qtd x preçoUnit)  e valor total
	Public Sub calculoPDV (qtd As Integer, precoUnit As Double, vt As Double)
		Dim valor As Double
		If v_updateItem = 1 Then 'em caso de insert
			
			valor  = qtd * precoUnit
			vt = vt + valor
			compra.Valor = valor
			compra.ValorTotal = vt
			txt_valorTotal.Text = CStr(FormatCurrency(compra.ValorTotal,2))
			dgv_Itens.Rows.Add(compra.NomeProduto,compra.NomeFantasia,compra.QTD,compra.Precovenda,compra.Valor, compra.IdProduto, compra.IdFornecedor)
			
			compra.Estoque -= qtd
			pnl_produto.Visible = True
			txt_produto.Clear
			txt_produto.Focus
			dgv_produtos.DataSource = ""
			
		ElseIf v_updateItem = 2 'em caso de alteração
			
				'1º subtrair do vt o valor
				valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString)
				vt = vt - valor
				
				'2º calcular o novo valor total
				vt = vt + (qtd * precoUnit)
				
				dgv_Itens.SelectedCells(2).Value = txt_qtd.Text 'QTD
				dgv_Itens.SelectedCells(4).Value = CStr(FormatCurrency(qtd * precoUnit,2)) 'valor
				txt_valorTotal.Text = CStr(FormatCurrency(vt,2))
				compra.Valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString) 'qtd * precoUnit
				dgv_Itens.Focus
				 
		ElseIf v_updateItem = 3 Then 'Em caso de subtração
			valor = CDbl(dgv_Itens.SelectedCells(4).Value.ToString)
			txt_valorTotal.Text  = CStr(FormatCurrency(vt - valor)) 	
		End If
			
	End Sub
	
	
	
End Class
