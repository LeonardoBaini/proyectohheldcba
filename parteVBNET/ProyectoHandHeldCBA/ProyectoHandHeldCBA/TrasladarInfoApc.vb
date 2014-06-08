Public Class TrasladarInfoApc

    ' copia y sobreescribe
    Private Sub FileCopier()
        Dim Source As String = "C:\Source.txt"
        Dim Destination As String = "C:\Copy.txt"
        System.IO.File.Copy(Source, Destination, True)
    End Sub


   


    Private Sub Trasladar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Trasladar.Click
        Try

            Dim rutaDestino As String = "\\" + NombreDeLaPC.Text + "\" + CarpetaDestino.Text + "\CULECTURAS.TXT"
          
            If System.IO.File.Exists(rutaDestino) = True Then

                MessageBox.Show("Imposible transferir, Hay datos pendientes de proceso en la PC, carpeta ''TEMPBAJADAS'' ya contiene archivo .")

            Else
                Try
                    System.IO.File.Move(".\LecturasPDA\CULECTURAS.txt", rutaDestino)
                    MessageBox.Show("Archivo transferido con éxito!")
                Catch ex As Exception
                    Me.Hide()
                    If ex.Message().ToString.Equals("IOException") Then
                        MessageBox.Show("ERROR! no se puede encontrar la ruta de destino, compruebe la conexión.")
                    Else
                        MessageBox.Show("ERROR! " + ex.Message() + " Ó NO HAY ARCHIVOS PARA TRASLADAR A PC, GENERE UNO ESCANEANDO UBICACIÓN.")
                    End If


                End Try


            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message())

        End Try

    End Sub

   
    Private Sub CarpetaDestino_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarpetaDestino.LostFocus
        RutaCompletaInfo.Text = "\\" + NombreDeLaPC.Text + "\" + CarpetaDestino.Text
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Hide()

    End Sub

    Private Sub NombreDeLaPC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreDeLaPC.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            CarpetaDestino.Focus()
        End If
    End Sub

    Private Sub CarpetaDestino_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CarpetaDestino.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Trasladar.Focus()

        End If
    End Sub

    
End Class
