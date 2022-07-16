<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPregunta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.radbtnResp1 = New System.Windows.Forms.RadioButton()
        Me.radbtnResp2 = New System.Windows.Forms.RadioButton()
        Me.radbtnResp3 = New System.Windows.Forms.RadioButton()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.AutoSize = True
        Me.lblPregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(87, 35)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(0, 24)
        Me.lblPregunta.TabIndex = 0
        '
        'radbtnResp1
        '
        Me.radbtnResp1.AutoSize = True
        Me.radbtnResp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnResp1.Location = New System.Drawing.Point(42, 94)
        Me.radbtnResp1.Name = "radbtnResp1"
        Me.radbtnResp1.Size = New System.Drawing.Size(14, 13)
        Me.radbtnResp1.TabIndex = 1
        Me.radbtnResp1.TabStop = True
        Me.radbtnResp1.UseVisualStyleBackColor = True
        '
        'radbtnResp2
        '
        Me.radbtnResp2.AutoSize = True
        Me.radbtnResp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnResp2.Location = New System.Drawing.Point(42, 139)
        Me.radbtnResp2.Name = "radbtnResp2"
        Me.radbtnResp2.Size = New System.Drawing.Size(14, 13)
        Me.radbtnResp2.TabIndex = 2
        Me.radbtnResp2.TabStop = True
        Me.radbtnResp2.UseVisualStyleBackColor = True
        '
        'radbtnResp3
        '
        Me.radbtnResp3.AutoSize = True
        Me.radbtnResp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radbtnResp3.Location = New System.Drawing.Point(42, 183)
        Me.radbtnResp3.Name = "radbtnResp3"
        Me.radbtnResp3.Size = New System.Drawing.Size(14, 13)
        Me.radbtnResp3.TabIndex = 3
        Me.radbtnResp3.TabStop = True
        Me.radbtnResp3.UseVisualStyleBackColor = True
        '
        'btnListo
        '
        Me.btnListo.Location = New System.Drawing.Point(447, 235)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(75, 23)
        Me.btnListo.TabIndex = 4
        Me.btnListo.Text = "¡Listo!"
        Me.btnListo.UseVisualStyleBackColor = True
        '
        'frmPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 300)
        Me.Controls.Add(Me.btnListo)
        Me.Controls.Add(Me.radbtnResp3)
        Me.Controls.Add(Me.radbtnResp2)
        Me.Controls.Add(Me.radbtnResp1)
        Me.Controls.Add(Me.lblPregunta)
        Me.Name = "frmPregunta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregunta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents radbtnResp1 As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnResp2 As System.Windows.Forms.RadioButton
    Friend WithEvents radbtnResp3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnListo As System.Windows.Forms.Button
End Class
