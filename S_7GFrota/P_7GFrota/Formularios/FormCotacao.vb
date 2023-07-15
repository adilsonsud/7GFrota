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

Public Partial Class FormCotacao
	
	Dim compra As New EntCompras
	Dim pdv As New EntPDV
	Dim cadPdv As New CadPDV
	Dim cadCompra As New CadCompras
	Dim opcaoPDV As Integer ' 1 insere cliente, 2 insere produto - usado para controlar oq o pnl_produto irá exibir (1 cliente / 2 produto)
	Dim v_updateItem As Integer ' 1 inserir, 2 atualizar, 3 deletar, realiza o calculo do vt e preçoUnit
	Dim v_valorTotal As Double = 0
	
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
	
	
Sub FormCotacao_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1   Then
					
			 If pnl_produto.Visible = False And pnl_qtd.Visible = False 'mostra pnl_produto
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
		
		
		If e.KeyCode = Keys.Escape And pnl_produto.Visible = True  Then
			pnl_produto.Visible = False
			dgv_Itens.Focus
		End If
		
		
		If e.KeyCode = Keys.F5 And pnl_produto.Visible = False  And dgv_Itens.RowCount > 0  And dgv_Itens.Visible = True Then
			v_updateItem = 2
			compra.Qtd = CInt(dgv_Itens.SelectedCells(2).Value.ToString)
			compra.PrecoCusto = CDbl(dgv_Itens.SelectedCells(3).Value.ToString)
			v_valorTotal = CDbl((txt_valorTotal.Text) - (compra.Qtd * compra.PrecoCusto))
			txt_qtd.Text = CStr (compra.Qtd)
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
			dgv_produtos.Columns(5).HeaderText = "PREÇO CUSTO"
			
			dgv_produtos.Columns(5).DefaultCellStyle.Format = ("c2")
			
			dgv_produtos.Columns(0).Visible = True  'Nome Produto
			dgv_produtos.Columns(1).Visible = True  'Nome Fantasia
			dgv_produtos.Columns(2).Visible = False 'IdProduto
			dgv_produtos.Columns(3).Visible = False 'IdFornecedor
			dgv_produtos.Columns(4).Visible = True  'QTD (Estoque)
			dgv_produtos.Columns(5).Visible = True  'Preço custo
			dgv_produtos.Columns(6).Visible = False 'Preço venda
			
			dgv_produtos.Columns(0).Width = 190
			dgv_produtos.Columns(1).Width = 190
			dgv_produtos.Columns(4).Width = 90
			dgv_produtos.Columns(5).Width = 120	
			
			
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
				
			compra.NomeProduto = dgv_produtos.SelectedCells(0).Value.ToString
			compra.NomeFantasia = dgv_produtos.SelectedCells(1).Value.ToString
			compra.IdProduto = CInt(dgv_produtos.SelectedCells(2).Value.ToString)
			compra.IdFornecedor = CInt(dgv_produtos.SelectedCells(3).Value.ToString)
			compra.PrecoCusto = CDbl(dgv_produtos.SelectedCells(5).Value.ToString)

			v_updateItem = 1
						
				pnl_produto.Visible = False
				pnl_qtd.Visible = True
				txt_qtd.Clear
				txt_qtd.Text = "1"
				txt_qtd.Focus
			End If
				
		End If
	End Sub
	
	
	
	Sub Dgv_Itens_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Delete Then
			v_updateItem = 3
			
			compra.QTD = CInt(dgv_Itens.SelectedCells(2).Value.ToString)
			compra.PrecoCusto = CDbl(dgv_Itens.SelectedCells(3).Value.ToString)
			v_valorTotal = CDbl (txt_valorTotal.Text)
			calculaTotal(compra.Qtd, compra.PrecoCusto)

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
					
					compra.QTD = CInt(txt_qtd.Text)
					calculaTotal(compra.Qtd, compra.PrecoCusto)
					
					pnl_qtd.Visible = False
					pnl_produto.Visible = True
					txt_produto.Clear
					dgv_produtos.DataSource = ""
					txt_produto.Focus
							
			  End If
		End If
	End Sub    
	
	Public sub calculaTotal (qtd As Integer, precoCusto As Double) 'usado quando é inserido algum item
		If v_updateItem = 1 Then
			v_valorTotal = CDbl(v_valorTotal +  (qtd * precoCusto))
			dgv_Itens.Rows.Add(compra.NomeProduto, compra.NomeFantasia, compra.Qtd, compra.PrecoCusto)
			txt_valorTotal.Text = CStr(FormatCurrency(v_valorTotal ,2))
		ElseIf v_updateItem = 2 Then
			v_valorTotal = v_valorTotal + (qtd * precoCusto)
			dgv_Itens.SelectedCells(2).Value = qtd
			txt_valorTotal.Text = FormatCurrency(v_valorTotal,2) 
		ElseIf v_updateItem = 3 Then	
			v_valorTotal -= (qtd * precoCusto)
			txt_valorTotal.Text = FormatCurrency(v_valorTotal,2)
		End If	
	End Sub	
	
	
	
End Class
