'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 27/2/2014
' Hora: 23:36
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class MainForm
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
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.cadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.categoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuItemClientes = New System.Windows.Forms.ToolStripMenuItem()
		Me.formaDePagamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuItemFornecedores = New System.Windows.Forms.ToolStripMenuItem()
		Me.produtosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.comprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.porFornecedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.orçamentoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.consultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.relatórioDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.comprasDetalheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.vendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.préVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.pDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.orçamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.consultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.categoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.analíticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.sintéticoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.statusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.relatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.estoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.menuStrip1.SuspendLayout
		Me.SuspendLayout
		'
		'menuStrip1
		'
		Me.menuStrip1.BackColor = System.Drawing.SystemColors.Control
		Me.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Close
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cadastroToolStripMenuItem, Me.comprasToolStripMenuItem, Me.vendasToolStripMenuItem, Me.relatoriosToolStripMenuItem})
		Me.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.menuStrip1.Size = New System.Drawing.Size(880, 23)
		Me.menuStrip1.TabIndex = 0
		Me.menuStrip1.Text = "menuStrip1"
		'
		'cadastroToolStripMenuItem
		'
		Me.cadastroToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
		Me.cadastroToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.cadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.categoriasToolStripMenuItem, Me.MenuItemClientes, Me.formaDePagamentoToolStripMenuItem, Me.MenuItemFornecedores, Me.produtosToolStripMenuItem})
		Me.cadastroToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
		Me.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem"
		Me.cadastroToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
		Me.cadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 19)
		Me.cadastroToolStripMenuItem.Text = "Cadastro"
		Me.cadastroToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
		'
		'categoriasToolStripMenuItem
		'
		Me.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem"
		Me.categoriasToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
		Me.categoriasToolStripMenuItem.Text = "Categorias"
		AddHandler Me.categoriasToolStripMenuItem.Click, AddressOf Me.CategoriasToolStripMenuItem_Click
		'
		'MenuItemClientes
		'
		Me.MenuItemClientes.Name = "MenuItemClientes"
		Me.MenuItemClientes.Size = New System.Drawing.Size(188, 22)
		Me.MenuItemClientes.Text = "Clientes"
		AddHandler Me.MenuItemClientes.Click, AddressOf Me.MenuItemClientes_Click
		'
		'formaDePagamentoToolStripMenuItem
		'
		Me.formaDePagamentoToolStripMenuItem.Name = "formaDePagamentoToolStripMenuItem"
		Me.formaDePagamentoToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
		Me.formaDePagamentoToolStripMenuItem.Text = "Forma de Pagamento"
		AddHandler Me.formaDePagamentoToolStripMenuItem.Click, AddressOf Me.FormaDePagamentoToolStripMenuItem_Click
		'
		'MenuItemFornecedores
		'
		Me.MenuItemFornecedores.Name = "MenuItemFornecedores"
		Me.MenuItemFornecedores.Size = New System.Drawing.Size(188, 22)
		Me.MenuItemFornecedores.Text = "Fornecedores"
		AddHandler Me.MenuItemFornecedores.Click, AddressOf Me.MenuItemFornecedores_Click
		'
		'produtosToolStripMenuItem
		'
		Me.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem"
		Me.produtosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
		Me.produtosToolStripMenuItem.Text = "Produtos"
		AddHandler Me.produtosToolStripMenuItem.Click, AddressOf Me.ProdutosToolStripMenuItem_Click
		'
		'comprasToolStripMenuItem
		'
		Me.comprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.porFornecedorToolStripMenuItem, Me.orçamentoToolStripMenuItem1, Me.consultarToolStripMenuItem})
		Me.comprasToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
		Me.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem"
		Me.comprasToolStripMenuItem.Size = New System.Drawing.Size(67, 19)
		Me.comprasToolStripMenuItem.Text = "Compras"
		'
		'porFornecedorToolStripMenuItem
		'
		Me.porFornecedorToolStripMenuItem.Name = "porFornecedorToolStripMenuItem"
		Me.porFornecedorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.porFornecedorToolStripMenuItem.Text = "Inserir Compra"
		AddHandler Me.porFornecedorToolStripMenuItem.Click, AddressOf Me.PorFornecedorToolStripMenuItem_Click
		'
		'orçamentoToolStripMenuItem1
		'
		Me.orçamentoToolStripMenuItem1.Name = "orçamentoToolStripMenuItem1"
		Me.orçamentoToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.orçamentoToolStripMenuItem1.Text = "Cotação"
		AddHandler Me.orçamentoToolStripMenuItem1.Click, AddressOf Me.OrçamentoToolStripMenuItem1Click
		'
		'consultarToolStripMenuItem
		'
		Me.consultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.relatórioDeToolStripMenuItem, Me.comprasDetalheToolStripMenuItem})
		Me.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem"
		Me.consultarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.consultarToolStripMenuItem.Text = "Consultar"
		'
		'relatórioDeToolStripMenuItem
		'
		Me.relatórioDeToolStripMenuItem.Name = "relatórioDeToolStripMenuItem"
		Me.relatórioDeToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
		Me.relatórioDeToolStripMenuItem.Text = "Relatório de Compras"
		AddHandler Me.relatórioDeToolStripMenuItem.Click, AddressOf Me.RelatórioDeToolStripMenuItem_Click
		'
		'comprasDetalheToolStripMenuItem
		'
		Me.comprasDetalheToolStripMenuItem.Name = "comprasDetalheToolStripMenuItem"
		Me.comprasDetalheToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
		Me.comprasDetalheToolStripMenuItem.Text = "Relatório de Compras Detalhe"
		AddHandler Me.comprasDetalheToolStripMenuItem.Click, AddressOf Me.ComprasDetalheToolStripMenuItem_Click
		'
		'vendasToolStripMenuItem
		'
		Me.vendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.préVendaToolStripMenuItem, Me.pDVToolStripMenuItem, Me.orçamentoToolStripMenuItem, Me.consultarToolStripMenuItem1})
		Me.vendasToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
		Me.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem"
		Me.vendasToolStripMenuItem.Size = New System.Drawing.Size(57, 19)
		Me.vendasToolStripMenuItem.Text = "Vendas"
		'
		'préVendaToolStripMenuItem
		'
		Me.préVendaToolStripMenuItem.Name = "préVendaToolStripMenuItem"
		Me.préVendaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.préVendaToolStripMenuItem.Text = "Pré Venda"
		AddHandler Me.préVendaToolStripMenuItem.Click, AddressOf Me.PréVendaToolStripMenuItem_Click
		'
		'pDVToolStripMenuItem
		'
		Me.pDVToolStripMenuItem.Name = "pDVToolStripMenuItem"
		Me.pDVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.pDVToolStripMenuItem.Text = "PDV"
		AddHandler Me.pDVToolStripMenuItem.Click, AddressOf Me.PDVToolStripMenuItem_Click
		'
		'orçamentoToolStripMenuItem
		'
		Me.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem"
		Me.orçamentoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.orçamentoToolStripMenuItem.Text = "Orçamento"
		AddHandler Me.orçamentoToolStripMenuItem.Click, AddressOf Me.OrçamentoToolStripMenuItem_Click
		'
		'consultarToolStripMenuItem1
		'
		Me.consultarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.categoriaToolStripMenuItem, Me.statusToolStripMenuItem})
		Me.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1"
		Me.consultarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
		Me.consultarToolStripMenuItem1.Text = "Consultar"
		'
		'categoriaToolStripMenuItem
		'
		Me.categoriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.analíticoToolStripMenuItem, Me.sintéticoToolStripMenuItem})
		Me.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem"
		Me.categoriaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
		Me.categoriaToolStripMenuItem.Text = "Relatorio de Vendas"
		AddHandler Me.categoriaToolStripMenuItem.Click, AddressOf Me.CategoriaToolStripMenuItemClick
		'
		'analíticoToolStripMenuItem
		'
		Me.analíticoToolStripMenuItem.Name = "analíticoToolStripMenuItem"
		Me.analíticoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.analíticoToolStripMenuItem.Text = "Analítico"
		AddHandler Me.analíticoToolStripMenuItem.Click, AddressOf Me.AnalíticoToolStripMenuItemClick
		'
		'sintéticoToolStripMenuItem
		'
		Me.sintéticoToolStripMenuItem.Name = "sintéticoToolStripMenuItem"
		Me.sintéticoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.sintéticoToolStripMenuItem.Text = "Sintético"
		'
		'statusToolStripMenuItem
		'
		Me.statusToolStripMenuItem.Name = "statusToolStripMenuItem"
		Me.statusToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
		Me.statusToolStripMenuItem.Text = "Status"
		AddHandler Me.statusToolStripMenuItem.Click, AddressOf Me.StatusToolStripMenuItemClick
		'
		'relatoriosToolStripMenuItem
		'
		Me.relatoriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.estoqueToolStripMenuItem})
		Me.relatoriosToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
		Me.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem"
		Me.relatoriosToolStripMenuItem.Size = New System.Drawing.Size(61, 19)
		Me.relatoriosToolStripMenuItem.Text = "Estoque"
		'
		'estoqueToolStripMenuItem
		'
		Me.estoqueToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
		Me.estoqueToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
		Me.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem"
		Me.estoqueToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
		Me.estoqueToolStripMenuItem.Text = "Visualizar Estoque"
		AddHandler Me.estoqueToolStripMenuItem.Click, AddressOf Me.EstoqueToolStripMenuItem_Click
		'
		'statusStrip1
		'
		Me.statusStrip1.BackColor = System.Drawing.SystemColors.Control
		Me.statusStrip1.Location = New System.Drawing.Point(0, 435)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(880, 22)
		Me.statusStrip1.TabIndex = 1
		Me.statusStrip1.Text = "statusStrip1"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(880, 457)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.menuStrip1)
		Me.ForeColor = System.Drawing.Color.White
		Me.MainMenuStrip = Me.menuStrip1
		Me.Name = "MainForm"
		Me.Text = "7GFrota"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private sintéticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private analíticoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private orçamentoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private comprasDetalheToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private relatórioDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private estoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private statusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private orçamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private préVendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private categoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private consultarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private pDVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private formaDePagamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private consultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private vendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private relatoriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private porFornecedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private comprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private produtosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private categoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private MenuItemFornecedores As System.Windows.Forms.ToolStripMenuItem
	Private MenuItemClientes As System.Windows.Forms.ToolStripMenuItem
	Private cadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
End Class
