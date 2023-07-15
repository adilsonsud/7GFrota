'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 14/3/2014
' Hora: 18:21
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class EntProdFor
	Private m_idProduto As Integer
	Private m_idFornecedor As Integer
	Private m_Produto As String
	Private m_Fornecedor As String
	Private m_QTD As Integer
	Private m_PrecoCusto As Double
	Private m_PrecoVenda As Double
	
	Public Property IdProduto() As Integer
		Get
			Return m_idProduto
		End Get
		Set
			m_idProduto = value
		End Set
	End Property

	Public Property IdFornecedor() As Integer
		Get
			Return m_idFornecedor
		End Get
		Set
			m_idFornecedor = value
		End Set
	End Property

	Public Property Produto() As String
		Get
			Return m_Produto
		End Get
		Set
			m_Produto = value
		End Set
	End Property

	Public Property Fornecedor() As String
		Get
			Return m_Fornecedor
		End Get
		Set
			m_Fornecedor = value
		End Set
	End Property

	Public Property QTD() As Integer
		Get
			Return m_QTD
		End Get
		Set
			m_QTD = value
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

	Public Property PrecoVenda() As Double
		Get
			Return m_PrecoVenda
		End Get
		Set
			m_PrecoVenda = value
		End Set
	End Property
	
End Class
