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
        Me.txtAddNote = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lstBoxDisplay = New System.Windows.Forms.ListBox()
        Me.txtChangeNote = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAddNote
        '
        Me.txtAddNote.Location = New System.Drawing.Point(97, 79)
        Me.txtAddNote.Name = "txtAddNote"
        Me.txtAddNote.Size = New System.Drawing.Size(232, 20)
        Me.txtAddNote.TabIndex = 0
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(16, 132)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(457, 179)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display all"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(16, 79)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 25)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(261, 20)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "Type a note to save or change: "
        '
        'lstBoxDisplay
        '
        Me.lstBoxDisplay.FormattingEnabled = True
        Me.lstBoxDisplay.Location = New System.Drawing.Point(440, 52)
        Me.lstBoxDisplay.Name = "lstBoxDisplay"
        Me.lstBoxDisplay.Size = New System.Drawing.Size(120, 121)
        Me.lstBoxDisplay.TabIndex = 5
        '
        'txtChangeNote
        '
        Me.txtChangeNote.Location = New System.Drawing.Point(97, 134)
        Me.txtChangeNote.Name = "txtChangeNote"
        Me.txtChangeNote.Size = New System.Drawing.Size(232, 20)
        Me.txtChangeNote.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 241)
        Me.Controls.Add(Me.txtChangeNote)
        Me.Controls.Add(Me.lstBoxDisplay)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.txtAddNote)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAddNote As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lstBoxDisplay As ListBox
    Friend WithEvents txtChangeNote As TextBox
End Class
