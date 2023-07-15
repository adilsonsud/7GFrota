'
' Criado por SharpDevelop.
' Usuário: Adilson
' Data: 4/12/2013
' Hora: 11:52
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data

Public Partial Class FormFornecedores
	Dim fornecedor As New EntFornecedores
	Dim CadFornecedor As New CadFornecedores
	Dim CadPF As New CadProdFor
	Dim ProdFor As New EntProdFor
	Dim v_update As Integer '1 inserir/ 2 editar - usada para a tabela Fornecedores
	Dim v_update2 As Integer '1 inserir/ 2 editar - usada para a tabela ProdFor
	Dim v_Pessoa As String  'usada na sub VerificaPessoa, armazena F para pessoa fisica e J para juridica
	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		DesabilitaUpdate
		
	End Sub
	
	
	Sub Bt_fecharClick(sender As Object, e As EventArgs)
		Me.Close		
	End Sub
	
	
	
	Sub FormFornecedoresKeyDown(sender As Object, e As KeyEventArgs) 'identifica o pressionamento das teclas f1 e f3
		If e.KeyCode = Keys.F1 Then  'quando f1 é pressionado a aba localicazar é acionada
			tabControl1.SelectTab(0)
			txt_Localizar.Clear
			txt_Localizar.Focus
			pnl_prodfor.Visible =False
			dgv_produtos.Visible = True
			bt_inserir.Enabled = True
		ElseIf e.KeyCode = Keys.F3 Then 'quando f3 é pressionado a aba cadastrar é acionada
			tabControl1.SelectTab(1)
			tabControl2.SelectTab(0)
			pnl_prodfor.Visible =False
			dgv_produtos.Visible = True
			bt_inserir.Enabled = True
		ElseIf e.KeyCode = Keys.F5 Then 'quando f5 for pressionado a aba produtos será acionada
			tabControl1.SelectTab(1)
			tabControl2.SelectTab(1)
		End If
		
		
		If pnl_prodfor.Visible = True Then
			If e.KeyCode = Keys.Escape Then
				preencheDgv_Produtos
				cb_produto.Items.Clear
				txt_precocusto.Text = ""		
				txt_precoVenda.Text = ""
				dgv_produtos.Focus
			
			ElseIf e.Control = True And e.KeyCode = Keys.Delete And v_update2=2 Then
				ExcluirProduto
			End If		
		Else
			Exit Sub
		End If
		
	End Sub
	
	
	
	Sub HabilitaUpdate 'disparado quando o comando novo ou editar é acionado
		bt_novo.Visible = False
		bt_editar.Visible = False
		bt_excluir.Visible = False
		bt_salvar.Visible = True		
		
		gb_pessoa.Enabled = True
		txt_idFornecedor.Enabled = True
		txt_CpfCnpj.Enabled = True
		txt_InscEstadual.Enabled = True
		txt_NomeFantasia.Enabled = True
		txt_RazaoSocial.Enabled = True
		txt_site.Enabled = True
		txt_endereco.Enabled = True
		txt_complemento.Enabled = True
		txt_bairro.Enabled = True
		txt_cep.Enabled = True
		txt_cidade.Enabled = True
		txt_estado.Enabled = True
		txt_fone1.Enabled = True
		txt_fone2.Enabled = True
		txt_fone3.Enabled = True
		txt_fone4.Enabled = True
		txt_email1.Enabled = True
		txt_email2.Enabled = True
		
		txt_NomeFantasia.Focus
		tabLocalizar.Enabled = False	
		
	End Sub
	
	Sub DesabilitaUpdate 'disparado quando o comando salvar é acionado
		bt_novo.Visible = True
		bt_editar.Visible = True
		bt_excluir.Visible = True
		bt_salvar.Visible = False
		
		
		txt_idFornecedor.Enabled = False
		txt_CpfCnpj.Enabled = False
		txt_InscEstadual.Enabled = False
		txt_NomeFantasia.Enabled = False
		txt_RazaoSocial.Enabled = False
		txt_site.Enabled = False
		txt_endereco.Enabled = False
		txt_complemento.Enabled = False
		txt_bairro.Enabled = False
		txt_cep.Enabled = False
		txt_cidade.Enabled = False
		txt_estado.Enabled = False
		txt_fone1.Enabled = False
		txt_fone2.Enabled = False
		txt_fone3.Enabled = False
		txt_fone4.Enabled = False
		txt_email1.Enabled = False
		txt_email2.Enabled = False
		rb_Fisica.Checked = False
		rb_juridica.Checked = False
		gb_pessoa.Enabled = False
		
		tabLocalizar.Enabled = True
		
	End Sub
	
	'Nessa rotina é verificado o radio button do form para atribuir o valor ao campo P_FisicaJuridica do banco de dados
	Public Sub VerificaPessoa 'usada na hora de salvar para verificar o valor de gb_pessoa se é fisica ou juridica.	
		Select Case rb_Fisica.Checked
			Case True 
				v_Pessoa = "F"
			Case False
				v_Pessoa = "J"
		End Select
	End Sub
	
	'Nessa rotina é verificado o valor do campo P_FisicaJuridica do no grid para atribuir o valor ao radio button do form
	Public Sub VerificaPessoa( strPessoa As String) 'usada para posicionar o radio buntton no form na hora que seleciona o cliente no gride
		If strPessoa = "F" Then
			rb_Fisica.Checked = True
		ElseIf strPessoa = "J" Then
			rb_juridica.Checked = True
		End If	
	End Sub
	
	
	Sub Bt_novoClick(sender As Object, e As EventArgs)
		v_update = 1
		HabilitaUpdate
		LimpaCampos	
		rb_Fisica.Checked = True
	End Sub
	
	Sub Bt_editarClick(sender As Object, e As EventArgs)
		If txt_idFornecedor.Text = String.Empty Then
			MsgBox("Não há dados para editar")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
			Exit Sub		
		Else	
			v_update = 2
			HabilitaUpdate
		End If	
	End Sub
	
	Sub Bt_salvarClick(sender As Object, e As EventArgs)
		VerificaPessoa
		If autenticaForm = True Then	
			If v_update = 1 Then
				fornecedor.P_FisicaJuridica = CChar(v_Pessoa)
				fornecedor.CPF_CNPJ = txt_CpfCnpj.Text
				fornecedor.InscricaoEstadual = txt_InscEstadual.Text
				fornecedor.NomeFantasia = txt_NomeFantasia.Text
				fornecedor.RazaoSocial = txt_RazaoSocial.Text
				fornecedor.Endereco = txt_endereco.Text
				fornecedor.Complemento = txt_complemento.Text
				fornecedor.Bairro = txt_bairro.Text
				fornecedor.Cep = txt_cep.Text
				fornecedor.Cidade = txt_cidade.Text
				fornecedor.Estado = txt_estado.Text
				fornecedor.Fone1 = txt_fone1.Text
				fornecedor.Fone2 = txt_fone2.Text
				fornecedor.Fone3 = txt_fone3.Text
				fornecedor.Fone4 = txt_fone4.Text
				fornecedor.Email1 = txt_email1.Text
				fornecedor.Email2 = txt_email2.Text
				fornecedor.Site = txt_site.Text
				CadFornecedor.AdicionarFornecedor(fornecedor)
			
				
			ElseIf v_update = 2 Then
				fornecedor.IdFornecedor = CInt (txt_idFornecedor.Text)
				fornecedor.P_FisicaJuridica = CChar(v_Pessoa)
				fornecedor.CPF_CNPJ = txt_CpfCnpj.Text
				fornecedor.InscricaoEstadual = txt_InscEstadual.Text
				fornecedor.NomeFantasia = txt_NomeFantasia.Text
				fornecedor.RazaoSocial = txt_RazaoSocial.Text
				fornecedor.Endereco = txt_endereco.Text
				fornecedor.Complemento = txt_complemento.Text
				fornecedor.Bairro = txt_bairro.Text
				fornecedor.Cep = txt_cep.Text
				fornecedor.Cidade = txt_cidade.Text
				fornecedor.Estado = txt_estado.Text
				fornecedor.Fone1 = txt_fone1.Text
				fornecedor.Fone2 = txt_fone2.Text
				fornecedor.Fone3 = txt_fone3.Text
				fornecedor.Fone4 = txt_fone4.Text
				fornecedor.Email1 = txt_email1.Text
				fornecedor.Email2 = txt_email2.Text
				fornecedor.Site = txt_site.Text
				CadFornecedor.EditarFornecedor(fornecedor)				
			
			End If
		Else
			Exit Sub
			
		End If
		LimpaCampos
		DesabilitaUpdate
		lbl_NomeFantasia.Text = "Escolha um Fornecedor - Press. F1"
		dgv_produtos.DataSource = ""
		bt_fechar.Focus
		
	End Sub
	
	Sub Txt_LocalizarKeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			
			Dim dt As  New DataTable
			Dim bs As New BindingSource
				
				dt = CadFornecedor.LocalizarFornecedor(txt_Localizar.Text)
				bs.DataSource = dt
				dgv_Fornecedor.DataSource = bs
				
			Try		
				
				dgv_Fornecedor.Columns(4).HeaderText = "Nome Fantasia"
				dgv_Fornecedor.Columns(5).HeaderText = "Razão Social"
