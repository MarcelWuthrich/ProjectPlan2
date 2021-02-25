Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel





Public Class frmDashboard



    'Définition de diverses variables
    Dim myColWidth As Integer = 60
    Dim i As Integer = 0



    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            'Affiche les projets et leurs heures
            pDisplayProjects()

            'Affiche les secteurs d'activités (task) sous forme d'onglets 
            pDisplayTasks()


        Catch ex As Exception
            Me.Cursor = Cursors.Default
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btcFermer_Click(sender As Object, e As EventArgs) Handles btcFermer.Click
        Try
            Me.Close()
        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btcRefresh_Click(sender As Object, e As EventArgs) Handles btcRefresh.Click
        Try

            pDisplayTasks()
            pDisplayProjects()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub pDisplayProjects()

        Try

            Me.Cursor = Cursors.WaitCursor


            Dim thisProject As New myProject
            Dim thisTask As New myTask
            Dim thisEstimatedResource As New myEstimatedResource
            Dim thisExecutedResource As New myExecuteResource
            Dim thisPlanResource As New myPlanResource

            Dim AllTasks(0) As Integer
            'La Valeur AllTask(0) contient le nombre d'enregistrements
            'La Valeur AllTask(1) contient le ID_Task de la première task
            'La Valeur AllTask(2) contient le ID_Task de la deuxième task
            '...etc...

            Dim thisTotalEstimated As Integer = 0
            Dim thisTotalEstimatedTask(0) As Integer
            'La Valeur thisTotalEstimatedTask(0) contient le nombre d'enregistrements
            'La Valeur thisTotalEstimatedTask(1) contient le total des ressources estimées par project et pas tâche
            'La Valeur thisTotalEstimatedTask(2) contient le total des ressources estimées par project et pas tâche
            '...etc...

            Dim thisTotalExecuted As Integer = 0
            Dim thisTotalExecutedTask(0) As Integer
            'La Valeur thisTotalExecutedTask(0) contient le nombre d'enregistrements
            'La Valeur thisTotalExecutedTask(1) contient le total des ressources exécutées par project et pas tâche
            'La Valeur thisTotalExecutedTask(2) contient le total des ressources exécutées par project et pas tâche
            '...etc...

            Dim thisTotalPlaned As Integer = 0
            Dim thisTotalPlanedTask(0) As Integer
            'La Valeur thisTotalPlanedTask(0) contient le nombre d'enregistrements
            'La Valeur thisTotalPlanedTask(1) contient le total des ressources planifiées par project et pas tâche
            'La Valeur thisTotalPlanedTask(2) contient le total des ressources planifiées par project et pas tâche
            '...etc...

            Dim thisTotalToBePlaned As Integer = 0
            Dim thisTotalToBePlanedTask(0) As Integer
            'La Valeur thisTotalToBePlanedTask(0) contient le nombre d'enregistrements
            'La Valeur thisTotalToBePlanedTask(1) contient le total des ressources encore à planifier par project et pas tâche
            'La Valeur thisTotalToBePlanedTask(2) contient le total des ressources encore à planifier par project et pas tâche
            '...etc...


            Dim ActiveRow As Integer = 0
            Dim TaskCount As Integer = 0
            Dim ProjectCount As Integer = 0

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReaderTask As MySqlDataReader
            Dim myDBDataReaderProject As MySqlDataReader

            Dim SQL As String = ""
            SQL = "SELECT ID_Task FROM Tasks WHERE Enable =1 ORDER BY DisplayOrder ASC;"


            'On vide le DataGridView
            dgvProjects.Rows.Clear()
            dgvProjects.Columns.Clear()


            'Définition du DataGridView
            dgvProjects.ReadOnly = True
            dgvProjects.AllowUserToAddRows = False
            dgvProjects.AllowUserToDeleteRows = False
            dgvProjects.MultiSelect = False



            'Définition des colonnes 0 - 6
            dgvProjects.Columns.Add("ID", "ID")                         '0  ID_Project 
            dgvProjects.Columns.Add("Projet", "Projet")                 '1  Nom du projet
            dgvProjects.Columns.Add("Deadline", "Deadline")             '2  Deadline
            dgvProjects.Columns.Add("Estimées", "Estimées")             '3  Ressources estimées pour tout le projet
            dgvProjects.Columns.Add("Effectuées", "Effectuées")         '4  Ressources effectuées pour tout le projet
            dgvProjects.Columns.Add("Planifiées", "Planifiées")         '5  Ressources planifiées pour tout le projet
            dgvProjects.Columns.Add("A planifier", "A planifier")       '6  Ressources à encore à planifier pour tout le projet

            dgvProjects.Columns(3).DefaultCellStyle.BackColor = Color.Black
            dgvProjects.Columns(3).DefaultCellStyle.ForeColor = Color.White
            dgvProjects.Columns(4).DefaultCellStyle.BackColor = Color.Black
            dgvProjects.Columns(4).DefaultCellStyle.ForeColor = Color.White
            dgvProjects.Columns(5).DefaultCellStyle.BackColor = Color.Black
            dgvProjects.Columns(5).DefaultCellStyle.ForeColor = Color.White
            dgvProjects.Columns(6).DefaultCellStyle.BackColor = Color.Black
            dgvProjects.Columns(6).DefaultCellStyle.ForeColor = Color.White

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommandTask As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReaderTask = myDBCommandTask.ExecuteReader()

            While myDBDataReaderTask.Read

                'Lecture du projet
                thisTask.ID_Task = myDBDataReaderTask.GetValue(0)
                thisTask.Read()


                ReDim Preserve AllTasks(AllTasks(0) + 1)
                AllTasks(0) += 1
                AllTasks(TaskCount + 1) = thisTask.ID_Task




                dgvProjects.Columns.Add("Estimées", "Estimées")             '7  Ressources estimées pour la tâche 1 (11 pour 2, 15 pour 3, etc.)
                dgvProjects.Columns.Add("Effectuées", "Effectuées")         '8  Ressources effectuées pour la tâche 1 (11 pour 2, 15 pour 3, etc.)
                dgvProjects.Columns.Add("Planifiées", "Planifiées")         '9  Ressources planifiées pour la tâche 1 (11 pour 2, 15 pour 3, etc.)
                dgvProjects.Columns.Add("A planifier", "A planifier")       '10 Ressources à encore à planifier la tâche 1 (11 pour 2, 15 pour 3, etc.)

                dgvProjects.Columns(TaskCount * 4 + 7).DefaultCellStyle.BackColor = Color.FromArgb(thisTask.BackColor)
                dgvProjects.Columns(TaskCount * 4 + 8).DefaultCellStyle.BackColor = Color.FromArgb(thisTask.BackColor)
                dgvProjects.Columns(TaskCount * 4 + 9).DefaultCellStyle.BackColor = Color.FromArgb(thisTask.BackColor)
                dgvProjects.Columns(TaskCount * 4 + 10).DefaultCellStyle.BackColor = Color.FromArgb(thisTask.BackColor)

                TaskCount += 1

            End While


            myDBDataReaderTask.Close()
            MyDBConnection.Close()



            'La colonne 0 (ID_Project) n'est pas visible
            dgvProjects.Columns(0).Visible = True
            For i = 1 To dgvProjects.ColumnCount - 1
                'Les autres colonnes sont visibles
                dgvProjects.Columns(i).Visible = True
                'On empêche de trier les colonnes de manière alphabétiques
                dgvProjects.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next i


            SQL = "SELECT projects.ID_Project FROM Projects LEFT JOIN ProjectPlan.status ON (projects.CE_ID_Status = status.ID_Status) WHERE (status.StatusProjectInWork =1);"


            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()


            Dim myDBCommandProject As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReaderProject = myDBCommandProject.ExecuteReader()
            While myDBDataReaderProject.Read

                'Lecture du projet
                thisProject.ID_Project = myDBDataReaderProject.GetValue(0)
                thisProject.Read()


                'On ajoute le projet dans le DataGridView
                dgvProjects.Rows.Add()

                'Affichages des cellules par projet
                dgvProjects.Item(0, ProjectCount).Value = thisProject.ID_Project                        'ID du projet
                dgvProjects.Item(1, ProjectCount).Value = thisProject.Title                             'Titre du projet
                dgvProjects.Item(2, ProjectCount).Value = Format(thisProject.DeadLine, "dd.MM.yyyy")    'Deadline du projet
                dgvProjects.Item(3, ProjectCount).Value = thisProject.EstimatedResources                'Ressources estimées totales
                dgvProjects.Item(4, ProjectCount).Value = thisProject.EffectiveResources                'Ressources effectives totales
                thisProject.GetPlanResources()                                                          'On calcule le nombre d'heures planifiées
                dgvProjects.Item(5, ProjectCount).Value = thisProject.PlanRessources                    'Ressources planifiées totales

                'On calcule le nombre d'heures encore à planifier
                Dim RessourcesToPlan As Single = thisProject.EstimatedResources - thisProject.EffectiveResources - thisProject.PlanRessources
                If RessourcesToPlan < 0 Then RessourcesToPlan = 0
                dgvProjects.Item(6, ProjectCount).Value = RessourcesToPlan                                 'nombre d'heures encore à planfier


                'On calcule les totaux pour le total des projets
                thisTotalEstimated += thisProject.EstimatedResources
                thisTotalExecuted += thisProject.EffectiveResources
                thisTotalPlaned += thisProject.PlanRessources
                thisTotalToBePlaned += RessourcesToPlan

                For myTaskNr = 1 To AllTasks(0)
                    thisTask = New myTask
                    thisTask.ID_Task = AllTasks(myTaskNr)
                    thisTask.Read()

                    'Affichage des ressources estimées par projet et secteur d'activités (task)
                    thisEstimatedResource = New myEstimatedResource
                    thisEstimatedResource.CE_ID_Project = thisProject.ID_Project
                    thisEstimatedResource.CE_ID_Task = AllTasks(myTaskNr)
                    thisEstimatedResource.GetEstimatedResourcesPerTaskAndProject()
                    dgvProjects.Item((myTaskNr - 1) * 4 + 7, ProjectCount).Value = thisEstimatedResource.EstimatedResourcesPerTaskAndProject

                    'Affichage des ressources exécutées par projet et secteur d'activités (task)
                    thisExecutedResource = New myExecuteResource
                    thisExecutedResource.CE_ID_Project = thisProject.ID_Project
                    thisExecutedResource.CE_ID_Task = AllTasks(myTaskNr)
                    thisExecutedResource.GetExecutedProjectResourcesPerTaskAndProject()
                    dgvProjects.Item((myTaskNr - 1) * 4 + 8, ProjectCount).Value = thisExecutedResource.ExecutedProjectResourcesPerTaskAndProject

                    'Affichage des ressources planifiées par projet et secteur d'activités (task)
                    thisPlanResource = New myPlanResource
                    thisPlanResource.CE_ID_Project = thisProject.ID_Project
                    thisPlanResource.CE_ID_Task = AllTasks(myTaskNr)
                    thisPlanResource.GetPlanProjectResourcesPerTaskAndProject()
                    dgvProjects.Item((myTaskNr - 1) * 4 + 9, ProjectCount).Value = thisPlanResource.PlanProjectResourcesPerTaskAndProject

                    'Affichage des ressources à planifier par projet et secteur d'activités (task)
                    Dim RessourcesToPlanPerTask As Single = thisEstimatedResource.EstimatedResourcesPerTaskAndProject - thisExecutedResource.ExecutedProjectResourcesPerTaskAndProject - thisPlanResource.PlanProjectResourcesPerTaskAndProject
                    If RessourcesToPlanPerTask < 0 Then RessourcesToPlanPerTask = 0
                    dgvProjects.Item((myTaskNr - 1) * 4 + 10, ProjectCount).Value = RessourcesToPlanPerTask                                 'nombre d'heures encore à planfier


                    'On additionne les heures planifiées par task
                    ReDim Preserve thisTotalEstimatedTask(thisTotalEstimatedTask(0) + 1)
                    thisTotalEstimatedTask(0) += 1
                    thisTotalEstimatedTask(myTaskNr) += thisEstimatedResource.EstimatedResourcesPerTaskAndProject

                    'On additionne les heures executées par task
                    ReDim Preserve thisTotalExecutedTask(thisTotalExecutedTask(0) + 1)
                    thisTotalExecutedTask(0) += 1
                    thisTotalExecutedTask(myTaskNr) += thisExecutedResource.ExecutedProjectResourcesPerTaskAndProject

                    'On additionne les heures planifiées par task
                    ReDim Preserve thisTotalPlanedTask(thisTotalPlanedTask(0) + 1)
                    thisTotalPlanedTask(0) += 1
                    thisTotalPlanedTask(myTaskNr) += thisPlanResource.PlanProjectResourcesPerTaskAndProject

                    'On additionne les heures encore à planifier par task
                    ReDim Preserve thisTotalToBePlanedTask(thisTotalToBePlanedTask(0) + 1)
                    thisTotalToBePlanedTask(0) += 1
                    thisTotalToBePlanedTask(myTaskNr) += RessourcesToPlanPerTask



                Next myTaskNr

                ProjectCount += 1

            End While


            myDBDataReaderProject.Close()


            'Affichage des totaux
            dgvProjects.Rows.Add()
            dgvProjects.Item(1, ProjectCount).Value = "TOTAUX"
            dgvProjects.Item(3, ProjectCount).Value = thisTotalEstimated                'Total pour le temps estimé de tous les projets
            dgvProjects.Item(4, ProjectCount).Value = thisTotalExecuted                 'Total pour le temps exécuté de tous les projets
            dgvProjects.Item(5, ProjectCount).Value = thisTotalPlaned                   'Total pour le temps planfié de tous les projets
            dgvProjects.Item(6, ProjectCount).Value = thisTotalToBePlaned               'Total pour le temps encore à planfier de tous les projets


            'On met la dernière ligne (totaux) en bold
            dgvProjects.Rows(ProjectCount).DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

            'On centre les colonnes
            dgvProjects.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


            For myTaskNr = 1 To AllTasks(0)

                'Affichage des totaux des ressources estimées par projet et secteur d'activités (task)
                dgvProjects.Item((myTaskNr - 1) * 4 + 7, ProjectCount).Value = thisTotalEstimatedTask(myTaskNr)
                dgvProjects.Item((myTaskNr - 1) * 4 + 8, ProjectCount).Value = thisTotalExecutedTask(myTaskNr)
                dgvProjects.Item((myTaskNr - 1) * 4 + 9, ProjectCount).Value = thisTotalPlanedTask(myTaskNr)
                dgvProjects.Item((myTaskNr - 1) * 4 + 10, ProjectCount).Value = thisTotalToBePlanedTask(myTaskNr)


            Next myTaskNr

            Me.Cursor = Cursors.Default



        Catch ex As Exception

            If DebugFlag = True Then MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub pDisplayTasks()
        Try

            Dim thisTB As TabControl = Me.tabTaskType


            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT ID_Task FROM Tasks WHERE Enable =1 ORDER BY DisplayOrder ASC;"
            Dim CountTasks As Integer = 0


            Dim myTask As New myTask

            'On met tous les champs textes en haut de la page sur invisible
            Me.texTask1.Visible = False
            Me.texTask2.Visible = False
            Me.texTask3.Visible = False
            Me.texTask4.Visible = False
            Me.texTask5.Visible = False
            Me.texTask6.Visible = False
            Me.texTask7.Visible = False
            Me.texTask8.Visible = False
            Me.texTask9.Visible = False
            Me.texTask10.Visible = False

            'On définit les couleurs et le fonds uniquement pour les totaux
            Me.texTaskTotal.BackColor = Color.Black
            Me.texTaskTotal.ForeColor = Color.White

            'On lit des task
            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre 
                Try
                    'Lecture du nombre d'enregistrement (en demi-jour)
                    myTask.ID_Task = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                myTask.Read()

                'on définit les caractéristiques des Tab
                thisTB.TabPages(CountTasks).Text = myTask.Task
                thisTB.TabPages(CountTasks).BackColor = Color.FromArgb(myTask.BackColor)


                'On définit les caractéristiques des textbox
                Dim myTextBox As TextBox
                myTextBox = Me.Controls("texTask" & CStr(CountTasks + 1))
                myTextBox.Visible = True
                myTextBox.Text = myTask.Task
                myTextBox.BackColor = Color.FromArgb(myTask.BackColor)


                Dim thisDGV As DataGridView
                Dim thisName As String = ""


                'On recherche le datagridview à l'intérieur du tab (0) --> Tab1
                Dim myControl As Control
                For Each myControl In Me.tabTaskType.TabPages(CountTasks).Controls
                    thisName = "dgvTabPage" & CStr(CountTasks + 1)
                    If myControl.Name = thisName Then

                        'On a trouvé le contrôle qui correspond à la tache, on rempli

                        'Définition du DataGridView
                        thisDGV = myControl
                        thisDGV.Columns.Clear()
                        thisDGV.Rows.Clear()
                        thisDGV.ReadOnly = True
                        thisDGV.AllowUserToAddRows = False
                        thisDGV.AllowUserToDeleteRows = False

                        thisDGV.DefaultCellStyle.BackColor = Color.FromArgb(myTask.BackColor)
                        thisDGV.RowHeadersVisible = False
                        thisDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


                        'Définition des colonnes
                        thisDGV.Columns.Add("", "")
                        thisDGV.Columns.Add("1 mois", "1 mois")
                        thisDGV.Columns.Add("3 mois", "3 mois")
                        thisDGV.Columns.Add("6 mois", "6 mois")
                        thisDGV.Columns.Add("12 mois", "12 mois")
                        thisDGV.Columns.Add("fin année", "fin année")


                        'On ajoute les lignes
                        thisDGV.Rows.Add()
                        thisDGV.Rows.Add()
                        thisDGV.Rows.Add()
                        thisDGV.Item(0, 0).Value = "Planifié projet"
                        thisDGV.Item(0, 1).Value = "Planifié administratif"
                        thisDGV.Item(0, 2).Value = "Libre (semaine)"


                        Dim myPlanProject As New myPlanResource
                        myPlanProject.CE_ID_Task = myTask.ID_Task






                        'On calcule les statistique de planification pour les prochaines périodes
                        Dim thisPlanProject1Month As String = fGetPlanedResources(myTask.ID_Task, True, False, DateAdd(DateInterval.Month, 1, Today))
                        thisDGV.Item(1, 0).Value = thisPlanProject1Month

                        Dim thisPlanAdminResource1Month As String = fGetPlanedResources(myTask.ID_Task, False, True, DateAdd(DateInterval.Month, 1, Today))
                        thisDGV.Item(1, 1).Value = thisPlanAdminResource1Month

                        Dim thisFreeResource1Month As String = fGetFreeResources(myTask.ID_Task, DateAdd(DateInterval.Month, 1, Today))
                        thisDGV.Item(1, 2).Value = thisFreeResource1Month

                        Dim thisPlanProject3Month As String = fGetPlanedResources(myTask.ID_Task, True, False, DateAdd(DateInterval.Month, 3, Today))
                        thisDGV.Item(2, 0).Value = thisPlanProject3Month

                        Dim thisPlanAdminResource3Month As String = fGetPlanedResources(myTask.ID_Task, False, True, DateAdd(DateInterval.Month, 3, Today))
                        thisDGV.Item(2, 1).Value = thisPlanAdminResource3Month

                        Dim thisFreeResource3Month As String = fGetFreeResources(myTask.ID_Task, DateAdd(DateInterval.Month, 3, Today))
                        thisDGV.Item(2, 2).Value = thisFreeResource3Month

                        Dim thisPlanProject6Month As String = fGetPlanedResources(myTask.ID_Task, True, False, DateAdd(DateInterval.Month, 6, Today))
                        thisDGV.Item(3, 0).Value = thisPlanProject6Month

                        Dim thisPlanAdminResource6Month As String = fGetPlanedResources(myTask.ID_Task, False, True, DateAdd(DateInterval.Month, 6, Today))
                        thisDGV.Item(3, 1).Value = thisPlanAdminResource6Month

                        Dim thisFreeResource6Month As String = fGetFreeResources(myTask.ID_Task, DateAdd(DateInterval.Month, 6, Today))
                        thisDGV.Item(3, 2).Value = thisFreeResource6Month

                        Dim thisPlanProject12Month As String = fGetPlanedResources(myTask.ID_Task, True, False, DateAdd(DateInterval.Year, 1, Today))
                        thisDGV.Item(4, 0).Value = thisPlanProject6Month

                        Dim thisPlanAdminResource12Month As String = fGetPlanedResources(myTask.ID_Task, False, True, DateAdd(DateInterval.Year, 1, Today))
                        thisDGV.Item(4, 1).Value = thisPlanAdminResource12Month

                        Dim thisFreeResource12Month As String = fGetFreeResources(myTask.ID_Task, DateAdd(DateInterval.Year, 1, Today))
                        thisDGV.Item(4, 2).Value = thisFreeResource12Month

                        Dim thisPlanProjectEndOfYear As String = fGetPlanedResources(myTask.ID_Task, True, False, New Date(Year(Today), 12, 31))
                        thisDGV.Item(5, 0).Value = thisPlanProjectEndOfYear

                        Dim thisPlanAdminResourceEndOfYear As String = fGetPlanedResources(myTask.ID_Task, False, True, New Date(Year(Today), 12, 31))
                        thisDGV.Item(5, 1).Value = thisPlanAdminResourceEndOfYear

                        Dim thisFreeResourceEndOfYear As String = fGetFreeResources(myTask.ID_Task, New Date(Year(Today), 12, 31))
                        thisDGV.Item(5, 2).Value = thisFreeResourceEndOfYear




                        'On met la grille en mode multiligne
                        thisDGV.DefaultCellStyle.WrapMode = DataGridViewTriState.True

                        'On aligne le texte à droite
                        thisDGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                        'On resize les lignes
                        thisDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells


                    End If
                Next



                CountTasks += 1

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            'On supprime les Tab que l'on n'utilisent pas
            For myTabToRemove = (thisTB.TabCount - 1) To CountTasks Step -1
                thisTB.Controls.Remove(thisTB.TabPages(myTabToRemove))
            Next


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Private Sub pDisplayNextMonths()
    '    Try

    '        Dim thisDGV As DataGridView = Me.dgvProjects
    '        Dim thisTB As TabControl = Me.tabTaskType

    '        Dim test As New DataGridView
    '        test.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '        Dim thisSize As New Drawing.Size
    '        thisSize.Width = thisTB.Size.Width - 400
    '        thisSize.Height = thisTB.Size.Height - 400
    '        test.Size = thisSize

    '        thisTB.TabPages(0).Controls.Add(test)
    '        'thisTB.TabPages(1).Text.ToString()


    '    Catch ex As Exception
    '        If DebugFlag = True Then MessageBox.Show(ex.ToString)
    '    End Try
    'End Sub











    Private Sub pDisplayFreeDates()

        Try

            'Affichage des couleurs de fond
            'Me.texFreeDateInfra.BackColor = ColorForInfra
            'Me.texFreeDateSAP.BackColor = ColorForSAP
            'Me.texFreeDateHelpdesk.BackColor = ColorForHelpdesk
            'Me.texFreeDatePlaning.BackColor = ColorForPlaning

            'On compte le nombre de membres actifs pour chaque tâche
            'Dim myCountMembersInfra = fGetProjectMembersForTask(1)
            'Dim myCountMembersSAP = fGetProjectMembersForTask(2)
            'Dim myCountMembersHelpdesk = fGetProjectMembersForTask(3)
            'Dim myCountMembersPlaning = fGetProjectMembersForTask(4)


            'Dim thisDate As Date = Today
            'Dim FreeNow As Boolean = False

            'Dim StillToPlanInfra As Single = myTotalInfra
            'Dim StillToPlanSAP As Single = myTotalSAP
            'Dim StillToPlanHelpdesk As Single = myTotalHelpdesk
            'Dim StillToPlanPlaning As Single = myTotalPlaning

            'Dim FreeDateInfra As Date = Nothing
            'Dim FreeDateSAP As Date = Nothing
            'Dim FreeDateHelpdesk As Date = Nothing
            'Dim FreeDatePlaning As Date = Nothing

            '================================================================
            'On calcule la première date de libre pour le team infrastructure
            '================================================================
            'FreeNow = False
            'thisDate = Today

            'While FreeNow = False

            '    'On décompte uniquement les jours de libre durant les jours de semaine
            '    Select Case thisDate.DayOfWeek
            '        Case DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday

            '            'On soustrait le nombre de membres de l'infa diminué du nombre de personnes déjà planifiées
            '            StillToPlanInfra = StillToPlanInfra - (myCountMembersInfra - fGetPlanResourcesForTask(1, thisDate))
            '            If StillToPlanInfra < 0 Then
            '                FreeNow = True
            '                FreeDateInfra = thisDate
            '            End If
            '    End Select
            '    thisDate = DateAdd(DateInterval.Day, 1, thisDate)
            'End While
            '================================================================
            'On calcule la première date de libre pour le team infrastructure
            '================================================================


            '================================================================
            'On calcule la première date de libre pour le team SAP
            '================================================================
            'FreeNow = False
            'thisDate = Today

            'While FreeNow = False

            '    'On décompte uniquement les jours de libre durant les jours de semaine
            '    Select Case thisDate.DayOfWeek
            '        Case DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday

            '            'On soustrait le nombre de membres de SAP diminué du nombre de personnes déjà planifiées
            '            StillToPlanSAP = StillToPlanSAP - (myCountMembersSAP - fGetPlanResourcesForTask(2, thisDate))
            '            If StillToPlanSAP < 0 Then
            '                FreeNow = True
            '                FreeDateSAP = thisDate
            '            End If
            '    End Select
            '    thisDate = DateAdd(DateInterval.Day, 1, thisDate)
            'End While
            '================================================================
            'On calcule la première date de libre pour le team SAP
            '================================================================


            '================================================================
            'On calcule la première date de libre pour le team Helpdesk
            '================================================================
            'FreeNow = False
            'thisDate = Today

            'While FreeNow = False

            '    'On décompte uniquement les jours de libre durant les jours de semaine
            '    Select Case thisDate.DayOfWeek
            '        Case DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday

            '            'On soustrait le nombre de membres du helpdesk diminué du nombre de personnes déjà planifiées
            '            StillToPlanHelpdesk = StillToPlanHelpdesk - (myCountMembersHelpdesk - fGetPlanResourcesForTask(3, thisDate))
            '            If StillToPlanHelpdesk < 0 Then
            '                FreeNow = True
            '                FreeDateHelpdesk = thisDate
            '            End If
            '    End Select
            '    thisDate = DateAdd(DateInterval.Day, 1, thisDate)
            'End While
            '================================================================
            'On calcule la première date de libre pour le team Helpdesk
            '================================================================


            '================================================================
            'On calcule la première date de libre pour le team Planification
            '================================================================
            'FreeNow = False
            'thisDate = Today

            'While FreeNow = False

            '    'On décompte uniquement les jours de libre durant les jours de semaine
            '    Select Case thisDate.DayOfWeek
            '        Case DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday

            '            'On soustrait le nombre de membres de la planification diminué du nombre de personnes déjà planifiées
            '            StillToPlanPlaning = StillToPlanPlaning - (myCountMembersPlaning - fGetPlanResourcesForTask(4, thisDate))
            '            If StillToPlanPlaning < 0 Then
            '                FreeNow = True
            '                FreeDatePlaning = thisDate
            '            End If
            '    End Select
            '    thisDate = DateAdd(DateInterval.Day, 1, thisDate)
            'End While
            '================================================================
            'On calcule la première date de libre pour le team Planification
            '================================================================

            'Affichage des soldes
            'Me.texFreeDateInfra.Text = Format(FreeDateInfra, "D")
            'Me.texFreeDateSAP.Text = Format(FreeDateSAP, "D")
            'Me.texFreeDateHelpdesk.Text = Format(FreeDateHelpdesk, "D")
            'Me.texFreeDatePlaning.Text = Format(FreeDatePlaning, "D")











        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Function fGetProjectMembersForTask(ID_Task As Integer) As Integer

        Dim myCount As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_ProjectMember) FROM ProjectsMembers WHERE Enable = 1 AND CE_ID_Task = " & ID_Task

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre COUNT
                Try
                    myCount = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return myCount

    End Function

    Private Function fGetPlanResourcesForTask(ID_Task As Integer, myDay As Date) As Single

        Dim myCount As Integer = 0

        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE PlanDate = '" & fConvertDateOnlyMySQL(myDay) & "' AND CE_ID_ProjectMember IN (SELECT ID_ProjectMember FROM ProjectsMembers WHERE CE_ID_Task = " & ID_Task & ");"

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre COUNT
                Try
                    'Lecture du nombre d'enregistrement (en demi-jour)
                    myCount = myDBDataReader.GetValue(0)

                    'Lecture du nombre d'enregistrements (en jour)
                    myCount = myCount / 2
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return myCount

    End Function

    Private Sub dgvProjets_CellDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvProjects.CellDoubleClick

        Try

            dgvProjects.Rows(dgvProjects.CurrentCell.RowIndex).Selected = True
            ID_Project = dgvProjects.Item(0, dgvProjects.CurrentCell.RowIndex).Value

            Dim myForm As Form = frmProjectDetails
            myForm.ShowDialog()
            myForm.Dispose()

            'Affiche les projets
            pDisplayProjects()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btcExportToExcel_Click(sender As Object, e As EventArgs) Handles btcExportToExcel.Click
        Try

            Me.Cursor = Cursors.WaitCursor
            pExportToExcel()
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub pExportToExcel()

        Try


            'Dim myApplication As Microsoft.Office.Interop.Excel.Application
            'Dim myWorkbook As Microsoft.Office.Interop.Excel.Workbook
            'Dim myWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            'myApplication = New Microsoft.Office.Interop.Excel.Application()
            'myWorkbook = myApplication.Workbooks.Add()


            'Dim NCol As Integer = dgvProjects.Columns.Count
            'Dim NRow As Integer = dgvProjects.RowCount

            'myWorkSheet = DirectCast(myWorkbook.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)

            'myApplication.Application.Visible = True


            'Définition des tâches
            'myWorkSheet.Cells.Item(1, 4) = "Total"
            'myWorkSheet.Cells.Item(1, 5) = "Total"
            'myWorkSheet.Cells.Item(1, 6) = "Total"
            'myWorkSheet.Cells.Item(1, 7) = "Total"
            'myWorkSheet.Cells.Item(1, 8) = "Infrastructure"
            'myWorkSheet.Cells.Item(1, 9) = "Infrastructure"
            'myWorkSheet.Cells.Item(1, 10) = "Infrastructure"
            'myWorkSheet.Cells.Item(1, 11) = "Infrastructure"
            'myWorkSheet.Cells.Item(1, 12) = "SAP"
            'myWorkSheet.Cells.Item(1, 13) = "SAP"
            'myWorkSheet.Cells.Item(1, 14) = "SAP"
            'myWorkSheet.Cells.Item(1, 15) = "SAP"
            'myWorkSheet.Cells.Item(1, 16) = "Helpdesk"
            'myWorkSheet.Cells.Item(1, 17) = "Helpdesk"
            'myWorkSheet.Cells.Item(1, 18) = "Helpdesk"
            'myWorkSheet.Cells.Item(1, 19) = "Helpdesk"
            'myWorkSheet.Cells.Item(1, 20) = "Planification"
            'myWorkSheet.Cells.Item(1, 21) = "Planification"
            'myWorkSheet.Cells.Item(1, 22) = "Planification"
            'myWorkSheet.Cells.Item(1, 23) = "Planification"



            ''Exportation des entêtes de colonnes
            'Dim Count = 1
            'For i As Integer = 1 To NCol
            '    If dgvProjects.Columns(i - 1).Visible = True Then
            '        myWorkSheet.Cells.Item(2, Count) = dgvProjects.Columns(i - 1).Name
            '        Count = Count + 1
            '    End If
            'Next


            ''Exportation des données
            'For i As Integer = 0 To dgvProjects.Rows.Count - 1
            '    Dim cant As Integer = 1
            '    For j As Integer = 0 To dgvProjects.Columns.Count - 1
            '        If dgvProjects.Columns(j).Visible = True Then
            '            myWorkSheet.Cells(i + 3, cant) = dgvProjects.Rows(i).Cells(j).Value
            '            cant = cant + 1
            '        End If
            '    Next
            'Next

            ''Définition des couleurs
            'Dim MyColor As Color
            'Dim MyColorRGB As Integer
            'Dim myRange As String = ""

            ''Total
            'MyColor = ColorForTotal
            'MyColorRGB = RGB(MyColor.R, MyColor.G, MyColor.B)
            'myRange = CStr("D1:G" & dgvProjects.Rows.Count + 2)
            'myWorkSheet.Range(myRange).Interior.Color = MyColorRGB

            ''Infrastructure
            'MyColor = ColorForInfra
            'MyColorRGB = RGB(MyColor.R, MyColor.G, MyColor.B)
            'myRange = CStr("H1:K" & dgvProjects.Rows.Count + 2)
            'myWorkSheet.Range(myRange).Interior.Color = MyColorRGB

            ''SAP
            'MyColor = ColorForSAP
            'MyColorRGB = RGB(MyColor.R, MyColor.G, MyColor.B)
            'myRange = CStr("L1:O" & dgvProjects.Rows.Count + 2)
            'myWorkSheet.Range(myRange).Interior.Color = MyColorRGB

            ''Helpdesk
            'MyColor = ColorForHelpdesk
            'MyColorRGB = RGB(MyColor.R, MyColor.G, MyColor.B)
            'myRange = CStr("P1:S" & dgvProjects.Rows.Count + 2)
            'myWorkSheet.Range(myRange).Interior.Color = MyColorRGB

            ''Planification
            'MyColor = ColorForPlaning
            'MyColorRGB = RGB(MyColor.R, MyColor.G, MyColor.B)
            'myRange = CStr("T1:W" & dgvProjects.Rows.Count + 2)
            'myWorkSheet.Range(myRange).Interior.Color = MyColorRGB


            'myWorkSheet.Rows.Item(1).Font.Bold = 1
            'myWorkSheet.Rows.Item(2).Font.Bold = 1
            'myWorkSheet.Rows.Item(dgvProjects.Rows.Count + 2).Font.Bold = 1
            'myWorkSheet.Rows.Item(1).HorizontalAlignment = 3
            'myWorkSheet.Columns.AutoFit()
            'myApplication.Application.Visible = True


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub pDisplayResouces(thisDGV As DataGridView, ID_Task As Integer)

        Try

            'Déclaration des variables

            Dim myDBDataReader As MySqlDataReader
            Dim MyDBConnection As New MySqlConnection
            Dim Sql As String = ""


            Dim myMember As New myProjectMember
            Dim myStat As New myStatistics

            'Projets planifiés
            Dim PP1mois As String = ""
            Dim PP3mois As String = ""
            Dim PP6mois As String = ""
            Dim PP12mois As String = ""
            Dim PPYear As String = ""

            'Administratif planifiés
            Dim AP1mois As String = ""
            Dim AP3mois As String = ""
            Dim AP6mois As String = ""
            Dim AP12mois As String = ""
            Dim APYear As String = ""

            'libres
            Dim F1mois As String = ""
            Dim F3mois As String = ""
            Dim F6mois As String = ""
            Dim F12mois As String = ""
            Dim FYear As String = ""

            'Totaux
            Dim PPTotal1mois As Single = 0
            Dim PPTotal3mois As Single = 0
            Dim PPTotal6mois As Single = 0
            Dim PPTotal12mois As Single = 0
            Dim PPTotalYear As Single = 0

            Dim APTotal1mois As Single = 0
            Dim APTotal3mois As Single = 0
            Dim APTotal6mois As Single = 0
            Dim APTotal12mois As Single = 0
            Dim APTotalYear As Single = 0

            Dim FTotal1mois As Single = 0
            Dim FTotal3mois As Single = 0
            Dim FTotal6mois As Single = 0
            Dim FTotal12mois As Single = 0
            Dim FTotalYear As Single = 0

            'On vide le DataGridView
            thisDGV.Rows.Clear()
            thisDGV.Columns.Clear()

            'On rend certains éléments invisible durant le chargement des données
            'thisDGV.Visible = False

            'Définition du DataGridView
            thisDGV.ReadOnly = True
            thisDGV.AllowUserToAddRows = False
            thisDGV.AllowUserToDeleteRows = False
            thisDGV.MultiSelect = False



            'Définition des colonnes
            thisDGV.Columns.Add("", "")
            thisDGV.Columns.Add("1 mois", "1 mois")
            thisDGV.Columns.Add("3 mois", "3 mois")
            thisDGV.Columns.Add("6 mois", "6 mois")
            thisDGV.Columns.Add("12 mois", "12 mois")
            thisDGV.Columns.Add("fin année", "fin année")

            'On ajoute les lignes
            thisDGV.Rows.Add()
            thisDGV.Rows.Add()
            thisDGV.Rows.Add()
            thisDGV.Item(0, 0).Value = "Planifié projet"
            thisDGV.Item(0, 1).Value = "Planifié administratif"
            thisDGV.Item(0, 2).Value = "Libre"



            'Commande sQL
            Sql = "SELECT ID_ProjectMember FROM ProjectsMembers WHERE Enable = 1 AND CE_ID_Task=" & ID_Task
            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                Try
                    'Lecture du projet
                    myMember.ID_ProjectMember = myDBDataReader.GetValue(0)
                    myMember.Read()
                Catch ex As Exception
                End Try

                myStat.ID_ProjectMember = myMember.ID_ProjectMember
                myStat.GetProjectDays()
                myStat.GetAdminDays()
                myStat.GetFreeDays()

                'Nom de la personne
                Dim thisName As String = UCase(Microsoft.VisualBasic.Left(myMember.Lastname, 2) & Microsoft.VisualBasic.Left(myMember.FirstName, 1))

                thisName = Replace(thisName, "Ü", "U")
                thisName = Replace(thisName, "Ù", "U")
                thisName = Replace(thisName, "Ú", "U")
                thisName = Replace(thisName, "Û", "U")
                thisName = Replace(thisName, "Ä", "A")
                thisName = Replace(thisName, "À", "A")
                thisName = Replace(thisName, "Á", "A")
                thisName = Replace(thisName, "Â", "A")
                thisName = Replace(thisName, "Ê", "E")
                thisName = Replace(thisName, "È", "E")
                thisName = Replace(thisName, "É", "E")
                thisName = Replace(thisName, "Ë", "E")
                thisName = Replace(thisName, "Î", "I")
                thisName = Replace(thisName, "Ì", "I")
                thisName = Replace(thisName, "Í", "I")
                thisName = Replace(thisName, "Î", "I")


                'Projets planifiés

                PPTotal1mois = PPTotal1mois + myStat.DaysOnProjects1Month
                PPTotal3mois = PPTotal3mois + myStat.DaysOnProjects3Month
                PPTotal6mois = PPTotal6mois + myStat.DaysOnProjects6Month
                PPTotal12mois = PPTotal12mois + myStat.DaysOnProjects12Month
                PPTotalYear = PPTotalYear + myStat.DaysOnProjectsEndYear

                If PP1mois = "" Then
                    PP1mois = thisName & " : " & Format(myStat.DaysOnProjects1Month, "0.0")
                Else
                    PP1mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnProjects1Month, "0.0")
                End If

                If PP3mois = "" Then
                    PP3mois = thisName & " : " & Format(myStat.DaysOnProjects3Month, "0.0")
                Else
                    PP3mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnProjects3Month, "0.0")
                End If

                If PP6mois = "" Then
                    PP6mois = thisName & " : " & Format(myStat.DaysOnProjects6Month, "0.0")
                Else
                    PP6mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnProjects6Month, "0.0")
                End If

                If PP12mois = "" Then
                    PP12mois = thisName & " : " & Format(myStat.DaysOnProjects12Month, "0.0")
                Else
                    PP12mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnProjects12Month, "0.0")
                End If

                If PPYear = "" Then
                    PPYear = thisName & " : " & Format(myStat.DaysOnProjectsEndYear, "0.0")
                Else
                    PPYear &= vbCrLf & thisName & " : " & Format(myStat.DaysOnProjectsEndYear, "0.0")
                End If





                'Administrtatif planifié

                APTotal1mois = APTotal1mois + myStat.DaysOnAdmin1Month
                APTotal3mois = APTotal3mois + myStat.DaysOnAdmin3Month
                APTotal6mois = APTotal6mois + myStat.DaysOnAdmin6Month
                APTotal12mois = APTotal12mois + myStat.DaysOnAdmin12Month
                APTotalYear = APTotalYear + myStat.DaysOnAdminEndYear

                If AP1mois = "" Then
                    AP1mois = thisName & " : " & Format(myStat.DaysOnAdmin1Month, "0.0")
                Else
                    AP1mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnAdmin1Month, "0.0")
                End If

                If AP3mois = "" Then
                    AP3mois = thisName & " : " & Format(myStat.DaysOnAdmin3Month, "0.0")
                Else
                    AP3mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnAdmin3Month)
                End If

                If AP6mois = "" Then
                    AP6mois = thisName & " : " & Format(myStat.DaysOnAdmin6Month, "0.0")
                Else
                    AP6mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnAdmin6Month, "0.0")
                End If

                If AP12mois = "" Then
                    AP12mois = thisName & " : " & Format(myStat.DaysOnAdmin12Month, "0.0")
                Else
                    AP12mois &= vbCrLf & thisName & " : " & Format(myStat.DaysOnAdmin12Month, "0.0")
                End If

                If APYear = "" Then
                    APYear = thisName & " : " & Format(myStat.DaysOnAdminEndYear, "0.0")
                Else
                    APYear &= vbCrLf & thisName & " : " & Format(myStat.DaysOnAdminEndYear, "0.0")
                End If





                'Ressources libres

                FTotal1mois = FTotal1mois + myStat.DaysFree1Month
                FTotal3mois = FTotal3mois + myStat.DaysFree3Month
                FTotal6mois = FTotal6mois + myStat.DaysFree6Month
                FTotal12mois = FTotal12mois + myStat.DaysFree12Month
                FTotalYear = FTotalYear + myStat.DaysFreeEndYear

                If F1mois = "" Then
                    F1mois = thisName & " : " & Format(myStat.DaysFree1Month, "0.0")
                Else
                    F1mois &= vbCrLf & thisName & " : " & Format(myStat.DaysFree1Month, "0.0")
                End If

                If F3mois = "" Then
                    F3mois = thisName & " : " & Format(myStat.DaysFree3Month, "0.0")
                Else
                    F3mois &= vbCrLf & thisName & " : " & Format(myStat.DaysFree3Month, "0.0")
                End If

                If F6mois = "" Then
                    F6mois = thisName & " : " & Format(myStat.DaysFree6Month, "0.0")
                Else
                    F6mois &= vbCrLf & thisName & " : " & Format(myStat.DaysFree6Month, "0.0")
                End If

                If F12mois = "" Then
                    F12mois = thisName & " : " & Format(myStat.DaysFree12Month, "0.0")
                Else
                    F12mois &= vbCrLf & thisName & " : " & Format(myStat.DaysFree12Month, "0.0")
                End If

                If FYear = "" Then
                    FYear = thisName & " : " & Format(myStat.DaysFreeEndYear, "0.0")
                Else
                    FYear &= vbCrLf & thisName & " : " & Format(myStat.DaysFreeEndYear, "0.0")
                End If



            End While


            'On ajoute les totaux
            PP1mois &= vbCrLf & "Total : " & CStr(PPTotal1mois)
            PP3mois &= vbCrLf & "Total : " & CStr(PPTotal3mois)
            PP6mois &= vbCrLf & "Total : " & CStr(PPTotal6mois)
            PP12mois &= vbCrLf & "Total : " & CStr(PPTotal12mois)
            PPYear &= vbCrLf & "Total : " & CStr(PPTotalYear)

            AP1mois &= vbCrLf & "Total : " & CStr(APTotal1mois)
            AP3mois &= vbCrLf & "Total : " & CStr(APTotal3mois)
            AP6mois &= vbCrLf & "Total : " & CStr(APTotal6mois)
            AP12mois &= vbCrLf & "Total : " & CStr(APTotal12mois)
            APYear &= vbCrLf & "Total : " & CStr(APTotalYear)

            F1mois &= vbCrLf & "Total : " & CStr(FTotal1mois)
            F3mois &= vbCrLf & "Total : " & CStr(FTotal3mois)
            F6mois &= vbCrLf & "Total : " & CStr(FTotal6mois)
            F12mois &= vbCrLf & "Total : " & CStr(FTotal12mois)
            FYear &= vbCrLf & "Total : " & CStr(FTotalYear)


            'On remplit la grille
            'thisDGV.Item(colonne, ligne).value

            thisDGV.Item(1, 0).Value = PP1mois
            thisDGV.Item(2, 0).Value = PP3mois
            thisDGV.Item(3, 0).Value = PP6mois
            thisDGV.Item(4, 0).Value = PP12mois
            thisDGV.Item(5, 0).Value = PPYear

            thisDGV.Item(1, 1).Value = AP1mois
            thisDGV.Item(2, 1).Value = AP3mois
            thisDGV.Item(3, 1).Value = AP6mois
            thisDGV.Item(4, 1).Value = AP12mois
            thisDGV.Item(5, 1).Value = APYear

            thisDGV.Item(1, 2).Value = F1mois
            thisDGV.Item(2, 2).Value = F3mois
            thisDGV.Item(3, 2).Value = F6mois
            thisDGV.Item(4, 2).Value = F12mois
            thisDGV.Item(5, 2).Value = FYear



            'On met la grille en mode multiligne
            thisDGV.Rows(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            thisDGV.Rows(1).DefaultCellStyle.WrapMode = DataGridViewTriState.True
            thisDGV.Rows(2).DefaultCellStyle.WrapMode = DataGridViewTriState.True

            'On resize la lignes
            thisDGV.AutoResizeRow(0, autoSizeRowMode:=DataGridViewAutoSizeRowMode.AllCells)
            thisDGV.AutoResizeRow(1, autoSizeRowMode:=DataGridViewAutoSizeRowMode.AllCells)
            thisDGV.AutoResizeRow(2, autoSizeRowMode:=DataGridViewAutoSizeRowMode.AllCells)

            'On resize les colonnes
            For i = 0 To 5
                thisDGV.AutoResizeColumn(i)
            Next i


            'On aligne le texte
            For i = 1 To 5
                thisDGV.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next i


            'On empêche de trier les colonnes de manière alphabétiques
            For i = 0 To 5
                thisDGV.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            Next i


            Select Case ID_Task
                Case 1
                    'dgvInfrastructure.DefaultCellStyle.BackColor = ColorForInfra

                Case 2
                    'dgvSAP.DefaultCellStyle.BackColor = ColorForSAP

                Case 3
                    'dgvHelpdesk.DefaultCellStyle.BackColor = ColorForHelpdesk

                Case 4
                    'dgvPlaning.DefaultCellStyle.BackColor = ColorForPlaning

            End Select



            myDBDataReader.Close()
            MyDBConnection.Close()


            Me.Cursor = Cursors.Default

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Function fGetPlanedResources(ID_Task As Integer, IsProject As Boolean, IsAdminResource As Boolean, CountDate As Date) As String

        Dim SQL As String = ""
        Dim myTotal As Integer = 0
        Dim myGrandTotal As Integer = 0
        Dim myResult As String = ""


        Dim myProjectMember As New myProjectMember

        Try
            'On recherche tous les membres de projets par tâche

            SQL &= "SELECT "
            SQL &= "    projectsmembers.ID_ProjectMember "
            SQL &= "FROM "
            SQL &= "    ProjectPlan.projectsmembers "
            SQL &= "    LEFT JOIN ProjectPlan.tasks  "
            SQL &= "        ON (projectsmembers.CE_ID_Task = tasks.ID_Task) "
            SQL &= "WHERE ( "
            SQL &= "tasks.Enable =1 "
            SQL &= "AND CE_ID_Task = " & ID_Task
            SQL &= "); "


            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read   'Boucle des membres de projects

                'Lecture des members de projets
                Try
                    myProjectMember.ID_ProjectMember = myDBDataReader.GetValue(0)
                    myProjectMember.Read()
                Catch ex As Exception
                End Try

                'Lecture des ressources planifiées par membre de projet
                SQL = ""
                SQL &= "SELECT "
                SQL &= "COUNT(ID_Resource) "
                SQL &= "FROM "
                SQL &= "Planresources "
                SQL &= "WHERE (PlanDate <= '" & fConvertDateOnlyMySQL(CountDate) & "' "
                SQL &= "AND CE_ID_ProjectMember = " & myProjectMember.ID_ProjectMember & " "
                If IsAdminResource = True Then
                    SQL &= "AND CE_ID_Project = 0 "
                    SQL &= "AND CE_ID_AdminResource <> 0) "
                End If
                If IsProject = True Then
                    SQL &= "AND CE_ID_Project <> 0 "
                    SQL &= "AND CE_ID_AdminResource = 0) "
                End If

                SQL &= ";"

                'On compte ce qui planifié pour chaque membre de projet

                Dim MyDBConnection2 As New MySqlConnection
                Dim myDBDataReader2 As MySqlDataReader
                MyDBConnection2.ConnectionString = cnProjectPlan
                MyDBConnection2.Open()
                Dim myDBCommand2 As MySqlCommand = New MySqlCommand(SQL, MyDBConnection2)
                myDBDataReader2 = myDBCommand2.ExecuteReader()
                While myDBDataReader2.Read  'Boucle des ressources planifiées par membre de projet
                    Try
                        myTotal = myDBDataReader2.GetValue(0)
                    Catch ex As Exception
                    End Try

                    myGrandTotal += myTotal

                    If myResult = "" Then
                        myResult &= myProjectMember.FirstName & " : " & myTotal
                    Else
                        myResult &= vbCrLf & myProjectMember.FirstName & " : " & myTotal
                    End If


                End While  'Boucle des ressources planifiées par membre de projet
                myDBDataReader2.Close()
                MyDBConnection2.Close()

            End While   'Boucle des membres de projects

            myDBDataReader.Close()
            MyDBConnection.Close()

            If myResult <> "" Then
                myResult &= vbCrLf
            End If
            myResult &= "TOTAL : " & myGrandTotal





        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return myResult

    End Function

    Private Function fGetFreeResources(ID_Task As Integer, CountDate As Date) As String


        Dim SQL As String = ""
        Dim myTotalResources As Integer = 0
        Dim myTotalPlanedResources As Integer = 0
        Dim myFreeResources As Integer = 0
        Dim myGrandTotal As Integer = 0
        Dim myResult As String = ""


        Dim myProjectMember As New myProjectMember

        Try


            'On compte le nombre de ressources totales jusqu'à la date données
            SQL = ""
            SQL &= "SELECT "
            SQL &= "COUNT(ID_Resource) "
            SQL &= "FROM "
            SQL &= "Planresources "
            SQL &= "WHERE (PlanDate <= '" & fConvertDateOnlyMySQL(CountDate) & "' "
            SQL &= "AND CE_ID_ProjectMember = 0) "
            'On ne calcule que les dates de libre en semaine
            SQL &= "AND (WEEKDAY(PlanDate)=0 Or WEEKDAY(PlanDate)=1 Or WEEKDAY(PlanDate)=2 Or WEEKDAY(PlanDate)=3 Or WEEKDAY(PlanDate)=4)"
            SQL &= ";"
            '================================================================================================
            'WEEKDAY
            'Syntax : WEEKDAY(date)
            'Description : returns the weekday index for date (0 = Monday, 1 = Tuesday, ... 6 = Sunday).
            '================================================================================================

            Dim MyDBConnection2 As New MySqlConnection
            Dim myDBDataReader2 As MySqlDataReader
            MyDBConnection2.ConnectionString = cnProjectPlan
            MyDBConnection2.Open()
            Dim myDBCommand2 As MySqlCommand = New MySqlCommand(SQL, MyDBConnection2)
            myDBDataReader2 = myDBCommand2.ExecuteReader()
            While myDBDataReader2.Read  'Boucle des ressources planifiées par membre de projet
                Try
                    myTotalResources = myDBDataReader2.GetValue(0)
                Catch ex As Exception
                End Try

            End While  'Boucle des ressources planifiées par membre de projet
            myDBDataReader2.Close()
            MyDBConnection2.Close()




            'On recherche tous les membres de projets par tâche

            SQL = ""
            SQL &= "SELECT "
            SQL &= "    projectsmembers.ID_ProjectMember "
            SQL &= "FROM "
            SQL &= "    ProjectPlan.projectsmembers "
            SQL &= "    LEFT JOIN ProjectPlan.tasks  "
            SQL &= "        ON (projectsmembers.CE_ID_Task = tasks.ID_Task) "
            SQL &= "WHERE ( "
            SQL &= "tasks.Enable =1 "
            SQL &= "And CE_ID_Task = " & ID_Task
            SQL &= "); "


            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read   'Boucle des membres de projects

                'Lecture des members de projets
                Try
                    myProjectMember.ID_ProjectMember = myDBDataReader.GetValue(0)
                    myProjectMember.Read()
                Catch ex As Exception
                End Try



                'On compte le nombre de ressources totales planifiées par membre de projet
                SQL = ""
                SQL &= "SELECT "
                SQL &= "COUNT(ID_Resource) "
                SQL &= "FROM "
                SQL &= "Planresources "
                SQL &= "WHERE (PlanDate <= '" & fConvertDateOnlyMySQL(CountDate) & "' "
                SQL &= "AND CE_ID_ProjectMember = " & myProjectMember.ID_ProjectMember & ");"

                Dim MyDBConnection3 As New MySqlConnection
                Dim myDBDataReader3 As MySqlDataReader
                MyDBConnection3.ConnectionString = cnProjectPlan
                MyDBConnection3.Open()
                Dim myDBCommand3 As MySqlCommand = New MySqlCommand(SQL, MyDBConnection3)
                myDBDataReader3 = myDBCommand3.ExecuteReader()
                While myDBDataReader3.Read  'Boucle des ressources planifiées par membre de projet
                    Try
                        myTotalPlanedResources = myDBDataReader3.GetValue(0)
                    Catch ex As Exception
                    End Try

                End While  'Boucle des ressources planifiées par membre de projet
                myDBDataReader3.Close()
                MyDBConnection3.Close()

                myFreeResources = myTotalResources - myTotalPlanedResources
                myGrandTotal += myFreeResources

                If myResult = "" Then
                    myResult &= myProjectMember.FirstName & " : " & myFreeResources
                Else
                    myResult &= vbCrLf & myProjectMember.FirstName & " : " & myFreeResources
                End If


            End While   'Boucle des membres de projects

            myDBDataReader.Close()
            MyDBConnection.Close()

            If myResult <> "" Then
                myResult &= vbCrLf
            End If
            myResult &= "TOTAL : " & myGrandTotal



        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return myResult

    End Function
End Class