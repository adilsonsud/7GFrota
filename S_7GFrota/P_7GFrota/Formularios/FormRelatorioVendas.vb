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

Public Partial Class FormRelatorioVendas
	
	Dim venda As New EntPDV
	Dim cadPDV As New CadPDV
	Dim cadCategorias As New CadCategorias
	Dim cadProdutos As New CadProdutos
	Dim cadFornecedor As New CadFornecedores
	Dim cadCliente As New CadClientes
	Dim cadForma As New CadFormaPagamento
	Dim dr As MySqlDataReader
	Dim bs As New BindingSource
	Dim filtro As String
	
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()	
	End Sub
	
	
	Sub eXIBEVENDAS
		Dim dt As New DataTable
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
			If ckb_Detalhe.Checked = False Then 'Retorna todas as vendas do periodo informado
				venda.Aberta = False
				dt = cadPDV.RetornaVendasPeriodo_Status(venda.Aberta,CDate(txt_data1.Text),CDate(txt_data2.Text))
				bs.DataSource = dt
				dgv_InfoVendas.DataSource = bs
				
				dgv_InfoVendas.Columns(0).HeaderText = "ID VENDA"
				dgv_InfoVendas.Columns(1).HeaderText = "FORMA PAGAMENTO"
				dgv_InfoVendas.Columns(2).HeaderText = "CLIENTE"
				'dgv_InfoVendas.Columns(3).HeaderText = "DATA"
				dgv_InfoVendas.Columns(4).HeaderText = "DESCONTO"
				dgv_InfoVendas.Columns(5).HeaderText = "VALOR TOTAL"
				dgv_InfoVendas.Columns(6).HeaderText = "PAGO"
				dgv_InfoVendas.Columns(7).HeaderText = "TROCO"
				'dgv_InfoVendas.Columns(8).HeaderText = "ABERTA"
				
				dgv_InfoVendas.Columns(3).Visible = False
				dgv_InfoVendas.Columns(8).Visible = False
				
				dgv_InfoVendas.Columns(4).DefaultCellStyle.Format = ("c2")
				dgv_InfoVendas.Columns(5).DefaultCellStyle.Format = ("c2")
				dgv_InfoVendas.Columns(6).DefaultCellStyle.Format = ("c2")
				dgv_InfoVendas.Columns(7).DefaultCellStyle.Format = ("c2")				
							
				dgv_InfoVendas.Columns(0).Width = 90
				dgv_InfoVendas.Columns(1).Width = 190
				dgv_InfoVendas.Columns(2).Width = 260
				dgv_InfoVendas.Columns(4).Width = 140
				dgv_InfoVendas.Columns(5).Width = 140
				dgv_InfoVendas.Columns(6).Width = 140
				dgv_InfoVendas.Columns(7).Width = 140
				txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(5)),2)
								
			ElseIf ckb_Detalhe.Checked = True Then
				If rb_categoria.Checked = True Then 'retorna categoria
					filtro = "where datavenda between '" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text + "' and categorias.nome like '%" & txt_pesquisa.Text & "%' order by categorias.nome"
					dt = cadCategorias.rELATORIOCATEGORIA(filtro)
					bs.DataSource = dt
					dgv_InfoVendas.DataSource = dt
					dgv_InfoVendas.Columns(0).HeaderText = "ID VENDA"
					dgv_InfoVendas.Columns(1).HeaderText = "CATEGORIA"
					dgv_InfoVendas.Columns(2).HeaderText = "PRODUTO"
					dgv_InfoVendas.Columns(3).HeaderText = "FORNECEDOR"
					dgv_InfoVendas.Columns(4).HeaderText = "QTD"
					dgv_InfoVendas.Columns(5).HeaderText = "VALOR"
					dgv_InfoVendas.Columns(6).HeaderText = "DATA"
					
					dgv_InfoVendas.Columns(6).Visible = False
					dgv_InfoVendas.Columns(5).DefaultCellStyle.Format = ("c2")
				
					dgv_InfoVendas.Columns(0).Width = 90
					dgv_InfoVendas.Columns(1).Width = 250
					dgv_InfoVendas.Columns(2).Width = 250
					dgv_InfoVendas.Columns(3).Width = 250
					dgv_InfoVendas.Columns(4).Width = 110
					dgv_InfoVendas.Columns(5).Width = 150
					txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(5)),2)
					
				ElseIf rb_cliente.Checked = True Then	
					filtro = "where datavenda between '" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text + "' and clientes.NomeCliente like '%" & txt_pesquisa.Text & "%' order by clientes.NomeCliente"
					dt = cadCliente.rELATORIOVENDACLIENTE(filtro)
					bs.DataSource = dt
					dgv_InfoVendas.DataSource = dt
					dgv_InfoVendas.Columns(0).HeaderText = "ID VENDA"
					dgv_InfoVendas.Columns(1).HeaderText = "CLIENTE"
					dgv_InfoVendas.Columns(2).HeaderText = "CATEGORIA"
					dgv_InfoVendas.Columns(3).HeaderText = "PRODUTO"
					dgv_InfoVendas.Columns(4).HeaderText = "FORNECEDOR"
					dgv_InfoVendas.Columns(5).HeaderText = "QTD"
					dgv_InfoVendas.Columns(6).HeaderText = "VALOR"
					dgv_InfoVendas.Columns(7).HeaderText = "FORMA PAGAMENTO"
					dgv_InfoVendas.Columns(8).HeaderText = "DATA"
					
					dgv_InfoVendas.Columns(8).Visible = False
					dgv_InfoVendas.Columns(6).DefaultCellStyle.Format = ("c2")
				
					dgv_InfoVendas.Columns(0).Width = 80
					dgv_InfoVendas.Columns(1).Width = 200
					dgv_InfoVendas.Columns(2).Width = 130
					dgv_InfoVendas.Columns(3).Width = 180
					dgv_InfoVendas.Columns(4).Width = 180
					dgv_InfoVendas.Columns(5).Width = 70
					dgv_InfoVendas.Columns(6).Width = 130
					dgv_InfoVendas.Columns(7).Width = 150
					txt_gasto.Text = FormatCurrency(CDbl(CalculaValorGasto(6)),2)
					
				ElseIf rb_produto.Checked = True Then	
