'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormClientes
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabLocalizar = New System.Windows.Forms.TabPage()
		Me.dgv_Clientes = New System.Windows.Forms.DataGridView()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_Localizar = New System.Windows.Forms.TextBox()
		Me.tabCadastrar = New System.Windows.Forms.TabPage()
		Me.tabControl2 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.gb_idcliente = New System.Windows.Forms.GroupBox()
		Me.txt_id = New System.Windows.Forms.TextBox()
		Me.gb_emdereco = New System.Windows.Forms.GroupBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.lbl_cpfCnpj = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.txt_dataNascimento = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.txt_RazaoSocial = New System.Windows.Forms.TextBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.txt_NomeFantasia = New System.Windows.Forms.TextBox()
		Me.txt_nome = New System.Windows.Forms.TextBox()
		Me.txt_InscEstadual = New System.Windows.Forms.TextBox()
		Me.txt_CpfCnpj = New System.Windows.Forms.TextBox()
		Me.gb_endereco = New System.Windows.Forms.GroupBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.txt_endereco = New System.Windows.Forms.TextBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label14 = New System.Windows.Forms.Label()
		Me.txt_complemento = New System.Windows.Forms.TextBox()
		Me.txt_estado = New System.Windows.Forms.TextBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.txt_cidade = New System.Windows.Forms.TextBox()
		Me.label12 = New System.Windows.Forms.Label()
		Me.txt_bairro = New System.Windows.Forms.TextBox()
		Me.txt_cep = New System.Windows.Forms.TextBox()
		Me.gb_Contatos = New System.Windows.Forms.GroupBox()
		Me.label20 = New System.Windows.Forms.Label()
		Me.txt_fone4 = New System.Windows.Forms.TextBox()
		Me.txt_fone1 = New System.Windows.Forms.TextBox()
		Me.label15 = New System.Windows.Forms.Label()
		Me.label19 = New System.Windows.Forms.Label()
		Me.label16 = New System.Windows.Forms.Label()
		Me.label18 = New System.Windows.Forms.Label()
		Me.txt_fone2 = New System.Windows.Forms.TextBox()
		Me.label17 = New System.Windows.Forms.Label()
		Me.txt_fone3 = New System.Windows.Forms.TextBox()
		Me.txt_email1 = New System.Windows.Forms.TextBox()
		Me.txt_email2 = New System.Windows.Forms.TextBox()
		Me.gb_pessoa = New System.Windows.Forms.GroupBox()
		Me.rb_juridica = New System.Windows.Forms.RadioButton()
		Me.rb_Fisica = New System.Windows.Forms.RadioButton()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.bt_salvar = New System.Windows.Forms.Button()
		Me.bt_excluir = New System.Windows.Forms.Button()
		Me.bt_editar = New System.Windows.Forms.Button()
		Me.bt_novo = New System.Windows.Forms.Button()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tabControl1.SuspendLayout
		Me.tabLocalizar.SuspendLayout
		CType(Me.dgv_Clientes,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.tabCadastrar.SuspendLayout
		Me.tabControl2.SuspendLayout
		Me.tabPage1.SuspendLayout
		Me.gb_idcliente.SuspendLayout
		Me.gb_emdereco.SuspendLayout
		Me.gb_endereco.SuspendLayout
		Me.gb_Contatos.SuspendLayout
		Me.gb_pessoa.SuspendLayout
		Me.panel5.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel1.SuspendLayout
		Me.SuspendLayout
		'
		'tabControl1
		'
		Me.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
		Me.tabControl1.Controls.Add(Me.tabLocalizar)
		Me.tabControl1.Controls.Add(Me.tabCadastrar)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Location = New System.Drawing.Point(0, 41)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(924, 525)
		Me.tabControl1.TabIndex = 54
		'
		'tabLocalizar
		'
		Me.tabLocalizar.Controls.Add(Me.dgv_Clientes)
		Me.tabLocalizar.Controls.Add(Me.groupBox1)
		Me.tabLocalizar.Location = New System.Drawing.Point(4, 25)
		Me.tabLocalizar.Name = "tabLocalizar"
		Me.tabLocalizar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLocalizar.Size = New System.Drawing.Size(916, 496)
		Me.tabLocalizar.TabIndex = 53
		Me.tabLocalizar.Text = "Localizar"
		Me.tabLocalizar.UseVisualStyleBackColor = true
		AddHandler Me.tabLocalizar.Enter, AddressOf Me.TabLocalizarEnter
		'
		'dgv_Clientes
		'
		Me.dgv_Clientes.AllowUserToAddRows = false
		Me.dgv_Clientes.AllowUserToDeleteRows = false
		Me.dgv_Clientes.AllowUserToOrderColumns = true
		Me.dgv_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Clientes.Location = New System.Drawing.Point(8, 78)
		Me.dgv_Clientes.MultiSelect = false
		Me.dgv_Clientes.Name = "dgv_Clientes"
		Me.dgv_Clientes.ReadOnly = true
		Me.dgv_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Clientes.Size = New System.Drawing.Size(895, 416)
		Me.dgv_Clientes.TabIndex = 52
		AddHandler Me.dgv_Clientes.DoubleClick, AddressOf Me.Dgv_Clientes_DoubleClick
		AddHandler Me.dgv_Clientes.KeyDown, AddressOf Me.Dgv_clientesKeyDown
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_Localizar)
		Me.groupBox1.Location = New System.Drawing.Point(8, 6)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(445, 66)
		Me.groupBox1.TabIndex = 51
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Digite o Nome do Cliente"
		'
		'txt_Localizar
		'
		Me.txt_Localizar.Location = New System.Drawing.Point(6, 29)
		Me.txt_Localizar.Name = "txt_Localizar"
		Me.txt_Localizar.Size = New System.Drawing.Size(381, 20)
		Me.txt_Localizar.TabIndex = 55
		AddHandler Me.txt_Localizar.KeyDown, AddressOf Me.Txt_LocalizarKeyDown
		'
		'tabCadastrar
		'
		Me.tabCadastrar.Controls.Add(Me.tabControl2)
		Me.tabCadastrar.Location = New System.Drawing.Point(4, 25)
		Me.tabCadastrar.Name = "tabCadastrar"
		Me.tabCadastrar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCadastrar.Size = New System.Drawing.Size(916, 496)
		Me.tabCadastrar.TabIndex = 50
		Me.tabCadastrar.Text = "Cadastrar"
		Me.tabCadastrar.UseVisualStyleBackColor = true
		'
		'tabControl2
		'
		Me.tabControl2.Controls.Add(Me.tabPage1)
		Me.tabControl2.Location = New System.Drawing.Point(16, 10)
		Me.tabControl2.Name = "tabControl2"
		Me.tabControl2.SelectedIndex = 0
		Me.tabControl2.Size = New System.Drawing.Size(891, 469)
		Me.tabControl2.TabIndex = 49
		'
		'tabPage1
		'
		Me.tabPage1.Controls.Add(Me.panel4)
		Me.tabPage1.Controls.Add(Me.gb_idcliente)
		Me.tabPage1.Controls.Add(Me.gb_emdereco)
		Me.tabPage1.Controls.Add(Me.gb_endereco)
		Me.tabPage1.Controls.Add(Me.gb_Contatos)
		Me.tabPage1.Controls.Add(Me.gb_pessoa)
		Me.tabPage1.Controls.Add(Me.panel5)
		Me.tabPage1.Controls.Add(Me.panel3)
		Me.tabPage1.Controls.Add(Me.bt_salvar)
		Me.tabPage1.Controls.Add(Me.bt_excluir)
		Me.tabPage1.Controls.Add(Me.bt_editar)
		Me.tabPage1.Controls.Add(Me.bt_novo)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(883, 443)
		Me.tabPage1.TabIndex = 48
		Me.tabPage1.Text = "Cliente"
		Me.tabPage1.UseVisualStyleBackColor = true
		AddHandler Me.tabPage1.Click, AddressOf Me.TabPage1_Click
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.Blue
		Me.panel4.Location = New System.Drawing.Point(11, 6)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(830, 2)
		Me.panel4.TabIndex = 47
		'
		'gb_idcliente
		'
		Me.gb_idcliente.Controls.Add(Me.txt_id)
		Me.gb_idcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_idcliente.ForeColor = System.Drawing.Color.Blue
		Me.gb_idcliente.Location = New System.Drawing.Point(26, 15)
		Me.gb_idcliente.Name = "gb_idcliente"
		Me.gb_idcliente.Size = New System.Drawing.Size(384, 50)
		Me.gb_idcliente.TabIndex = 46
		Me.gb_idcliente.TabStop = false
		Me.gb_idcliente.Text = "ID CLIENTE"
		'
		'txt_id
		'
		Me.txt_id.Location = New System.Drawing.Point(12, 22)
		Me.txt_id.Name = "txt_id"
		Me.txt_id.ReadOnly = true
		Me.txt_id.Size = New System.Drawing.Size(120, 20)
		Me.txt_id.TabIndex = 45
		'
		'gb_emdereco
		'
		Me.gb_emdereco.Controls.Add(Me.label4)
		Me.gb_emdereco.Controls.Add(Me.lbl_cpfCnpj)
		Me.gb_emdereco.Controls.Add(Me.label6)
		Me.gb_emdereco.Controls.Add(Me.label7)
		Me.gb_emdereco.Controls.Add(Me.txt_dataNascimento)
		Me.gb_emdereco.Controls.Add(Me.label8)
		Me.gb_emdereco.Controls.Add(Me.txt_RazaoSocial)
		Me.gb_emdereco.Controls.Add(Me.label5)
		Me.gb_emdereco.Controls.Add(Me.txt_NomeFantasia)
		Me.gb_emdereco.Controls.Add(Me.txt_nome)
		Me.gb_emdereco.Controls.Add(Me.txt_InscEstadual)
		Me.gb_emdereco.Controls.Add(Me.txt_CpfCnpj)
		Me.gb_emdereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_emdereco.ForeColor = System.Drawing.Color.Blue
		Me.gb_emdereco.Location = New System.Drawing.Point(26, 81)
		Me.gb_emdereco.Name = "gb_emdereco"
		Me.gb_emdereco.Size = New System.Drawing.Size(384, 185)
		Me.gb_emdereco.TabIndex = 1
		Me.gb_emdereco.TabStop = false
		Me.gb_emdereco.Text = "DADOS"
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label4.Location = New System.Drawing.Point(54, 26)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(52, 13)
		Me.label4.TabIndex = 43
		Me.label4.Text = "CLIENTE"
		'
		'lbl_cpfCnpj
		'
		Me.lbl_cpfCnpj.AutoSize = true
		Me.lbl_cpfCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_cpfCnpj.ForeColor = System.Drawing.Color.MidnightBlue
		Me.lbl_cpfCnpj.Location = New System.Drawing.Point(47, 52)
		Me.lbl_cpfCnpj.Name = "lbl_cpfCnpj"
		Me.lbl_cpfCnpj.Size = New System.Drawing.Size(59, 13)
		Me.lbl_cpfCnpj.TabIndex = 42
		Me.lbl_cpfCnpj.Text = "CPF/CNPJ"
		'
		'label6
		'
		Me.label6.AutoSize = true
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label6.Location = New System.Drawing.Point(14, 78)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(92, 13)
		Me.label6.TabIndex = 41
		Me.label6.Text = "INSC.ESTADUAL"
		'
		'label7
		'
		Me.label7.AutoSize = true
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label7.Location = New System.Drawing.Point(12, 104)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(94, 13)
		Me.label7.TabIndex = 40
		Me.label7.Text = "NOME FANTASIA"
		'
		'txt_dataNascimento
		'
		Me.txt_dataNascimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_dataNascimento.Location = New System.Drawing.Point(112, 150)
		Me.txt_dataNascimento.Name = "txt_dataNascimento"
		Me.txt_dataNascimento.Size = New System.Drawing.Size(250, 20)
		Me.txt_dataNascimento.TabIndex = 7
		AddHandler Me.txt_dataNascimento.KeyDown, AddressOf Me.Txt_dataNascimento_KeyDown
		'
		'label8
		'
		Me.label8.AutoSize = true
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label8.Location = New System.Drawing.Point(35, 153)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(71, 13)
		Me.label8.TabIndex = 39
		Me.label8.Text = "DATA NASC."
		'
		'txt_RazaoSocial
		'
		Me.txt_RazaoSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_RazaoSocial.Location = New System.Drawing.Point(112, 124)
		Me.txt_RazaoSocial.Name = "txt_RazaoSocial"
		Me.txt_RazaoSocial.Size = New System.Drawing.Size(250, 20)
		Me.txt_RazaoSocial.TabIndex = 6
		AddHandler Me.txt_RazaoSocial.KeyDown, AddressOf Me.Txt_RazaoSocial_KeyDown
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label5.Location = New System.Drawing.Point(21, 127)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(85, 13)
		Me.label5.TabIndex = 38
		Me.label5.Text = "RAZÃO SOCIAL"
		'
		'txt_NomeFantasia
		'
		Me.txt_NomeFantasia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_NomeFantasia.Location = New System.Drawing.Point(112, 98)
		Me.txt_NomeFantasia.Name = "txt_NomeFantasia"
		Me.txt_NomeFantasia.Size = New System.Drawing.Size(250, 20)
		Me.txt_NomeFantasia.TabIndex = 5
		AddHandler Me.txt_NomeFantasia.KeyDown, AddressOf Me.Txt_NomeFantasia_KeyDown
		'
		'txt_nome
		'
		Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_nome.Location = New System.Drawing.Point(112, 21)
		Me.txt_nome.Name = "txt_nome"
		Me.txt_nome.Size = New System.Drawing.Size(250, 20)
		Me.txt_nome.TabIndex = 2
		'
		'txt_InscEstadual
		'
		Me.txt_InscEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_InscEstadual.Location = New System.Drawing.Point(112, 72)
		Me.txt_InscEstadual.Name = "txt_InscEstadual"
		Me.txt_InscEstadual.Size = New System.Drawing.Size(250, 20)
		Me.txt_InscEstadual.TabIndex = 4
		AddHandler Me.txt_InscEstadual.KeyDown, AddressOf Me.Txt_InscEstadual_KeyDown
		'
		'txt_CpfCnpj
		'
		Me.txt_CpfCnpj.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_CpfCnpj.Location = New System.Drawing.Point(112, 47)
		Me.txt_CpfCnpj.Name = "txt_CpfCnpj"
		Me.txt_CpfCnpj.Size = New System.Drawing.Size(250, 20)
		Me.txt_CpfCnpj.TabIndex = 3
		AddHandler Me.txt_CpfCnpj.KeyPress, AddressOf Me.Txt_CpfCnpj_KeyPress
		'
		'gb_endereco
		'
		Me.gb_endereco.Controls.Add(Me.label9)
		Me.gb_endereco.Controls.Add(Me.txt_endereco)
		Me.gb_endereco.Controls.Add(Me.label10)
		Me.gb_endereco.Controls.Add(Me.label14)
		Me.gb_endereco.Controls.Add(Me.txt_complemento)
		Me.gb_endereco.Controls.Add(Me.txt_estado)
		Me.gb_endereco.Controls.Add(Me.label13)
		Me.gb_endereco.Controls.Add(Me.label11)
		Me.gb_endereco.Controls.Add(Me.txt_cidade)
		Me.gb_endereco.Controls.Add(Me.label12)
		Me.gb_endereco.Controls.Add(Me.txt_bairro)
		Me.gb_endereco.Controls.Add(Me.txt_cep)
		Me.gb_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_endereco.ForeColor = System.Drawing.Color.Blue
		Me.gb_endereco.Location = New System.Drawing.Point(416, 81)
		Me.gb_endereco.Name = "gb_endereco"
		Me.gb_endereco.Size = New System.Drawing.Size(381, 185)
		Me.gb_endereco.TabIndex = 1
		Me.gb_endereco.TabStop = false
		Me.gb_endereco.Text = "ENDEREÇO"
		'
		'label9
		'
		Me.label9.AutoSize = true
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label9.Location = New System.Drawing.Point(28, 30)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(67, 13)
		Me.label9.TabIndex = 36
		Me.label9.Text = "ENDEREÇO"
		'
		'txt_endereco
		'
		Me.txt_endereco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_endereco.Location = New System.Drawing.Point(110, 23)
		Me.txt_endereco.Name = "txt_endereco"
		Me.txt_endereco.Size = New System.Drawing.Size(250, 20)
		Me.txt_endereco.TabIndex = 8
		AddHandler Me.txt_endereco.KeyDown, AddressOf Me.Txt_endereco_KeyDown
		'
		'label10
		'
		Me.label10.AutoSize = true
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label10.Location = New System.Drawing.Point(6, 56)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(90, 13)
		Me.label10.TabIndex = 35
		Me.label10.Text = "COMPLEMENTO"
		'
		'label14
		'
		Me.label14.AutoSize = true
		Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label14.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label14.Location = New System.Drawing.Point(44, 159)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(51, 13)
		Me.label14.TabIndex = 34
		Me.label14.Text = "ESTADO"
		'
		'txt_complemento
		'
		Me.txt_complemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_complemento.Location = New System.Drawing.Point(110, 49)
		Me.txt_complemento.Name = "txt_complemento"
		Me.txt_complemento.Size = New System.Drawing.Size(250, 20)
		Me.txt_complemento.TabIndex = 9
		AddHandler Me.txt_complemento.KeyDown, AddressOf Me.Txt_complemento_KeyDown
		'
		'txt_estado
		'
		Me.txt_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_estado.Location = New System.Drawing.Point(110, 156)
		Me.txt_estado.Name = "txt_estado"
		Me.txt_estado.Size = New System.Drawing.Size(250, 20)
		Me.txt_estado.TabIndex = 13
		AddHandler Me.txt_estado.KeyDown, AddressOf Me.Txt_estado_KeyDown
		'
		'label13
		'
		Me.label13.AutoSize = true
		Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label13.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label13.Location = New System.Drawing.Point(48, 131)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(47, 13)
		Me.label13.TabIndex = 33
		Me.label13.Text = "CIDADE"
		'
		'label11
		'
		Me.label11.AutoSize = true
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label11.Location = New System.Drawing.Point(47, 80)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(48, 13)
		Me.label11.TabIndex = 32
		Me.label11.Text = "BAIRRO"
		'
		'txt_cidade
		'
		Me.txt_cidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_cidade.Location = New System.Drawing.Point(110, 131)
		Me.txt_cidade.Name = "txt_cidade"
		Me.txt_cidade.Size = New System.Drawing.Size(250, 20)
		Me.txt_cidade.TabIndex = 12
		AddHandler Me.txt_cidade.KeyDown, AddressOf Me.Txt_cidade_KeyDown
		'
		'label12
		'
		Me.label12.AutoSize = true
		Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label12.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label12.Location = New System.Drawing.Point(67, 108)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(28, 13)
		Me.label12.TabIndex = 31
		Me.label12.Text = "CEP"
		'
		'txt_bairro
		'
		Me.txt_bairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_bairro.Location = New System.Drawing.Point(110, 75)
		Me.txt_bairro.Name = "txt_bairro"
		Me.txt_bairro.Size = New System.Drawing.Size(250, 20)
		Me.txt_bairro.TabIndex = 10
		AddHandler Me.txt_bairro.KeyDown, AddressOf Me.Txt_bairro_KeyDown
		'
		'txt_cep
		'
		Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_cep.Location = New System.Drawing.Point(110, 101)
		Me.txt_cep.Name = "txt_cep"
		Me.txt_cep.Size = New System.Drawing.Size(250, 20)
		Me.txt_cep.TabIndex = 11
		AddHandler Me.txt_cep.KeyDown, AddressOf Me.Txt_cep_KeyDown
		'
		'gb_Contatos
		'
		Me.gb_Contatos.Controls.Add(Me.label20)
		Me.gb_Contatos.Controls.Add(Me.txt_fone4)
		Me.gb_Contatos.Controls.Add(Me.txt_fone1)
		Me.gb_Contatos.Controls.Add(Me.label15)
		Me.gb_Contatos.Controls.Add(Me.label19)
		Me.gb_Contatos.Controls.Add(Me.label16)
		Me.gb_Contatos.Controls.Add(Me.label18)
		Me.gb_Contatos.Controls.Add(Me.txt_fone2)
		Me.gb_Contatos.Controls.Add(Me.label17)
		Me.gb_Contatos.Controls.Add(Me.txt_fone3)
		Me.gb_Contatos.Controls.Add(Me.txt_email1)
		Me.gb_Contatos.Controls.Add(Me.txt_email2)
		Me.gb_Contatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_Contatos.ForeColor = System.Drawing.Color.Blue
		Me.gb_Contatos.Location = New System.Drawing.Point(26, 275)
		Me.gb_Contatos.Name = "gb_Contatos"
		Me.gb_Contatos.Size = New System.Drawing.Size(771, 110)
		Me.gb_Contatos.TabIndex = 1
		Me.gb_Contatos.TabStop = false
		Me.gb_Contatos.Text = "CONTATOS"
		'
		'label20
		'
		Me.label20.AutoSize = true
		Me.label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label20.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label20.Location = New System.Drawing.Point(578, 25)
		Me.label20.Name = "label20"
		Me.label20.Size = New System.Drawing.Size(45, 13)
		Me.label20.TabIndex = 45
		Me.label20.Text = "FONE 4"
		'
		'txt_fone4
		'
		Me.txt_fone4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone4.Location = New System.Drawing.Point(578, 41)
		Me.txt_fone4.Name = "txt_fone4"
		Me.txt_fone4.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone4.TabIndex = 17
		AddHandler Me.txt_fone4.KeyDown, AddressOf Me.Txt_fone4_KeyDown
		'
		'txt_fone1
		'
		Me.txt_fone1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone1.Location = New System.Drawing.Point(12, 41)
		Me.txt_fone1.Name = "txt_fone1"
		Me.txt_fone1.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone1.TabIndex = 14
		AddHandler Me.txt_fone1.KeyDown, AddressOf Me.Txt_fone1_KeyDown
		'
		'label15
		'
		Me.label15.AutoSize = true
		Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label15.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label15.Location = New System.Drawing.Point(12, 25)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(45, 13)
		Me.label15.TabIndex = 39
		Me.label15.Text = "FONE 1"
		'
		'label19
		'
		Me.label19.AutoSize = true
		Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label19.Location = New System.Drawing.Point(389, 90)
		Me.label19.Name = "label19"
		Me.label19.Size = New System.Drawing.Size(48, 13)
		Me.label19.TabIndex = 43
		Me.label19.Text = "EMAIL 2"
		'
		'label16
		'
		Me.label16.AutoSize = true
		Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label16.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label16.Location = New System.Drawing.Point(203, 25)
		Me.label16.Name = "label16"
		Me.label16.Size = New System.Drawing.Size(45, 13)
		Me.label16.TabIndex = 40
		Me.label16.Text = "FONE 2"
		'
		'label18
		'
		Me.label18.AutoSize = true
		Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label18.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label18.Location = New System.Drawing.Point(12, 90)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(48, 13)
		Me.label18.TabIndex = 42
		Me.label18.Text = "EMAIL 1"
		'
		'txt_fone2
		'
		Me.txt_fone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone2.Location = New System.Drawing.Point(201, 41)
		Me.txt_fone2.Name = "txt_fone2"
		Me.txt_fone2.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone2.TabIndex = 15
		AddHandler Me.txt_fone2.KeyDown, AddressOf Me.Txt_fone2_KeyDown
		'
		'label17
		'
		Me.label17.AutoSize = true
		Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label17.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label17.Location = New System.Drawing.Point(390, 25)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(45, 13)
		Me.label17.TabIndex = 41
		Me.label17.Text = "FONE 3"
		'
		'txt_fone3
		'
		Me.txt_fone3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_fone3.Location = New System.Drawing.Point(390, 41)
		Me.txt_fone3.Name = "txt_fone3"
		Me.txt_fone3.Size = New System.Drawing.Size(185, 20)
		Me.txt_fone3.TabIndex = 16
		AddHandler Me.txt_fone3.KeyDown, AddressOf Me.Txt_fone3_KeyDown
		'
		'txt_email1
		'
		Me.txt_email1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_email1.Location = New System.Drawing.Point(12, 67)
		Me.txt_email1.Name = "txt_email1"
		Me.txt_email1.Size = New System.Drawing.Size(374, 20)
		Me.txt_email1.TabIndex = 18
		AddHandler Me.txt_email1.KeyDown, AddressOf Me.Txt_email1_KeyDown
		'
		'txt_email2
		'
		Me.txt_email2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_email2.Location = New System.Drawing.Point(389, 67)
		Me.txt_email2.Name = "txt_email2"
		Me.txt_email2.Size = New System.Drawing.Size(374, 20)
		Me.txt_email2.TabIndex = 19
		AddHandler Me.txt_email2.KeyDown, AddressOf Me.Txt_email2_KeyDown
		'
		'gb_pessoa
		'
		Me.gb_pessoa.Controls.Add(Me.rb_juridica)
		Me.gb_pessoa.Controls.Add(Me.rb_Fisica)
		Me.gb_pessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gb_pessoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_pessoa.ForeColor = System.Drawing.Color.Blue
		Me.gb_pessoa.Location = New System.Drawing.Point(416, 15)
		Me.gb_pessoa.Name = "gb_pessoa"
		Me.gb_pessoa.Size = New System.Drawing.Size(381, 50)
		Me.gb_pessoa.TabIndex = 1
		Me.gb_pessoa.TabStop = false
		Me.gb_pessoa.Text = "PESSOA"
		'
		'rb_juridica
		'
		Me.rb_juridica.AutoSize = true
		Me.rb_juridica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rb_juridica.Location = New System.Drawing.Point(151, 25)
		Me.rb_juridica.Name = "rb_juridica"
		Me.rb_juridica.Size = New System.Drawing.Size(69, 17)
		Me.rb_juridica.TabIndex = 1
		Me.rb_juridica.Text = "Juridica"
		Me.rb_juridica.UseVisualStyleBackColor = true
		'
		'rb_Fisica
		'
		Me.rb_Fisica.AutoSize = true
		Me.rb_Fisica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rb_Fisica.ForeColor = System.Drawing.Color.Blue
		Me.rb_Fisica.Location = New System.Drawing.Point(16, 25)
		Me.rb_Fisica.Name = "rb_Fisica"
		Me.rb_Fisica.Size = New System.Drawing.Size(60, 17)
		Me.rb_Fisica.TabIndex = 0
		Me.rb_Fisica.Text = "Física"
		Me.rb_Fisica.UseVisualStyleBackColor = true
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.Blue
		Me.panel5.Controls.Add(Me.panel6)
		Me.panel5.Location = New System.Drawing.Point(10, 394)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(830, 2)
		Me.panel5.TabIndex = 60
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel6.Location = New System.Drawing.Point(0, 159)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(705, 1)
		Me.panel6.TabIndex = 61
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.Blue
		Me.panel3.Location = New System.Drawing.Point(10, 73)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(830, 2)
		Me.panel3.TabIndex = 62
		'
		'bt_salvar
		'
		Me.bt_salvar.BackColor = System.Drawing.Color.MidnightBlue
		Me.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_salvar.ForeColor = System.Drawing.Color.White
		Me.bt_salvar.Location = New System.Drawing.Point(46, 410)
		Me.bt_salvar.Name = "bt_salvar"
		Me.bt_salvar.Size = New System.Drawing.Size(98, 23)
		Me.bt_salvar.TabIndex = 20
		Me.bt_salvar.Text = "&Salvar"
		Me.bt_salvar.UseVisualStyleBackColor = false
		Me.bt_salvar.Visible = false
		AddHandler Me.bt_salvar.Click, AddressOf Me.Bt_salvarClick
		'
		'bt_excluir
		'
		Me.bt_excluir.BackColor = System.Drawing.Color.MidnightBlue
		Me.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_excluir.ForeColor = System.Drawing.Color.White
		Me.bt_excluir.Location = New System.Drawing.Point(177, 410)
		Me.bt_excluir.Name = "bt_excluir"
		Me.bt_excluir.Size = New System.Drawing.Size(75, 23)
		Me.bt_excluir.TabIndex = 66
		Me.bt_excluir.Text = "E&xcluir"
		Me.bt_excluir.UseVisualStyleBackColor = false
		AddHandler Me.bt_excluir.Click, AddressOf Me.Bt_excluirClick
		'
		'bt_editar
		'
		Me.bt_editar.BackColor = System.Drawing.Color.MidnightBlue
		Me.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_editar.ForeColor = System.Drawing.Color.White
		Me.bt_editar.Location = New System.Drawing.Point(101, 410)
		Me.bt_editar.Name = "bt_editar"
		Me.bt_editar.Size = New System.Drawing.Size(75, 23)
		Me.bt_editar.TabIndex = 64
		Me.bt_editar.Text = "&Editar"
		Me.bt_editar.UseVisualStyleBackColor = false
		AddHandler Me.bt_editar.Click, AddressOf Me.Bt_editarClick
		'
		'bt_novo
		'
		Me.bt_novo.BackColor = System.Drawing.Color.MidnightBlue
		Me.bt_novo.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_novo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_novo.ForeColor = System.Drawing.Color.White
		Me.bt_novo.Location = New System.Drawing.Point(25, 410)
		Me.bt_novo.Name = "bt_novo"
		Me.bt_novo.Size = New System.Drawing.Size(75, 23)
		Me.bt_novo.TabIndex = 65
		Me.bt_novo.Text = "&Novo"
		Me.bt_novo.UseVisualStyleBackColor = false
		AddHandler Me.bt_novo.Click, AddressOf Me.Bt_novoClick
		'
		'bt_fechar
		'
		Me.bt_fechar.BackColor = System.Drawing.Color.MidnightBlue
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
		Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bt_fechar.ForeColor = System.Drawing.Color.White
		Me.bt_fechar.Location = New System.Drawing.Point(832, 6)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(75, 28)
		Me.bt_fechar.TabIndex = 20
		Me.bt_fechar.Text = "&Fechar"
		Me.bt_fechar.UseVisualStyleBackColor = false
		AddHandler Me.bt_fechar.Click, AddressOf Me.Bt_fecharClick
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel2.Controls.Add(Me.bt_fechar)
		Me.panel2.Controls.Add(Me.label2)
		Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel2.Location = New System.Drawing.Point(0, 566)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(924, 39)
		Me.panel2.TabIndex = 20
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.White
		Me.label2.Location = New System.Drawing.Point(12, 11)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(214, 18)
		Me.label2.TabIndex = 68
		Me.label2.Text = "F1 Localizar / F3 Cadastrar"
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.White
		Me.label1.Location = New System.Drawing.Point(12, 8)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(271, 24)
		Me.label1.TabIndex = 69
		Me.label1.Text = "CADASTRO DE CLIENTES"
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(924, 41)
		Me.panel1.TabIndex = 70
		'
		'FormClientes
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(924, 605)
		Me.Controls.Add(Me.tabControl1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.panel2)
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormClientes"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "CLIENTES"
		AddHandler FormClosed, AddressOf Me.FormClientes_FormClosed
		AddHandler Shown, AddressOf Me.FormClientes_Shown
		AddHandler KeyDown, AddressOf Me.FormClientesKeyDown
		AddHandler KeyPress, AddressOf Me.FormClientes_KeyPress
		Me.tabControl1.ResumeLayout(false)
		Me.tabLocalizar.ResumeLayout(false)
		CType(Me.dgv_Clientes,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.tabCadastrar.ResumeLayout(false)
		Me.tabControl2.ResumeLayout(false)
		Me.tabPage1.ResumeLayout(false)
		Me.gb_idcliente.ResumeLayout(false)
		Me.gb_idcliente.PerformLayout
		Me.gb_emdereco.ResumeLayout(false)
		Me.gb_emdereco.PerformLayout
		Me.gb_endereco.ResumeLayout(false)
		Me.gb_endereco.PerformLayout
		Me.gb_Contatos.ResumeLayout(false)
		Me.gb_Contatos.PerformLayout
		Me.gb_pessoa.ResumeLayout(false)
		Me.gb_pessoa.PerformLayout
		Me.panel5.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private gb_idcliente As System.Windows.Forms.GroupBox
	Private txt_fone4 As System.Windows.Forms.TextBox
	Private label20 As System.Windows.Forms.Label
	Private gb_emdereco As System.Windows.Forms.GroupBox
	Private gb_Contatos As System.Windows.Forms.GroupBox
	Private gb_endereco As System.Windows.Forms.GroupBox
	Private txt_InscEstadual As System.Windows.Forms.TextBox
	Private txt_NomeFantasia As System.Windows.Forms.TextBox
	Private txt_RazaoSocial As System.Windows.Forms.TextBox
	Private txt_dataNascimento As System.Windows.Forms.TextBox
	Private txt_endereco As System.Windows.Forms.TextBox
	Private txt_complemento As System.Windows.Forms.TextBox
	Private txt_bairro As System.Windows.Forms.TextBox
	Private txt_cep As System.Windows.Forms.TextBox
	Private txt_estado As System.Windows.Forms.TextBox
	Private txt_fone1 As System.Windows.Forms.TextBox
	Private txt_fone2 As System.Windows.Forms.TextBox
	Private txt_fone3 As System.Windows.Forms.TextBox
	Private txt_email1 As System.Windows.Forms.TextBox
	Private txt_email2 As System.Windows.Forms.TextBox
	Private txt_cidade As System.Windows.Forms.TextBox
	Private label5 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private label13 As System.Windows.Forms.Label
	Private label14 As System.Windows.Forms.Label
	Private label15 As System.Windows.Forms.Label
	Private label16 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private label18 As System.Windows.Forms.Label
	Private label19 As System.Windows.Forms.Label
	Private rb_Fisica As System.Windows.Forms.RadioButton
	Private rb_juridica As System.Windows.Forms.RadioButton
	Private gb_pessoa As System.Windows.Forms.GroupBox
	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel4 As System.Windows.Forms.Panel
	Private panel6 As System.Windows.Forms.Panel
	Private panel5 As System.Windows.Forms.Panel
	Private panel3 As System.Windows.Forms.Panel
	Private bt_novo As System.Windows.Forms.Button
	Private bt_editar As System.Windows.Forms.Button
	Private bt_excluir As System.Windows.Forms.Button
	Private bt_salvar As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Private lbl_cpfCnpj As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private txt_id As System.Windows.Forms.TextBox
	Private txt_nome As System.Windows.Forms.TextBox
	Private txt_CpfCnpj As System.Windows.Forms.TextBox
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabControl2 As System.Windows.Forms.TabControl
	Private txt_Localizar As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private dgv_Clientes As System.Windows.Forms.DataGridView
	Private label2 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private bt_fechar As System.Windows.Forms.Button
	Private tabCadastrar As System.Windows.Forms.TabPage
	Private tabLocalizar As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
	
	Sub TabPage1_Click(sender As Object, e As EventArgs)
		
	End Sub
	

End Class
