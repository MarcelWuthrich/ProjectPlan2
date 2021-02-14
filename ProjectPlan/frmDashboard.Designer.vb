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
        Me.btcChart = New System.Windows.Forms.Button()
        Me.btcExportToExcel = New System.Windows.Forms.Button()
        Me.texTask8 = New System.Windows.Forms.TextBox()
        Me.texTask7 = New System.Windows.Forms.TextBox()
        Me.texTask6 = New System.Windows.Forms.TextBox()
        Me.texTask5 = New System.Windows.Forms.TextBox()
        Me.texTask10 = New System.Windows.Forms.TextBox()
        Me.texTask9 = New System.Windows.Forms.TextBox()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNextFreeDate.SuspendLayout()
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
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1577, 896)
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
        Me.grpNextFreeDate.ResumeLayout(False)
        Me.grpNextFreeDate.PerformLayout()
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
End Class
