'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient



Public Class myProjectManager

    Private _ID_ProjectManager As Integer
    Private _FirstName As String
    Private _Lastname As String
    Private _Enable As Boolean
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

    Public Property Enable As Boolean
        Get
            Return _Enable
        End Get
        Set(value As Boolean)
            _Enable = value
        End Set
    End Property

    Public Property ID_ProjectManager As Integer
        Get
            Return _ID_ProjectManager
        End Get
        Set(ByVal value As Integer)
            _ID_ProjectManager = value
        End Set
    End Property

    'Défintion des fonctions

    Public Function Read() As myProjectManager

        'Recherche les données d'un statut en fonction de son ID_ProjectManager


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_ProjectManager, FirstName, Lastname, Enable from ProjectManagers where ID_ProjectManager =" & Me.ID_ProjectManager

            'Remise à zéro des variables
            ID_ProjectManager = Nothing
            FirstName = Nothing
            Lastname = Nothing
            Enable = Nothing
            FullName = Nothing

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_ProjectManager = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.FirstName = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.Lastname = myDBDataReader.GetString(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre
                Try
                    Me.Enable = myDBDataReader.GetValue(3)
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

    Public Function Find_ID_From_FullName() As myProjectManager

        'Recherche les données d'un Project Manager en fonction de son fullname


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_ProjectManager, FirstName, Lastname  from ProjectManagers;"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_ProjectManager = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.FirstName = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.Lastname = myDBDataReader.GetString(2)
                Catch ex As Exception
                End Try

                If Me.Lastname & " " & Me.FirstName = Me.FullName Then
                    Exit While
                Else
                    Me.ID_ProjectManager = 0
                End If

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function

    Public Function NewID() As myProjectManager

        'Recherche le plus grand ID_ProjectManager, ajoute 1 et définit la variable ID_ProjectManager
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_ProjectManager FROM ProjectManagers ORDER BY ID_ProjectManager DESC LIMIT 1;"

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

        Me.ID_ProjectManager = _NewID

        Return Me

    End Function

    Public Function Exists() As Boolean

        Dim _Exists As Boolean = False
        Dim _Count As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_ProjectManager) FROM ProjectManagers WHERE ID_ProjectManager = " & Me.ID_ProjectManager

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

    Public Function Save() As myProjectManager

        Try

            Dim SQL As String = ""




            If Me.Exists = True Then

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE ProjectManagers SET "
                SQL &= "FirstName ='" & Replace(Me.FirstName, "'", "''") & "',"
                SQL &= "Lastname ='" & Replace(Me.Lastname, "'", "''") & "', "
                If Me.Enable = True Then
                    SQL &= "Enable = 1 "
                Else
                    SQL &= "Enable = 0 "
                End If

                SQL &= "WHERE ID_ProjectManager=" & Me.ID_ProjectManager & ";"

            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO ProjectManagers "
                SQL &= "(ID_ProjectManager, FirstName, Lastname, Enable ) VALUES ("
                SQL &= Me.ID_ProjectManager & ","
                SQL &= "'" & Replace(Me._FirstName, "'", "''") & "',"
                SQL &= "'" & Replace(Me.Lastname, "'", "''") & "',"
                If Me.Enable = True Then
                    SQL &= "1)"
                Else
                    SQL &= "0)"
                End If


                ID_ProjectManager = Me.ID_ProjectManager

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

        End Try

        Return Me

    End Function


End Class
