'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myTask


    Private _ID_Task As Integer
    Private _Task As String
    Private _Enable As Boolean
    Private _DisplayOrder As Integer



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
        Set(ByVal value As Integer)
            _DisplayOrder = value
        End Set
    End Property

    Public Property ID_Task As Integer
        Get
            Return _ID_Task
        End Get
        Set(ByVal value As Integer)
            _ID_Task = value
        End Set
    End Property

    Public Property Task As String
        Get
            Return _Task
        End Get

        Set(ByVal value As String)
            _Task = value
        End Set
    End Property


    Public Function Read() As myTask

        'Recherche les données d'une tâche en fonction de son ID_Task

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Task, Task, Enable, DisplayOrder from Tasks where ID_Task =" & Me.ID_Task

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Task = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.Task = myDBDataReader.GetString(1)
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
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me


    End Function

    Public Function Find_ID_From_Task() As myTask

        'Recherche les données d'un statut en fonction de son Task


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Task from Task where CONVERT(VARCHAR, Task) = '" & Me.Task & "';"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Task = myDBDataReader.GetValue(0)
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

    Public Function Save() As myTask
        Try

            Dim SQL As String = ""


            If Me.Exists = True And Me.ID_Task <> 0 Then

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE Tasks SET "
                SQL &= "ID_Task =" & Me.ID_Task & ","
                SQL &= "Task ='" & Replace(Me.Task, "'", "''") & "',"
                If Me.Enable = True Then
                    SQL &= "Enable = 1, "
                Else
                    SQL &= "Enable = 0, "
                End If
                SQL &= "DisplayOrder =" & Me.DisplayOrder & " "
                SQL &= "WHERE ID_Task = " & Me.ID_Task & ";"

            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO Tasks "
                SQL &= "(ID_Task, Task, Enable, DisplayOrder) VALUES ("
                SQL &= Me.ID_Task & ","
                SQL &= "'" & Replace(Me.Task, "'", "''") & "',"
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





    Public Function Exists() As Boolean

        Dim _Exists As Boolean = False
        Dim _Count As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT COUNT(ID_Task) FROM Tasks WHERE ID_Task = " & Me.ID_Task

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

            If _Count >= 1 Then
                _Exists = True
            End If

        Catch ex As Exception

        End Try

        Return _Exists

    End Function

    Public Function NewID() As myTask

        'Recherche le plus grand ID_Task, ajoute 1 et définit la variable ID_Task
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Task FROM Tasks ORDER BY ID_Task DESC LIMIT 1;"

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

        Me.ID_Task = _NewID

        Return Me

    End Function

End Class
