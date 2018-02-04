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
        Me.lblMove = New System.Windows.Forms.Label()
        Me.txtMove = New System.Windows.Forms.MaskedTextBox()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMove
        '
        Me.lblMove.AutoSize = True
        Me.lblMove.Location = New System.Drawing.Point(29, 39)
        Me.lblMove.Name = "lblMove"
        Me.lblMove.Size = New System.Drawing.Size(64, 13)
        Me.lblMove.TabIndex = 0
        Me.lblMove.Text = "Enter move:"
        '
        'txtMove
        '
        Me.txtMove.Location = New System.Drawing.Point(71, 66)
        Me.txtMove.Name = "txtMove"
        Me.txtMove.Size = New System.Drawing.Size(100, 20)
        Me.txtMove.TabIndex = 1
        '
        'btnFire
        '
        Me.btnFire.Location = New System.Drawing.Point(84, 117)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(75, 23)
        Me.btnFire.TabIndex = 2
        Me.btnFire.Text = "Fire"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.txtMove)
        Me.Controls.Add(Me.lblMove)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMove As Label
    Friend WithEvents txtMove As MaskedTextBox
    Friend WithEvents btnFire As Button
End Class
