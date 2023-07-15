'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 7/3/2014
' Hora: 23:02
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'

	
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadCategorias

	Dim conexao As New CL_Conexao	
	Dim con As New MySqlConnection
	Dim cmd As MySqlCommand
	Dim dr As MySqlDataReader
	Dim dt As New DataTable
	
	
	Dim sql As String
	
	Public Sub New()
		con = conexao.conectar
	End Sub
	
	Public Sub AdicionarCategoria (categoria As EntCategorias)
	
	Try
		sql = ("insert into 7gfrota.categorias (nome) values (@nome)")
		cmd = New MySqlCommand(sql, con)	
		
		cmd.Parameters.Add("@nome",MySqlDbType.String).Value = categoria.Nome
		cmd.ExecuteNonQuery		
		MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Categorias")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		End Try		
	End Sub
	
	
	Public Sub EditarCategoria (categoria As EntCategorias)
		Try
			sql = "update 7gfrota.categorias Set nome = @nome where idcategoria = @idcategoria"
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = categoria.Nome
			cmd.Parameters.Add("@idcategoria",MySqlDbType.Int32).Value = categoria.IdCategoria
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Categorias")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		End Try
		
	End Sub
	
	Public Sub ExcluirCategoria(idCategoria As String)
	  Try 
		sql="delete from 7gfrota.categorias where idcategoria = " + idCategoria
		cmd = New MySqlCommand(sql,con)	
		cmd.ExecuteNonQuery	
		MsgBox("Exclusão bem sucedida", vbOKOnly, "Cadastro de Categorias")
		
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar excluir categoria "+ ex.Message)
	  End Try	
	End Sub
	
	Public Function LocalizarCategoria(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  * from 7gfrota.categorias where nome like '%"& nome & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, con)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar categoria no Banco de dados: " + ex.Message)
		End Try
		Return dt
	End Function
	
	
	
	Public Function RetornaNomeCategoria(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select nome from 7gfrota.categorias where nome like '%"& nome & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, con)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar categoria no Banco de dados: " + ex.Message)
		End Try
		Return dt
	End Function
	
	Public Function rELATORIOCATEGORIA(filtroSql As String) As DataTable
		Dim dt As New DataTable
		Try                                       
	 		sql = "Select itemvendas.idVenda,categorias.Nome,produtos.Nome,fornecedores.NomeFantasia,itemvendas.QTD,itemvendas.Valor,vendas.DataVenda " & _
				  "FROM ((((`7gfrota`.prod_for prod_for INNER JOIN `7gfrota`.fornecedores fornecedores On (prod_for.idFornecedor = fornecedores.idFornecedor)) " & _
				  "INNER JOIN `7gfrota`.produtos produtos On (prod_for.idProduto = produtos.idProduto)) INNER JOIN `7gfrota`.categorias categorias On " & _
			      "(produtos.idCategoria = categorias.idCategoria)) INNER JOIN `7gfrota`.itemvendas itemvendas On (itemvendas.idProduto = prod_for.idProduto) And " & _
				  "(itemvendas.idFornecedor = prod_for.idFornecedor)) INNER JOIN `7gfrota`.vendas vendas On (itemvendas.idVenda = vendas.idVendas) " + filtroSql
			Dim da As new MySqlDataAdapter(sql,con)
			da.Fill(dt)	
		  Catch ex As MySqlException	
			MsgBox("Erro ao tentar exibir Consulta por Categoria "+ ex.Message)
		End Try
   		Return dt 	
	End Function
	
	Public Sub desconectar
		con.Close
		conexao.desconectar
	End Sub
	
	
	
End Class
