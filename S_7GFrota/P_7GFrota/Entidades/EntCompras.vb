'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 2/4/2014
' Hora: 12:54
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class EntCompras
	Private m_IdCompra As Integer
	Private m_IdProduto As Integer
	Private m_IdFornecedor As Integer
	Private m_NomeProduto As String
	Private m_NomeFantasia As String
	Private m_DataCompra As String
	Private m_ValorTotal As Double
	Private m_Detalhe As String
	Private m_Qtd As Integer
	Private m_PrecoCusto As Double
	
	Public Property IdCompra() As Integer
		Get
			Return m_IdCompra
		End Get
		Set
			m_IdCompra = value
		End Set
	End Property

	Public Property IdProduto() As Integer
		Get
			Return m_IdProduto
		End Get
		Set
			m_IdProduto = value
		End Set
	End Property

	Public Property IdFornecedor() As Integer
		Get
			Return m_IdFornecedor
		End Get
		Set
			m_IdFornecedor = value
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

	Public Property NomeFantasia() As String
		Get
			Return m_NomeFantasia
		End Get
		Set
			m_NomeFantasia = value
		End Set
	End Property

	Public Property DataCompra() As String
		Get
			Return m_DataCompra
		End Get
		Set
			m_DataCompra = value
		End Set
	End Property

	Public Property ValorTotal() As Double
		Get
			Return m_ValorTotal
		End Get
		Set
			m_ValorTotal = value
		End Set
	End Property

	Public Property Detalhe() As String
		Get
			Return m_Detalhe
		End Get
		Set
			m_Detalhe = value
		End Set
	End Property

	Public Property Qtd() As Integer
		Get
			Return m_Qtd
		End Get
		Set
			m_Qtd = value
		End Set
	End Property

	Public Property PrecoCusto() As Double
		Get
			Return m_PrecoCusto
		End Get
		Set
			m_PrecoCusto = value
		End Set
	End Property
	
	
End Class
