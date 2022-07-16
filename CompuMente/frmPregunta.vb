Public Class frmPregunta

    Private Sub btnListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListo.Click
        Dim RespuestaSeleccionada As String = ""
        
            If radbtnResp1.Checked Then
                RespuestaSeleccionada = radbtnResp1.Text.ToString
            ElseIf radbtnResp2.Checked Then
                RespuestaSeleccionada = radbtnResp2.Text.ToString
            ElseIf radbtnResp3.Checked Then
                RespuestaSeleccionada = radbtnResp3.Text.ToString
            End If
            If RespuestaSeleccionada.CompareTo(Componentes.PreguntaElegida.RespCorrecta) = 0 Then
                MsgBox("Respuesta Correcta", MsgBoxStyle.OkOnly, "¡Sos un genio!")
            Componentes.RespondioBien = True
            If Componentes.GrupoRespondiendo = 1 Then
                Componentes.pbarGrupo1.Increment(10)
            Else
                If Componentes.GrupoRespondiendo = 2 Then
                    Componentes.pbarGrupo2.Increment(10)
                ElseIf Componentes.GrupoRespondiendo = 3 Then
                    Componentes.pbarGrupo3.Increment(10)
                ElseIf Componentes.GrupoRespondiendo = 4 Then
                    Componentes.pbarGrupo4.Increment(10)
                ElseIf Componentes.GrupoRespondiendo = 5 Then
                    Componentes.pbarGrupo5.Increment(10)
                ElseIf Componentes.GrupoRespondiendo = 6 Then
                    Componentes.pbarGrupo6.Increment(10)
                End If
            End If
        Else
            MsgBox("Respuesta Incorrecta", MsgBoxStyle.OkOnly, "¡Fallaste!")
        End If
        If Componentes.GrupoRespondiendo = 1 Then
            Componentes.GrupoRespondiendo = 2
            Componentes.pctbxMemRAM.Location = New Point(1007, 169)
        Else
            If Componentes.GrupoRespondiendo = 2 Then
                Componentes.GrupoRespondiendo = 3
                Componentes.pctbxMemRAM.Location = New Point(1007, 264)
            ElseIf Componentes.GrupoRespondiendo = 3 Then
                Componentes.GrupoRespondiendo = 4
                Componentes.pctbxMemRAM.Location = New Point(1007, 357)
            ElseIf Componentes.GrupoRespondiendo = 4 Then
                Componentes.GrupoRespondiendo = 5
                Componentes.pctbxMemRAM.Location = New Point(1007, 444)
            ElseIf Componentes.GrupoRespondiendo = 5 Then
                Componentes.GrupoRespondiendo = 6
                Componentes.pctbxMemRAM.Location = New Point(1007, 541)
            ElseIf Componentes.GrupoRespondiendo = 6 Then
                Componentes.GrupoRespondiendo = 1
                Componentes.pctbxMemRAM.Location = New Point(1007, 79)
            End If
        End If
        If Componentes.pbarGrupo1.Value = 100 Then
            MsgBox("¡Ganó el grupo número 1!", MsgBoxStyle.OkOnly, "¡Felicitaciones!")
            Componentes.btnOk.Visible = False
            Componentes.btnOk.Enabled = False
            Componentes.btnIniciar.Visible = True
            Componentes.btnIniciar.Enabled = True
        ElseIf Componentes.pbarGrupo2.Value = 100 Then
            MsgBox("¡Ganó el grupo número 2!", MsgBoxStyle.OkOnly, "¡Felicitaciones!")
            Componentes.btnOk.Visible = False
            Componentes.btnOk.Enabled = False
            Componentes.btnIniciar.Visible = True
            Componentes.btnIniciar.Enabled = True
        ElseIf Componentes.pbarGrupo3.Value = 100 Then
            MsgBox("¡Ganó el grupo número 3!", MsgBoxStyle.OkOnly, "¡Felicitaciones!")
            Componentes.btnOk.Visible = False
            Componentes.btnOk.Enabled = False
            Componentes.btnIniciar.Visible = True
            Componentes.btnIniciar.Enabled = True
        ElseIf Componentes.pbarGrupo4.Value = 100 Then
            MsgBox("¡Ganó el grupo número 4!", MsgBoxStyle.OkOnly, "¡Felicitaciones!")
            Componentes.btnOk.Visible = False
            Componentes.btnOk.Enabled = False
            Componentes.btnIniciar.Visible = True
            Componentes.btnIniciar.Enabled = True
        ElseIf Componentes.pbarGrupo5.Value = 100 Then
            MsgBox("¡Ganó el grupo número 5!", MsgBoxStyle.OkOnly, "¡Felicitaciones!")
            Componentes.btnOk.Visible = False
            Componentes.btnOk.Enabled = False
            Componentes.btnIniciar.Visible = True
            Componentes.btnIniciar.Enabled = True
        ElseIf Componentes.pbarGrupo6.Value = 100 Then
            MsgBox("¡Ganó el grupo número 6!", MsgBoxStyle.OkOnly, "¡Felicitaciones!")
            Componentes.btnOk.Visible = False
            Componentes.btnOk.Enabled = False
            Componentes.btnIniciar.Visible = True
            Componentes.btnIniciar.Enabled = True
        End If
        Componentes.Enabled = True
        Me.Close()

    End Sub
End Class