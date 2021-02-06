'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myProject

    Private _ID_Project As Integer
    Private _CE_ID_Status As Integer
    Private _CE_ID_Priority As Integer
    Private _CE_ID_ProjectManager As Integer
    Private _CE_ID_Category As Integer
    Private _CE_ID_Customer As Integer
    Private _CE_ID_Urgency As Integer
    Private _Title As String
    Private _Description As String
    Private _BeginDate As Date
    Private _Deadline As Date
    Private _EstimatedResources As Single
    Private _EffectiveResources As Single
    Private _ImplementationRate As Single
    Private _PlanRessources As Single


    Public Property PlanRessources As Single
        Get
            Return _PlanRessources
        End Get
        Set(value As Single)
            _PlanRessources = value
        End Set
    End Property

    Public Property ImplementationRate As Single
        Get
            Return _ImplementationRate
        End Get
        Set(ByVal value As Single)
            _ImplementationRate = value
        End Set
    End Property

    Public Property EstimatedResources As Single
        Get
            Return _EstimatedResources
        End Get
        Set(ByVal value As Single)
            _EstimatedResources = value
        End Set
    End Property




    Public Property EffectiveResources As Single
        Get
            Return _EffectiveResources
        End Get
        Set(ByVal value As Single)
            _EffectiveResources = value
        End Set
    End Property

    Public Property BeginDate As Date
        Get
            Return _BeginDate
        End Get
        Set(ByVal value As Date)
            _BeginDate = value
        End Set
    End Property


    Public Property DeadLine As Date
        Get
            Return _Deadline
        End Get
        Set(ByVal value As Date)
            _Deadline = value
        End Set
    End Property

    Public Property ID_Project As Integer
        Get
            Return _ID_Project
        End Get
        Set(ByVal value As Integer)
            _ID_Project = value
        End Set
    End Property

    Public Property CE_ID_Customer As Integer
        Get
            Return _CE_ID_Customer
        End Get
        Set(ByVal value As Integer)
            _CE_ID_Customer = value
        End Set
    End Property

    Public Property CE_ID_Urgency As Integer
        Get
            Return _CE_ID_Urgency
        End Get
        Set(ByVal value As Integer)
            _CE_ID_Urgency = value
        End Set
    End Property

    Public Property CE_ID_Priority As Integer
        Get
            Return _CE_ID_Priority
        End Get
        Set(ByVal value As Integer)
            _CE_ID_Priority = value
        End Set
    End Property


    Public Property CE_ID_Status As Integer
        Get
            Return _CE_ID_Status
        End Get
        Set(ByVal value As Integer)
            _CE_ID_Status = value
        End Set
    End Property


    Public Property CE_ID_Category As Integer
        Get
            Return _CE_ID_Category
        End Get

        Set(ByVal value As Integer)
            _CE_ID_Category = value
        End Set
    End Property

    Public Property CE_ID_ProjectManager As Integer
        Get
            Return _CE_ID_ProjectManager
        End Get

        Set(ByVal value As Integer)
            _CE_ID_ProjectManager = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return _Title
        End Get

        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _Description
        End Get

        Set(ByVal value As String)
            _Description = value
        End Set
    End Property


    Public Function Read() As myProject

        'Recherche les données d'un projet en fonction de son ID_Projet

        'Dim tmp As New myProject

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Project, Title, BeginDate, Deadline, Description, EstimatedResources, EffectiveResources, ImplementationRate, CE_ID_ProjectManager, CE_ID_Status, CE_ID_Priority, CE_ID_Category, CE_ID_Customer, CE_ID_Urgency FROM Projects WHERE ID_Project=" & Me.ID_Project

            'Réinitialisation des variables
            ID_Project = Nothing
            CE_ID_Status = Nothing
            CE_ID_Priority = Nothing
            CE_ID_ProjectManager = Nothing
            CE_ID_Category = Nothing
            CE_ID_Customer = Nothing
            CE_ID_Urgency = Nothing
            Title = Nothing
            Description = Nothing
            BeginDate = Nothing
            DeadLine = Nothing
            EstimatedResources = Nothing
            EffectiveResources = Nothing
            ImplementationRate = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_PROJECT
                Try
                    Me.ID_Project = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre Title
                Try
                    Me.Title = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du paramètre BEGIN
                Try
                    Me.BeginDate = myDBDataReader.GetDateTime(2)
                Catch ex As Exception
                End Try

                'Lecture du paramètre DEADLINE
                Try
                    Me.DeadLine = myDBDataReader.GetDateTime(3)
                Catch ex As Exception
                End Try

                'Lecture du paramètre DESCRIPTION
                Try
                    Me.Description = myDBDataReader.GetString(4)
                Catch ex As Exception
                End Try

                'Lecture du paramètre ESTIMATEDRESOURCES
                Try
                    Me.EstimatedResources = myDBDataReader.GetValue(5)
                Catch ex As Exception
                End Try


                'Lecture du paramètre EffectiveResources
                Try
                    Me.EffectiveResources = myDBDataReader.GetValue(6)
                Catch ex As Exception
                End Try

                'Lecture du paramètre ImplementationRate
                Try
                    Me.ImplementationRate = myDBDataReader.GetValue(7)
                Catch ex As Exception
                End Try

                'Lecture du paramètre CE_ID_ProjectManager
                Try
                    Me.CE_ID_ProjectManager = myDBDataReader.GetValue(8)
                Catch ex As Exception
                End Try

                'Lecture du paramètre CE_ID_Status
                Try
                    Me.CE_ID_Status = myDBDataReader.GetValue(9)
                Catch ex As Exception
                End Try

                'Lecture du paramètre CE_ID_Priority
                Try
                    Me.CE_ID_Priority = myDBDataReader.GetValue(10)
                Catch ex As Exception
                End Try

                'Lecture du paramètre CE_ID_Category
                Try
                    Me.CE_ID_Category = myDBDataReader.GetValue(11)
                Catch ex As Exception
                End Try

                'Lecture du paramètre CE_ID_Customer
                Try
                    Me.CE_ID_Customer = myDBDataReader.GetValue(12)
                Catch ex As Exception
                End Try

                'Lecture du paramètre CE_ID_Urgency
                Try
                    Me.CE_ID_Urgency = myDBDataReader.GetValue(13)
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

    Public Function Exists() As Boolean

        Dim _Exists As Boolean = False
        Dim _Count As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_Project) FROM Projects WHERE ID_Project = " & Me.ID_Project

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


    Public Function Count() As Integer

        Try
            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_Project) FROM Projects"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre COUNT
                Try
                    Count = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception

        End Try

        Return Count

    End Function

    Public Function NewID() As myProject

        'Recherche le plus grand ID_Project, ajoute 1 et définit la variable ID_Project
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Project FROM Projects ORDER BY ID_Project DESC LIMIT 1;"

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()
            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            Try
                If myDBDataReader.Read Then
                    _NewID = myDBDataReader.GetValue(0)
                End If
            Catch ex As Exception
            End Try
            _NewID = _NewID + 1
            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception

        End Try

        Me.ID_Project = _NewID

        Return Me

    End Function

    Public Function Save() As myProject

        Try

            Dim SQL As String = ""


            If Me.Exists = True Then

                'On définit le project
                Dim myProjectDB As New myProject
                myProjectDB.ID_Project = Me.ID_Project
                myProjectDB.Read()

                'on compte les jours travaillés et on calcule le taux de réalisation
                Me.GetEffectiveResources()
                If Me.EstimatedResources = 0 Then
                    Me.ImplementationRate = 0
                Else
                    Me.ImplementationRate = CInt(Me.EffectiveResources / Me.EstimatedResources * 100)
                End If

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE Projects SET "
                SQL &= "Title ='" & Replace(Me.Title, "'", "''") & "',"
                SQL &= "Description ='" & Replace(Me.Description, "'", "''") & "', "
                SQL &= "CE_ID_Status =" & Me.CE_ID_Status & ", "
                SQL &= "CE_ID_Priority =" & Me.CE_ID_Priority & ", "
                SQL &= "CE_ID_ProjectManager =" & Me.CE_ID_ProjectManager & ", "
                SQL &= "CE_ID_Category =" & Me.CE_ID_Category & ", "
                SQL &= "CE_ID_Customer =" & Me.CE_ID_Customer & ", "
                SQL &= "CE_ID_Urgency =" & Me.CE_ID_Urgency & ", "
                SQL &= "BeginDate ='" & fConvertDateOnlyMySQL(Me.BeginDate) & "', "
                SQL &= "Deadline ='" & fConvertDateOnlyMySQL(Me.DeadLine) & "', "
                SQL &= "EstimatedResources = " & Me.EstimatedResources & ", "
                SQL &= "EffectiveResources = " & Me.EffectiveResources & ", "
                SQL &= "ImplementationRate = " & Me.ImplementationRate & " "
                SQL &= "WHERE ID_Project=" & Me.ID_Project & ";"

                Dim myHistory As New myProjectHistory
                myHistory.CE_ID_Project = Me.ID_Project
                myHistory.ModifyBy = Logon
                myHistory.Modification = ""
                If myProjectDB.Title <> Me.Title Then myHistory.Modification &= "old title <" & myProjectDB.Title & "> new title <" & Me.Title & "> ; "
                If myProjectDB.Description <> Me.Description Then myHistory.Modification &= "old description <" & myProjectDB.Description & "> new description <" & Me.Description & "> ; "
                If myProjectDB.BeginDate <> Me.BeginDate Then myHistory.Modification &= "old BeginDate <" & myProjectDB.BeginDate & "> new BeginDate <" & Me.BeginDate & "> ; "
                If myProjectDB.DeadLine <> Me.DeadLine Then myHistory.Modification &= "old deadline <" & myProjectDB.DeadLine & "> new deadline <" & Me.DeadLine & "> ; "
                If myProjectDB.EstimatedResources <> Me.EstimatedResources Then myHistory.Modification &= "old estimated resources <" & myProjectDB.EstimatedResources & "> new estimated resources <" & Me.EstimatedResources & "> ; "
                If myProjectDB.ImplementationRate <> Me.ImplementationRate Then myHistory.Modification &= "old implementationrate <" & myProjectDB.ImplementationRate & "> new implementation rate <" & Me.ImplementationRate & "> ; "
                If myProjectDB.CE_ID_Status <> Me.CE_ID_Status Then myHistory.Modification &= "old CE_ID_Status <" & myProjectDB.CE_ID_Status & "> new CE_ID_Status <" & Me.CE_ID_Status & "> ; "
                If myProjectDB.CE_ID_Priority <> Me.CE_ID_Priority Then myHistory.Modification &= "old CE_ID_Priority <" & myProjectDB.CE_ID_Priority & "> new CE_ID_Priority <" & Me.CE_ID_Priority & "> ; "
                If myProjectDB.CE_ID_ProjectManager <> Me.CE_ID_ProjectManager Then myHistory.Modification &= "old CE_ID_ProjectManager <" & myProjectDB.CE_ID_ProjectManager & "> new CE_ID_ProjectManager <" & Me.CE_ID_ProjectManager & "> ; "
                If myProjectDB.CE_ID_Customer <> Me.CE_ID_Customer Then myHistory.Modification &= "old CE_ID_Customer <" & myProjectDB.CE_ID_Customer & "> new CE_ID_Customer <" & Me.CE_ID_Customer & "> ; "
                If myProjectDB.CE_ID_Urgency <> Me.CE_ID_Urgency Then myHistory.Modification &= "old CE_ID_Urgency <" & myProjectDB.CE_ID_Urgency & "> new CE_ID_Urgency <" & Me.CE_ID_Urgency & "> ; "
                If myProjectDB.CE_ID_Category <> Me.CE_ID_Category Then myHistory.Modification &= "old CE_ID_Category <" & myProjectDB.CE_ID_Category & "> new CE_ID_Category <" & Me.CE_ID_Category & "> ; "

                myHistory.ModifyDate = Now
                myHistory.Save()

            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO Projects "
                SQL &= "(ID_Project, Title, Description, CE_ID_Status, CE_ID_Priority, CE_ID_ProjectManager, CE_ID_Category, CE_ID_Customer, CE_ID_Urgency, BeginDate, Deadline, EstimatedResources, EffectiveResources, ImplementationRate ) VALUES ("
                SQL &= Me.ID_Project & ","
                SQL &= "'" & Replace(Me.Title, "'", "''") & "',"
                SQL &= "'" & Replace(Me.Description, "'", "''") & "',"
                SQL &= Me.CE_ID_Status & ","
                SQL &= Me.CE_ID_Priority & ","
                SQL &= Me.CE_ID_ProjectManager & ","
                SQL &= Me.CE_ID_Category & ","
                SQL &= Me.CE_ID_Customer & ","
                SQL &= Me.CE_ID_Urgency & ","
                SQL &= "'" & fConvertDateOnlyMySQL(Me.BeginDate) & "', "
                SQL &= "'" & fConvertDateOnlyMySQL(Me.DeadLine) & "', "
                SQL &= Me.EstimatedResources & ","
                SQL &= Me.EffectiveResources & ","
                SQL &= Me.ImplementationRate & ")"


                Dim myHistory As New myProjectHistory
                myHistory.CE_ID_Project = Me.ID_Project
                myHistory.ModifyBy = Logon
                myHistory.Modification = "new project creation, ID <" & Me.ID_Project & "> title <" & Me.Title & "> ; "
                myHistory.ModifyDate = Now
                myHistory.Save()

                ID_Project = Me.ID_Project

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

    Public Function GetEffectiveResources() As myProject

        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = ""
            Dim ID_Resource As Integer = 0
            Dim HalfDay As Integer = 0
            Dim Total As Single = 0
            Dim myResource As New myExecuteResource

            If ID_Project <> 0 Then
                Sql = "SELECT ID_Resource,HalfDay FROM ExecutedResources WHERE CE_ID_Project = " & Me.ID_Project & ";"

                MyDBConnection.ConnectionString = cnProjectPlan
                MyDBConnection.Open()
                Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()

                While myDBDataReader.Read

                    'Lecture du premier paramètre HalfDay
                    Try
                        myResource.ID_Resource = myDBDataReader.GetValue(0)
                        myResource.Read()
                    Catch ex As Exception
                    End Try


                    Select Case myResource.HalfDay
                        Case 1, 2
                            'Si c'est un demi jour, on ajoute 0.5 jour
                            Total = Total + 0.5
                        Case Else
                            'Dans les autres cas (0, null, etc), on ajoute 1 jour
                            Total = Total + 1
                    End Select
                End While

                Me.EffectiveResources = Total

                myDBDataReader.Close()
                MyDBConnection.Close()

            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function


    Public Function GetPlanResources() As myProject

        'Renvoie le nombre de jours planifiés pour un projet donné
        'On donne la réponse en demi-jour
        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = ""

            If ID_Project <> 0 Then
                Sql = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE CE_ID_Project = " & Me.ID_Project & ";"
                MyDBConnection.ConnectionString = cnProjectPlan
                MyDBConnection.Open()
                Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
                myDBDataReader = myDBCommand.ExecuteReader()

                While myDBDataReader.Read

                    'Lecture du premier paramètre HalfDay
                    Try
                        'On lit et on divise par 2 parce que les valeurs de la DB sont des demi-jours
                        Me.PlanRessources = myDBDataReader.GetValue(0) / 2
                    Catch ex As Exception
                    End Try

                End While

                myDBDataReader.Close()
                MyDBConnection.Close()

            End If


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function


End Class
