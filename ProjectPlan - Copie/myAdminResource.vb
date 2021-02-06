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
End Class
