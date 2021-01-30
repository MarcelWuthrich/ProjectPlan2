'Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient



Public Class frmProjectsList

    Private Sub frmProjectsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            'Polulate des statuts
            pPopulateFilterStatus()

            'Polulate des categories
            pPopulateFilterCategory()


            'Défintion des valeurs de filtres par défaut (suppression des filtres)
            Me.chkAllProjects.Checked = False
            Call btcFilterClear_Click(sender, e)


            Me.WindowState = FormWindowState.Maximized

            pRefreshDisplay()
            dgvProjets.Rows(0).Selected = True


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pFilterDGV()

        Try

            Dim ProjectDisplayedCount As Integer = 0

            'On lit le status
            Dim ID_Status As Integer = Val(DirectCast(lovFilterStatus.SelectedItem, KeyValuePair(Of String, String)).Key)

            'On lit la catégorie
            Dim ID_Category As Integer = Val(DirectCast(lovFilterCategory.SelectedItem, KeyValuePair(Of String, String)).Key)

            Dim myFilter As String = ""
            Dim bs As New BindingSource
            bs = VprojectlistBindingSource

            'Filtre selon le texte
            myFilter = "(title like '%" & Me.texFilter.Text & "%' OR description like '%" & Me.texFilter.Text & "%') "

            'On regarde s'il faut afficher les projets actifs (ID_Status < 10) ou tous les projets
            If chkAllProjects.Checked = False Then
                myFilter &= " AND CE_ID_Status < 10 "
            End If

            'On regarde s'il faut filtrer les statuts (<>0)
            If ID_Status <> 0 Then
                myFilter &= " AND CE_ID_Status = " & ID_Status & " "
            End If

            'On regarde s'il faut filtrer les catégories (<>0)
            If ID_Category <> 0 Then
                myFilter &= " AND CE_ID_Category = " & ID_Category & " "
            End If

            bs.Filter = myFilter

            dgvProjets.DataSource = bs

            'Recherche du nombre total de projets
            Dim myProject As New myProject
            Dim TotalProjectNumber As Integer = myProject.Count()

            'Affiche le nombre  de projets dans la liste et le nombre total de projets
            Me.labProjectsNumber.Text = "Projects : " & dgvProjets.RowCount & "/" & TotalProjectNumber

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub pPopulateFilterStatus()

        Try

            Me.lovFilterStatus.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Status, Status FROM Status WHERE Enable = 1 ORDER BY DisplayOrder ASC ;"
            Dim MyDBConnection As New MySqlConnection

            Dim Status As String = ""
            Dim ID_Status As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'On insère une ligne vide
            myDictionnary.Add(Str(0), "")

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read


                Try
                    ID_Status = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Status = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Status), Status)

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.lovFilterStatus.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovFilterStatus.DisplayMember = "Value"
            Me.lovFilterStatus.ValueMember = "Key"

            Me.lovFilterStatus.SelectedIndex = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub pPopulateFilterCategory()

        Try

            Me.lovFilterCategory.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Category, Category FROM ProjectCategories WHERE Enable = 1 ORDER BY DisplayOrder ASC ;"
            Dim MyDBConnection As New MySqlConnection

            Dim Category As String = ""
            Dim ID_Category As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'On insère une ligne vide
            myDictionnary.Add(Str(0), "")

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read


                Try
                    ID_Category = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Category = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Category), Category)

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.lovFilterCategory.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovFilterCategory.DisplayMember = "Value"
            Me.lovFilterCategory.ValueMember = "Key"

            Me.lovFilterCategory.SelectedIndex = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcFilter_Click(sender As Object, e As EventArgs) Handles btcFilter.Click
        Try

            pFilterDGV()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub dgvProjets_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

        Try

            dgvProjets.Rows(dgvProjets.CurrentCell.RowIndex).Selected = True
            ID_Project_Current = dgvProjets.Item(0, dgvProjets.CurrentCell.RowIndex).Value

            Dim myForm As Form = frmProjectDetails
            myForm.Show()
            myForm.Dispose()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btcFilterClear_Click(sender As Object, e As EventArgs) Handles btcFilterClear.Click

        Try

            Me.texFilter.Text = ""
            Me.lovFilterStatus.SelectedIndex = 0
            Me.lovFilterCategory.SelectedIndex = 0
            Me.chkAllProjects.Checked = False

            pFilterDGV()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub chkAllProjects_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllProjects.CheckedChanged

        Try
            'On filtre les données
            'pFilterDGV()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcClose_Click(sender As Object, e As EventArgs) Handles btcClose.Click

        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcAddProject_Click(sender As Object, e As EventArgs) Handles btcAddProject.Click
        Try


            ID_Project_Current = 0


            Dim myForm As Form = frmProjectDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pRefreshDisplay()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcModifyProject_Click(sender As Object, e As EventArgs) Handles btcModifyProject.Click
        Try

            Dim RowSelected As Integer = dgvProjets.CurrentCell.RowIndex

            Dim myForm As Form = frmProjectDetails
            myForm.ShowDialog()
            myForm.Dispose()

            pRefreshDisplay()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Private Sub dgvProjets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjets.CellClick
        Try

            dgvProjets.Rows(dgvProjets.CurrentCell.RowIndex).Selected = True
            ID_Project_Current = dgvProjets.Rows(dgvProjets.CurrentRow.Index).Cells(0).Value


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pRefreshDisplay()
        Try
            Me.VprojectlistTableAdapter.Fill(Me.DsProjectsList.vprojectlist)
            dgvProjets.Rows(0).Selected = True
            ID_Project_Current = dgvProjets.Rows(dgvProjets.CurrentRow.Index).Cells(0).Value

            pFilterDGV()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjets_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjets.CellContentClick

    End Sub
End Class