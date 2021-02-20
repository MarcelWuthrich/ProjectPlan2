'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myAdminResource


    Private _ID_AdminResource As Integer
    Private _AdminResource As String
    Private _Enable As Boolean
    Private _DisplayOrder As Integer
    Private _Symbol As String


    Public Property ID_AdminResource As Integer
        Get
            Return _ID_AdminResource
        End Get
        Set(value As Integer)
            _ID_AdminResource = value
        End Set
    End Property

    Public Property Symbol As String
        Get
            Return _Symbol
        End Get
        Set(value As String)
            _Symbol = value
        End Set
    End Property


    Public Property AdminResource As String
        Get
            Return _AdminResource
        End Get
        Set(value As String)
            _AdminResource = value
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

    Public Property DisplayOrder As Integer
        Get
            Return _DisplayOrder
        End Get
        Set(value As Integer)
            _DisplayOrder = value
        End Set
    End Property


    Public Function read() As myAdminResource

        Try

            'Recherche les données d'une autre ressource en fonction de son ID_AdminResource

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_AdminResource, AdminResource, Enable, DisplayOrder, Symbol FROM AdminResources where ID_AdminResource = " & Me.ID_AdminResource & ";"

            'Remise à zéro des variables
            ID_AdminResource = Nothing
            AdminResource = Nothing
            Enable = Nothing
            DisplayOrder = Nothing
            Symbol = Nothing

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre 
                Try
                    Me.ID_AdminResource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.AdminResource = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.Enable = myDBDataReader.GetBoolean(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre 
                Try
                    Me.DisplayOrder = myDBDataReader.GetValue(3)
                Catch ex As Exception
                End Try
                'Lecture du 5e paramètre 
                Try
                    Me.Symbol = myDBDataReader.GetString(4)
                Catch ex As Exception
                End Try


            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

        End Try

        Return Me

    End Function



    Public Function Save() As myAdminResource
        Try

            Dim SQL As String = ""


            If Me.Exists = True And Me.ID_AdminResource <> 0 Then

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE adminresources SET "
                SQL &= "ID_AdminResource =" & Me.ID_AdminResource & ","
                SQL &= "AdminResource ='" & Replace(Me.AdminResource, "'", "''") & "',"
                If Me.Enable = True Then
                    SQL &= "Enable = 1, "
                Else
                    SQL &= "Enable = 0, "
                End If
                SQL &= "Symbol ='" & Replace(Me.Symbol, "'", "''") & "',"
                SQL &= "DisplayOrder =" & Me.DisplayOrder & " "
                SQL &= "WHERE ID_AdminResource = " & Me.ID_AdminResource & ";"

            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO adminresources "
                SQL &= "(ID_AdminResource, AdminResource, Enable, Symbol, DisplayOrder) VALUES ("
                SQL &= Me.ID_AdminResource & ","
                SQL &= "'" & Replace(Me.AdminResource, "'", "''") & "',"
                If Me.Enable = True Then
                    SQL &= "1,"
                Else
                    SQL &= "0,"
                End If
                SQL &= "'" & Replace(Me.Symbol, "'", "''") & "', "
                SQL &= Me.DisplayOrder & ");"

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
            Dim SQL As String = "SELECT COUNT(ID_AdminResource) FROM adminresources WHERE ID_AdminResource = " & Me.ID_AdminResource

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

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

            If _Count >= 1 Then
                _Exists = True
            End If

        Catch ex As Exception

        End Try

        Return _Exists

    End Function


    Public Function NewID() As myAdminResource

        'Recherche le plus grand ID_AdminResource, ajoute 1 et définit la variable ID_AdminResource
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_AdminResource FROM adminresources ORDER BY ID_AdminResource DESC LIMIT 1;"

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

        Me.ID_AdminResource = _NewID

        Return Me

    End Function

End Class
