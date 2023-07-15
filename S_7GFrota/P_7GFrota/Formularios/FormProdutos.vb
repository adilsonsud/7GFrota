'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data

Public Partial Class FormProdutos
	Dim produto As New EntProdutos
	Dim CadProduto As New CadProdutos
	Dim v_update As Integer '1 inserir/ 2 editar
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		DesabilitaUpdate
	End Sub
	
	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	Sub FormProdutosKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1 Then
			tabControl1.SelectTab(0)
			txt_Localizar.Clear
			txt_Localizar.Focus	
		ElseIf e.KeyCode = Keys.F3 Then
			tabControl1.SelectTab(1)
		End If
	End Sub
	
	Sub HabilitaUpdate
		bt_novo.Visible = False
		bt_editar.Visible = False
		bt_excluir.Visible = False
		bt_salvar.Visible = True		
		
		txt_id.Enabled = True
		txt_nome.Enabled = True
		cb_Categoria.Enabled = True
		txt_nome.Focus
		tabLocalizar.Enabled = False	
		
	End Sub
	
	Sub DesabilitaUpdate
		bt_novo.Visible = True
		bt_editar.Visible = True
		bt_excluir.Visible = True
		bt_salvar.Visible = False
		cb_Categoria.Enabled = False
		txt_id.Enabled = False
		txt_nome.Enabled = False	
			
		tabLocalizar.Enabled = True
		
	End Sub
	
	Sub Bt_novoClick(sender As Object, e As EventArgs)
		v_update = 1
		HabilitaUpdate
		LimpaCampos		
		carregaCb_categoria
	End Sub
	
	Sub Bt_editarClick(sender As Object, e As EventArgs)
		If txt_id.Text = String.Empty Then
			MsgBox("Não há dados para editar")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
			
			Exit Sub	
		Else	
			v_update = 2
			HabilitaUpdate
		End If	
	End Sub
	
	
	Sub Bt_salvarClick(sender As Object, e As EventArgs)
		
		If autenticaForm = True Then	
			SelecionaIdCategoria
			If v_update = 1 Then
				produto.NomeProduto = txt_nome.Text
				produto.IdCategoria = produto.IdCategoria
				CadProduto.AdicionarProduto(produto)
				LimpaCampos
				
			ElseIf v_update = 2 Then
				produto.IdProduto = CInt (txt_id.Text)
				produto.NomeProduto = txt_nome.Text
				produto.IdCategoria = produto.IdCategoria
				CadProduto.EditarProduto(produto)			
				LimpaCampos
			End If
		Else
			Exit Sub
			
		End If
		DesabilitaUpdate
		bt_fechar.Focus
		
	End Sub
	
	Sub Txt_LocalizarKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			Dim ds As New Dataset
			Dim bs As New BindingSource	
			
			ds = CadProduto.LocalizarProduto(txt_Localizar.Text)
			bs.DataSource = ds.Tables(0)
			
			dgv_Produtos.DataSource = bs
			
			dgv_Produtos.Columns(0).HeaderText = "NOME PRODUTO"
			dgv_Produtos.Columns(1).HeaderText = "CATEGORIA"
			
			dgv_Produtos.Columns(0).Visible = True
			dgv_Produtos.Columns(1).Visible = True
			dgv_Produtos.Columns(2).Visible = False
			dgv_Produtos.Columns(3).Visible = False
			
			dgv_Produtos.Columns(0).Width = 200
			dgv_Produtos.Columns(1).Width = 200
			
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_Produtos.Focus
		End If
	End Sub
	
	
	Sub Dgv_ProdutosKeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
			carregaCb_categoria
			txt_id.Text = dgv_Produtos.SelectedCells(2).Value.ToString
			txt_nome.Text = dgv_Produtos.SelectedCells(0).Value.ToString
			cb_Categoria.Text = dgv_Produtos.SelectedCells(1).Value.ToString
			
			dgv_Produtos.DataSource =""
			tabControl1.SelectTab(1)	
		End If
		
	End Sub
	
	Sub TabLocalizarEnter(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	
	Sub Bt_excluirClick(sender As Object, e As EventArgs)
		
		If txt_id.Text = String.Empty Then
			MsgBox("Não há dados para excluir")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
			Exit Sub
		
		Else
				If MsgBox("Confirme a exclusão!",vbYesNo , "Excluir")= vbYes Then
					CadProduto.ExcluirProduto(txt_id.Text)
					LimpaCampos
				Else
					Exit Sub
				End If		
		End If		
	End Sub
	
	Sub LimpaCampos
		txt_id.Clear
		txt_nome.Clear	
		cb_Categoria.Items.Clear
	End Sub
	
	'chama a sub carregaNomeCategoria na classe cadProdutos e armazena no dataReader
	'Objetivo, preencher o combo categoria
	Sub carregaCb_categoria
		Dim categoria As MySqlDataReader
		
		categoria = CadProduto.CarregaNomeCategoria
		While categoria.Read
			cb_Categoria.Items.Add(categoria(0))
		End While
		categoria.Close	
	End Sub
	
	'chama a sub selecionaIdCategoria na classe cadProdutos para selecionar o idCategoria
	'objetivo, armazenar o idcategoria na tabela produtos, de acordo com a categoria selecionada no combo
	Sub SelecionaIdCategoria
		Dim drId As MySqlDataReader
		
		drId = CadProduto.selecionaIdCategoria(cb_Categoria.Text)
		drId.Read
		produto.IdCategoria = drId.GetInt32(0)
		drId.Close
		
	End Sub
	
	
	Function autenticaForm As Boolean
		Dim Aform As Boolean = False 'true Aform ok, false objeto em branco 		
	
	If txt_nome.Text = "" Then
			MsgBox("Digite o nome do Produto")
			txt_nome.Focus
		ElseIf cb_Categoria.Text = "" Then
			MsgBox("Digite o nome da Categoria")
			cb_Categoria.Focus
		Else
			Aform = True
		End If
		
		Return Aform
	End Function
	
	
	Sub FormProdutos_KeyPress(sender As Object, e As KeyPressEventArgs)
		If e.KeyChar = Convert.ToChar(13) Then
			e.Handled = True
			SendKeys.Send("{TAB}")		
		End If
	End Sub
	
	
	Sub Cb_Categoria_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_nome.Focus
		End If
	End Sub
	
	Sub Bt_salvar_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode= Keys.Escape Then
			cb_Categoria.Focus 
		End If
	End Sub
	
	Sub FormProdutos_Shown(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	Sub FormProdutos_FormClosed(sender As Object, e As FormClosedEventArgs)
		CadProduto.desconectar
	End Sub
	
	Sub Dgv_Produtos_DoubleClick(sender As Object, e As EventArgs)
			carregaCb_categoria
			txt_id.Text = dgv_Produtos.SelectedCells(2).Value.ToString
			txt_nome.Text = dgv_Produtos.SelectedCells(0).Value.ToString
			cb_Categoria.Text = dgv_Produtos.SelectedCells(1).Value.ToString
			
			dgv_Produtos.DataSource =""
			tabControl1.SelectTab(1)	
	End Sub
End Class
