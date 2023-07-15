'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Public Partial Class FormFuncionario
	'Dim EF As New Ent_Funcionario	
	'Dim DF As New DAL_Funcionario
	Dim v_update As Integer '1 inserir/ 2 editar
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		DesabilitaUpdate
		'DF.Conectar
		'carregaComboFuncao
	End Sub
	
	
	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	Sub FormFuncionarioKeyDown(sender As Object, e As KeyEventArgs)
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
		
		txt_nome.ReadOnly = False
		txt_salario.ReadOnly = False
		cb_funcao.Enabled = True		
		tabLocalizar.Enabled = False		
		txt_nome.Focus
		
	End Sub
	
	Sub DesabilitaUpdate
		bt_novo.Visible = True
		bt_editar.Visible = True
		bt_excluir.Visible = True
		bt_salvar.Visible = False
		
		txt_nome.ReadOnly = True
		txt_salario.ReadOnly = True
		cb_funcao.Enabled = False
		
		tabLocalizar.Enabled = True
		
	End Sub
	
	Sub Bt_novoClick(sender As Object, e As EventArgs)
		v_update = 1
		HabilitaUpdate
		LimpaCampos
		carregaComboFuncao
		
		
	End Sub
	
	Sub Bt_editarClick(sender As Object, e As EventArgs)
		If txt_id.Text = String.Empty Then
			MsgBox("Não há dados para editar")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
			'carregaComboFuncao
			Exit Sub
			
		Else	
			v_update = 2
			HabilitaUpdate
		End If
		
	End Sub
	
	Sub Bt_salvarClick(sender As Object, e As EventArgs)

		If autenticaForm = True Then	
			If v_update = 1 Then
'				EF.NomeFuncionario = txt_nome.Text
'				EF.Salario = CDbl( txt_salario.Text)
'				EF.IdFuncao = EF.IdFuncao
'				DF.Inserir(EF)
				MsgBox("Inserido com sucesso")
				LimpaCampos
				
			ElseIf v_update = 2 Then
				SelecionaIdFuncao
'				EF.IdFuncionario = CInt(txt_id.Text)
'				EF.NomeFuncionario = txt_nome.Text
'				EF.Salario = CDbl( txt_salario.Text)
'				EF.IdFuncao = EF.IdFuncao
'				DF.Editar(EF)
				MsgBox("Alterado com sucesso")
				LimpaCampos
			End If
		Else
			Exit Sub
			
		End If
		DesabilitaUpdate
		
		
	End Sub
	
	Sub Txt_LocalizarKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
				
'			Dim dr As MySqlDataReader
'			Dim bs As New BindingSource
'			dr = DF.ListarFuncionario(txt_Localizar.Text)
'			bs.DataSource = dr
'			dr.Close
'			dgv_Clientes.DataSource = bs
			
			
			dgv_Clientes.Columns(0).HeaderText = "ID"
			dgv_Clientes.Columns(1).HeaderText = "NOME"
			dgv_Clientes.Columns(2).HeaderText = "SALÁRIO"
			dgv_Clientes.Columns(3).HeaderText = "FUNÇÃO"
			dgv_Clientes.Columns(4).HeaderText = "DEPARTAMENTO"
			
			dgv_Clientes.Columns(0).Width = 50
			dgv_Clientes.Columns(1).Width = 300
			dgv_Clientes.Columns(2).Width = 100
			dgv_Clientes.Columns(3).Width = 170
			dgv_Clientes.Columns(4).Width = 150
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_Clientes.Focus
		End If
	End Sub
	
	Sub carregaComboFuncao
'		Dim funcao As MySqlDataReader
'		funcao = DF.CarregaNomeFunção
'		While funcao.Read
'			cb_funcao.Items.Add(funcao(0))
'		End While
'		funcao.Close
		
	End Sub
	
	Sub SelecionaIdFuncao
'		Dim drId As MySqlDataReader
		
'		drId = DF.selecionaIdFuncao(cb_funcao.Text)
'		drId.Read
'		EF.IdFuncao = drId.GetInt32(0)
'		drId.Close
		
	End Sub
	
	
	Sub Cb_funcaoSelectedValueChanged(sender As Object, e As EventArgs)
		SelecionaIdFuncao
	End Sub
	
	
	Sub Dgv_FuncionariosKeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
			carregaComboFuncao
			txt_id.Text = dgv_Clientes.SelectedCells(0).value.ToString
			txt_nome.Text = dgv_Clientes.SelectedCells(1).Value.ToString
			txt_salario.Text = dgv_Clientes.SelectedCells(2).Value.ToString
			cb_funcao.Text = dgv_Clientes.SelectedCells(3).Value.ToString
			txt_departamento.Text = dgv_Clientes.SelectedCells(4).Value.ToString	
			dgv_Clientes.DataSource =""
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
'					DF.Excluir(txt_id.Text)
					LimpaCampos
					MsgBox("Exclusão bem sucedida")
				Else
					Exit Sub
				End If		
		End If		
	End Sub
	
	Sub LimpaCampos
		txt_id.Clear
		txt_nome.Clear
		txt_salario.Clear
		txt_departamento.Clear
		cb_funcao.Items.Clear
	
	End Sub
	
	
	Function autenticaForm As Boolean
		Dim Aform As Boolean = False 'true Aform ok, false objeto em branco 		
	
		If txt_nome.Text = "" Then
			MsgBox("Digite o nome do funcionario")
			txt_nome.Focus
			
		ElseIf txt_salario.Text = "" Then
			MsgBox("Digite o salário do funcionario")
			txt_salario.Focus
			
'		ElseIf cb_funcao.Text = "" Then
'			MsgBox("Escolha a função do funcionario")
'			cb_funcao.Focus
			
		Else
			Aform = True
		End If
		
		Return Aform
	End Function
	
	
	Sub Txt_salarioLeave(sender As Object, e As EventArgs)
		If  IsNumeric(txt_salario.Text) = False Then
			MsgBox("Digite um valor numerico valido")
			txt_salario.Text = ""
			txt_salario.Focus
		End If
	End Sub
End Class
