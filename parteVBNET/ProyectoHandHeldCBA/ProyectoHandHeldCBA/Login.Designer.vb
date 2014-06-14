<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.textUsuario = New System.Windows.Forms.TextBox
        Me.textContrasenia = New System.Windows.Forms.TextBox
        Me.textNroHandHeld = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ButtonAceptar = New System.Windows.Forms.Button
        Me.salir = New System.Windows.Forms.Button
        Me.InicializarUsuarios = New System.Windows.Forms.Button
        Me.datosPendientes = New System.Windows.Forms.Label
        Me.userLogueado = New System.Windows.Forms.Label
        Me.LabelhheldNro = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'textUsuario
        '
        Me.textUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.textUsuario.Location = New System.Drawing.Point(39, 44)
        Me.textUsuario.Name = "textUsuario"
        Me.textUsuario.Size = New System.Drawing.Size(171, 21)
        Me.textUsuario.TabIndex = 0
        '
        'textContrasenia
        '
        Me.textContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.textContrasenia.Location = New System.Drawing.Point(39, 97)
        Me.textContrasenia.Name = "textContrasenia"
        Me.textContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textContrasenia.Size = New System.Drawing.Size(171, 21)
        Me.textContrasenia.TabIndex = 1
        '
        'textNroHandHeld
        '
        Me.textNroHandHeld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.textNroHandHeld.Location = New System.Drawing.Point(39, 149)
        Me.textNroHandHeld.Name = "textNroHandHeld"
        Me.textNroHandHeld.Size = New System.Drawing.Size(171, 21)
        Me.textNroHandHeld.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(39, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 18)
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(39, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(39, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 19)
        Me.Label3.Text = "Nro de Hand Held"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(131, 207)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(70, 31)
        Me.ButtonAceptar.TabIndex = 6
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(42, 207)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(69, 31)
        Me.salir.TabIndex = 10
        Me.salir.Text = "Salir"
        '
        'InicializarUsuarios
        '
        Me.InicializarUsuarios.Location = New System.Drawing.Point(42, 244)
        Me.InicializarUsuarios.Name = "InicializarUsuarios"
        Me.InicializarUsuarios.Size = New System.Drawing.Size(159, 33)
        Me.InicializarUsuarios.TabIndex = 14
        Me.InicializarUsuarios.Text = "Inicializar usuarios"
        '
        'datosPendientes
        '
        Me.datosPendientes.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.datosPendientes.Location = New System.Drawing.Point(10, 4)
        Me.datosPendientes.Name = "datosPendientes"
        Me.datosPendientes.Size = New System.Drawing.Size(219, 19)
        '
        'userLogueado
        '
        Me.userLogueado.Location = New System.Drawing.Point(39, 177)
        Me.userLogueado.Name = "userLogueado"
        Me.userLogueado.Size = New System.Drawing.Size(92, 19)
        '
        'LabelhheldNro
        '
        Me.LabelhheldNro.Location = New System.Drawing.Point(146, 177)
        Me.LabelhheldNro.Name = "LabelhheldNro"
        Me.LabelhheldNro.Size = New System.Drawing.Size(63, 18)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(215, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 18)
        Me.Label4.Text = "v2"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelhheldNro)
        Me.Controls.Add(Me.userLogueado)
        Me.Controls.Add(Me.datosPendientes)
        Me.Controls.Add(Me.InicializarUsuarios)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textNroHandHeld)
        Me.Controls.Add(Me.textContrasenia)
        Me.Controls.Add(Me.textUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "TFSA                          "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents textUsuario As System.Windows.Forms.TextBox
    Friend WithEvents textContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents textNroHandHeld As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonAceptar As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents InicializarUsuarios As System.Windows.Forms.Button
    Friend WithEvents datosPendientes As System.Windows.Forms.Label
    Friend WithEvents userLogueado As System.Windows.Forms.Label
    Friend WithEvents LabelhheldNro As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
