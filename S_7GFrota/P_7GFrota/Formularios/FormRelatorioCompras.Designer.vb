'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormRelatorioCompras
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
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelatorioCompras))
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.lbl_rodape = New System.Windows.Forms.Label()
		Me.pnl_principal = New System.Windows.Forms.Panel()
		Me.gb_ItensCompra = New System.Windows.Forms.GroupBox()
		Me.dgv_Itens = New System.Windows.Forms.DataGridView()
		Me.gb_compras = New System.Windows.Forms.GroupBox()
		Me.dgv_InfoCompras = New System.Windows.Forms.DataGridView()
		Me.pnl_lateral = New System.Windows.Forms.Panel()
		Me.gb_gasto = New System.Windows.Forms.GroupBox()
		Me.bt_imprimirGasto = New System.Windows.Forms.Button()
		Me.label5 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.txt_gasto = New System.Windows.Forms.TextBox()
		Me.gb_Periodo = New System.Windows.Forms.GroupBox()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.dateTimePicker2 = New System.Windows.Forms.DateTimePicker()
		Me.txt_data2 = New System.Windows.Forms.TextBox()
		Me.txt_data1 = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.bt_imprimir = New System.Windows.Forms.Button()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.pnl_principal.SuspendLayout
		Me.gb_ItensCompra.SuspendLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gb_compras.SuspendLayout
		CType(Me.dgv_InfoCompras,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_lateral.SuspendLayout
		Me.gb_gasto.SuspendLayout
		Me.gb_Periodo.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
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
		Me.label1.Size = New System.Drawing.Size(403, 38)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Relatório de Compras"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
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
		Me.bt_fechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
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
		Me.lbl_rodape.Size = New System.Drawing.Size(380, 18)
		Me.lbl_rodape.TabIndex = 0
		Me.lbl_rodape.Text = "F1 - Exibir Compras / F3 - Exibir Itens da Compra"
		'
		'pnl_principal
		'
		Me.pnl_principal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_principal.Controls.Add(Me.pnl_lateral)
		Me.pnl_principal.Controls.Add(Me.gb_ItensCompra)
		Me.pnl_principal.Controls.Add(Me.gb_compras)
		Me.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl_principal.Location = New System.Drawing.Point(0, 49)
		Me.pnl_principal.Name = "pnl_principal"
		Me.pnl_principal.Size = New System.Drawing.Size(1371, 660)
		Me.pnl_principal.TabIndex = 2
		'
		'gb_ItensCompra
		'
		Me.gb_ItensCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.gb_ItensCompra.Controls.Add(Me.dgv_Itens)
		Me.gb_ItensCompra.ForeColor = System.Drawing.Color.White
		Me.gb_ItensCompra.Location = New System.Drawing.Point(216, 170)
		Me.gb_ItensCompra.Name = "gb_ItensCompra"
		Me.gb_ItensCompra.Size = New System.Drawing.Size(1141, 482)
		Me.gb_ItensCompra.TabIndex = 7
		Me.gb_ItensCompra.TabStop = false
		Me.gb_ItensCompra.Text = "Itens da Compra"
		'
		'dgv_Itens
		'
		Me.dgv_Itens.AllowUserToAddRows = false
		Me.dgv_Itens.AllowUserToResizeRows = false
		Me.dgv_Itens.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.dgv_Itens.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgv_Itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		Me.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Itens.DefaultCellStyle = dataGridViewCellStyle2
		Me.dgv_Itens.EnableHeadersVisualStyles = false
		Me.dgv_Itens.Location = New System.Drawing.Point(10, 20)
		Me.dgv_Itens.MultiSelect = false
		Me.dgv_Itens.Name = "dgv_Itens"
		Me.dgv_Itens.ReadOnly = true
		Me.dgv_Itens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		Me.dgv_Itens.RowHeadersVisible = false
		Me.dgv_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Itens.Size = New System.Drawing.Size(1116, 451)
		Me.dgv_Itens.TabIndex = 9
		'
		'gb_compras
		'
		Me.gb_compras.Controls.Add(Me.dgv_InfoCompras)
		Me.gb_compras.ForeColor = System.Drawing.Color.White
		Me.gb_compras.Location = New System.Drawing.Point(216, 5)
		Me.gb_compras.Name = "gb_compras"
		Me.gb_compras.Size = New System.Drawing.Size(1141, 159)
		Me.gb_compras.TabIndex = 6
		Me.gb_compras.TabStop = false
		Me.gb_compras.Text = "Informações da Compra"
		'
		'dgv_InfoCompras
		'
		Me.dgv_InfoCompras.AllowUserToAddRows = false
		Me.dgv_InfoCompras.AllowUserToResizeRows = false
		Me.dgv_InfoCompras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.dgv_InfoCompras.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgv_InfoCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_InfoCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_InfoCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3
		Me.dgv_InfoCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_InfoCompras.DefaultCellStyle = dataGridViewCellStyle4
		Me.dgv_InfoCompras.EnableHeadersVisualStyles = false
		Me.dgv_InfoCompras.Location = New System.Drawing.Point(10, 20)
		Me.dgv_InfoCompras.MultiSelect = false
		Me.dgv_InfoCompras.Name = "dgv_InfoCompras"
		Me.dgv_InfoCompras.ReadOnly = true
		Me.dgv_InfoCompras.RowHeadersVisible = false
		Me.dgv_InfoCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_InfoCompras.Size = New System.Drawing.Size(1121, 132)
		Me.dgv_InfoCompras.TabIndex = 6
		'
		'pnl_lateral
		'
		Me.pnl_lateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.pnl_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_lateral.Controls.Add(Me.gb_gasto)
		Me.pnl_lateral.Controls.Add(Me.gb_Periodo)
		Me.pnl_lateral.Controls.Add(Me.bt_imprimir)
		Me.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Left
		Me.pnl_lateral.Location = New System.Drawing.Point(0, 0)
		Me.pnl_lateral.Name = "pnl_lateral"
		Me.pnl_lateral.Size = New System.Drawing.Size(209, 656)
		Me.pnl_lateral.TabIndex = 3
		'
		'gb_gasto
		'
		Me.gb_gasto.Controls.Add(Me.bt_imprimirGasto)
		Me.gb_gasto.Controls.Add(Me.label5)
		Me.gb_gasto.Controls.Add(Me.label4)
		Me.gb_gasto.Controls.Add(Me.txt_gasto)
		Me.gb_gasto.ForeColor = System.Drawing.Color.White
		Me.gb_gasto.Location = New System.Drawing.Point(7, 94)
		Me.gb_gasto.Name = "gb_gasto"
		Me.gb_gasto.Size = New System.Drawing.Size(190, 139)
		Me.gb_gasto.TabIndex = 13
		Me.gb_gasto.TabStop = false
		Me.gb_gasto.Text = "Informação de gastos"
		Me.gb_gasto.Visible = false
		'
		'bt_imprimirGasto
		'
		Me.bt_imprimirGasto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.bt_imprimirGasto.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_imprimirGasto.Location = New System.Drawing.Point(12, 105)
		Me.bt_imprimirGasto.Name = "bt_imprimirGasto"
		Me.bt_imprimirGasto.Size = New System.Drawing.Size(166, 23)
		Me.bt_imprimirGasto.TabIndex = 15
		Me.bt_imprimirGasto.Text = "Imprimir &Relatório"
		Me.bt_imprimirGasto.UseVisualStyleBackColor = false
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Location = New System.Drawing.Point(8, 39)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(104, 13)
		Me.label5.TabIndex = 14
		Me.label5.Text = "período selecionado"
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(9, 24)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(161, 13)
		Me.label4.TabIndex = 13
		Me.label4.Text = "Gasto com compras referente ao"
		'
		'txt_gasto
		'
		Me.txt_gasto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.txt_gasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_gasto.ForeColor = System.Drawing.Color.Lime
		Me.txt_gasto.Location = New System.Drawing.Point(12, 65)
		Me.txt_gasto.Name = "txt_gasto"
		Me.txt_gasto.ReadOnly = true
		Me.txt_gasto.Size = New System.Drawing.Size(166, 26)
		Me.txt_gasto.TabIndex = 12
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
		Me.txt_data2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.txt_data2.ForeColor = System.Drawing.Color.White
		Me.txt_data2.Location = New System.Drawing.Point(69, 48)
		Me.txt_data2.Name = "txt_data2"
		Me.txt_data2.ReadOnly = true
		Me.txt_data2.Size = New System.Drawing.Size(100, 20)
		Me.txt_data2.TabIndex = 16
		'
		'txt_data1
		'
		Me.txt_data1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
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
		Me.bt_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
		Me.bt_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_imprimir.ForeColor = System.Drawing.Color.White
		Me.bt_imprimir.Image = CType(resources.GetObject("bt_imprimir.Image"),System.Drawing.Image)
		Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.bt_imprimir.Location = New System.Drawing.Point(19, 249)
		Me.bt_imprimir.Name = "bt_imprimir"
		Me.bt_imprimir.Size = New System.Drawing.Size(166, 39)
		Me.bt_imprimir.TabIndex = 7
		Me.bt_imprimir.Text = "Imprimir &Itens Compra"
		Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.toolTip1.SetToolTip(Me.bt_imprimir, "Imprimir Relatório de Estoque")
		Me.bt_imprimir.UseVisualStyleBackColor = true
		Me.bt_imprimir.Visible = false
		'
		'toolTip1
		'
		Me.toolTip1.IsBalloon = true
		'
		'FormRelatorioCompras
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
		Me.Name = "FormRelatorioCompras"
		Me.Text = "PRÉ VENDA"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler KeyDown, AddressOf Me.FormRelatorioCompras_KeyDown
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.pnl_principal.ResumeLayout(false)
		Me.gb_ItensCompra.ResumeLayout(false)
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).EndInit
		Me.gb_compras.ResumeLayout(false)
		CType(Me.dgv_InfoCompras,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_lateral.ResumeLayout(false)
		Me.gb_gasto.ResumeLayout(false)
		Me.gb_gasto.PerformLayout
		Me.gb_Periodo.ResumeLayout(false)
		Me.gb_Periodo.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private bt_imprimirGasto As System.Windows.Forms.Button
	Private label5 As System.Windows.Forms.Label
	Private txt_gasto As System.Windows.Forms.TextBox
	Private gb_gasto As System.Windows.Forms.GroupBox
	Private label4 As System.Windows.Forms.Label
	Private dgv_InfoCompras As System.Windows.Forms.DataGridView
	Private gb_compras As System.Windows.Forms.GroupBox
	Private gb_ItensCompra As System.Windows.Forms.GroupBox
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
	Private dgv_Itens As System.Windows.Forms.DataGridView
	Private lbl_rodape As System.Windows.Forms.Label
	Private pnl_lateral As System.Windows.Forms.Panel
	Private pnl_principal As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel

End Class
