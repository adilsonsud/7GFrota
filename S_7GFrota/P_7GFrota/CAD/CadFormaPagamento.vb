'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 12:17
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'	
Imports	MySql.Data.MySqlClient
Imports System.Data

Public Class CadFormaPagamento

	Dim conexao As New CL_Conexao	
	Dim con As New MySqlConnection
	Dim cmd As MySqlCommand
	Dim dr As MySqlDataReader
	Dim sql As String
	
	Public Sub New()
		con = conexao.conectar
	End Sub
	
	Public Sub AdicionarFormaPagamento (FormaPagamento As EntFormaPagamento)
	
	Try
			sql = ("insert into 7gfrota.FormaPagamentos (forma) values (@nome)")
			cmd = New MySqlCommand(sql, con)	
			
			cmd.Parameters.Add("@nome",MySqlDbType.String).Value = FormaPagamento.NomeFormaPagamento
			cmd.ExecuteNonQuery		
			MsgBox("Inserido com sucesso",vbOKOnly,"Cadastro de Forma de Pagamento")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar inserir Dados no Banco: " + ex.Message)	
		End Try		
	End Sub
	
	
	Public Sub EditarFormaPagamento (FormaPagamento As EntFormaPagamento)
		Try
			sql = "update 7gfrota.FormaPagamentos Set forma = @forma where idFormaPagamento = @idFormaPagamento"
			
			cmd = New MySqlCommand(sql, con)	
			cmd.Parameters.Add("@forma",MySqlDbType.String).Value = FormaPagamento.NomeFormaPagamento
			cmd.Parameters.Add("@idFormaPagamento",MySqlDbType.Int32).Value = FormaPagamento.IdFormaPagamento
			cmd.ExecuteNonQuery		
			MsgBox("Alterado com sucesso",vbOKOnly,"Cadastro de Forma de Pagamento")
			
		Catch ex As MySqlException
			MsgBox("Erro ao tentar editar Dados no Banco: " + ex.Message)	
		End Try
	End Sub
	
	
	Public Sub ExcluirFormaPagamento(idFormaPagamento As String)
	  Try 
		sql="delete from 7gfrota.FormaPagamentos where idFormaPagamento = " + idFormaPagamento
		cmd = New MySqlCommand(sql,con)	
		cmd.ExecuteNonQuery	
		MsgBox("Exclusão bem sucedida", vbOKOnly, "Cadastro de Forma de Pagamento")
		
	  Catch ex As MySqlException	
		MsgBox("erro ao tentar excluir forma de pagamento! "+ ex.Message)
	  End Try	
	End Sub
	
	Public Function LocalizarFormaPagamento(nomeForma As String)As DataTable
		Dim dt As New DataTable
		Try
			sql = " select  * from 7gfrota.FormaPagamentos where forma like '%"& nomeForma & "%'"	
			'cmd = New MySqlCommand(sql,con)
			'dr = cmd.ExecuteReader
			
			Dim da As New MySqlDataAdapter(sql, con)
			da.Fill(dt)	
		Catch ex As MySqlException
			MsgBox("Erro ao tentar localizar Forma de Pagamento no Banco de dados: " + ex.Message)
		End Try
		Return dt
	End Function
		
	
	Public Sub desconectar
		con.Close
		conexao.desconectar
	End Sub
	
	
End Class
