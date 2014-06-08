<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InicializarUsuarios
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NombrePC = New System.Windows.Forms.TextBox
        Me.NombreCarpeta = New System.Windows.Forms.TextBox
        Me.ruta = New System.Windows.Forms.TextBox
        Me.CopiarDatos = New System.Windows.Forms.Button
        Me.Volver = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'NombrePC
        '
        Me.NombrePC.Location = New System.Drawing.Point(31, 38)
        Me.NombrePC.Name = "NombrePC"
        Me.NombrePC.Size = New System.Drawing.Size(180, 21)
        Me.NombrePC.TabIndex = 0
        '
        'NombreCarpeta
        '
        Me.NombreCarpeta.Location = New System.Drawing.Point(31, 93)
        Me.NombreCarpeta.Name = "NombreCarpeta"
        Me.NombreCarpeta.Size = New System.Drawing.Size(180, 21)
        Me.NombreCarpeta.TabIndex = 1
        Me.NombreCarpeta.Text = "USRS"
        '
        'ruta
        '
        Me.ruta.Location = New System.Drawing.Point(31, 152)
        Me.ruta.Name = "ruta"
        Me.ruta.ReadOnly = True
        Me.ruta.Size = New System.Drawing.Size(180, 21)
        Me.ruta.TabIndex = 2
        '
        'CopiarDatos
        '
        Me.CopiarDatos.Location = New System.Drawing.Point(122, 215)
        Me.CopiarDatos.Name = "CopiarDatos"
        Me.CopiarDatos.Size = New System.Drawing.Size(89, 38)
        Me.CopiarDatos.TabIndex = 3
        Me.CopiarDatos.Text = "Copiar Datos"
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(27, 215)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(89, 38)
        Me.Volver.TabIndex = 4
        Me.Volver.Text = "Volver"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(32, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 19)
        Me.Label1.Text = "NOMBRE DE LA PC"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(31, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 14)
        Me.Label2.Text = "CARPETA DE USUARIOS"
        '
        'InicializarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Volver)
        Me.Controls.Add(Me.CopiarDatos)
        Me.Controls.Add(Me.ruta)
        Me.Controls.Add(Me.NombreCarpeta)
        Me.Controls.Add(Me.NombrePC)
        Me.Name = "InicializarUsuarios"
        Me.Text = "Inicializar Usuarios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NombrePC As System.Windows.Forms.TextBox
    Friend WithEvents NombreCarpeta As System.Windows.Forms.TextBox
    Friend WithEvents ruta As System.Windows.Forms.TextBox
    Friend WithEvents CopiarDatos As System.Windows.Forms.Button
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
