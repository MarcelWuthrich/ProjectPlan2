Public Class frmProjectManagerDetails
    Private Sub frmProjectManagerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim thisProjectManager As New myProjectManager
            thisProjectManager.ID_ProjectManager = ID_ProjectManager
            thisProjectManager.Read()

            Me.texID_ProjectManager.Text = thisProjectManager.ID_ProjectManager
            Me.texNom.Text = thisProjectManager.Lastname
            Me.texPrenom.Text = thisProjectManager.FirstName

            If thisProjectManager.Enable = True Then
                Me.chkActive.Checked = True
            Else
                Me.chkActive.Checked = False
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try



    End Sub

    Private Sub btcAnnuler_Click(sender As Object, e As EventArgs) Handles btcAnnuler.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcOK_Click(sender As Object, e As EventArgs) Handles btcOK.Click
        Try

            Dim thisProjectManager As New myProjectManager


            thisProjectManager.ID_ProjectManager = Val(Me.texID_ProjectManager.Text)
            thisProjectManager.FirstName = Me.texPrenom.Text
            thisProjectManager.Lastname = Me.texNom.Text
            If Me.chkActive.Checked = True Then
                thisProjectManager.Enable = True
            Else
                thisProjectManager.Enable = False
            End If

            thisProjectManager.Save()

            Me.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class