Imports MySql.Data.MySqlClient

Public Class frmResourcesTable
    Private Sub frmResourcesTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.dtpDateFrom.Value = DateSerial(Year(Today), Month(Today), 1)
            Me.dtpDateTo.Value = DateSerial(Year(Today), Month(Today) + 1, 0)

            Me.dtpDateFrom.Value = DateSerial(2020, 1, 1)
            Me.dtpDateTo.Value = DateSerial(2020, 1, 10)

            Me.dgvPlanning.Columns.Clear()

            Me.Cursor = Cursors.WaitCursor


            Dim FilterStartDate As Date = Me.dtpDateFrom.Value
            Dim FilterEndDate As Date = Me.dtpDateTo.Value
            Dim FilterCurrentDate As Date = FilterStartDate

            Dim StartHours() As Integer = {8, 9, 10, 11, 13, 14, 15, 16}
            Dim thisHour As Integer = 0

            Dim ProjectMemberForDateFilter As String = fGetProjectMemberForDateFilter(FilterStartDate, FilterEndDate)

            While FilterCurrentDate <= FilterEndDate
                For Each thisHour In StartHours


                    Console.WriteLine(FilterCurrentDate & " " & Format(thisHour, "00") & ":00")
                Next thishour
                FilterCurrentDate = DateAdd(DateInterval.Day, 1, FilterCurrentDate)

            End While




            'Dim StartTime As DateTime = Now

            pCreateDGVColumns()
            'pDisplayDGVContent()

            'Me.Cursor = Cursors.Default
            'Dim EndTime As DateTime = Now

            'MessageBox.Show(StartTime & vbCrLf & EndTime)
            'Dim StartHours() As Integer = {8, 9, 10, 11, 13, 14, 15, 16}

            'Me.dgvPlanning.Columns.Clear()

            'Dim col As New DataGridViewColumn

            'Dim thisDay As Date = Today
            'Dim MaxDay As Date = DateAdd(DateInterval.Day, 4, thisDay)

            'While thisDay < MaxDay
            '    For Each thisHour In StartHours
            '        col = New DataGridViewColumn
            '        col.HeaderText = Format(thisDay, "dd") & vbCrLf & Format(thisHour, "00") & "h00"
            '        dgvPlanning.Columns.Add(col)
            '    Next thisHour
            '    thisDay = DateAdd(DateInterval.Day, 1, thisDay)
            'End While


            'Dim myRow As New DataGridViewRow
            'Dim myID As Integer = dgvPlanning.Rows.Add()

            'myRow = dgvPlanning.Rows(myID)
            'myRow.Cells(0).Value = "valeur 0"
            'myRow.Cells(1).Value = "valeur 1"


            'Dim myRow As String() = {"1", "2", "3"}
            'dgvPlanning.Rows.Add(myRow)





            'Dim thisDGVTest1 As DataGridView = Me.dgvPlanning

            'thisDGV.Item(0, 0).Value = "0.0"
            'thisDGV.Item(0, 1).Value = "0.1"
            'thisDGV.Item(0, 2).Value = "0.2"
            'thisDGV.Item(1, 0).Value = "1.0"
            'thisDGV.Item(1, 1).Value = "1.1"
            'thisDGV.Item(1, 2).Value = "1.2"
            'thisDGV.Item(2, 0).Value = "2.0"
            'thisDGV.Item(2, 1).Value = "2.1"
            'thisDGV.Item(2, 2).Value = "2.2"

            'Dim thisTextBox As New TextBox
            'thisTextBox.Text = "Toto"



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
    Private Function fGetProjectMemberForDateFilter(FromDate As Date, ToDate As Date) As String

        Dim ProjectPlanResultString As String = ""

        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""
            Dim ProjectPlanResult As New List(Of Integer)


            SQL &= "SELECT DISTINCT ID_ProjectMember FROM planresources "
            SQL &= "LEFT JOIN projectsmembers ON CE_ID_ProjectMember = ID_ProjectMember "
            SQL &= "WHERE (PlanDate >='" & fConvertDateOnlyMySQL(FromDate) & "' "
            SQL &= "AND PlanDate <='" & fConvertDateOnlyMySQL(ToDate) & "' "
            SQL &= "AND CE_ID_ProjectMember <> 0) "
            SQL &= "ORDER BY ID_ProjectMember ASC; "


            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    ProjectPlanResult.Add(myDBDataReader.GetValue(0))
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            If ProjectPlanResult.Count > 0 Then

                ProjectPlanResultString = "{"

                For I = 0 To ProjectPlanResult.Count - 1
                    If ProjectPlanResult.Count = 1 Then
                        ProjectPlanResultString &= CStr(ProjectPlanResult(I))
                    Else
                        If Len(ProjectPlanResultString) = 1 Then
                            ProjectPlanResultString &= CStr(ProjectPlanResult(I))
                        Else
                            ProjectPlanResultString &= ", " & CStr(ProjectPlanResult(I))
                        End If
                    End If
                Next I
                ProjectPlanResultString &= "}"
            Else
                ProjectPlanResultString = "{}"
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        fGetProjectMemberForDateFilter = ProjectPlanResultString

    End Function

    Private Sub pCreateDGVColumns()

        Try

            Dim myDateFrom As Date = Me.dtpDateFrom.Value
            Dim myDateTo As Date = Me.dtpDateTo.Value

            Dim ThisIDMember As Integer = 0
            Dim FirstName As String = ""
            Dim LastName As String = ""

            Dim thisDGV As DataGridView = Me.dgvPlanning

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""


            SQL &= "SELECT DISTINCT ID_ProjectMember, FirstName, LastName FROM planresources "
            SQL &= "LEFT JOIN projectsmembers ON CE_ID_ProjectMember = ID_ProjectMember "
            SQL &= "WHERE (PlanDate >='" & fConvertDateOnlyMySQL(myDateFrom) & "' "
            SQL &= "AND PlanDate <='" & fConvertDateOnlyMySQL(myDateTo) & "' "
            SQL &= "AND CE_ID_ProjectMember <> 0) "
            SQL &= "ORDER BY ID_ProjectMember ASC; "


            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    ThisIDMember = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    FirstName = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    LastName = myDBDataReader.GetString(2)
                Catch ex As Exception
                End Try


                thisDGV.Columns.Add(ThisIDMember, FirstName & " " & LastName & " (" & ThisIDMember & ")")

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub pDisplayDGVContent()
        Try

            Dim thisDGV As DataGridView = Me.dgvPlanning

            If thisDGV.Columns.Count = 0 Then Exit Sub


            Dim myDateFrom As Date = Me.dtpDateFrom.Value
            Dim myDateTo As Date = Me.dtpDateTo.Value

            Dim thisIDResource As Integer = 0
            Dim thisPlanDate As Date = Nothing
            Dim thisHour As Integer = 0
            Dim thisCEIDProjectMember As Integer = 0
            Dim thisIDProject As Integer = 0
            Dim thisTitle As String = ""
            Dim thisIDAdminResource As Integer = 0
            Dim thisAdminResource As String = ""

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""

            SQL &= "SELECT ID_Resource, PlanDate, Hour, CE_ID_ProjectMember, ID_Project, Title, ID_AdminResource, AdminResource "
            SQL &= "FROM planresources "
            SQL &= "LEFT JOIN adminresources ON (CE_ID_AdminResource = ID_AdminResource) "
            SQL &= "LEFT JOIN projects ON (CE_ID_Project = ID_Project) "
            SQL &= "WHERE (PlanDate >='" & fConvertDateOnlyMySQL(myDateFrom) & "' "
            SQL &= "AND PlanDate <='" & fConvertDateOnlyMySQL(myDateTo) & "') "
            SQL &= "ORDER BY PlanDate, Hour, CE_ID_ProjectMember ASC; "

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    thisIDResource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    thisPlanDate = myDBDataReader.GetDateTime(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    thisHour = myDBDataReader.GetValue(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre
                Try
                    thisCEIDProjectMember = myDBDataReader.GetValue(3)
                Catch ex As Exception
                End Try

                'Lecture du 5e paramètre
                Try
                    thisIDProject = myDBDataReader.GetValue(4)
                Catch ex As Exception
                End Try

                'Lecture du 6e paramètre
                Try
                    thisTitle = myDBDataReader.GetString(5)
                Catch ex As Exception
                End Try

                'Lecture du 7e paramètre
                Try
                    thisIDAdminResource = myDBDataReader.GetValue(6)
                Catch ex As Exception
                End Try

                'Lecture du 8e paramètre
                Try
                    thisAdminResource = myDBDataReader.GetString(7)
                Catch ex As Exception
                End Try



                'Dim thisRow As New DataGridViewRow
                'thisRow.CreateCells(thisDGV)
                'thisRow.SetValues("Col 1", "Col 2", "Col 3", "Col 4", "Col 5", "Col 6")
                'thisRow.HeaderCell.Value = Format(thisPlanDate, "D") & " " & Format(thisHour, "00") & "h00"

                'If Weekday(thisPlanDate) = vbSaturday Or Weekday(thisPlanDate) = vbSunday Then
                '    thisRow.DefaultCellStyle.BackColor = Color.Gray
                'End If

                'thisDGV.Rows.Add(thisRow)

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()



            'dgvPlanning.Rows.Add(10)
            'dgvPlanning.Rows.Add()
            'dgvPlanning.Rows.Add()

            'thisDGV.Rows(0).HeaderCell.Value = Format(Today, "D") & " " & "08h00"
            'thisDGV.Rows(1).HeaderCell.Value = Format(Today, "D") & " " & "09h00"
            'thisDGV.Rows(2).HeaderCell.Value = Format(Today, "D") & " " & "10h00"

            'thisDGV.Item(1, 1).Value = "Test"


            'MessageBox.Show(thisDGV.Item(1, 1).ColumnIndex.ToString)
            'MessageBox.Show(thisDGV.Columns("1").ToString())

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcFilter_Click(sender As Object, e As EventArgs) Handles btcFilter.Click
        Try

            Dim StartTime As DateTime = Now


            Me.dgvPlanning.Columns.Clear()
            pCreateDGVColumns()
            pDisplayDGVContent()

            Dim EndTime As DateTime = Now

            MessageBox.Show(StartTime & vbCrLf & EndTime)

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class