<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.lblCurrencyName = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtCurrencyName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCurrencyName
        '
        Me.lblCurrencyName.AutoSize = True
        Me.lblCurrencyName.Location = New System.Drawing.Point(12, 29)
        Me.lblCurrencyName.Name = "lblCurrencyName"
        Me.lblCurrencyName.Size = New System.Drawing.Size(108, 13)
        Me.lblCurrencyName.TabIndex = 0
        Me.lblCurrencyName.Text = "Enter Currency Name"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(14, 52)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(103, 13)
        Me.lblRate.TabIndex = 1
        Me.lblRate.Text = "Enter Currency Rate"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(79, 96)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(126, 52)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 4
        '
        'txtCurrencyName
        '
        Me.txtCurrencyName.Location = New System.Drawing.Point(126, 24)
        Me.txtCurrencyName.Name = "txtCurrencyName"
        Me.txtCurrencyName.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrencyName.TabIndex = 5
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 142)
        Me.Controls.Add(Me.txtCurrencyName)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblCurrencyName)
        Me.Name = "admin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrencyName As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtCurrencyName As TextBox
End Class
