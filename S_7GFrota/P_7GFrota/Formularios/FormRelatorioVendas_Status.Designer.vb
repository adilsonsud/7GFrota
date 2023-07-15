'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormRelatorioVendas_Status
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelatorioVendas_Status))
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.lbl_rodape = New System.Windows.Forms.Label()
		Me.pnl_principal = New System.Windows.Forms.Panel()
		Me.pnl_lateral = New System.Windows.Forms.Panel()
		Me.gb_status = New System.Windows.Forms.GroupBox()
		Me.radioButton2 = New System.Windows.Forms.RadioButton()
		Me.rb_Aberta = New System.Windows.Forms.RadioButton()
		Me.gb_Periodo = New System.Windows.Forms.GroupBox()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.txt_data2 = New System.Windows.Forms.TextBox()
		Me.txt_data1 = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.bt_imprimir = New System.Windows.Forms.Button()
		Me.gb_vendas = New System.Windows.Forms.GroupBox()
		Me.pnl_Itens = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.gb_itens = New System.Windows.Forms.GroupBox()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.lbl_status = New System.Windows.Forms.Label()
		Me.lbl_troco = New System.Windows.Forms.Label()
		Me.lbl_pago = New System.Windows.Forms.Label()
		Me.lbl_pagamento = New System.Windows.Forms.Label()
		Me.lbl_total = New System.Windows.Forms.Label()
		Me.lbl_Desconto = New System.Windows.Forms.Label()
		Me.lbl_idvenda = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.dgv_Itens = New System.Windows.Forms.DataGridView()
		Me.dgv_vendas = New System.Windows.Forms.DataGridView()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.lbl_cliente = New System.Windows.Forms.Label()
		Me.lbl_data = New System.Windows.Forms.Label()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.pnl_principal.SuspendLayout
		Me.pnl_lateral.SuspendLayout
		Me.gb_status.SuspendLayout
		Me.gb_Periodo.SuspendLayout
		Me.gb_vendas.SuspendLayout
		Me.pnl_Itens.SuspendLayout
		Me.panel3.SuspendLayout
		Me.gb_itens.SuspendLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dgv_vendas,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.Black
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(1371, 49)
		Me.panel1.TabIndex = 0
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Verdana", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.White
		Me.label1.Location = New System.Drawing.Point(12, 5)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(538, 38)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Relatório de Status da Venda"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.Black
		Me.panel2.Controls.Add(Me.bt_fechar)
		Me.panel2.Controls.Add(Me.lbl_rodape)
		Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel2.Location = New System.Drawing.Point(0, 709)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(1371, 42)
		Me.panel2.TabIndex = 1
		'
		'bt_fechar
		'
		Me.bt_fechar.BackColor = System.Drawing.Color.Black
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_fechar.ForeColor = System.Drawing.Color.White
		Me.bt_fechar.Location = New System.Drawing.Point(1284, 13)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(75, 23)
		Me.bt_fechar.TabIndex = 1
		Me.bt_fechar.Text = "&Fechar"
		Me.bt_fechar.UseVisualStyleBackColor = false
		AddHandler Me.bt_fechar.Click, AddressOf Me.Bt_fechar_Click
		'
		'lbl_rodape
		'
		Me.lbl_rodape.AutoSize = true
		Me.lbl_rodape.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_rodape.ForeColor = System.Drawing.Color.White
		Me.lbl_rodape.Location = New System.Drawing.Point(9, 16)
		Me.lbl_rodape.Name = "lbl_rodape"
		Me.lbl_rodape.Size = New System.Drawing.Size(343, 18)
		Me.lbl_rodape.TabIndex = 0
		Me.lbl_rodape.Text = "F1 - Exibir Venda / F3 - Exibir Itens da Venda"
		'
		'pnl_principal
		'
		Me.pnl_principal.BackColor = System.Drawing.Color.Black
		Me.pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_principal.Controls.Add(Me.pnl_lateral)
		Me.pnl_principal.Controls.Add(Me.gb_vendas)
		Me.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl_principal.Location = New System.Drawing.Point(0, 49)
		Me.pnl_principal.Name = "pnl_principal"
		Me.pnl_principal.Size = New System.Drawing.Size(1371, 660)
		Me.pnl_principal.TabIndex = 2
		'
		'pnl_lateral
		'
		Me.pnl_lateral.BackColor = System.Drawing.Color.Black
		Me.pnl_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_lateral.Controls.Add(Me.gb_status)
		Me.pnl_lateral.Controls.Add(Me.gb_Periodo)
		Me.pnl_lateral.Controls.Add(Me.bt_imprimir)
		Me.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Left
		Me.pnl_lateral.Location = New System.Drawing.Point(0, 0)
		Me.pnl_lateral.Name = "pnl_lateral"
		Me.pnl_lateral.Size = New System.Drawing.Size(209, 656)
		Me.pnl_lateral.TabIndex = 3
		'
		'gb_status
		'
		Me.gb_status.Controls.Add(Me.radioButton2)
		Me.gb_status.Controls.Add(Me.rb_Aberta)
		Me.gb_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_status.ForeColor = System.Drawing.Color.White
		Me.gb_status.Location = New System.Drawing.Point(8, 96)
		Me.gb_status.Name = "gb_status"
		Me.gb_status.Size = New System.Drawing.Size(188, 54)
		Me.gb_status.TabIndex = 14
		Me.gb_status.TabStop = false
		Me.gb_status.Text = "Exibir Status Por:"
		'
		'radioButton2
		'
		Me.radioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.radioButton2.Location = New System.Drawing.Point(106, 24)
		Me.radioButton2.Name = "radioButton2"
		Me.radioButton2.Size = New System.Drawing.Size(74, 24)
		Me.radioButton2.TabIndex = 1
		Me.radioButton2.Text = "Fechada"
		Me.radioButton2.UseVisualStyleBackColor = true
		'
		'rb_Aberta
		'
		Me.rb_Aberta.Checked = true
		Me.rb_Aberta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rb_Aberta.Location = New System.Drawing.Point(12, 24)
		Me.rb_Aberta.Name = "rb_Aberta"
		Me.rb_Aberta.Size = New System.Drawing.Size(74, 24)
		Me.rb_Aberta.TabIndex = 0
		Me.rb_Aberta.TabStop = true
		Me.rb_Aberta.Text = "Aberta"
		Me.rb_Aberta.UseVisualStyleBackColor = true
		'
		'gb_Periodo
		'
		Me.gb_Periodo.Controls.Add(Me.dateTimePicker1)
		Me.gb_Periodo.Controls.Add(Me.dateTimePicker2)
		Me.gb_Periodo.Controls.Add(Me.txt_data2)
		Me.gb_Periodo.Controls.Add(Me.txt_data1)
		Me.gb_Periodo.Controls.Add(Me.label3)
		Me.gb_Periodo.Controls.Add(Me.label2)
		Me.gb_Periodo.ForeColor = System.Drawing.Color.White
		Me.gb_Periodo.Location = New System.Drawing.Point(7, 5)
		Me.gb_Periodo.Name = "gb_Periodo"
		Me.gb_Periodo.Size = New System.Drawing.Size(190, 83)
		Me.gb_Periodo.TabIndex = 10
		Me.gb_Periodo.TabStop = false
		Me.gb_Periodo.Text = "Escolha o Período "
		'
		'dateTimePicker1
		'
		Me.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White
		Me.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White
		Me.dateTimePicker1.CustomFormat = ""
		Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dateTimePicker1.Location = New System.Drawing.Point(164, 19)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(19, 20)
		Me.dateTimePicker1.TabIndex = 8
		AddHandler Me.dateTimePicker1.ValueChanged, AddressOf Me.DateTimePicker1_ValueChanged
		'
		'dateTimePicker2
		'
		Me.dateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.White
		Me.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.dateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.White
		Me.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker2.Location = New System.Drawing.Point(164, 48)
		Me.dateTimePicker2.Name = "dateTimePicker2"
		Me.dateTimePicker2.Size = New System.Drawing.Size(19, 20)
		Me.dateTimePicker2.TabIndex = 12
		AddHandler Me.dateTimePicker2.ValueChanged, AddressOf Me.DateTimePicker2_ValueChanged
		'
		'txt_data2
		'
		Me.txt_data2.BackColor = System.Drawing.Color.Black
		Me.txt_data2.ForeColor = System.Drawing.Color.White
		Me.txt_data2.Location = New System.Drawing.Point(69, 48)
		Me.txt_data2.Name = "txt_data2"
		Me.txt_data2.ReadOnly = true
		Me.txt_data2.Size = New System.Drawing.Size(100, 20)
		Me.txt_data2.TabIndex = 16
		'
		'txt_data1
		'
		Me.txt_data1.BackColor = System.Drawing.Color.Black
		Me.txt_data1.ForeColor = System.Drawing.Color.White
		Me.txt_data1.Location = New System.Drawing.Point(70, 19)
		Me.txt_data1.Name = "txt_data1"
		Me.txt_data1.ReadOnly = true
		Me.txt_data1.Size = New System.Drawing.Size(100, 20)
		Me.txt_data1.TabIndex = 15
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(8, 53)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(55, 13)
		Me.label3.TabIndex = 11
		Me.label3.Text = "Data Final"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(8, 23)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(60, 13)
		Me.label2.TabIndex = 10
		Me.label2.Text = "Data Inicial"
		'
		'bt_imprimir
		'
		Me.bt_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.bt_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
		Me.bt_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_imprimir.ForeColor = System.Drawing.Color.White
		Me.bt_imprimir.Image = CType(resources.GetObject("bt_imprimir.Image"),System.Drawing.Image)
		Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.bt_imprimir.Location = New System.Drawing.Point(8, 161)
		Me.bt_imprimir.Name = "bt_imprimir"
		Me.bt_imprimir.Size = New System.Drawing.Size(187, 39)
		Me.bt_imprimir.TabIndex = 7
		Me.bt_imprimir.Text = "&Imprimir Informações"
		Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.toolTip1.SetToolTip(Me.bt_imprimir, "Imprimir Relatório")
		Me.bt_imprimir.UseVisualStyleBackColor = true
		'
		'gb_vendas
		'
		Me.gb_vendas.BackColor = System.Drawing.Color.Black
		Me.gb_vendas.Controls.Add(Me.pnl_Itens)
		Me.gb_vendas.Controls.Add(Me.dgv_vendas)
		Me.gb_vendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_vendas.ForeColor = System.Drawing.Color.White
		Me.gb_vendas.Location = New System.Drawing.Point(216, 5)
		Me.gb_vendas.Name = "gb_vendas"
		Me.gb_vendas.Size = New System.Drawing.Size(1141, 647)
		Me.gb_vendas.TabIndex = 6
		Me.gb_vendas.TabStop = false
		Me.gb_vendas.Text = "INFORMAÇÕES DA VENDA"
		'
		'pnl_Itens
		'
		Me.pnl_Itens.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.pnl_Itens.Controls.Add(Me.panel3)
		Me.pnl_Itens.Location = New System.Drawing.Point(10, 19)
		Me.pnl_Itens.Name = "pnl_Itens"
		Me.pnl_Itens.Size = New System.Drawing.Size(1121, 571)
		Me.pnl_Itens.TabIndex = 7
		Me.pnl_Itens.Visible = false
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.Black
		Me.panel3.Controls.Add(Me.gb_itens)
		Me.panel3.Location = New System.Drawing.Point(6, 6)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(1108, 560)
		Me.panel3.TabIndex = 0
		'
		'gb_itens
		'
		Me.gb_itens.BackColor = System.Drawing.Color.Black
		Me.gb_itens.Controls.Add(Me.panel4)
		Me.gb_itens.Controls.Add(Me.lbl_status)
		Me.gb_itens.Controls.Add(Me.lbl_troco)
		Me.gb_itens.Controls.Add(Me.lbl_data)
		Me.gb_itens.Controls.Add(Me.lbl_pago)
		Me.gb_itens.Controls.Add(Me.lbl_pagamento)
		Me.gb_itens.Controls.Add(Me.lbl_total)
		Me.gb_itens.Controls.Add(Me.lbl_cliente)
		Me.gb_itens.Controls.Add(Me.lbl_Desconto)
		Me.gb_itens.Controls.Add(Me.lbl_idvenda)
		Me.gb_itens.Controls.Add(Me.label9)
		Me.gb_itens.Controls.Add(Me.label10)
		Me.gb_itens.Controls.Add(Me.label11)
		Me.gb_itens.Controls.Add(Me.label12)
		Me.gb_itens.Controls.Add(Me.label8)
		Me.gb_itens.Controls.Add(Me.label7)
		Me.gb_itens.Controls.Add(Me.label6)
		Me.gb_itens.Controls.Add(Me.label5)
		Me.gb_itens.Controls.Add(Me.label4)
		Me.gb_itens.Controls.Add(Me.dgv_Itens)
		Me.gb_itens.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_itens.ForeColor = System.Drawing.Color.White
		Me.gb_itens.Location = New System.Drawing.Point(5, 0)
		Me.gb_itens.Name = "gb_itens"
		Me.gb_itens.Size = New System.Drawing.Size(1093, 554)
		Me.gb_itens.TabIndex = 15
		Me.gb_itens.TabStop = false
		Me.gb_itens.Text = "Itens da Venda"
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panel4.Location = New System.Drawing.Point(9, 73)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(1073, 2)
		Me.panel4.TabIndex = 26
		'
		'lbl_status
		'
		Me.lbl_status.AutoSize = true
		Me.lbl_status.Location = New System.Drawing.Point(972, 27)
		Me.lbl_status.Name = "lbl_status"
		Me.lbl_status.Size = New System.Drawing.Size(0, 13)
		Me.lbl_status.TabIndex = 25
		'
		'lbl_troco
		'
		Me.lbl_troco.AutoSize = true
		Me.lbl_troco.Location = New System.Drawing.Point(800, 54)
		Me.lbl_troco.Name = "lbl_troco"
		Me.lbl_troco.Size = New System.Drawing.Size(0, 13)
		Me.lbl_troco.TabIndex = 24
		'
		'lbl_pago
		'
		Me.lbl_pago.AutoSize = true
		Me.lbl_pago.Location = New System.Drawing.Point(486, 53)
		Me.lbl_pago.Name = "lbl_pago"
		Me.lbl_pago.Size = New System.Drawing.Size(0, 13)
		Me.lbl_pago.TabIndex = 22
		'
		'lbl_pagamento
		'
		Me.lbl_pagamento.AutoSize = true
		Me.lbl_pagamento.Location = New System.Drawing.Point(258, 25)
		Me.lbl_pagamento.Name = "lbl_pagamento"
		Me.lbl_pagamento.Size = New System.Drawing.Size(0, 13)
		Me.lbl_pagamento.TabIndex = 21
		'
		'lbl_total
		'
		Me.lbl_total.AutoSize = true
		Me.lbl_total.Location = New System.Drawing.Point(69, 52)
		Me.lbl_total.Name = "lbl_total"
		Me.lbl_total.Size = New System.Drawing.Size(0, 13)
		Me.lbl_total.TabIndex = 20
		'
		'lbl_Desconto
		'
		Me.lbl_Desconto.AutoSize = true
		Me.lbl_Desconto.Location = New System.Drawing.Point(258, 52)
		Me.lbl_Desconto.Name = "lbl_Desconto"
		Me.lbl_Desconto.Size = New System.Drawing.Size(0, 13)
		Me.lbl_Desconto.TabIndex = 18
		'
		'lbl_idvenda
		'
		Me.lbl_idvenda.AutoSize = true
		Me.lbl_idvenda.Location = New System.Drawing.Point(71, 25)
		Me.lbl_idvenda.Name = "lbl_idvenda"
		Me.lbl_idvenda.Size = New System.Drawing.Size(0, 13)
		Me.lbl_idvenda.TabIndex = 17
		'
		'label9
		'
		Me.label9.AutoSize = true
		Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label9.Location = New System.Drawing.Point(751, 53)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(44, 13)
		Me.label9.TabIndex = 16
		Me.label9.Text = "Troco:"
		'
		'label10
		'
		Me.label10.AutoSize = true
		Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label10.Location = New System.Drawing.Point(429, 52)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(40, 13)
		Me.label10.TabIndex = 15
		Me.label10.Text = "Pago:"
		'
		'label11
		'
		Me.label11.AutoSize = true
		Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label11.Location = New System.Drawing.Point(8, 52)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(40, 13)
		Me.label11.TabIndex = 14
		Me.label11.Text = "Total:"
		'
		'label12
		'
		Me.label12.AutoSize = true
		Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label12.Location = New System.Drawing.Point(178, 52)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(65, 13)
		Me.label12.TabIndex = 13
		Me.label12.Text = "Desconto:"
		'
		'label8
		'
		Me.label8.AutoSize = true
		Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.Location = New System.Drawing.Point(752, 27)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(38, 13)
		Me.label8.TabIndex = 12
		Me.label8.Text = "Data:"
		'
		'label7
		'
		Me.label7.AutoSize = true
		Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label7.Location = New System.Drawing.Point(922, 27)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(47, 13)
		Me.label7.TabIndex = 11
		Me.label7.Text = "Status:"
		'
		'label6
		'
		Me.label6.AutoSize = true
		Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label6.Location = New System.Drawing.Point(178, 25)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(74, 13)
		Me.label6.TabIndex = 10
		Me.label6.Text = "Pagamento:"
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.Location = New System.Drawing.Point(430, 25)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(50, 13)
		Me.label5.TabIndex = 9
		Me.label5.Text = "Cliente:"
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(8, 26)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(58, 13)
		Me.label4.TabIndex = 8
		Me.label4.Text = "IdVenda:"
		'
		'dgv_Itens
		'
		Me.dgv_Itens.AllowDrop = true
		Me.dgv_Itens.AllowUserToAddRows = false
		Me.dgv_Itens.AllowUserToDeleteRows = false
		Me.dgv_Itens.AllowUserToOrderColumns = true
		Me.dgv_Itens.AllowUserToResizeRows = false
		Me.dgv_Itens.BackgroundColor = System.Drawing.Color.Black
		Me.dgv_Itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		Me.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Itens.DefaultCellStyle = dataGridViewCellStyle2
		Me.dgv_Itens.EnableHeadersVisualStyles = false
		Me.dgv_Itens.Location = New System.Drawing.Point(11, 86)
		Me.dgv_Itens.MultiSelect = false
		Me.dgv_Itens.Name = "dgv_Itens"
		Me.dgv_Itens.ReadOnly = true
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Itens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
		Me.dgv_Itens.RowHeadersVisible = false
		Me.dgv_Itens.Size = New System.Drawing.Size(1067, 462)
		Me.dgv_Itens.TabIndex = 7
		'
		'dgv_vendas
		'
		Me.dgv_vendas.AllowDrop = true
		Me.dgv_vendas.AllowUserToAddRows = false
		Me.dgv_vendas.AllowUserToDeleteRows = false
		Me.dgv_vendas.AllowUserToOrderColumns = true
		Me.dgv_vendas.AllowUserToResizeRows = false
		Me.dgv_vendas.BackgroundColor = System.Drawing.Color.Black
		Me.dgv_vendas.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgv_vendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dgv_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_vendas.DefaultCellStyle = dataGridViewCellStyle5
		Me.dgv_vendas.EnableHeadersVisualStyles = false
		Me.dgv_vendas.Location = New System.Drawing.Point(10, 20)
		Me.dgv_vendas.MultiSelect = false
		Me.dgv_vendas.Name = "dgv_vendas"
		Me.dgv_vendas.ReadOnly = true
		Me.dgv_vendas.RowHeadersVisible = false
		Me.dgv_vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_vendas.Size = New System.Drawing.Size(1121, 604)
		Me.dgv_vendas.TabIndex = 6
		'
		'toolTip1
		'
		Me.toolTip1.IsBalloon = true
		'
		'lbl_cliente
		'
		Me.lbl_cliente.AutoSize = true
		Me.lbl_cliente.Location = New System.Drawing.Point(486, 25)
		Me.lbl_cliente.Name = "lbl_cliente"
		Me.lbl_cliente.Size = New System.Drawing.Size(0, 13)
		Me.lbl_cliente.TabIndex = 19
		'
		'lbl_data
		'
		Me.lbl_data.AutoSize = true
		Me.lbl_data.Location = New System.Drawing.Point(799, 28)
		Me.lbl_data.Name = "lbl_data"
		Me.lbl_data.Size = New System.Drawing.Size(0, 13)
		Me.lbl_data.TabIndex = 23
		'
		'FormRelatorioVendas_Status
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(1371, 751)
		Me.Controls.Add(Me.pnl_principal)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormRelatorioVendas_Status"
		Me.Text = "PRÉ VENDA"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler KeyDown, AddressOf Me.FormRelatorioCompras_KeyDown
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.pnl_principal.ResumeLayout(false)
		Me.pnl_lateral.ResumeLayout(false)
		Me.gb_status.ResumeLayout(false)
		Me.gb_Periodo.ResumeLayout(false)
		Me.gb_Periodo.PerformLayout
		Me.gb_vendas.ResumeLayout(false)
		Me.pnl_Itens.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.gb_itens.ResumeLayout(false)
		Me.gb_itens.PerformLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dgv_vendas,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private panel4 As System.Windows.Forms.Panel
	Private label7 As System.Windows.Forms.Label
	Private lbl_idvenda As System.Windows.Forms.Label
	Private lbl_Desconto As System.Windows.Forms.Label
	Private lbl_cliente As System.Windows.Forms.Label
	Private lbl_total As System.Windows.Forms.Label
	Private lbl_pagamento As System.Windows.Forms.Label
	Private lbl_pago As System.Windows.Forms.Label
	Private lbl_data As System.Windows.Forms.Label
	Private lbl_troco As System.Windows.Forms.Label
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private label10 As System.Windows.Forms.Label
	Private label9 As System.Windows.Forms.Label
	Private label5 As System.Windows.Forms.Label
	Private label6 As System.Windows.Forms.Label
	Private lbl_status As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private dgv_Itens As System.Windows.Forms.DataGridView
	Private panel3 As System.Windows.Forms.Panel
	Private gb_itens As System.Windows.Forms.GroupBox
	Private pnl_Itens As System.Windows.Forms.Panel
	Private rb_Aberta As System.Windows.Forms.RadioButton
	Private radioButton2 As System.Windows.Forms.RadioButton
	Private gb_status As System.Windows.Forms.GroupBox
	Private dgv_vendas As System.Windows.Forms.DataGridView
	Private gb_vendas As System.Windows.Forms.GroupBox
	Private txt_data2 As System.Windows.Forms.TextBox
	Private txt_data1 As System.Windows.Forms.TextBox
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private dateTimePicker2 As System.Windows.Forms.DateTimePicker
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private gb_Periodo As System.Windows.Forms.GroupBox
	Private bt_imprimir As System.Windows.Forms.Button
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private bt_fechar As System.Windows.Forms.Button
	Private lbl_rodape As System.Windows.Forms.Label
	Private pnl_lateral As System.Windows.Forms.Panel
	Private pnl_principal As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel

End Class
