<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CambioUbicacion
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
        Me.partNumber = New System.Windows.Forms.TextBox
        Me.nroDisenio = New System.Windows.Forms.TextBox
        Me.nroEntrada = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextUbicacion = New System.Windows.Forms.TextBox
        Me.aceptar = New System.Windows.Forms.Button
        Me.Retroceder = New System.Windows.Forms.Button
        Me.Reimprimir = New System.Windows.Forms.CheckBox
        Me.REIMPINFO = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'partNumber
        '
        Me.partNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.partNumber.Location = New System.Drawing.Point(18, 35)
        Me.partNumber.Name = "partNumber"
        Me.partNumber.Size = New System.Drawing.Size(211, 21)
        Me.partNumber.TabIndex = 0
        '
        'nroDisenio
        '
        Me.nroDisenio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nroDisenio.Location = New System.Drawing.Point(18, 127)
        Me.nroDisenio.Name = "nroDisenio"
        Me.nroDisenio.Size = New System.Drawing.Size(210, 21)
        Me.nroDisenio.TabIndex = 1
        '
        'nroEntrada
        '
        Me.nroEntrada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nroEntrada.Location = New System.Drawing.Point(17, 79)
        Me.nroEntrada.Name = "nroEntrada"
        Me.nroEntrada.Size = New System.Drawing.Size(211, 21)
        Me.nroEntrada.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(18, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 23)
        Me.Label1.Text = "Part Number"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(18, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 19)
        Me.Label2.Text = "Nro De Diseño"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(17, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.Text = "Nro de Entrada"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(18, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.Text = "Ubicación"
        '
        'TextUbicacion
        '
        Me.TextUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TextUbicacion.Location = New System.Drawing.Point(18, 173)
        Me.TextUbicacion.Name = "TextUbicacion"
        Me.TextUbicacion.Size = New System.Drawing.Size(210, 21)
        Me.TextUbicacion.TabIndex = 11
        '
        'aceptar
        '
        Me.aceptar.BackColor = System.Drawing.Color.GreenYellow
        Me.aceptar.Location = New System.Drawing.Point(18, 200)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(211, 37)
        Me.aceptar.TabIndex = 12
        Me.aceptar.Text = "Aceptar"
        '
        'Retroceder
        '
        Me.Retroceder.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Retroceder.Location = New System.Drawing.Point(18, 246)
        Me.Retroceder.Name = "Retroceder"
        Me.Retroceder.Size = New System.Drawing.Size(86, 33)
        Me.Retroceder.TabIndex = 13
        Me.Retroceder.Text = "Retroceder"
        '
        'Reimprimir
        '
        Me.Reimprimir.Location = New System.Drawing.Point(73, 15)
        Me.Reimprimir.Name = "Reimprimir"
        Me.Reimprimir.Size = New System.Drawing.Size(25, 20)
        Me.Reimprimir.TabIndex = 18
        '
        'REIMPINFO
        '
        Me.REIMPINFO.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.REIMPINFO.Location = New System.Drawing.Point(3, 16)
        Me.REIMPINFO.Name = "REIMPINFO"
        Me.REIMPINFO.Size = New System.Drawing.Size(28, 19)
        Me.REIMPINFO.Text = "NO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.REIMPINFO)
        Me.Panel1.Controls.Add(Me.Reimprimir)
        Me.Panel1.Location = New System.Drawing.Point(128, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(101, 34)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.Text = "REIMPRIMIR"
        '
        'CambioUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Retroceder)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.TextUbicacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nroEntrada)
        Me.Controls.Add(Me.nroDisenio)
        Me.Controls.Add(Me.partNumber)
        Me.KeyPreview = True
        Me.Name = "CambioUbicacion"
        Me.Text = "Cambio De Ubicación"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents partNumber As System.Windows.Forms.TextBox
    Friend WithEvents nroDisenio As System.Windows.Forms.TextBox
    Friend WithEvents nroEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents Retroceder As System.Windows.Forms.Button
    Friend WithEvents Reimprimir As System.Windows.Forms.CheckBox
    Friend WithEvents REIMPINFO As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
