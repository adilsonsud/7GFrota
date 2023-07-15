'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormProdutos
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
		Me.dgv_Produtos = New System.Windows.Forms.DataGridView()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.txt_Localizar = New System.Windows.Forms.TextBox()
		Me.tabCadastrar = New System.Windows.Forms.TabPage()
		Me.tabControl2 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.cb_Categoria = New System.Windows.Forms.ComboBox()
		Me.label5 = New System.Windows.Forms.Label()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.bt_salvar = New System.Windows.Forms.Button()
		Me.bt_excluir = New System.Windows.Forms.Button()
		Me.bt_editar = New System.Windows.Forms.Button()
		Me.bt_novo = New System.Windows.Forms.Button()
		Me.txt_nome = New System.Windows.Forms.TextBox()
		Me.txt_id = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.bt_fechar = New System.Windows.Forms.Button()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.tabControl1.SuspendLayout
		Me.tabLocalizar.SuspendLayout
		CType(Me.dgv_Produtos,System.ComponentModel.ISupportInitialize).BeginInit
		Me.groupBox1.SuspendLayout
		Me.tabCadastrar.SuspendLayout
		Me.tabControl2.SuspendLayout
		Me.tabPage1.SuspendLayout
		Me.panel5.SuspendLayout
		Me.panel3.SuspendLayout
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
		Me.tabControl1.Size = New System.Drawing.Size(470, 353)
		Me.tabControl1.TabIndex = 1
		'
		'tabLocalizar
		'
		Me.tabLocalizar.Controls.Add(Me.dgv_Produtos)
		Me.tabLocalizar.Controls.Add(Me.groupBox1)
		Me.tabLocalizar.Location = New System.Drawing.Point(4, 25)
		Me.tabLocalizar.Name = "tabLocalizar"
		Me.tabLocalizar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabLocalizar.Size = New System.Drawing.Size(462, 324)
		Me.tabLocalizar.TabIndex = 0
		Me.tabLocalizar.Text = "Localizar"
		Me.tabLocalizar.UseVisualStyleBackColor = true
		AddHandler Me.tabLocalizar.Enter, AddressOf Me.TabLocalizarEnter
		'
		'dgv_Produtos
		'
		Me.dgv_Produtos.AllowUserToAddRows = false
		Me.dgv_Produtos.AllowUserToDeleteRows = false
		Me.dgv_Produtos.AllowUserToOrderColumns = true
		Me.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgv_Produtos.Location = New System.Drawing.Point(8, 78)
		Me.dgv_Produtos.MultiSelect = false
		Me.dgv_Produtos.Name = "dgv_Produtos"
		Me.dgv_Produtos.ReadOnly = true
		Me.dgv_Produtos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.dgv_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgv_Produtos.Size = New System.Drawing.Size(445, 231)
		Me.dgv_Produtos.TabIndex = 1
		AddHandler Me.dgv_Produtos.DoubleClick, AddressOf Me.Dgv_Produtos_DoubleClick
		AddHandler Me.dgv_Produtos.KeyDown, AddressOf Me.Dgv_ProdutosKeyDown
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.txt_Localizar)
		Me.groupBox1.Location = New System.Drawing.Point(8, 6)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(445, 66)
		Me.groupBox1.TabIndex = 0
		Me.groupBox1.TabStop = false
		Me.groupBox1.Text = "Digite o Nome do Produto"
		'
		'txt_Localizar
		'
		Me.txt_Localizar.Location = New System.Drawing.Point(9, 29)
		Me.txt_Localizar.Name = "txt_Localizar"
		Me.txt_Localizar.Size = New System.Drawing.Size(381, 20)
		Me.txt_Localizar.TabIndex = 0
		AddHandler Me.txt_Localizar.KeyDown, AddressOf Me.Txt_LocalizarKeyDown
		'
		'tabCadastrar
		'
		Me.tabCadastrar.Controls.Add(Me.tabControl2)
		Me.tabCadastrar.Location = New System.Drawing.Point(4, 25)
		Me.tabCadastrar.Name = "tabCadastrar"
		Me.tabCadastrar.Padding = New System.Windows.Forms.Padding(3)
		Me.tabCadastrar.Size = New System.Drawing.Size(462, 324)
		Me.tabCadastrar.TabIndex = 1
		Me.tabCadastrar.Text = "Cadastrar"
		Me.tabCadastrar.UseVisualStyleBackColor = true
		'
		'tabControl2
		'
		Me.tabControl2.Controls.Add(Me.tabPage1)
		Me.tabControl2.Location = New System.Drawing.Point(16, 10)
		Me.tabControl2.Name = "tabControl2"
		Me.tabControl2.SelectedIndex = 0
		Me.tabControl2.Size = New System.Drawing.Size(437, 275)
		Me.tabControl2.TabIndex = 0
		'
		'tabPage1
		'
		Me.tabPage1.Controls.Add(Me.cb_Categoria)
		Me.tabPage1.Controls.Add(Me.label5)
		Me.tabPage1.Controls.Add(Me.panel5)
		Me.tabPage1.Controls.Add(Me.panel3)
		Me.tabPage1.Controls.Add(Me.bt_salvar)
		Me.tabPage1.Controls.Add(Me.bt_excluir)
		Me.tabPage1.Controls.Add(Me.bt_editar)
		Me.tabPage1.Controls.Add(Me.bt_novo)
		Me.tabPage1.Controls.Add(Me.txt_nome)
		Me.tabPage1.Controls.Add(Me.txt_id)
		Me.tabPage1.Controls.Add(Me.label4)
		Me.tabPage1.Controls.Add(Me.label3)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(429, 249)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Produtos"
		Me.tabPage1.UseVisualStyleBackColor = true
		'
		'cb_Categoria
		'
		Me.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cb_Categoria.FormattingEnabled = true
		Me.cb_Categoria.Location = New System.Drawing.Point(114, 93)
		Me.cb_Categoria.Name = "cb_Categoria"
		Me.cb_Categoria.Size = New System.Drawing.Size(253, 21)
		Me.cb_Categoria.TabIndex = 17
		AddHandler Me.cb_Categoria.KeyDown, AddressOf Me.Cb_Categoria_KeyDown
		'
		'label5
		'
		Me.label5.AutoSize = true
		Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label5.Location = New System.Drawing.Point(33, 96)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(78, 13)
		Me.label5.TabIndex = 16
		Me.label5.Text = "CATEGORIA"
		'
		'panel5
		'
		Me.panel5.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel5.Controls.Add(Me.panel6)
		Me.panel5.Location = New System.Drawing.Point(13, 173)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(400, 2)
		Me.panel5.TabIndex = 15
		'
		'panel6
		'
		Me.panel6.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel6.Location = New System.Drawing.Point(0, 159)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(705, 1)
		Me.panel6.TabIndex = 15
		'
		'panel3
		'
		Me.panel3.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel3.Controls.Add(Me.panel4)
		Me.panel3.Location = New System.Drawing.Point(13, 19)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(400, 2)
		Me.panel3.TabIndex = 14
		'
		'panel4
		'
		Me.panel4.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel4.Location = New System.Drawing.Point(0, 159)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(705, 1)
		Me.panel4.TabIndex = 15
		'
		'bt_salvar
		'
		Me.bt_salvar.BackColor = System.Drawing.Color.MidnightBlue
		Me.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_salvar.ForeColor = System.Drawing.Color.White
		Me.bt_salvar.Location = New System.Drawing.Point(37, 184)
		Me.bt_salvar.Name = "bt_salvar"
		Me.bt_salvar.Size = New System.Drawing.Size(98, 23)
		Me.bt_salvar.TabIndex = 18
		Me.bt_salvar.Text = "&Salvar"
		Me.bt_salvar.UseVisualStyleBackColor = false
		Me.bt_salvar.Visible = false
		AddHandler Me.bt_salvar.Click, AddressOf Me.Bt_salvarClick
		AddHandler Me.bt_salvar.KeyDown, AddressOf Me.Bt_salvar_KeyDown
		'
		'bt_excluir
		'
		Me.bt_excluir.BackColor = System.Drawing.Color.MidnightBlue
		Me.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand
		Me.bt_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_excluir.ForeColor = System.Drawing.Color.White
		Me.bt_excluir.Location = New System.Drawing.Point(168, 184)
		Me.bt_excluir.Name = "bt_excluir"
		Me.bt_excluir.Size = New System.Drawing.Size(75, 23)
		Me.bt_excluir.TabIndex = 12
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
		Me.bt_editar.Location = New System.Drawing.Point(92, 184)
		Me.bt_editar.Name = "bt_editar"
		Me.bt_editar.Size = New System.Drawing.Size(75, 23)
		Me.bt_editar.TabIndex = 11
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
		Me.bt_novo.Location = New System.Drawing.Point(16, 184)
		Me.bt_novo.Name = "bt_novo"
		Me.bt_novo.Size = New System.Drawing.Size(75, 23)
		Me.bt_novo.TabIndex = 10
		Me.bt_novo.Text = "&Novo"
		Me.bt_novo.UseVisualStyleBackColor = false
		AddHandler Me.bt_novo.Click, AddressOf Me.Bt_novoClick
		'
		'txt_nome
		'
		Me.txt_nome.Location = New System.Drawing.Point(114, 65)
		Me.txt_nome.Name = "txt_nome"
		Me.txt_nome.Size = New System.Drawing.Size(253, 20)
		Me.txt_nome.TabIndex = 6
		'
		'txt_id
		'
		Me.txt_id.Location = New System.Drawing.Point(114, 39)
		Me.txt_id.Name = "txt_id"
		Me.txt_id.ReadOnly = true
		Me.txt_id.Size = New System.Drawing.Size(100, 20)
		Me.txt_id.TabIndex = 5
		'
		'label4
		'
		Me.label4.AutoSize = true
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label4.Location = New System.Drawing.Point(3, 68)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(108, 13)
		Me.label4.TabIndex = 1
		Me.label4.Text = "NOME RPODUTO"
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
		Me.label3.Location = New System.Drawing.Point(91, 42)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(20, 13)
		Me.label3.TabIndex = 0
		Me.label3.Text = "ID"
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
		Me.bt_fechar.Location = New System.Drawing.Point(382, 7)
		Me.bt_fechar.Name = "bt_fechar"
		Me.bt_fechar.Size = New System.Drawing.Size(75, 28)
		Me.bt_fechar.TabIndex = 2
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
		Me.panel2.Location = New System.Drawing.Point(0, 394)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(470, 41)
		Me.panel2.TabIndex = 2
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.ForeColor = System.Drawing.Color.White
		Me.label2.Location = New System.Drawing.Point(12, 11)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(214, 18)
		Me.label2.TabIndex = 0
		Me.label2.Text = "F1 Localizar / F3 Cadastrar"
		'
		'label1
		'
		Me.label1.AutoSize = true
		Me.label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.ForeColor = System.Drawing.Color.White
		Me.label1.Location = New System.Drawing.Point(12, 8)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(286, 24)
		Me.label1.TabIndex = 1
		Me.label1.Text = "CADASTRO DE PRODUTOS"
		'
		'panel1
		'
		Me.panel1.BackColor = System.Drawing.Color.MidnightBlue
		Me.panel1.Controls.Add(Me.label1)
		Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.panel1.Location = New System.Drawing.Point(0, 0)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(470, 41)
		Me.panel1.TabIndex = 0
		'
		'FormProdutos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(470, 435)
		Me.Controls.Add(Me.tabControl1)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.panel2)
		Me.KeyPreview = true
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "FormProdutos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "PRODUTOS"
		AddHandler FormClosed, AddressOf Me.FormProdutos_FormClosed
		AddHandler Shown, AddressOf Me.FormProdutos_Shown
		AddHandler KeyDown, AddressOf Me.FormProdutosKeyDown
		AddHandler KeyPress, AddressOf Me.FormProdutos_KeyPress
		Me.tabControl1.ResumeLayout(false)
		Me.tabLocalizar.ResumeLayout(false)
		CType(Me.dgv_Produtos,System.ComponentModel.ISupportInitialize).EndInit
		Me.groupBox1.ResumeLayout(false)
		Me.groupBox1.PerformLayout
		Me.tabCadastrar.ResumeLayout(false)
		Me.tabControl2.ResumeLayout(false)
		Me.tabPage1.ResumeLayout(false)
		Me.tabPage1.PerformLayout
		Me.panel5.ResumeLayout(false)
		Me.panel3.ResumeLayout(false)
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private cb_Categoria As System.Windows.Forms.ComboBox
	Private label5 As System.Windows.Forms.Label
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
	Private label3 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private txt_id As System.Windows.Forms.TextBox
	Private txt_nome As System.Windows.Forms.TextBox
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabControl2 As System.Windows.Forms.TabControl
	Private txt_Localizar As System.Windows.Forms.TextBox
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private dgv_Produtos As System.Windows.Forms.DataGridView
	Private label2 As System.Windows.Forms.Label
	Private panel2 As System.Windows.Forms.Panel
	Private bt_fechar As System.Windows.Forms.Button
	Private tabCadastrar As System.Windows.Forms.TabPage
	Private tabLocalizar As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
End Class
