'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 12:09
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class EntFormaPagamento
	Private m_idFormaPagamento As Integer
	Private m_nomeFormaPagamento As String
	
	Public Property IdFormaPagamento() As Integer
		Get
			Return m_idFormaPagamento
		End Get
		Set
			m_idFormaPagamento = value
		End Set
	End Property

	Public Property NomeFormaPagamento() As String
		Get
			Return m_nomeFormaPagamento
		End Get
		Set
			m_nomeFormaPagamento = value
		End Set
	End Property
	
End Class
