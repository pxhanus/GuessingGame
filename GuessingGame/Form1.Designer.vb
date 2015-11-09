<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.btnCheckGuess = New System.Windows.Forms.Button()
        Me.txtPlayerGuess = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(40, 22)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(167, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a guess between 1 and 50: "
        '
        'btnCheckGuess
        '
        Me.btnCheckGuess.Location = New System.Drawing.Point(106, 88)
        Me.btnCheckGuess.Name = "btnCheckGuess"
        Me.btnCheckGuess.Size = New System.Drawing.Size(83, 23)
        Me.btnCheckGuess.TabIndex = 1
        Me.btnCheckGuess.Text = "Check Guess"
        Me.btnCheckGuess.UseVisualStyleBackColor = True
        '
        'txtPlayerGuess
        '
        Me.txtPlayerGuess.Location = New System.Drawing.Point(213, 19)
        Me.txtPlayerGuess.Name = "txtPlayerGuess"
        Me.txtPlayerGuess.Size = New System.Drawing.Size(40, 20)
        Me.txtPlayerGuess.TabIndex = 2
        '
        'lblMessage
        '
        Me.lblMessage.Location = New System.Drawing.Point(12, 50)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(268, 20)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 123)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtPlayerGuess)
        Me.Controls.Add(Me.btnCheckGuess)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents btnCheckGuess As System.Windows.Forms.Button
    Friend WithEvents txtPlayerGuess As System.Windows.Forms.TextBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label

End Class
