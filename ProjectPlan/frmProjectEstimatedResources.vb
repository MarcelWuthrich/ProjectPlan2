Imports MySql.Data.MySqlClient

Public Class frmProjectEstimatedResources
    Private Sub frmProjectPlanResources_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim thisProject As New myProject
            Dim thisResource As New myEstimatedResource
            Dim ID As Integer = 0

            thisProject.ID_Project = ID_Project_Current
            thisProject.Read()

            thisResource.ID_Resource = ID_Resource_Current
            thisResource.Read()

            pPopulateTasks()

            Me.texID_Project.Text = thisProject.ID_Project
            Me.texProjectTitle.Text = thisProject.Title
            Me.texEstimatRedesource.Text = thisResource.EstimatedResource

            'Tâche
            For I = 0 To lovTasks.Items.Count - 1
                ID = DirectCast(lovTasks.Items(I), KeyValuePair(Of String, String)).Key
                If thisResource.CE_ID_Task = ID Then
                    Me.lovTasks.SelectedIndex = I
                    Exit For
                End If
            Next I



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pPopulateTasks()

        Try

            Me.lovTasks.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Task, Task FROM Tasks WHERE Enable = 1 ORDER BY DisplayOrder ASC ;"
            Dim MyDBConnection As New MySqlConnection

            Dim Task As String = ""
            Dim ID_Task As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'On insère une ligne vide
            myDictionnary.Add(Str(0), "")

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read


                Try
                    ID_Task = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Task = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Task), Task)

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.lovTasks.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovTasks.DisplayMember = "Value"
            Me.lovTasks.ValueMember = "Key"

            Me.lovTasks.SelectedIndex = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub BtcCancel_Click(sender As Object, e As EventArgs) Handles BtcCancel.Click
        Try

            Me.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcOK_Click(sender As Object, e As EventArgs) Handles btcOK.Click
        Try

            Dim thisResource As New myEstimatedResource

            thisResource.ID_Resource = ID_Resource_Current
            thisResource.Read()

            thisResource.CE_ID_Project = ID_Project_Current
            thisResource.EstimatedResource = Me.texEstimatRedesource.Text

            'On lit la catégorie
            Dim ID_Task As String = DirectCast(lovTasks.SelectedItem, KeyValuePair(Of String, String)).Key
            thisResource.CE_ID_Task = ID_Task

            thisResource.Save()

            ID_Resource_Current = thisResource.ID_Resource

            Me.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class