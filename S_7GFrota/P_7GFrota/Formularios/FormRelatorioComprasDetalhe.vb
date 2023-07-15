'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:39
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data

Public Partial Class FormRelatorioComprasDetalhe
	
	Dim compra As New EntCompras
	Dim cadPDV As New CadPDV
	Dim cadCategorias As New CadCategorias
	Dim cadProdutos As New CadProdutos
	Dim cadFornecedor As New CadFornecedores
	Dim cadCompras As New CadCompras
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
	End Sub
	
	
	Sub ExibeComprasDetalhe
		Dim dt As New DataTable
		Dim bs As New BindingSource
		Dim filtro As String

			If txt_data1.Text = "" Then
				MsgBox("Escolha uma data inicial para efetuar a consulta", vbInformation, "DATA INICIAL EM BRANCO")
				ckb_Detalhe.Checked = False
				txt_data1.Focus
				Exit Sub
			ElseIf txt_data2.Text = "" Then
				MsgBox("Escolha uma data final para efetuar a consulta", vbInformation, "DATA FINAL EM BRANCO")
				ckb_Detalhe.Checked = False
				txt_data2.Focus
				Exit Sub
			Else
				If ckb_Detalhe.Checked = False Then
					filtro = "where datacompra between " + "'" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text +  " ' order by compras.DataCompra"
					
				ElseIf ckb_Detalhe.Checked = True Then
					If rb_categoria.Checked = True Then
						filtro = " where categorias.Nome like '%" & txt_pesquisa.Text & "%' and datacompra between " + "'" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text + "' order by compras.DataCompra"
					ElseIf rb_produto.Checked = True Then	
						filtro = " where datacompra between " + "'" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text +  "' and produtos.Nome like '%" & txt_pesquisa.Text & "%' order by compras.DataCompra"
					ElseIf rb_fornecedor.Checked = True Then
						filtro = " where datacompra between " + "'" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text +  "' and fornecedores.NomeFantasia like '%" + txt_pesquisa.Text + "%' order by compras.DataCompra"
					End If
				End If
				dt = cadCompras.RetornaCompraDetalhe(filtro)
				bs.DataSource = dt
				dgv_InfoCompras.DataSource = bs
				
				dgv_InfoCompras.Columns(0).HeaderText = "ID"
				dgv_InfoCompras.Columns(1).HeaderText = "DATA"
				dgv_InfoCompras.Columns(2).HeaderText = "VALOR TOTAL"
				dgv_InfoCompras.Columns(3).HeaderText = "CATEGORIA"
				dgv_InfoCompras.Columns(4).HeaderText = "PRODUTO"
				dgv_InfoCompras.Columns(5).HeaderText = "FORNECEDOR"
				dgv_InfoCompras.Columns(6).HeaderText = "QTD"
				dgv_InfoCompras.Columns(7).HeaderText = "PREÇO CUSTO"
				
				dgv_InfoCompras.Columns(2).DefaultCellStyle.Format = ("c2")
				dgv_InfoCompras.Columns(7).DefaultCellStyle.Format = ("c2")
				
				dgv_InfoCompras.Columns(0).Width = 80
				dgv_InfoCompras.Columns(1).Width = 110
				dgv_InfoCompras.Columns(2).Width = 150
				dgv_InfoCompras.Columns(3).Width = 150
				dgv_InfoCompras.Columns(4).Width = 210
				dgv_InfoCompras.Columns(5).Width = 210
				dgv_InfoCompras.Columns(6).Width = 60
				dgv_InfoCompras.Columns(7).Width = 150
				
				txt_gasto.Text = CStr(FormatCurrency(CalculaValorGasto,2))
			End If
				
	End Sub
	
	
	
	Sub Bt_fechar_Click(sender As Object, e As EventArgs)
			Me.Close
	End Sub
	
	
	
	Sub Rb_categoria_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome da Categoria"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_produto_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Produto"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	
	
	Sub Rb_fornecedor_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Fornecedor"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_qtd_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite a Quantidade"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
	
	Sub Rb_ProdutoZerado_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = False
		gb_pesquisa.Text = ""
		
	End Sub
	
	Sub Rb_todos_Click(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = False
		gb_pesquisa.Text = ""
	End Sub
	
	
	
	
	Sub Txt_pesquisa_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			gb_pesquisa.Visible = False
			gb_detalhe.Focus
		End If
		
		
		If e.KeyCode = Keys.Enter Then
			ExibePesquisa
		End If		
		
		If e.KeyCode = Keys.Down Then
			dgv_pesquisa.Focus
		End If
	End Sub
	
	
	
	Sub Dgv_Itens_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			gb_detalhe.Focus
		End If
	End Sub
	
	Sub Dgv_pesquisa_KeyDown(sender As Object, e As KeyEventArgs)
		
		If e.KeyCode = Keys.Enter Then
				If dgv_pesquisa.RowCount < 1 Then
					Exit Sub
				Else
					txt_pesquisa.Text = dgv_pesquisa.SelectedCells(0).Value.ToString
					dgv_pesquisa.DataSource = ""
					txt_pesquisa.Focus
				End If
			
		ElseIf e.KeyCode = Keys.Escape Then
			txt_pesquisa.Focus
		End If
		
	End Sub
	
	
	
	Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
		txt_data2.Text = dateTimePicker2.Text
	End Sub
	
	Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
		txt_data1.Text = dateTimePicker1.Text
	End Sub
	
	
	Sub Ckb_Detalhe_Click(sender As Object, e As EventArgs)
		If ckb_Detalhe.Checked = True Then
				If txt_data1.Text = "" Then
					MsgBox("Escolha uma data inicial para efetuar a consulta", vbInformation, "DATA INICIAL EM BRANCO")
					ckb_Detalhe.Checked = False
					txt_data1.Focus
					Exit Sub
				ElseIf txt_data2.Text = "" Then
					MsgBox("Escolha uma data final para efetuar a consulta", vbInformation, "DATA FINAL EM BRANCO")
					ckb_Detalhe.Checked = False
					txt_data2.Focus
					Exit Sub
				Else
					gb_detalhe.Visible = True
				End If
				
		ElseIf ckb_Detalhe.Checked = False Then
			gb_detalhe.Visible = False
			gb_pesquisa.Visible = False
			txt_data1.Text = ""
			txt_data2.Text = ""
		End If
	End Sub
	
	
	
	
	Sub FormRelatorioCompras_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F1 Then
			ExibeComprasDetalhe
		End If
	End Sub
	
	
	
	Sub ExibePesquisa
		Dim dt As New DataTable
		Dim bs As New BindingSource
			If rb_categoria.Checked = True Then
				dt = cadCategorias.RetornaNomeCategoria(txt_pesquisa.Text)
				bs.DataSource = dt
				dgv_pesquisa.DataSource = bs	
				dgv_pesquisa.Columns(0).HeaderText = "CATEGORIA"
			ElseIf rb_produto.Checked = True Then
				dt = cadProdutos.RetornaNomeProduto(txt_pesquisa.Text)
				bs.DataSource = dt
				dgv_pesquisa.DataSource = bs	
				dgv_pesquisa.Columns(0).HeaderText = "PRODUTO"
			ElseIf rb_fornecedor.Checked = True
				dt = cadFornecedor.RetornaNomeFornecedor(txt_pesquisa.Text)
				bs.DataSource = dt
				dgv_pesquisa.DataSource = bs	
				dgv_pesquisa.Columns(0).HeaderText = "FORNECEDOR"	
			Else
				Exit Sub
			End If
					
		dgv_pesquisa.Columns(0).Width = 173
	End Sub
	
	
	Function CalculaValorGasto As Double
		
		Dim linha As Integer = 0
		Dim valor As Double = 0

		while linha <= dgv_InfoCompras.rowcount - 1
			valor = valor + CDbl(dgv_InfoCompras.item(7,linha).Value)
			linha +=1
		end while

		Return valor
	End Function
	
	
End Class
