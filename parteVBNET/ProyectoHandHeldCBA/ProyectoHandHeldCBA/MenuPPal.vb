Public Class MenuPPal

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub cambioUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cambioUbicacion.Click

        Dim cambioUbic As CambioUbicacion
        cambioUbic = New CambioUbicacion()
        cambioUbic.Show()
    End Sub

    



   
    Private Sub retroceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retroceder.Click

        If System.IO.File.Exists(".\LecturasPDA\CULECTURAS.txt") = True Then

            Login.datosPendientes.Text = "Hay datos pendientes de proceso."

        Else
            Login.datosPendientes.Text = "No hay datos pendientes."

        End If
        Me.Hide()


    End Sub

   
    Private Sub ButtonBajaraPc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBajaraPc.Click
        TrasladarInfoApc.Show()

    End Sub
End Class