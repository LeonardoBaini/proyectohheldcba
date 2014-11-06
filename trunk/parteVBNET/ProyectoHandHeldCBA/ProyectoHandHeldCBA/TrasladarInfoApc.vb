Public Class TrasladarInfoApc

    ' copia y sobreescribe
    Private Sub FileCopier()
        Dim Source As String = "C:\Source.txt"
        Dim Destination As String = "C:\Copy.txt"
        System.IO.File.Copy(Source, Destination, True)
    End Sub

    Private Sub moverArchivo(ByVal nombreArchivo As String)
        Try

            Dim rutaDestino As String = "\\" + NombreDeLaPC.Text + "\" + CarpetaDestino.Text + "\" + nombreArchivo
            Dim rutaAcarpetaDestino As String = "\\" + NombreDeLaPC.Text + "\" + CarpetaDestino.Text

            If System.IO.File.Exists(rutaDestino) = True Then

                MessageBox.Show("Imposible transferir, Hay datos pendientes de proceso en la PC, carpeta ''TEMPBAJADAS'' ya contiene el archivo " + nombreArchivo)

            Else
                Try
                    System.IO.File.Move(".\LecturasPDA\" + nombreArchivo, rutaDestino)
                    MessageBox.Show("Archivo transferido con éxito!")
                Catch ex As Exception


                    If ex.Message().ToString.Equals("IOException") Then
                        MessageBox.Show("No se puede encontrar la ruta de destino, compruebe la conexión.", "Error!")
                    Else
                        MessageBox.Show(ex.Message() + " Ó NO HAY ARCHIVOS PARA TRASLADAR A PC, GENERE UNO.", "Error!")
                    End If



                End Try


            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message())

        End Try
    End Sub

    Private Function controlarCamposVacios() As Boolean
        If (NombreDeLaPC.TextLength > 0) And (CarpetaDestino.TextLength > 0) Then
            Return True
        Else
            Return False

        End If
    End Function


    Private Sub Trasladar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Trasladar.Click
        If controlarCamposVacios() = True Then
            moverArchivo("CULECTURAS.txt")
        Else
            MessageBox.Show("Indique el destino.")
        End If

       




    End Sub


    Private Sub CarpetaDestino_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarpetaDestino.LostFocus, RutaCompletaInfo.TextChanged
        RutaCompletaInfo.Text = "\\" + NombreDeLaPC.Text + "\" + CarpetaDestino.Text
    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Hide()

    End Sub

   

    Private Sub CarpetaDestino_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CarpetaDestino.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Trasladar.Focus()

        End If
    End Sub


    Private Sub ButtonInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInventario.Click
        If controlarCamposVacios() = True Then
            moverArchivo("CUTOMINVEN.txt")
        Else
            MessageBox.Show("Indique el destino.")
        End If

    End Sub

   
    Private Sub NombreDeLaPC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NombreDeLaPC.TextChanged
        RutaCompletaInfo.Text = "\\" + NombreDeLaPC.Text + "\" + CarpetaDestino.Text
    End Sub
End Class
