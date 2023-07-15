'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormEstoque
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstoque))
		Dim dataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim dataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.lbl_rodape = New System.Windows.Forms.Label()
		Me.pnl_principal = New System.Windows.Forms.Panel()
		Me.dgv_Itens = New System.Windows.Forms.DataGridView()
		Me.pictureBox1 = New System.Windows.Forms.PictureBox()
		Me.pnl_lateral = New System.Windows.Forms.Panel()
		Me.bt_imprimir = New System.Windows.Forms.Button()
		Me.gb_pesquisa = New System.Windows.Forms.GroupBox()
		Me.dgv_pesquisa = New System.Windows.Forms.DataGridView()
		Me.txt_pesquisa = New System.Windows.Forms.TextBox()
		Me.gb_exibirEstoque = New System.Windows.Forms.GroupBox()
		Me.rb_todos = New System.Windows.Forms.RadioButton()
		Me.rb_qtd = New System.Windows.Forms.RadioButton()
		Me.rb_fornecedor = New System.Windows.Forms.RadioButton()
		Me.rb_produto = New System.Windows.Forms.RadioButton()
		Me.rb_categoria = New System.Windows.Forms.RadioButton()
		Me.rb_ProdutoZerado = New System.Windows.Forms.RadioButton()
		Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.panel1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.pnl_principal.SuspendLayout
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.pnl_lateral.SuspendLayout
		Me.gb_pesquisa.SuspendLayout
		CType(Me.dgv_pesquisa,System.ComponentModel.ISupportInitialize).BeginInit
		Me.gb_exibirEstoque.SuspendLayout
		Me.SuspendLayout
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
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
		Me.label1.Size = New System.Drawing.Size(161, 38)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Estoque"
		'
		'panel2
		'
		Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
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
		Me.bt_fechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White
		Me.bt_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
		Me.bt_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
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
		Me.lbl_rodape.Size = New System.Drawing.Size(152, 18)
		Me.lbl_rodape.TabIndex = 0
		Me.lbl_rodape.Text = "F1 - Exibir Estoque"
		'
		'pnl_principal
		'
		Me.pnl_principal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.pnl_principal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_principal.Controls.Add(Me.dgv_Itens)
		Me.pnl_principal.Dock = System.Windows.Forms.DockStyle.Fill
		Me.pnl_principal.Location = New System.Drawing.Point(0, 49)
		Me.pnl_principal.Name = "pnl_principal"
		Me.pnl_principal.Size = New System.Drawing.Size(1371, 660)
		Me.pnl_principal.TabIndex = 2
		'
		'dgv_Itens
		'
		Me.dgv_Itens.AllowUserToAddRows = false
		Me.dgv_Itens.AllowUserToResizeRows = false
		Me.dgv_Itens.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.dgv_Itens.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgv_Itens.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_Itens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
		dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_Itens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
		Me.dgv_Itens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
		dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_Itens.DefaultCellStyle = dataGridViewCellStyle2
		Me.dgv_Itens.EnableHeadersVisualStyles = false
		Me.dgv_Itens.Location = New System.Drawing.Point(215, 16)
		Me.dgv_Itens.MultiSelect = false
		Me.dgv_Itens.Name = "dgv_Itens"
		Me.dgv_Itens.ReadOnly = true
		Me.dgv_Itens.RowHeadersVisible = false
		Me.dgv_Itens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Itens.Size = New System.Drawing.Size(1142, 587)
		Me.dgv_Itens.TabIndex = 3
		AddHandler Me.dgv_Itens.KeyDown, AddressOf Me.Dgv_Itens_KeyDown
		'
		'pictureBox1
		'
		Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"),System.Drawing.Image)
		Me.pictureBox1.Location = New System.Drawing.Point(19, 490)
		Me.pictureBox1.Name = "pictureBox1"
		Me.pictureBox1.Size = New System.Drawing.Size(152, 161)
		Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
		Me.pictureBox1.TabIndex = 4
		Me.pictureBox1.TabStop = false
		'
		'pnl_lateral
		'
		Me.pnl_lateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.pnl_lateral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.pnl_lateral.Controls.Add(Me.bt_imprimir)
		Me.pnl_lateral.Controls.Add(Me.gb_pesquisa)
		Me.pnl_lateral.Controls.Add(Me.gb_exibirEstoque)
		Me.pnl_lateral.Controls.Add(Me.pictureBox1)
		Me.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Left
		Me.pnl_lateral.Location = New System.Drawing.Point(0, 49)
		Me.pnl_lateral.Name = "pnl_lateral"
		Me.pnl_lateral.Size = New System.Drawing.Size(209, 660)
		Me.pnl_lateral.TabIndex = 3
		'
		'bt_imprimir
		'
		Me.bt_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.bt_imprimir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
		Me.bt_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
		Me.bt_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.bt_imprimir.ForeColor = System.Drawing.Color.White
		Me.bt_imprimir.Image = CType(resources.GetObject("bt_imprimir.Image"),System.Drawing.Image)
		Me.bt_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.bt_imprimir.Location = New System.Drawing.Point(3, 431)
		Me.bt_imprimir.Name = "bt_imprimir"
		Me.bt_imprimir.Size = New System.Drawing.Size(152, 43)
		Me.bt_imprimir.TabIndex = 7
		Me.bt_imprimir.Text = "&Imprimir Estoque"
		Me.bt_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.toolTip1.SetToolTip(Me.bt_imprimir, "Imprimir Relatório de Estoque")
		Me.bt_imprimir.UseVisualStyleBackColor = true
		'
		'gb_pesquisa
		'
		Me.gb_pesquisa.Controls.Add(Me.dgv_pesquisa)
		Me.gb_pesquisa.Controls.Add(Me.txt_pesquisa)
		Me.gb_pesquisa.ForeColor = System.Drawing.Color.White
		Me.gb_pesquisa.Location = New System.Drawing.Point(3, 175)
		Me.gb_pesquisa.Name = "gb_pesquisa"
		Me.gb_pesquisa.Size = New System.Drawing.Size(192, 250)
		Me.gb_pesquisa.TabIndex = 6
		Me.gb_pesquisa.TabStop = false
		Me.gb_pesquisa.Visible = false
		'
		'dgv_pesquisa
		'
		Me.dgv_pesquisa.AllowUserToAddRows = false
		Me.dgv_pesquisa.AllowUserToResizeRows = false
		Me.dgv_pesquisa.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.dgv_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.dgv_pesquisa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
		Me.dgv_pesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
		dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgv_pesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3
		Me.dgv_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		dataGridViewCellStyle4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
		dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
		dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue
		dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgv_pesquisa.DefaultCellStyle = dataGridViewCellStyle4
		Me.dgv_pesquisa.EnableHeadersVisualStyles = false
		Me.dgv_pesquisa.Location = New System.Drawing.Point(8, 49)
		Me.dgv_pesquisa.MultiSelect = false
		Me.dgv_pesquisa.Name = "dgv_pesquisa"
		Me.dgv_pesquisa.ReadOnly = true
		Me.dgv_pesquisa.RowHeadersVisible = false
		Me.dgv_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_pesquisa.Size = New System.Drawing.Size(173, 187)
		Me.dgv_pesquisa.TabIndex = 5
		AddHandler Me.dgv_pesquisa.KeyDown, AddressOf Me.Dgv_pesquisa_KeyDown
		'
		'txt_pesquisa
		'
		Me.txt_pesquisa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.txt_pesquisa.ForeColor = System.Drawing.Color.White
		Me.txt_pesquisa.Location = New System.Drawing.Point(7, 20)
		Me.txt_pesquisa.Name = "txt_pesquisa"
		Me.txt_pesquisa.Size = New System.Drawing.Size(175, 20)
		Me.txt_pesquisa.TabIndex = 0
		AddHandler Me.txt_pesquisa.KeyDown, AddressOf Me.Txt_pesquisa_KeyDown
		'
		'gb_exibirEstoque
		'
		Me.gb_exibirEstoque.Controls.Add(Me.rb_todos)
		Me.gb_exibirEstoque.Controls.Add(Me.rb_qtd)
		Me.gb_exibirEstoque.Controls.Add(Me.rb_fornecedor)
		Me.gb_exibirEstoque.Controls.Add(Me.rb_produto)
		Me.gb_exibirEstoque.Controls.Add(Me.rb_categoria)
		Me.gb_exibirEstoque.Controls.Add(Me.rb_ProdutoZerado)
		Me.gb_exibirEstoque.ForeColor = System.Drawing.Color.White
		Me.gb_exibirEstoque.Location = New System.Drawing.Point(3, 16)
		Me.gb_exibirEstoque.Name = "gb_exibirEstoque"
		Me.gb_exibirEstoque.Size = New System.Drawing.Size(192, 153)
		Me.gb_exibirEstoque.TabIndex = 5
		Me.gb_exibirEstoque.TabStop = false
		Me.gb_exibirEstoque.Text = "Exibir Por : "
		AddHandler Me.gb_exibirEstoque.PreviewKeyDown, AddressOf Me.Gb_exibirEstoque_PreviewKeyDown
		'
		'rb_todos
		'
		Me.rb_todos.AutoSize = true
		Me.rb_todos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_todos.Location = New System.Drawing.Point(16, 126)
		Me.rb_todos.Name = "rb_todos"
		Me.rb_todos.Size = New System.Drawing.Size(55, 17)
		Me.rb_todos.TabIndex = 5
		Me.rb_todos.TabStop = true
		Me.rb_todos.Text = "&Todos"
		Me.toolTip1.SetToolTip(Me.rb_todos, "Pressione (Alt + t) para selecionar esta opção")
		Me.rb_todos.UseVisualStyleBackColor = false
		AddHandler Me.rb_todos.Click, AddressOf Me.Rb_todos_Click
		'
		'rb_qtd
		'
		Me.rb_qtd.AutoSize = true
		Me.rb_qtd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_qtd.Location = New System.Drawing.Point(16, 106)
		Me.rb_qtd.Name = "rb_qtd"
		Me.rb_qtd.Size = New System.Drawing.Size(48, 17)
		Me.rb_qtd.TabIndex = 4
		Me.rb_qtd.TabStop = true
		Me.rb_qtd.Text = "&QTD"
		Me.toolTip1.SetToolTip(Me.rb_qtd, "Pressione (Alt + q) para selecionar esta opção")
		Me.rb_qtd.UseVisualStyleBackColor = false
		AddHandler Me.rb_qtd.Click, AddressOf Me.Rb_qtd_Click
		'
		'rb_fornecedor
		'
		Me.rb_fornecedor.AutoSize = true
		Me.rb_fornecedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_fornecedor.Location = New System.Drawing.Point(16, 87)
		Me.rb_fornecedor.Name = "rb_fornecedor"
		Me.rb_fornecedor.Size = New System.Drawing.Size(79, 17)
		Me.rb_fornecedor.TabIndex = 3
		Me.rb_fornecedor.TabStop = true
		Me.rb_fornecedor.Text = "F&ornecedor"
		Me.toolTip1.SetToolTip(Me.rb_fornecedor, "Pressione (Alt + o) para selecionar esta opção")
		Me.rb_fornecedor.UseVisualStyleBackColor = false
		AddHandler Me.rb_fornecedor.Click, AddressOf Me.Rb_fornecedor_Click
		'
		'rb_produto
		'
		Me.rb_produto.AutoSize = true
		Me.rb_produto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_produto.Location = New System.Drawing.Point(16, 68)
		Me.rb_produto.Name = "rb_produto"
		Me.rb_produto.Size = New System.Drawing.Size(62, 17)
		Me.rb_produto.TabIndex = 2
		Me.rb_produto.TabStop = true
		Me.rb_produto.Text = "&Produto"
		Me.toolTip1.SetToolTip(Me.rb_produto, "Pressione (Alt + p) para selecionar esta opção")
		Me.rb_produto.UseVisualStyleBackColor = false
		AddHandler Me.rb_produto.Click, AddressOf Me.Rb_produto_Click
		'
		'rb_categoria
		'
		Me.rb_categoria.AutoSize = true
		Me.rb_categoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_categoria.Location = New System.Drawing.Point(16, 48)
		Me.rb_categoria.Name = "rb_categoria"
		Me.rb_categoria.Size = New System.Drawing.Size(70, 17)
		Me.rb_categoria.TabIndex = 1
		Me.rb_categoria.TabStop = true
		Me.rb_categoria.Text = "&Categoria"
		Me.toolTip1.SetToolTip(Me.rb_categoria, "Pressione (Alt + c) para selecionar esta opção")
		Me.rb_categoria.UseVisualStyleBackColor = false
		AddHandler Me.rb_categoria.Click, AddressOf Me.Rb_categoria_Click
		'
		'rb_ProdutoZerado
		'
		Me.rb_ProdutoZerado.AutoSize = true
		Me.rb_ProdutoZerado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.rb_ProdutoZerado.Location = New System.Drawing.Point(16, 26)
		Me.rb_ProdutoZerado.Name = "rb_ProdutoZerado"
		Me.rb_ProdutoZerado.Size = New System.Drawing.Size(109, 17)
		Me.rb_ProdutoZerado.TabIndex = 0
		Me.rb_ProdutoZerado.TabStop = true
		Me.rb_ProdutoZerado.Text = "Produtos &Zerados"
		Me.toolTip1.SetToolTip(Me.rb_ProdutoZerado, "Pressione (Alt + z) para selecionar esta opção")
		Me.rb_ProdutoZerado.UseVisualStyleBackColor = false
		AddHandler Me.rb_ProdutoZerado.Click, AddressOf Me.Rb_ProdutoZerado_Click
		'
		'toolTip1
		'
		Me.toolTip1.IsBalloon = true
		'
		'FormEstoque
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.ClientSize = New System.Drawing.Size(1371, 751)
		Me.Controls.Add(Me.pnl_lateral)
		Me.Controls.Add(Me.pnl_principal)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.panel1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormEstoque"
		Me.Text = "PRÉ VENDA"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		AddHandler Shown, AddressOf Me.FormEstoque_Shown
		AddHandler KeyDown, AddressOf Me.FormEstoque_KeyDown
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.pnl_principal.ResumeLayout(false)
		CType(Me.dgv_Itens,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.pictureBox1,System.ComponentModel.ISupportInitialize).EndInit
		Me.pnl_lateral.ResumeLayout(false)
		Me.gb_pesquisa.ResumeLayout(false)
		Me.gb_pesquisa.PerformLayout
		CType(Me.dgv_pesquisa,System.ComponentModel.ISupportInitialize).EndInit
		Me.gb_exibirEstoque.ResumeLayout(false)
		Me.gb_exibirEstoque.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private bt_imprimir As System.Windows.Forms.Button
	Private dgv_pesquisa As System.Windows.Forms.DataGridView
	Private toolTip1 As System.Windows.Forms.ToolTip
	Private txt_pesquisa As System.Windows.Forms.TextBox
	Private gb_pesquisa As System.Windows.Forms.GroupBox
	Private rb_ProdutoZerado As System.Windows.Forms.RadioButton
	Private rb_categoria As System.Windows.Forms.RadioButton
	Private rb_produto As System.Windows.Forms.RadioButton
	Private rb_fornecedor As System.Windows.Forms.RadioButton
	Private rb_qtd As System.Windows.Forms.RadioButton
	Private rb_todos As System.Windows.Forms.RadioButton
	Private gb_exibirEstoque As System.Windows.Forms.GroupBox
	Private pictureBox1 As System.Windows.Forms.PictureBox
	Private bt_fechar As System.Windows.Forms.Button
	Private dgv_Itens As System.Windows.Forms.DataGridView
	Private lbl_rodape As System.Windows.Forms.Label
	Private pnl_lateral As System.Windows.Forms.Panel
	Private pnl_principal As System.Windows.Forms.Panel
	Private panel2 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private panel1 As System.Windows.Forms.Panel

End Class
