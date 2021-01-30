Imports MySql.Data.MySqlClient


Public Class myPlanAdminResources



    Public Function Save() As myPlanAdminResources

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



End Class
