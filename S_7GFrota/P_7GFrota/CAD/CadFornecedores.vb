'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 6/3/2014
' Hora: 18:35
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadFornecedores
	
	Dim conexao As New CL_Conexao	
	Dim con As New MySqlConnection
	Dim cmd As MySqlCommand
	Dim dr As MySqlDataReader
	
	Dim sql As String
	
	Public Sub New()
		con = conexao.conectar
	End Sub
	
	Public Sub AdicionarFornecedor (fornecedor As EntFornecedores)
	
	Try
			sql = ("insert into 7gfrota.fornecedores (P_FisicaJuridica, CPF_CNPJ, InscricaoEstadual, NomeFantasia, RazaoSocial, Endereco, Complemento, Bairro, Cep, Cidade, Estado, Fone1, Fone2, Fone3, Fone4, Email1, Email2, site) values (@P_FisicaJuridica, @CPF_CNPJ, @InscricaoEstadual, @NomeFantasia, @RazaoSocial, @Endereco, @Complemento, @Bairro, @Cep, @Cidade, @Estado, @Fone1, @Fone2, @Fone3, @Fone4, @Email1, @Email2, @site)")
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@P_FisicaJuridica",MySqlDbType.String).Value = fornecedor.P_FisicaJuridica
			cmd.Parameters.Add("@CPF_CNPJ", MySqlDbType.String).Value = fornecedor.CPF_CNPJ
			cmd.Parameters.Add("@InscricaoEstadual",MySqlDbType.String).Value = fornecedor.InscricaoEstadual
			cmd.Parameters.Add("@NomeFantasia",MySqlDbType.String).Value = fornecedor.NomeFantasia
			cmd.Parameters.Add("@RazaoSocial",MySqlDbType.String).Value = fornecedor.RazaoSocial
			cmd.Parameters.Add("@Endereco",MySqlDbType.String).Value = fornecedor.Endereco
			cmd.Parameters.Add("@Complemento",MySqlDbType.String).Value = fornecedor.Complemento
			cmd.Parameters.Add("@Bairro",MySqlDbType.String).Value = fornecedor.Bairro
			cmd.Parameters.Add("@Cep",MySqlDbType.String).Value = fornecedor.Cep
			cmd.Parameters.Add("@Cidade",MySqlDbType.String).Value = fornecedor.Cidade
			cmd.Parameters.Add("@Estado",MySqlDbType.String).Value = fornecedor.Estado
			cmd.Parameters.Add("@Fone1",MySqlDbType.String).Value = fornecedor.Fone1
			cmd.Parameters.Add("@Fone2",MySqlDbType.String).Value = fornecedor.Fone2
			cmd.Parameters.Add("@Fone3",MySqlDbType.String).Value = fornecedor.Fone3
			cmd.Parameters.Add("@Fone4",MySqlDbType.String).Value = fornecedor.Fone4
			cmd.Parameters.Add("@Email1",MySqlDbType.String).Value = fornecedor.Email1
			cmd.Parameters.Add("@Email2",MySqlDbType.String).Value = fornecedor.Email2
			cmd.Parameters.Add("@site", MySqlDbType.String).Value = fornecedor.Site
			cmd.ExecuteNonQuery		
			MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Fornecedores")	
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		End Try		
	End Sub
	
	
	Public Sub EditarFornecedor (fornecedor As EntFornecedores)
		Try
			sql = "update 7gfrota.fornecedores Set P_FisicaJuridica = @P_FisicaJuridica, CPF_CNPJ = @CPF_CNPJ, InscricaoEstadual = @InscricaoEstadual," & _
				"			NomeFantasia = @NomeFantasia, RazaoSocial = @RazaoSocial," & _
				"			Endereco = @Endereco, Complemento = @Complemento, Bairro = @Bairro, Cep = @Cep, Cidade = @Cidade, Estado = @Estado, " & _
				"			Fone1 = @Fone1, Fone2 = @Fone2, Fone3 = @Fone3, Fone4 = @Fone4, Email1 = @Email1, Email2 = @Email2, site = @site" & _
				"			where idfornecedor = @idfornecedor"	
			
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@P_FisicaJuridica",MySqlDbType.String).Value = fornecedor.P_FisicaJuridica
			cmd.Parameters.Add("@CPF_CNPJ", MySqlDbType.String).Value = fornecedor.CPF_CNPJ
			cmd.Parameters.Add("@InscricaoEstadual",MySqlDbType.String).Value = fornecedor.InscricaoEstadual
			cmd.Parameters.Add("@NomeFantasia",MySqlDbType.String).Value = fornecedor.NomeFantasia
			cmd.Parameters.Add("@RazaoSocial",MySqlDbType.String).Value = fornecedor.RazaoSocial
			cmd.Parameters.Add("@Endereco",MySqlDbType.String).Value = fornecedor.Endereco
			cmd.Parameters.Add("@Complemento",MySqlDbType.String).Value = fornecedor.Complemento
			cmd.Parameters.Add("@Bairro",MySqlDbType.String).Value = fornecedor.Bairro
			cmd.Parameters.Add("@Cep",MySqlDbType.String).Value = fornecedor.Cep
			cmd.Parameters.Add("@Cidade",MySqlDbType.String).Value = fornecedor.Cidade
			cmd.Parameters.Add("@Estado",MySqlDbType.String).Value = fornecedor.Estado
			cmd.Parameters.Add("@Fone1",MySqlDbType.String).Value = fornecedor.Fone1
			cmd.Parameters.Add("@Fone2",MySqlDbType.String).Value = fornecedor.Fone2
			cmd.Parameters.Add("@Fone3",MySqlDbType.String).Value = fornecedor.Fone3
			cmd.Parameters.Add("@Fone4",MySqlDbType.String).Value = fornecedor.Fone4
			cmd.Parameters.Add("@Email1",MySqlDbType.String).Value = fornecedor.Email1
			cmd.Parameters.Add("@Email2",MySqlDbType.String).Value = fornecedor.Email2
			cmd.Parameters.Add("@site",MySqlDbType.String).Value = fornecedor.Site
			cmd.Parameters.Add("@idfornecedor",MySqlDbType.Int32).Value = fornecedor.IdFornecedor
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Fornecedores")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		End Try
		
	End Sub
	
	Public Sub ExcluirFornecedor(idfornecedor As String)
		Try 
		sql="delete from 7gfrota.fornecedores where idfornecedor = " + idfornecedor
		cmd = New MySqlCommand(sql,con)	
		cmd.ExecuteNonQuery	
		MsgBox("Exclusão bem sucedida")
		
	Catch ex As MySqlException	
		MsgBox("erro ao tentar excluir fornecedor "+ ex.Message)
	End Try
		
	End Sub
	
	Public Function LocalizarFornecedor(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  * from 7gfrota.fornecedores where nomeFantasia like '%"& nome & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, con)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar fornecedor no Banco de dados: " + ex.Message)
		End Try
		Return dt
	End Function
	
	
	Public Function RetornaNomeFornecedor(nome As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  NomeFantasia from 7gfrota.fornecedores where nomeFantasia like '%"& nome & "%'"	
			
			Dim da As New MySqlDataAdapter(sql, con)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar nome do fornecedor : " + ex.Message)
		End Try
		Return dt
	End Function
		
	
	Public Sub desconectar
		con.Close
		conexao.desconectar
	End Sub
	
End Class
