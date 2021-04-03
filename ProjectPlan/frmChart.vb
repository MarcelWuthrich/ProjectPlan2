Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Globalization


Public Class frmChart
    Private Sub frmChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            pDisplayChart()


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



    Private Sub pDisplayChart()

        Try
            'Déclaration des variables
            Dim I As Integer = 0
            Dim myCI As CultureInfo = New CultureInfo("fr-FR")
            Dim myCal As Calendar = myCI.Calendar
            Dim KW As Integer = 0
            Dim myLabel As String = ""


            'On efface les données du chart
            myChart.Series.Clear()


            ''On définit le chart
            'myChart.Width = 1400
            'myChart.Height = 700

            'On définit les axes
            'On affiche les ressources planifiées
            'If radTotal.Checked = True Then myChart.ChartAreas(0).AxisY.Maximum = fDefineAxeY(0)
            'If radInfrastructure.Checked = True Then myChart.ChartAreas(0).AxisY.Maximum = fDefineAxeY(1)
            'If radSAP.Checked = True Then myChart.ChartAreas(0).AxisY.Maximum = fDefineAxeY(2)
            'If radHelpdesk.Checked = True Then myChart.ChartAreas(0).AxisY.Maximum = fDefineAxeY(3)
            'If radPlanification.Checked = True Then myChart.ChartAreas(0).AxisY.Maximum = fDefineAxeY(4)
            myChart.ChartAreas(0).AxisY.Maximum = fDefineAxeY(0)

            myChart.ChartAreas(0).AxisY.Minimum = 0

            'On définit le chart des ressources planifiées
            Dim Series1 As New Series("Heures planifiées")
            'Series1.ChartType = SeriesChartType.Line

            'On définit le chart des ressources qui doivent encore être planifiées
            Dim Series2 As New Series("Heures encore libre")

            'On définit un chart sur 52 semaines (avec 1 avant et 1 après pour éviter de couper l'affichage)
            myChart.ChartAreas(0).AxisX.Minimum = 0
            myChart.ChartAreas(0).AxisX.Maximum = 52 + 1

            'On active le zoom sur le graphique
            myChart.ChartAreas(0).CursorX.IsUserSelectionEnabled = True

            'On recherche la date du prochain lundi (la semaine prochaine si on est lundi)
            Dim NextMonday As Date = Nothing
            Dim currentDay As Date = DateAdd(DateInterval.Day, 1, Today)
            Do
                If Weekday(currentDay) = vbMonday Then
                    NextMonday = currentDay
                Else
                    currentDay = DateAdd(DateInterval.Day, 1, currentDay)
                End If
            Loop Until NextMonday <> Nothing

            'On affiche les données des 52 prochaines semaines
            Dim Next52Mondays As Date = NextMonday

            Dim myCountResource As Single = 0

            'On affiche toutes les semaines. Le numéro de la semaine est calculé depuis lundi
            For I = 0 To 51
                KW = myCal.GetWeekOfYear(Next52Mondays, System.Globalization.CalendarWeekRule.FirstFourDayWeek, vbSunday)
                If KW = 53 Then
                    'Si on a la semaine 53, c'est qu'on a encore le dernier lundi en décembre
                    'On passe à la semaine 1 et on incrémente l'année
                    KW = 1
                    myLabel = KW & "/" & Year(Next52Mondays) + 1
                Else
                    myLabel = KW & "/" & Year(Next52Mondays)
                End If

                'On affiche les ressources planifiées
                'If radTotal.Checked = True Then myCountResource = fGetPlanResources(Next52Mondays, 0)
                'If radInfrastructure.Checked = True Then myCountResource = fGetPlanResources(Next52Mondays, 1)
                'If radSAP.Checked = True Then myCountResource = fGetPlanResources(Next52Mondays, 2)
                'If radHelpdesk.Checked = True Then myCountResource = fGetPlanResources(Next52Mondays, 3)
                'If radPlanification.Checked = True Then myCountResource = fGetPlanResources(Next52Mondays, 4)
                myCountResource = fGetPlanResources(Next52Mondays, 0)

                'On affiche ce qui est planifié
                Series1.Points.AddXY(myLabel, myCountResource)
                Series1.Points(I).ToolTip = myCountResource

                'On compte le nombre de personnes de chaque type de tâches
                Dim myMembers As Integer = 0
                'If radTotal.Checked = True Then myMembers = fGetMembers(0)
                'If radInfrastructure.Checked = True Then myMembers = fGetMembers(1)
                'If radSAP.Checked = True Then myMembers = fGetMembers(2)
                'If radHelpdesk.Checked = True Then myMembers = fGetMembers(3)
                'If radPlanification.Checked = True Then myMembers = fGetMembers(4)
                myMembers = fGetMembers(0)

                'Chaque personne travaille 40 heures par semaine.
                'Par définition, ce qui n'est pas planifié est libre
                Dim myFree As Single = (myMembers * 40) - myCountResource

                'Si des jours sont planifiés le week-end, on peut avoir un total négatif.
                'Il faut donc corriger pour ne pas être négatif
                If myFree < 0 Then myFree = 0
                Series2.Points.AddXY(myLabel, myFree)
                Series2.Points(I).ToolTip = myFree

                'On incrémente au lundi suivant
                Next52Mondays = DateAdd(DateInterval.Day, 7, Next52Mondays)

            Next I



            myChart.ChartAreas(0).AxisX.Interval = 1
            myChart.ChartAreas(0).AxisY.Interval = 20


            'On ajoute les séries aux chart
            myChart.Series.Add(Series1)
            myChart.Series.Add(Series2)

            myChart.Series(0).Color = Color.Red
            myChart.Series(1).Color = Color.Blue

            myChart.ChartAreas(0).AxisY.Title = "Heures"
            myChart.ChartAreas(0).AxisX.Title = "Semaines"


        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Function fDefineAxeY(TaskType As Integer) As Integer

        Dim AxeY As Integer = 0

        Try

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""
            Dim MyDBConnection As New MySqlConnection

            Select Case TaskType
                Case 1, 2, 3, 4
                    'On recherche le nombre de personnes par type
                    SQL = "SELECT COUNT(ID_ProjectMember) FROM ProjectsMembers WHERE Enable = 1 and CE_ID_Task=" & TaskType & ";"
                Case Else
                    'On recherche le nombre de personnes par type
                    SQL = "SELECT COUNT(ID_ProjectMember) FROM ProjectsMembers WHERE Enable = 1 ;"
            End Select
            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                Try
                    AxeY = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            'On multiplie par 40 heures par semaine et on incrémente à la dizaine supérieure
            AxeY = AxeY * 40

            Dim myDizaine As Integer = Math.Truncate(AxeY / 10)
            myDizaine = (myDizaine + 1) * 10
            AxeY = myDizaine

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return AxeY

    End Function





    Private Function fGetPlanResources(thisMonday As Date, TaskType As Integer) As Single

        Dim CountResource As Single = 0

        Try
            Dim MondayIn1Week As Date = DateAdd(DateInterval.Day, 7, thisMonday)

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""
            Dim MyDBConnection As New MySqlConnection

            Select Case TaskType
                Case 1, 2, 3, 4
                    'On recherche la planification pour infrastructure, SAP, helpdesk ou planification
                    SQL = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE PlanDate >='" & fConvertDateTimeMySQL(thisMonday) & "' AND PlanDate < '" & fConvertDateTimeMySQL(MondayIn1Week) & "' AND CE_ID_ProjectMember IN (SELECT ID_ProjectMember FROM ProjectsMembers WHERE CE_ID_Task=" & TaskType & " AND Enable=1);"
                Case Else
                    'Dans les autre cas, on revoie toutes les valeurs
                    SQL = "SELECT COUNT(ID_Resource) FROM PlanResources WHERE PlanDate >='" & fConvertDateTimeMySQL(thisMonday) & "' AND PlanDate < '" & fConvertDateTimeMySQL(MondayIn1Week) & "'  AND CE_ID_ProjectMember IN (SELECT ID_ProjectMember FROM ProjectsMembers WHERE Enable=1);"
            End Select
            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read


                Try
                    CountResource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            'On veut le résultat en jours et pas en demi-jours
            CountResource = CountResource / 2
            'On veut le résultat en heures
            CountResource = CountResource

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return CountResource

    End Function



    Private Function fGetMembers(TaskType As Integer) As Integer

        Dim CountMembers As Integer = 0

        Try

            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""
            Dim MyDBConnection As New MySqlConnection

            Select Case TaskType
                Case 1, 2, 3, 4
                    'On recherche la planification pour infrastructure, SAP, helpdesk ou planification
                    SQL = "SELECT COUNT(ID_ProjectMember) FROM ProjectsMembers WHERE CE_ID_Task=" & TaskType & " AND Enable=1;"
                Case Else
                    'Dans les autre cas, on revoie toutes les valeurs
                    SQL = "SELECT COUNT(ID_ProjectMember) FROM ProjectsMembers WHERE Enable=1;"
            End Select
            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read


                Try
                    CountMembers = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Return CountMembers

    End Function


End Class