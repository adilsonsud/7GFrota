'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 7/3/2014
' Hora: 22:56
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Public Class EntCategorias
	Private m_idCategoria As Integer
	Private m_Nome As String
	
	Public Property IdCategoria() As Integer
		Get
			Return m_idCategoria
		End Get
		Set
			m_idCategoria = value
		End Set
	End Property

	Public Property Nome() As String
		Get
			Return m_Nome
		End Get
		Set
			m_Nome = value
		End Set
	End Property
	
End Class
