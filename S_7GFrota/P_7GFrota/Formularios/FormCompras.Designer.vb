'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 31/3/2014
' Hora: 13:34
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormCompras
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
		Dim dataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.label3 = New System.Windows.Forms.Label()
		Me.gb_DadosCompra = New System.Windows.Forms.GroupBox()
		Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txt_detalhe = New System.Windows.Forms.TextBox()
		Me.dgv_itens = New System.Windows.Forms.DataGridView()
		Me.IdProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NomeProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.IdFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NomeFantasia = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PrecoCusto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.pnl_Produto = New System.Windows.Forms.Panel()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.txt_produto = New System.Windows.Forms.TextBox()
		Me.dgv_produtos = New System.Windows.Forms.DataGridView()
		Me.pnl_qtd = New System.Windows.Forms.Panel()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.txt_qtd = New System.Windows.Forms.TextBox()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label4 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.label5 = New System.Windows.Forms.Label()
		Me.lbl_totalCompra = New System.Windows.Forms.Label()
		Me.gb_ValorTotalCompra = New System.Windows.Forms.GroupBox()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.lbl_NovaCompra = New System.Windows.Forms.Label()
		Me.gb_DadosCompra.SuspendLayout
		CType(Me.dgv_itens,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_Produto.SuspendLayout
		Me.groupBox2.SuspendLayout
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_qtd.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.gb_ValorTotalCompra.SuspendLayout
		Me.panel3.SuspendLayout
		Me.SuspendLayout
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(9, 28)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(44, 13)
		Me.label3.TabIndex = 2
		Me.label3.Text = "DATA:"
		'
		'gb_DadosCompra
		'
		Me.gb_DadosCompra.Controls.Add(Me.dateTimePicker1)
		Me.gb_DadosCompra.Controls.Add(Me.label2)
		Me.gb_DadosCompra.Controls.Add(Me.txt_detalhe)
		Me.gb_DadosCompra.Controls.Add(Me.label3)
		Me.gb_DadosCompra.Location = New System.Drawing.Point(3, 48)
		Me.gb_DadosCompra.Name = "gb_DadosCompra"
		Me.gb_DadosCompra.Size = New System.Drawing.Size(593, 59)
		Me.gb_DadosCompra.TabIndex = 3
		Me.gb_DadosCompra.TabStop = false
		Me.gb_DadosCompra.Text = "DADOS COMPRA"
		Me.gb_DadosCompra.Visible = false
		'
		'dateTimePicker1
		'
		Me.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dateTimePicker1.Location = New System.Drawing.Point(59, 24)
		Me.dateTimePicker1.Name = "dateTimePicker1"
		Me.dateTimePicker1.Size = New System.Drawing.Size(92, 20)
		Me.dateTimePicker1.TabIndex = 6
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(179, 28)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(61, 13)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Detalhes:"
		'
		'txt_detalhe
		'
		Me.txt_detalhe.Location = New System.Drawing.Point(246, 25)
		Me.txt_detalhe.Name = "txt_detalhe"
		Me.txt_detalhe.Size = New System.Drawing.Size(235, 20)
		Me.txt_detalhe.TabIndex = 4
		'
		'dgv_itens
		'
		Me.dgv_itens.AllowUserToAddRows = false
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		Me.dgv_itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProduto, Me.NomeProduto, Me.IdFornecedor, Me.NomeFantasia, Me.qtd, Me.PrecoCusto})
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_itens.DefaultCellStyle = dataGridViewCellStyle3
		Me.dgv_itens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
		Me.dgv_itens.EnableHeadersVisualStyles = false
		Me.dgv_itens.Location = New System.Drawing.Point(3, 114)
		Me.dgv_itens.MultiSelect = false
		Me.dgv_itens.Name = "dgv_itens"
		Me.dgv_itens.ReadOnly = true
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_itens.RowHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dgv_itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_itens.Size = New System.Drawing.Size(841, 440)
		Me.dgv_itens.StandardTab = true
		Me.dgv_itens.TabIndex = 4
		Me.dgv_itens.Visible = false
		AddHandler Me.dgv_itens.KeyDown, AddressOf Me.Dgv_itens_KeyDown
		'
		'IdProduto
		'
		Me.IdProduto.HeaderText = "IdProduto"
		Me.IdProduto.Name = "IdProduto"
		Me.IdProduto.ReadOnly = true
		Me.IdProduto.Visible = false
		Me.IdProduto.Width = 50
		'
		'NomeProduto
		'
		Me.NomeProduto.HeaderText = "PRODUTO"
		Me.NomeProduto.Name = "NomeProduto"
		Me.NomeProduto.ReadOnly = true
		Me.NomeProduto.Width = 220
		'
		'IdFornecedor
		'
		Me.IdFornecedor.HeaderText = "IdFornecedor"
		Me.IdFornecedor.Name = "IdFornecedor"
		Me.IdFornecedor.ReadOnly = true
		Me.IdFornecedor.Visible = false
		Me.IdFornecedor.Width = 50
		'
		'NomeFantasia
		'
		Me.NomeFantasia.HeaderText = "FORNECEDOR"
		Me.NomeFantasia.Name = "NomeFantasia"
		Me.NomeFantasia.ReadOnly = true
		Me.NomeFantasia.Width = 220
		'
		'qtd
		'
		Me.qtd.HeaderText = "QTD (F5)"
		Me.qtd.Name = "qtd"
		Me.qtd.ReadOnly = true
		'
		'PrecoCusto
		'
		dataGridViewCellStyle2.Format = "C2"
		dataGridViewCellStyle2.NullValue = Nothing
		Me.PrecoCusto.DefaultCellStyle = dataGridViewCellStyle2
		Me.PrecoCusto.HeaderText = "PREÇO CUSTO"
		Me.PrecoCusto.Name = "PrecoCusto"
		Me.PrecoCusto.ReadOnly = true
		Me.PrecoCusto.Width = 180
		'
		'pnl_Produto
		'
		Me.pnl_Produto.Controls.Add(Me.groupBox2)
		Me.pnl_Produto.Controls.Add(Me.dgv_produtos)
		Me.pnl_Produto.Location = New System.Drawing.Point(215, 151)
		Me.pnl_Produto.Name = "pnl_Produto"
		Me.pnl_Produto.Size = New System.Drawing.Size(609, 377)
		Me.pnl_Produto.TabIndex = 5
		Me.pnl_Produto.Visible = false
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.txt_produto)
		Me.groupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.groupBox2.Location = New System.Drawing.Point(11, 8)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(589, 57)
		Me.groupBox2.TabIndex = 0
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "DIGITE O NOME DO PRODUTO"
		'
		'txt_produto
		'
		Me.txt_produto.Location = New System.Drawing.Point(7, 28)
		Me.txt_produto.Name = "txt_produto"
		Me.txt_produto.Size = New System.Drawing.Size(576, 20)
		Me.txt_produto.TabIndex = 0
		AddHandler Me.txt_produto.KeyDown, AddressOf Me.Txt_produto_KeyDown
		'
		'dgv_produtos
		'
		Me.dgv_produtos.AllowUserToAddRows = false
		Me.dgv_produtos.AllowUserToDeleteRows = false
		Me.dgv_produtos.AllowUserToOrderColumns = true
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5
		Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
		dataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_produtos.DefaultCellStyle = dataGridViewCellStyle6
		Me.dgv_produtos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
		Me.dgv_produtos.EnableHeadersVisualStyles = false
		Me.dgv_produtos.Location = New System.Drawing.Point(11, 70)
		Me.dgv_produtos.MultiSelect = false
		Me.dgv_produtos.Name = "dgv_produtos"
		Me.dgv_produtos.ReadOnly = true
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7
		Me.dgv_produtos.RowHeadersVisible = false
		Me.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_produtos.Size = New System.Drawing.Size(589, 295)
		Me.dgv_produtos.TabIndex = 1
		AddHandler Me.dgv_produtos.KeyDown, AddressOf Me.Dgv_produtos_KeyDown
		'
		'pnl_qtd
		'
		Me.pnl_qtd.Controls.Add(Me.groupBox3)
		Me.pnl_qtd.Location = New System.Drawing.Point(337, 138)
		Me.pnl_qtd.Name = "pnl_qtd"
		Me.pnl_qtd.Size = New System.Drawing.Size(323, 97)
		Me.pnl_qtd.TabIndex = 2
		Me.pnl_qtd.Visible = false
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.txt_qtd)
		Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.groupBox3.Location = New System.Drawing.Point(8, 2)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(309, 88)
		Me.groupBox3.TabIndex = 0
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "DIGITE A QUANTIDADE COMPRADA"
		'
		'txt_qtd
		'
		Me.txt_qtd.Location = New System.Drawing.Point(94, 40)
		Me.txt_qtd.Name = "txt_qtd"
		Me.txt_qtd.Size = New System.Drawing.Size(87, 20)
		Me.txt_qtd.TabIndex = 0
		AddHandler Me.txt_qtd.KeyDown, AddressOf Me.Txt_qtd_KeyDown
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panel1.Controls.Add(Me.label4)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(851, 42)
		Me.panel1.TabIndex = 7
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.Color.White
		Me.label4.Location = New System.Drawing.Point(3, 9)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(222, 25)
		Me.label4.TabIndex = 0
		Me.label4.Text = "INSERIR COMPRAS"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.panel2.Controls.Add(Me.bt_fechar)
		Me.panel2.Controls.Add(Me.label5)
		Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel2.Location = New System.Drawing.Point(0, 560)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(851, 39)
		Me.panel2.TabIndex = 8
		'
		'bt_fechar
		'
		Me.bt_fechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_fechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bt_fechar.ForeColor = System.Drawing.Color.White
		Me.bt_fechar.Location = New System.Drawing.Point(769, 7)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(75, 28)
		Me.bt_fechar.TabIndex = 20
		Me.bt_fechar.Text = "&Fechar"
		Me.bt_fechar.UseVisualStyleBackColor = false
		AddHandler Me.bt_fechar.Click, AddressOf Me.Bt_fechar_Click
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.Color.White
		Me.label5.Location = New System.Drawing.Point(12, 11)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(308, 16)
		Me.label5.TabIndex = 68
		Me.label5.Text = "F1 Adicionar Produto / F3  Finalizar Compra"
		'
		'lbl_totalCompra
		'
		Me.lbl_totalCompra.AutoSize = true
		Me.lbl_totalCompra.BackColor = System.Drawing.Color.Black
		Me.lbl_totalCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_totalCompra.ForeColor = System.Drawing.Color.Yellow
		Me.lbl_totalCompra.Location = New System.Drawing.Point(9, 5)
		Me.lbl_totalCompra.Name = "lbl_totalCompra"
		Me.lbl_totalCompra.Size = New System.Drawing.Size(0, 24)
		Me.lbl_totalCompra.TabIndex = 70
		'
		'gb_ValorTotalCompra
		'
		Me.gb_ValorTotalCompra.BackColor = System.Drawing.SystemColors.Control
		Me.gb_ValorTotalCompra.Controls.Add(Me.panel3)
		Me.gb_ValorTotalCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_ValorTotalCompra.ForeColor = System.Drawing.Color.Red
		Me.gb_ValorTotalCompra.Location = New System.Drawing.Point(601, 48)
		Me.gb_ValorTotalCompra.Name = "gb_ValorTotalCompra"
		Me.gb_ValorTotalCompra.Size = New System.Drawing.Size(243, 59)
		Me.gb_ValorTotalCompra.TabIndex = 71
		Me.gb_ValorTotalCompra.TabStop = false
		Me.gb_ValorTotalCompra.Text = "VALOR TOTAL DA COMPRA"
		Me.gb_ValorTotalCompra.Visible = false
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.Black
		Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.panel3.Controls.Add(Me.lbl_totalCompra)
		Me.panel3.Location = New System.Drawing.Point(4, 15)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(234, 39)
		Me.panel3.TabIndex = 71
		'
		'lbl_NovaCompra
		'
		Me.lbl_NovaCompra.AutoSize = true
		Me.lbl_NovaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_NovaCompra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.lbl_NovaCompra.Location = New System.Drawing.Point(84, 257)
		Me.lbl_NovaCompra.Name = "lbl_NovaCompra"
		Me.lbl_NovaCompra.Size = New System.Drawing.Size(612, 33)
		Me.lbl_NovaCompra.TabIndex = 72
		Me.lbl_NovaCompra.Text = "PARA  NOVA  COMPRA  PRESSIONE - F1"
		'
		'FormCompras
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(851, 599)
		Me.Controls.Add(Me.pnl_qtd)
		Me.Controls.Add(Me.pnl_Produto)
		Me.Controls.Add(Me.gb_ValorTotalCompra)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.gb_DadosCompra)
		Me.Controls.Add(Me.lbl_NovaCompra)
		Me.Controls.Add(Me.dgv_itens)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormCompras"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "COMPRAS"
		AddHandler KeyDown, AddressOf Me.FormCompras_KeyDown
		AddHandler KeyUp, AddressOf Me.FormCompras_KeyUp
		Me.gb_DadosCompra.ResumeLayout(false)
		Me.gb_DadosCompra.PerformLayout
		CType(Me.dgv_itens,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_Produto.ResumeLayout(false)
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_qtd.ResumeLayout(false)
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.gb_ValorTotalCompra.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private IdFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
	Private IdProduto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private lbl_NovaCompra As System.Windows.Forms.Label
	Private panel3 As System.Windows.Forms.Panel
	Private gb_ValorTotalCompra As System.Windows.Forms.GroupBox
	Private lbl_totalCompra As System.Windows.Forms.Label
	Private txt_qtd As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private pnl_qtd As System.Windows.Forms.Panel
	Private PrecoCusto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private qtd As System.Windows.Forms.DataGridViewTextBoxColumn
	Private NomeFantasia As System.Windows.Forms.DataGridViewTextBoxColumn
	Private NomeProduto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private txt_produto As System.Windows.Forms.TextBox
	Private dgv_produtos As System.Windows.Forms.DataGridView
	Private label5 As System.Windows.Forms.Label
	Private bt_fechar As System.Windows.Forms.Button
	Private panel2 As System.Windows.Forms.Panel
	Private label4 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private pnl_Produto As System.Windows.Forms.Panel
	Private dgv_itens As System.Windows.Forms.DataGridView
	Private txt_detalhe As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private gb_DadosCompra As System.Windows.Forms.GroupBox
	Private label3 As System.Windows.Forms.Label
	
End Class
