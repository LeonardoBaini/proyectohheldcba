Public Class InicializarUsuarios

    Private Sub CopiarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarDatos.Click

        Try

            Dim rutaDestino As String = "\\" + NombrePC.Text + "\" + NombreCarpeta.Text + "\USRS.TXT"

            If System.IO.File.Exists(rutaDestino) = True Then

                ' MessageBox.Show("Imposible transferir, Hay datos pendientes de proceso en la PC, carpeta ''TEMPBAJADAS'' ya contiene archivo .")


                Try
                    System.IO.File.Delete(".\USRS\USRS.txt")
                    System.IO.File.Copy(rutaDestino, ".\USRS\USRS.txt")


                    MessageBox.Show("Archivo copiado con éxito!")
                Catch ex As Exception
                    Me.Hide()
                    If ex.Message().ToString.Equals("IOException") Then
                        MessageBox.Show("ERROR! no se puede encontrar la ruta de destino, compruebe la conexión .")
                    Else
                        MessageBox.Show("ERROR! " + ex.Message())
                    End If


                End Try

            Else
                MessageBox.Show("LA CARPETA C:\TFHHELD\USRS NO EXISTE O NO ESTA COMPARTIDA")


            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message())

        End Try

    End Sub

    Private Sub Volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Volver.Click
        Me.Close()

    End Sub

    

    Private Sub NombreCarpeta_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreCarpeta.LostFocus
        ruta.Text = "\\" + NombrePC.Text + "\" + NombreCarpeta.Text
        CopiarDatos.Focus()

      
    End Sub

    Private Sub NombrePC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombrePC.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            NombreCarpeta.Focus()
        End If
    End Sub

    Private Sub NombreCarpeta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreCarpeta.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            CopiarDatos.Focus()
        End If
    End Sub
End Class



