'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 10/3/2014
' Hora: 19:20
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class EntProdutos
	Private m_idProduto As Integer
	Private m_NomeProduto As String
	Private m_idCategoria As Integer
	Private m_nomeCategoria As String
	
	Public Property IdProduto() As Integer
		Get
			Return m_idProduto
		End Get
		Set
			m_idProduto = value
		End Set
	End Property

	Public Property NomeProduto() As String
		Get
			Return m_NomeProduto
		End Get
		Set
			m_NomeProduto = value
		End Set
	End Property

	Public Property IdCategoria() As Integer
		Get
			Return m_idCategoria
		End Get
		Set
			m_idCategoria = value
		End Set
	End Property

	Public Property NomeCategoria() As String
		Get
			Return m_nomeCategoria
		End Get
		Set
			m_nomeCategoria = value
		End Set
	End Property
	
End Class