'					filtro = " where datacompra between " + "'" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text +  "' and produtos.Nome like '%" & txt_pesquisa.Text & "%' order by compras.DataCompra"
'				ElseIf rb_fornecedor.Checked = True Then
'					filtro = " where datacompra between " + "'" + txt_data1.Text +  "'" + " and " + "'" + txt_data2.Text +  "' and fornecedores.NomeFantasia like '%" + txt_pesquisa.Text + "%' order by compras.DataCompra"
				End If
			End If
				'dt = cadCompras.RetornaCompraDetalhe(filtro)
				'bs.DataSource = dt
				'dgv_InfoVendas.DataSource = bs
				
'				dgv_InfoVendas.Columns(0).HeaderText = "ID"
'				dgv_InfoVendas.Columns(1).HeaderText = "DATA"
'				dgv_InfoVendas.Columns(2).HeaderText = "VALOR TOTAL"
'				dgv_InfoVendas.Columns(3).HeaderText = "CATEGORIA"
'				dgv_InfoVendas.Columns(4).HeaderText = "PRODUTO"
'				dgv_InfoVendas.Columns(5).HeaderText = "FORNECEDOR"
'				dgv_InfoVendas.Columns(6).HeaderText = "QTD"
'				dgv_InfoVendas.Columns(7).HeaderText = "PREÇO CUSTO"
'				
'				dgv_InfoVendas.Columns(2).DefaultCellStyle.Format = ("c2")
'				dgv_InfoVendas.Columns(7).DefaultCellStyle.Format = ("c2")
'				
'				dgv_InfoVendas.Columns(0).Width = 80
'				dgv_InfoVendas.Columns(1).Width = 110
'				dgv_InfoVendas.Columns(2).Width = 150
'				dgv_InfoVendas.Columns(3).Width = 150
'				dgv_InfoVendas.Columns(4).Width = 210
'				dgv_InfoVendas.Columns(5).Width = 210
'				dgv_InfoVendas.Columns(6).Width = 60
'				dgv_InfoVendas.Columns(7).Width = 150
'				txt_gasto.Text = CStr(FormatCurrency(CalculaValorGasto,2))
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
	
	Sub Rb_clienteClick(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite o Nome do Cliente"
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
	
	
	Sub Txt_pesquisa_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			gb_pesquisa.Visible = False
			gb_detalhe.Focus
		End If
		
		
		If e.KeyCode = Keys.Enter Then
			eXIBEPESQUISA
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
	
	
	Sub eXIBEPESQUISA
		Dim dt As New DataTable
		Dim bs As New BindingSource
		
		If rb_categoria.Checked = True Then
			dt = cadCategorias.RetornaNomeCategoria(txt_pesquisa.Text)
			bs.DataSource = dt
			dgv_pesquisa.DataSource = bs	
			dgv_pesquisa.Columns(0).HeaderText = "CATEGORIA"	
		ElseIf rb_cliente.Checked = True Then
			dt = cadCliente.rETORNANOMECLIENTE(txt_pesquisa.Text)
			bs.DataSource = dt
			dgv_pesquisa.DataSource = bs	
			dgv_pesquisa.Columns(0).HeaderText = "CLIENTE"	
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
	
	
	Function CalculaValorGasto(coluna As Integer) As Double
		
		Dim linha As Integer = 0
		Dim valor As Double = 0

		while linha <= dgv_InfoVendas.rowcount - 1
			valor = valor + CDbl(dgv_InfoVendas.item(coluna,linha).Value)
			linha +=1
		end while

		Return valor
	End Function
	
	Sub FormRelatorioVendasKeyDown(sender As Object, e As KeyEventArgs)
		If  e.KeyCode = Keys.F1 Then
			dgv_InfoVendas.DataSource = ""
			eXIBEVENDAS
		End If
	End Sub

	
	
	Sub Rb_formaPagamentoClick(sender As Object, e As EventArgs)
		gb_pesquisa.Visible = True
		gb_pesquisa.Text = "Digite a Forma de Pagamento"
		dgv_pesquisa.DataSource = ""
		txt_pesquisa.Text = ""
		txt_pesquisa.Focus
	End Sub
End Class
