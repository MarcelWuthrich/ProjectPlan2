'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class frmProjectDetails

    Dim thisProject As New myProject
    Dim ID_ProjectEstimatedResource As Integer = 0

    Private Sub btcAnnuler_Click(sender As Object, e As EventArgs) Handles btcAnnuler.Click

        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcOK_Click(sender As Object, e As EventArgs) Handles btcOK.Click

        Try
            'On définit une nouvelle variable de type myProjet
            Dim thisProject As New myProject

            'On lit la priorité
            Dim ID_Priority As String = DirectCast(lovPriority.SelectedItem, KeyValuePair(Of String, String)).Key

            'On lit l'urgence
            Dim ID_Urgency As String = DirectCast(lovUrgency.SelectedItem, KeyValuePair(Of String, String)).Key

            'On lit le client
            Dim ID_Customer As String = DirectCast(lovCustomer.SelectedItem, KeyValuePair(Of String, String)).Key

            'On lit le chef de projet
            Dim ID_ProjectManager As String = DirectCast(lovProjectManager.SelectedItem, KeyValuePair(Of String, String)).Key

            'On lit la catégorie
            Dim ID_Category As String = DirectCast(lovProjectCategory.SelectedItem, KeyValuePair(Of String, String)).Key

            'On lit le statut
            Dim ID_Status As String = DirectCast(lovStatus.SelectedItem, KeyValuePair(Of String, String)).Key


            'On lit des données des champs texte
            thisProject.ID_Project = Val(Me.texID_Project.Text)
            thisProject.Title = Me.texTitre.Text
            thisProject.Description = Me.texDescription.Text
            thisProject.CE_ID_ProjectManager = Me.lovProjectManager.SelectedIndex
            thisProject.BeginDate = Me.dtpBegin.Value
            thisProject.DeadLine = Me.dtpDeadline.Value
            'thisProject.ImplementationRate = Me.texImplementationRate.Text
            thisProject.EstimatedResources = Me.texEstimatedResources.Text
            thisProject.CE_ID_Priority = ID_Priority
            thisProject.CE_ID_Category = ID_Category
            thisProject.CE_ID_Customer = ID_Customer
            thisProject.CE_ID_Urgency = ID_Urgency
            thisProject.CE_ID_Status = ID_Status
            thisProject.CE_ID_ProjectManager = ID_ProjectManager



            ID_Project_Current = thisProject.ID_Project
            thisProject.Save()

            ID_Project_Current = 0

            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub frmProjectDetails_Close(sender As Object, e As EventArgs) Handles MyBase.Closing

        Try

            ID_Project_Current = 0

        Catch ex As Exception

            If Me.texID_Project.Text = "0" Then Me.texID_Project.Text = ""

        End Try

    End Sub

    Private Sub frmProjectDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsProjectEstimatedResources.vprojectestimatedresources' table. You can move, or remove it, as needed.
        Me.VprojectestimatedresourcesTableAdapter.Fill(Me.DsProjectEstimatedResources.vprojectestimatedresources)

        pDisplayProjectEstimatedResources()

        Dim ID As Integer = 0

        Try

            'on définit les status
            pPopulateStatus()

            'on définit les chefs de projets
            pPopulateProjectManager()

            'on définit les chefs de projets
            pPopulateCustomer()

            'On définit les priorités
            pPopulateProjectPriority()

            'On définit les urgences
            pPopulateProjectUrgencies()

            'On définit les catégories
            pPopulateProjectCategories()


            'On lit les informations du projet
            thisProject.ID_Project = ID_Project_Current
            thisProject.Read()
            'thisProject.GetEffectiveResources()

            'On cherche le nombre de jours planifés
            'Dim thisResource As New myPlanResource
            'If ID_Project_Current <> 0 Then
            '    thisResource.CE_ID_Project = thisProject.ID_Project
            '    thisResource.Get_Count_PlanResource_From_CE_ID_Project()
            'End If


            'On renseigne les champs 
            Me.texID_Project.Text = thisProject.ID_Project
            Me.texTitre.Text = thisProject.Title
            Me.dtpBegin.Text = thisProject.BeginDate
            Me.dtpDeadline.Text = thisProject.DeadLine
            Me.texDescription.Text = thisProject.Description
            Me.texEstimatedResources.Text = thisProject.EstimatedResources
            Me.texImplementationRate.Text = thisProject.ImplementationRate
            Me.texExecutedResources.Text = Format(thisProject.EffectiveResources, "0.0")
            'Me.texPlanResources.Text = Format(thisResource.CountPlanResource, "0.0")



            'Chefs de projets
            For I = 0 To lovProjectManager.Items.Count - 1
                ID = DirectCast(lovProjectManager.Items(I), KeyValuePair(Of String, String)).Key
                If thisProject.CE_ID_ProjectManager = ID Then
                    Me.lovProjectManager.SelectedIndex = I
                    Exit For
                End If
            Next I

            'Status
            For I = 0 To lovStatus.Items.Count - 1
                ID = DirectCast(lovStatus.Items(I), KeyValuePair(Of String, String)).Key
                If thisProject.CE_ID_Status = ID Then
                    Me.lovStatus.SelectedIndex = I
                    Exit For
                End If
            Next I

            'Priorité
            For I = 0 To lovPriority.Items.Count - 1
                ID = DirectCast(lovPriority.Items(I), KeyValuePair(Of String, String)).Key
                If thisProject.CE_ID_Priority = ID Then
                    Me.lovPriority.SelectedIndex = I
                    Exit For
                End If
            Next I

            'Urgence
            For I = 0 To lovUrgency.Items.Count - 1
                ID = DirectCast(lovUrgency.Items(I), KeyValuePair(Of String, String)).Key
                If thisProject.CE_ID_Urgency = ID Then
                    Me.lovUrgency.SelectedIndex = I
                    Exit For
                End If
            Next I

            'Catégorie
            For I = 0 To lovProjectCategory.Items.Count - 1
                ID = DirectCast(lovProjectCategory.Items(I), KeyValuePair(Of String, String)).Key
                If thisProject.CE_ID_Category = ID Then
                    Me.lovProjectCategory.SelectedIndex = I
                    Exit For
                End If
            Next I

            'Client
            For I = 0 To lovCustomer.Items.Count - 1
                ID = DirectCast(lovCustomer.Items(I), KeyValuePair(Of String, String)).Key
                If thisProject.CE_ID_Customer = ID Then
                    Me.lovCustomer.SelectedIndex = I
                    Exit For
                End If
            Next I

            If Me.texID_Project.Text = "0" Then Me.texID_Project.Text = ""

        Catch ex As Exception

        End Try
    End Sub

    Private Sub pPopulateStatus()

        Try

            Me.lovStatus.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Status, Status FROM Status where enable = 1 order by DisplayOrder ASC;"
            Dim MyDBConnection As New MySqlConnection

            Dim Status As String = ""
            Dim ID_Status As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'Le premier enregistrement est une ligne vide
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

            Me.lovStatus.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovStatus.DisplayMember = "Value"
            Me.lovStatus.ValueMember = "Key)"

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub pPopulateProjectPriority()

        Try

            Me.lovPriority.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Priority, Priority FROM ProjectPriority where enable = 1 order by DisplayOrder ASC;"
            Dim MyDBConnection As New MySqlConnection

            Dim Priority As String = ""
            Dim ID_Priority As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'Le premier enregistrement est une ligne vide
            myDictionnary.Add(Str(0), "")

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                Try
                    ID_Priority = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Priority = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Priority), Priority)

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.lovPriority.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovPriority.DisplayMember = "Value"
            Me.lovPriority.ValueMember = "Key)"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub pPopulateProjectManager()

        Try

            Me.lovProjectManager.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_ProjectManager, FirstName, Lastname FROM ProjectManagers where Enable = 1 ;"
            Dim MyDBConnection As New MySqlConnection

            Dim PM As String = ""
            Dim ID_Projectmanagery As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            Dim FirstName As String = ""
            Dim LastName As String = ""

            'Le premier enregistrement est une ligne vide
            myDictionnary.Add(Str(0), "")


            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read


                Try
                    ID_ProjectManager = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    FirstName = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                Try
                    LastName = myDBDataReader.GetString(2)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_ProjectManager), LastName & " " & FirstName)

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.lovProjectManager.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovProjectManager.DisplayMember = "Value"
            Me.lovProjectManager.ValueMember = "Key)"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub pPopulateProjectCategories()

        Try

            Me.lovProjectCategory.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Category, Category FROM ProjectCategories WHERE Enable = 1 ORDER BY DisplayOrder ASC ;"
            Dim MyDBConnection As New MySqlConnection

            Dim Category As String = ""
            Dim ID_Category As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'Le premier enregistrement est une ligne vide
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

            Me.lovProjectCategory.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovProjectCategory.DisplayMember = "Value"
            Me.lovProjectCategory.ValueMember = "Key"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub texEstimatedResources_LostFocus(sender As Object, e As EventArgs)

        Try

            If Val(Me.texEstimatedResources.Text) = 0 Then
                Me.texImplementationRate.Text = "0"
            Else
                Me.texImplementationRate.Text = CInt(thisProject.EffectiveResources / Me.texEstimatedResources.Text * 100)
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub pPopulateCustomer()

        Try

            Me.lovCustomer.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Customer, Lastname, Firstname FROM Customers where enable = 1 order by DisplayOrder ASC;"
            Dim MyDBConnection As New MySqlConnection

            Dim Lastname As String = ""
            Dim Firstname As String = ""
            Dim ID_Client As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'Le premier enregistrement est une ligne vide
            myDictionnary.Add(Str(0), "")

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read



                Try
                    ID_Client = MydbDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Lastname = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                Try
                    Firstname = myDBDataReader.GetString(2)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Client), Lastname & " " & Firstname)

            End While

            Me.lovCustomer.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovCustomer.DisplayMember = "Value"
            Me.lovCustomer.ValueMember = "Key)"

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub pPopulateProjectUrgencies()

        Try

            Me.lovUrgency.Items.Clear()

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Urgency, Urgency FROM Urgencies where enable = 1 order by DisplayOrder ASC;"
            Dim MyDBConnection As New MySqlConnection

            Dim Urgency As String = ""
            Dim ID_Urgency As Integer = 0
            Dim myDictionnary As New Dictionary(Of String, String)()

            'Le premier enregistrement est une ligne vide
            myDictionnary.Add(Str(0), "")

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                Try
                    ID_Urgency = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Try
                    Urgency = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                myDictionnary.Add(Str(ID_Urgency), Urgency)

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.lovUrgency.DataSource = New BindingSource(myDictionnary, Nothing)
            Me.lovUrgency.DisplayMember = "Value"
            Me.lovUrgency.ValueMember = "Key"

        Catch ex As Exception

        End Try

    End Sub



    Private Sub dgvProjectRemarks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectRemarks.CellDoubleClick
        Try

            dgvProjectRemarks.Rows(dgvProjectRemarks.CurrentCell.RowIndex).Selected = True
            ID_Remark = dgvProjectRemarks.Item(0, dgvProjectRemarks.CurrentCell.RowIndex).Value

            'Dim myForm As Form = frmProjectRemarkText
            'myForm.ShowDialog()
            'myForm.Dispose()

            'pDisplayRemarks()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcRessourceAdd_Click(sender As Object, e As EventArgs) Handles btcRessourceAdd.Click
        Try

            'On ajoute une ressource, l'ID de la nouvlle ressource n'est pas encore connue
            ID_Resource_Current = 0

            Dim myForm As Form = frmProjectEstimatedResources
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectEstimatedResources()

            'Dernière opération avant la fin
            ID_Resource_Current = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayProjectEstimatedResources()
        Try

            'TODO: This line of code loads data into the 'ProjectplanDataSet1.vprojectestimatedresources' table. You can move, or remove it, as needed.
            Me.VprojectestimatedresourcesTableAdapter.Fill(Me.DsProjectEstimatedResources.vprojectestimatedresources)
            dgvProjectRessources.Rows(dgvProjectRessources.CurrentCell.RowIndex).Selected = True
            ID_Resource_Current = dgvProjectRessources.Rows(dgvProjectRessources.CurrentRow.Index).Cells(0).Value

            Dim thisResource As New myEstimatedResource
            thisResource.ID_Resource = ID_Resource_Current
            thisResource.Read()

            Me.texEstimatedResources.Text = thisResource.GetEstimatedResources_CE_ID_Project()

            Dim bs As New BindingSource
            bs = VprojectestimatedresourcesBindingSource
            bs.Filter = "CE_ID_Project=" & ID_Project_Current

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcRessourceModify_Click(sender As Object, e As EventArgs) Handles btcRessourceModify.Click
        Try

            Dim myForm As Form = frmProjectEstimatedResources
            myForm.ShowDialog()
            myForm.Dispose()

            pDisplayProjectEstimatedResources()

            'Dernière opération avant la fin
            ID_Resource_Current = 0

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvProjectRessources_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectRessources.CellClick
        Try
            dgvProjectRessources.Rows(dgvProjectRessources.CurrentCell.RowIndex).Selected = True
            ID_Resource_Current = dgvProjectRessources.Rows(dgvProjectRessources.CurrentRow.Index).Cells(0).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvProjectRemarks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjectRemarks.CellClick
        Try

            dgvProjectRemarks.Rows(dgvProjectRemarks.CurrentCell.RowIndex).Selected = True
            ID_Remark = dgvProjectRemarks.Item(0, dgvProjectRemarks.CurrentCell.RowIndex).Value

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class