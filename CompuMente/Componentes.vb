Public Class Componentes
    Public Elegido As String
    Public ListadoAlumnos = New List(Of String)
    Public ListadoPreguntas As List(Of Pregunta) = New List(Of Pregunta)
    Public PreguntaElegida As Pregunta
    Public RespondioBien As Boolean = False
    Public GrupoRespondiendo As Integer = 1


    Private Sub Componentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        btnIniciar.Visible = True
        btnIniciar.Enabled = True
        btnOk.Visible = False
        btnOk.Enabled = False

        CargarListadoAlumnos()

        

    End Sub

    Public Sub SeleccionAlumnoAlAzahar()

        Dim aleatorio As New Random()
        Dim i As Integer = aleatorio.Next(23)
        Elegido = ListadoAlumnos(i)
    End Sub

    Private Sub CargarListadoAlumnos()
        ListadoAlumnos.Add("Álvarez Joel Emilio")
        ListadoAlumnos.Add("Baez Tobias Leonel")
        ListadoAlumnos.Add("Cabral Joaquín")
        ListadoAlumnos.Add("Camaño Matías Alejandro")
        ListadoAlumnos.Add("Córdoba Mauricio Catriel")
        ListadoAlumnos.Add("Coronel Germán")
        ListadoAlumnos.Add("Coronel Tiziano Tomás")
        ListadoAlumnos.Add("Gaido Villarreal Lucas Alberto")
        ListadoAlumnos.Add("Galliano Bustos Donato")
        ListadoAlumnos.Add("Guevara Peuser Alma")
        ListadoAlumnos.Add("Ibarra Ticiano")
        ListadoAlumnos.Add("Lieby Alejandro Martín")
        ListadoAlumnos.Add("Lieby Joaquín")
        ListadoAlumnos.Add("Palacio Eusebio Bautista")
        ListadoAlumnos.Add("Roldán Coronel Lautaro Ezequiel")
        ListadoAlumnos.Add("Romero Benjamín")
        ListadoAlumnos.Add("Romero Silva Tatiana")
        ListadoAlumnos.Add("Salomón Martín Ignacio")
        ListadoAlumnos.Add("Saravia Favio Benjamín")
        ListadoAlumnos.Add("Sosa Lara Berenice")
        ListadoAlumnos.Add("Vissani Brusadin Santino")
        ListadoAlumnos.Add("Vivas Huppi Ana Alfonsina")
        ListadoAlumnos.Add("Vivas Ramirez Florencia")
    End Sub

    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        btnIniciar.Visible = False
        btnIniciar.Enabled = False
        btnOk.Visible = True
        btnOk.Enabled = True
        pctbxMemRAM.Visible = True
        CargarListadoPreguntas()
        GrupoRespondiendo = 1
        pctbxMemRAM.Location = New Point(1007, 79)

        Dim i As Integer


        lbl1Grupo1.Text = ""
        lbl1Grupo2.Text = ""
        lbl1Grupo3.Text = ""
        lbl1Grupo4.Text = ""
        lbl1Grupo5.Text = ""
        lbl1Grupo6.Text = ""
        lbl2Grupo1.Text = ""
        lbl2Grupo2.Text = ""
        lbl2Grupo3.Text = ""
        lbl2Grupo4.Text = ""
        lbl2Grupo5.Text = ""
        lbl2Grupo6.Text = ""
        lbl3Grupo1.Text = ""
        lbl3Grupo2.Text = ""
        lbl3Grupo3.Text = ""
        lbl3Grupo4.Text = ""
        lbl3Grupo5.Text = ""
        lbl3Grupo6.Text = ""
        lbl4Grupo1.Text = ""
        lbl4Grupo2.Text = ""
        lbl4Grupo3.Text = ""
        lbl4Grupo4.Text = ""
        lbl4Grupo5.Text = ""

        For i = 0 To 23 Step 1
            SeleccionAlumnoAlAzahar()
            If lbl1Grupo1.Text.Length = 0 Then
                lbl1Grupo1.Text = Elegido
            Else
                While lbl1Grupo1.Text.CompareTo(Elegido) = 0
                    SeleccionAlumnoAlAzahar()
                End While
                If lbl1Grupo2.Text.Length = 0 Then
                    lbl1Grupo2.Text = Elegido
                Else
                    While lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                        SeleccionAlumnoAlAzahar()
                    End While
                    If lbl1Grupo3.Text.Length = 0 Then
                        lbl1Grupo3.Text = Elegido
                    Else
                        While lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                            SeleccionAlumnoAlAzahar()
                        End While
                        If lbl1Grupo4.Text.Length = 0 Then
                            lbl1Grupo4.Text = Elegido
                        Else
                            While lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                SeleccionAlumnoAlAzahar()
                            End While
                            If lbl1Grupo5.Text.Length = 0 Then
                                lbl1Grupo5.Text = Elegido
                            Else
                                While lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                    SeleccionAlumnoAlAzahar()
                                End While
                                If lbl1Grupo6.Text.Length = 0 Then
                                    lbl1Grupo6.Text = Elegido
                                Else
                                    While lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                        SeleccionAlumnoAlAzahar()
                                    End While
                                    If lbl2Grupo1.Text.Length = 0 Then
                                        lbl2Grupo1.Text = Elegido
                                    Else
                                        While lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                            SeleccionAlumnoAlAzahar()
                                        End While
                                        If lbl2Grupo2.Text.Length = 0 Then
                                            lbl2Grupo2.Text = Elegido
                                        Else
                                            While lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                SeleccionAlumnoAlAzahar()
                                            End While
                                            If lbl2Grupo3.Text.Length = 0 Then
                                                lbl2Grupo3.Text = Elegido
                                            Else
                                                While lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                    SeleccionAlumnoAlAzahar()
                                                End While
                                                If lbl2Grupo4.Text.Length = 0 Then
                                                    lbl2Grupo4.Text = Elegido
                                                Else
                                                    While lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                        SeleccionAlumnoAlAzahar()
                                                    End While
                                                    If lbl2Grupo5.Text.Length = 0 Then
                                                        lbl2Grupo5.Text = Elegido
                                                    Else
                                                        While lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                            SeleccionAlumnoAlAzahar()
                                                        End While
                                                        If lbl2Grupo6.Text.Length = 0 Then
                                                            lbl2Grupo6.Text = Elegido
                                                        Else
                                                            While lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                SeleccionAlumnoAlAzahar()
                                                            End While
                                                            If lbl3Grupo1.Text.Length = 0 Then
                                                                lbl3Grupo1.Text = Elegido
                                                            Else
                                                                While lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                    SeleccionAlumnoAlAzahar()
                                                                End While
                                                                If lbl3Grupo2.Text.Length = 0 Then
                                                                    lbl3Grupo2.Text = Elegido
                                                                Else
                                                                    While lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                        SeleccionAlumnoAlAzahar()
                                                                    End While
                                                                    If lbl3Grupo3.Text.Length = 0 Then
                                                                        lbl3Grupo3.Text = Elegido
                                                                    Else
                                                                        While lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                            SeleccionAlumnoAlAzahar()
                                                                        End While
                                                                        If lbl3Grupo4.Text.Length = 0 Then
                                                                            lbl3Grupo4.Text = Elegido
                                                                        Else
                                                                            While lbl3Grupo4.Text.CompareTo(Elegido) = 0 Or lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                                SeleccionAlumnoAlAzahar()
                                                                            End While
                                                                            If lbl3Grupo5.Text.Length = 0 Then
                                                                                lbl3Grupo5.Text = Elegido
                                                                            Else
                                                                                While lbl3Grupo5.Text.CompareTo(Elegido) = 0 Or lbl3Grupo4.Text.CompareTo(Elegido) = 0 Or lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                                    SeleccionAlumnoAlAzahar()
                                                                                End While
                                                                                If lbl3Grupo6.Text.Length = 0 Then
                                                                                    lbl3Grupo6.Text = Elegido
                                                                                Else
                                                                                    While lbl3Grupo6.Text.CompareTo(Elegido) = 0 Or lbl3Grupo5.Text.CompareTo(Elegido) = 0 Or lbl3Grupo4.Text.CompareTo(Elegido) = 0 Or lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                                        SeleccionAlumnoAlAzahar()
                                                                                    End While
                                                                                    If lbl4Grupo1.Text.Length = 0 Then
                                                                                        lbl4Grupo1.Text = Elegido
                                                                                    Else
                                                                                        While lbl4Grupo1.Text.CompareTo(Elegido) = 0 Or lbl3Grupo6.Text.CompareTo(Elegido) = 0 Or lbl3Grupo5.Text.CompareTo(Elegido) = 0 Or lbl3Grupo4.Text.CompareTo(Elegido) = 0 Or lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                                            SeleccionAlumnoAlAzahar()
                                                                                        End While
                                                                                        If lbl4Grupo2.Text.Length = 0 Then
                                                                                            lbl4Grupo2.Text = Elegido
                                                                                        Else
                                                                                            While lbl4Grupo2.Text.CompareTo(Elegido) = 0 Or lbl4Grupo1.Text.CompareTo(Elegido) = 0 Or lbl3Grupo6.Text.CompareTo(Elegido) = 0 Or lbl3Grupo5.Text.CompareTo(Elegido) = 0 Or lbl3Grupo4.Text.CompareTo(Elegido) = 0 Or lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                                                SeleccionAlumnoAlAzahar()
                                                                                            End While
                                                                                            If lbl4Grupo3.Text.Length = 0 Then
                                                                                                lbl4Grupo3.Text = Elegido
                                                                                            Else
                                                                                                While lbl4Grupo3.Text.CompareTo(Elegido) = 0 Or lbl4Grupo2.Text.CompareTo(Elegido) = 0 Or lbl4Grupo1.Text.CompareTo(Elegido) = 0 Or lbl3Grupo6.Text.CompareTo(Elegido) = 0 Or lbl3Grupo5.Text.CompareTo(Elegido) = 0 Or lbl3Grupo4.Text.CompareTo(Elegido) = 0 Or lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                                                    SeleccionAlumnoAlAzahar()
                                                                                                End While
                                                                                                If lbl4Grupo4.Text.Length = 0 Then
                                                                                                    lbl4Grupo4.Text = Elegido
                                                                                                Else
                                                                                                    While lbl4Grupo4.Text.CompareTo(Elegido) = 0 Or lbl4Grupo3.Text.CompareTo(Elegido) = 0 Or lbl4Grupo2.Text.CompareTo(Elegido) = 0 Or lbl4Grupo1.Text.CompareTo(Elegido) = 0 Or lbl3Grupo6.Text.CompareTo(Elegido) = 0 Or lbl3Grupo5.Text.CompareTo(Elegido) = 0 Or lbl3Grupo4.Text.CompareTo(Elegido) = 0 Or lbl3Grupo3.Text.CompareTo(Elegido) = 0 Or lbl3Grupo2.Text.CompareTo(Elegido) = 0 Or lbl3Grupo1.Text.CompareTo(Elegido) = 0 Or lbl2Grupo6.Text.CompareTo(Elegido) = 0 Or lbl2Grupo5.Text.CompareTo(Elegido) = 0 Or lbl2Grupo4.Text.CompareTo(Elegido) = 0 Or lbl2Grupo3.Text.CompareTo(Elegido) = 0 Or lbl2Grupo2.Text.CompareTo(Elegido) = 0 Or lbl2Grupo1.Text.CompareTo(Elegido) = 0 Or lbl1Grupo6.Text.CompareTo(Elegido) = 0 Or lbl1Grupo5.Text.CompareTo(Elegido) = 0 Or lbl1Grupo4.Text.CompareTo(Elegido) = 0 Or lbl1Grupo3.Text.CompareTo(Elegido) = 0 Or lbl1Grupo2.Text.CompareTo(Elegido) = 0 Or lbl1Grupo1.Text.CompareTo(Elegido) = 0
                                                                                                        SeleccionAlumnoAlAzahar()
                                                                                                    End While
                                                                                                    If lbl4Grupo5.Text.Length = 0 Then
                                                                                                        lbl4Grupo5.Text = Elegido
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next

        pbarGrupo1.Value = 0
        pbarGrupo2.Value = 0
        pbarGrupo3.Value = 0
        pbarGrupo4.Value = 0
        pbarGrupo5.Value = 0
        pbarGrupo6.Value = 0

    End Sub

    Public Class Pregunta
        Public Property Pregunta As String
        Public Property Resp1 As String
        Public Property Resp2 As String
        Public Property Resp3 As String
        Public Property RespCorrecta As String

        Public Sub New(ByVal Preg As String, ByVal R1 As String, ByVal R2 As String, ByVal R3 As String, ByVal RCorr As String)
            Pregunta = Preg
            Resp1 = R1
            Resp2 = R2
            Resp3 = R3
            RespCorrecta = RCorr

        End Sub
    End Class

    Private Sub CargarListadoPreguntas()
        ListadoPreguntas.Add(New Pregunta("¿Cuáles son las partes principales en las que se divide una computadora?", "Hardware y Software", "CPU, Memoria RAM, Placa Madre y Disco Rígido", "Monitor, teclado, mouse y parlantes", "Hardware y Software"))
        ListadoPreguntas.Add(New Pregunta("¿Qué es el Hardware?", "La parte lógica de una computadora", "La parte física de una computadora", "La parte interna de una computadora", "La parte física de una computadora"))
        ListadoPreguntas.Add(New Pregunta("¿Qué es el Software?", "La parte lógica de una computadora", "La parte física de una computadora", "La parte interna de una computadora", "La parte lógica de una computadora"))
        ListadoPreguntas.Add(New Pregunta("¿Cuáles son los distintos tipos de Hardware?", "Táctil, Dinámico y Digital", "Parte física, parte lógica y parte analógica", "Dispositivos de Entrada, Dispositivos de Proceso y Dispositivos de Salida", "Dispositivos de Entrada, Dispositivos de Proceso y Dispositivos de Salida"))
        ListadoPreguntas.Add(New Pregunta("¿Cuál sería un ejemplo de Dispositivo de Entrada?", "Memoria RAM", "Teclado", "Monitor", "Teclado"))
        ListadoPreguntas.Add(New Pregunta("¿Cuál sería un ejemplo de Dispositivo de Proceso?", "Memoria RAM", "Teclado", "Monitor", "Memoria RAM"))
        ListadoPreguntas.Add(New Pregunta("¿Cuál sería un ejemplo de Dispositivo de Salida?", "Memoria RAM", "Teclado", "Monitor", "Monitor"))
        ListadoPreguntas.Add(New Pregunta("¿Cuáles de los siguientes son componentes de la computadora?", "Memoria RAM, Disco Duro, Microprocesador y Placa Madre", "Teclado, Monitor, Mouse y Parlantes", "Gabinete, Disco Duro, Monitor y Microprocesador", "Memoria RAM, Disco Duro, Microprocesador y Placa Madre"))
        ListadoPreguntas.Add(New Pregunta("¿Con qué objeto cotidiano se puede relacionar al Microprocesador?", "Depósito", "Cerebro", "Autopista", "Cerebro"))
        ListadoPreguntas.Add(New Pregunta("¿Con qué objeto cotidiano se puede relacionar al Disco Duro?", "Depósito", "Cerebro", "Autopista", "Depósito"))
        ListadoPreguntas.Add(New Pregunta("¿Con qué objeto cotidiano se puede relacionar al Bus de Datos?", "Depósito", "Cerebro", "Autopista", "Autopista"))
        ListadoPreguntas.Add(New Pregunta("¿Para qué sirve el microprocesador?", "Almacenar la información permanentemente", "Realizar las tareas principales de una computadora", "Almacenar información mientras se necesita", "Realizar las tareas principales de una computadora"))
        ListadoPreguntas.Add(New Pregunta("¿Para qué sirve el Disco Duro?", "Almacenar la información permanentemente", "Realizar las tareas principales de una computadora", "Almacenar información mientras se necesita", "Almacenar la información permanentemente"))
        ListadoPreguntas.Add(New Pregunta("¿Para qué sirve la Memoria RAM?", "Almacenar la información permanentemente", "Realizar las tareas principales de una computadora", "Almacenar información mientras se necesita", "Almacenar información mientras se necesita"))
        ListadoPreguntas.Add(New Pregunta("¿Para qué sirve la Placa Madre?", "Almacenar información", "Realizar las tareas principales de una computadora", "Conectar los componentes entre sí y con los dispositivos de Entrada y Salida", "Conectar los componentes entre sí y con los dispositivos de Entrada y Salida"))
        ListadoPreguntas.Add(New Pregunta("¿Cómo está compuesto el microprocesador?", "Unidad de Control, Unidad Aritmético-Lógica, Registros, Bus y Clock", "Unidad de Control, Unidad Aritmético-Lógica, Memoria RAM, Bus y ALU", "Memoria ROM, Unidad Aritmético-Lógica, Registros, Memoria RAM y Clock", "Unidad de Control, Unidad Aritmético-Lógica, Registros, Bus y Clock"))
        ListadoPreguntas.Add(New Pregunta("¿Cómo está compuesta la Memoria Principal?", "Disco Duro, Unidad de CD's y Memoria RAM", "Memoria RAM y Placa Madre", "Memoria ROM y Memoria RAM", "Memoria ROM y Memoria RAM"))
        ListadoPreguntas.Add(New Pregunta("¿Cómo se mide la capacidad del Disco Duro?", "Se mide en GigaBytes (GB)", "Se mide en GigaHertz (GHz)", "Se mide en Gigagramos (Gg)", "Se mide en GigaBytes (GB)"))
        ListadoPreguntas.Add(New Pregunta("¿Qué componentes se conectan directamente (sin cables) a la Placa Madre?", "Disco Duro, Procesador y Memoria RAM", "Memoria ROM, Procesador y Memoria RAM", "Memoria ROM, Procesador y Lectora de DVD's", "Memoria ROM, Procesador y Memoria RAM"))
        ListadoPreguntas.Add(New Pregunta("¿Cómo está formado el Modelo de Von Neumann?", "ALU, Unidad de Control, Registros, Memoria Principal y dispositivos de Entrada/Salida", "ALU, Unidad de Control, Registros, Memoria Principal y Disco Duro", "Procesador, Unidad de Control, Registros, Lectora de DVD's y dispositivos de Entrada/Salida", "ALU, Unidad de Control, Registros, Memoria Principal y dispositivos de Entrada/Salida"))
        ListadoPreguntas.Add(New Pregunta("¿Qué indica el Modelo de Von Neumann?", "El orden de los componentes de una computadora", "La forma en que se transmite y procesa la información", "La forma en que se almacena la información", "La forma en que se transmite y procesa la información"))
        ListadoPreguntas.Add(New Pregunta("¿En qué se basa la Jerarquía de Memorias?", "El orden de los componentes de una computadora", "La cantidad de información que se procesa", "Capacidad, velocidad y costo por bit de las distintas memorias", "Capacidad, velocidad y costo por bit de las distintas memorias"))
        ListadoPreguntas.Add(New Pregunta("¿Cuál es el objetivo de la Jerarquía de Memorias?", "Obtener computadoras más rápidas y de mayor capacidad a menor precio", "Obtener computadoras más rápidas y de mayor capacidad a mayor precio", "Obtener computadoras más lentas y de mayorcapacidad a menor precio", "Obtener computadoras más rápidas y de mayor capacidad a menor precio"))
        ListadoPreguntas.Add(New Pregunta("¿Cómo se organizan las memorias en la Jerarquía de Memorias?", "Se organizan en niveles y de forma piramidal", "Se organizan en escalas y de forma helicoidal", "Se organizan en graduaciones y de forma escalonada", "Se organizan en niveles y de forma piramidal"))
        ListadoPreguntas.Add(New Pregunta("¿Qué determina la capacidad de una computadora?", "La velocidad del disco duro, la capacidad del microprocesador y de la memoria RAM, entre otros", "La capacidad del disco duro, la capacidad del microprocesador y de la memoria RAM, entre otros", "La capacidad del disco duro, la velocidad del microprocesador y la capacidad de la memoria RAM, entre otros", "La capacidad del disco duro, la velocidad del microprocesador y la capacidad de la memoria RAM, entre otros"))
        ListadoPreguntas.Add(New Pregunta("¿Qué tendrías en cuenta al momento de elegir una computadora?", "La velocidad del disco duro, la capacidad del microprocesador y de la memoria RAM, el precio,el color, entre otros", "La capacidad del disco duro, la velocidad del microprocesador, la capacidad de la memoria RAM, el precio,la calidad de los componentes, entre otros", "La capacidad del disco duro, la velocidad del microprocesador y de la memoria RAM, el precio,la forma, entre otros", "La capacidad del disco duro, la velocidad del microprocesador, la capacidad de la memoria RAM, el precio,la calidad de los componentes, entre otros"))
        ListadoPreguntas.Add(New Pregunta("¿Qué creó Alan Turing?", "Una máquina imaginaria", "Una computadora", "Una máquina mecánica", "Una máquina imaginaria"))
        ListadoPreguntas.Add(New Pregunta("¿Qué determinó Alan Turing que sentó las bases para la creación de computadoras?", "Que todo lo computable es lo que tiene solución por medio de computadora", "Que todo lo computable es lo que tiene solución por medio de un algoritmo", "Que todo lo computable es lo que tiene solución mágica", "Que todo lo computable es lo que tiene solución por medio de un algoritmo"))
        ListadoPreguntas.Add(New Pregunta("Según Alan Turing, ¿qué es lo no computable?", "Todo lo que no tiene solución por medio de un algoritmo", "Todo lo que no tiene solución por medio de computadora", "Todo lo que no tiene solución en la vida", "Todo lo que no tiene solución por medio de un algoritmo"))
        ListadoPreguntas.Add(New Pregunta("Alan Turing, ¿conoció una computadora?", "Sí, él creó la primera", "Sí, usó una durante la Segunda Guerra Mundial", "No, falleció sin poder hacer realidad su idea por falta de medios técnicos", "No, falleció sin poder hacer realidad su idea por falta de medios técnicos"))
        ListadoPreguntas.Add(New Pregunta("Buscá un Disco Duro entre las computadoras desarmadas y la profe responderá si trajiste el componente correcto", "Sí", "No", "No", "Sí"))
        ListadoPreguntas.Add(New Pregunta("Buscá un Microprocesador entre las computadoras desarmadas y la profe responderá si trajiste el componente correcto", "Sí", "No", "No", "Sí"))
        ListadoPreguntas.Add(New Pregunta("Buscá una Memoria RAM entre las computadoras desarmadas y la profe responderá si trajiste el componente correcto", "Sí", "No", "No", "Sí"))
        ListadoPreguntas.Add(New Pregunta("Buscá una Placa Madre entre las computadoras desarmadas y la profe responderá si trajiste el componente correcto", "Sí", "No", "No", "Sí"))
        ListadoPreguntas.Add(New Pregunta("Señalá un monitor de las computadoras armadas y la profe responderá si es el componente correcto", "Sí", "No", "No", "Sí"))
        ListadoPreguntas.Add(New Pregunta("Señalá un teclado de las computadoras armadas y la profe responderá si es el componente correcto", "Sí", "No", "No", "Sí"))

    End Sub

    Public Sub SeleccionPreguntaAlAzahar()

        Dim aleatorio As New Random()
        Dim i As Integer = aleatorio.Next(30)
        PreguntaElegida = ListadoPreguntas(i)
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        SeleccionPreguntaAlAzahar()
        frmPregunta.lblPregunta.Text = PreguntaElegida.Pregunta.ToString
        frmPregunta.radbtnResp1.Text = PreguntaElegida.Resp1.ToString
        frmPregunta.radbtnResp2.Text = PreguntaElegida.Resp2.ToString
        frmPregunta.radbtnResp3.Text = PreguntaElegida.Resp3.ToString
        frmPregunta.Show()
        frmPregunta.radbtnResp1.Checked = True
        frmPregunta.radbtnResp2.Checked = False
        frmPregunta.radbtnResp3.Checked = False
        Me.Enabled = False

    End Sub

End Class
