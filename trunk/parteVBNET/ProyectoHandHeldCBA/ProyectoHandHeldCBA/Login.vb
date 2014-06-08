Imports System.IO

Public Class Login
  


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim exists As Boolean


        exists = System.IO.Directory.Exists(".\usrs")
        If exists = False Then
            Try

                System.IO.Directory.CreateDirectory(".\usrs")
                MessageBox.Show("Directorio de usuarios creado")
            Catch ex As Exception

            End Try

        End If

        If System.IO.File.Exists(".\LecturasPDA\CULECTURAS.txt") = True Then

            datosPendientes.Text = "HAY DATOS PENDIENTES!!!."

        Else
            datosPendientes.Text = "No hay datos pendientes..."

        End If

    End Sub

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        Dim exists As Boolean
        exists = System.IO.File.Exists(".\usrs\USRS.TXT")

        If exists = True Then



            If textUsuario.TextLength = 0 Or textContrasenia.TextLength = 0 Or textNroHandHeld.TextLength = 0 Then

                MessageBox.Show("No se permiten campos vacíos, por favor complételos.")

            Else
                If textNroHandHeld.TextLength > 0 And textNroHandHeld.TextLength < 3 Then




                    If compararUsuarioValido(textUsuario.Text, textContrasenia.Text) = True Then
                        MessageBox.Show("Bienvenido " + textUsuario.Text)
                        userLogueado.Text = textUsuario.Text
                        LabelhheldNro.Text = textNroHandHeld.Text



                        MenuPPal.Show()
                    Else
                        MessageBox.Show("usuario o clave incorrecta, pida el alta de usuario a su encargado.")


                    End If

                ElseIf textNroHandHeld.TextLength > 2 Then
                    MessageBox.Show("Solo se permite nro hanheld hasta el 99 inclusive ")
                    textNroHandHeld.Text = ""
                    textNroHandHeld.BackColor = Color.Red




                End If



            End If

        Else
            MessageBox.Show("No hay usuarios cargados en el sistema ***INICIALICE USUARIOS***.")


        End If

    End Sub










    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click

        Me.Close()


    End Sub


    Private Sub InicializarUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InicializarUsuarios.Click
        Dim InicializarUsuario As InicializarUsuarios
        InicializarUsuario = New InicializarUsuarios()
        InicializarUsuario.Show()




    End Sub

   

   
   

    Private Function compararUsuarioValido(ByVal usuario As String, ByVal password As String) As Boolean
        Dim concatenados = usuario + "," + password

        Dim valor As Boolean
        valor = False


        Dim fileReader As System.IO.StreamReader
        Dim lineRead As String
        Dim usuarioNombre As String
        Dim pass As String
        Dim largo As Integer
        Dim indice As Integer




        fileReader = File.OpenText(".\usrs\USRS.txt")



        While fileReader.Peek <> -1

            lineRead = fileReader.ReadLine()
            largo = lineRead.Count
            largo = largo - (lineRead.IndexOf(",") + 1)



            indice = lineRead.IndexOf(",")
            usuarioNombre = lineRead.Substring(0, lineRead.IndexOf(","))
            pass = lineRead.Substring(lineRead.IndexOf(",") + 1, largo)
            pass = DesencriptarPassword(pass)


            If (usuarioNombre + "," + pass).Equals(concatenados) Then
                valor = True
                Return valor

            End If



        End While

        fileReader.Close()


        Return valor


    End Function

    Private Sub textUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textUsuario.TextChanged

    End Sub

    Private Sub textNroHandHeld_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textNroHandHeld.TextChanged
        textNroHandHeld.BackColor = Color.White

    End Sub

    Private Sub textUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textUsuario.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            textContrasenia.Focus()


        End If
    End Sub

    Private Sub textContrasenia_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textContrasenia.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            textNroHandHeld.Focus()


        End If
    End Sub

    Private Sub textNroHandHeld_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textNroHandHeld.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then

            ButtonAceptar.Focus()


        End If
    End Sub







    ' función que decodifica el dato
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Function DesencriptarPassword(ByVal DataValue As String) As String
        Dim res As String
        res = ""

        Dim str1 As String = DataValue  ' "Mjqqt%\twi&" -> Hello Word!
        For ctr As Integer = 0 To str1.Length - 1

            Dim a As Char
            a = str1(ctr)
            Dim n As Integer
            n = Microsoft.VisualBasic.AscW(a) - 5

            res = res + Chr(n)



        Next

        Return res

    End Function

    


   















End Class
