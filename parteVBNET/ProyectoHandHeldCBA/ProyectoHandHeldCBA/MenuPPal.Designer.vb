<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MenuPPal
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
        Me.cambioUbicacion = New System.Windows.Forms.Button
        Me.ButtonBajaraPc = New System.Windows.Forms.Button
        Me.retroceder = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cambioUbicacion
        '
        Me.cambioUbicacion.BackColor = System.Drawing.Color.Yellow
        Me.cambioUbicacion.Location = New System.Drawing.Point(43, 57)
        Me.cambioUbicacion.Name = "cambioUbicacion"
        Me.cambioUbicacion.Size = New System.Drawing.Size(150, 29)
        Me.cambioUbicacion.TabIndex = 0
        Me.cambioUbicacion.Text = "Cambio de Ubicación"
        '
        'ButtonBajaraPc
        '
        Me.ButtonBajaraPc.BackColor = System.Drawing.Color.Yellow
        Me.ButtonBajaraPc.Location = New System.Drawing.Point(43, 162)
        Me.ButtonBajaraPc.Name = "ButtonBajaraPc"
        Me.ButtonBajaraPc.Size = New System.Drawing.Size(150, 26)
        Me.ButtonBajaraPc.TabIndex = 1
        Me.ButtonBajaraPc.Text = "Bajar a PC"
        '
        'retroceder
        '
        Me.retroceder.Location = New System.Drawing.Point(42, 255)
        Me.retroceder.Name = "retroceder"
        Me.retroceder.Size = New System.Drawing.Size(150, 28)
        Me.retroceder.TabIndex = 2
        Me.retroceder.Text = "Retroceder"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(43, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Toma de Inventario"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(33, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.Text = "Seleccione una opción"
        '
        'MenuPPal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.retroceder)
        Me.Controls.Add(Me.ButtonBajaraPc)
        Me.Controls.Add(Me.cambioUbicacion)
        Me.Name = "MenuPPal"
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cambioUbicacion As System.Windows.Forms.Button
    Friend WithEvents ButtonBajaraPc As System.Windows.Forms.Button
    Friend WithEvents retroceder As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
