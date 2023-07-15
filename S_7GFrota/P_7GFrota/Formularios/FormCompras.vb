'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 31/3/2014
' Hora: 13:34
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data
Public Partial Class FormCompras
	Dim cadcompra As New CadCompras
	Dim compras As New EntCompras
	Dim v_updateCompras As Integer '1 insere produtos no gride Itens / 2 atualiza somente a quantidade no gride intens
	
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	
	Sub FormCompras_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.F1  And dgv_itens.Visible = False And lbl_NovaCompra.Visible = True Then 'insere compra
				
				lbl_NovaCompra.Visible = False
				dgv_itens.Visible = True
				gb_DadosCompra.Visible = True
				gb_ValorTotalCompra.Visible = True
				txt_detalhe.Focus			
				
				cadcompra.AdicionarCompra(compras)
				compras.IdCompra =  cadcompra.RetornaIdCompra 'instancia compras.idcompra com o valor que foi criado
				
				
		Else If e.KeyCode = Keys.F1 And dgv_itens.Visible = True And lbl_NovaCompra.Visible = False Then
			
					If pnl_qtd.Visible = True Then
						Exit Sub
					
					ElseIf pnl_Produto.Visible = False  And dgv_itens.Visible = True And lbl_NovaCompra.Visible = False Then 'mostra Pnl_produto
						pnl_Produto.Visible = True
						dgv_produtos.DataSource = ""
						txt_produto.Clear
						txt_produto.Focus
						
					Elseif pnl_Produto.Visible = True Then 'limpa txt_produto
						txt_produto.Clear
						txt_produto.Focus
					Else
						Exit Sub
					End If
					
		End If
		
		
		If e.KeyCode = Keys.Escape Then
			If pnl_Produto.Visible = True Then
				pnl_Produto.Visible = False
				dgv_produtos.DataSource = ""
				dgv_itens.Focus
			End If
		End If
		
		If e.KeyCode = Keys.F5  Then
			Try
				
				If pnl_qtd.Visible = False And dgv_itens.Visible = True And lbl_NovaCompra.Visible = False And pnl_Produto.Visible = False Then
						v_updateCompras = 2
						pnl_qtd.Visible = True
						pnl_Produto.Visible = False
						txt_qtd.Text = dgv_itens.SelectedCells(4).Value.ToString
						compras.IdProduto = CInt(dgv_itens.SelectedCells(0).Value.ToString)
						compras.IdFornecedor =CInt(dgv_itens.SelectedCells(2).Value.ToString)
						txt_qtd.Focus
				Else
						Exit Sub
					End If
					
			Catch erro As Exception
				MsgBox("Certifique-se de que existe item correto na tabela de produtos para mudar a quantidade" + erro.Message, vbOKOnly,"Erro")
				pnl_qtd.Visible = False
				Exit Sub
			End Try
			
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
			dgv_produtos.Columns(5).HeaderText = "PREÇO CUSTO"
			
			dgv_produtos.Columns(5).DefaultCellStyle.Format = ("c2")
			
			dgv_produtos.Columns(0).Visible = True  'Nome Produto
			dgv_produtos.Columns(1).Visible = True  'Nome Fantasia
			dgv_produtos.Columns(2).Visible = False 'IdProduto
			dgv_produtos.Columns(3).Visible = False 'IdFornecedor
			dgv_produtos.Columns(4).Visible = True  'QTD (Estoque)
			dgv_produtos.Columns(5).Visible = True  'Preço custo
			dgv_produtos.Columns(6).Visible = False 'Preço venda
			
			dgv_produtos.Columns(0).Width = 180
			dgv_produtos.Columns(1).Width = 180
			dgv_produtos.Columns(4).Width = 70
			dgv_produtos.Columns(5).Width = 110	
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_produtos.Focus
		End If
	End Sub
	
	Sub Dgv_produtos_KeyDown(sender As Object, e As KeyEventArgs)
	      If e.KeyCode = Keys.Enter Then
				Try
					v_updateCompras =1
					pnl_qtd.Visible = True
					pnl_Produto.Visible = False
					txt_qtd.Text = "1"
					txt_qtd.Focus
						
					compras.NomeProduto = dgv_produtos.SelectedCells(0).Value.ToString
					compras.NomeFantasia = dgv_produtos.SelectedCells(1).Value.ToString
					compras.IdProduto = CInt(dgv_produtos.SelectedCells(2).Value.ToString)
					compras.IdFornecedor = CInt(dgv_produtos.SelectedCells(3).Value.ToString)
					compras.PrecoCusto = CDbl(dgv_produtos.SelectedCells(5).Value.ToString)
					
				Catch erro As Exception
					MsgBox("Erro inesperado, Certifique-se de ter escolhido um produto corretamente -> " + erro.Message, vbOKOnly, "Erro")
					pnl_qtd.Visible = False
					pnl_Produto.Visible = True
					txt_produto.Focus
			   End Try
		  End If
	End Sub
	
	
	Sub Txt_qtd_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			If Not IsNumeric(txt_qtd.Text) Or txt_qtd.Text = "0" Then
				txt_qtd.Focus
			else	
				If v_updateCompras = 1  Then 'insere produtos no grid Itens
					compras.Qtd = CInt( txt_qtd.Text)
					Dim insere As Boolean = cadcompra.AdicionarItensCompra(compras)
					
							Select Case insere 'select usado pra evitar q seja inserida uma linha no gride Itens em caso de erro, pois quando o usuario insere um item que ja existe da erro e não é inserido no banco mas é inserido no gride 
								Case = False
									pnl_qtd.Visible = False
									Exit Sub
								Case = True
									dgv_itens.Rows.Add(compras.IdProduto,compras.NomeProduto,compras.IdFornecedor, compras.NomeFantasia,compras.Qtd,compras.PrecoCusto)
									pnl_qtd.Visible = False
									dgv_produtos.DataSource = ""
									pnl_Produto.Visible = True
									txt_produto.Clear
									txt_produto.Focus
								
									'if utilizado para valorar compras.valortotal pq na hora de receber o valor vai dar erro se não tiver nada na lbl_totalcompra
									If lbl_totalCompra.Text = "" Then
										compras.ValorTotal = 0
									Else
										compras.ValorTotal = CDbl(lbl_totalCompra.Text)
									End If	
									lbl_totalCompra.Text =  CStr (FormatCurrency (calculaPreco(compras.Qtd, compras.PrecoCusto,compras.ValorTotal),2))
							End Select
							
							'Procedimentos para ataualizar o estoque na tabela prodFor
							Dim dr As MySqlDataReader = cadcompra.SelecionaEstoque(compras.IdProduto,compras.IdFornecedor)
							dr.Read
							Dim qtd As Integer = dr.GetInt32(0) + compras.Qtd
							dr.Close
							cadcompra.atualizaEstoque(qtd,compras.IdProduto,compras.IdFornecedor)
							
									
					ElseIf v_updateCompras = 2 Then ' Atualiza a qtd da linha selecionada
						Try
							Dim EstoqueAntigo As Integer ' utilizada para armazenar o valor antigo antes que seja atualizado
							Dim EstoqueAtual As Integer 'utilizada para atualizar o estoque da tabela prodFor
							
						'Primeiro é subtraido o total existente e armazenado na variavel vt
							compras.Qtd = CInt(dgv_itens.SelectedCells(4).Value.ToString)
							EstoqueAntigo = compras.Qtd
							compras.PrecoCusto = CDbl(dgv_itens.SelectedCells(5).Value.ToString)
							compras.ValorTotal = CDbl(lbl_totalCompra.Text)
							Dim vt As Double = subtraiPreco(compras.Qtd,compras.PrecoCusto,compras.ValorTotal)
						
				        'Segundo, é feita uma nova soma usando o valor que está na variavel vt						
					    	dgv_itens.SelectedCells(4).Value = txt_qtd.Text
							compras.PrecoCusto = CDbl(dgv_itens.SelectedCells(5).Value.ToString)
							compras.Qtd = CInt(txt_qtd.Text)
							compras.ValorTotal = vt
							lbl_totalCompra.Text = CStr(FormatCurrency(calculaPreco(compras.Qtd,compras.PrecoCusto,compras.ValorTotal),2))
							
							dgv_itens.Focus
							pnl_qtd.Visible = False
							
							cadcompra.AtualizaItensCompras(compras)
								
							'Procedimentos para ataualizar o estoque na tabela prodFor
							Dim dr As MySqlDataReader = cadcompra.SelecionaEstoque(compras.IdProduto,compras.IdFornecedor)
							dr.Read
						    EstoqueAtual =   (dr.GetInt32(0) - EstoqueAntigo) + compras.Qtd
						    dr.Close
							cadcompra.atualizaEstoque(EstoqueAtual,compras.IdProduto,compras.IdFornecedor)
							
				    	Catch erro As Exception
				    		MsgBox("Verifique o valor digitado" + erro.Message,vbOKOnly,"ERRO")
				    	End Try	
					End If
			End If
				
		End If
		
	End Sub
	
	
	Public function calculaPreco (qtd As Integer, preco As Double, vt As Double)As Double 'usado quando é inserido algum item
		vt = vt + (qtd * preco)
		Return vt
	End Function
	
	Public Function subtraiPreco (qtd As Integer, preco As Double, vt As Double) As Double 'usado quando é deletado algum item
		Dim valor As Double
		
		valor = vt - (qtd * preco) 
		Return valor
	End Function
	
	
	
	Sub Dgv_itens_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Delete Then
			Try	
				compras.ValorTotal = CDbl (lbl_totalCompra.Text)
				compras.IdProduto = CInt(dgv_itens.SelectedCells(0).Value.ToString)
				compras.IdFornecedor = CInt(dgv_itens.SelectedCells(2).Value.ToString)
				compras.Qtd = CInt (dgv_itens.SelectedCells(4).Value.ToString)
				compras.PrecoCusto = CDbl(dgv_itens.SelectedCells(5).Value.ToString)
				
				lbl_totalCompra.Text = CStr (FormatCurrency(subtraiPreco(compras.Qtd, compras.PrecoCusto, compras.ValorTotal),2))
				cadcompra.ExcluirItenCompra(compras.IdCompra,compras.IdProduto,compras.IdFornecedor)
				
				'Procedimentos para ataualizar o estoque na tabela prodFor
				Dim dr As MySqlDataReader = cadcompra.SelecionaEstoque(compras.IdProduto,compras.IdFornecedor)
				dr.Read
				Dim qtd As Integer = dr.GetInt32(0) - compras.Qtd
				dr.Close
				cadcompra.atualizaEstoque(qtd,compras.IdProduto,compras.IdFornecedor)
				
			Catch erro As Exception
				MsgBox("Não existe dados para excluir",vbOKOnly,"Erro ao Excluir!")
			End Try	
		End If
		
	End Sub
	

	
	
	Sub FormCompras_KeyUp(sender As Object, e As KeyEventArgs) 'usado para finalizar a compra
		If e.KeyCode = Keys.F3  Then
			If dgv_itens.Visible = True And lbl_NovaCompra.Visible = False Then 
					pnl_Produto.Visible = False
					pnl_qtd.Visible = False
					
					If MsgBox("Deseja Finalizar esta compra?",vbYesNo,"Finalizar Compra") = vbYes Then
							Try
								compras.DataCompra = dateTimePicker1.Text
								compras.ValorTotal = CDbl(lbl_totalCompra.Text)
								compras.Detalhe = txt_detalhe.Text			
							    cadcompra.AtualizarCompras(compras)
								
								'dgv_itens.DataSource = ""
								dgv_itens.Rows.Clear
								lbl_totalCompra.Text = ""
								txt_detalhe.Text = ""
								
								gb_DadosCompra.Visible = False
								gb_ValorTotalCompra.Visible = False
								dgv_itens.Visible = False
								lbl_NovaCompra.Visible = True
								
								Me.Focus
							Catch erro As Exception
								MsgBox("Você está tentando finalizar uma compra sem itens! -> " + erro.Message,vbOKOnly, "Erro ao Finalizar Compra")
								Exit Sub
							
							End Try	
						Else
							Exit Sub	
						End If	
						
			Else
				Exit Sub
			End If							
						
		End If
		
		
	End Sub
	
	
End Class
