Imports MySql.Data.MySqlClient


Public Class frmResourcesValidation



    Private Sub frmResourcesValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsVResourceToday.vplanresourcetoday' table. You can move, or remove it, as needed.
        Me.VplanresourcetodayTableAdapter.Fill(Me.DsVResourceToday.vplanresourcetoday)


        Exit Sub

        Try
            pLoadPlanResources()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub pLoadPlanResources()

        Try


            'Me.lstPlanResources.Items.Clear()

            Dim thisResource As New myPlanResource
            Dim thisProject As New myProject
            Dim thisAdmin As New myAdminResource
            Dim thisMember As New myProjectMember

            Dim Line As String = ""

            Dim Category As String = ""
            Dim ID_Category As Integer = 0

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT ID_Resource FROM PlanResources WHERE PlanDate < '" & fConvertDateOnlyMySQL(Today) & "' ORDER BY PlanDate, HalfDay ASC;"
            Dim MyDBConnection As New MySqlConnection

            SQL = ""
            SQL &= "SELECT "
            SQL &= "    planresources.ID_Resource "
            SQL &= "    , planresources.PlanDate "
            SQL &= "    , planresources.HalfDay "
            SQL &= "    , planresources.Hour "
            SQL &= "    , projectsmembers.FirstName "
            SQL &= "    , projectsmembers.LastName "
            SQL &= "    , adminresources.AdminResource "
            SQL &= "    , projects.Title "
            SQL &= "FROM "
            SQL &= "    ProjectPlan.planresources "
            SQL &= "    LEFT JOIN ProjectPlan.projectsmembers  "
            SQL &= "        ON (planresources.CE_ID_ProjectMember = projectsmembers.ID_ProjectMember) "
            SQL &= "    LEFT JOIN ProjectPlan.adminresources  "
            SQL &= "        ON (planresources.CE_ID_AdminResource = adminresources.ID_AdminResource) "
            SQL &= "    LEFT JOIN ProjectPlan.projects  "
            SQL &= "        ON (planresources.CE_ID_Project = projects.ID_Project) "
            SQL &= "WHERE (planresources.PlanDate < '" & fConvertDateOnlyMySQL(Today) & "' "
            SQL &= "    AND planresources.CE_ID_ProjectMember <>0);' "




            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                Try

                    Try
                        thisResource.ID_Resource = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try

                    thisResource.Read()

                    thisMember.ID_ProjectMember = thisResource.CE_ID_ProjectMember
                    thisMember.Read()

                    If thisResource.CE_ID_AdminResource = 0 Then
                        thisAdmin.ID_AdminResource = 0
                    Else
                        thisAdmin.ID_AdminResource = thisResource.CE_ID_AdminResource
                        thisAdmin.read()
                    End If

                    If thisResource.CE_ID_Project = 0 Then
                        thisProject.ID_Project = 0
                    Else
                        thisProject.ID_Project = thisResource.CE_ID_Project
                        thisProject.Read()
                    End If



                    Line = Format(thisResource.PlanDate, "D") & " " & Format(thisResource.Hour, "00") & ":00 " & " / " & thisMember.FullName & " / " & thisAdmin.AdminResource & " / " & thisProject.Title

                    Try
                        ID_Category = thisResource.ID_Resource
                    Catch ex As Exception
                    End Try

                    'lstPlanResources.Items.Add(Line)

                Catch ex As Exception
                    If DebugFlag = True Then MessageBox.Show(ex.ToString)
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()




        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    'Private Sub btcValidate_Click(sender As Object, e As EventArgs)

    '    Try

    '        'Dim I As Integer = 0
    '        'Dim ID_resource As String = ""
    '        'Dim thisPlanResource As New myPlanResource
    '        'Dim Count As Integer = 0

    '        'Cursor.Current = Cursors.WaitCursor

    '        'For I = 0 To chklovPlanResources.CheckedItems.Count - 1
    '        '    'If = True Then

    '        '    'On lit le membre de projet sélectionné
    '        '    ID_resource = DirectCast(chklovPlanResources.CheckedItems(I), KeyValuePair(Of String, String)).Key
    '        '    'Title = DirectCast(chklovPlanResources.Items(I), KeyValuePair(Of String, String)).Value

    '        '    thisPlanResource.ID_Resource = ID_resource
    '        '    thisPlanResource.Read()
    '        '    SetPlanToExecutedSQLTransaction(cnProjectPlan, thisPlanResource)

    '        '    'On sauve le projet avec le nouveau taux de réalisation
    '        '    Dim thisProject As New myProject
    '        '    thisProject.ID_Project = thisPlanResource.CE_ID_Project
    '        '    thisProject.Read()
    '        '    thisProject.GetEffectiveResources()
    '        '    If thisProject.EstimatedResources = 0 Then
    '        '        thisProject.ImplementationRate = 0
    '        '    Else
    '        '        thisProject.ImplementationRate = CInt(thisProject.EffectiveResources / thisProject.EstimatedResources * 100)
    '        '    End If
    '        '    thisProject.Save()

    '        '    Count = Count + 1

    '        '    'End If
    '        'Next I

    '        ''Actualisation de l'affichage
    '        'Call frmTabResources.pDisplayResourcesTable()

    '        'Cursor.Current = Cursors.Default

    '        'Select Case Count

    '        '    Case 0
    '        '        MessageBox.Show("pas de ressource validée")

    '        '    Case 1
    '        '        MessageBox.Show("1 ressource validée")

    '        '    Case >= 2
    '        '        MessageBox.Show(Count & " ressources validées")
    '        'End Select

    '    Catch ex As Exception
    '        If DebugFlag = True Then MessageBox.Show(ex.ToString)
    '    End Try

    'End Sub

    'Private Sub btcValidateAdmin_Click(sender As Object, e As EventArgs) Handles btcValidate.Click

    '    Try






    '        'Dim thisPlanResource As New myPlanResource
    '        'Dim Count As Integer = 0

    '        'Dim mySQLDataReader As MYSqlDataReader
    '        'Dim SQL As String = ""
    '        'Dim MySQLConnection As New MYSqlConnection

    '        'Cursor.Current = Cursors.WaitCursor

    '        'MySQLConnection.ConnectionString = cnProjectPlan
    '        'MySQLConnection.Open()


    '        'SQL = "SELECT ID_Resource FROM PlanResources WHERE CE_ID_AdminResource <> 0 AND "

    '        ''Si on a une date, on filtre sur la date
    '        'If Me.chkDateTo.Checked = True Then
    '        '    SQL = SQL & " PlanDate <= '" & fConvertDateOnlySQL(Me.dptDateTo.Value) & "'"
    '        'Else
    '        '    SQL = SQL & " PlanDate <= '" & fConvertDateOnlySQL(Today) & "'"
    '        'End If


    '        '''Si on a un membre de projet, on filtre sur le membre du projet
    '        ''If Me.chkProjectMember.Checked = True Then
    '        ''    'On lit le client
    '        ''    Dim ID_ProjectMember As String = DirectCast(lovProjectMembers.SelectedItem, KeyValuePair(Of String, String)).Key
    '        ''    SQL = SQL & " AND CE_ID_ProjectMember = " & ID_ProjectMember & ";"
    '        ''Else
    '        ''    SQL = SQL & ";"
    '        ''End If

    '        'Dim mySQLCommand As SqlCommand = New SqlCommand(SQL, MySQLConnection)
    '        'mySQLDataReader = mySQLCommand.ExecuteReader()

    '        'While mySQLDataReader.Read


    '        '    Try

    '        '        Try
    '        '            thisPlanResource.ID_Resource = mySQLDataReader.GetValue(0)
    '        '        Catch ex As Exception
    '        '        End Try

    '        '        thisPlanResource.Read()
    '        '        SetPlanToExecutedSQLTransaction(cnProjectPlan, thisPlanResource)
    '        '        Count = Count + 1

    '        '    Catch ex As Exception
    '        '    End Try

    '        'End While

    '        'mySQLDataReader.Close()
    '        'MySQLConnection.Close()

    '        ''Actualisation de l'affichage
    '        'Call frmTabResources.pDisplayResourcesTable()

    '        'Cursor.Current = Cursors.Default

    '        'Select Case Count

    '        '    Case 0
    '        '        MessageBox.Show("pas de ressource validée")

    '        '    Case 1
    '        '        MessageBox.Show("1 ressource validée")

    '        '    Case >= 2
    '        '        MessageBox.Show(Count & " ressources validées")
    '        'End Select


    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub SetPlanToExecutedSQLTransaction(ByVal connectionString As String, thisPlanResource As myPlanResource)

        Using connection As New MYSqlConnection(connectionString)
            connection.Open()

            Dim myDBcommand As MySqlCommand = connection.CreateCommand()
            Dim myTransaction As MySqlTransaction

            ' Start a local transaction
            myTransaction = connection.BeginTransaction("SetPlanToExecuted")

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            myDBcommand.Connection = connection
            myDBcommand.Transaction = mytransaction

            Try
                Dim SQL As String = ""
                SQL = "INSERT INTO ExecutedResources (ID_Resource,CE_ID_ProjectMember,CE_ID_Project,CE_ID_AdminResource,PlanDate,HalfDay,Timestamp) "
                SQL &= " VALUES (" & thisPlanResource.ID_Resource & "," & thisPlanResource.CE_ID_ProjectMember & ","
                SQL &= thisPlanResource.CE_ID_Project & "," & thisPlanResource.CE_ID_AdminResource & ",'" & fConvertDateonlySQL(thisPlanResource.PlanDate) & "'," & thisPlanResource.HalfDay & ",'" & fConvertDateTimeSQL(Now) & "');"
                myDBcommand.CommandText = SQL
                myDBcommand.ExecuteNonQuery()

                SQL = "DELETE FROM PlanResources WHERE ID_Resource=" & thisPlanResource.ID_Resource
                myDBcommand.CommandText = SQL
                myDBcommand.ExecuteNonQuery()

                ' Attempt to commit the transaction.
                myTransaction.Commit()
                Debug.WriteLine("Both records are written to database.")

            Catch ex As Exception
                Debug.WriteLine("Commit Exception Type: {0}", ex.GetType())
                Debug.WriteLine("  Message: {0}", ex.Message)

                ' Attempt to roll back the transaction.
                Try
                    myTransaction.Rollback()

                Catch ex2 As Exception
                    ' This catch block will handle any errors that may have occurred
                    ' on the server that would cause the rollback to fail, such as
                    ' a closed connection.
                    Debug.WriteLine("Rollback Exception Type: {0}", ex2.GetType())
                    Debug.WriteLine("  Message: {0}", ex2.Message)
                End Try
            End Try
        End Using

    End Sub

    Private Sub btcFermer_Click(sender As Object, e As EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub



    Private Sub btcValidate_Click(sender As Object, e As EventArgs) Handles btcValidate.Click

        Try

            Dim thisResource As New myPlanResource
            Dim myDBDataReader As MySqlDataReader
            Dim MyDBConnection As New MySqlConnection
            Dim Sql As String = ""
            Dim Count As Integer = 0

            If Me.chkDateTo.Checked = True Then
                Sql = "SELECT ID_Resource FROM PlanResources WHERE PlanDate <= '" & fConvertDateonlySQL(Me.dptDateTo.Value) & "' ORDER BY PlanDate, HalfDay ASC;"
            Else
                Sql = "SELECT ID_Resource FROM PlanResources WHERE PlanDate < '" & fConvertDateonlySQL(Today) & "' ORDER BY PlanDate, HalfDay ASC;"
            End If

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                Try
                    thisResource.ID_Resource = myDBDataReader.GetValue(0)
                    thisResource.Read()
                    SetPlanToExecutedSQLTransaction(cnProjectPlan, thisResource)
                    Count = Count + 1

                    If thisResource.CE_ID_Project <> 0 Then
                        Dim myProject As New myProject
                        myProject.ID_Project = thisResource.CE_ID_Project
                        myProject.Read()
                        myProject.GetEffectiveResources()
                        myProject.ImplementationRate = myProject.EffectiveResources / myProject.EstimatedResources * 100
                        myProject.Save()
                    End If

                Catch ex As Exception
                End Try
            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


            pLoadPlanResources()



            Select Case Count
                Case 0
                    MessageBox.Show("pas de ressource validée")
                Case 1
                    MessageBox.Show("1 ressource validée")
                Case >= 2
                    MessageBox.Show(Count & " ressources validées")
            End Select

        Catch ex As Exception
        End Try

    End Sub

    Private Sub btcFermer_Click_1(sender As Object, e As EventArgs) Handles btcFermer.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class