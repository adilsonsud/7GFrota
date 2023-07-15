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

Public Class CadPDV
	
	Dim conexao As New CL_Conexao	
	Dim con As New MySqlConnection
	Dim cmd As MySqlCommand
	Dim dr As MySqlDataReader
	Dim sql As String
	Dim venda As New EntPDV
	
	
	Public Sub New()
		con = conexao.conectar
	End Sub
	
	Public Function CarregaFormaPagamento As MySqlDataReader
		sql = "select forma from 7gfrota.FormaPagamentos"
		Try
			cmd = New MySqlCommand(sql,con)	
	   		dr = cmd.ExecuteReader  
		    
		Catch ex As MySqlException
			MsgBox("Erro ao listar Formas de Pagamento ->" + ex.ToString)	
		End Try	
	Return dr
	dr.Close
	End Function
	
	
	Public Function SelecionaIdFormaPagamento (forma As String) As Integer
		Dim idForma As Integer
		sql = "select idformapagamento from 7gfrota.FormaPagamentos where forma = '" + forma + "'"
		Try
			cmd = New MySqlCommand(sql,con)	
			dr = cmd.ExecuteReader  
			dr.Read
	   		idForma = dr.GetInt32(0)
	   		dr.Close
		Catch ex As MySqlException
			MsgBox("Erro ao selecionar IdFormaPagamento ->" + ex.ToString)	
		End Try	
		Return idForma
	End Function
	
	
	
	
	Public Function RetornaFormaPagamento (idForma As String) As String
		
		sql = "select forma from 7gfrota.FormaPagamentos where idFormaPagamento = " + idForma 
		Try
			cmd = New MySqlCommand(sql,con)	
			dr = cmd.ExecuteReader  
			dr.Read
	   		venda.NomeFormaPagamento = dr.GetString(0)
	   		dr.Close
	   		
		Catch ex As MySqlException
			MsgBox("Erro ao selecionar Forma de Pagamento ->" + ex.ToString)	
		End Try	
		Return venda.NomeFormaPagamento
	End Function
	
	
	Public Function ExibeProdutos  (NomeProduto As String) As DataTable
 	  Dim dt As New DataTable
	 	Try                        '  0                     1                    2                  3                   4                 5                 6 
			sql = "Select  produtos.Nome, fornecedores.NomeFantasia, prod_for.idProduto,prod_for.idFornecedor,prod_for.QTD, prod_for.PrecoCusto, prod_for.precoVenda " & _
				"FROM (`7gfrota`.prod_for prod_for INNER JOIN `7gfrota`.fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor))" & _
				"INNER JOIN `7gfrota`.produtos produtos On (prod_for.idProduto = produtos.idProduto) where produtos.Nome like '%" & NomeProduto & "%' "   & _
				" order by produtos.nome, fornecedores.NomeFantasia"
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		  Catch ex As MySqlException	
			MsgBox("erro ao tentar exibir Produtos "+ ex.Message)
		End Try
   		Return dt 	
	End Function
	
	
	Public Function SelecionaCliente(nome As String) As DataTable
		
		Dim dt As New DataTable
		 	Try                                    
				sql = " select idCliente,NomeCliente, CPF_CNPJ from 7gfrota.clientes where nomecliente like '%"& nome & "%'"	
				Dim da As new MySqlDataAdapter(sql,con)
				da.Fill(dt)	
			  Catch ex As MySqlException	
				MsgBox("erro ao tentar exibir Cliente "+ ex.Message)
			End Try
   		Return dt 
	End Function
	
	
	Public Function SelecionaIdCliente (cliente As String) As Integer
		Dim idCliente As Integer
		sql = "select idCliente from 7gfrota.clientes where NomeCliente = '" + cliente + "'"
		Try
			cmd = New MySqlCommand(sql,con)	
			dr = cmd.ExecuteReader  
			dr.Read
	   		idCliente = dr.GetInt32(0)
	   		dr.Close
		Catch ex As MySqlException
			MsgBox("Erro ao Selecionar IdCliente ->" + ex.ToString)	
		End Try	
		Return idCliente
	End Function
	
	
	
	Public Function RetornaNomeCliente (idCliente As String) As String
		
		sql = "select NomeCliente from 7gfrota.clientes where idCliente = " + idCliente
		Try
			cmd = New MySqlCommand(sql,con)	
			dr = cmd.ExecuteReader  
			dr.Read
	   		venda.NomeCliente = dr.GetString(0)
	   		dr.Close
		Catch ex As MySqlException
			MsgBox("Erro ao Selecionar NomeCliente ->" + ex.ToString)	
		End Try	
		Return venda.NomeCliente
	End Function
	
	
	
	Public Sub AdicionarVenda (venda As EntPDV)
	
	    Try
			sql = ("insert into 7gfrota.vendas (IdFormaPagamento, IdCliente,DataVenda, desconto, valortotal, pago, troco, aberta) values (@IdFormaPagamento, @IdCliente,@DataVenda, @desconto, @valortotal, @pago, @troco, @aberta)")
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@IdFormaPagamento",MySqlDbType.Int32).Value = venda.IdFormaPagamento
			cmd.Parameters.Add("@IdCliente", MySqlDbType.Int32).Value = venda.IdCliente
			cmd.Parameters.Add("@DataVenda", MySqlDbType.String).Value = venda.DataVenda
			cmd.Parameters.Add("@desconto", MySqlDbType.Double).Value = venda.Desconto
			cmd.Parameters.Add("@valortotal", MySqlDbType.Double).Value = venda.ValorTotal
			cmd.Parameters.Add("@pago", MySqlDbType.Double).Value = venda.Pago
			cmd.Parameters.Add("@troco", MySqlDbType.double).Value = venda.Troco
			cmd.Parameters.Add("@aberta", MySqlDbType.Bit).Value = venda.Aberta
			cmd.ExecuteNonQuery		
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir  venda no Banco: " + ex.ToString)	
		End Try		
	End Sub
	
	
	
	Public function AdicionarItensVenda(ItensVenda As EntPDV) As Boolean
		Dim insere As Boolean
	
	    Try
			sql = ("insert into 7gfrota.Itemvendas (idVenda,idProduto, idFornecedor, QTD, Valor) values (@idVenda,@idProduto, @idFornecedor, @QTD, @Valor)")
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@idVenda",MySqlDbType.Int32).Value = ItensVenda.IdVenda
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ItensVenda.IdProduto
			cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = ItensVenda.IdFornecedor
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ItensVenda.Qtd
			cmd.Parameters.Add("@Valor",MySqlDbType.Double).Value = ItensVenda.Valor
			cmd.ExecuteNonQuery		
			insere = True
		Catch ex As MySqlException
			MsgBox("Verifique se este item já foi incluido, caso queira inserir mais quantidades deste item, pressione F5 " & _
				"para mudar a quantidade ao invez de tentar inserir um novo item: -> " + ex.Message, vbOKOnly, "Erro ao Inserir Item!")	
			insere = False
		End Try		
		Return insere
	End Function
	
	
	Public sub AtualizaItemVenda (ItemVenda As EntPDV)
		
		Try
			sql = "update 7gfrota.Itemvendas Set  QTD = @QTD, Valor = @Valor where  idVenda = @idVenda and idProduto = @idProduto and  idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, con)
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ItemVenda.QTD
			cmd.Parameters.Add("@Valor",MySqlDbType.Double).Value = ItemVenda.Valor
			cmd.Parameters.Add("@idVenda",MySqlDbType.Int32).Value = ItemVenda.IdVenda
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ItemVenda.IdProduto
			cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = ItemVenda.IdFornecedor
			cmd.ExecuteNonQuery		
		Catch ex As MySqlException
			MsgBox("Erro ao tentar atualizar este Itens da Venda: " + ex.Message)		
		End Try
	End Sub
	
	
	Public Function RetornaIdVenda As Integer
		Dim dr As  MySqlDataReader
		sql = ("SELECT max(idvendas) from 7gfrota.vendas")
		cmd = New MySqlCommand(sql,con)
		dr = cmd.ExecuteReader
		dr.Read
		venda.IdVenda = dr.GetInt32(0)
		dr.Close
		Return venda.IdVenda
	End Function
	
	
	Public Sub AtualizarInfoVendas (idCliente As Integer, idForma As Integer, idVenda As Integer)'utilizada para alterar forma de pagamento ou o cliente
		Try
			sql = "update 7gfrota.vendas Set idCliente = @idCliente, idFormaPagamento = @idFormaPagamento where idVendas = @idVendas"
			
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@idCliente",MySqlDbType.Int32).Value = idCliente
			cmd.Parameters.Add("@idFormaPagamento",MySqlDbType.Int32).Value = idForma
			cmd.Parameters.Add("@idVendas",MySqlDbType.Int32).Value = idVenda
			cmd.ExecuteNonQuery		
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar alterar informações da venda: " + ex.Message)	
		End Try
	End Sub
	
	
	Public Sub AtualizarVenda (vendas As EntPDV)'utilizada na hora de finalizar a venda, atualiza valor total, desconto, pago, troco, aberta
		Try
			sql = "update 7gfrota.vendas Set desconto = @desconto, valorTotal = @valorTotal, pago = @pago, troco = @troco, aberta = @aberta where idVendas = @idVendas and idFormaPagamento = @idFormaPagamento and idCliente = @idCliente"
			
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@desconto",MySqlDbType.Double).Value = vendas.Desconto
			cmd.Parameters.Add("@valorTotal",MySqlDbType.Double).Value = vendas.ValorTotal
			cmd.Parameters.Add("@pago",MySqlDbType.Double).Value = vendas.Pago
			cmd.Parameters.Add("@troco",MySqlDbType.Double).Value = vendas.Troco
			cmd.Parameters.Add("@aberta",MySqlDbType.Bit).Value = vendas.Aberta
			cmd.Parameters.Add("@idVendas",MySqlDbType.Int32).Value = vendas.IdVenda
			cmd.Parameters.Add("@idFormaPagamento",MySqlDbType.Int32).Value = vendas.IdFormaPagamento
			cmd.Parameters.Add("@idCliente",MySqlDbType.Int32).Value = vendas.IdCliente
			cmd.ExecuteNonQuery		
			
		Catch ex As MySqlException
			MsgBox("Erro ao atualizar informações da venda: " + ex.Message)	
		End Try
	End Sub
	
	
	Public Sub ExcluirItenVenda(idVenda As Integer, idProduto As Integer, idFornecedor As Integer)
	  Try 
	  	sql="delete from 7gfrota.Itemvendas where idVenda = @idVenda and idProduto = @idProduto  and idFornecedor = @idFornecedor " 
	  	cmd = New MySqlCommand(sql,con)	
	  	cmd.Parameters.Add("@idVenda",MySqlDbType.Int32).Value = idVenda
		cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProduto
		cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = idFornecedor
		cmd.ExecuteNonQuery	
		
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar excluir Item "+ ex.Message)
	  End Try	
	End Sub
	
	
	Public function SelecionaEstoque (idProduto As Integer, idFornecedor As Integer) As Integer
		Dim dr As  MySqlDataReader
		Try
			sql = "select qtd from 7gfrota.prod_for  where idProduto = @idProduto and idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = idFornecedor
			dr = cmd.ExecuteReader
			dr.Read
			venda.Estoque = dr.GetInt32(0)
			dr.Close
		Catch ex As MySqlException
			MsgBox("Erro ao selecionar estoque: " + ex.Message)	
		End Try	
		Return venda.Estoque
	End Function
	
	
	
	Public Sub AtualizaEstoque (estoque As Integer,idProduto As Integer, idFornecedor As Integer)
		Try
			sql = "update 7gfrota.prod_for Set  QTD = @QTD  where idProduto = @idProduto and idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = estoque
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = IdProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = IdFornecedor
			cmd.ExecuteNonQuery	
		Catch ex As MySqlException
			MsgBox("Erro ao atualizar estoque: " + ex.Message)	
		End Try	
	End Sub
	
	
	Public Function RetornaVenda (idVenda As String) As EntPDV
		Dim dr As  MySqlDataReader
			Try
				sql = "select *  from 7gfrota.vendas where idVendas = @idVendas"
				cmd = New MySqlCommand(sql,con)
				cmd.Parameters.Add("@idVendas",MySqlDbType.Int32).Value = idVenda
				dr = cmd.ExecuteReader
				dr.Read
				venda.IdVenda = dr.GetInt32(0)
				venda.IdFormaPagamento = dr.GetInt32(1)
				venda.IdCliente = dr.GetInt32(2)
				venda.DataVenda = dr.GetString(3)
				venda.Desconto = dr.GetDouble(4)
				venda.ValorTotal = dr.GetDouble(5)
				venda.Pago = dr.GetDouble(6)
				venda.Troco = dr.GetDouble(7)
				venda.Aberta = dr.GetBoolean(8)
				dr.Close
			Catch erro As MySqlException
				MsgBox("Código de orçamento não localizado -> " + erro.Message,vbInformation,"ERRO")
				dr.Close
				venda.IdVenda = 0
			End Try
			
			Return venda
	End Function
	
	
	
	Public Function RetornaVendasPeriodo_Status (aberta As Boolean, data1 As Date, data2 As Date) As DataTable ' Usado no form RelatorioVendas_Status
		Dim dt As New DataTable
		Try
				'                      0                       1                2                   3               4                5              6            7            8
				sql = "Select vendas.idVendas,formapagamentos.Forma,clientes.NomeCliente,vendas.DataVenda,vendas.Desconto,vendas.ValorTotal,vendas.Pago,vendas.Troco,vendas.Aberta " & _
				      "FROM(`7gfrota`.vendas vendas INNER JOIN `7gfrota`.formapagamentos formapagamentos On (vendas.idFormaPagamento = formapagamentos.idFormaPagamento)) " & _
					  "INNER JOIN `7gfrota`.clientes clientes ON (vendas.idCliente = clientes.idCliente) where aberta =  @aberta and dataVenda between  @data1  and  @data2  order by datavenda , idvendas "	
				cmd = New MySqlCommand(sql,con)
				cmd.Parameters.Add("@aberta",MySqlDbType.Bit).Value = aberta
				cmd.Parameters.Add("@data1",MySqlDbType.Date).Value = data1
				cmd.Parameters.Add("@data2",MySqlDbType.Date).Value = data2
				Dim da As New MySqlDataAdapter
				da.SelectCommand = cmd
				da.Fill(dt)
				
			Catch erro As MySqlException
				MsgBox("Erro ao tentar exibir vendas -> " + erro.Message,vbInformation,"ERRO")
			End Try
			Return dt
			dr.Close
	End Function
	
	
	Public Function RetornaItensVenda (idVenda As String) As DataTable
			 Dim dt As New DataTable
	 	Try       '                  0                    1                   2               3                    4                  5                       6                    7
	 		sql = "Select produtos.Nome,fornecedores.NomeFantasia,itemvendas.QTD,prod_for.PrecoVenda, itemvendas.Valor,itemvendas.idProduto,itemvendas.idFornecedor,itemvendas.idVenda " & _
	 			"FROM(((`7gfrota`.prod_for prod_for INNER JOIN `7gfrota`.produtos produtos On (prod_for.idProduto = produtos.idProduto)) " & _
	 			"INNER JOIN `7gfrota`.fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor)) " & _
	 			"INNER JOIN `7gfrota`.itemvendas itemvendas On (itemvendas.idProduto = prod_for.idProduto) And (itemvendas.idFornecedor = prod_for.idFornecedor)) " & _
	 			"INNER JOIN `7gfrota`.vendas vendas ON (itemvendas.idVenda = vendas.idVendas) where itemvendas.idVenda = " + idVenda + " order by produtos.Nome"
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		 Catch ex As MySqlException	
				MsgBox("erro ao tentar exibir Itens da venda "+ ex.Message)
		 End Try
   		Return dt 	
	End Function
	
	
	
	Public Function ExibeEstoque (filtroSql As String)  As DataTable
 	  Dim dt As New DataTable
	 	Try                                       
	 		sql = "Select categorias.Nome,produtos.Nome,fornecedores.NomeFantasia,prod_for.QTD,prod_for.PrecoCusto,prod_for.PrecoVenda " & _
	 			"FROM ((`7gfrota`.produtos produtos INNER JOIN `7gfrota`.categorias categorias On (produtos.idCategoria = categorias.idCategoria)) " & _
	 			"INNER JOIN `7gfrota`.prod_for prod_for On (prod_for.idProduto = produtos.idProduto)) " & _
	 			"INNER JOIN `7gfrota`.fornecedores fornecedores ON (prod_for.idFornecedor = fornecedores.idFornecedor)" + filtroSql
	 		
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		  Catch ex As MySqlException	
			MsgBox("erro ao tentar exibir Estoque "+ ex.Message)
		End Try
	  
   		Return dt 	
	End Function
	
	
	Public Function sQLGENERICA(filtro As String) As DataTable
		Dim dt As New DataTable
		Try                                       
	 		sql = filtro
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		  Catch ex As MySqlException	
			MsgBox("erro na SQL GENERICA "+ ex.Message)
		End Try
   		Return dt 	
	End Function
	
End Class
