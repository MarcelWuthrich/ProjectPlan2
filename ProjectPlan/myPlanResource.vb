﻿'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class myPlanResource


    Private _ID_Resource As Integer
    Private _CE_ID_ProjectMember As Integer
    Private _CE_ID_Project As Integer
    Private _CE_ID_AdminResource As Integer
    Private _CE_ID_Task As Integer
    Private _PlanDate As Date
    Private _Hour As Integer
    Private _Blocked As Boolean
    Private _Remark As String
    Private _IsPlaned As Boolean
    Private _ProjectMembersCount As Integer
    Private _IsAdminResource As Boolean
    Private _IsProjectResource As Boolean
    Private _FirstFreeDayForResource As Date
    Private _CountPlanResource As Integer
    Private _MinPlanDate As Date
    Private _MaxPlanDate As Date
    Private _PlanProjectResourcesPerTaskAndProject As Single



    Public Property Hour As Integer
        Get
            Return _Hour
        End Get
        Set(ByVal value As Integer)
            _Hour = value
        End Set
    End Property

    Public Property CE_ID_Task As Integer
        Get
            Return _CE_ID_Task
        End Get
        Set(ByVal value As Integer)
            _CE_ID_Task = value
        End Set
    End Property

    Public Property PlanProjectResourcesPerTaskAndProject As Single
        Get
            Return _PlanProjectResourcesPerTaskAndProject
        End Get
        Set(value As Single)
            _PlanProjectResourcesPerTaskAndProject = value
        End Set
    End Property



    Public Property MaxPlanDate As Date
        Get
            Return _MaxPlanDate
        End Get
        Set(value As Date)
            _MaxPlanDate = value
        End Set
    End Property
    Public Property MinPlanDate As Date
        Get
            Return _MinPlanDate
        End Get
        Set(value As Date)
            _MinPlanDate = value
        End Set
    End Property
    Public Property Remark As String
        Get
            Return _Remark
        End Get
        Set(value As String)
            _Remark = value
        End Set
    End Property
    Public Property Blocked As Boolean
        Get
            Return _Blocked
        End Get
        Set(value As Boolean)
            _Blocked = value
        End Set
    End Property

    Public Property CountPlanResource As Integer
        Get
            Return _CountPlanResource
        End Get
        Set(value As Integer)
            _CountPlanResource = value
        End Set
    End Property

    Public Property FirstFreeDayForResource As Date
        Get
            Return _FirstFreeDayForResource
        End Get
        Set(value As Date)
            _FirstFreeDayForResource = value
        End Set
    End Property

    Public Property IsProjectResource As Boolean
        Get
            Return _IsProjectResource
        End Get
        Set(value As Boolean)
            _IsProjectResource = value
        End Set
    End Property

    Public Property IsAdminResource As Boolean
        Get
            Return _IsAdminResource
        End Get
        Set(value As Boolean)
            _IsAdminResource = value
        End Set
    End Property

    Public Property ProjectMembersCount As Integer
        Get
            Return _ProjectMembersCount
        End Get
        Set(value As Integer)
            _ProjectMembersCount = value
        End Set
    End Property

    Public Property IsPlaned As Boolean
        Get
            Return _IsPlaned
        End Get
        Set(value As Boolean)
            _IsPlaned = value
        End Set
    End Property

    Public Property ID_Resource As Integer
        Get
            Return _ID_Resource
        End Get
        Set(value As Integer)
            _ID_Resource = value
        End Set
    End Property

    Public Property CE_ID_ProjectMember As Integer
        Get
            Return _CE_ID_ProjectMember
        End Get
        Set(value As Integer)
            _CE_ID_ProjectMember = value
        End Set
    End Property

    Public Property CE_ID_Project As Integer
        Get
            Return _CE_ID_Project
        End Get
        Set(value As Integer)
            _CE_ID_Project = value
        End Set
    End Property

    Public Property CE_ID_AdminResource As Integer
        Get
            Return _CE_ID_AdminResource
        End Get
        Set(value As Integer)
            _CE_ID_AdminResource = value
        End Set
    End Property

    Public Property PlanDate As Date
        Get
            Return _PlanDate
        End Get
        Set(value As Date)
            _PlanDate = value
        End Set
    End Property

    Public Function NewID() As myPlanResource

        'Recherche le plus grand ID_Resource, ajoute 1 et définit la variable ID_Resource

        'Attention : il est important de regarder dans les 2 tables "PlanResources" et "ExecutedResources".
        'parce que si on efface des ressources planifiées, il est possible que des ressources exécutées existent avec des ID déjà attribués et donc plus grand.
        'il y a un risque d'avoir des doublons dans les ID_Resource


        Dim _NewIDPlan As Integer = 0
        Dim _NewIDExecuted As Integer = 0
        Dim _NewID As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection
            MyDBConnection.ConnectionString = cnProjectPlan

            Dim myDBDataReader1 As MySqlDataReader
            Dim myDBDataReader2 As MySqlDataReader
            Dim Sql As String = ""


            MyDBConnection.Open()

            Sql = "SELECT ID_Resource FROM PlanResources ORDER BY ID_Resource DESC LIMIT 1;"
            Dim mydbCommand1 As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader1 = mydbCommand1.ExecuteReader()
            Try
                If myDBDataReader1.Read Then
                    _NewIDPlan = myDBDataReader1.GetValue(0)
                End If
            Catch ex As Exception
            End Try
            myDBDataReader1.Close()

            Sql = "SELECT ID_Resource FROM ExecutedResources ORDER BY ID_Resource DESC LIMIT 1;"
            Dim myDBCommand2 As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader2 = myDBCommand2.ExecuteReader()
            Try
                If myDBDataReader2.Read Then
                    _NewIDExecuted = myDBDataReader2.GetValue(0)
                End If
            Catch ex As Exception
            End Try
            myDBDataReader2.Close()

            MyDBConnection.Close()

            If _NewIDPlan > _NewIDExecuted Then
                _NewID = _NewIDPlan + 1
            Else
                _NewID = _NewIDExecuted + 1
            End If

        Catch ex As Exception

        End Try

        Me.ID_Resource = _NewID

        Return Me

    End Function

    Public Function Exists() As Boolean

        Dim _Exists As Boolean = False
        Dim _Count As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE ID_Resource = " & Me.ID_Resource

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre COUNT
                Try
                    _Count = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            If _Count = 1 Then
                _Exists = True
            End If

        Catch ex As Exception

        End Try

        Return _Exists

    End Function

    Public Function Read() As myPlanResource

        'Recherche les données d'une ressource planifiée en fonction de son ID_Resource



        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Resource, CE_ID_ProjectMember, CE_ID_Project, CE_ID_AdminResource, PlanDate, Hour, Blocked, Remark FROM PlanResources WHERE ID_Resource=" & Me.ID_Resource


            'Remise à zéro des variables
            ID_Resource = Nothing
            CE_ID_ProjectMember = Nothing
            CE_ID_Project = Nothing
            CE_ID_AdminResource = Nothing
            PlanDate = Nothing
            Hour = Nothing
            Blocked = Nothing
            Remark = Nothing
            IsPlaned = Nothing
            ProjectMembersCount = Nothing
            IsAdminResource = Nothing
            IsProjectResource = Nothing
            FirstFreeDayForResource = Nothing

            MyDBConnection.ConnectionString = cnProjectPlan

            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre 
                Try
                    Me.ID_Resource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.CE_ID_ProjectMember = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.CE_ID_Project = myDBDataReader.GetValue(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre 
                Try
                    Me.CE_ID_AdminResource = myDBDataReader.GetValue(3)
                Catch ex As Exception
                End Try

                'Lecture du 5e paramètre 
                Try
                    Me.PlanDate = myDBDataReader.GetDateTime(4)
                Catch ex As Exception
                End Try

                'Lecture du 6e paramètre 
                Try
                    Me.Hour = myDBDataReader.GetValue(5)
                Catch ex As Exception
                End Try

                'Lecture du 7e paramètre 
                Try
                    Me.Blocked = myDBDataReader.GetBoolean(6)
                Catch ex As Exception
                End Try

                'Lecture du 8e paramètre 
                Try
                    Me.Remark = myDBDataReader.GetString(7)
                Catch ex As Exception
                End Try


            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            'On détermine si c'est une ressource de projet
            If Me.CE_ID_Project = 0 Then
                Me.IsProjectResource = False
            Else
                Me.IsProjectResource = True
            End If

            'On détermine si c'est une ressource administrative
            If Me.CE_ID_AdminResource = 0 Then
                Me.IsAdminResource = False
            Else
                Me.IsAdminResource = True
            End If

            'Si c'est une ressource administrative ou une ressource de projet, c'est planifié
            If Me.IsAdminResource = True Or Me.IsProjectResource = True Then
                Me.IsPlaned = True
            End If


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function

    Public Function Save() As myPlanResource

        Try

            Dim SQL As String = ""

            'Si le champs remark contient la valeur "InitializeResourcesToHorizon", on sauvegarde un enregistremetn vide
            'On ne fait donc aucune validation

            If Me.Remark <> "InitializeResourcesToHorizon" Then

                'Si l'ID de la ressource administrative et celle du projet sont nulles, c'est qu'il y a une erreur et qu'il ne faut rien sauver
                'WUM / 08.05.2019
                If CE_ID_AdminResource = 0 And CE_ID_Project = 0 Then
                    Return Me
                    Exit Function
                End If

                'Si l'ID du membre de projet est nulle, c'est qu'il y a une erreur et qu'il ne faut rien sauver
                'WUM / 10.05.2019
                If CE_ID_ProjectMember = 0 Then
                    Return Me
                    Exit Function
                End If

                'On regarde si on a déjà une ressource pour la personne et la date prévues
                If Me.ID_Resource = 0 Then
                    'Return Me
                    Me.GetIDResourceFromDateAndMember()
                End If

            End If

            If Me.Exists = True And Me.ID_Resource <> 0 Then



                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE PlanResources SET "
                SQL &= "CE_ID_ProjectMember =" & Me._CE_ID_ProjectMember & ", "
                SQL &= "CE_ID_Project =" & Me._CE_ID_Project & ", "
                SQL &= "CE_ID_AdminResource =" & Me.CE_ID_AdminResource & ", "
                SQL &= "PlanDate ='" & fConvertDateTimeMySQL(Me.PlanDate) & "', "
                If Me.Blocked = True Then
                    SQL &= "Blocked = 1, "
                Else
                    SQL &= "Blocked = 0, "
                End If
                SQL &= "Remark = '" & Replace(Me.Remark, "'", "''") & "',"
                SQL &= "Hour = " & Me.Hour & " "

                SQL &= "WHERE ID_Resource=" & Me.ID_Resource & ";"



            Else


                Me.NewID()


                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO PlanResources "
                SQL &= "(ID_Resource, CE_ID_ProjectMember, CE_ID_Project, CE_ID_AdminResource, PlanDate, Blocked, Remark, Hour) VALUES ("
                SQL &= Me.ID_Resource & ","
                SQL &= Me.CE_ID_ProjectMember & ","
                SQL &= Me.CE_ID_Project & ","
                SQL &= Me.CE_ID_AdminResource & ","
                SQL &= "'" & fConvertDateOnlyMySQL(Me.PlanDate) & "',"
                If Me.Blocked = True Then
                    SQL &= "1, "
                Else
                    SQL &= "0, "
                End If
                'Si on a la remark = "", on initialise l'enregistrement mais on ne veut pas enregistrer la remarque
                If Me.Remark = "InitializeResourcesToHorizon" Then
                    SQL &= "'',"
                Else
                    SQL &= "'" & Replace(Me.Remark, "'", "''") & "',"
                End If

                SQL &= Me.Hour & ")"

            End If


            Dim MyDBConnection As New MySqlConnection



            If SQL <> "" Then

                'On exécute la commande SQL uniquement si elle existe
                MyDBConnection.ConnectionString = cnProjectPlan
                MyDBConnection.Open()

                Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

                myDBCommand.ExecuteNonQuery()
                myDBCommand = Nothing
                MyDBConnection.Close()

            End If



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function

    Public Function CheckIfPlaned() As myPlanResource

        'Vérifie s'il existe un enregistrement pour une personne à une date donnée et met la priorité IsPlaned 
        'INPUT : CE_ID_ProjectMember pour la personne
        'INPUT : PlanDate pour la personne
        'OUTPUT : IsPlaned (TRUE si on trouve un record, FALSE si on n'a rien trouvé)



        Dim _ID_Resource As Integer = 0
        Dim _CE_ID_Project As Integer = 0
        Dim _CE_ID_AdminResource As Integer = 0


        Try

            Dim MyDBConnection As New MySqlConnection


            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Resource, CE_ID_Project, CE_ID_AdminResource FROM PlanResources WHERE  CE_ID_ProjectMember = " & Me.CE_ID_ProjectMember & " AND PlanDate = '" & fConvertDateOnlyMySQL(Me.PlanDate) & "' AND Hour = " & Me.Hour & ";"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre 
                Try
                    _ID_Resource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre 
                Try
                    _CE_ID_Project = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                'Lecture du premier paramètre 
                Try
                    _CE_ID_AdminResource = myDBDataReader.GetValue(2)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            If _ID_Resource <> 0 Then

                'On a trouvé un record, on récupère l'ID et on met IsPlaned
                Me.ID_Resource = _ID_Resource
                Me.IsPlaned = True
            Else
                'On n'a pas trouvé de record, on met IsPlaned
                Me.IsPlaned = False
            End If


            'On détermine si c'est une ressource de projet
            If _CE_ID_Project = 0 Then
                Me.IsProjectResource = False
            Else
                Me.IsProjectResource = True
            End If


            'On détermine si c'est une ressource administrative
            If Me._CE_ID_AdminResource = 0 Then
                Me.IsAdminResource = False
            Else
                Me.IsAdminResource = True
            End If


        Catch ex As Exception

            'Debug.WriteLine(ex.ToString)

        End Try

        Return Me

    End Function

    Public Function GetProjectMembersCount() As myPlanResource

        Try

            'Recherche tous les membres de projets qui ont des ressources planifiées
            'INPUT : rien
            'OUTPUT : Le nombre de membres de projects qui ont des ressources planifiées

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(DISTINCT CE_ID_ProjectMember) FROM PlanResources;"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_PROJECT
                Try
                    Me.ProjectMembersCount = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()
        Catch ex As Exception

        End Try

        Return Me

    End Function

    Public Function GetResourceFromDateAndMember() As myPlanResource

        Try
            'Recherche la ressource en fonction du CE_ID_Membre, d'une date PlanDate et d'une Hour
            'INPUT : CE_ID_ProjectMember
            'INPUT : PlanDate
            'INPUT : Hour
            'OUTPUT : myPlanResource

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Resource FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.CE_ID_ProjectMember & " AND PlanDate = '" & fConvertDateOnlyMySQL(Me.PlanDate) & "' AND Hour = " & Me.Hour & ";"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.ID_Resource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.Read()

        Catch ex As Exception

        End Try


        Return Me

    End Function

    Public Function GetIDResourceFromDateAndMember() As myPlanResource

        Try
            'Recherche le ID_Resource en fonction du CE_ID_Membre, d'une date PlanDate et d'une Hour
            'INPUT : CE_ID_ProjectMember
            'INPUT : PlanDate
            'INPUT : Hour
            'OUTPUT : ID_Resource

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Resource FROM PlanResources WHERE CE_ID_ProjectMember = " & Me.CE_ID_ProjectMember & " AND PlanDate = '" & fConvertDateOnlyMySQL(Me.PlanDate) & "' AND Hour = " & Me.Hour & ";"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.ID_Resource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

        End Try


        Return Me

    End Function

    Public Function Delete() As myPlanResource

        Try
            'On efface la ressource en fonction de son ID_Resource
            'INPUT : ID_Resource

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "DELETE FROM PlanResources WHERE ID_Resource = " & Me.ID_Resource & ";"

            MyDBConnection.ConnectionString = cnProjectPlan

            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            'While mySQLDataReader.Read

            '    'Lecture du premier paramètre ID_Resource
            '    Try
            '        Me.ID_Resource = mySQLDataReader.GetValue(0)
            '    Catch ex As Exception
            '    End Try

            'End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            Me.Read()

        Catch ex As Exception

        End Try


        Return Me

    End Function

    Public Function GetFirstFreeDayForResource() As myPlanResource

        'Recherche la première date libre à partir de la date d'une ressource définie par ID_Resource
        'INPUT : ID_Resource
        'OUTPUT : FirstFreeDayForResource

        Try


            Dim thisDate As Date = Me.PlanDate
            Dim thisHour As Integer = Me.Hour
            Dim thisResource As New myPlanResource
            thisResource = Me

            '''' ça faut revoir avec le HalfDay (TODO)
            Do
                'On ajoute 1 jour à la date actuelle
                thisResource.PlanDate = DateAdd(DateInterval.Day, 1, thisResource.PlanDate)


                If Weekday(thisResource.PlanDate) = vbSaturday Or Weekday(thisResource.PlanDate) = vbSunday Then
                    'Si la date est un samedi ou un dimanche, on passe au jour suivant
                    Continue Do
                Else
                    'Si c'est un jour de semaine, on regarde si on peut planifier
                    thisResource.CheckIfPlaned()

                    If thisResource.IsPlaned = True Then
                        'Si c'est déjà planifié, on passe au jour suivant
                        Continue Do
                    End If
                End If

            Loop Until thisResource.IsPlaned = False

            Me.FirstFreeDayForResource = thisResource.PlanDate

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me
    End Function

    Public Function Get_Count_PlanResource_From_CE_ID_Project() As myPlanResource

        Try
            'Recherche le nombre de jours planifiés pour sur un projet donné
            'INPUT : CE_ID_Project
            'OUTPUT : CountPlanResource

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "select COUNT(ID_Resource) from PlanResources WHERE CE_ID_Project=" & CE_ID_Project

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.CountPlanResource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception

        End Try


        Return Me

    End Function

    Public Function GetMaxPlanDate() As myPlanResource

        Me.MaxPlanDate = Nothing

        Try


            'Recherche la PlanDate la plus récente
            'INPUT : nothing
            'OUTPUT : PlanDate


            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT PlanDate FROM PlanResources ORDER BY plandate DESC LIMIT 1;"
            Me.MaxPlanDate = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan

            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.MaxPlanDate = myDBDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception

        End Try

        Return Me

    End Function

    Public Function GetMinPlanDate() As myPlanResource

        Me.MinPlanDate = Nothing

        Try


            'Recherche la PlanDate la plus ancienne
            'INPUT : nothing
            'OUTPUT : PlanDate


            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT PlanDate FROM PlanResources ORDER BY plandate ASC LIMIT 1;"
            Me.MinPlanDate = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan

            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.MinPlanDate = myDBDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception

        End Try

        Return Me

    End Function


    Public Function GetPlanProjectResourcesPerTaskAndProject() As myPlanResource

        'Renvoi le nombre de jours planifiées pour un projet donné et pour les membres d'une tâches données
        'INPUT : CE_ID_Project
        'INPUT : CE_ID_Task
        'OUTPUT : EstimatedProjectResources

        Dim ProjectResources As Single = 0

        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""

            SQL = "SELECT COUNT(ID_Resource) FROM PlanResources where CE_ID_Project=" & Me.CE_ID_Project & " AND CE_ID_ProjectMember IN (SELECT ID_ProjectMember FROM ProjectsMembers WHERE CE_ID_Task=" & Me.CE_ID_Task & ") "

            'SQL = "SELECT NumberDays FROM ProjectEstimatedResources WHERE CE_ID_Project = " & Me.CE_ID_Project & " AND CE_ID_TASK = " & Me.CE_ID_Task & ";"
            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()
            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du paramètre HalfDay
                Try
                    'On lit 
                    ProjectResources = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Me.PlanProjectResourcesPerTaskAndProject = ProjectResources
        Return Me

    End Function


    Public Function InitializePlanningToHorizon() As myPlanResource

        Try
            Dim DateOffsetDays As Integer = 365
            Dim StartHours() As Integer = {8, 9, 10, 11, 13, 14, 15, 16}
            Dim thisResource As New myPlanResource

            Dim DateHorizon As Date = DateAdd(DateInterval.Day, DateOffsetDays, Today)

            Dim OldestPlanDate As Date = Nothing
            thisResource.GetMaxPlanDate()
            OldestPlanDate = thisResource.MaxPlanDate

            's'il n'y a pas d'enregistrements, on a une date dans le passé
            'Si on a une date avant le 01.01.2000, on considère qu'il n'y a pas d'enregistrements dans la table et on part depuis aujourd'hui
            Dim zeroDate As Date = New Date(2000, 1, 1)
            If OldestPlanDate < zeroDate Then OldestPlanDate = Today

            Dim OldestPlanDatePlus1Day As Date
            OldestPlanDatePlus1Day = DateAdd(DateInterval.Day, 1, OldestPlanDate)

            Dim thisDate As Date = OldestPlanDatePlus1Day


            'On insère des planifications vides entre la plus grande date planifiée et l'horizon
            thisResource.Remark = "InitializeResourcesToHorizon"
            While thisDate <= DateHorizon

                thisResource.PlanDate = thisDate
                For Each thisHour In StartHours
                    thisResource.ID_Resource = 0
                    thisResource.Hour = thisHour
                    thisResource.Save()
                Next thisHour

                thisDate = DateAdd(DateInterval.Day, 1, thisDate)
            End While

            Me.MaxPlanDate = DateHorizon

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function

    Public Function Delete_From_ID_ProjectMember_And_DateTime() As myPlanResource

        Try
            'On efface la ressource en fonction de son ID_ProjectMember et de sa date et heure
            'INPUT : ID_ProjectMember
            'INPUT : PlanDate
            'INPUT : Hour
            'si une de ces 3 valeurs n'est pas définies, on n'efface rien

            If Me.CE_ID_ProjectMember <> 0 And Not IsNothing(Me.PlanDate) And Hour <> 0 Then
                Dim MyDBConnection As New MySqlConnection
                Dim myDBDataReader As MySqlDataReader

                Dim SQL As String = ""
                SQL &= "DELETE FROM PlanResources WHERE "
                SQL &= "CE_ID_ProjectMember = " & Me.CE_ID_ProjectMember & " "
                SQL &= "AND PlanDate = '" & fConvertDateOnlyMySQL(Me.PlanDate) & "' "
                SQL &= "AND Hour = " & Me.Hour & "; "

                MyDBConnection.ConnectionString = cnProjectPlan

                MyDBConnection.Open()
                Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()
                myDBDataReader.Close()
                MyDBConnection.Close()
            End If


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function


End Class
