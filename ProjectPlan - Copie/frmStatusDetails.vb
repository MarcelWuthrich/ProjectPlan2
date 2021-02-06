Public Class frmStatusDetails
    Private Sub btcAnnuler_Click(sender As Object, e As EventArgs) Handles btcAnnuler.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcOK_Click(sender As Object, e As EventArgs) Handles btcOK.Click
        Try

            Dim thisStatus As New myStatus

            If IsNumeric(Me.texID_Status.Text) Then thisStatus.ID_Status = CInt(Me.texID_Status.Text)
            thisStatus.Status = Me.texStatus.Text
            thisStatus.DisplayOrder = Me.texDisplayOrder.Text
            If Me.chkActive.Checked = True Then
                thisStatus.Enable = True
            Else
                thisStatus.Enable = False
            End If
            thisStatus.Save()

            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frmStatusDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ID As Integer = 0

        Try

            Dim thisStatus As New myStatus
            thisStatus.ID_Status = ID_Status_Current
            thisStatus.Read()

            Me.texID_Status.Text = thisStatus.ID_Status
            Me.texStatus.Text = thisStatus.Status
            Me.texDisplayOrder.Text = thisStatus.DisplayOrder

            If thisStatus.Enable = True Then
                Me.chkActive.Checked = True
            Else
                Me.chkActive.Checked = False
            End If

            If Me.texID_Status.Text = "0" Then Me.texID_Status.Text = ""

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class