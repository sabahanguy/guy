Public Class Form8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("END SESSION?", vbOKCancel, ".:: THANKS DR.FAIZAL ::.") = vbOK Then
            Me.Close()
        Else
        End If
        Dim NewForm As Form
        NewForm = New Form1
        NewForm.Show()
        NewForm = Nothing
        Me.Close()
        Form1.Close()
        Form2.Close()
        Form3.Close()
        Form4.Close()
        Form5.Close()
        Form6.Close()
        Form7.Close()
        Form9.Close()

    End Sub

End Class