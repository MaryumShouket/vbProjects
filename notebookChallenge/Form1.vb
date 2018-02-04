Public Class Form1
    Dim arraySize As Integer = 10
    Dim notes(arraySize) As String
    Dim number0 As Integer
    Dim noteNumberToChange As Integer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddNote()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstBoxDisplay.Visible = True
        lstBoxDisplay.Items.Clear()
        For j As Integer = 0 To arraySize Step +1
            If Not notes(j) Is Nothing Then
                lstBoxDisplay.Items.Add(notes(j))
            End If

        Next

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ChangeNote()
    End Sub

    Private Sub lstBoxDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxDisplay.SelectedIndexChanged
        txtChangeNote.Text = lstBoxDisplay.SelectedItem
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Forms.Form1.MaximizeBox = False
    End Sub

    Private Sub MyEventHandler(sender As Object, e As KeyEventArgs) Handles txtAddNote.KeyDown, txtChangeNote.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            If sender.Name = "txtAddNote" Then
                AddNote()
            ElseIf sender.Name = "txtChangeNote" Then
                ChangeNote()
            End If
        End If
    End Sub

    Private Sub AddNote()
        If number0 > arraySize Then
            MsgBox("Number of notes exceeded the limit")
        Else
            notes(number0) = txtAddNote.Text
            txtAddNote.ResetText()
            lstBoxDisplay.Items.Add(notes(number0))
            number0 += 1

        End If
    End Sub

    Private Sub ChangeNote()
        RemoveHandler lstBoxDisplay.SelectedIndexChanged, AddressOf lstBoxDisplay_SelectedIndexChanged

        Dim selectItemIndex As Integer
        selectItemIndex = lstBoxDisplay.SelectedIndex
        If selectItemIndex < 0 Then
            MsgBox("Please first select a note from the list")
        Else
            lstBoxDisplay.Items.RemoveAt(selectItemIndex)
            lstBoxDisplay.Items.Insert(selectItemIndex, txtChangeNote.Text)
            lstBoxDisplay.SetSelected(selectItemIndex, True)
            'lstBoxDisplay.SelectedIndex = selectItemIndex

        End If
        AddHandler lstBoxDisplay.SelectedIndexChanged, AddressOf lstBoxDisplay_SelectedIndexChanged
    End Sub
End Class