'				dgv_Fornecedor.Columns(12).HeaderText = "Fone1"
'				dgv_Fornecedor.Columns(16).HeaderText = "Email1"	
				
				dgv_Fornecedor.Columns(0).Visible = False
				dgv_Fornecedor.Columns(1).Visible = False
				dgv_Fornecedor.Columns(2).Visible = False
				dgv_Fornecedor.Columns(3).Visible = False
				dgv_Fornecedor.Columns(4).Visible = True
				dgv_Fornecedor.Columns(5).Visible = True
				dgv_Fornecedor.Columns(6).Visible = False
				dgv_Fornecedor.Columns(7).Visible = False
				dgv_Fornecedor.Columns(8).Visible = False
				dgv_Fornecedor.Columns(9).Visible = False
				dgv_Fornecedor.Columns(10).Visible = False
				dgv_Fornecedor.Columns(11).Visible = False
				dgv_Fornecedor.Columns(12).Visible = True
				dgv_Fornecedor.Columns(13).Visible = False
				dgv_Fornecedor.Columns(14).Visible = False
				dgv_Fornecedor.Columns(15).Visible = False
				dgv_Fornecedor.Columns(16).Visible = True
				dgv_Fornecedor.Columns(17).Visible = False
				dgv_Fornecedor.Columns(18).Visible = True
				
				dgv_Fornecedor.Columns(4).Width = 180 'NomeFantasia
				dgv_Fornecedor.Columns(5).Width = 180 'RazaoSocial
				dgv_Fornecedor.Columns(6).Width = 180 'Endereco
				dgv_Fornecedor.Columns(12).Width = 125 'Fone1
				dgv_Fornecedor.Columns(16).Width = 180 'Email1
				dgv_Fornecedor.Columns(18).Width = 185 'site
				'				dgv_Fornecedor.Columns(6).Width = 180
				
			Catch ex As MySqlException
				MsgBox("Fornecedor não Localizado: " + ex.Message)
				txt_Localizar.Focus
			Finally
				LimpaCampos
				dgv_produtos.DataSource = ""
			End Try	
			
		End If
		
		If e.KeyCode = Keys.Down Then
			dgv_Fornecedor.Focus
		End If
	End Sub
	
	Sub Dgv_FornecedoresKeyDown(sender As Object, e As KeyEventArgs)
		
		Try
			If e.KeyCode = Keys.Enter Then
				v_Pessoa = dgv_Fornecedor.SelectedCells(1).Value.ToString
				VerificaPessoa(v_Pessoa)
				
				txt_idFornecedor.Text = dgv_Fornecedor.SelectedCells(0).value.ToString
				txt_CpfCnpj.Text = dgv_Fornecedor.SelectedCells(2).Value.ToString	
				txt_InscEstadual.Text = dgv_Fornecedor.SelectedCells(3).Value.ToString	
				txt_NomeFantasia.Text = dgv_Fornecedor.SelectedCells(4).Value.ToString	
				txt_RazaoSocial.Text = dgv_Fornecedor.SelectedCells(5).Value.ToString	
				txt_endereco.Text = dgv_Fornecedor.SelectedCells(6).Value.ToString	
				txt_complemento.Text = dgv_Fornecedor.SelectedCells(7).Value.ToString	
				txt_bairro.Text = dgv_Fornecedor.SelectedCells(8).Value.ToString	
				txt_cep.Text = dgv_Fornecedor.SelectedCells(9).Value.ToString	
				txt_cidade.Text = dgv_Fornecedor.SelectedCells(10).Value.ToString	
				txt_estado.Text = dgv_Fornecedor.SelectedCells(11).Value.ToString	
				txt_fone1.Text = dgv_Fornecedor.SelectedCells(12).Value.ToString	
				txt_fone2.Text = dgv_Fornecedor.SelectedCells(13).Value.ToString	
				txt_fone3.Text = dgv_Fornecedor.SelectedCells(14).Value.ToString	
				txt_fone4.Text = dgv_Fornecedor.SelectedCells(15).Value.ToString	
				txt_email1.Text = dgv_Fornecedor.SelectedCells(16).Value.ToString	
				txt_email2.Text = dgv_Fornecedor.SelectedCells(17).Value.ToString	
				txt_site.Text = dgv_Fornecedor.SelectedCells(18).value.ToString
				lbl_NomeFantasia.Text = dgv_Fornecedor.SelectedCells(4).Value.ToString
				
				dgv_Fornecedor.DataSource =""
				tabControl1.SelectTab(1)	
				tabControl2.SelectTab(0)
				
				preencheDgv_Produtos
			End If	
		Catch ex As Exception
			MsgBox("Digite um valor valido",vbOKOnly,"Erro inesperado")
			txt_Localizar.Focus
		End Try	
	End Sub
	
	Sub TabLocalizarEnter(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	Sub Bt_excluirClick(sender As Object, e As EventArgs)
		
		If txt_idFornecedor.Text = String.Empty Then
			MsgBox("Não há dados para excluir")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
			Exit Sub
		
		Else
			If MsgBox("Confirme a exclusão!",vbYesNo , "Excluir")= vbYes Then
				CadFornecedor.ExcluirFornecedor(txt_idFornecedor.Text)
				LimpaCampos
			Else
				Exit Sub
			End If		
		End If		
	End Sub
	
	Sub LimpaCampos
		txt_idFornecedor.Clear
		txt_CpfCnpj.Clear
		txt_InscEstadual.Clear
		txt_NomeFantasia.Clear
		txt_RazaoSocial.Clear
		txt_site.Clear
		txt_endereco.Clear
		txt_complemento.Clear
		txt_bairro.Clear
		txt_cep.Clear
		txt_cidade.Clear
		txt_estado.Clear
		txt_fone1.Clear
		txt_fone2.Clear
		txt_fone3.Clear
		txt_fone4.Clear
		txt_email1.Clear
		txt_email2.Clear
		rb_Fisica.Checked = False
		rb_juridica.Checked = False
	
	End Sub
	
	
	Function autenticaForm As Boolean
		Dim Aform As Boolean = False 'true Aform ok, false objeto em branco 		
			
		If txt_NomeFantasia.Text = "" Then
			MsgBox("Digite o nome Fantasia")
			txt_NomeFantasia.Focus	
		Else
			Aform = True
		End If
		Return Aform
	End Function
	
	
		Sub FormFornecedores_KeyPress(sender As Object, e As KeyPressEventArgs)
			If tabLocalizar.Visible = True Then 
					If e.KeyChar = Convert.ToChar(13) Then
						e.Handled = True
						SendKeys.Send("{TAB}")			
					End If
			ElseIf tabFornecedor.Visible = True Then
					If e.KeyChar = Convert.ToChar(13) Then
						e.Handled = True
						SendKeys.Send("{TAB}")			
					End If				
			End If
		
	End Sub
	
	
	'------------------------------------------------------------------------
	
	
	Sub Txt_RazaoSocial_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_NomeFantasia.Focus
		End If
	End Sub
	
	Sub Txt_CpfCnpj_KeyPress(sender As Object, e As KeyPressEventArgs)
		If  e.KeyChar = Convert.ToChar(27) Then
			txt_RazaoSocial.Focus
		End If
	End Sub
	
	Sub Txt_InscEstadual_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_CpfCnpj.Focus
		End If
	End Sub
	
	Sub Txt_site_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_InscEstadual.Focus
		End If
	End Sub

	
	Sub Txt_endereco_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_site.Focus
		End If
	End Sub
	
	Sub Txt_complemento_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_endereco.Focus
		End If
	End Sub
	
	Sub Txt_bairro_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_complemento.Focus
		End If
	End Sub
	
	Sub Txt_cep_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_bairro.Focus
		End If
	End Sub
	
	Sub Txt_cidade_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_cep.Focus
		End If
	End Sub
	
	Sub Txt_estado_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_cidade.Focus
		End If
	End Sub
	
	Sub Txt_fone1_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_estado.Focus
		End If
	End Sub
	
	Sub Txt_fone2_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone1.Focus
		End If
	End Sub
	
	Sub Txt_fone3_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone2.Focus
		End If
	End Sub
	
	Sub Txt_fone4_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone3.Focus
		End If
	End Sub
	
	Sub Txt_email1_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_fone4.Focus
		End If
	End Sub
	
	Sub Txt_email2_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Escape Then
			txt_email1.Focus
		End If
	End Sub
	
	Sub FormClientes_FormClosed(sender As Object, e As FormClosedEventArgs)
		CadFornecedor.desconectar
	End Sub
	
'------------ SUBS PRODFOR -------------------------------------------	
	
	Sub Bt_inserir_Click(sender As Object, e As EventArgs)
		If txt_idFornecedor.Text = "" Then
			MsgBox("Escolha um fornecedor",vbOKOnly,"Produtos do Fornecedor")
			tabControl1.SelectTab(0)
			txt_Localizar.Focus
		Else	
			InserirProduto
		End If
		
	End Sub
		
	Sub preencheCb_produto	
		Dim dr As MySqlDataReader
			dr = Cadpf.ExibeProdutos
			cb_produto.Items.Clear
		While dr.Read
			cb_produto.Items.Add(dr(1))
		End While
		dr.Close	
	End Sub
	
	Sub preencheDgv_Produtos
			Dim ds As New DataSet
			Dim bs As  New BindingSource
			ds.Clear
			dgv_produtos.DataSource = ""
			
			ds = CadPF.ExibeProdutosFornecedor(txt_idFornecedor.Text)
			bs.DataSource = ds.Tables(0)
			
			dgv_produtos.Visible = True
			bt_inserir.Enabled  = True
			pnl_prodfor.Visible = False
			
			dgv_produtos.DataSource = bs	
			
			dgv_Produtos.Columns(0).Visible = False 'Nome Fantasia
			dgv_Produtos.Columns(1).Visible = True  'Nome Produto
			dgv_Produtos.Columns(2).Visible = False 'idProduto
			dgv_Produtos.Columns(3).Visible = False 'idFornecedor
			dgv_Produtos.Columns(4).Visible = True  'QTD
			dgv_Produtos.Columns(5).Visible = True  'Preco custo
			dgv_Produtos.Columns(6).Visible = True  'Preco venda
			
			dgv_Produtos.Columns(1).HeaderText = "Nome Produto"
			dgv_Produtos.Columns(4).HeaderText = "QTD"
			dgv_Produtos.Columns(5).HeaderText = "Preço de Custo"
			dgv_Produtos.Columns(6).HeaderText = "Preço de Venda"
			
			'Aplica formatação do tipo moeda nas respectivas colulas
			dgv_produtos.Columns(5).DefaultCellStyle.Format = ("c2")
			dgv_Produtos.Columns(6).DefaultCellStyle.Format = ("C2")
		
			dgv_Produtos.Columns(1).Width = 350 'Nome Produto
			dgv_Produtos.Columns(4).Width = 100 'QTD
			dgv_Produtos.Columns(5).Width = 150 'Preco custo
			dgv_Produtos.Columns(6).Width = 150 'Preco venda
			dgv_produtos.Focus
	End Sub
	
	
	
	Sub Exibe_Pnl_ProdFor
		Try
			dgv_produtos.Visible = False
			bt_inserir.Enabled = False
			pnl_prodfor.Visible = True
			
			gb_prodFor.Text = "ALTERAR INFORMAÇÕES DESTE PRODUTO "
			cb_produto.Text = dgv_produtos.SelectedCells(1).Value.ToString
			cb_produto.Enabled = False
			txt_precocusto.Text = FormatCurrency(dgv_produtos.SelectedCells(5).Value.ToString,2)
			txt_precoVenda.Text = FormatCurrency(dgv_produtos.SelectedCells(6).Value.ToString,2)
			
		Catch ex As Exception
			MsgBox("Selecione um produto valido no grid", vbOKOnly,"Erro" + ex.Message )
			preencheDgv_Produtos
		End Try
	End Sub
	
	
	Sub Bt_ok_Click(sender As Object, e As EventArgs)	
		If cb_produto.Text = "" Then
			MsgBox("Escolha um Produto",vbOKOnly,"Produto em branco")
			cb_produto.Focus
		ElseIf txt_precocusto.Text = "" Then
			txt_precocusto.Text = "0"
		
		ElseIf	txt_precoVenda.Text = "" Then
			txt_precoVenda.Text = "0"
			
		ElseIf Not IsNumeric(txt_precocusto.Text) Then
			MsgBox("Digite um número valido para Preço de Custo",vbOKOnly,"Digito invalido")
			txt_precocusto.Focus
		
		ElseIf Not IsNumeric(txt_precoVenda.Text) Then
			MsgBox("Digite um número valido para Preço de Venda",vbOKOnly,"Digito invalido")
			txt_precoVenda.Focus
		Else
			
			SelecionaIdProduto
			If v_update2 = 1 Then	
				
				ProdFor.IdProduto = ProdFor.IdProduto
				ProdFor.IdFornecedor = CInt(txt_idFornecedor.Text)
				ProdFor.QTD = 0
				ProdFor.PrecoCusto = CDbl(txt_precocusto.Text)
				ProdFor.PrecoVenda = CDbl (txt_precoVenda.Text)
				CadPF.AdicionarProdFor(ProdFor)
				
			ElseIf v_update2 = 2 Then
				
				ProdFor.PrecoCusto = CDbl(txt_precocusto.Text)
				ProdFor.PrecoVenda = CDbl(txt_precoVenda.Text)
				CadPF.EditarProdFor(ProdFor)
			End If
			
			cb_produto.Items.Clear
			txt_precocusto.Text = ""
			txt_precoVenda.Text = ""
			preencheDgv_Produtos
			
		End If			
	End Sub
	
	
	Sub TabControl2_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.F5 Then
			tabControl2.SelectTab(1)
		End If
	End Sub
	
	
	Sub Dgv_produtos_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			Editarproduto
		End If
	End Sub
	
	
	'chama a sub selecionaIdProduto na classe cadProdFor para selecionar o idProduto
	'objetivo, armazenar o idproduto na tabela ProdFor, de acordo com o produto selecionado no combo
	Sub SelecionaIdProduto
		Dim drId As MySqlDataReader
		drId = CadPF.selecionaIdProduto(cb_produto.Text)
		drId.Read
		ProdFor.IdProduto = drId.GetInt32(0)
		drId.Close
	End Sub
	
	Sub ExcluirProduto
		If MsgBox("Confirme a exclusão deste produto!",vbYesNo , "Excluir")= vbYes Then
			Dim idProd, idForn As String
			idProd = Cstr(ProdFor.IdProduto)
			idForn = Cstr(ProdFor.IdFornecedor)
			CadPF.ExcluirProdFor(idProd,idForn)
			preencheDgv_Produtos
			txt_precoVenda.Text=""
			txt_precocusto.Text = ""
		End If
	End Sub
	
	Sub Editarproduto
		v_update2 = 2
		preencheCb_produto
		
		'Preenche as variaveis da entidade prodFor
		ProdFor.IdProduto = CInt(dgv_produtos.SelectedCells(2).Value.ToString)
		ProdFor.IdFornecedor = CInt(dgv_produtos.SelectedCells(3).Value.ToString)
		ProdFor.PrecoCusto = CDbl(dgv_produtos.SelectedCells(4).Value.ToString)
		Exibe_Pnl_ProdFor
		txt_precocusto.Focus
		lbl_excluir.Visible = True
	End Sub
	
	Sub InserirProduto
		v_update2 = 1
		dgv_produtos.Visible = False
		pnl_prodfor.Visible = True
		cb_produto.Enabled = True
		bt_inserir.Enabled = False
		preencheCb_produto
		cb_produto.Focus
		gb_prodFor.Text = "ADICIONE PRODUTOS PARA ESTE FORNECEDOR"
		lbl_excluir.Visible = False
	End Sub
	
	
	Sub Dgv_produtos_DoubleClick(sender As Object, e As EventArgs)
		Editarproduto
	End Sub
	
	Sub FormFornecedores_Shown(sender As Object, e As EventArgs)
		txt_Localizar.Focus
	End Sub
	
	
	Sub lbl_excluir_Click(sender As Object, e As EventArgs)
			ExcluirProduto
	End Sub

	
	Sub Cb_produto_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			txt_precocusto.Focus
		End If
	End Sub
	
	
	Sub Txt_precocusto_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			txt_precoVenda.Focus
		End If
	End Sub
	
	Sub Txt_precoVenda_KeyDown(sender As Object, e As KeyEventArgs)
		If e.KeyCode = Keys.Enter Then
			bt_ok.Focus
		ElseIf e.KeyCode = Keys.Escape Then
			txt_precocusto.Focus
		End If
	End Sub
	
	
	Sub Txt_precocusto_Leave(sender As Object, e As EventArgs)	
			 If txt_precocusto.Text = "" Then
			 	txt_precocusto.Text = "0"
			 ElseIf Not IsNumeric(txt_precocusto.Text) Then
			 	MsgBox("Digite um número valido para Preço custo", vbOKOnly, "Digito incorreto")
			 	txt_precocusto.Focus 
			 ElseIf txt_precocusto.Text <> ""
					txt_precocusto.Text = FormatCurrency(txt_precocusto.Text,2)
			 End If	
	End Sub
	
	
	Sub Txt_precoVenda_Leave(sender As Object, e As EventArgs)
		 If txt_precoVenda.Text = "" Then
		 	txt_precoVenda.Text = "0"
		 ElseIf Not IsNumeric (txt_precoVenda.Text) Then
		 	MsgBox("Digite um número valido para Preço venda", vbOKOnly, "Digito incorreto")
		 	txt_precoVenda.Focus
		ElseIf txt_precoVenda.Text <> "" Then
				txt_precoVenda.Text = FormatCurrency(txt_precoVenda.Text,2)
		End If
	End Sub
	
	
	Sub Dgv_Fornecedor_DoubleClick(sender As Object, e As EventArgs)
		v_Pessoa = dgv_Fornecedor.SelectedCells(1).Value.ToString
			VerificaPessoa(v_Pessoa)
			
			txt_idFornecedor.Text = dgv_Fornecedor.SelectedCells(0).value.ToString
			txt_CpfCnpj.Text = dgv_Fornecedor.SelectedCells(2).Value.ToString	
			txt_InscEstadual.Text = dgv_Fornecedor.SelectedCells(3).Value.ToString	
			txt_NomeFantasia.Text = dgv_Fornecedor.SelectedCells(4).Value.ToString	
			txt_RazaoSocial.Text = dgv_Fornecedor.SelectedCells(5).Value.ToString	
			txt_endereco.Text = dgv_Fornecedor.SelectedCells(6).Value.ToString	
			txt_complemento.Text = dgv_Fornecedor.SelectedCells(7).Value.ToString	
			txt_bairro.Text = dgv_Fornecedor.SelectedCells(8).Value.ToString	
			txt_cep.Text = dgv_Fornecedor.SelectedCells(9).Value.ToString	
			txt_cidade.Text = dgv_Fornecedor.SelectedCells(10).Value.ToString	
			txt_estado.Text = dgv_Fornecedor.SelectedCells(11).Value.ToString	
			txt_fone1.Text = dgv_Fornecedor.SelectedCells(12).Value.ToString	
			txt_fone2.Text = dgv_Fornecedor.SelectedCells(13).Value.ToString	
			txt_fone3.Text = dgv_Fornecedor.SelectedCells(14).Value.ToString	
			txt_fone4.Text = dgv_Fornecedor.SelectedCells(15).Value.ToString	
			txt_email1.Text = dgv_Fornecedor.SelectedCells(16).Value.ToString	
			txt_email2.Text = dgv_Fornecedor.SelectedCells(17).Value.ToString	
			txt_site.Text = dgv_Fornecedor.SelectedCells(18).value.ToString
			lbl_NomeFantasia.Text = dgv_Fornecedor.SelectedCells(4).Value.ToString
			
			dgv_Fornecedor.DataSource =""
			tabControl1.SelectTab(1)	
			tabControl2.SelectTab(0)
			
			preencheDgv_Produtos
	End Sub
End Class
