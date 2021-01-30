'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myProjectHistory



    Private _ID_History As Integer
    Private _CE_ID_Priority As Integer
    Private _CE_ID_Status As Integer
    Private _CE_ID_Project As Integer
    Private _ModifyBy As String
    Private _ModifyDate As DateTime
    Private _Modification As String



    'Défnition des proprétés publiques


    Public Property ID_History As Integer
        Get
            Return _ID_History
        End Get
        Set(value As Integer)
            _ID_History = value
        End Set
    End Property
    Public Property CE_ID_Priority As Integer
        Get
            Return _CE_ID_Priority
        End Get
        Set(value As Integer)
            _CE_ID_Priority = value
        End Set
    End Property

    Public Property CE_ID_Status As Integer
        Get
            Return _CE_ID_Status
        End Get
        Set(value As Integer)
            _CE_ID_Status = value
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

    Public Property ModifyBy As String
        Get
            Return _ModifyBy
        End Get

        Set(ByVal value As String)
            _ModifyBy = value
        End Set
    End Property

    Public Property Modification As String
        Get
            Return _Modification
        End Get
        Set(ByVal value As String)
            _Modification = value
        End Set
    End Property

    Public Property ModifyDate As Date
        Get
            Return _ModifyDate
        End Get
        Set(value As Date)
            _ModifyDate = value
        End Set
    End Property



    Public Function NewID() As myProjectHistory

        'Recherche le plus grand ID_Project_History, ajoute 1 et définit la variable  ID_Project_History
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_History FROM ProjectsHistory ORDER BY ID_History DESC LIMIT 1;"

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

        Me.ID_History = _NewID

        Return Me



    End Function

    Public Function Read() As myProjectHistory

        'Recherche les données d'un projet en fonction de son ID_Projet

        'Dim tmp As New myProject

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_History, CE_ID_Project, ModifyBy, ModifyDate, Modifcation FROM ProjectsHistory WHERE ID_History=" & Me.ID_History

            'Remise à zéro des variables
            ID_History = Nothing
            CE_ID_Priority = Nothing
            CE_ID_Status = Nothing
            CE_ID_Project = Nothing
            ModifyBy = Nothing
            ModifyDate = Nothing
            Modification = Nothing

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_History = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre 
                Try
                    Me.CE_ID_Project = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre 
                Try
                    Me.ModifyBy = myDBDataReader.GetString(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre 
                Try
                    Me.ModifyDate = myDBDataReader.GetDateTime(3)
                Catch ex As Exception
                End Try

                'Lecture du 5e paramètre DESCRIPTION
                Try
                    Me.Modification = myDBDataReader.GetString(4)
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
            Dim Sql As String = "SELECT COUNT(ID_History) FROM ProjectsHistory WHERE ID_History = " & Me.ID_History

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

    Public Function Save() As myProjectHistory

        Try

            Dim SQL As String = ""




            If Me.Exists = True Then

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE ProjectsHistory SET "
                SQL &= "CE_ID_Project = " & Me.CE_ID_Project & ", "
                SQL &= "ModifyBy ='" & Replace(Me.ModifyBy, "'", "''") & "', "
                SQL &= "ModifyDate ='" & fConvertDateTimeMySQL(Me.ModifyDate) & "', "
                SQL &= "Modification ='" & Replace(Me.Modification, "'", "''") & "' "
                SQL &= "WHERE ID_History=" & Me.ID_History & ";"

            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO ProjectsHistory "
                SQL &= "(ID_History, CE_ID_Project, ModifyBy, ModifyDate, Modification ) VALUES ("
                SQL &= Me.ID_History & ","
                SQL &= Me.CE_ID_Project & ","
                SQL &= "'" & Replace(Me.ModifyBy, "'", "''") & "',"
                SQL &= "'" & fConvertDateTimeMySQL(Me.ModifyDate) & "',"
                SQL &= "'" & Replace(Me.Modification, "'", "''") & "')"

                ID_History = Me.ID_History

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

End Class
