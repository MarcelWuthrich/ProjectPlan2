'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class frmTaskDetails
    Private Sub btcAnnuler_Click(sender As Object, e As EventArgs) Handles btcAnnuler.Click

        Try

            Me.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btcOK_Click(sender As Object, e As EventArgs) Handles btcOK.Click

        Try

            Dim thisTask As New myTask

            If IsNumeric(Me.texID_Task.Text) Then thisTask.ID_Task = CInt(Me.texID_Task.Text)
            thisTask.Task = Me.texTask.Text
            thisTask.DisplayOrder = Me.texDisplayOrder.Text
            If Me.chkActive.Checked = True Then
                thisTask.Enable = True
            Else
                thisTask.Enable = False
            End If
            thisTask.Save()

            Me.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Private Sub frmTaskDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim thisTask As New myTask
            thisTask.ID_Task = ID_Task_Current

            If thisTask.ID_Task = 0 Then
                'C'est une nouvelle tâche
                Me.texID_Task.Text = ""
                Me.texTask.Text = ""
                Me.texDisplayOrder.Text = ""
                Me.chkActive.Checked = True
            Else
                thisTask.Read()
                Me.texID_Task.Text = thisTask.ID_Task
                Me.texTask.Text = thisTask.Task
                Me.texDisplayOrder.Text = thisTask.DisplayOrder
                If thisTask.Enable = True Then
                    Me.chkActive.Checked = True
                Else
                    Me.chkActive.Checked = False
                End If
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)

        End Try
    End Sub
End Class