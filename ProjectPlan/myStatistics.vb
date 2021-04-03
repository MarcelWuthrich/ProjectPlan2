Imports MySql.Data.MySqlClient



Public Class myStatistics


    Private _ID_ProjectMember As Integer
    Private _ID_Project As Integer
    Private _HoursOnProjectPlaned As Single
    Private _HoursOnProjects1Month As Single
    Private _HoursOnProjects3Month As Single
    Private _HoursOnProjects6Month As Single
    Private _HoursOnProjects12Month As Single
    Private _HoursOnProjectsEndYear As Single
    Private _HoursOnAdmin1Month As Single
    Private _HoursOnAdmin3Month As Single
    Private _HoursOnAdmin6Month As Single
    Private _HoursOnAdmin12Month As Single
    Private _HoursOnAdminEndYear As Single
    Private _HoursFree1Month As Single
    Private _HoursFree3Month As Single
    Private _HoursFree6Month As Single
    Private _HoursFree12Month As Single
    Private _HoursFreeEndYear As Single
    Private _ProjectList As String
    Private _AdminList As String

    Public Property HoursOnProjectsEndYear As Single
        Get
            Return _HoursOnProjectsEndYear
        End Get
        Set(value As Single)
            _HoursOnProjectsEndYear = value
        End Set
    End Property

    Public Property HoursOnAdminEndYear As Single
        Get
            Return _HoursOnAdminEndYear
        End Get
        Set(value As Single)
            _HoursOnAdminEndYear = value
        End Set
    End Property

    Public Property HoursFreeEndYear As Single
        Get
            Return _HoursFreeEndYear
        End Get
        Set(value As Single)
            _HoursFreeEndYear = value
        End Set
    End Property


    Public Property ProjectList As String
        Get
            Return _ProjectList
        End Get
        Set(value As String)
            _ProjectList = value
        End Set
    End Property

    Public Property AdminList As String
        Get
            Return _AdminList
        End Get
        Set(value As String)
            _AdminList = value
        End Set
    End Property

    Public Property HoursFree1Month As Single
        Get
            Return _HoursFree1Month
        End Get
        Set(value As Single)
            _HoursFree1Month = value
        End Set
    End Property

    Public Property HoursFree3Month As Single
        Get
            Return _HoursFree3Month
        End Get
        Set(value As Single)
            _HoursFree3Month = value
        End Set
    End Property

    Public Property HoursFree6Month As Single
        Get
            Return _HoursFree6Month
        End Get
        Set(value As Single)
            _HoursFree6Month = value
        End Set
    End Property

    Public Property HoursFree12Month As Single
        Get
            Return _HoursFree12Month
        End Get
        Set(value As Single)
            _HoursFree12Month = value
        End Set
    End Property

    Public Property HoursOnAdmin12Month As Single
        Get
            Return _HoursOnAdmin12Month
        End Get
        Set(value As Single)
            _HoursOnAdmin12Month = value
        End Set
    End Property

    Public Property HoursOnAdmin6Month As Single
        Get
            Return _HoursOnAdmin6Month
        End Get
        Set(value As Single)
            _HoursOnAdmin6Month = value
        End Set
    End Property

    Public Property HoursOnAdmin3Month As Single
        Get
            Return _HoursOnAdmin3Month
        End Get
        Set(value As Single)
            _HoursOnAdmin3Month = value
        End Set
    End Property

    Public Property HoursOnAdmin1Month As Single
        Get
            Return _HoursOnAdmin1Month
        End Get
        Set(value As Single)
            _HoursOnAdmin1Month = value
        End Set
    End Property

    Public Property HoursOnProjects12Month As Single
        Get
            Return _HoursOnProjects12Month
        End Get
        Set(value As Single)
            _HoursOnProjects12Month = value
        End Set
    End Property

    Public Property HoursOnProjects6Month As Single
        Get
            Return _HoursOnProjects6Month
        End Get
        Set(value As Single)
            _HoursOnProjects6Month = value
        End Set
    End Property

    Public Property HoursOnProjects3Month As Single
        Get
            Return _HoursOnProjects3Month
        End Get
        Set(value As Single)
            _HoursOnProjects3Month = value
        End Set
    End Property

    Public Property HoursOnProjects1Month As Single
        Get
            Return _HoursOnProjects1Month
        End Get
        Set(value As Single)
            _HoursOnProjects1Month = value
        End Set
    End Property

    Public Property HoursOnProjectPlaned As Single
        Get
            Return _HoursOnProjectPlaned
        End Get
        Set(value As Single)
            _HoursOnProjectPlaned = value
        End Set
    End Property

    Public Property ID_ProjectMember As Single
        Get
            Return _ID_ProjectMember
        End Get
        Set(value As Single)
            _ID_ProjectMember = value
        End Set
    End Property

    Public Property ID_Project As Single
        Get
            Return _ID_Project
        End Get
        Set(value As Single)
            _ID_Project = value
        End Set
    End Property

    Public Function GetProjectHours() As myStatistics

        Try

            Try

                'Recherche le nombre d'heures planifiées sur des projets pour une personne donnée
                'INPUT : ID_ProjectManager
                'OUTPUT : HoursOnProjects1Month
                'OUTPUT : HoursOnProjects3Month
                'OUTPUT : HoursOnProjects6Month
                'OUTPUT : HoursOnProjects12Month
                'OUTPUT : HoursOnProjectsEndYear

                Dim DateIn1Month As Date = DateAdd(DateInterval.Month, 1, Now)
                Dim DateIn3Month As Date = DateAdd(DateInterval.Month, 3, Now)
                Dim DateIn6Month As Date = DateAdd(DateInterval.Month, 6, Now)
                Dim DateIn12Month As Date = DateAdd(DateInterval.Month, 12, Now)
                Dim DateEndYear As Date = New Date(Year(Today), 12, 31)

                Dim MyDBConnection As New MySqlConnection

                Dim myDBDataReader As MySqlDataReader
                MyDBConnection.ConnectionString = cnProjectPlan

                Dim SQL As String = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_Project <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn1Month) & "';"

                MyDBConnection.Open()
                Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnProjects1Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                SQL = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_Project <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn3Month) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(SQL, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnProjects3Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                SQL = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_Project <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn6Month) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(SQL, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnProjects6Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                SQL = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_Project <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn12Month) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(SQL, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnProjects12Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                SQL = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_Project <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateEndYear) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(SQL, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnProjectsEndYear = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                MyDBConnection.Close()


            Catch ex As Exception


            End Try


        Catch ex As Exception

        End Try


        Return Me


    End Function

    Public Function GetAdminHours() As myStatistics

        Try

            Try

                'Recherche le nombre de jours planifiés sur de l'administratif pour une personne donnée
                'INPUT : ID_ProjectManager
                'OUTPUT : DaysOnAdmin1Month
                'OUTPUT : DaysOnAdmin3Month
                'OUTPUT : DaysOnAdmin6Month
                'OUTPUT : DaysOnAdmin12Month
                'OUTPUT : DaysOnAdminEndYear

                Dim DateIn1Month As Date = DateAdd(DateInterval.Month, 1, Now)
                Dim DateIn3Month As Date = DateAdd(DateInterval.Month, 3, Now)
                Dim DateIn6Month As Date = DateAdd(DateInterval.Month, 6, Now)
                Dim DateIn12Month As Date = DateAdd(DateInterval.Month, 12, Now)
                Dim DateEndYear As Date = New Date(Year(Today), 12, 31)

                Dim MyDBConnection As New MySqlConnection

                Dim myDBDataReader As MySqlDataReader
                MyDBConnection.ConnectionString = cnProjectPlan

                Dim Sql As String = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_AdminResource <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn1Month) & "';"

                MyDBConnection.Open()
                Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnAdmin1Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                Sql = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_AdminResource <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn3Month) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(Sql, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnAdmin3Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                Sql = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_AdminResource <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn6Month) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(Sql, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnAdmin6Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                Sql = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_AdminResource <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateIn12Month) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(Sql, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnAdmin12Month = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                Sql = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_AdminResource <> 0 AND PlanDate <= '" & fConvertDateOnlyMySQL(DateEndYear) & "';"

                'MySQLConnection.Open()
                myDBCommand = New MySqlCommand(Sql, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                While myDBDataReader.Read
                    'Lecture du premier paramètre
                    Try
                        Me.HoursOnAdminEndYear = myDBDataReader.GetValue(0)
                    Catch ex As Exception
                    End Try
                End While
                myDBDataReader.Close()

                MyDBConnection.Close()


            Catch ex As Exception


            End Try


        Catch ex As Exception

        End Try


        Return Me


    End Function

    Public Function GetFreeHours() As myStatistics



        Try

            'Recherche le nombre d'heures planifiés sur de l'administratif pour une personne donnée
            'INPUT : ID_ProjectManager
            'OUTPUT : HoursFree1Month
            'OUTPUT : HoursFree3Month
            'OUTPUT : HoursFree6Month
            'OUTPUT : HoursFree12Month
            'OUTPUT : HoursFreeEndYear


            Dim StartHours() As Integer = {8, 9, 10, 11, 13, 14, 15, 16}

            Dim DateIn1Month As Date = DateAdd(DateInterval.Month, 1, Today)
            Dim DateIn3Month As Date = DateAdd(DateInterval.Month, 3, Today)
            Dim DateIn6Month As Date = DateAdd(DateInterval.Month, 6, Today)
            Dim DateIn12Month As Date = DateAdd(DateInterval.Month, 12, Today)
            Dim DateEndYear As Date = New Date(Year(Today), 12, 31)


            Dim CounterFreeIn1Month As Single = 0
            Dim CounterFreeIn3Month As Single = 0
            Dim CounterFreeIn6Month As Single = 0
            Dim CounterFreeIn12Month As Single = 0
            Dim CounterFreeEndYear As Single = 0


            Dim thisDate As Date = Today



            While thisDate <= DateIn12Month


                Select Case thisDate.DayOfWeek

                    Case DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday

                        Dim thisPlanResource As New myPlanResource
                        thisPlanResource.CE_ID_ProjectMember = Me.ID_ProjectMember
                        thisPlanResource.PlanDate = thisDate


                        For Each thisHour In StartHours
                            thisPlanResource.Hour = thisHour

                            thisPlanResource.CheckIfPlaned()

                            If thisPlanResource.IsPlaned = False Then

                                If thisDate <= DateIn1Month Then
                                    CounterFreeIn1Month += 1
                                End If

                                If thisDate <= DateIn3Month Then
                                    CounterFreeIn3Month += 1
                                End If

                                If thisDate <= DateIn6Month Then
                                    CounterFreeIn6Month += 1
                                End If

                                If thisDate <= DateIn12Month Then
                                    CounterFreeIn12Month += 1
                                End If

                                If thisDate <= DateEndYear Then
                                    CounterFreeEndYear += 1
                                End If

                            End If

                        Next thisHour


                End Select

                thisDate = DateAdd(DateInterval.Day, 1, thisDate)

            End While


            Me.HoursFree1Month = CounterFreeIn1Month
            Me.HoursFree3Month = CounterFreeIn3Month
            Me.HoursFree6Month = CounterFreeIn6Month
            Me.HoursFree12Month = CounterFreeIn12Month
            Me.HoursFreeEndYear = CounterFreeEndYear


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function

    Public Function GetProjectList() As myStatistics

        Try

            'Recherche le nombre de jours planifiés sur des project
            'INPUT : ID_ProjectManager
            'OUTPUT : ProjectList (texte avec le nom des membres et les jours planifiés)

            Dim thisCount As Single = 0
            Dim thisID As Integer = 0
            Me.ProjectList = ""

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            MyDBConnection.ConnectionString = cnProjectPlan

            Dim Sql As String = "Select COUNT(ID_RESOURCE),CE_ID_Project From PlanResources where CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_Project <> 0 GROUP BY CE_ID_Project ;"

            MyDBConnection.Open()
            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()
            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    thisCount = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    thisID = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                Dim thisProject As New myProject
                thisProject.ID_Project = thisID
                thisProject.Read()
                If thisCount <= 1 Then
                    Me.ProjectList &= Format(thisCount, "0.0") & " jour : " & thisProject.Title & vbCrLf
                Else
                    Me.ProjectList &= Format(thisCount, "0.0") & " jours : " & thisProject.Title & vbCrLf
                End If

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function

    Public Function GetAdminList() As myStatistics

        Try

            'Recherche le nombre de jours planifiés sur des project
            'INPUT : ID_ProjectManager
            'OUTPUT : AdminList (texte avec le nom des membres et les jours planifiés)

            Dim thisCount As Single = 0
            Dim thisID As Integer = 0
            Me.AdminList = ""

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            MyDBConnection.ConnectionString = cnProjectPlan

            Dim Sql As String = "Select COUNT(ID_RESOURCE),CE_ID_AdminResource From PlanResources where CE_ID_ProjectMember = " & Me.ID_ProjectMember & " AND CE_ID_AdminResource <> 0 GROUP BY CE_ID_AdminResource ;"

            MyDBConnection.Open()
            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()
            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    thisCount = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    thisID = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                Dim thisAdmin As New myAdminResource
                thisAdmin.ID_AdminResource = thisID
                thisAdmin.read()
                If thisCount <= 1 Then
                    Me.AdminList &= Format(thisCount, "0.0") & " jour : " & thisAdmin.AdminResource & vbCrLf
                Else
                    Me.AdminList &= Format(thisCount, "0.0") & " jours : " & thisAdmin.AdminResource & vbCrLf
                End If

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function

    Public Function GetPlanedHoursOnProject()

        Try

            'Recherche le nombre de jours planifiés sur un project donnée
            'INPUT : ID_Project
            'OUTPUT : HoursOnProjectPlaned

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            MyDBConnection.ConnectionString = cnProjectPlan

            Dim Sql As String = "Select COUNT(ID_RESOURCE) FROM PlanResources where CE_ID_Project = " & Me.ID_Project & ";"

            MyDBConnection.Open()
            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()
            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.HoursOnProjectPlaned = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function
End Class

