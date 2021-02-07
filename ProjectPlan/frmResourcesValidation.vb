Imports MySql.Data.MySqlClient


Public Class frmResourcesValidation



    Dim thisRow As String = ""
    Dim thisColumn As String = ""



    Private Sub frmResourcesValidation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.chkDateTo.Checked = True
            Me.dptDateTo.Value = Today

            pLoadPlanResources()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub pLoadPlanResources()

        Try

            'TODO: This line of code loads data into the 'DsVResourceToday.vplanresourcetoday' table. You can move, or remove it, as needed.
            Me.VplanresourcetodayTableAdapter.Fill(Me.DsVResourceToday.vplanresourcetoday)


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub SetPlanToExecutedSQLTransaction(ByVal connectionString As String, thisPlanResource As myPlanResource)

        Using connection As New MYSqlConnection(connectionString)
            connection.Open()

            Dim myDBcommand As MySqlCommand = connection.CreateCommand()
            Dim myTransaction As MySqlTransaction

            ' Start a local transaction
            myTransaction = connection.BeginTransaction()

            ' Must assign both transaction object and connection
            ' to Command object for a pending local transaction.
            myDBcommand.Connection = connection
            myDBcommand.Transaction = mytransaction

            Try
                Dim SQL As String = ""
                SQL = "INSERT INTO ExecutedResources (ID_Resource,CE_ID_ProjectMember,CE_ID_Project,CE_ID_AdminResource,PlanDate,Hour,Timestamp) "
                SQL &= " VALUES (" & thisPlanResource.ID_Resource & "," & thisPlanResource.CE_ID_ProjectMember & ","
                SQL &= thisPlanResource.CE_ID_Project & "," & thisPlanResource.CE_ID_AdminResource & ",'" & fConvertDateOnlyMySQL(thisPlanResource.PlanDate) & "'," & thisPlanResource.Hour & ",'" & fConvertDateTimeMySQL(Now) & "');"
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



    Private Sub btcValidate_Click(sender As Object, e As EventArgs) Handles btcValidate.Click

        Try

            Dim Count As Integer = 0


            'Si on a checké la sélection, on valide uniquement les ressources sélectionnées
            If chkSelection.Checked = True Then
                Dim ID_Resource As Integer = 0

                Dim thisResource As New myPlanResource

                For Each SelectedItem In dgvPlanResources.SelectedRows
                    'Lecture de tous les ID des rows sélectionnés
                    ID_Resource = dgvPlanResources.Item(0, SelectedItem.index).Value

                    thisResource.ID_Resource = ID_Resource
                    thisResource.Read()
                    SetPlanToExecutedSQLTransaction(cnProjectPlan, thisResource)
                    Count += 1

                Next

            End If


            'Si on n'a pas checké la sélection, on valide les ressources en fonction de la date.
            'On prend la date du jour si on pas checké la date, on prend la date indiquée si on a checké la date
            If chkSelection.Checked = False Then


                Dim thisResource As New myPlanResource
                Dim myDBDataReader As MySqlDataReader
                Dim MyDBConnection As New MySqlConnection
                Dim Sql As String = ""

                If Me.chkDateTo.Checked = True Then
                    Sql = "SELECT ID_Resource FROM PlanResources WHERE PlanDate <= '" & fConvertDateOnlyMySQL(Me.dptDateTo.Value) & "' ORDER BY PlanDate, Hour ASC;"
                Else
                    Sql = "SELECT ID_Resource FROM PlanResources WHERE PlanDate < '" & fConvertDateOnlyMySQL(Today) & "' ORDER BY PlanDate, Hour ASC;"
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

                        'On ne compte que les ressources attribuées à une personne, pas les ressources comprises dans l'horizon
                        If thisResource.CE_ID_ProjectMember <> 0 Then
                            Count += 1
                        End If

                        'If thisResource.CE_ID_Project <> 0 Then
                        '    Dim myProject As New myProject
                        '    myProject.ID_Project = thisResource.CE_ID_Project
                        '    myProject.Read()
                        '    myProject.GetEffectiveResources()
                        '    myProject.ImplementationRate = myProject.EffectiveResources / myProject.EstimatedResources * 100
                        '    myProject.Save()
                        'End If

                    Catch ex As Exception
                    End Try
                End While

                myDBDataReader.Close()
                MyDBConnection.Close()

            End If


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

    Private Sub btcFermer_Click(sender As Object, e As EventArgs) Handles btcFermer.Click

        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub



    Private Sub chkSelection_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelection.CheckedChanged
        Try
            If chkSelection.Checked = True And chkDateTo.Checked = True Then
                Me.chkDateTo.Checked = False
            End If
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub chkDateTo_CheckedChanged(sender As Object, e As EventArgs) Handles chkDateTo.CheckedChanged
        Try
            If chkDateTo.Checked = True And chkSelection.Checked = True Then
                Me.chkSelection.Checked = False
            End If
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class