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
        Me.culecturas = New System.Windows.Forms.Label
        Me.ButtonInventario = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'NombreDeLaPC
        '
        Me.NombreDeLaPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NombreDeLaPC.Location = New System.Drawing.Point(12, 58)
        Me.NombreDeLaPC.Name = "NombreDeLaPC"
        Me.NombreDeLaPC.Size = New System.Drawing.Size(224, 21)
        Me.NombreDeLaPC.TabIndex = 0
        '
        'nombrePC
        '
        Me.nombrePC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.nombrePC.Location = New System.Drawing.Point(12, 35)
        Me.nombrePC.Name = "nombrePC"
        Me.nombrePC.Size = New System.Drawing.Size(200, 20)
        Me.nombrePC.Text = "Nombre de la PC o IP"
        '
        'Carpeta
        '
        Me.Carpeta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Carpeta.Location = New System.Drawing.Point(12, 92)
        Me.Carpeta.Name = "Carpeta"
        Me.Carpeta.Size = New System.Drawing.Size(200, 20)
        Me.Carpeta.Text = "Nombre de la carpeta destino"
        '
        'CarpetaDestino
        '
        Me.CarpetaDestino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CarpetaDestino.Location = New System.Drawing.Point(12, 115)
        Me.CarpetaDestino.Name = "CarpetaDestino"
        Me.CarpetaDestino.Size = New System.Drawing.Size(224, 21)
        Me.CarpetaDestino.TabIndex = 3
        Me.CarpetaDestino.Text = "TEMPBAJADAS"
        '
        'Trasladar
        '
        Me.Trasladar.BackColor = System.Drawing.Color.GreenYellow
        Me.Trasladar.Location = New System.Drawing.Point(11, 219)
        Me.Trasladar.Name = "Trasladar"
        Me.Trasladar.Size = New System.Drawing.Size(97, 25)
        Me.Trasladar.TabIndex = 4
        Me.Trasladar.Text = "Trasladar a PC"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.Text = "Info ruta cargada"
        '
        'RutaCompletaInfo
        '
        Me.RutaCompletaInfo.BackColor = System.Drawing.Color.Yellow
        Me.RutaCompletaInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RutaCompletaInfo.Location = New System.Drawing.Point(11, 171)
        Me.RutaCompletaInfo.Name = "RutaCompletaInfo"
        Me.RutaCompletaInfo.ReadOnly = True
        Me.RutaCompletaInfo.Size = New System.Drawing.Size(226, 21)
        Me.RutaCompletaInfo.TabIndex = 6
        '
        'Salir
        '
        Me.Salir.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Salir.Location = New System.Drawing.Point(12, 258)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(224, 24)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "RETROCEDER"
        '
        'culecturas
        '
        Me.culecturas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.culecturas.Location = New System.Drawing.Point(12, 201)
        Me.culecturas.Name = "culecturas"
        Me.culecturas.Size = New System.Drawing.Size(95, 18)
        Me.culecturas.Text = "CULECTURAS"
        '
        'ButtonInventario
        '
        Me.ButtonInventario.BackColor = System.Drawing.Color.GreenYellow
        Me.ButtonInventario.Location = New System.Drawing.Point(130, 219)
        Me.ButtonInventario.Name = "ButtonInventario"
        Me.ButtonInventario.Size = New System.Drawing.Size(106, 25)
        Me.ButtonInventario.TabIndex = 15
        Me.ButtonInventario.Text = "Trasladar a PC"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(130, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.Text = "CUTOMINVEN"
        '
        'TrasladarInfoApc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonInventario)
        Me.Controls.Add(Me.culecturas)
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
    Friend WithEvents culecturas As System.Windows.Forms.Label
    Friend WithEvents ButtonInventario As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
