<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.texTask1 = New System.Windows.Forms.TextBox()
        Me.texTask2 = New System.Windows.Forms.TextBox()
        Me.texTask3 = New System.Windows.Forms.TextBox()
        Me.texTask4 = New System.Windows.Forms.TextBox()
        Me.texTaskTotal = New System.Windows.Forms.TextBox()
        Me.btcFermer = New System.Windows.Forms.Button()
        Me.tabTaskType = New System.Windows.Forms.TabControl()
        Me.texFreeDateInfra = New System.Windows.Forms.TextBox()
        Me.labFreeDateInfra = New System.Windows.Forms.Label()
        Me.labFreeDateSAP = New System.Windows.Forms.Label()
        Me.texFreeDateSAP = New System.Windows.Forms.TextBox()
        Me.labFreeDateHelpdesk = New System.Windows.Forms.Label()
        Me.texFreeDateHelpdesk = New System.Windows.Forms.TextBox()
        Me.labFreeDatePlaning = New System.Windows.Forms.Label()
        Me.texFreeDatePlaning = New System.Windows.Forms.TextBox()
        Me.grpNextFreeDate = New System.Windows.Forms.GroupBox()
        Me.btcExportToExcel = New System.Windows.Forms.Button()
        Me.texTask8 = New System.Windows.Forms.TextBox()
        Me.texTask7 = New System.Windows.Forms.TextBox()
        Me.texTask6 = New System.Windows.Forms.TextBox()
        Me.texTask5 = New System.Windows.Forms.TextBox()
        Me.texTask10 = New System.Windows.Forms.TextBox()
        Me.texTask9 = New System.Windows.Forms.TextBox()
        Me.btcRefresh = New System.Windows.Forms.Button()
        Me.btcChart = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.dgvTabPage1 = New System.Windows.Forms.DataGridView()
        Me.dgvTabPage2 = New System.Windows.Forms.DataGridView()
        Me.dgvTabPage3 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTaskType.SuspendLayout()
        Me.grpNextFreeDate.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvTabPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTabPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTabPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProjects
        '
        Me.dgvProjects.AllowUserToResizeColumns = False
        Me.dgvProjects.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(23, 73)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjects.Size = New System.Drawing.Size(1550, 495)
        Me.dgvProjects.TabIndex = 0
        '
        'texTask1
        '
        Me.texTask1.Location = New System.Drawing.Point(402, 23)
        Me.texTask1.Name = "texTask1"
        Me.texTask1.ReadOnly = True
        Me.texTask1.Size = New System.Drawing.Size(100, 20)
        Me.texTask1.TabIndex = 5
        Me.texTask1.Text = "Task1"
        Me.texTask1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask2
        '
        Me.texTask2.Location = New System.Drawing.Point(508, 23)
        Me.texTask2.Name = "texTask2"
        Me.texTask2.ReadOnly = True
        Me.texTask2.Size = New System.Drawing.Size(100, 20)
        Me.texTask2.TabIndex = 6
        Me.texTask2.Text = "Task2"
        Me.texTask2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask3
        '
        Me.texTask3.Location = New System.Drawing.Point(614, 23)
        Me.texTask3.Name = "texTask3"
        Me.texTask3.ReadOnly = True
        Me.texTask3.Size = New System.Drawing.Size(100, 20)
        Me.texTask3.TabIndex = 7
        Me.texTask3.Text = "Task3"
        Me.texTask3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask4
        '
        Me.texTask4.Location = New System.Drawing.Point(720, 23)
        Me.texTask4.Name = "texTask4"
        Me.texTask4.ReadOnly = True
        Me.texTask4.Size = New System.Drawing.Size(100, 20)
        Me.texTask4.TabIndex = 8
        Me.texTask4.Text = "Task4"
        Me.texTask4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTaskTotal
        '
        Me.texTaskTotal.Location = New System.Drawing.Point(296, 23)
        Me.texTaskTotal.Name = "texTaskTotal"
        Me.texTaskTotal.ReadOnly = True
        Me.texTaskTotal.Size = New System.Drawing.Size(100, 20)
        Me.texTaskTotal.TabIndex = 9
        Me.texTaskTotal.Text = "Total"
        Me.texTaskTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btcFermer
        '
        Me.btcFermer.Location = New System.Drawing.Point(24, 19)
        Me.btcFermer.Name = "btcFermer"
        Me.btcFermer.Size = New System.Drawing.Size(75, 23)
        Me.btcFermer.TabIndex = 10
        Me.btcFermer.Text = "Fermer"
        Me.btcFermer.UseVisualStyleBackColor = True
        '
        'tabTaskType
        '
        Me.tabTaskType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabTaskType.Controls.Add(Me.TabPage1)
        Me.tabTaskType.Controls.Add(Me.TabPage2)
        Me.tabTaskType.Controls.Add(Me.TabPage3)
        Me.tabTaskType.Controls.Add(Me.TabPage4)
        Me.tabTaskType.Controls.Add(Me.TabPage5)
        Me.tabTaskType.Controls.Add(Me.TabPage6)
        Me.tabTaskType.Controls.Add(Me.TabPage7)
        Me.tabTaskType.Controls.Add(Me.TabPage8)
        Me.tabTaskType.Controls.Add(Me.TabPage9)
        Me.tabTaskType.Controls.Add(Me.TabPage10)
        Me.tabTaskType.Location = New System.Drawing.Point(23, 581)
        Me.tabTaskType.Name = "tabTaskType"
        Me.tabTaskType.SelectedIndex = 0
        Me.tabTaskType.Size = New System.Drawing.Size(565, 298)
        Me.tabTaskType.TabIndex = 11
        '
        'texFreeDateInfra
        '
        Me.texFreeDateInfra.Location = New System.Drawing.Point(138, 42)
        Me.texFreeDateInfra.Name = "texFreeDateInfra"
        Me.texFreeDateInfra.ReadOnly = True
        Me.texFreeDateInfra.Size = New System.Drawing.Size(154, 20)
        Me.texFreeDateInfra.TabIndex = 12
        '
        'labFreeDateInfra
        '
        Me.labFreeDateInfra.AutoSize = True
        Me.labFreeDateInfra.Location = New System.Drawing.Point(34, 45)
        Me.labFreeDateInfra.Name = "labFreeDateInfra"
        Me.labFreeDateInfra.Size = New System.Drawing.Size(69, 13)
        Me.labFreeDateInfra.TabIndex = 13
        Me.labFreeDateInfra.Text = "Infrastructure"
        '
        'labFreeDateSAP
        '
        Me.labFreeDateSAP.AutoSize = True
        Me.labFreeDateSAP.Location = New System.Drawing.Point(34, 97)
        Me.labFreeDateSAP.Name = "labFreeDateSAP"
        Me.labFreeDateSAP.Size = New System.Drawing.Size(28, 13)
        Me.labFreeDateSAP.TabIndex = 15
        Me.labFreeDateSAP.Text = "SAP"
        '
        'texFreeDateSAP
        '
        Me.texFreeDateSAP.Location = New System.Drawing.Point(138, 94)
        Me.texFreeDateSAP.Name = "texFreeDateSAP"
        Me.texFreeDateSAP.ReadOnly = True
        Me.texFreeDateSAP.Size = New System.Drawing.Size(154, 20)
        Me.texFreeDateSAP.TabIndex = 14
        '
        'labFreeDateHelpdesk
        '
        Me.labFreeDateHelpdesk.AutoSize = True
        Me.labFreeDateHelpdesk.Location = New System.Drawing.Point(34, 149)
        Me.labFreeDateHelpdesk.Name = "labFreeDateHelpdesk"
        Me.labFreeDateHelpdesk.Size = New System.Drawing.Size(52, 13)
        Me.labFreeDateHelpdesk.TabIndex = 17
        Me.labFreeDateHelpdesk.Text = "Helpdesk"
        '
        'texFreeDateHelpdesk
        '
        Me.texFreeDateHelpdesk.Location = New System.Drawing.Point(138, 146)
        Me.texFreeDateHelpdesk.Name = "texFreeDateHelpdesk"
        Me.texFreeDateHelpdesk.ReadOnly = True
        Me.texFreeDateHelpdesk.Size = New System.Drawing.Size(154, 20)
        Me.texFreeDateHelpdesk.TabIndex = 16
        '
        'labFreeDatePlaning
        '
        Me.labFreeDatePlaning.AutoSize = True
        Me.labFreeDatePlaning.Location = New System.Drawing.Point(34, 201)
        Me.labFreeDatePlaning.Name = "labFreeDatePlaning"
        Me.labFreeDatePlaning.Size = New System.Drawing.Size(64, 13)
        Me.labFreeDatePlaning.TabIndex = 19
        Me.labFreeDatePlaning.Text = "Planification"
        '
        'texFreeDatePlaning
        '
        Me.texFreeDatePlaning.Location = New System.Drawing.Point(138, 198)
        Me.texFreeDatePlaning.Name = "texFreeDatePlaning"
        Me.texFreeDatePlaning.ReadOnly = True
        Me.texFreeDatePlaning.Size = New System.Drawing.Size(154, 20)
        Me.texFreeDatePlaning.TabIndex = 20
        '
        'grpNextFreeDate
        '
        Me.grpNextFreeDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpNextFreeDate.Controls.Add(Me.texFreeDateSAP)
        Me.grpNextFreeDate.Controls.Add(Me.texFreeDatePlaning)
        Me.grpNextFreeDate.Controls.Add(Me.texFreeDateInfra)
        Me.grpNextFreeDate.Controls.Add(Me.labFreeDatePlaning)
        Me.grpNextFreeDate.Controls.Add(Me.labFreeDateInfra)
        Me.grpNextFreeDate.Controls.Add(Me.labFreeDateHelpdesk)
        Me.grpNextFreeDate.Controls.Add(Me.labFreeDateSAP)
        Me.grpNextFreeDate.Controls.Add(Me.texFreeDateHelpdesk)
        Me.grpNextFreeDate.Location = New System.Drawing.Point(682, 603)
        Me.grpNextFreeDate.Name = "grpNextFreeDate"
        Me.grpNextFreeDate.Size = New System.Drawing.Size(374, 266)
        Me.grpNextFreeDate.TabIndex = 21
        Me.grpNextFreeDate.TabStop = False
        Me.grpNextFreeDate.Text = "Prochaine date de libre"
        '
        'btcExportToExcel
        '
        Me.btcExportToExcel.Location = New System.Drawing.Point(138, 20)
        Me.btcExportToExcel.Name = "btcExportToExcel"
        Me.btcExportToExcel.Size = New System.Drawing.Size(104, 23)
        Me.btcExportToExcel.TabIndex = 23
        Me.btcExportToExcel.Text = "Export vers Excel"
        Me.btcExportToExcel.UseVisualStyleBackColor = True
        '
        'texTask8
        '
        Me.texTask8.Location = New System.Drawing.Point(1144, 23)
        Me.texTask8.Name = "texTask8"
        Me.texTask8.ReadOnly = True
        Me.texTask8.Size = New System.Drawing.Size(100, 20)
        Me.texTask8.TabIndex = 27
        Me.texTask8.Text = "Task8"
        Me.texTask8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask7
        '
        Me.texTask7.Location = New System.Drawing.Point(1038, 23)
        Me.texTask7.Name = "texTask7"
        Me.texTask7.ReadOnly = True
        Me.texTask7.Size = New System.Drawing.Size(100, 20)
        Me.texTask7.TabIndex = 26
        Me.texTask7.Text = "Task7"
        Me.texTask7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask6
        '
        Me.texTask6.Location = New System.Drawing.Point(932, 23)
        Me.texTask6.Name = "texTask6"
        Me.texTask6.ReadOnly = True
        Me.texTask6.Size = New System.Drawing.Size(100, 20)
        Me.texTask6.TabIndex = 25
        Me.texTask6.Text = "Task6"
        Me.texTask6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask5
        '
        Me.texTask5.Location = New System.Drawing.Point(826, 23)
        Me.texTask5.Name = "texTask5"
        Me.texTask5.ReadOnly = True
        Me.texTask5.Size = New System.Drawing.Size(100, 20)
        Me.texTask5.TabIndex = 24
        Me.texTask5.Text = "Task5"
        Me.texTask5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask10
        '
        Me.texTask10.Location = New System.Drawing.Point(1356, 23)
        Me.texTask10.Name = "texTask10"
        Me.texTask10.ReadOnly = True
        Me.texTask10.Size = New System.Drawing.Size(100, 20)
        Me.texTask10.TabIndex = 29
        Me.texTask10.Text = "Task10"
        Me.texTask10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texTask9
        '
        Me.texTask9.Location = New System.Drawing.Point(1250, 23)
        Me.texTask9.Name = "texTask9"
        Me.texTask9.ReadOnly = True
        Me.texTask9.Size = New System.Drawing.Size(100, 20)
        Me.texTask9.TabIndex = 28
        Me.texTask9.Text = "Task9"
        Me.texTask9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btcRefresh
        '
        Me.btcRefresh.Image = Global.ProjectPlan.My.Resources.Resources.refresh_23_23
        Me.btcRefresh.Location = New System.Drawing.Point(248, 21)
        Me.btcRefresh.Name = "btcRefresh"
        Me.btcRefresh.Size = New System.Drawing.Size(23, 23)
        Me.btcRefresh.TabIndex = 30
        Me.btcRefresh.UseVisualStyleBackColor = True
        '
        'btcChart
        '
        Me.btcChart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btcChart.Image = CType(resources.GetObject("btcChart.Image"), System.Drawing.Image)
        Me.btcChart.Location = New System.Drawing.Point(1204, 635)
        Me.btcChart.Name = "btcChart"
        Me.btcChart.Size = New System.Drawing.Size(134, 134)
        Me.btcChart.TabIndex = 22
        Me.btcChart.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvTabPage1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(557, 272)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvTabPage2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(557, 272)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvTabPage3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(557, 272)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(557, 272)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(557, 272)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(557, 272)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(557, 272)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(557, 272)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "TabPage8"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(557, 272)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "TabPage9"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TabPage10
        '
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(557, 272)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "TabPage10"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'dgvTabPage1
        '
        Me.dgvTabPage1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabPage1.Location = New System.Drawing.Point(3, 3)
        Me.dgvTabPage1.Name = "dgvTabPage1"
        Me.dgvTabPage1.Size = New System.Drawing.Size(551, 266)
        Me.dgvTabPage1.TabIndex = 0
        '
        'dgvTabPage2
        '
        Me.dgvTabPage2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabPage2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabPage2.Location = New System.Drawing.Point(3, 3)
        Me.dgvTabPage2.Name = "dgvTabPage2"
        Me.dgvTabPage2.Size = New System.Drawing.Size(551, 266)
        Me.dgvTabPage2.TabIndex = 0
        '
        'dgvTabPage3
        '
        Me.dgvTabPage3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTabPage3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabPage3.Location = New System.Drawing.Point(3, 3)
        Me.dgvTabPage3.Name = "dgvTabPage3"
        Me.dgvTabPage3.Size = New System.Drawing.Size(551, 266)
        Me.dgvTabPage3.TabIndex = 0
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1577, 896)
        Me.Controls.Add(Me.btcRefresh)
        Me.Controls.Add(Me.texTask10)
        Me.Controls.Add(Me.texTask9)
        Me.Controls.Add(Me.texTask8)
        Me.Controls.Add(Me.texTask7)
        Me.Controls.Add(Me.texTask6)
        Me.Controls.Add(Me.texTask5)
        Me.Controls.Add(Me.btcExportToExcel)
        Me.Controls.Add(Me.btcChart)
        Me.Controls.Add(Me.grpNextFreeDate)
        Me.Controls.Add(Me.tabTaskType)
        Me.Controls.Add(Me.btcFermer)
        Me.Controls.Add(Me.texTaskTotal)
        Me.Controls.Add(Me.texTask4)
        Me.Controls.Add(Me.texTask3)
        Me.Controls.Add(Me.texTask2)
        Me.Controls.Add(Me.texTask1)
        Me.Controls.Add(Me.dgvProjects)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTaskType.ResumeLayout(False)
        Me.grpNextFreeDate.ResumeLayout(False)
        Me.grpNextFreeDate.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvTabPage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTabPage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTabPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProjects As DataGridView
    Friend WithEvents texTask1 As TextBox
    Friend WithEvents texTask2 As TextBox
    Friend WithEvents texTask3 As TextBox
    Friend WithEvents texTask4 As TextBox
    Friend WithEvents texTaskTotal As TextBox
    Friend WithEvents btcFermer As Button
    Friend WithEvents tabTaskType As TabControl
    Friend WithEvents texFreeDateInfra As TextBox
    Friend WithEvents labFreeDateInfra As Label
    Friend WithEvents labFreeDateSAP As Label
    Friend WithEvents texFreeDateSAP As TextBox
    Friend WithEvents labFreeDateHelpdesk As Label
    Friend WithEvents texFreeDateHelpdesk As TextBox
    Friend WithEvents labFreeDatePlaning As Label
    Friend WithEvents texFreeDatePlaning As TextBox
    Friend WithEvents grpNextFreeDate As GroupBox
    Friend WithEvents btcChart As Button
    Friend WithEvents btcExportToExcel As Button
    Friend WithEvents texTask8 As TextBox
    Friend WithEvents texTask7 As TextBox
    Friend WithEvents texTask6 As TextBox
    Friend WithEvents texTask5 As TextBox
    Friend WithEvents texTask10 As TextBox
    Friend WithEvents texTask9 As TextBox
    Friend WithEvents btcRefresh As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvTabPage1 As DataGridView
    Friend WithEvents dgvTabPage2 As DataGridView
    Friend WithEvents dgvTabPage3 As DataGridView
End Class
