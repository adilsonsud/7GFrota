'
' Criado por SharpDevelop.
' Usuário: Admin
' Data: 18/11/2013
' Hora: 11:09
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'

Imports System
Imports MySql.Data.MySqlClient
Imports System.Configuration




Public Class CL_Conexao
	
	Dim con As New MySqlConnection
	
	Public  function  conectar () As MySqlConnection
		Try
			con.ConnectionString = "Server=localhost;Database=7gfrota;Uid=root;Pwd=root123;Connect Timeout=30"
			con.Open
		Catch ex As MySqlException
			MsgBox("Erro ao tentar conectar ao banco -> " & ex.Message)
		End Try		
			Return con
	End Function
	
	Public Sub desconectar
		Try
			con.Close
		Catch ex As MySqlException
			MsgBox("Erro ao desconectar do banco -> " & ex.Message)
		End Try
	End Sub
	
	
End Class


