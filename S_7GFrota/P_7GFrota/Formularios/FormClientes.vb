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
Public Partial Class FormClientes
	Dim cliente As New EntClientes
	Dim CadCliente As New CadClientes
	Dim v_update As Integer '1 inserir/ 2 editar
	Dim v_Pessoa As String  'usada na sub VerificaPessoa, armazena F para pessoa fisica e J para juridica
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		DesabilitaUpdate
		
	End Sub
	
	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	Sub FormClientesKeyDown(sender As Object, e As KeyEventArgs) 'identifica o pressionamento das teclas f1 e f3
		If e.KeyCode = Keys.F1 Then  'quando f1 é pressionado a aba localicazar é acionada
			tabControl1.SelectTab(0)
			txt_Localizar.Clear
			txt_Localizar.Focus
			
			
		ElseIf e.KeyCode = Keys.F3 Then 'quando f3 é pressionado a aba cadastrar é acionada
			tabControl1.SelectTab(1)
		End If
		
		
	End Sub
	
	Sub HabilitaUpdate 'disparado quando o comando novo ou editar é acionado
		bt_novo.Visible = False
		bt_editar.Visible = False
		bt_excluir.Visible = False
		bt_salvar.Visible = True		
		
		gb_pessoa.Enabled = True
		txt_id.Enabled = True
		txt_CpfCnpj.Enabled = True
		txt_InscEstadual.Enabled = True
		txt_NomeFantasia.Enabled = True
		txt_RazaoSocial.Enabled = True
		txt_nome.Enabled = True
		txt_dataNascimento.Enabled = True
		txt_endereco.Enabled = True
		txt_complemento.Enabled = True
		txt_bairro.Enabled = True
		txt_cep.Enabled = True
		txt_cidade.Enabled = True
		txt_estado.Enabled = True
		txt_fone1.Enabled = True
		txt_fone2.Enabled = True
		txt_fone3.Enabled = True
		txt_fone4.Enabled = True
		txt_email1.Enabled = True
		txt_email2.Enabled = True
		
		txt_nome.Focus
		tabLocalizar.Enabled = False	
		
	End Sub
	
	Sub DesabilitaUpdate 'disparado quando o comando salvar é acionado
		bt_novo.Visible = True
		bt_editar.Visible = True
		bt_excluir.Visible = True
		bt_salvar.Visible = False
		
		
		txt_id.Enabled = False
		txt_CpfCnpj.Enabled = False
		txt_InscEstadual.Enabled = False
		txt_NomeFantasia.Enabled = False
		txt_RazaoSocial.Enabled = False
		txt_nome.Enabled = False
		txt_dataNascimento.Enabled = False
		txt_endereco.Enabled = False
		txt_complemento.Enabled = False
		txt_bairro.Enabled = False
		txt_cep.Enabled = False
		txt_cidade.Enabled = False
		txt_estado.Enabled = False
		txt_fone1.Enabled = False
		txt_fone2.Enabled = False
		txt_fone3.Enabled = False
		txt_fone4.Enabled = False
		txt_email1.Enabled = False
		txt_email2.Enabled = False
		rb_Fisica.Checked = False
		rb_juridica.Checked = False
		gb_pessoa.Enabled = False
		
		tabLocalizar.Enabled = True
		
	End Sub
	
	'Nessa rotina é verificado o radio button do form para atribuir o valor ao campo P_FisicaJuridica do banco de dados
	Public Sub VerificaPessoa 'usada na hora de salvar para verificar o valor de gb_pessoa se é fisica ou juridica.	
		Select Case rb_Fisica.Checked
			Case True 
				v_Pessoa = "F"
			Case False
				v_Pessoa = "J"
		End Select
	End Sub
	
	'Nessa rotina é verificado o valor do campo P_FisicaJuridica do no grid para atribuir o valor ao radio button do form
	Public Sub VerificaPessoa( strPessoa As String) 'usada para posicionar o radio buntton no form na hora que seleciona o cliente no gride
		If strPessoa = "F" Then
			rb_Fisica.Checked = True
		ElseIf strPessoa = "J" Then
			rb_juridica.Checked = True
		End If	
	End Sub
	
	
	Sub Bt_novoClick(sender As Object, e As EventArgs)
		v_update = 1
		rb_Fisica.Checked = True
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
		VerificaPessoa
		If autenticaForm = True Then	
			If v_update = 1 Then
				cliente.P_FisicaJuridica = CChar(v_Pessoa)
				cliente.CPF_CNPJ = txt_CpfCnpj.Text
				cliente.InscricaoEstadual = txt_InscEstadual.Text
				cliente.NomeFantasia = txt_NomeFantasia.Text
				cliente.RazaoSocial = txt_RazaoSocial.Text
				cliente.NomeCliente = txt_nome.Text
				cliente.DatNascimento = CDate (txt_dataNascimento.Text)
				cliente.Endereco = txt_endereco.Text
				cliente.Complemento = txt_complemento.Text
				cliente.Bairro = txt_bairro.Text
				cliente.Cep = txt_cep.Text
				cliente.Cidade = txt_cidade.Text
				cliente.Estado = txt_estado.Text
				cliente.Fone1 = txt_fone1.Text
				cliente.Fone2 = txt_fone2.Text
				cliente.Fone3 = txt_fone3.Text
				cliente.Fone4 = txt_fone4.Text
				cliente.Email1 = txt_email1.Text
				cliente.Email2 = txt_email2.Text
				CadCliente.AdicionarCliente(cliente)
				LimpaCampos
				
			ElseIf v_update = 2 Then
				cliente.IdCliente = CInt (txt_id.Text)
				cliente.P_FisicaJuridica = CChar(v_Pessoa)
				cliente.CPF_CNPJ = txt_CpfCnpj.Text
				cliente.InscricaoEstadual = txt_InscEstadual.Text
				cliente.NomeFantasia = txt_NomeFantasia.Text
				cliente.RazaoSocial = txt_RazaoSocial.Text
				cliente.NomeCliente = txt_nome.Text
				cliente.DatNascimento = CDate (txt_dataNascimento.Text)
				cliente.Endereco = txt_endereco.Text
				cliente.Complemento = txt_complemento.Text
				cliente.Bairro = txt_bairro.Text
				cliente.Cep = txt_cep.Text
				cliente.Cidade = txt_cidade.Text
				cliente.Estado = txt_estado.Text
				cliente.Fone1 = txt_fone1.Text
				cliente.Fone2 = txt_fone2.Text
				cliente.Fone3 = txt_fone3.Text
				cliente.Fone4 = txt_fone4.Text
				cliente.Email1 = txt_email1.Text
				cliente.Email2 = txt_email2.Text
				CadCliente.EditarCliente(cliente)				
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
				'Dim dr As MySqlDataReader
				
				' se precisar instanciar a classe Ent_Funcionario, não precisa digitar é so copiar essa abaixo que ja ta pronta
				'			Cliente.IdCliente = dr.GetInt32("idcliente")
				'			Cliente.P_FisicaJuridica = dr.GetChar("P_FisicaJuridica")
				'			Cliente.CPF_CNPJ = dr.GetString("cpf_cnpj")
				'			Cliente.InscricaoEstadual = dr.GetString("inscricaoEstadual")
				'			Cliente.NomeFantasia = dr.GetString("NomeFantasia")
				'			Cliente.RazaoSocial = dr.GetString("razaosocial")
				'			Cliente.NomeCliente = dr.GetString ("nomecliente")
				'			Cliente.DatNascimento = dr.GetDateTime("datnascimento")
				'			Cliente.Endereco = dr.GetString("endereco")
				'			Cliente.Complemento = dr.GetString("complemento")
				'			Cliente.Bairro = dr.GetString("bairro")
				'			Cliente.Cep = dr.GetString("cep")
				'			Cliente.Cidade = dr.GetString("cidade")
				'			Cliente.Estado = dr.GetString("estado")
				'			Cliente.Fone1 = dr.GetString("fone1")
				'			Cliente.Fone2 = dr.GetString("fone2")
				'			Cliente.Fone3 = dr.GetString("fone3")
				'			Cliente.Fone4 = dr.GetString("fone4")
				'			Cliente.Email1 = dr.GetString("email1")
				'			Cliente.Email2 = dr.GetString("email2")
				
				'o datareader tem alguns comportamentos indesejados como erro quando sql não retorna nada e não possui auto ordenação no gride
