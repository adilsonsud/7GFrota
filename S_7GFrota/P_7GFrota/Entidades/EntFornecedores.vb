'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 3/3/2014
' Hora: 01:58
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class EntFornecedores
	Private m_IdFornecedor As Integer
	Private m_P_FisicaJuridica As Char
	Private m_CPF_CNPJ As String
	Private m_InscricaoEstadual As String
	Private m_NomeFantasia As String
	Private m_RazaoSocial As String
	Private m_Endereco As String
	Private m_Complemento As String
	Private m_Bairro As String
	Private m_Cep As String
	Private m_Cidade As String
	Private m_Estado As String
	Private m_Fone1 As String
	Private m_Fone2 As String
	Private m_Fone3 As String
	Private m_Fone4 As String
	Private m_Email1 As String
	Private m_Email2 As String
	Private m_Site As String
	
	Public Property IdFornecedor() As Integer
		Get
			Return m_IdFornecedor
		End Get
		Set
			m_IdFornecedor = value
		End Set
	End Property

	Public Property P_FisicaJuridica() As Char
		Get
			Return m_P_FisicaJuridica
		End Get
		Set
			m_P_FisicaJuridica = value
		End Set
	End Property

	Public Property CPF_CNPJ() As String
		Get
			Return m_CPF_CNPJ
		End Get
		Set
			m_CPF_CNPJ = value
		End Set
	End Property

	Public Property InscricaoEstadual() As String
		Get
			Return m_InscricaoEstadual
		End Get
		Set
			m_InscricaoEstadual = value
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

	Public Property RazaoSocial() As String
		Get
			Return m_RazaoSocial
		End Get
		Set
			m_RazaoSocial = value
		End Set
	End Property

	Public Property Endereco() As String
		Get
			Return m_Endereco
		End Get
		Set
			m_Endereco = value
		End Set
	End Property

	Public Property Complemento() As String
		Get
			Return m_Complemento
		End Get
		Set
			m_Complemento = value
		End Set
	End Property

	Public Property Bairro() As String
		Get
			Return m_Bairro
		End Get
		Set
			m_Bairro = value
		End Set
	End Property

	Public Property Cep() As String
		Get
			Return m_Cep
		End Get
		Set
			m_Cep = value
		End Set
	End Property

	Public Property Cidade() As String
		Get
			Return m_Cidade
		End Get
		Set
			m_Cidade = value
		End Set
	End Property

	Public Property Estado() As String
		Get
			Return m_Estado
		End Get
		Set
			m_Estado = value
		End Set
	End Property

	Public Property Fone1() As String
		Get
			Return m_Fone1
		End Get
		Set
			m_Fone1 = value
		End Set
	End Property

	Public Property Fone2() As String
		Get
			Return m_Fone2
		End Get
		Set
			m_Fone2 = value
		End Set
	End Property

	Public Property Fone3() As String
		Get
			Return m_Fone3
		End Get
		Set
			m_Fone3 = value
		End Set
	End Property

	Public Property Fone4() As String
		Get
			Return m_Fone4
		End Get
		Set
			m_Fone4 = value
		End Set
	End Property

	Public Property Email1() As String
		Get
			Return m_Email1
		End Get
		Set
			m_Email1 = value
		End Set
	End Property

	Public Property Email2() As String
		Get
			Return m_Email2
		End Get
		Set
			m_Email2 = value
		End Set
	End Property

	Public Property Site() As String
		Get
			Return m_Site
		End Get
		Set
			m_Site = value
		End Set
	End Property
	
	
		
End Class
