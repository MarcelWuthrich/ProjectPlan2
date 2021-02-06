'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myUrgency



    Private _ID_Urgency As Integer
    Private _Urgency As String
    Private _Enable As Boolean


    Public Property Enable As Boolean
        Get
            Return _Enable
        End Get
        Set(value As Boolean)
            _Enable = value
        End Set
    End Property

    Public Property ID_Urgency As Integer
        Get
            Return _ID_Urgency
        End Get
        Set(ByVal value As Integer)
            _ID_Urgency = value
        End Set
    End Property

    Public Property Urgency As String
        Get
            Return _Urgency
        End Get

        Set(ByVal value As String)
            _Urgency = value
        End Set
    End Property


    Public Function Read() As myUrgency

        'Recherche les données d'une tâche en fonction de son ID_Urgency

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Urgency, Urgency, Enable from Urgencies where ID_Urgency =" & Me.ID_Urgency

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Urgency = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.Urgency = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.Enable = myDBDataReader.GetValue(2)
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


End Class
