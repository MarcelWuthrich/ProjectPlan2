Public Class frmResourcesPlanSeries
    Private Sub frmResourcesAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsProjects.projects' table. You can move, or remove it, as needed.
        Me.ProjectsTableAdapter.Fill(Me.DsProjects.projects)

        Try

            pDisplayProjectMembers()
            pDisplayResourcesAdmin()

            Me.radDaily.Checked = True

            pClearFieldsDaily()

            Me.dtpDate.Value = New Date(2020, 12, 21)
            Me.texNumberOfDays.Text = "2"


            Me.radWeekly.Checked = True
            Me.texNumberOfWeeks.Text = "2"
            Me.texWeekFrom.Text = "11"
            Me.texWeekTo.Text = "14"
            Me.chkMonday.Checked = True
            Me.chkTuesday.Checked = True
            Me.chkWednesday.Checked = False
            Me.chkThursday.Checked = False
            Me.chkFriday.Checked = True
            Me.chkSaturday.Checked = True
            Me.chkSunday.Checked = False

            Me.btcPlanFree.Visible = False

        Catch ex As Exception

        End Try

    End Sub
    Private Sub pDisplayResourcesAdmin()
        Try

            'TODO: This line of code loads data into the 'DsResoucesAdmin.vresourcesadmin' table. You can move, or remove it, as needed.
            Me.VresourcesadminTableAdapter.Fill(Me.DsResoucesAdmin.vresourcesadmin)

            Dim myFilter As String = "Enable=1"
            Dim thisBindingSource As New BindingSource
            thisBindingSource = VresourcesadminBindingSource
            thisBindingSource.Filter = myFilter

            dgvResourcesAdmin.DataSource = thisBindingSource

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayProjectMembers()

        Try

            'TODO: This line of code loads data into the 'ProjectplanDataSet.vprojectmembers' table. You can move, or remove it, as needed.
            Me.VprojectmembersTableAdapter.Fill(Me.dsProjectPlan.vprojectmembers)

            Dim myFilter As String = "Enable=1"
            Dim thisBindingSource As New BindingSource
            thisBindingSource = VprojectmembersBindingSource
            thisBindingSource.Filter = myFilter

            dgvProjectMembers.DataSource = thisBindingSource

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcFermer_Click(sender As Object, e As EventArgs) Handles btcFermer.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub texDayFrom_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texDayTo_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texWeekFrom_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texWeekTo_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texNumberOfWeeks_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)

            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))
                MessageBox.Show(Me.texNumberOfWeeks.Text)
            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub texNumberOfDays_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try

            Dim thisAscii As Integer = Asc(e.KeyChar.ToString)
            If (thisAscii >= 48 And thisAscii <= 57) Or thisAscii = 9 Or thisAscii = 127 Or thisAscii = 8 Then
                'Le caractère est valable, on ne fait rien (chiffre, delete (127) ou tab(9) ou backspace(8))

            Else
                'Le caractère n'est pas valable, on ne le traite pas
                e.Handled = True
            End If

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcPlan_Click(sender As Object, e As EventArgs) Handles btcPlan.Click
        Try

            If Me.radDaily.Checked = True Then
                'Validation des champs
                pValidateFieldsDaily()
            End If

            If Me.radWeekly.Checked = True Then
                'Validation des champs
                pValidateFieldsWeekly()
            End If


            Dim thisResource As New myPlanResource
            thisResource.InitializePlanningToHorizon()


            ID_Project_Current = dgvProjects.Rows(dgvProjects.CurrentRow.Index).Cells(0).Value
            ID_ResourceAdmin_Current = dgvResourcesAdmin.Rows(dgvResourcesAdmin.CurrentRow.Index).Cells(0).Value
            ID_ProjectMember_Current = dgvProjectMembers.Rows(dgvProjectMembers.CurrentRow.Index).Cells(0).Value

            Select Case tabResources.SelectedIndex
                Case 0
                    'C'est le premier onglet "Administratif"
                    'C'est ID_ResourceAdmin_Current qui compte
                    ID_Project_Current = 0
                Case 1
                    'C'est le deuxième onglet "Projets"
                    'C'est ID_Project_Current qui compte
                    ID_ResourceAdmin_Current = 0
                Case Else
                    'Le reste est inconnu
                    ID_Project_Current = 0
                    ID_ResourceAdmin_Current = 0
            End Select

            pPlanResources()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pClearFieldsWeekly()
        Try
            Me.texMessage.Text = ""
            Me.texNumberOfWeeks.BackColor = Nothing
            Me.texWeekFrom.BackColor = Nothing
            Me.texWeekTo.BackColor = Nothing


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pClearFieldsDaily()
        Try
            Me.texMessage.Text = ""
            Me.texNumberOfDays.BackColor = Nothing
            Me.texDayFrom.BackColor = Nothing
            Me.texDayTo.BackColor = Nothing

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pValidateFieldsDaily()
        Try

            pClearFieldsDaily()

            Dim thisNumberOfDays As Integer = 0
            Dim thisDayFrom As Integer = 0
            Dim thisDayTo As Integer = 0

            Try
                thisNumberOfDays = CInt(Me.texNumberOfDays.Text)
            Catch ex As Exception
            End Try

            Try
                thisDayFrom = CInt(Me.texDayFrom.Text)
            Catch ex As Exception
            End Try

            Try
                thisDayTo = CInt(Me.texDayTo.Text)
            Catch ex As Exception
            End Try


            Select Case thisNumberOfDays
                Case 1 To 365
                    'OK nombre de jours valables
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Max. 365 jours. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Max. 365 jours. "
                    End If
                    Me.texNumberOfDays.BackColor = Color.Pink
            End Select


            Select Case thisDayFrom

                Case 8, 9, 10, 11, 13, 14, 15, 16
                    'OK heure valable
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Heures ""De"" uniquement 8 à 11 et 13 à 16. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Heures ""De"" uniquement 8 à 11 et 13 à 16. "
                    End If
                    Me.texDayFrom.BackColor = Color.Pink
            End Select

            Select Case thisDayTo
                Case 9, 10, 11, 12, 14, 15, 16, 17
                    'OK heure valable
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Heures ""A"" uniquement de 9 à 12 et 14 à 17. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Heures ""A"" uniquement de 9 à 12 et 14 à 17. "
                    End If
                    Me.texDayTo.BackColor = Color.Pink
            End Select



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pValidateFieldsWeekly()
        Try

            pClearFieldsWeekly()

            Dim thisNumberOfWeeks As Integer = 0
            Dim thisWeekFrom As Integer = 0
            Dim thisWeekTo As Integer = 0

            Try
                thisNumberOfWeeks = CInt(Me.texNumberOfWeeks.Text)
            Catch ex As Exception
            End Try

            Try
                thisWeekFrom = CInt(Me.texWeekFrom.Text)
            Catch ex As Exception
            End Try

            Try
                thisWeekTo = CInt(Me.texWeekTo.Text)
            Catch ex As Exception
            End Try


            Select Case thisNumberOfWeeks
                Case 1 To 52
                    'OK nombre de jours valables
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Nombre de semines entre 1 et 52."
                    Else
                        Me.texMessage.Text &= vbCrLf & "Nombre de semines entre 1 et 52."
                    End If
                    Me.texNumberOfWeeks.BackColor = Color.Pink
            End Select


            Select Case thisWeekFrom

                Case 8, 9, 10, 11, 13, 14, 15, 16
                    'OK heure valable
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Heures ""De"" uniquement 8 à 11 et 13 à 16. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Heures ""De"" uniquement 8 à 11 et 13 à 16. "
                    End If
                    Me.texWeekFrom.BackColor = Color.Pink
            End Select

            Select Case thisWeekTo
                Case 9, 10, 11, 12, 14, 15, 16, 17
                    'OK heure valable
                Case Else
                    If Len(Me.texMessage.Text) = 0 Then
                        Me.texMessage.Text &= "Heures ""A"" uniquement de 9 à 12 et 14 à 17. "
                    Else
                        Me.texMessage.Text &= vbCrLf & "Heures ""A"" uniquement de 9 à 12 et 14 à 17. "
                    End If
                    Me.texWeekTo.BackColor = Color.Pink
            End Select



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub radDaily_CheckedChanged_1(sender As Object, e As EventArgs) Handles radDaily.CheckedChanged
        Try

            If Me.radDaily.Checked = True Then
                Me.grpDaily.Visible = True
                Me.grpWeekly.Visible = False
            End If

            pClearFieldsDaily()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub radWeekly_CheckedChanged_1(sender As Object, e As EventArgs) Handles radWeekly.CheckedChanged
        Try

            If Me.radWeekly.Checked = True Then
                Me.grpWeekly.Visible = True
                Me.grpDaily.Visible = False
            End If

            pClearFieldsDaily()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pPlanResources()
        Try

            Dim PlanMode As String = ""
            Dim StartDate As Date = Nothing
            Dim DailyNumberOfDays As Integer = 0
            Dim DailyTimeFrom As Integer = 0
            Dim DailyTimeTo As Integer = 0
            Dim DailyOnlyWeekDays As Boolean = True
            Dim WeeklyNumberOfWeeks As Integer = 0
            Dim WeeklyTimeFrom As Integer = 0
            Dim WeeklyTimeTo As Integer = 0
            Dim WeeklyMonday As Boolean = False
            Dim WeeklyTuesday As Boolean = False
            Dim WeeklyWednesday As Boolean = False
            Dim WeeklyThursday As Boolean = False
            Dim WeeklyFriday As Boolean = False
            Dim WeeklySaturday As Boolean = False
            Dim WeeklySunday As Boolean = False

            Dim thisResource As New myPlanResource


            'Lecture de la date de début
            StartDate = Me.dtpDate.Value

            'Lecture des options pour le mode journalier
            If radDaily.Checked = True Then
                PlanMode = "daily"
                DailyNumberOfDays = Me.texNumberOfDays.Text
                DailyTimeFrom = Me.texDayFrom.Text
                DailyTimeTo = Me.texDayTo.Text
                If Me.radWeekDays.Checked = True Then DailyOnlyWeekDays = True
                If Me.radDays.Checked = True Then DailyOnlyWeekDays = False
            End If


            'Lecture des options pour le mode hebdomadaire
            If radWeekly.Checked = True Then
                PlanMode = "weekly"
                WeeklyNumberOfWeeks = Me.texNumberOfWeeks.Text
                WeeklyTimeFrom = Me.texWeekFrom.Text
                WeeklyTimeTo = Me.texWeekTo.Text
                If Me.chkMonday.Checked = True Then WeeklyMonday = True
                If Me.chkTuesday.Checked = True Then WeeklyTuesday = True
                If Me.chkWednesday.Checked = True Then WeeklyWednesday = True
                If Me.chkThursday.Checked = True Then WeeklyThursday = True
                If Me.chkFriday.Checked = True Then WeeklyFriday = True
                If Me.chkSaturday.Checked = True Then WeeklySaturday = True
                If Me.chkSunday.Checked = True Then WeeklySunday = True
            End If


            'Sauvegarde de la planification journalière
            If PlanMode = "daily" Then

                Dim thisDate As Date = StartDate
                Dim EndDate As Date = DateAdd(DateInterval.Day, DailyNumberOfDays, StartDate)
                Dim thisHour As Integer = 0
                Dim thisDay As Integer = 0

                'On boucle en fonction du nombre de jours
                Do While thisDate < EndDate

                    'On vérifie le jour de la semaine
                    thisDay = Weekday(thisDate)
                    If (thisDay = vbSaturday Or thisDay = vbSunday) And DailyOnlyWeekDays = True Then
                        'on ne fait rien sur on ne veut que les jours de la semaine et qu'on est samedi ou dimanche
                    Else
                        'Dans les autres cas, on planifie
                        For thisHour = DailyTimeFrom To DailyTimeTo - 1

                            Select Case thisHour
                                Case 8, 9, 10, 11, 13, 14, 15, 16
                                    'OK heure valable

                                    thisResource.ID_Resource = 0
                                    thisResource.CE_ID_AdminResource = ID_ResourceAdmin_Current
                                    thisResource.CE_ID_Project = ID_Project_Current
                                    thisResource.CE_ID_ProjectMember = ID_ProjectMember_Current
                                    thisResource.PlanDate = thisDate
                                    thisResource.Hour = thisHour
                                    thisResource.Save()

                                    'Debug.Print(Format(thisDate, "D") & " " & Format(thisHour, "00") & ":00")
                                Case Else
                            End Select
                        Next

                    End If

                    thisDate = DateAdd(DateInterval.Day, 1, thisDate)
                Loop

            End If



            'Sauvegarde de la planification hebdomadaire
            If PlanMode = "weekly" Then

                Dim thisDate As Date = StartDate
                Dim EndDate As Date = DateAdd(DateInterval.WeekOfYear, WeeklyNumberOfWeeks, StartDate)
                Dim thisHour As Integer = 0
                Dim thisDay As Integer = 0

                'On boucle en fonction du nombre de jours
                Do While thisDate < EndDate

                    'On vérifie le jour de la semaine
                    thisDay = Weekday(thisDate)

                    If (thisDay = vbMonday And WeeklyMonday = True) Or
                       (thisDay = vbTuesday And WeeklyTuesday = True) Or
                       (thisDay = vbWednesday And WeeklyWednesday = True) Or
                       (thisDay = vbThursday And WeeklyThursday = True) Or
                       (thisDay = vbFriday And WeeklyFriday = True) Or
                       (thisDay = vbSaturday And WeeklySaturday = True) Or
                       (thisDay = vbSunday And WeeklySunday = True) Then

                        For thisHour = WeeklyTimeFrom To WeeklyTimeTo - 1

                            Select Case thisHour
                                Case 8, 9, 10, 11, 13, 14, 15, 16
                                    'OK heure valable

                                    thisResource.ID_Resource = 0
                                    thisResource.CE_ID_AdminResource = ID_ResourceAdmin_Current
                                    thisResource.CE_ID_Project = ID_Project_Current
                                    thisResource.CE_ID_ProjectMember = ID_ProjectMember_Current
                                    thisResource.PlanDate = thisDate
                                    thisResource.Hour = thisHour
                                    thisResource.Save()

                                    'Debug.Print(Format(thisDate, "D") & " " & Format(thisHour, "00") & ":00")

                                Case Else
                            End Select
                        Next

                    End If


                    thisDate = DateAdd(DateInterval.Day, 1, thisDate)
                Loop



            End If


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



End Class