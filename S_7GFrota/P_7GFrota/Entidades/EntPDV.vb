'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 15/04/2014
' Hora: 18:40
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class EntPDV
	Private m_idVenda As Integer
	Private m_idFormaPagamento As Integer
	Private m_idCliente As Integer
	Private m_idProduto As Integer
	Private m_idFornecedor As Integer
	Private m_NomeFormaPagamento As String
	Private m_NomeCliente As String
	Private m_NomeProduto As String
	Private m_NomeFantasia As String
	Private m_dataVenda As Date
	Private m_desconto As Double
	Private m_valorTotal As Double
	Private m_Pago As Double
	Private m_Troco As Double
	Private m_Aberta As Boolean
	Private m_QTD As Integer
	Private m_valor As Double
	Private m_estoque As Integer
	Private m_precovenda As Double
	
	
	Public Property IdVenda() As Integer
		Get
			Return m_idVenda
		End Get
		Set
			m_idVenda = value
		End Set
	End Property

	Public Property IdFormaPagamento() As Integer
		Get
			Return m_idFormaPagamento
		End Get
		Set
			m_idFormaPagamento = value
		End Set
	End Property

	Public Property IdCliente() As Integer
		Get
			Return m_idCliente
		End Get
		Set
			m_idCliente = value
		End Set
	End Property

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

	Public Property NomeFormaPagamento() As String
		Get
			Return m_NomeFormaPagamento
		End Get
		Set
			m_NomeFormaPagamento = value
		End Set
	End Property

	Public Property NomeCliente() As String
		Get
			Return m_NomeCliente
		End Get
		Set
			m_NomeCliente = value
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

	Public Property DataVenda() As DateTime
		Get
			Return m_dataVenda
		End Get
		Set
			m_dataVenda = value
		End Set
	End Property

	Public Property Desconto() As Double
		Get
			Return m_desconto
		End Get
		Set
			m_desconto = value
		End Set
	End Property

	Public Property ValorTotal() As Double
		Get
			Return m_valorTotal
		End Get
		Set
			m_valorTotal = value
		End Set
	End Property

	Public Property Pago() As Double
		Get
			Return m_Pago
		End Get
		Set
			m_Pago = value
		End Set
	End Property

	Public Property Troco() As Double
		Get
			Return m_Troco
		End Get
		Set
			m_Troco = value
		End Set
	End Property

	Public Property Aberta() As Boolean
		Get
			Return m_Aberta
		End Get
		Set
			m_Aberta = value
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

	Public Property Valor() As Double
		Get
			Return m_valor
		End Get
		Set
			m_valor = value
		End Set
	End Property

	Public Property Estoque() As Integer
		Get
			Return m_estoque
		End Get
		Set
			m_estoque = value
		End Set
	End Property

	Public Property Precovenda() As Double
		Get
			Return m_precovenda
		End Get
		Set
			m_precovenda = value
		End Set
	End Property
End Class
