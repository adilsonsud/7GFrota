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

Public Partial Class FormFormaPagamento
	Dim FormaPagamento As New EntFormaPagamento	
	Dim CadFormaPagamento As New CadFormaPagamento
	Dim v_update As Integer '1 inserir/ 2 editar
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		DesabilitaUpdate
	End Sub
	
	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	Sub FormCategoriasKeyDown(sender As Object, e As KeyEventArgs)
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
		txt_nome.Focus
		tabLocalizar.Enabled = False	
		
	End Sub
	
	Sub DesabilitaUpdate
		bt_novo.Visible = True
		bt_editar.Visible = True
		bt_excluir.Visible = True
		bt_salvar.Visible = False
		
		txt_id.Enabled = False
		txt_nome.Enabled = False		
		tabLocalizar.Enabled = True
		
	End Sub
	
	Sub Bt_novoClick(sender As Object, e As EventArgs)
		v_update = 1
		HabilitaUpdate
		LimpaCampos		
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
			If v_update = 1 Then
				FormaPagamento.NomeFormaPagamento = txt_nome.Text
				CadFormaPagamento.AdicionarFormaPagamento(FormaPagamento)
				LimpaCampos
				
			ElseIf v_update = 2 Then
				FormaPagamento.IdFormaPagamento = CInt (txt_id.Text)
				FormaPagamento.NomeFormaPagamento = txt_nome.Text
				CadFormaPagamento.EditarFormaPagamento(FormaPagamento)			
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
			Dim dt As New DataTable
			Dim bs As New BindingSource	
			
			dt = CadFormaPagamento.LocalizarFormaPagamento(txt_Localizar.Text)
			bs.DataSource = dt
			dgv_Categorias.DataSource = bs
			
			dgv_Categorias.Columns(1).HeaderText = "FORMA DE PAGAMENTO"
			
			dgv_Categorias.Columns(0).Visible = False
			dgv_Categorias.Columns(1).Visible = True
			
			dgv_Categorias.Columns(1).Width = 300
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_Categorias.Focus
		End If
	End Sub
	
	
	Sub Dgv_CategoriasKeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
			txt_id.Text = dgv_Categorias.SelectedCells(0).Value.ToString
			txt_nome.Text = dgv_Categorias.SelectedCells(1).Value.ToString
			dgv_Categorias.DataSource =""
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
					CadFormaPagamento.ExcluirFormaPagamento(txt_id.Text)
					LimpaCampos
				Else
					Exit Sub
				End If		
		End If		
	End Sub
	
	Sub LimpaCampos
		txt_id.Clear
		txt_nome.Clear		
	End Sub
	
	
	Function autenticaForm As Boolean
		Dim Aform As Boolean = False 'true Aform ok, false objeto em branco 		
	
		If txt_nome.Text = "" Then
			MsgBox("Digite o nome da categoria")
			txt_nome.Focus
		Else
			Aform = True
		End If
		
		Return Aform
	End Function
		
	Sub FormCategorias_Shown(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	Sub FormCategorias_FormClosed(sender As Object, e As FormClosedEventArgs)
		CadFormaPagamento.desconectar
	End Sub
	
	Sub Dgv_Categorias_DoubleClick(sender As Object, e As EventArgs)
		
			txt_id.Text = dgv_Categorias.SelectedCells(0).Value.ToString
			txt_nome.Text = dgv_Categorias.SelectedCells(1).Value.ToString
			dgv_Categorias.DataSource =""
			tabControl1.SelectTab(1)	
		
	End Sub
	
End Class
