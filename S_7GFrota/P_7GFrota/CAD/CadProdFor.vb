'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 14/3/2014
' Hora: 18:28
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class CadProdFor
	Dim conexao As New CL_Conexao	
	Dim ProdFor As New EntProdFor
	Dim con As New MySqlConnection
	Dim cmd As MySqlCommand
	Dim dr As MySqlDataReader
	Dim sql As String
	
	Public Sub New()
		con = conexao.conectar
	End Sub
	
  Public Sub AdicionarProdFor (ProdFor As EntProdFor)
	
	 Try
		sql = ("insert into 7gfrota.prod_for (idProduto, idFornecedor, QTD, PrecoCusto, PrecoVenda) values (@idProduto, @idFornecedor, @QTD, @PrecoCusto, @PrecoVenda)")
		cmd = New MySqlCommand(sql, con)	
		cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ProdFor.IdProduto
		cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = ProdFor.IdFornecedor
		cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ProdFor.QTD
		cmd.Parameters.Add("@PrecoCusto",MySqlDbType.Double).Value = ProdFor.PrecoCusto
		cmd.Parameters.Add("@PrecoVenda",MySqlDbType.Double).Value = ProdFor.PrecoVenda
		cmd.ExecuteNonQuery		
		MsgBox("Inserido com sucesso",vbOKOnly,"Produto do Fornecedor")	
			
	 Catch ex As MySqlException
		MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
	 End Try		
  End Sub
  
  Public Sub EditarProdFor (ProdFor As EntProdFor)
		Try
			sql = "update 7gfrota.prod_for Set  QTD = @QTD, PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda  where idProduto = @idProduto and idFornecedor = @idFornecedor"
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@QTD",MySqlDbType.Int32).Value = ProdFor.QTD
			cmd.Parameters.Add("@PrecoCusto",MySqlDbType.Double).Value = ProdFor.PrecoCusto
			cmd.Parameters.Add("@PrecoVenda",MySqlDbType.Double).Value = ProdFor.PrecoVenda
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = ProdFor.IdProduto
			cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = ProdFor.IdFornecedor
			cmd.ExecuteNonQuery	
			MsgBox("Alterado com sucesso",vbOKOnly, "Produto do Fornecedor")	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		End Try	
  End Sub
  
  Public Sub ExcluirProdFor(idProd As String, idFor As String)
		Try 
		sql="delete from 7gfrota.prod_for where idProduto = @idProduto and idFornecedor = @idFornecedor"
		cmd = New MySqlCommand(sql,con)	
		cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = idProd
		cmd.Parameters.Add("@idFornecedor", MySqlDbType.Int32).Value = idFor
		cmd.ExecuteNonQuery	
		MsgBox("Exclusão bem sucedida", vbOKOnly, "Produto do Fornecedor")
		
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar excluir Produto deste Fornecedor "+ ex.Message)
	  End Try
  End Sub
  
 'Sub para preencher o gride 
 Public Function ExibeProdutosFornecedor  (idForn As String) As DataSet
 	Dim ds As New DataSet
 	Try                            '  0                     1                2                  3                   4                 5                 6 
		sql = "Select  fornecedores.NomeFantasia, produtos.Nome, prod_for.idProduto,prod_for.idFornecedor,prod_for.QTD, prod_for.PrecoCusto, prod_for.precoVenda " & _
			"FROM (`7gfrota`.prod_for prod_for INNER JOIN `7gfrota`.fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor))" & _
			"INNER JOIN `7gfrota`.produtos produtos On (prod_for.idProduto = produtos.idProduto) where prod_for.idFornecedor = "  & idForn
		
		Dim da As new MySqlDataAdapter(sql,con)
		da.Fill(ds,"prod_for")	
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar exibir Produtos "+ ex.Message)
	End Try
	  
   Return ds 	
 End Function
 
 
 'Sub para preencher o combo
 Public Function ExibeProdutos  As MySqlDataReader
 	Try 
		sql="select * from 7gfrota.produtos " 
		cmd = New MySqlCommand(sql,con)	
		dr = cmd.ExecuteReader	
		
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar exibir Produtos "+ ex.Message)
	  End Try
	  
	  Return dr 	
	  dr.Close
 End Function
 
 
Public Function selecionaIdProduto (NomeProduto As String) As MySqlDataReader
	
	sql = "select idProduto from 7gfrota.produtos where Nome = '" + NomeProduto + "'"
		Try
				cmd = New MySqlCommand(sql,con)	
				dr = cmd.ExecuteReader  
			Catch ex As Exception
				MsgBox("erro ao selecionar IdProduto "+ ex.ToString)
			End Try	
		Return dr
		dr.Close
End Function 

 
End Class
 
 
 
