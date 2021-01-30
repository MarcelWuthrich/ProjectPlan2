'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myStatus


    Private _ID_Status As Integer
    Private _Status As String
    Private _Enable As Boolean
    Private _DisplayOrder As Integer


    Public Property DisplayOrder As Integer
        Get
            Return _DisplayOrder
        End Get
        Set(ByVal value As Integer)
            _DisplayOrder = value
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

    Public Property ID_Status As Integer
        Get
            Return _ID_Status
        End Get
        Set(ByVal value As Integer)
            _ID_Status = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _Status
        End Get

        Set(ByVal value As String)
            _Status = value
        End Set
    End Property


    Public Function Read() As myStatus

        'Recherche les données d'un statut en fonction de son ID_Status


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Status, Status, Enable, DisplayOrder from Status where ID_Status =" & Me.ID_Status

            MyDBConnection.ConnectionString = cnProjectPlan



            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Status = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.Status = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.Enable = myDBDataReader.GetValue(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre
                Try
                    Me.DisplayOrder = myDBDataReader.GetValue(3)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function

    Public Function Find_ID_From_Status() As myStatus

        'Recherche les données d'un statut en fonction de son status


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Status from Status where CONVERT(VARCHAR, Status) = '" & Me.Status & "';"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Status = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try


            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function


    Public Function Exists() As Boolean

        Dim _Exists As Boolean = False
        Dim _Count As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT COUNT(ID_Status) FROM Status WHERE ID_Status = " & Me.ID_Status

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


    Public Function NewID() As myStatus

        'Recherche le plus grand ID_Status, ajoute 1 et définit la variable ID_Status
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Status FROM Status ORDER BY ID_Status DESC LIMIT 1;"

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

        Me.ID_Status = _NewID

        Return Me

    End Function

    Public Function Save() As myStatus
        Try

            Dim SQL As String = ""


            If Me.Exists = True And Me.ID_Status <> 0 Then

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE Status SET "
                SQL &= "ID_Status =" & Me.ID_Status & ","
                SQL &= "Status ='" & Replace(Me.Status, "'", "''") & "',"
                If Me.Enable = True Then
                    SQL &= "Enable = 1, "
                Else
                    SQL &= "Enable = 0, "
                End If
                SQL &= "DisplayOrder =" & Me.DisplayOrder & " "
                SQL &= "WHERE ID_Status = " & Me.ID_Status & ";"

            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO Status "
                SQL &= "(ID_Status, Status, Enable, DisplayOrder) VALUES ("
                SQL &= Me.ID_Status & ","
                SQL &= "'" & Replace(Me.Status, "'", "''") & "',"
                If Me.Enable = True Then
                    SQL &= "1,"
                Else
                    SQL &= "0,"
                End If
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



End Class
