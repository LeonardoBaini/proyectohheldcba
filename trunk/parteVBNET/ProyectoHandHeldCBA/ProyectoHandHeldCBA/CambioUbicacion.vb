Public Class CambioUbicacion

    

    

    Private Sub Retroceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Retroceder.Click

        Me.Hide()

    End Sub

    Private Sub escribirArchivoConR()
        Try
            Dim exists As Boolean
            exists = System.IO.Directory.Exists(".\LecturasPDA")
            If exists = False Then
                Try
                    MessageBox.Show("Directorio .\LecturasPDA no existe pulse ok para crear.")
                    System.IO.Directory.CreateDirectory(".\LecturasPDA")
                    MessageBox.Show("Directorio .\LecturasPDA creado")
                Catch ex As Exception

                    MessageBox.Show(ex.Message + " Error no se puede crear el directorio!, reinicie la aplicación")
                    Me.Close()

                End Try
            End If



            'ejemplo 
            'ESPACIOS  5       2             2                     3       8
            'UBICACIÓN   ENTRADA NRO DISEÑO    PART NUMBER           NRO HHELD USUARIO
            '2H51701     109980  005040626330  0504062633000092110   15        LBAINI
            '2C21303     108683  005040626331  0504062633000092110   15        LBAINI
            '2B21701     108575  005040626332  0504062633000092110   15        LBAINI
            '2B52802     110022  005040626333  0504062633000092110   15        LBAINI
            ' anda Const fic As String = "\\Laptop\PASE\CULECTURAS.txt"
            Const fic As String = ".\LecturasPDA\CULECTURAS.txt"

            Dim espacio5 As String = "  R  "
            Dim espacio2 As String = "  "
            Dim espacio3 As String = "   "
            Dim espacio8 As String = "        "
            Dim handHeld As String = Login.LabelhheldNro.Text
            Dim usuario As String = Login.userLogueado.Text
            Dim nroDis As String = nroDisenio.Text()
            Dim partNmr As String = partNumber.Text()
            Dim ubic As String = TextUbicacion.Text()
            Dim numEntrada = nroEntrada.Text()

            Dim sw As New System.IO.StreamWriter(fic, True)
            sw.WriteLine(ubic + espacio5 + numEntrada + espacio2 + nroDis + espacio2 + partNmr + espacio3 + handHeld + espacio8 + usuario)
            sw.Close()
            MessageBox.Show("Guardado ok con R!")


        Catch ex As Exception

            MessageBox.Show(ex.Message + " Error el dato no se guardó!, reinicie la aplicación")
            Me.Close()


        End Try


    End Sub

    Private Sub escribirArchivo()
        Try
            Dim exists As Boolean
            exists = System.IO.Directory.Exists(".\LecturasPDA")
            If exists = False Then
                Try
                    MessageBox.Show("Directorio .\LecturasPDA no existe pulse ok para crear.")
                    System.IO.Directory.CreateDirectory(".\LecturasPDA")
                    MessageBox.Show("Directorio .\LecturasPDA creado")
                Catch ex As Exception

                    MessageBox.Show(ex.Message + " Error no se puede crear el directorio!, reinicie la aplicación")
                    Me.Close()

                End Try
            End If



            'ejemplo 
            'ESPACIOS  5       2             2                     3       8
            'UBICACIÓN   ENTRADA NRO DISEÑO    PART NUMBER           NRO HHELD USUARIO
            '2H51701     109980  005040626330  0504062633000092110   15        LBAINI
            '2C21303     108683  005040626331  0504062633000092110   15        LBAINI
            '2B21701     108575  005040626332  0504062633000092110   15        LBAINI
            '2B52802     110022  005040626333  0504062633000092110   15        LBAINI
            ' anda Const fic As String = "\\Laptop\PASE\CULECTURAS.txt"
            Const fic As String = ".\LecturasPDA\CULECTURAS.txt"

            Dim espacio5 As String = "     "
            Dim espacio2 As String = "  "
            Dim espacio3 As String = "   "
            Dim espacio8 As String = "        "
            Dim handHeld As String = Login.LabelhheldNro.Text
            Dim usuario As String = Login.userLogueado.Text
            Dim nroDis As String = nroDisenio.Text()
            Dim partNmr As String = partNumber.Text()
            Dim ubic As String = TextUbicacion.Text()
            Dim numEntrada = nroEntrada.Text()

            Dim sw As New System.IO.StreamWriter(fic, True)
            sw.WriteLine(ubic + espacio5 + numEntrada + espacio2 + nroDis + espacio2 + partNmr + espacio3 + handHeld + espacio8 + usuario)
            sw.Close()
            MessageBox.Show("Guardado ok sin R!")


        Catch ex As Exception

            MessageBox.Show(ex.Message + " Error el dato no se guardó!, reinicie la aplicación")
            Me.Close()


        End Try


    End Sub

    Private Function hayCamposVacios() As Boolean
        Dim part As Integer
        Dim nroDis As Integer
        Dim entr As Integer
        Dim ubic As Integer
        part = partNumber.TextLength
        nroDis = nroDisenio.TextLength
        entr = nroEntrada.TextLength
        ubic = TextUbicacion.TextLength
        If part = 0 Or nroDis = 0 Or entr = 0 Or ubic = 0 Then
            Return True
        Else
            Return False

        End If


    End Function

    Private Function controlarIgualdadPartNumberDisenio() As Boolean
        Dim part As Boolean = controlarTamanioCampo(partNumber, 19)
        Dim dis As Boolean = controlarTamanioCampo(nroDisenio, 12)



        If part = True And dis = True Then

            Try
                Dim _partNumber As String
                Dim _disenio As String


                _partNumber = partNumber.Text().Substring(0, 11)
                _disenio = nroDisenio.Text().Substring(1, 11) ' TextBox2.Text().Substring(1, 11)

                If _partNumber.Equals(_disenio) Then
                    partNumber.BackColor = Color.Green
                    nroDisenio.BackColor = Color.Green


                    Return True
                Else


                    Return False


                End If
            Catch e As Exception

                MessageBox.Show(e.Message + " Error el dato no se guardó!, reinicie la aplicación")
                Me.Close()
            End Try

        Else
            MessageBox.Show("Complete PartNumber y Nro de diseño para continuar")
        End If

    End Function



    Private Sub guardar()

        If hayCamposVacios() = False Then



            If controlarIgualdadPartNumberDisenio() = True Then

                If Reimprimir.Checked = True Then
                    If (verCoherencias() = True) Then
                        escribirArchivoConR()
                        limpiarCampos()
                    Else

                    End If


                ElseIf Reimprimir.Checked = False Then

                    If (verCoherencias() = True) Then
                        escribirArchivo()
                        limpiarCampos()
                    Else

                    End If


                    End If



            Else

                MessageBox.Show("Nro Diseño y P Number no coinciden, avise al supervisor!!!")

                partNumber.BackColor = Color.OrangeRed

                nroDisenio.BackColor = Color.OrangeRed


            End If

        Else
            MessageBox.Show("Hay campos vacíos no se puede guardar, complételos")

        End If



    End Sub

    Private Sub campoEnRojo(ByVal CampoText As TextBox)

        CampoText.BackColor = Color.Red


    End Sub



    Private Sub limpiarCampos()
        nroDisenio.Text = ""
        nroDisenio.BackColor = Color.White

        partNumber.Text = ""
        partNumber.BackColor = Color.White
        TextUbicacion.Text = ""
        TextUbicacion.BackColor = Color.White
        nroEntrada.Text = ""
        nroEntrada.BackColor = Color.White


    End Sub



    Private Function controlarTamanioCampo(ByVal CampoText As TextBox, ByVal tamanioCampoEsperado As Integer) As Boolean
        If CampoText.TextLength() > 0 Then
            If CampoText.TextLength() = tamanioCampoEsperado Then
                CampoText.BackColor = Color.Yellow

                Return True
            Else
                CampoText.BackColor = Color.Red

                'MessageBox.Show("No coincide el tamaño del campo -" + tamanioCampoEsperado.ToString + "- caract")
                CampoText.Text = ""
                ' CampoText.Focus()

                Return False

            End If



        End If

    End Function


    Private Sub partNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles partNumber.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If controlarTamanioCampo(partNumber, 19) = True Then
                nroEntrada.Focus()
            End If
        End If

    End Sub


    Private Sub partNumber_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles partNumber.LostFocus

        controlarTamanioCampo(partNumber, 19)



    End Sub
    Private Sub partNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles partNumber.TextChanged

        If partNumber.TextLength = 19 Then
            nroEntrada.Focus()

        End If
    End Sub

    Private Sub nroEntrada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nroEntrada.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If controlarTamanioCampo(nroEntrada, 6) = True Then
                nroDisenio.Focus()
            End If


        End If

    End Sub
    Private Sub nroEntrada_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nroEntrada.LostFocus
        controlarTamanioCampo(nroEntrada, 6)


    End Sub
    Private Sub nroEntrada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nroEntrada.TextChanged

        If nroEntrada.TextLength = 6 Then
            nroDisenio.Focus()

        End If

    End Sub

    Private Sub nroDisenio_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nroDisenio.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If controlarTamanioCampo(nroDisenio, 12) = True Then
                TextUbicacion.Focus()
            End If


        End If

    End Sub

    Private Sub nroDisenio_LostFocus_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nroDisenio.LostFocus

        controlarTamanioCampo(nroDisenio, 12)

    End Sub
    Private Sub nroDisenio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nroDisenio.TextChanged
        If nroDisenio.TextLength = 12 Then
            TextUbicacion.Focus()
        End If
    End Sub
    Private Sub TextUbicacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextUbicacion.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If controlarTamanioCampo(TextUbicacion, 6) Then
                aceptar.Focus()

            End If
        End If
    End Sub




    Private Sub TextUbicacion_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextUbicacion.LostFocus
        controlarTamanioCampo(TextUbicacion, 6)


    End Sub

    Private Sub TextUbicacion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextUbicacion.TextChanged
        If TextUbicacion.TextLength = 6 Then

            aceptar.Focus()

        End If
    End Sub

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click

        guardar()
        partNumber.Focus()


    End Sub





    Private Sub Reimprimir_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reimprimir.CheckStateChanged
        If Reimprimir.Checked = True Then
            REIMPINFO.Text = "SI"
        Else
            REIMPINFO.Text = "NO"
        End If
    End Sub
    Private Function verCoherencias() As Boolean
        Try
            Dim largoDisenio As Integer
            Dim largoPartNumber As Integer
            Dim largoEntrada As Integer

            largoDisenio = nroDisenio.TextLength
            largoPartNumber = partNumber.TextLength
            largoEntrada = nroEntrada.TextLength

            If (largoDisenio > 5 And largoPartNumber > 5 And largoEntrada > 5) Then
                'si el largo es mayor a 5 , es decir, 6 o más
                Dim disF6 As String
                Dim partF6 As String
                Dim nroF6 As String


                disF6 = nroDisenio.Text().Substring(0, 6)
                partF6 = partNumber.Text().Substring(0, 6)
                nroF6 = nroEntrada.Text().Substring(0, 6)

                If (disF6 <> partF6 And partF6 <> nroF6 And nroF6 <> disF6) Then
                    ' Lógica dado a,b,c si a != b y b!=c y c!=a ,no hay iguales entre si

                    Return True

                Else
                    MessageBox.Show("Error, tipeo 2 veces el mismo campo")

                    Select Case True


                        Case disF6 = nroF6
                            campoEnRojo(nroDisenio)
                            campoEnRojo(nroEntrada)

                        Case partF6 = disF6
                            campoEnRojo(partNumber)
                            campoEnRojo(nroDisenio)

                        Case nroF6 = partF6
                            campoEnRojo(partNumber)
                            campoEnRojo(nroEntrada)


                    End Select


                    Return False

                End If

                MessageBox.Show("Error, Hay un campo de largo menor a 6 ")
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message)
            Return False

        End Try




    End Function





End Class