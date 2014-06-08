<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TrasladarInfoApc
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
        Me.NombreDeLaPC = New System.Windows.Forms.TextBox
        Me.nombrePC = New System.Windows.Forms.Label
        Me.Carpeta = New System.Windows.Forms.Label
        Me.CarpetaDestino = New System.Windows.Forms.TextBox
        Me.Trasladar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.RutaCompletaInfo = New System.Windows.Forms.TextBox
        Me.Salir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'NombreDeLaPC
        '
        Me.NombreDeLaPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NombreDeLaPC.Location = New System.Drawing.Point(21, 40)
        Me.NombreDeLaPC.Name = "NombreDeLaPC"
        Me.NombreDeLaPC.Size = New System.Drawing.Size(200, 21)
        Me.NombreDeLaPC.TabIndex = 0
        '
        'nombrePC
        '
        Me.nombrePC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.nombrePC.Location = New System.Drawing.Point(21, 17)
        Me.nombrePC.Name = "nombrePC"
        Me.nombrePC.Size = New System.Drawing.Size(111, 20)
        Me.nombrePC.Text = "Nombre de la PC"
        '
        'Carpeta
        '
        Me.Carpeta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Carpeta.Location = New System.Drawing.Point(21, 76)
        Me.Carpeta.Name = "Carpeta"
        Me.Carpeta.Size = New System.Drawing.Size(200, 20)
        Me.Carpeta.Text = "Nombre de la carpeta destino"
        '
        'CarpetaDestino
        '
        Me.CarpetaDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CarpetaDestino.Location = New System.Drawing.Point(21, 99)
        Me.CarpetaDestino.Name = "CarpetaDestino"
        Me.CarpetaDestino.Size = New System.Drawing.Size(200, 21)
        Me.CarpetaDestino.TabIndex = 3
        Me.CarpetaDestino.Text = "TEMPBAJADAS"
        '
        'Trasladar
        '
        Me.Trasladar.Location = New System.Drawing.Point(140, 220)
        Me.Trasladar.Name = "Trasladar"
        Me.Trasladar.Size = New System.Drawing.Size(97, 33)
        Me.Trasladar.TabIndex = 4
        Me.Trasladar.Text = "Trasladar a PC"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(23, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.Text = "Info ruta cargada"
        '
        'RutaCompletaInfo
        '
        Me.RutaCompletaInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RutaCompletaInfo.Enabled = False
        Me.RutaCompletaInfo.Location = New System.Drawing.Point(11, 171)
        Me.RutaCompletaInfo.Name = "RutaCompletaInfo"
        Me.RutaCompletaInfo.Size = New System.Drawing.Size(226, 21)
        Me.RutaCompletaInfo.TabIndex = 6
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(14, 220)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(89, 33)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "Salir"
        '
        'TrasladarInfoApc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.RutaCompletaInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Trasladar)
        Me.Controls.Add(Me.CarpetaDestino)
        Me.Controls.Add(Me.Carpeta)
        Me.Controls.Add(Me.nombrePC)
        Me.Controls.Add(Me.NombreDeLaPC)
        Me.Name = "TrasladarInfoApc"
        Me.Text = "TrasladarInfoApc"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NombreDeLaPC As System.Windows.Forms.TextBox
    Friend WithEvents nombrePC As System.Windows.Forms.Label
    Friend WithEvents Carpeta As System.Windows.Forms.Label
    Friend WithEvents CarpetaDestino As System.Windows.Forms.TextBox
    Friend WithEvents Trasladar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RutaCompletaInfo As System.Windows.Forms.TextBox
    Friend WithEvents Salir As System.Windows.Forms.Button
End Class
