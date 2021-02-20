Public Class frmResourceAdminDetails
    Private Sub btcAnnuler_Click(sender As Object, e As EventArgs) Handles btcAnnuler.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcOK_Click(sender As Object, e As EventArgs) Handles btcOK.Click

        Try


            Dim thisAdminResource As New myAdminResource

            If IsNumeric(Me.texID_ResourceAdmin.Text) Then thisAdminResource.ID_AdminResource = CInt(Me.texID_ResourceAdmin.Text)
            thisAdminResource.AdminResource = Me.texResourceAdmin.Text
            thisAdminResource.Symbol = Me.texResourceAdminSymbol.Text
            thisAdminResource.DisplayOrder = Me.texDisplayOrder.Text
            If Me.chkActive.Checked = True Then
                thisAdminResource.Enable = True
            Else
                thisAdminResource.Enable = False
            End If
            thisAdminResource.Save()



            Me.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub frmResourceAdminDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim thisAdminResource As New myAdminResource
            thisAdminResource.ID_AdminResource = ID_ResourceAdmin_Current

            If thisAdminResource.ID_AdminResource = 0 Then
                'C'est une nouvelle ressource administrative
                Me.texID_ResourceAdmin.Text = ""
                Me.texResourceAdmin.Text = ""
                Me.texResourceAdminSymbol.Text = ""
                Me.texDisplayOrder.Text = ""
                Me.chkActive.Checked = True
            Else
                thisAdminResource.read()
                Me.texID_ResourceAdmin.Text = thisAdminResource.ID_AdminResource
                Me.texResourceAdmin.Text = thisAdminResource.AdminResource
                Me.texResourceAdminSymbol.Text = thisAdminResource.Symbol
                Me.texDisplayOrder.Text = thisAdminResource.DisplayOrder
                If thisAdminResource.Enable = True Then
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