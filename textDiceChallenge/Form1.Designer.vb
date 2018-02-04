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
        Me.lblRollDice = New System.Windows.Forms.Label()
        Me.btnRollDice = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRollDice
        '
        Me.lblRollDice.AutoSize = True
        Me.lblRollDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollDice.Location = New System.Drawing.Point(106, 100)
        Me.lblRollDice.Name = "lblRollDice"
        Me.lblRollDice.Size = New System.Drawing.Size(161, 13)
        Me.lblRollDice.TabIndex = 0
        Me.lblRollDice.Text = "Click button to roll the dice"
        '
        'btnRollDice
        '
        Me.btnRollDice.Location = New System.Drawing.Point(148, 135)
        Me.btnRollDice.Name = "btnRollDice"
        Me.btnRollDice.Size = New System.Drawing.Size(75, 23)
        Me.btnRollDice.TabIndex = 1
        Me.btnRollDice.Text = "Roll Dice"
        Me.btnRollDice.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(298, 100)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(21, 13)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 306)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnRollDice)
        Me.Controls.Add(Me.lblRollDice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRollDice As Label
    Friend WithEvents btnRollDice As Button
    Friend WithEvents lblOutput As Label
End Class
