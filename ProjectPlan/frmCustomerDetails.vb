Imports System.ComponentModel
Imports MySql.Data.MySqlClient


Public Class frmCustomerDetails
    Private Sub frmCustomerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If ID_Customer_Current <> 0 Then
                Dim thisCustomer As New myCustomer
                thisCustomer.ID_Customer = ID_Customer_Current
                thisCustomer.Read()

                Me.texID_Customer.Text = thisCustomer.ID_Customer
                Me.texFirstname.Text = thisCustomer.FirstName
                Me.texLastname.Text = thisCustomer.Lastname
                Me.texCompanyName.Text = thisCustomer.CompanyName
                Me.texCompanyLocation.Text = thisCustomer.CompanyLocation
                If thisCustomer.Enable = True Then
                    Me.chkActive.Checked = True
                Else
                    Me.chkActive.Checked = False
                End If
                Me.texDisplayOrder.Text = thisCustomer.DisplayOrder
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

            Dim thisCustomer As New myCustomer
            If Me.texID_Customer.Text = "" Then
                thisCustomer.ID_Customer = 0
            Else
                thisCustomer.ID_Customer = CInt(Me.texID_Customer.Text)
            End If
            thisCustomer.FirstName = Me.texFirstname.Text
            thisCustomer.Lastname = Me.texLastname.Text
            thisCustomer.CompanyName = Me.texCompanyName.Text
            thisCustomer.CompanyLocation = Me.texCompanyLocation.Text
            If Me.chkActive.Checked = True Then
                thisCustomer.Enable = True
            Else
                thisCustomer.Enable = False
            End If
            thisCustomer.DisplayOrder = CInt(Me.texDisplayOrder.Text)
            thisCustomer.Save()

            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub frmCustomerDetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            ID_Customer_Current = 0
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class