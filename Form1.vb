Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_2_hmDataSet.Sheet1' table. You can move, or remove it, as needed.
        Me.Sheet1TableAdapter.Fill(Me.Database_2_hmDataSet.Sheet1)

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Sheet1BindingSource.MoveFirst()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Sheet1BindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Sheet1BindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Sheet1BindingSource.MoveLast()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Sheet1BindingSource.EndEdit()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Sheet1BindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Database_2_hmDataSet)
            MessageBox.Show("Data have been recorded")
        Catch ex As Exception
            MessageBox.Show("An error occured! Please try again.")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Sheet1BindingSource.RemoveCurrent()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure?", vbOKCancel, ".:: Data Information ::.") = vbOK Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Form2.Show()
    End Sub
End Class
