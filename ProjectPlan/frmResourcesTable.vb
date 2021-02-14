Imports MySql.Data.MySqlClient


Public Class frmResourcesTable


    Dim thisRow As String = ""
    Dim thisColumn As String = ""


    Private Sub frmResourcesTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LOAD : avant que la fenêtre soit visible
        Try

            'Dim myDateFrom As Date = New Date(2021, 1, 5)
            Dim myDateFrom As Date = Today

            Dim myDateTo As Date = DateAdd(DateInterval.Day, 10, myDateFrom)

            Me.dtpDateFrom.Value = myDateFrom
            Me.dtpDateTo.Value = myDateTo



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
    Private Function fGetProjectMemberForDateFilter(FromDate As Date, ToDate As Date) As List(Of Integer)

        Dim myMemberList As New List(Of Integer)


        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""

            'On affiche uniquement les membres de projets qui ont des ressources planifiées pour la période données
            'SQL &= "SELECT DISTINCT ID_ProjectMember FROM planresources "
            'SQL &= "LEFT JOIN projectsmembers ON CE_ID_ProjectMember = ID_ProjectMember "
            'SQL &= "WHERE (PlanDate >='" & fConvertDateOnlyMySQL(FromDate) & "' "
            'SQL &= "AND PlanDate <='" & fConvertDateOnlyMySQL(ToDate) & "' "
            'SQL &= "AND CE_ID_ProjectMember <> 0) "
            'SQL &= "ORDER BY ID_ProjectMember ASC; "


            'On affiche tous les membres de projets, qu'ils aient des ressources planifiées ou non 
            SQL = "SELECT ID_ProjectMember, FirstName, LastName FROM ProjectsMembers WHERE Enable = 1 ORDER BY ID_ProjectMember ASC ;"


            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    myMemberList.Add(myDBDataReader.GetValue(0))
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Dim myResponse As Integer() = myMemberList.ToArray

        fGetProjectMemberForDateFilter = myMemberList

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

            Me.dgvPlanning.Columns.Clear()

            'On affiche uniquement les membres de projets qui ont des ressources planifiées pour la période données
            'SQL &= "SELECT DISTINCT ID_ProjectMember, FirstName, LastName FROM planresources "
            'SQL &= "LEFT JOIN projectsmembers ON CE_ID_ProjectMember = ID_ProjectMember "
            'SQL &= "WHERE (PlanDate >='" & fConvertDateOnlyMySQL(myDateFrom) & "' "
            'SQL &= "AND PlanDate <='" & fConvertDateOnlyMySQL(myDateTo) & "' "
            'SQL &= "AND CE_ID_ProjectMember <> 0) "
            'SQL &= "ORDER BY ID_ProjectMember ASC; "



            'On affiche tous les membres de projets, qu'ils aient des ressources planifiées ou non 
            SQL = "SELECT ID_ProjectMember, FirstName, LastName FROM ProjectsMembers WHERE Enable = 1 ORDER BY ID_ProjectMember ASC ;"

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

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


                'thisDGV.Columns.Add(ThisIDMember, FirstName & " " & LastName & " (" & ThisIDMember & ")")
                thisDGV.Columns.Add(ThisIDMember, FirstName & " " & LastName)

            End While

            For I = 0 To dgvPlanning.ColumnCount - 1
                thisDGV.Columns(I).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                thisDGV.Columns(I).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Next


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



            Dim myAdminResource As String = ""
            Dim myProject As String = ""

            Dim myRow As Integer = 0
            Dim myCol As Integer = 0
            Dim ThisDateTime As DateTime = Nothing


            'Me.dtpDateFrom.Value = DateSerial(Year(Today), Month(Today), 1)
            'Me.dtpDateTo.Value = DateSerial(Year(Today), Month(Today) + 1, 0)

            'Me.dgvPlanning.Columns.Clear()


            Dim FilterStartDate As Date = Me.dtpDateFrom.Value
            Dim FilterEndDate As Date = Me.dtpDateTo.Value
            Dim thisCurrentDate As Date = FilterStartDate

            Dim StartHours As New List(Of Integer)
            StartHours.Add(8)
            StartHours.Add(9)
            StartHours.Add(10)
            StartHours.Add(11)
            StartHours.Add(13)
            StartHours.Add(14)
            StartHours.Add(15)
            StartHours.Add(16)
            Dim thisHour As Integer = 0

            Dim ProjectMemberForDateFilterList As List(Of Integer) = fGetProjectMemberForDateFilter(FilterStartDate, FilterEndDate)
            Dim thisMember As Integer = 0



            'Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)





            Dim MyDBConnection As New MySqlConnection

            Dim SQL As String = ""

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()


            While thisCurrentDate <= FilterEndDate
                For Each thisHour In StartHours

                    ThisDateTime = New DateTime(Year(thisCurrentDate), Month(thisCurrentDate), Microsoft.VisualBasic.Day(thisCurrentDate), thisHour, 0, 0)
                    dgvPlanning.Rows.Add()
                    'dgvPlanning.Rows(myRow).HeaderCell.Value = Format(thisCurrentDate, "D") & " " & Format(thisHour, "00") & ":00"
                    dgvPlanning.Rows(myRow).HeaderCell.Value = ThisDateTime.ToString

                    If Weekday(thisCurrentDate) = vbSaturday Or Weekday(thisCurrentDate) = vbSunday Then
                        dgvPlanning.Rows(myRow).DefaultCellStyle.BackColor = Color.LightGray
                    End If


                    For Each thisMember In ProjectMemberForDateFilterList

                        SQL = ""
                        SQL &= " SELECT planresources.ID_Resource,"
                        SQL &= " planresources.CE_ID_ProjectMember,"
                        SQL &= " planresources.CE_ID_Project,"
                        SQL &= " planresources.CE_ID_AdminResource,"
                        SQL &= " planresources.PlanDate,"
                        SQL &= " planresources.Hour,"
                        SQL &= " projects.Title,"
                        SQL &= " adminresources.AdminResource"
                        SQL &= " FROM planresources"
                        SQL &= " LEFT JOIN adminresources ON (planresources.CE_ID_AdminResource=adminresources.ID_AdminResource)"
                        SQL &= " LEFT JOIN projects ON (planresources.CE_ID_Project=projects.ID_Project)"
                        SQL &= " WHERE planresources.PlanDate='" & fConvertDateOnlyMySQL(thisCurrentDate) & "' AND planresources.Hour = " & thisHour & " AND planresources.CE_ID_ProjectMember=" & thisMember & ";"


                        Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
                        Dim myDBDataReader As MySqlDataReader
                        myDBDataReader = myDBCommand.ExecuteReader()

                        While myDBDataReader.Read

                            myProject = ""
                            myAdminResource = ""

                            'Lecture du premier paramètre
                            Try
                                myProject = myDBDataReader.GetString(6)
                            Catch ex As Exception
                            End Try
                            Try
                                myAdminResource = myDBDataReader.GetString(7)

                            Catch ex As Exception
                            End Try

                            Dim msg As String = ""
                            msg &= "myCol: " & myCol
                            msg &= ", myRow: " & myRow
                            msg &= ", Col count: " & dgvPlanning.ColumnCount
                            msg &= ", Row count: " & dgvPlanning.RowCount

                            Console.WriteLine(msg)

                            If myProject <> "" Then
                                dgvPlanning.Item(myCol, myRow).Value = myProject
                                dgvPlanning.Item(myCol, myRow).Style.BackColor = Color.LightGreen
                            End If
                            If myAdminResource <> "" Then
                                dgvPlanning.Item(myCol, myRow).Value = myAdminResource
                                dgvPlanning.Item(myCol, myRow).Style.BackColor = Color.LightYellow
                            End If



                        End While
                        myDBDataReader.Close()


                        myCol += 1
                    Next thisMember

                    myCol = 0
                    myRow += 1
                Next thisHour

                thisCurrentDate = DateAdd(DateInterval.Day, 1, thisCurrentDate)

            End While

            MyDBConnection.Close()






        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcFilter_Click(sender As Object, e As EventArgs) Handles btcFilter.Click
        Try

            Me.Cursor = Cursors.WaitCursor

            Me.dgvPlanning.Columns.Clear()

            pCreateDGVColumns()

            pDisplayDGVContent()

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub




    Private Sub dgvPlanning_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgvPlanning.MouseUp
        Try
            If e.Button <> MouseButtons.Right Then Return

            Dim cms = New ContextMenuStrip

            'Pour détermine la cellule sélectionnée
            Dim ht As DataGridView.HitTestInfo
            ht = Me.dgvPlanning.HitTest(e.X, e.Y)
            thisRow = ht.RowIndex
            thisColumn = ht.ColumnIndex

            Dim _row As Integer = CInt(thisRow)
            Dim _col As Integer = CInt(thisColumn)
            Me.dgvPlanning.CurrentCell = Me.dgvPlanning(_col, _row)

            Dim item1 = cms.Items.Add("Effacer")
            item1.Tag = 1
            AddHandler item1.Click, AddressOf menuChoice

            Dim item2 = cms.Items.Add("Insérer une/des tâche/s administrative/s")
            item2.Tag = 2
            AddHandler item2.Click, AddressOf menuChoice

            Dim item3 = cms.Items.Add("Insérer un/des projet/s")
            item3.Tag = 3
            AddHandler item3.Click, AddressOf menuChoice

            Dim item4 = cms.Items.Add(StrDup(20, Chr(151)))
            item4.Tag = 4
            AddHandler item4.Click, AddressOf menuChoice

            Dim item5 = cms.Items.Add("Bloquer une/des date/s --> pas encore implémenté")
            item5.Tag = 5
            AddHandler item5.Click, AddressOf menuChoice

            Dim item6 = cms.Items.Add("Débloquer une/des date/s --> pas encore implémenté")
            item6.Tag = 6
            AddHandler item6.Click, AddressOf menuChoice

            Dim item7 = cms.Items.Add(StrDup(20, Chr(151)))
            item7.Tag = 7
            AddHandler item7.Click, AddressOf menuChoice

            Dim item8 = cms.Items.Add("Ajouter une/des remarque/s --> pas encore implémenté")
            item8.Tag = 8
            AddHandler item8.Click, AddressOf menuChoice

            Dim item9 = cms.Items.Add("Effacer une/des remarque/s --> pas encore implémenté")
            item9.Tag = 9
            AddHandler item9.Click, AddressOf menuChoice

            '-- etc
            '..

            cms.Show(dgvPlanning, e.Location)


        Catch ex As Exception

        End Try
    End Sub





    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim item = CType(sender, ToolStripMenuItem)
            Dim selection = CInt(item.Tag)

            If selection = 1 Then
                'Effacer les cellules sélectionnées
                pDeleteSelectedCells()
            End If

            If selection = 2 Then
                'Insérer une tâche administrative
                pAddAdministrativeTask()
            End If

            If selection = 3 Then
                'Insérer un projet
                pAddProject()
            End If


            pCreateDGVColumns()
            pDisplayDGVContent()




        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub frmResourcesTable_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'SHOWN : après que la fenêtre soit visible

        Try

            Me.Cursor = Cursors.WaitCursor

            pCreateDGVColumns()

            pDisplayDGVContent()

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub pDeleteSelectedCells()
        Try

            Dim myDGV As DataGridView = Me.dgvPlanning
            Dim mySelectedCells As DataGridViewSelectedCellCollection
            Dim myCell As DataGridViewCell
            Dim mySelectedColumns As DataGridViewTextBoxColumn

            Dim thisID_ProjectMember As Integer = 0
            Dim thisDate As DateTime

            Dim thisResource As myPlanResource = Nothing


            mySelectedCells = myDGV.SelectedCells


            For Each myCell In mySelectedCells
                Dim myRow As Integer = myCell.RowIndex
                Dim myCol As Integer = myCell.ColumnIndex

                mySelectedColumns = myDGV.Columns(myCol)
                thisID_ProjectMember = CInt(mySelectedColumns.Name)

                thisDate = myDGV.Rows(myRow).HeaderCell.Value

                thisResource = New myPlanResource
                thisResource.CE_ID_ProjectMember = thisID_ProjectMember
                thisResource.Hour = CInt(Hour(thisDate))
                thisResource.PlanDate = thisDate
                thisResource.Delete_From_ID_ProjectMember_And_DateTime()


            Next myCell



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pAddAdministrativeTask()
        Try


            Dim myDGV As DataGridView = Me.dgvPlanning
            Dim mySelectedCells As DataGridViewSelectedCellCollection
            Dim myCell As DataGridViewCell
            Dim mySelectedColumns As DataGridViewTextBoxColumn

            Dim thisID_ProjectMember As Integer = 0
            Dim thisDate As DateTime

            Dim thisResource As myPlanResource = Nothing


            mySelectedCells = myDGV.SelectedCells

            'On reset la variable globale
            G_ID_ResourceAdmin = 0

            'On affiche la fenêtre des ressouces administratives
            Dim myForm As Form = frmResourceAdminList
            myForm.ShowDialog()
            myForm.Dispose()


            For Each myCell In mySelectedCells
                Dim myRow As Integer = myCell.RowIndex
                Dim myCol As Integer = myCell.ColumnIndex

                mySelectedColumns = myDGV.Columns(myCol)
                thisID_ProjectMember = CInt(mySelectedColumns.Name)

                thisDate = myDGV.Rows(myRow).HeaderCell.Value

                thisResource = New myPlanResource
                thisResource.CE_ID_ProjectMember = thisID_ProjectMember
                thisResource.Hour = CInt(Hour(thisDate))
                thisResource.PlanDate = thisDate
                thisResource.CE_ID_AdminResource = G_ID_ResourceAdmin
                thisResource.Save()


            Next myCell


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub pAddProject()

        Try
            Dim myDGV As DataGridView = Me.dgvPlanning
            Dim mySelectedCells As DataGridViewSelectedCellCollection
            Dim myCell As DataGridViewCell
            Dim mySelectedColumns As DataGridViewTextBoxColumn

            Dim thisID_ProjectMember As Integer = 0
            Dim thisDate As DateTime

            Dim thisResource As myPlanResource = Nothing


            mySelectedCells = myDGV.SelectedCells

            'On reset la variable globale
            G_ID_ResourceProject = 0

            'On affiche la fenêtre des ressouces administratives
            Dim myForm As Form = frmResourceProjectsList
            myForm.ShowDialog()
            myForm.Dispose()


            For Each myCell In mySelectedCells
                Dim myRow As Integer = myCell.RowIndex
                Dim myCol As Integer = myCell.ColumnIndex

                mySelectedColumns = myDGV.Columns(myCol)
                thisID_ProjectMember = CInt(mySelectedColumns.Name)

                thisDate = myDGV.Rows(myRow).HeaderCell.Value

                thisResource = New myPlanResource
                thisResource.CE_ID_ProjectMember = thisID_ProjectMember
                thisResource.Hour = CInt(Hour(thisDate))
                thisResource.PlanDate = thisDate
                thisResource.CE_ID_Project = G_ID_ResourceProject
                thisResource.Save()


            Next myCell


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

End Class