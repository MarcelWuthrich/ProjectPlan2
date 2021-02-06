'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient



Public Class myCustomer

    Private _ID_Customer As Integer
    Private _FirstName As String
    Private _Lastname As String
    Private _CompanyName As String
    Private _CompanyLocation As String
    Private _Enable As Boolean
    Private _FullName As String
    Private _DisplayOrder As Integer

    'Défnition des proprétés publiques

    Public Property FullName As String
        Get
            Return _FullName
        End Get

        Set(ByVal value As String)
            _FullName = value
        End Set
    End Property
    Public Property CompanyName As String
        Get
            Return _CompanyName
        End Get

        Set(ByVal value As String)
            _CompanyName = value
        End Set
    End Property

    Public Property CompanyLocation As String
        Get
            Return _CompanyLocation
        End Get

        Set(ByVal value As String)
            _CompanyLocation = value
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

    Public Property ID_Customer As Integer
        Get
            Return _ID_Customer
        End Get
        Set(ByVal value As Integer)
            _ID_Customer = value
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

    'Défintion des fonctions

    Public Function Read() As myCustomer

        'Recherche les données d'un statut en fonction de son ID_Customer


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Customer, FirstName, LastName, CompanyName, CompanyLocation, Enable, DisplayOrder from Customers where ID_Customer =" & Me.ID_Customer


            'Remise à zéro des variables
            Me.ID_Customer = Nothing
            Me.FirstName = Nothing
            Me.Lastname = Nothing
            Me.Enable = Nothing
            Me.CompanyName = Nothing
            Me.CompanyLocation = Nothing
            Me.FullName = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Customer = myDBDataReader.GetValue(0)
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
                    Me.CompanyName = myDBDataReader.GetString(3)
                Catch ex As Exception
                End Try

                'Lecture du 5e paramètre
                Try
                    Me.CompanyLocation = myDBDataReader.GetString(4)
                Catch ex As Exception
                End Try

                'Lecture du 6e paramètre
                Try
                    Me.Enable = myDBDataReader.GetValue(5)
                Catch ex As Exception
                End Try

                'Lecture du 7e paramètre
                Try
                    Me.DisplayOrder = myDBDataReader.GetValue(6)
                Catch ex As Exception
                End Try

                'Construction du FullName
                Me.FullName = Me.Lastname & " " & Me.FirstName

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

            If DebugFlag = True Then MessageBox.Show(ex.ToString)

        End Try

        Return Me


    End Function

    Public Function NewID() As myCustomer

        'Recherche le plus grand ID_Customer, ajoute 1 et définit la variable ID_Customer
        Dim _NewID As Integer = 0

        Try
            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Customer FROM Customers ORDER BY ID_Customer DESC LIMIT 1;"

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
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Me.ID_Customer = _NewID

        Return Me

    End Function

    Public Function Exists() As Boolean

        Dim _Exists As Boolean = False
        Dim _Count As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_Customer) FROM Customers WHERE ID_Customer = " & Me.ID_Customer

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
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return _Exists

    End Function

    Public Function Save() As myCustomer

        Try

            Dim SQL As String = ""




            If Me.Exists = True Then

                'L'enregistrement existe déjà, il faut faire un update
                SQL = "UPDATE Customers SET "
                SQL &= "FirstName ='" & Replace(Me.FirstName, "'", "''") & "',"
                SQL &= "LastName ='" & Replace(Me.Lastname, "'", "''") & "', "
                SQL &= "CompanyName ='" & Replace(Me.CompanyName, "'", "''") & "', "
                SQL &= "CompanyLocation ='" & Replace(Me.CompanyLocation, "'", "''") & "', "
                If Me.Enable = True Then
                    SQL &= "Enable = 1, "
                Else
                    SQL &= "Enable = 0, "
                End If
                SQL &= "DisplayOrder =" & Me.DisplayOrder & " "

                SQL &= "WHERE ID_Customer=" & Me.ID_Customer & ";"
            Else


                Me.NewID()

                'L'enregistrement n'existe pas encore, il faut faire un insert
                SQL = "INSERT INTO Customers "
                SQL &= "(ID_Customer, FirstName, LastName, CompanyName, CompanyLocation, Enable, DisplayOrder ) VALUES ("
                SQL &= Me.ID_Customer & ","
                SQL &= "'" & Replace(Me._FirstName, "'", "''") & "',"
                SQL &= "'" & Replace(Me.Lastname, "'", "''") & "',"
                SQL &= "'" & Replace(Me.CompanyName, "'", "''") & "',"
                SQL &= "'" & Replace(Me.CompanyLocation, "'", "''") & "',"
                If Me.Enable = True Then
                    SQL &= "1,"
                Else
                    SQL &= "0,"
                End If
                SQL &= Me.DisplayOrder & ")"

                ID_Customer = Me.ID_Customer

            End If

            Dim MyDBConection As New MySqlConnection



            If SQL <> "" Then

                'On exécute la commande SQL uniquement si elle existe
                MyDBConection.ConnectionString = cnProjectPlan
                MyDBConection.Open()

                Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConection)

                myDBCommand.ExecuteNonQuery()
                myDBCommand = Nothing
                MyDBConection.Close()

            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return Me

    End Function

    Public Function GetIDMemberFromFullName() As myCustomer

        'Recherche le ID_Customer en fonction du Fullname
        'INPUT : FullName
        'OUTPUT : myCustomer

        Try

            Dim _ProjectMember As String = Me.FullName

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Customer FROM Customers;"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre COUNT
                Try
                    Me.ID_Customer = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                Me.Read()
                If Me.FullName = _ProjectMember Then Exit While

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
        Return Me

    End Function

End Class
