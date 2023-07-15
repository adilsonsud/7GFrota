'
' Criado por SharpDevelop.
' Usuário: Administrador
' Data: 31/3/2014
' Hora: 13:21
' 
' Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
'
Partial Class FormVendas
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVendas))
		Me.bt_venda = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'bt_venda
		'
		Me.bt_venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.bt_venda.Image = CType(resources.GetObject("bt_venda.Image"),System.Drawing.Image)
		Me.bt_venda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.bt_venda.Location = New System.Drawing.Point(872, 12)
		Me.bt_venda.Name = "bt_venda"
		Me.bt_venda.Size = New System.Drawing.Size(74, 27)
		Me.bt_venda.TabIndex = 0
		Me.bt_venda.Text = "&Venda"
		Me.bt_venda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.bt_venda.UseVisualStyleBackColor = true
		'
		'FormVendas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(958, 462)
		Me.Controls.Add(Me.bt_venda)
		Me.Name = "FormVendas"
		Me.Text = "VENDAS DE PRODUTOS E SERVIÇOS"
		Me.ResumeLayout(false)
	End Sub
	Private bt_venda As System.Windows.Forms.Button
End Class
