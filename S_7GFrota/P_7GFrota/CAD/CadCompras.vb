'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 2/4/2014
' Hora: 01:00
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class CadCompras
	Dim conexao As New CL_Conexao
	Dim sql As String
	Dim con As New MySqlConnection
	Dim cmd As MySqlCommand
	Dim compras As New EntCompras
	Dim dr As MySqlDataReader
	
	
	Public Sub New()
		con = conexao.conectar
	End Sub
	
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
	
	Public Sub AdicionarCompra (compra As EntCompras)
	
	    Try
			sql = ("insert into 7gfrota.compras (DataCompra, ValorTotal, Detalhe) values (@DataCompra, @ValorTotal, @Detalhe)")
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@DataCompra",MySqlDbType.Date).Value = Today
			cmd.Parameters.Add("@ValorTotal", MySqlDbType.Double).Value = compra.ValorTotal
			cmd.Parameters.Add("@Detalhe", MySqlDbType.string).Value = compra.Detalhe
			cmd.ExecuteNonQuery		
			
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados da compa no Banco: " + ex.Message)	
		End Try		
	End Sub
	
	
	Public Function RetornaIdCompra As Integer
		Dim dr As  MySqlDataReader
		
		sql = ("SELECT max(idcompra) from 7gfrota.compras")
		cmd = New MySqlCommand(sql,con)
		dr = cmd.ExecuteReader
		 dr.Read
		compras.IdCompra = dr.GetInt32(0)
		dr.Close
		Return compras.IdCompra
	End Function
	
	
	
	Public function AdicionarItensCompra (ItensCompra As  EntCompras) As Boolean
		Dim insere As Boolean 'serve para decidir se vai ser inserido no grid 
	    Try
			sql = ("insert into 7gfrota.ItemCompras (idProduto, idFornecedor,idCompra, QTD, PrecoCusto) values (@idProduto, @idFornecedor,@idCompra, @QTD, @PrecoCusto)")
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ItensCompra.IdProduto
			cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = ItensCompra.IdFornecedor
			cmd.Parameters.Add("@idCompra",MySqlDbType.Int32).Value = ItensCompra.IdCompra
			cmd.Parameters.Add("@qtd",MySqlDbType.Int32).Value = ItensCompra.Qtd
			cmd.Parameters.Add("@PrecoCusto",MySqlDbType.Double).Value = ItensCompra.PrecoCusto
			cmd.ExecuteNonQuery		
			
			insere  = True
			
			Catch ex As MySqlException
				MsgBox("Verifique se este item já foi incluido: -> " + ex.Message, vbOKOnly, "Erro ao Inserir Item!")	
				insere = False
			End Try		
		Return insere
	End Function
	
	
	
	Public Sub AtualizarCompras (compra As EntCompras)
		Try
			sql = "update 7gfrota.compras Set DataCompra = @DataCompra, ValorTotal = @ValorTotal, Detalhe = @Detalhe where idCompra = @idCompra"
			
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@DataCompra",MySqlDbType.String).Value = compra.DataCompra
			cmd.Parameters.Add("@ValorTotal",MySqlDbType.Double).Value = compra.ValorTotal
			cmd.Parameters.Add("@Detalhe",MySqlDbType.String).Value = compra.Detalhe
			cmd.Parameters.Add("@idCompra",MySqlDbType.Int32).Value = compra.IdCompra
			cmd.ExecuteNonQuery		
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		End Try
	End Sub
	
	
	
	Public Sub AtualizaItensCompras (ItensCompra As EntCompras)
		Try
			sql = "update 7gfrota.ItemCompras Set QTD = @QTD where  idProduto = @idProduto and  idFornecedor = @idFornecedor and idCompra = @idCompra"
			
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ItensCompra.Qtd
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ItensCompra.IdProduto
			cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = ItensCompra.IdFornecedor
			cmd.Parameters.Add("@idCompra",MySqlDbType.Int32).Value = ItensCompra.IdCompra
			cmd.ExecuteNonQuery		
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar atualizar Itens da Compra no Dados no Banco: " + ex.Message)	
		End Try
		
	End Sub
	
	
		
	Public Sub ExcluirItenCompra(idCompra As Integer, idProduto As Integer, idFornecedor As Integer)
	  Try 
		sql="delete from 7gfrota.ItemCompras where idProduto = @idProduto  and idFornecedor = @idFornecedor and idCompra = @idCompra " 
		cmd = New MySqlCommand(sql,con)	
		cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProduto
		cmd.Parameters.Add("@idFornecedor",MySqlDbType.Int32).Value = idFornecedor
		cmd.Parameters.Add("@idCompra",MySqlDbType.Int32).Value = idCompra
		cmd.ExecuteNonQuery	
		
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar excluir Item "+ ex.Message)
	  End Try	
	End Sub
	
	
	Public Function SelecionaEstoque (IdProduto As Integer, IdFornecedor As Integer)As MySqlDataReader 'Serve para retornar o campo QTD de um produto da tabela ProdFor. 'Usado quando se pretende atualizar o estoque, então chama-se antes da sub atualizaEstoque, para poder obter o valor atual
		
			Try
				sql = "select QTD from 7gfrota.prod_for  where idProduto = @idProduto and idFornecedor = @idFornecedor"
				cmd = New MySqlCommand(sql, con)	
				cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = IdProduto
				cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = IdFornecedor
				dr = cmd.ExecuteReader		
					
			Catch ex As MySqlException
				MsgBox("Erro ao tentar selecionar Estoque -> " + ex.Message)	
			End Try																								   
		
		Return dr	
		dr.Close
	End Function
	
	
	
	Public Sub atualizaEstoque(qtd As Integer, IdProduto As Integer, IdFornecedor As Integer) ' atualiza o valor de QTD na tabela ProdFor, antes de chamar esta sub, deve-se obter o valro do estoque atual chamando a function SelecionaEstoque
		
		Try
			sql = "update 7gfrota.prod_for Set  QTD = @QTD  where idProduto = @idProduto and idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = qtd
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = IdProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = IdFornecedor
			cmd.ExecuteNonQuery	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar atualizar Estoque -> " + ex.Message)	
		End Try	
		
	End Sub
	
	
	Public Function RetornaCompra(data1 As String, data2 As String) As DataTable
		 Dim dt As New DataTable
	 	Try                                       
	 		sql = "Select * from 7gfrota.compras where datacompra between " + "'" + data1 +  "'" + " and " + "'" + data2 +  " ' order by datacompra"
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		  Catch ex As MySqlException	
			MsgBox("erro ao tentar exibir Compra "+ ex.Message)
		End Try
	  
   		Return dt 	
		
	End Function
	
	
	
	Public Function RetornaItensCompra  (idCompra As String) As DataTable
 	  Dim dt As New DataTable
	 	Try                            '  0                1                    2                     3                   4     
	 		sql = "Select itemcompras.idCompra, produtos.Nome, fornecedores.NomeFantasia,itemcompras.QTD,itemcompras.PrecoCusto " & _
	 			"FROM (((`7gfrota`.prod_for prod_for INNER JOIN `7gfrota`.produtos produtos On (prod_for.idProduto = produtos.idProduto)) " & _
	 			"INNER JOIN `7gfrota`.itemcompras itemcompras On (itemcompras.idProduto = prod_for.idProduto)And (itemcompras.idFornecedor = prod_for.idFornecedor)) " & _
	 			"INNER JOIN `7gfrota`.compras compras On (itemcompras.idCompra = compras.idCompra))" & _
	 			"INNER JOIN `7gfrota`.fornecedores fornecedores ON (prod_for.idFornecedor = fornecedores.idFornecedor) where itemcompras.idCompra = " + idCompra + " order by produtos.Nome and fornecedores.NomeFantasia"
	 		
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		  Catch ex As MySqlException	
			MsgBox("erro ao tentar exibir Itens da Compra -> "+ ex.Message)
		End Try
	  
   		Return dt 	
	End Function
	
	
	
	Public Function RetornaValorCompra(data1 As String, data2 As String) As Double
		 Dim dr As  MySqlDataReader
	 	Try                                       
	 		sql = "Select SUM(ValorTotal) from 7gfrota.compras where datacompra between " + "'" + data1 +  "'" + " and " + "'" + data2 +  "'"
	 		cmd = New MySqlCommand(sql, con)	
	 		dr = cmd.ExecuteReader	
	 		dr.Read
	 		If dr.HasRows Then
	 			compras.ValorTotal = 0
	 			dr.Close
	 		Else
	 			compras.ValorTotal = dr.GetDouble(0)
	 			dr.Close
	 		End If
		  Catch ex As MySqlException	
			MsgBox("erro ao tentar exibir Valor dos Gastos -> "+ ex.Message)
		End Try
   		Return compras.ValorTotal 	
	End Function
	
	
	
	
	
	Public Function RetornaPrecoCusto(data1 As String, data2 As String) As Double
		 Dim dr As  MySqlDataReader
	 	Try                                       
	 		sql = "Select SUM(ValorTotal) from 7gfrota.compras where datacompra between " + "'" + data1 +  "'" + " and " + "'" + data2 +  "'"
	 		cmd = New MySqlCommand(sql, con)	
	 		dr = cmd.ExecuteReader	
	 		dr.Read
	 		compras.ValorTotal = dr.GetDouble(0)
	 		dr.Close
		  Catch ex As MySqlException	
			MsgBox("erro ao tentar exibir Preço custo -> "+ ex.Message)
		End Try
	  
   		Return compras.ValorTotal 	
		
	End Function
	
	
	
	
	Public Function RetornaCompraDetalhe(filtro As String) As DataTable
		 Dim dt As New DataTable
	 	Try                     '   0                 1                    2                 3             4                    5                     6                7                         
	 	  sql = "Select compras.idCompra, compras.DataCompra, compras.ValorTotal,categorias.Nome,produtos.Nome,fornecedores.NomeFantasia,itemcompras.QTD,itemcompras.PrecoCusto " & _
	 			"FROM ((((`7gfrota`.produtos produtos INNER JOIN `7gfrota`.categorias categorias On (produtos.idCategoria = categorias.idCategoria)) " & _
	 			"INNER JOIN `7gfrota`.prod_for prod_for On (prod_for.idProduto = produtos.idProduto)) " & _
	 			"INNER JOIN `7gfrota`.itemcompras itemcompras On (itemcompras.idProduto = prod_for.idProduto) And (itemcompras.idFornecedor = prod_for.idFornecedor)) " & _
	 			"INNER JOIN `7gfrota`.compras compras On (itemcompras.idCompra = compras.idCompra)) INNER JOIN `7gfrota`.fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor) " + filtro
	 			
	 		
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		  Catch ex As MySqlException	
			MsgBox("erro ao tentar exibir Compra -> "+ ex.Message)
		End Try
	  
   		Return dt 	
		
	End Function
	
		
	Public Sub desconectar
		con.Close
		conexao.desconectar
	End Sub
	
End Class
