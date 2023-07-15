'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 27/2/2014
' Hora: 23:36
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MenuItemClientes_Click(sender As Object, e As EventArgs)
		Dim form As New FormClientes
		form.ShowDialog
	End Sub
	
	
	
	Sub MenuItemFornecedores_Click(sender As Object, e As EventArgs)
		Dim form As New FormFornecedores
		form.ShowDialog

	End Sub
	
	Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormCategorias
		form.ShowDialog
	End Sub
	
	Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormProdutos
		form.ShowDialog
	End Sub
	
	Sub PorFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormCompras
		form.ShowDialog
	End Sub
	
	Sub FormaDePagamentoToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormFormaPagamento
		form.ShowDialog
	End Sub
	
	Sub PDVToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormPDV
		form.ShowDialog
	End Sub
	
	Sub PréVendaToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormPreVenda
		form.ShowDialog
	End Sub
	
	Sub OrçamentoToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormOrcamento
		form.ShowDialog
	End Sub
	
	Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormEstoque
		form.ShowDialog
	End Sub
	
	Sub RelatórioDeToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioCompras
		form.ShowDialog
	End Sub
	
	Sub ComprasDetalheToolStripMenuItem_Click(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioComprasDetalhe
		form.ShowDialog
	End Sub
	
	Sub OrçamentoToolStripMenuItem1Click(sender As Object, e As EventArgs)
		Dim form As New FormCotacao
		form.ShowDialog
	End Sub
	
	Sub StatusToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioVendas_Status
		form.ShowDialog
	End Sub
	
	Sub CategoriaToolStripMenuItemClick(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub AnalíticoToolStripMenuItemClick(sender As Object, e As EventArgs)
		Dim form As New FormRelatorioVendas
		form.ShowDialog
	End Sub
End Class
