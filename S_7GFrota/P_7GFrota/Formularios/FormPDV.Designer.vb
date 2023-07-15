'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormPDV
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
		Dim dataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPDV))
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.lbl_idvenda = New System.Windows.Forms.Label()
		Me.lbl_norcamento = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.lbl_rodape = New System.Windows.Forms.Label()
		Me.pnl_principal = New System.Windows.Forms.Panel()
		Me.pnl_qtd = New System.Windows.Forms.Panel()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.groupBox5 = New System.Windows.Forms.GroupBox()
		Me.txt_qtd = New System.Windows.Forms.TextBox()
		Me.pnl_produto = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.lbl_cliente = New System.Windows.Forms.Label()
		Me.dgv_produtos = New System.Windows.Forms.DataGridView()
		Me.gb_Nomeproduto = New System.Windows.Forms.GroupBox()
		Me.txt_produto = New System.Windows.Forms.TextBox()
		Me.gb_status = New System.Windows.Forms.GroupBox()
		Me.lbl_status = New System.Windows.Forms.Label()
		Me.gb_venda = New System.Windows.Forms.GroupBox()
		Me.cb_formaPagamento = New System.Windows.Forms.ComboBox()
		Me.txt_FormaPagamento = New System.Windows.Forms.TextBox()
		Me.lbl_data = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.txt_cliente = New System.Windows.Forms.TextBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.dgv_itensOrcamento = New System.Windows.Forms.DataGridView()
		Me.dgv_Itens = New System.Windows.Forms.DataGridView()
		Me.PRODUTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FORNECEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.QTD = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PRECOUNITARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.idProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.idFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.lbl_central = New System.Windows.Forms.Label()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_valorTotal = New System.Windows.Forms.TextBox()
		Me.groupBox2 = New System.Windows.Forms.GroupBox()
		Me.txt_desconto = New System.Windows.Forms.TextBox()
		Me.groupBox3 = New System.Windows.Forms.GroupBox()
		Me.txt_pago = New System.Windows.Forms.TextBox()
		Me.groupBox4 = New System.Windows.Forms.GroupBox()
		Me.txt_troco = New System.Windows.Forms.TextBox()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pnl_lateral = New System.Windows.Forms.Panel()
		Me.pnl_orcamento = New System.Windows.Forms.Panel()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.groupBox6 = New System.Windows.Forms.GroupBox()
		Me.txt_Norcamento = New System.Windows.Forms.TextBox()
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.pnl_principal.SuspendLayout
		Me.pnl_qtd.SuspendLayout
		Me.panel4.SuspendLayout
		Me.groupBox5.SuspendLayout
		Me.pnl_produto.SuspendLayout
		Me.panel3.SuspendLayout
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gb_Nomeproduto.SuspendLayout
		Me.gb_status.SuspendLayout
		Me.gb_venda.SuspendLayout
		CType(Me.dgv_itensOrcamento,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.groupBox2.SuspendLayout
		Me.groupBox3.SuspendLayout
		Me.groupBox4.SuspendLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_lateral.SuspendLayout
		Me.pnl_orcamento.SuspendLayout
		Me.panel6.SuspendLayout
		Me.groupBox6.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.Black
		Me.panel1.Controls.Add(Me.lbl_idvenda)
		Me.panel1.Controls.Add(Me.lbl_norcamento)
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(1371, 49)
		Me.panel1.TabIndex = 0
		'
		'lbl_idvenda
		'
		Me.lbl_idvenda.AutoSize = true
		Me.lbl_idvenda.BackColor = System.Drawing.Color.Transparent
		Me.lbl_idvenda.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_idvenda.ForeColor = System.Drawing.Color.White
		Me.lbl_idvenda.Location = New System.Drawing.Point(915, 9)
		Me.lbl_idvenda.Name = "lbl_idvenda"
		Me.lbl_idvenda.Size = New System.Drawing.Size(0, 33)
		Me.lbl_idvenda.TabIndex = 2
		Me.lbl_idvenda.Visible = false
		'
		'lbl_norcamento
		'
		Me.lbl_norcamento.AutoSize = true
		Me.lbl_norcamento.BackColor = System.Drawing.Color.Transparent
		Me.lbl_norcamento.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_norcamento.ForeColor = System.Drawing.Color.White
		Me.lbl_norcamento.Location = New System.Drawing.Point(684, 8)
		Me.lbl_norcamento.Name = "lbl_norcamento"
		Me.lbl_norcamento.Size = New System.Drawing.Size(221, 32)
		Me.lbl_norcamento.TabIndex = 1
		Me.lbl_norcamento.Text = "Nº Orçamento:"
		Me.lbl_norcamento.Visible = false
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.BackColor = System.Drawing.Color.Transparent
		Me.label1.Font = New System.Drawing.Font("Verdana", 24!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.White
		Me.label1.Location = New System.Drawing.Point(12, 5)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(303, 38)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Ponto De Venda"
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
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.Cyan
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
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
		Me.lbl_rodape.Size = New System.Drawing.Size(315, 18)
		Me.lbl_rodape.TabIndex = 0
		Me.lbl_rodape.Text = "F1 - Adicionar Item / F3 - Finalizar Venda"
		Me.lbl_rodape.Visible = false
		'
		'pnl_principal
		'
		Me.pnl_principal.BackColor = System.Drawing.Color.Black
		Me.pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_principal.Controls.Add(Me.pnl_qtd)
		Me.pnl_principal.Controls.Add(Me.pnl_produto)
		Me.pnl_principal.Controls.Add(Me.gb_status)
		Me.pnl_principal.Controls.Add(Me.gb_venda)
		Me.pnl_principal.Controls.Add(Me.dgv_itensOrcamento)
		Me.pnl_principal.Controls.Add(Me.dgv_Itens)
		Me.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl_principal.Location = New System.Drawing.Point(0, 49)
		Me.pnl_principal.Name = "pnl_principal"
		Me.pnl_principal.Size = New System.Drawing.Size(1011, 660)
		Me.pnl_principal.TabIndex = 2
		Me.pnl_principal.Visible = false
		'
		'pnl_qtd
		'
		Me.pnl_qtd.BackColor = System.Drawing.Color.Gray
		Me.pnl_qtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnl_qtd.Controls.Add(Me.panel4)
		Me.pnl_qtd.Location = New System.Drawing.Point(543, 139)
		Me.pnl_qtd.Name = "pnl_qtd"
		Me.pnl_qtd.Size = New System.Drawing.Size(218, 104)
		Me.pnl_qtd.TabIndex = 5
		Me.pnl_qtd.Visible = false
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.Black
		Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel4.Controls.Add(Me.groupBox5)
		Me.panel4.Location = New System.Drawing.Point(4, 3)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(209, 96)
		Me.panel4.TabIndex = 1
		'
		'groupBox5
		'
		Me.groupBox5.Controls.Add(Me.txt_qtd)
		Me.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.groupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox5.ForeColor = System.Drawing.Color.White
		Me.groupBox5.Location = New System.Drawing.Point(7, 3)
		Me.groupBox5.Name = "groupBox5"
		Me.groupBox5.Size = New System.Drawing.Size(193, 85)
		Me.groupBox5.TabIndex = 0
		Me.groupBox5.TabStop = false
		Me.groupBox5.Text = "DIGITE A QUANTIDADE"
		'
		'txt_qtd
		'
		Me.txt_qtd.BackColor = System.Drawing.Color.Black
		Me.txt_qtd.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_qtd.ForeColor = System.Drawing.Color.White
		Me.txt_qtd.Location = New System.Drawing.Point(23, 36)
		Me.txt_qtd.Name = "txt_qtd"
		Me.txt_qtd.Size = New System.Drawing.Size(146, 30)
		Me.txt_qtd.TabIndex = 0
		AddHandler Me.txt_qtd.KeyDown, AddressOf Me.Txt_qtd_KeyDown
		'
		'pnl_produto
		'
		Me.pnl_produto.BackColor = System.Drawing.Color.Gray
		Me.pnl_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnl_produto.Controls.Add(Me.panel3)
		Me.pnl_produto.Location = New System.Drawing.Point(352, 148)
		Me.pnl_produto.Name = "pnl_produto"
		Me.pnl_produto.Size = New System.Drawing.Size(625, 477)
		Me.pnl_produto.TabIndex = 4
		Me.pnl_produto.Visible = false
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.Black
		Me.panel3.Controls.Add(Me.lbl_cliente)
		Me.panel3.Controls.Add(Me.dgv_produtos)
		Me.panel3.Controls.Add(Me.gb_Nomeproduto)
		Me.panel3.Location = New System.Drawing.Point(5, 5)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(612, 465)
		Me.panel3.TabIndex = 1
		'
		'lbl_cliente
		'
		Me.lbl_cliente.AutoSize = true
		Me.lbl_cliente.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_cliente.ForeColor = System.Drawing.Color.White
		Me.lbl_cliente.Location = New System.Drawing.Point(115, 18)
		Me.lbl_cliente.Name = "lbl_cliente"
		Me.lbl_cliente.Size = New System.Drawing.Size(360, 41)
		Me.lbl_cliente.TabIndex = 5
		Me.lbl_cliente.Text = "ESCOLHA UM CLIENTE"
		Me.lbl_cliente.Visible = false
		'
		'dgv_produtos
		'
		Me.dgv_produtos.AllowUserToAddRows = false
		Me.dgv_produtos.AllowUserToDeleteRows = false
		Me.dgv_produtos.AllowUserToOrderColumns = true
		Me.dgv_produtos.AllowUserToResizeRows = false
		Me.dgv_produtos.BackgroundColor = System.Drawing.Color.Black
		Me.dgv_produtos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_produtos.DefaultCellStyle = dataGridViewCellStyle2
		Me.dgv_produtos.EnableHeadersVisualStyles = false
		Me.dgv_produtos.GridColor = System.Drawing.Color.White
		Me.dgv_produtos.Location = New System.Drawing.Point(8, 80)
		Me.dgv_produtos.Name = "dgv_produtos"
		Me.dgv_produtos.ReadOnly = true
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3
		Me.dgv_produtos.RowHeadersVisible = false
		Me.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_produtos.Size = New System.Drawing.Size(593, 374)
		Me.dgv_produtos.TabIndex = 2
		AddHandler Me.dgv_produtos.KeyDown, AddressOf Me.Dgv_produtos_KeyDown
		'
		'gb_Nomeproduto
		'
		Me.gb_Nomeproduto.Controls.Add(Me.txt_produto)
		Me.gb_Nomeproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gb_Nomeproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_Nomeproduto.ForeColor = System.Drawing.Color.White
		Me.gb_Nomeproduto.Location = New System.Drawing.Point(7, 7)
		Me.gb_Nomeproduto.Name = "gb_Nomeproduto"
		Me.gb_Nomeproduto.Size = New System.Drawing.Size(595, 64)
		Me.gb_Nomeproduto.TabIndex = 3
		Me.gb_Nomeproduto.TabStop = false
		Me.gb_Nomeproduto.Text = "DIGITE O NOME DO PRODUTO"
		'
		'txt_produto
		'
		Me.txt_produto.BackColor = System.Drawing.Color.Black
		Me.txt_produto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_produto.ForeColor = System.Drawing.Color.White
		Me.txt_produto.Location = New System.Drawing.Point(11, 28)
		Me.txt_produto.Name = "txt_produto"
		Me.txt_produto.Size = New System.Drawing.Size(568, 20)
		Me.txt_produto.TabIndex = 0
		AddHandler Me.txt_produto.KeyDown, AddressOf Me.Txt_produto_KeyDown
		'
		'gb_status
		'
		Me.gb_status.Controls.Add(Me.lbl_status)
		Me.gb_status.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 9!)
		Me.gb_status.ForeColor = System.Drawing.Color.White
		Me.gb_status.Location = New System.Drawing.Point(824, 6)
		Me.gb_status.Name = "gb_status"
		Me.gb_status.Size = New System.Drawing.Size(170, 77)
		Me.gb_status.TabIndex = 2
		Me.gb_status.TabStop = false
		Me.gb_status.Text = "Status da venda"
		'
		'lbl_status
		'
		Me.lbl_status.AutoSize = true
		Me.lbl_status.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_status.ForeColor = System.Drawing.Color.Red
		Me.lbl_status.Location = New System.Drawing.Point(44, 34)
		Me.lbl_status.Name = "lbl_status"
		Me.lbl_status.Size = New System.Drawing.Size(84, 22)
		Me.lbl_status.TabIndex = 0
		Me.lbl_status.Text = "Fechada"
		Me.lbl_status.Visible = false
		'
		'gb_venda
		'
		Me.gb_venda.BackColor = System.Drawing.Color.Black
		Me.gb_venda.Controls.Add(Me.cb_formaPagamento)
		Me.gb_venda.Controls.Add(Me.txt_FormaPagamento)
		Me.gb_venda.Controls.Add(Me.lbl_data)
		Me.gb_venda.Controls.Add(Me.label4)
		Me.gb_venda.Controls.Add(Me.label3)
		Me.gb_venda.Controls.Add(Me.txt_cliente)
		Me.gb_venda.Controls.Add(Me.label2)
		Me.gb_venda.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gb_venda.ForeColor = System.Drawing.Color.White
		Me.gb_venda.Location = New System.Drawing.Point(3, 6)
		Me.gb_venda.Name = "gb_venda"
		Me.gb_venda.Size = New System.Drawing.Size(815, 77)
		Me.gb_venda.TabIndex = 1
		Me.gb_venda.TabStop = false
		Me.gb_venda.Text = "Informações da venda (F7)"
		'
		'cb_formaPagamento
		'
		Me.cb_formaPagamento.BackColor = System.Drawing.Color.Black
		Me.cb_formaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cb_formaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cb_formaPagamento.ForeColor = System.Drawing.Color.Cyan
		Me.cb_formaPagamento.FormattingEnabled = true
		Me.cb_formaPagamento.Location = New System.Drawing.Point(428, 42)
		Me.cb_formaPagamento.Name = "cb_formaPagamento"
		Me.cb_formaPagamento.Size = New System.Drawing.Size(211, 22)
		Me.cb_formaPagamento.TabIndex = 25
		AddHandler Me.cb_formaPagamento.KeyDown, AddressOf Me.Cb_formaPagamento_KeyDown
		'
		'txt_FormaPagamento
		'
		Me.txt_FormaPagamento.BackColor = System.Drawing.Color.Black
		Me.txt_FormaPagamento.ForeColor = System.Drawing.Color.Cyan
		Me.txt_FormaPagamento.Location = New System.Drawing.Point(428, 43)
		Me.txt_FormaPagamento.Name = "txt_FormaPagamento"
		Me.txt_FormaPagamento.Size = New System.Drawing.Size(211, 21)
		Me.txt_FormaPagamento.TabIndex = 24
		Me.txt_FormaPagamento.Visible = false
		'
		'lbl_data
		'
		Me.lbl_data.AutoSize = true
		Me.lbl_data.ForeColor = System.Drawing.Color.Cyan
		Me.lbl_data.Location = New System.Drawing.Point(673, 44)
		Me.lbl_data.Name = "lbl_data"
		Me.lbl_data.Size = New System.Drawing.Size(0, 14)
		Me.lbl_data.TabIndex = 23
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Location = New System.Drawing.Point(671, 23)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(35, 14)
		Me.label4.TabIndex = 22
		Me.label4.Text = "Data"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(427, 23)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(133, 14)
		Me.label3.TabIndex = 20
		Me.label3.Text = "Forma de Pagamento"
		'
		'txt_cliente
		'
		Me.txt_cliente.BackColor = System.Drawing.Color.Black
		Me.txt_cliente.ForeColor = System.Drawing.Color.Cyan
		Me.txt_cliente.Location = New System.Drawing.Point(17, 43)
		Me.txt_cliente.Name = "txt_cliente"
		Me.txt_cliente.Size = New System.Drawing.Size(379, 21)
		Me.txt_cliente.TabIndex = 19
		AddHandler Me.txt_cliente.KeyDown, AddressOf Me.Txt_cliente_KeyDown
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(14, 23)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(56, 14)
		Me.label2.TabIndex = 18
		Me.label2.Text = "Cliente"
		'
		'dgv_itensOrcamento
		'
		Me.dgv_itensOrcamento.AllowUserToAddRows = false
		Me.dgv_itensOrcamento.AllowUserToDeleteRows = false
		Me.dgv_itensOrcamento.AllowUserToResizeRows = false
		Me.dgv_itensOrcamento.BackgroundColor = System.Drawing.Color.Black
		Me.dgv_itensOrcamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dgv_itensOrcamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_itensOrcamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_itensOrcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4
		Me.dgv_itensOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_itensOrcamento.DefaultCellStyle = dataGridViewCellStyle5
		Me.dgv_itensOrcamento.EnableHeadersVisualStyles = false
		Me.dgv_itensOrcamento.GridColor = System.Drawing.Color.Black
		Me.dgv_itensOrcamento.Location = New System.Drawing.Point(3, 89)
		Me.dgv_itensOrcamento.MultiSelect = false
		Me.dgv_itensOrcamento.Name = "dgv_itensOrcamento"
		Me.dgv_itensOrcamento.ReadOnly = true
		Me.dgv_itensOrcamento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_itensOrcamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle6
		Me.dgv_itensOrcamento.RowHeadersVisible = false
		Me.dgv_itensOrcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_itensOrcamento.Size = New System.Drawing.Size(991, 559)
		Me.dgv_itensOrcamento.TabIndex = 6
		'
		'dgv_Itens
		'
		Me.dgv_Itens.AllowUserToAddRows = false
		Me.dgv_Itens.AllowUserToResizeRows = false
		Me.dgv_Itens.BackgroundColor = System.Drawing.Color.Black
		Me.dgv_Itens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.dgv_Itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Cyan
		dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7
		Me.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Itens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PRODUTO, Me.FORNECEDOR, Me.QTD, Me.PRECOUNITARIO, Me.VALOR, Me.idProduto, Me.idFornecedor})
		dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
		dataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer))
		dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
		dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Itens.DefaultCellStyle = dataGridViewCellStyle10
		Me.dgv_Itens.EnableHeadersVisualStyles = false
		Me.dgv_Itens.Location = New System.Drawing.Point(3, 88)
		Me.dgv_Itens.MultiSelect = false
		Me.dgv_Itens.Name = "dgv_Itens"
		Me.dgv_Itens.ReadOnly = true
		Me.dgv_Itens.RowHeadersVisible = false
		Me.dgv_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Itens.Size = New System.Drawing.Size(991, 559)
		Me.dgv_Itens.TabIndex = 3
		AddHandler Me.dgv_Itens.KeyDown, AddressOf Me.Dgv_Itens_KeyDown
		'
		'PRODUTO
		'
		Me.PRODUTO.HeaderText = "PRODUTO"
		Me.PRODUTO.Name = "PRODUTO"
		Me.PRODUTO.ReadOnly = true
		Me.PRODUTO.Width = 290
		'
		'FORNECEDOR
		'
		Me.FORNECEDOR.HeaderText = "FORNECEDOR"
		Me.FORNECEDOR.Name = "FORNECEDOR"
		Me.FORNECEDOR.ReadOnly = true
		Me.FORNECEDOR.Width = 280
		'
		'QTD
		'
		Me.QTD.HeaderText = "QTD (F5)"
		Me.QTD.Name = "QTD"
		Me.QTD.ReadOnly = true
		Me.QTD.Width = 85
		'
		'PRECOUNITARIO
		'
		dataGridViewCellStyle8.Format = "C2"
		dataGridViewCellStyle8.NullValue = "0"
		Me.PRECOUNITARIO.DefaultCellStyle = dataGridViewCellStyle8
		Me.PRECOUNITARIO.HeaderText = "PREÇO UNIT"
		Me.PRECOUNITARIO.Name = "PRECOUNITARIO"
		Me.PRECOUNITARIO.ReadOnly = true
		Me.PRECOUNITARIO.Width = 158
		'
		'VALOR
		'
		dataGridViewCellStyle9.Format = "C2"
		dataGridViewCellStyle9.NullValue = "0"
		Me.VALOR.DefaultCellStyle = dataGridViewCellStyle9
		Me.VALOR.HeaderText = "VALOR"
		Me.VALOR.Name = "VALOR"
		Me.VALOR.ReadOnly = true
		Me.VALOR.Width = 158
		'
		'idProduto
		'
		Me.idProduto.HeaderText = "idProduto"
		Me.idProduto.Name = "idProduto"
		Me.idProduto.ReadOnly = true
		Me.idProduto.Visible = false
		'
		'idFornecedor
		'
		Me.idFornecedor.HeaderText = "idFornecedor"
		Me.idFornecedor.Name = "idFornecedor"
		Me.idFornecedor.ReadOnly = true
		Me.idFornecedor.Visible = false
		'
		'lbl_central
		'
		Me.lbl_central.AutoSize = true
		Me.lbl_central.BackColor = System.Drawing.SystemColors.Control
		Me.lbl_central.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lbl_central.ForeColor = System.Drawing.Color.Black
		Me.lbl_central.Location = New System.Drawing.Point(301, 333)
		Me.lbl_central.Name = "lbl_central"
		Me.lbl_central.Size = New System.Drawing.Size(717, 42)
		Me.lbl_central.TabIndex = 6
		Me.lbl_central.Text = "F1 - Nova Venda / F3 - Abrir Orçamento"
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_valorTotal)
		Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox1.ForeColor = System.Drawing.Color.Lime
		Me.groupBox1.Location = New System.Drawing.Point(12, 1)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(330, 110)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "VALOR TOTAL"
		'
		'txt_valorTotal
		'
		Me.txt_valorTotal.BackColor = System.Drawing.Color.Black
		Me.txt_valorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_valorTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_valorTotal.ForeColor = System.Drawing.Color.Lime
		Me.txt_valorTotal.Location = New System.Drawing.Point(11, 43)
		Me.txt_valorTotal.Name = "txt_valorTotal"
		Me.txt_valorTotal.ReadOnly = true
		Me.txt_valorTotal.Size = New System.Drawing.Size(310, 49)
		Me.txt_valorTotal.TabIndex = 0
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.txt_desconto)
		Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox2.ForeColor = System.Drawing.Color.White
		Me.groupBox2.Location = New System.Drawing.Point(12, 118)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(330, 110)
		Me.groupBox2.TabIndex = 1
		Me.groupBox2.TabStop = false
		Me.groupBox2.Text = "DESCONTO"
		'
		'txt_desconto
		'
		Me.txt_desconto.BackColor = System.Drawing.Color.Black
		Me.txt_desconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_desconto.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_desconto.ForeColor = System.Drawing.Color.White
		Me.txt_desconto.Location = New System.Drawing.Point(10, 49)
		Me.txt_desconto.Name = "txt_desconto"
		Me.txt_desconto.ReadOnly = true
		Me.txt_desconto.Size = New System.Drawing.Size(310, 49)
		Me.txt_desconto.TabIndex = 0
		AddHandler Me.txt_desconto.KeyDown, AddressOf Me.Txt_desconto_KeyDown
		AddHandler Me.txt_desconto.KeyPress, AddressOf Me.Txt_desconto_KeyPress
		'
		'groupBox3
		'
		Me.groupBox3.Controls.Add(Me.txt_pago)
		Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox3.ForeColor = System.Drawing.Color.Aqua
		Me.groupBox3.Location = New System.Drawing.Point(12, 233)
		Me.groupBox3.Name = "groupBox3"
		Me.groupBox3.Size = New System.Drawing.Size(330, 110)
		Me.groupBox3.TabIndex = 2
		Me.groupBox3.TabStop = false
		Me.groupBox3.Text = "PAGO"
		'
		'txt_pago
		'
		Me.txt_pago.BackColor = System.Drawing.Color.Black
		Me.txt_pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_pago.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_pago.ForeColor = System.Drawing.Color.Cyan
		Me.txt_pago.Location = New System.Drawing.Point(9, 46)
		Me.txt_pago.Name = "txt_pago"
		Me.txt_pago.ReadOnly = true
		Me.txt_pago.Size = New System.Drawing.Size(310, 49)
		Me.txt_pago.TabIndex = 0
		AddHandler Me.txt_pago.KeyDown, AddressOf Me.Txt_pago_KeyDown
		AddHandler Me.txt_pago.KeyPress, AddressOf Me.Txt_pago_KeyPress
		'
		'groupBox4
		'
		Me.groupBox4.Controls.Add(Me.txt_troco)
		Me.groupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox4.ForeColor = System.Drawing.Color.Red
		Me.groupBox4.Location = New System.Drawing.Point(12, 348)
		Me.groupBox4.Name = "groupBox4"
		Me.groupBox4.Size = New System.Drawing.Size(330, 110)
		Me.groupBox4.TabIndex = 3
		Me.groupBox4.TabStop = false
		Me.groupBox4.Text = "TROCO"
		'
		'txt_troco
		'
		Me.txt_troco.BackColor = System.Drawing.Color.Black
		Me.txt_troco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txt_troco.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_troco.ForeColor = System.Drawing.Color.Red
		Me.txt_troco.Location = New System.Drawing.Point(9, 41)
		Me.txt_troco.Name = "txt_troco"
		Me.txt_troco.ReadOnly = true
		Me.txt_troco.Size = New System.Drawing.Size(310, 49)
		Me.txt_troco.TabIndex = 0
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(84, 469)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(194, 175)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pictureBox1.TabIndex = 4
		Me.pictureBox1.TabStop = false
		'
		'pnl_lateral
		'
		Me.pnl_lateral.BackColor = System.Drawing.Color.Black
		Me.pnl_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_lateral.Controls.Add(Me.pictureBox1)
		Me.pnl_lateral.Controls.Add(Me.groupBox4)
		Me.pnl_lateral.Controls.Add(Me.groupBox3)
		Me.pnl_lateral.Controls.Add(Me.groupBox2)
		Me.pnl_lateral.Controls.Add(Me.groupBox1)
		Me.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Right
		Me.pnl_lateral.Location = New System.Drawing.Point(1011, 49)
		Me.pnl_lateral.Name = "pnl_lateral"
		Me.pnl_lateral.Size = New System.Drawing.Size(360, 660)
		Me.pnl_lateral.TabIndex = 3
		Me.pnl_lateral.Visible = false
		'
		'pnl_orcamento
		'
		Me.pnl_orcamento.BackColor = System.Drawing.Color.Gray
		Me.pnl_orcamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.pnl_orcamento.Controls.Add(Me.panel6)
		Me.pnl_orcamento.Location = New System.Drawing.Point(431, 261)
		Me.pnl_orcamento.Name = "pnl_orcamento"
		Me.pnl_orcamento.Size = New System.Drawing.Size(330, 104)
		Me.pnl_orcamento.TabIndex = 7
		Me.pnl_orcamento.Visible = false
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.Black
		Me.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.panel6.Controls.Add(Me.groupBox6)
		Me.panel6.Location = New System.Drawing.Point(4, 3)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(321, 96)
		Me.panel6.TabIndex = 1
		'
		'groupBox6
		'
		Me.groupBox6.Controls.Add(Me.txt_Norcamento)
		Me.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.groupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.groupBox6.ForeColor = System.Drawing.Color.White
		Me.groupBox6.Location = New System.Drawing.Point(7, 6)
		Me.groupBox6.Name = "groupBox6"
		Me.groupBox6.Size = New System.Drawing.Size(309, 85)
		Me.groupBox6.TabIndex = 0
		Me.groupBox6.TabStop = false
		Me.groupBox6.Text = "DIGITE O NÚMERO DO ORÇAMENTO"
		'
		'txt_Norcamento
		'
		Me.txt_Norcamento.BackColor = System.Drawing.Color.Black
		Me.txt_Norcamento.Font = New System.Drawing.Font("Bitstream Vera Sans Mono", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_Norcamento.ForeColor = System.Drawing.Color.White
		Me.txt_Norcamento.Location = New System.Drawing.Point(15, 31)
		Me.txt_Norcamento.Name = "txt_Norcamento"
		Me.txt_Norcamento.Size = New System.Drawing.Size(277, 30)
		Me.txt_Norcamento.TabIndex = 0
		AddHandler Me.txt_Norcamento.KeyDown, AddressOf Me.Txt_Norcamento_KeyDown
		AddHandler Me.txt_Norcamento.KeyPress, AddressOf Me.Txt_Norcamento_KeyPress
		'
		'FormPDV
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1371, 751)
		Me.Controls.Add(Me.pnl_principal)
		Me.Controls.Add(Me.pnl_lateral)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.lbl_central)
		Me.Controls.Add(Me.pnl_orcamento)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormPDV"
		Me.Text = "VENDAS"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler KeyDown, AddressOf Me.FormPDV_KeyDown
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.pnl_principal.ResumeLayout(false)
		Me.pnl_qtd.ResumeLayout(false)
		Me.panel4.ResumeLayout(false)
		Me.groupBox5.ResumeLayout(false)
		Me.groupBox5.PerformLayout
		Me.pnl_produto.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		CType(Me.dgv_produtos,System.ComponentModel.ISupportInitialize).EndInit
		Me.gb_Nomeproduto.ResumeLayout(false)
		Me.gb_Nomeproduto.PerformLayout
		Me.gb_status.ResumeLayout(false)
		Me.gb_status.PerformLayout
		Me.gb_venda.ResumeLayout(false)
		Me.gb_venda.PerformLayout
		CType(Me.dgv_itensOrcamento,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.groupBox2.ResumeLayout(false)
		Me.groupBox2.PerformLayout
		Me.groupBox3.ResumeLayout(false)
		Me.groupBox3.PerformLayout
		Me.groupBox4.ResumeLayout(false)
		Me.groupBox4.PerformLayout
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_lateral.ResumeLayout(false)
		Me.pnl_orcamento.ResumeLayout(false)
		Me.panel6.ResumeLayout(false)
		Me.groupBox6.ResumeLayout(false)
		Me.groupBox6.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lbl_idvenda As System.Windows.Forms.Label
	Private lbl_norcamento As System.Windows.Forms.Label
	Private dgv_itensOrcamento As System.Windows.Forms.DataGridView
	Private txt_Norcamento As System.Windows.Forms.TextBox
	Private groupBox6 As System.Windows.Forms.GroupBox
	Private panel6 As System.Windows.Forms.Panel
	Private pnl_orcamento As System.Windows.Forms.Panel
	Private cb_formaPagamento As System.Windows.Forms.ComboBox
	Private txt_FormaPagamento As System.Windows.Forms.TextBox
	Private idFornecedor As System.Windows.Forms.DataGridViewTextBoxColumn
	Private idProduto As System.Windows.Forms.DataGridViewTextBoxColumn
	Private lbl_cliente As System.Windows.Forms.Label
	Private txt_qtd As System.Windows.Forms.TextBox
	Private panel4 As System.Windows.Forms.Panel
	Private groupBox5 As System.Windows.Forms.GroupBox
	Private pnl_qtd As System.Windows.Forms.Panel
	Private VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
	Private PRECOUNITARIO As System.Windows.Forms.DataGridViewTextBoxColumn
	Private QTD As System.Windows.Forms.DataGridViewTextBoxColumn
	Private FORNECEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
	Private PRODUTO As System.Windows.Forms.DataGridViewTextBoxColumn
	Private panel3 As System.Windows.Forms.Panel
	Private dgv_produtos As System.Windows.Forms.DataGridView
	Private txt_produto As System.Windows.Forms.TextBox
	Private gb_Nomeproduto As System.Windows.Forms.GroupBox
	Private pnl_produto As System.Windows.Forms.Panel
	Private lbl_central As System.Windows.Forms.Label
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private txt_valorTotal As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private txt_desconto As System.Windows.Forms.TextBox
	Private groupBox2 As System.Windows.Forms.GroupBox
	Private txt_pago As System.Windows.Forms.TextBox
	Private groupBox3 As System.Windows.Forms.GroupBox
	Private txt_troco As System.Windows.Forms.TextBox
	Private groupBox4 As System.Windows.Forms.GroupBox
	Private bt_fechar As System.Windows.Forms.Button
	Private dgv_Itens As System.Windows.Forms.DataGridView
	Private lbl_status As System.Windows.Forms.Label
	Private gb_status As System.Windows.Forms.GroupBox
	Private lbl_rodape As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private txt_cliente As System.Windows.Forms.TextBox
	Private lbl_data As System.Windows.Forms.Label
	Private gb_venda As System.Windows.Forms.GroupBox
	Private pnl_lateral As System.Windows.Forms.Panel
	Private pnl_principal As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel

End Class