'				dr = CadCliente.LocalizarCliente(txt_Localizar.Text)
'				bs.DataSource = dr
'				dr.Close
'				dgv_Clientes.DataSource = bs
				
				ds = CadCliente.LocalizarCliente(txt_Localizar.Text)
				bs.DataSource = ds.Tables(0)
				dgv_Clientes.DataSource = bs
				
			Try		
				dgv_Clientes.Columns(0).HeaderText = "Nome Cliente"
				dgv_Clientes.Columns(1).HeaderText = "Nome Fantasia"
				dgv_Clientes.Columns(2).HeaderText = "Razão Social"
				dgv_Clientes.Columns(3).HeaderText = "Endereço"
				dgv_Clientes.Columns(4).HeaderText = "Fone1"
				dgv_Clientes.Columns(5).HeaderText = "Fone2"
				dgv_Clientes.Columns(6).HeaderText = "Email1"	
				
				dgv_Clientes.Columns(0).Visible = True
				dgv_Clientes.Columns(1).Visible = True
				dgv_Clientes.Columns(2).Visible = True
				dgv_Clientes.Columns(3).Visible = True
				dgv_Clientes.Columns(4).Visible = True
				dgv_Clientes.Columns(5).Visible = True
				dgv_Clientes.Columns(6).Visible = True
				dgv_Clientes.Columns(7).Visible = False
				dgv_Clientes.Columns(8).Visible = False
				dgv_Clientes.Columns(9).Visible = False
				dgv_Clientes.Columns(10).Visible = False
				dgv_Clientes.Columns(11).Visible = False
				dgv_Clientes.Columns(12).Visible = False
				dgv_Clientes.Columns(13).Visible = False
				dgv_Clientes.Columns(14).Visible = False
				dgv_Clientes.Columns(15).Visible = False
				dgv_Clientes.Columns(16).Visible = False
				dgv_Clientes.Columns(17).Visible = False
				dgv_Clientes.Columns(18).Visible = False
				dgv_Clientes.Columns(19).Visible = False
				
				dgv_Clientes.Columns(0).Width = 200
				dgv_Clientes.Columns(1).Width = 100
				dgv_Clientes.Columns(2).Width = 100
				dgv_Clientes.Columns(3).Width = 150
				dgv_Clientes.Columns(4).Width = 60
				dgv_Clientes.Columns(5).Width = 60
				dgv_Clientes.Columns(6).Width = 180
				
			Catch ex As MySqlException
				MsgBox("Cliente não Localizado: " + ex.Message)
				txt_Localizar.Focus
			End Try	
			
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_Clientes.Focus
		End If
	End Sub
	
	Sub Dgv_ClientesKeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
			v_Pessoa = dgv_Clientes.SelectedCells(8).Value.ToString
			VerificaPessoa(v_Pessoa)
			
			txt_id.Text = dgv_Clientes.SelectedCells(7).value.ToString
			txt_CpfCnpj.Text = dgv_Clientes.SelectedCells(9).Value.ToString	
			txt_InscEstadual.Text = dgv_Clientes.SelectedCells(10).Value.ToString	
			txt_NomeFantasia.Text = dgv_Clientes.SelectedCells(1).Value.ToString	
			txt_RazaoSocial.Text = dgv_Clientes.SelectedCells(2).Value.ToString	
			txt_nome.Text = dgv_Clientes.SelectedCells(0).Value.ToString
			'Cliente.DatNascimento = CDate (dgv_Clientes.SelectedCells(11).Value.ToString)
			'txt_dataNascimento.Text = FormatDateTime(Cliente.DatNascimento, DateFormat.ShortDate)
			txt_dataNascimento.Text = CStr(dgv_Clientes.SelectedCells(11).FormattedValue)
			txt_endereco.Text = dgv_Clientes.SelectedCells(3).Value.ToString	
			txt_complemento.Text = dgv_Clientes.SelectedCells(12).Value.ToString	
			txt_bairro.Text = dgv_Clientes.SelectedCells(13).Value.ToString	
			txt_cep.Text = dgv_Clientes.SelectedCells(14).Value.ToString	
			txt_cidade.Text = dgv_Clientes.SelectedCells(15).Value.ToString	
			txt_estado.Text = dgv_Clientes.SelectedCells(16).Value.ToString	
			txt_fone1.Text = dgv_Clientes.SelectedCells(4).Value.ToString	
			txt_fone2.Text = dgv_Clientes.SelectedCells(5).Value.ToString	
			txt_fone3.Text = dgv_Clientes.SelectedCells(17).Value.ToString	
			txt_fone4.Text = dgv_Clientes.SelectedCells(18).Value.ToString	
			txt_email1.Text = dgv_Clientes.SelectedCells(6).Value.ToString	
			txt_email2.Text = dgv_Clientes.SelectedCells(19).Value.ToString	
			
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
					CadCliente.ExcluirCliente(txt_id.Text)
					LimpaCampos
				Else
					Exit Sub
				End If		
		End If		
	End Sub
	
	Sub LimpaCampos
		txt_id.Clear
		txt_CpfCnpj.Clear
		txt_InscEstadual.Clear
		txt_NomeFantasia.Clear
		txt_RazaoSocial.Clear
		txt_nome.Clear
		txt_dataNascimento.Clear
		txt_endereco.Clear
		txt_complemento.Clear
		txt_bairro.Clear
		txt_cep.Clear
		txt_cidade.Clear
		txt_estado.Clear
		txt_fone1.Clear
		txt_fone2.Clear
		txt_fone3.Clear
		txt_fone4.Clear
		txt_email1.Clear
		txt_email2.Clear
		rb_Fisica.Checked = True
	
	End Sub
	
	
	Function autenticaForm As Boolean
		Dim Aform As Boolean = False 'true Aform ok, false objeto em branco 		
	
		If txt_nome.Text = "" Then
			MsgBox("Digite o nome do funcionario")
			txt_nome.Focus
			
		ElseIf txt_CpfCnpj.Text = "" Then
			MsgBox("Digite o Cpf ou Cnpj do cliene")
			txt_CpfCnpj.Focus
			
		ElseIf txt_NomeFantasia.Text = "" Then
			MsgBox("Digite o nome Fantasia")
			txt_NomeFantasia.Focus
			
		ElseIf txt_dataNascimento.Text = "" Then
			MsgBox("Se não for digitada uma data, o sistema atribuirá a data de hoje!")
			txt_dataNascimento.Text = FormatDateTime(Today, DateFormat.ShortDate)
			txt_dataNascimento.Focus
		Else
			Aform = True
		End If
		
		Return Aform
	End Function
	
	
	Sub FormClientes_KeyPress(sender As Object, e As KeyPressEventArgs)
		If e.KeyChar = Convert.ToChar(13) Then
			e.Handled = True
			SendKeys.Send("{TAB}")		
		End If
	End Sub
	
	
	Sub Txt_CpfCnpj_KeyPress(sender As Object, e As KeyPressEventArgs)
		If  e.KeyChar = Convert.ToChar(27) Then
			txt_nome.Focus
		End If
	End Sub
	
	Sub Txt_InscEstadual_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_CpfCnpj.Focus
		End If
	End Sub
	
	Sub Txt_NomeFantasia_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_InscEstadual.Focus
		End If
	End Sub
	
	Sub Txt_RazaoSocial_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_NomeFantasia.Focus
		End If
	End Sub
	
	Sub Txt_dataNascimento_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
		txt_RazaoSocial.Focus
		End If
	End Sub
	
	Sub Txt_endereco_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_dataNascimento.Focus
		End If
	End Sub
	
	Sub Txt_complemento_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_endereco.Focus
		End If
	End Sub
	
	Sub Txt_bairro_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_complemento.Focus
		End If
	End Sub
	
	Sub Txt_cep_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_bairro.Focus
		End If
	End Sub
	
	Sub Txt_cidade_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_cep.Focus
		End If
	End Sub
	
	Sub Txt_estado_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_cidade.Focus
		End If
	End Sub
	
	Sub Txt_fone1_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_estado.Focus
		End If
	End Sub
	
	Sub Txt_fone2_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone1.Focus
		End If
	End Sub
	
	Sub Txt_fone3_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone2.Focus
		End If
	End Sub
	
	Sub Txt_fone4_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone3.Focus
		End If
	End Sub
	
	Sub Txt_email1_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone4.Focus
		End If
	End Sub
	
	Sub Txt_email2_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_email1.Focus
		End If
	End Sub
	
	Sub FormClientes_FormClosed(sender As Object, e As FormClosedEventArgs)
		CadCliente.desconectar
	End Sub
	
	Sub FormClientes_Shown(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	Sub Dgv_Clientes_DoubleClick(sender As Object, e As EventArgs)
		v_Pessoa = dgv_Clientes.SelectedCells(8).Value.ToString
			VerificaPessoa(v_Pessoa)
			
			txt_id.Text = dgv_Clientes.SelectedCells(7).value.ToString
			txt_CpfCnpj.Text = dgv_Clientes.SelectedCells(9).Value.ToString	
			txt_InscEstadual.Text = dgv_Clientes.SelectedCells(10).Value.ToString	
			txt_NomeFantasia.Text = dgv_Clientes.SelectedCells(1).Value.ToString	
			txt_RazaoSocial.Text = dgv_Clientes.SelectedCells(2).Value.ToString	
			txt_nome.Text = dgv_Clientes.SelectedCells(0).Value.ToString
			'Cliente.DatNascimento = CDate (dgv_Clientes.SelectedCells(11).Value.ToString)
			'txt_dataNascimento.Text = FormatDateTime(Cliente.DatNascimento, DateFormat.ShortDate)
			txt_dataNascimento.Text = CStr(dgv_Clientes.SelectedCells(11).FormattedValue)
			txt_endereco.Text = dgv_Clientes.SelectedCells(3).Value.ToString	
			txt_complemento.Text = dgv_Clientes.SelectedCells(12).Value.ToString	
			txt_bairro.Text = dgv_Clientes.SelectedCells(13).Value.ToString	
			txt_cep.Text = dgv_Clientes.SelectedCells(14).Value.ToString	
			txt_cidade.Text = dgv_Clientes.SelectedCells(15).Value.ToString	
			txt_estado.Text = dgv_Clientes.SelectedCells(16).Value.ToString	
			txt_fone1.Text = dgv_Clientes.SelectedCells(4).Value.ToString	
			txt_fone2.Text = dgv_Clientes.SelectedCells(5).Value.ToString	
			txt_fone3.Text = dgv_Clientes.SelectedCells(17).Value.ToString	
			txt_fone4.Text = dgv_Clientes.SelectedCells(18).Value.ToString	
			txt_email1.Text = dgv_Clientes.SelectedCells(6).Value.ToString	
			txt_email2.Text = dgv_Clientes.SelectedCells(19).Value.ToString	
			
			dgv_Clientes.DataSource =""
			tabControl1.SelectTab(1)
	End Sub
End Class
