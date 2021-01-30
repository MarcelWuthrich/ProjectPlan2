Imports System.Data.SqlClient
Imports Microsoft.VisualBasic


Module GlobalProjectPlan

    Public ID_Project As Integer = 0
    Public ID_Remark As Integer = 0
    Public ID_Customer As Integer = 0
    Public ID_ProjectManager As Integer = 0
    Public ID_ProjectMember As Integer = 0
    Public DebugFlag As Boolean = True
    Public G_ID_ResourceAdmin As Integer = 0
    Public G_ID_ResourceProject As Integer = 0
    Public Logon As String = ""
    Public ID_Project_Current As Integer = 0
    Public ID_Resource_Current As Integer = 0
    Public ID_Task_Current As Integer = 0
    Public ID_Status_Current As Integer = 0
    Public ID_Customer_Current As Integer = 0
    Public ID_ProjectMember_Current As Integer = 0
    Public ID_ResourceAdmin_Current As Integer = 0

    'Variables pour frmProjectAddEstimateRessource.vb
    Public G_Add_ID_Task As Integer = 0
    Public G_Add_NumberDays As Integer = 0

    'Variable de connexion à la db
    'Public cnProjectPlan As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjectPlan;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Public cnProjectPlan As String = "server=localhost;user id=root;password=syY2Dnvii5CFTdxXwFqU;persistsecurityinfo=True;database=projectplan"

    '2020-11-19'

    Public Function fConvertDateOnlyMySQL(ByVal tDate As Date) As String

        'Converti une variable de type Date en une variable de type String que l'on peut utiliser dans une commande MySQL
        Dim DateString As String = ""
        Dim DateNull As New Date

        Try
            If DateNull <> tDate Then
                DateString = Year(tDate) & "-" & Month(tDate) & "-" & Day(tDate)
            End If
        Catch ex As Exception

        End Try

        Return DateString

    End Function

    Public Function fConvertDateTimeMySQL(ByVal tDate As Date) As String

        'Converti une variable de type Date en une variable de type String que l'on peut utiliser dans une commande MySQL
        Dim DateString As String = ""
        Dim DateNull As New Date

        Try
            If DateNull <> tDate Then
                DateString = Year(tDate) & "-" & Month(tDate) & "-" & Day(tDate) & " " & Hour(tDate) & ":" & Minute(tDate) & ":" & Second(tDate)
            End If
        Catch ex As Exception

        End Try

        Return DateString

    End Function

    Public Function fConvertDateTimeSQL(ByVal tDate As Date) As String

        'Converti une variable de type Date en une variable de type String que l'on peut utiliser dans une commande SQL
        Dim DateString As String = ""
        Dim DateNull As New Date

        Try
            If DateNull <> tDate Then
                DateString = Month(tDate) & "/" & Day(tDate) & "/" & Year(tDate) & " " & Hour(tDate) & ":" & Minute(tDate) & ":" & Second(tDate)
            End If
        Catch ex As Exception

        End Try

        Return DateString

    End Function

    Public Function fConvertDateonlySQL(ByVal tDate As Date) As String

        'Converti une variable de type Date en une variable de type String que l'on peut utiliser dans une commande SQL
        Dim DateString As String = ""
        Dim DateNull As New Date

        Try
            If DateNull <> tDate Then
                DateString = Month(tDate) & "/" & Day(tDate) & "/" & Year(tDate)
            End If
        Catch ex As Exception

        End Try

        Return DateString

    End Function

    Public Function fPlanResourceGetMinDate() As Date

        Dim thisMinDate As Date = Nothing

        Try

            'Recherche la plus petite PlanDate dans la table PlanResources
            'INPUT : rien
            'OUTPUT : La plus petite date avec des ressource planifiées


            Dim MySQLConnection As New SqlConnection

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = "SELECT PlanDate FROM PlanResources ORDER by PlanDate ASC LIMIT 1;"

            MySQLConnection.ConnectionString = cnProjectPlan


            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)

            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read

                'Lecture du premier paramètre ID_PROJECT
                Try
                    thisMinDate = mySQLDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try


        Return thisMinDate


    End Function

    Public Function fPlanResourceGetMaxDate() As Date

        Dim thisMaxDate As Date = Nothing

        Try

            'Recherche la plus petite PlanDate dans la table PlanResources
            'INPUT : rien
            'OUTPUT : La plus grande date avec des ressource planifiées

            Dim MySQLConnection As New SqlConnection

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = "SELECT PlanDate FROM PlanResources ORDER by PlanDate DESC LIMIT 1;"

            MySQLConnection.ConnectionString = cnProjectPlan


            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)

            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read

                'Lecture du premier paramètre ID_PROJECT
                Try
                    thisMaxDate = mySQLDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return thisMaxDate


    End Function

    Public Function fExecutedResourceGetMinDate() As Date

        Dim thisMinDate As Date = Nothing

        Try

            'Recherche la plus petite PlanDate dans la table ExecutedResources
            'INPUT : rien
            'OUTPUT : La plus petite date avec des ressources exécutées


            Dim MySQLConnection As New SqlConnection

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = "SELECT PlanDate FROM ExecutedResources ORDER by PlanDate ASC LIMIT 1;"

            MySQLConnection.ConnectionString = cnProjectPlan


            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)

            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read

                'Lecture du premier paramètre ID_PROJECT
                Try
                    thisMinDate = mySQLDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try


        Return thisMinDate


    End Function

    Public Function fExecutedResourceGetMaxDate() As Date

        Dim thisMaxDate As Date = Nothing

        Try

            'Recherche la plus petite PlanDate dans la table ExecutedResources
            'INPUT : rien
            'OUTPUT : La plus grande date avec des ressources exécutées

            Dim MySQLConnection As New SqlConnection

            Dim mySQLDataReader As SqlDataReader
            Dim Sql As String = "SELECT PlanDate FROM ExecutedResources ORDER by PlanDate DESC LIMIT 1;"

            MySQLConnection.ConnectionString = cnProjectPlan


            MySQLConnection.Open()

            Dim mySQLCommand As SqlCommand = New SqlCommand(Sql, MySQLConnection)

            mySQLDataReader = mySQLCommand.ExecuteReader()

            While mySQLDataReader.Read

                'Lecture du premier paramètre ID_PROJECT
                Try
                    thisMaxDate = mySQLDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            mySQLDataReader.Close()
            MySQLConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return thisMaxDate


    End Function

End Module
