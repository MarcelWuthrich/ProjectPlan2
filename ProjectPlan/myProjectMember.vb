'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient




Public Class myProjectMember

    Private _ID_ProjectMember As Integer
    Private _CE_ID_Task As Integer
    Private _FirstName As String
    Private _Lastname As String
    Private _Enable As Boolean
    Private _IsDeleted As Boolean
    Private _FullName As String

    'Défnition des proprétés publiques

    Public Property FullName As String
        Get
            Return _FullName
        End Get

        Set(ByVal value As String)
            _FullName = value
        End Set
    End Property

    Public Property Lastname As String
        Get
            Return _Lastname
        End Get

        Set(ByVal value As String)
            _Lastname = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get

        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    Public Property IsDeleted As Boolean
        Get
            Return _IsDeleted
        End Get
        Set(value As Boolean)
            _IsDeleted = value
        End Set
    End Property

    Public Property Enable As Boolean
        Get
            Return _Enable
        End Get
        Set(value As Boolean)
            _Enable = value
        End Set
    End Property

    Public Property ID_ProjectMember As Integer
        Get
            Return _ID_ProjectMember
        End Get
        Set(ByVal value As Integer)
            _ID_ProjectMember = value
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

    'Défintion des fonctions

    Public Function Read() As myProjectMember

        'Recherche les données d'un statut en fonction de son ID_ProjectMember


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_ProjectMember, CE_ID_Task, FirstName, LastName, Enable, IsDeleted from ProjectsMembers where ID_ProjectMember =" & Me.ID_ProjectMember
            Sql = "SELECT ID_ProjectMember, CE_ID_Task, FirstName, LastName, Enable from ProjectsMembers where ID_ProjectMember =" & Me.ID_ProjectMember

            'Remise à zéro des variables
            ID_ProjectMember = Nothing
            CE_ID_Task = Nothing
            FirstName = Nothing
            Lastname = Nothing
            Enable = Nothing
            IsDeleted = Nothing
            FullName = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_ProjectMember = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.CE_ID_Task = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.FirstName = myDBDataReader.GetString(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre
                Try
                    Me.Lastname = myDBDataReader.GetString(3)
                Catch ex As Exception
                End Try

                'Lecture du 5e paramètre
                Try
                    Me.Enable = myDBDataReader.GetValue(4)
                Catch ex As Exception
                End Try

                'Lecture du 6e paramètre
                Try
                    Me.IsDeleted = myDBDataReader.GetValue(5)
                Catch ex As Exception
                End Try


                'Construction du FullName
                Me.FullName = Me.Lastname & " " & Me.FirstName

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function

    Public Function NewID() As myProjectMember

        'Recherche le plus grand ID_ProjectMember, ajoute 1 et définit la variable ID_ProjectMember
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_ProjectMember FROM ProjectsMembers ORDER BY ID_ProjectMember DESC LIMIT 1;"

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

        Me.ID_ProjectMember = _NewID

        Return Me

    End Function

    Public Function Exists() As Boolean

        Dim _Exists As Boolean = False
        Dim _Count As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_ProjectMember) FROM ProjectsMembers WHERE ID_ProjectMember = " & Me.ID_ProjectMember

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

    Public Function Save() As myProjectMember

        Try

            Dim SQL As String = ""




            If Me.Exists = True Then

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE ProjectsMembers SET "
                SQL &= "CE_ID_Task ='" & Me.CE_ID_Task & "',"
                SQL &= "FirstName ='" & Replace(Me.FirstName, "'", "''") & "',"
                SQL &= "LastName ='" & Replace(Me.Lastname, "'", "''") & "', "
                If Me.Enable = True Then
                    'SQL &= "Enable = 1, "
                    SQL &= "Enable = 1 "
                Else
                    'SQL &= "Enable = 0, "
                    SQL &= "Enable = 0 "
                End If
                'If Me.IsDeleted = True Then
                '    SQL &= "IsDeleted = 1 "
                'Else
                '    SQL &= "IsDeleted = 0 "
                'End If

                SQL &= "WHERE ID_ProjectMember=" & Me.ID_ProjectMember & ";"

            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO ProjectsMembers "
                '                SQL &= "(ID_ProjectMember, CE_ID_Task, FirstName, LastName, Enable, IsDeleted ) VALUES ("
                SQL &= "(ID_ProjectMember, CE_ID_Task, FirstName, LastName, Enable ) VALUES ("
                SQL &= Me.ID_ProjectMember & ","
                SQL &= Me.CE_ID_Task & ","
                SQL &= "'" & Replace(Me._FirstName, "'", "''") & "',"
                SQL &= "'" & Replace(Me.Lastname, "'", "''") & "',"
                If Me.Enable = True Then
                    'SQL &= "1,"
                    SQL &= "1)"
                Else
                    'SQL &= "0,"
                    SQL &= "0)"
                End If
                'If Me.IsDeleted = True Then
                '    SQL &= "1)"
                'Else
                '    SQL &= "0)"
                'End If


                ID_ProjectMember = Me.ID_ProjectMember

            End If

            Dim MyDBConn As New MySqlConnection



            If SQL <> "" Then

                'On exécute la commande SQL uniquement si elle existe
                MyDBConn.ConnectionString = cnProjectPlan
                MyDBConn.Open()

                Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConn)

                myDBCommand.ExecuteNonQuery()
                myDBCommand = Nothing
                MyDBConn.Close()

            End If

        Catch ex As Exception

        End Try

        Return Me

    End Function

    Public Function GetIDMemberFromFullName() As myProjectMember

        'Recherche le ID_Member en fonction du Fullname
        'INPUT : FullName
        'OUTPUT : myProjectMember

        Try

            Dim _ProjectMember As String = Me.FullName

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_ProjectMember FROM ProjectsMembers;"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre COUNT
                Try
                    Me.ID_ProjectMember = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Me.Read()
                If Me.FullName = _ProjectMember Then Exit While

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()
        Catch ex As Exception

        End Try

        Return Me

    End Function

End Class
