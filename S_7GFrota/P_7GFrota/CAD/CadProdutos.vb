'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 10/3/2014
' Hora: 19:20
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadProdutos
	
	Dim conexao As New CL_Conexao	
	Dim con As New MySqlConnection
	Dim cmd As MySqlCommand
	Dim dr As MySqlDataReader
	Dim sql As String
	
	Public Sub New()
		con = conexao.conectar
	End Sub
	
	Public Sub AdicionarProduto (produto As EntProdutos)
	
	Try
			sql = ("insert into 7gfrota.produtos (nome, idCategoria) values (@nome, @idCategoria)")
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = produto.NomeProduto
			cmd.Parameters.Add("@idCategoria", MySqlDbType.Int32).Value = produto.IdCategoria
			cmd.ExecuteNonQuery		
			MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Produtos")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		End Try		
	End Sub
	
	
	Public Sub EditarProduto (produto As EntProdutos)
		Try
			sql = "update 7gfrota.produtos Set nome = @nome, idcategoria = @idcategoria where idProduto = @idProduto"
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = produto.NomeProduto
			cmd.Parameters.Add("@idcategoria", MySqlDbType.Int32).Value = produto.IdCategoria
			cmd.Parameters.Add("@idProduto",MySqlDbType.Int32).Value = produto.IdProduto
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Produtos")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		End Try
	End Sub
	
	
	Public Sub ExcluirProduto(idProduto As String)
		Try 
			sql="delete from 7gfrota.produtos where idproduto = " + idProduto
			cmd = New MySqlCommand(sql,con)	
			cmd.ExecuteNonQuery	
			MsgBox("Exclusão bem sucedida", vbOKOnly, "Cadastro de Produtos")
			
		Catch ex As MySqlException	
			MsgBox("erro ao tentar excluir produto "+ ex.Message)
		End Try
	End Sub
	
'	Public Function LocalizarProduto(nome As String)As Dataset
'		Dim ds As New Dataset
'		Try
'			sql = " select  * from 7gfrota.produtos where nome like '%"& nome & "%'"	
'			Dim da As New MySqlDataAdapter(sql, con)
'			da.Fill(ds,"produtos")	
'		Catch ex As MySqlException
'			MsgBox("Erro ao tentar localizar produto no Banco de dados: " + ex.Message)
'		End Try
'		Return ds
'	End Function


	'lista tds os produtos da tb produtos e faz um join com tb categorias, usado no gride
Public Function LocalizarProduto (nome As String) As DataSet
	Dim ds As New Dataset

	Try
		sql = "Select produtos.Nome,categorias.Nome, produtos.idProduto, produtos.idCategoria FROM `7gfrota`.produtos produtos INNER JOIN `7gfrota`.categorias categorias On (produtos.idCategoria = categorias.idCategoria)" & _
		"		 WHERE produtos.nome like '%" & nome & "%' order by produtos.nome"   				
	
		
		Dim da As New MySqlDataAdapter(sql, con)
		da.Fill(ds)		

		Catch ex As MySqlException
			MsgBox("Erro ao localizar Produto" + ex.Message)	
		End Try
		    Return ds
End Function
	
	
	
'usada p/selecionar tds os nomes de categorias e armazenar em algum componente como ComboBox
Public	function CarregaNomeCategoria As MySqlDataReader
	sql = "select nome from 7gfrota.categorias"
		Try
			cmd = New MySqlCommand(sql,con)	
	   		dr = cmd.ExecuteReader  
		    
		Catch ex As MySqlException
			MsgBox("Erro ao listar categorias ->" + ex.ToString)	
		End Try	
	Return dr
	dr.Close
End Function


Public Function selecionaIdCategoria (NomeCategoria As String) As MySqlDataReader
	
	sql = "select idCategoria from 7gfrota.categorias where nome = '" + NomeCategoria + "'"
		Try
				cmd = New MySqlCommand(sql,con)	
				dr = cmd.ExecuteReader  
			Catch ex As Exception
				MsgBox("erro ao selecionar IdCategoria "+ ex.ToString)
			End Try	
		Return dr
		dr.Close
	
End Function

Public Function RetornaNomeProduto (nome As String)  As DataTable
	Dim dt As New DataTable
	
	Try
		sql="select nome from 7gfrota.produtos where nome like '%"& nome & "%'"
		Dim da As New MySqlDataAdapter(sql, con)
		da.Fill(dt)	
		
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar exibir o Produto "+ ex.Message)
	  End Try
	  
	  Return dt	
 End Function
 
 
	Public Sub desconectar
		con.Close
		conexao.desconectar
	End Sub
	
End Class
