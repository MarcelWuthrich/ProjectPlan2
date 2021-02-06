Imports MySql.Data.MySqlClient

Public Class myEstimatedResource


    Private _ID_Resource As Integer
    Private _CE_ID_Project As Integer
    Private _CE_ID_Task As Integer
    Private _EstimatedResource As Integer
    Private _CreationDate As DateTime
    Private _LastModifyDate As DateTime


    Public Property CE_ID_Task As Integer
        Get
            Return _CE_ID_Task
        End Get
        Set(ByVal value As Integer)
            _CE_ID_Task = value
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

    Public Property ID_Resource As Integer
        Get
            Return _ID_Resource
        End Get
        Set(value As Integer)
            _ID_Resource = value
        End Set
    End Property

    Public Property CreationDate As DateTime
        Get
            Return _CreationDate
        End Get
        Set(value As DateTime)
            _CreationDate = value
        End Set
    End Property


    Public Property LastModifyDate As DateTime
        Get
            Return _LastModifyDate
        End Get
        Set(value As DateTime)
            _LastModifyDate = value
        End Set
    End Property

    Public Property EstimatedResource As Integer
        Get
            Return _EstimatedResource
        End Get
        Set(ByVal value As Integer)
            _EstimatedResource = value
        End Set
    End Property

    Public Function NewID() As myEstimatedResource

        'Recherche le plus grand ID_Resource, ajoute 1 et définit la variable ID_Resource


        Dim _NewID As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection
            MyDBConnection.ConnectionString = cnProjectPlan

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = ""


            MyDBConnection.Open()

            Sql = "SELECT ID_Resource FROM projectestimatedresources ORDER BY ID_Resource DESC LIMIT 1;"
            Dim mydbCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = mydbCommand.ExecuteReader()
            Try
                If myDBDataReader.Read Then
                    _NewID = myDBDataReader.GetValue(0)
                End If
            Catch ex As Exception
            End Try

            _NewID = _NewID + 1

            myDBDataReader.Close()


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
            Dim Sql As String = "SELECT COUNT(ID_Resource) FROM projectestimatedresources WHERE ID_Resource = " & Me.ID_Resource

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

    Public Function Save() As myEstimatedResource

        Try

            Dim SQL As String = ""




            If Me.Exists = True Then



                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE projectestimatedresources SET "
                SQL &= "ID_Resource =" & Me.ID_Resource & ", "
                SQL &= "CE_ID_Project =" & Me.CE_ID_Project & ", "
                SQL &= "CE_ID_Task =" & Me.CE_ID_Task & ", "
                SQL &= "EstimatedResource =" & Me.EstimatedResource & ", "
                SQL &= "CreationDate ='" & fConvertDateTimeMySQL(Me.CreationDate) & "', "
                SQL &= "LastModifyDate ='" & fConvertDateTimeMySQL(Now) & "' "
                SQL &= "WHERE ID_Resource=" & Me.ID_Resource & ";"


            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO projectestimatedresources "
                SQL &= "(ID_Resource, CE_ID_Project, CE_ID_Task, EstimatedResource, CreationDate, LastModifyDate) VALUES ("
                SQL &= Me.ID_Resource & ","
                SQL &= Me.CE_ID_Project & ","
                SQL &= Me.CE_ID_Task & ","
                SQL &= Me.EstimatedResource & ","
                SQL &= "'" & fConvertDateTimeMySQL(Now) & "',"
                SQL &= "'" & fConvertDateTimeMySQL(Now) & "')"

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

            Dim thisProject As New myProject
            thisProject.ID_Project = Me.CE_ID_Project
            thisProject.Read()
            thisProject.EstimatedResources = Me.GetEstimatedResources_CE_ID_Project
            thisProject.Save()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function

    Public Function Read() As myEstimatedResource

        'Recherche les données d'une ressourcee d'un projet en fonction de son ID_Resource


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT ID_Resource, CE_ID_Project, CE_ID_Task, EstimatedResource, CreationDate, LastModifyDate FROM ProjectEstimatedResources WHERE ID_Resource = " & Me.ID_Resource

            'Réinitialisation des variables
            Me.ID_Resource = Nothing
            Me.CE_ID_Project = Nothing
            Me.CE_ID_Task = Nothing
            Me.EstimatedResource = Nothing
            Me.CreationDate = Nothing
            Me.LastModifyDate = Nothing

            MyDBConnection.ConnectionString = cnProjectPlan

            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Resource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.CE_ID_Project = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.CE_ID_Task = myDBDataReader.GetValue(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre
                Try
                    Me.EstimatedResource = myDBDataReader.GetValue(3)
                Catch ex As Exception
                End Try

                'Lecture du 5e paramètre
                Try
                    Me.CreationDate = myDBDataReader.GetDateTime(4)
                Catch ex As Exception
                End Try

                'Lecture du 6e paramètre
                Try
                    Me.LastModifyDate = myDBDataReader.GetDateTime(5)
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

    Public Function GetEstimatedResources_CE_ID_Project() As Integer

        Dim TotalEstimatedResouces As Integer = 0

        Try

            GetEstimatedResources_CE_ID_Project = 0

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT SUM(EstimatedResource) FROM projectestimatedresources WHERE CE_ID_Project = " & Me.CE_ID_Project

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre COUNT
                Try
                    TotalEstimatedResouces = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return TotalEstimatedResouces

    End Function

End Class
