<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class currencyConverterForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.AdminPage = New System.Windows.Forms.TabPage()
        Me.txtCurrencyName = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblCurrencyName = New System.Windows.Forms.Label()
        Me.calculationPage = New System.Windows.Forms.TabPage()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.cboCurrencyNames = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.AdminPage.SuspendLayout()
        Me.calculationPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AdminPage)
        Me.TabControl1.Controls.Add(Me.calculationPage)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(285, 264)
        Me.TabControl1.TabIndex = 0
        '
        'AdminPage
        '
        Me.AdminPage.Controls.Add(Me.txtCurrencyName)
        Me.AdminPage.Controls.Add(Me.txtRate)
        Me.AdminPage.Controls.Add(Me.btnSave)
        Me.AdminPage.Controls.Add(Me.lblRate)
        Me.AdminPage.Controls.Add(Me.lblCurrencyName)
        Me.AdminPage.Location = New System.Drawing.Point(4, 22)
        Me.AdminPage.Name = "AdminPage"
        Me.AdminPage.Padding = New System.Windows.Forms.Padding(3)
        Me.AdminPage.Size = New System.Drawing.Size(277, 238)
        Me.AdminPage.TabIndex = 0
        Me.AdminPage.Text = "Admin Page"
        Me.AdminPage.UseVisualStyleBackColor = True
        '
        'txtCurrencyName
        '
        Me.txtCurrencyName.Location = New System.Drawing.Point(125, 25)
        Me.txtCurrencyName.Name = "txtCurrencyName"
        Me.txtCurrencyName.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrencyName.TabIndex = 10
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(125, 53)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(78, 97)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(13, 53)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(103, 13)
        Me.lblRate.TabIndex = 7
        Me.lblRate.Text = "Enter Currency Rate"
        '
        'lblCurrencyName
        '
        Me.lblCurrencyName.AutoSize = True
        Me.lblCurrencyName.Location = New System.Drawing.Point(11, 30)
        Me.lblCurrencyName.Name = "lblCurrencyName"
        Me.lblCurrencyName.Size = New System.Drawing.Size(108, 13)
        Me.lblCurrencyName.TabIndex = 6
        Me.lblCurrencyName.Text = "Enter Currency Name"
        '
        'calculationPage
        '
        Me.calculationPage.Controls.Add(Me.cboCurrencyNames)
        Me.calculationPage.Controls.Add(Me.Calculate)
        Me.calculationPage.Controls.Add(Me.txtAmount)
        Me.calculationPage.Controls.Add(Me.lblAmount)
        Me.calculationPage.Controls.Add(Me.lblCurrency)
        Me.calculationPage.Location = New System.Drawing.Point(4, 22)
        Me.calculationPage.Name = "calculationPage"
        Me.calculationPage.Padding = New System.Windows.Forms.Padding(3)
        Me.calculationPage.Size = New System.Drawing.Size(277, 238)
        Me.calculationPage.TabIndex = 1
        Me.calculationPage.Text = "Calculation Page"
        Me.calculationPage.UseVisualStyleBackColor = True
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(72, 132)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(75, 23)
        Me.Calculate.TabIndex = 4
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(116, 78)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 3
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(9, 81)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(101, 13)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Enter amount (GBP)"
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.Location = New System.Drawing.Point(9, 30)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(77, 13)
        Me.lblCurrency.TabIndex = 0
        Me.lblCurrency.Text = "Enter Currency"
        '
        'cboCurrencyNames
        '
        Me.cboCurrencyNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurrencyNames.FormattingEnabled = True
        Me.cboCurrencyNames.Location = New System.Drawing.Point(116, 30)
        Me.cboCurrencyNames.Name = "cboCurrencyNames"
        Me.cboCurrencyNames.Size = New System.Drawing.Size(121, 21)
        Me.cboCurrencyNames.TabIndex = 5
        '
        'currencyConverterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "currencyConverterForm"
        Me.text = "currencyConverterForm"
        Me.TabControl1.ResumeLayout(False)
        Me.AdminPage.ResumeLayout(False)
        Me.AdminPage.PerformLayout()
        Me.calculationPage.ResumeLayout(False)
        Me.calculationPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AdminPage As TabPage
    Friend WithEvents calculationPage As TabPage
    Friend WithEvents txtCurrencyName As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblRate As Label
    Friend WithEvents lblCurrencyName As Label
    Friend WithEvents Calculate As Button
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblCurrency As Label
    Friend WithEvents cboCurrencyNames As ComboBox
End Class
