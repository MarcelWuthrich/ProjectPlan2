Public Class frmResourcesAdmin
    Private Sub frmResourcesAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            pDisplayProjectMembers()
            pDisplayResourcesAdmin()

            Me.radDaily.Checked = True


        Catch ex As Exception

        End Try

    End Sub
    Private Sub pDisplayResourcesAdmin()
        Try

            'TODO: This line of code loads data into the 'DsResoucesAdmin.vresourcesadmin' table. You can move, or remove it, as needed.
            Me.VresourcesadminTableAdapter.Fill(Me.DsResoucesAdmin.vresourcesadmin)

            Dim myFilter As String = "Enable=1"
            Dim thisBindingSource As New BindingSource
            thisBindingSource = VresourcesadminBindingSource
            thisBindingSource.Filter = myFilter

            dgvResourcesAdmin.DataSource = thisBindingSource

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayProjectMembers()

        Try

            'TODO: This line of code loads data into the 'ProjectplanDataSet.vprojectmembers' table. You can move, or remove it, as needed.
            Me.VprojectmembersTableAdapter.Fill(Me.ProjectplanDataSet.vprojectmembers)

            Dim myFilter As String = "Enable=1"
            Dim thisBindingSource As New BindingSource
            thisBindingSource = VprojectmembersBindingSource
            thisBindingSource.Filter = myFilter

            dgvProjectMembers.DataSource = thisBindingSource

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcFermer_Click(sender As Object, e As EventArgs) Handles btcFermer.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub radDaily_CheckedChanged(sender As Object, e As EventArgs) Handles radDaily.CheckedChanged
        Try

            If Me.radDaily.Checked = True Then
                Me.grpDaily.Visible = True
                Me.grpWeekly.Visible = False
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub radWeekly_CheckedChanged(sender As Object, e As EventArgs) Handles radWeekly.CheckedChanged
        Try

            If Me.radWeekly.Checked = True Then
                Me.grpWeekly.Visible = True
                Me.grpDaily.Visible = False
            End If
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub texDayFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texDayFrom.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texDayTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texDayTo.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texWeekFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texWeekFrom.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texWeekTo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texWeekTo.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texNumberOfWeeks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texNumberOfWeeks.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texNumberOfDays_KeyPress(sender As Object, e As KeyPressEventArgs) Handles texNumberOfDays.KeyPress
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcPlan_Click(sender As Object, e As EventArgs) Handles btcPlan.Click
        Try

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class