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

Public Partial Class FormEstoque
	
	Dim venda As New EntPDV
	Dim cadPDV As New CadPDV
	Dim cadCategorias As New CadCategorias
	Dim cadProdutos As New CadProdutos
	Dim cadFornecedor As New CadFornecedores
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		
			
	End Sub
	
	Sub ExibeEstoque
		Dim Filtro As String
		Dim dt As New DataTable
		Dim bs As New BindingSource	
		
		If rb_ProdutoZerado.Checked = True Then
			Filtro = " where prod_for.QTD = 0"
			
		ElseIf rb_categoria.Checked = True Then
			Filtro = " where categorias.Nome like '%" & txt_pesquisa.Text & "%' "
			
		ElseIf rb_produto.Checked = True Then	
			Filtro = " where produtos.Nome like '%" & txt_pesquisa.Text & "%' "
			
		ElseIf rb_fornecedor.Checked = True Then
			Filtro = " where fornecedores.NomeFantasia like '%" & txt_pesquisa.Text & "%' "
			
		ElseIf rb_qtd.Checked = True Then
				If txt_pesquisa.Text = "" Then
					Filtro = "" 
				Else	
					
					Filtro = " where prod_for.QTD = " & txt_pesquisa.Text
				End If
			
			
		ElseIf rb_todos.Checked = True Then
			Filtro = ""
			dt = cadPDV.ExibeEstoque(Filtro)
			bs.DataSource = dt
			dgv_Itens.DataSource = bs
		Else
			MsgBox("Escolha uma opção para exibir o estoque", vbInformation,"ATENÇÃO")
			gb_exibirEstoque.Focus
			Exit Sub
		End If
			
			dt = cadPDV.ExibeEstoque(Filtro)
			bs.DataSource = dt
			dgv_Itens.DataSource = bs
			
			dgv_Itens.Columns(0).HeaderText = "CATEGORIA"
			dgv_Itens.Columns(1).HeaderText = "PRODUTO"
			dgv_Itens.Columns(2).HeaderText = "FORNECEDOR"
			dgv_Itens.Columns(3).HeaderText = "QTD"
			dgv_Itens.Columns(4).HeaderText = "PREÇO CUSTO"
			dgv_Itens.Columns(5).HeaderText = "PREÇO VENDA"
			
			dgv_Itens.Columns(4).DefaultCellStyle.Format = ("c2")
			dgv_Itens.Columns(5).DefaultCellStyle.Format = ("c2")
			
			dgv_Itens.Columns(0).Width = 200
			dgv_Itens.Columns(1).Width = 270
			dgv_Itens.Columns(2).Width = 250
			dgv_Itens.Columns(3).Width = 80	
			dgv_Itens.Columns(4).Width = 160	
			dgv_Itens.Columns(5).Width = 160	
	End Sub
	
	
	Sub ExibePesquisa
		Dim dt As New DataTable
		Dim bs As New BindingSource
					If rb_categoria.Checked = True Then
						dt = cadCategorias.RetornaNomeCategoria(txt_pesquisa.Text)
						bs.DataSource = dt
						dgv_pesquisa.DataSource = bs	
						dgv_pesquisa.Columns(0).HeaderText = "CATEGORIA"
					ElseIf rb_produto.Checked = True Then
						dt = cadProdutos.RetornaNomeProduto(txt_pesquisa.Text)
						bs.DataSource = dt
						dgv_pesquisa.DataSource = bs	
						dgv_pesquisa.Columns(0).HeaderText = "PRODUTO"
					ElseIf rb_fornecedor.Checked = True
						dt = cadFornecedor.RetornaNomeFornecedor(txt_pesquisa.Text)
						bs.DataSource = dt
						dgv_pesquisa.DataSource = bs	
						dgv_pesquisa.Columns(0).HeaderText = "FORNECEDOR"	
					Else
						Exit Sub
					End If
					
			dgv_pesquisa.Columns(0).Width = 173
	End Sub
	
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
			Me.Close
	End Sub
	
	
	
	Sub FormEstoque_Shown(sender As Object, e As EventArgs)
		gb_pesquisa.Focus		
	End Sub
	
	Sub Rb_categoria_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome da Categoria"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_produto_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Produto"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_fornecedor_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Fornecedor"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_qtd_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite a Quantidade"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_ProdutoZerado_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = False
		gb_pesquisa.Text = ""
		
	End Sub
	
	Sub Rb_todos_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = False
		gb_pesquisa.Text = ""
	End Sub
	
	
	Sub FormEstoque_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1 Then
			ExibeEstoque
		End If
	End Sub
	
	Sub Txt_pesquisa_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			gb_pesquisa.Visible = False
			gb_exibirEstoque.Focus
		End If
		
		
		If e.KeyCode = Keys.Enter Then
			ExibePesquisa
		End If		
		
		If e.KeyCode = Keys.Down Then
			dgv_pesquisa.Focus
		End If
	End Sub
	
	Sub Gb_exibirEstoque_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
		If e.KeyCode = Keys.Escape Then
			dgv_Itens.Focus
		End If
	End Sub
	
	Sub Dgv_Itens_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			gb_exibirEstoque.Focus
		End If
	End Sub
	
	Sub Dgv_pesquisa_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
				If dgv_pesquisa.RowCount < 1 Then
					Exit Sub
				Else
					txt_pesquisa.Text = dgv_pesquisa.SelectedCells(0).Value.ToString
					dgv_pesquisa.DataSource = ""
					txt_pesquisa.Focus
				End If
			
		ElseIf e.KeyCode = Keys.Escape Then
			txt_pesquisa.Focus
		End If
		
		
		
	End Sub
	
End Class
