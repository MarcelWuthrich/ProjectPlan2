<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistiquesProjects
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatistiquesProjects))
        Me.btcClose = New System.Windows.Forms.Button()
        Me.labTotalExecutedResources = New System.Windows.Forms.Label()
        Me.labTotalPlanResources = New System.Windows.Forms.Label()
        Me.labExecutedResources = New System.Windows.Forms.Label()
        Me.labPlanResources = New System.Windows.Forms.Label()
        Me.labProjectNumber = New System.Windows.Forms.Label()
        Me.grpProjects = New System.Windows.Forms.GroupBox()
        Me.radProjectsAll = New System.Windows.Forms.RadioButton()
        Me.radProjectsInWork = New System.Windows.Forms.RadioButton()
        Me.dgvProjectsList = New System.Windows.Forms.DataGridView()
        Me.ID_Project = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusProjectInWorkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VprojectliststatistiquesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProjectListStatistques = New ProjectPlan.dsProjectListStatistques()
        Me.VprojectliststatistiquesTableAdapter = New ProjectPlan.dsProjectListStatistquesTableAdapters.vprojectliststatistiquesTableAdapter()
        Me.dgvPlanResources = New System.Windows.Forms.DataGridView()
        Me.dgvExecutedResources = New System.Windows.Forms.DataGridView()
        Me.DsProjectListStatisquesPlanResources = New ProjectPlan.dsProjectListStatisquesPlanResources()
        Me.VprojectliststatisquesplanresourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VprojectliststatisquesplanresourcesTableAdapter = New ProjectPlan.dsProjectListStatisquesPlanResourcesTableAdapters.vprojectliststatisquesplanresourcesTableAdapter()
        Me.IDResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCATHOURh00DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectMemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dsvprojectliststatistiquesexecutedresources = New ProjectPlan.dsvprojectliststatistiquesexecutedresources()
        Me.VprojectliststatistiquesexecutedresourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VprojectliststatistiquesexecutedresourcesTableAdapter = New ProjectPlan.dsvprojectliststatistiquesexecutedresourcesTableAdapters.vprojectliststatistiquesexecutedresourcesTableAdapter()
        Me.IDResourceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanDateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONCATHOURh00DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectMemberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.texEffectivePlusEstimatedResources = New System.Windows.Forms.TextBox()
        Me.labEffectivePlusEstimatedResources = New System.Windows.Forms.Label()
        Me.texProjectRate = New System.Windows.Forms.TextBox()
        Me.labProjectRate = New System.Windows.Forms.Label()
        Me.texProjectInitialPlaned = New System.Windows.Forms.TextBox()
        Me.labProjectInitialPlaned = New System.Windows.Forms.Label()
        Me.texProjectDeadline = New System.Windows.Forms.TextBox()
        Me.labProjectDeadline = New System.Windows.Forms.Label()
        Me.grpProjects.SuspendLayout()
        CType(Me.dgvProjectsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectliststatistiquesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjectListStatistques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPlanResources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExecutedResources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjectListStatisquesPlanResources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectliststatisquesplanresourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dsvprojectliststatistiquesexecutedresources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectliststatistiquesexecutedresourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcClose
        '
        Me.btcClose.Location = New System.Drawing.Point(599, 440)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(75, 23)
        Me.btcClose.TabIndex = 20
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'labTotalExecutedResources
        '
        Me.labTotalExecutedResources.AutoSize = True
        Me.labTotalExecutedResources.Location = New System.Drawing.Point(839, 410)
        Me.labTotalExecutedResources.Name = "labTotalExecutedResources"
        Me.labTotalExecutedResources.Size = New System.Drawing.Size(31, 13)
        Me.labTotalExecutedResources.TabIndex = 19
        Me.labTotalExecutedResources.Text = "Total"
        '
        'labTotalPlanResources
        '
        Me.labTotalPlanResources.AutoSize = True
        Me.labTotalPlanResources.Location = New System.Drawing.Point(483, 410)
        Me.labTotalPlanResources.Name = "labTotalPlanResources"
        Me.labTotalPlanResources.Size = New System.Drawing.Size(31, 13)
        Me.labTotalPlanResources.TabIndex = 18
        Me.labTotalPlanResources.Text = "Total"
        '
        'labExecutedResources
        '
        Me.labExecutedResources.AutoSize = True
        Me.labExecutedResources.Location = New System.Drawing.Point(839, 115)
        Me.labExecutedResources.Name = "labExecutedResources"
        Me.labExecutedResources.Size = New System.Drawing.Size(115, 13)
        Me.labExecutedResources.TabIndex = 17
        Me.labExecutedResources.Text = "Ressources exécutées"
        '
        'labPlanResources
        '
        Me.labPlanResources.AutoSize = True
        Me.labPlanResources.Location = New System.Drawing.Point(483, 115)
        Me.labPlanResources.Name = "labPlanResources"
        Me.labPlanResources.Size = New System.Drawing.Size(110, 13)
        Me.labPlanResources.TabIndex = 14
        Me.labPlanResources.Text = "Ressources planifiées"
        '
        'labProjectNumber
        '
        Me.labProjectNumber.AutoSize = True
        Me.labProjectNumber.Location = New System.Drawing.Point(37, 113)
        Me.labProjectNumber.Name = "labProjectNumber"
        Me.labProjectNumber.Size = New System.Drawing.Size(93, 13)
        Me.labProjectNumber.TabIndex = 13
        Me.labProjectNumber.Text = "Nombre de projets"
        '
        'grpProjects
        '
        Me.grpProjects.Controls.Add(Me.radProjectsAll)
        Me.grpProjects.Controls.Add(Me.radProjectsInWork)
        Me.grpProjects.Location = New System.Drawing.Point(37, 34)
        Me.grpProjects.Name = "grpProjects"
        Me.grpProjects.Size = New System.Drawing.Size(385, 72)
        Me.grpProjects.TabIndex = 11
        Me.grpProjects.TabStop = False
        Me.grpProjects.Text = "Projets"
        '
        'radProjectsAll
        '
        Me.radProjectsAll.AutoSize = True
        Me.radProjectsAll.Location = New System.Drawing.Point(6, 42)
        Me.radProjectsAll.Name = "radProjectsAll"
        Me.radProjectsAll.Size = New System.Drawing.Size(99, 17)
        Me.radProjectsAll.TabIndex = 1
        Me.radProjectsAll.Text = "Tous les projets"
        Me.radProjectsAll.UseVisualStyleBackColor = True
        '
        'radProjectsInWork
        '
        Me.radProjectsInWork.AutoSize = True
        Me.radProjectsInWork.Checked = True
        Me.radProjectsInWork.Location = New System.Drawing.Point(6, 19)
        Me.radProjectsInWork.Name = "radProjectsInWork"
        Me.radProjectsInWork.Size = New System.Drawing.Size(180, 17)
        Me.radProjectsInWork.TabIndex = 0
        Me.radProjectsInWork.TabStop = True
        Me.radProjectsInWork.Text = "Uniquement des projets en cours"
        Me.radProjectsInWork.UseVisualStyleBackColor = True
        '
        'dgvProjectsList
        '
        Me.dgvProjectsList.AllowUserToAddRows = False
        Me.dgvProjectsList.AllowUserToDeleteRows = False
        Me.dgvProjectsList.AutoGenerateColumns = False
        Me.dgvProjectsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectsList.ColumnHeadersVisible = False
        Me.dgvProjectsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Project, Me.TitleDataGridViewTextBoxColumn, Me.StatusProjectInWorkDataGridViewTextBoxColumn})
        Me.dgvProjectsList.DataSource = Me.VprojectliststatistiquesBindingSource
        Me.dgvProjectsList.Location = New System.Drawing.Point(37, 134)
        Me.dgvProjectsList.MultiSelect = False
        Me.dgvProjectsList.Name = "dgvProjectsList"
        Me.dgvProjectsList.ReadOnly = True
        Me.dgvProjectsList.RowHeadersVisible = False
        Me.dgvProjectsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectsList.Size = New System.Drawing.Size(385, 264)
        Me.dgvProjectsList.TabIndex = 21
        '
        'ID_Project
        '
        Me.ID_Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID_Project.DataPropertyName = "ID_Project"
        Me.ID_Project.HeaderText = "ID_Project"
        Me.ID_Project.Name = "ID_Project"
        Me.ID_Project.ReadOnly = True
        Me.ID_Project.Width = 5
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusProjectInWorkDataGridViewTextBoxColumn
        '
        Me.StatusProjectInWorkDataGridViewTextBoxColumn.DataPropertyName = "StatusProjectInWork"
        Me.StatusProjectInWorkDataGridViewTextBoxColumn.HeaderText = "StatusProjectInWork"
        Me.StatusProjectInWorkDataGridViewTextBoxColumn.Name = "StatusProjectInWorkDataGridViewTextBoxColumn"
        Me.StatusProjectInWorkDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusProjectInWorkDataGridViewTextBoxColumn.Visible = False
        '
        'VprojectliststatistiquesBindingSource
        '
        Me.VprojectliststatistiquesBindingSource.DataMember = "vprojectliststatistiques"
        Me.VprojectliststatistiquesBindingSource.DataSource = Me.DsProjectListStatistques
        Me.VprojectliststatistiquesBindingSource.Filter = ""
        '
        'DsProjectListStatistques
        '
        Me.DsProjectListStatistques.DataSetName = "dsProjectListStatistques"
        Me.DsProjectListStatistques.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectliststatistiquesTableAdapter
        '
        Me.VprojectliststatistiquesTableAdapter.ClearBeforeFill = True
        '
        'dgvPlanResources
        '
        Me.dgvPlanResources.AllowUserToAddRows = False
        Me.dgvPlanResources.AllowUserToDeleteRows = False
        Me.dgvPlanResources.AllowUserToResizeRows = False
        Me.dgvPlanResources.AutoGenerateColumns = False
        Me.dgvPlanResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlanResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanResources.ColumnHeadersVisible = False
        Me.dgvPlanResources.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDResourceDataGridViewTextBoxColumn, Me.PlanDateDataGridViewTextBoxColumn, Me.CONCATHOURh00DataGridViewTextBoxColumn, Me.CEIDProjectDataGridViewTextBoxColumn, Me.ProjectMemberDataGridViewTextBoxColumn})
        Me.dgvPlanResources.DataSource = Me.VprojectliststatisquesplanresourcesBindingSource
        Me.dgvPlanResources.Location = New System.Drawing.Point(486, 134)
        Me.dgvPlanResources.Name = "dgvPlanResources"
        Me.dgvPlanResources.ReadOnly = True
        Me.dgvPlanResources.RowHeadersVisible = False
        Me.dgvPlanResources.Size = New System.Drawing.Size(298, 264)
        Me.dgvPlanResources.TabIndex = 22
        '
        'dgvExecutedResources
        '
        Me.dgvExecutedResources.AllowUserToAddRows = False
        Me.dgvExecutedResources.AllowUserToDeleteRows = False
        Me.dgvExecutedResources.AllowUserToResizeRows = False
        Me.dgvExecutedResources.AutoGenerateColumns = False
        Me.dgvExecutedResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExecutedResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExecutedResources.ColumnHeadersVisible = False
        Me.dgvExecutedResources.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDResourceDataGridViewTextBoxColumn1, Me.PlanDateDataGridViewTextBoxColumn1, Me.CONCATHOURh00DataGridViewTextBoxColumn1, Me.CEIDProjectDataGridViewTextBoxColumn1, Me.ProjectMemberDataGridViewTextBoxColumn1})
        Me.dgvExecutedResources.DataSource = Me.VprojectliststatistiquesexecutedresourcesBindingSource
        Me.dgvExecutedResources.Location = New System.Drawing.Point(842, 134)
        Me.dgvExecutedResources.Name = "dgvExecutedResources"
        Me.dgvExecutedResources.ReadOnly = True
        Me.dgvExecutedResources.RowHeadersVisible = False
        Me.dgvExecutedResources.Size = New System.Drawing.Size(334, 264)
        Me.dgvExecutedResources.TabIndex = 23
        '
        'DsProjectListStatisquesPlanResources
        '
        Me.DsProjectListStatisquesPlanResources.DataSetName = "dsProjectListStatisquesPlanResources"
        Me.DsProjectListStatisquesPlanResources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectliststatisquesplanresourcesBindingSource
        '
        Me.VprojectliststatisquesplanresourcesBindingSource.DataMember = "vprojectliststatisquesplanresources"
        Me.VprojectliststatisquesplanresourcesBindingSource.DataSource = Me.DsProjectListStatisquesPlanResources
        '
        'VprojectliststatisquesplanresourcesTableAdapter
        '
        Me.VprojectliststatisquesplanresourcesTableAdapter.ClearBeforeFill = True
        '
        'IDResourceDataGridViewTextBoxColumn
        '
        Me.IDResourceDataGridViewTextBoxColumn.DataPropertyName = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn.HeaderText = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn.Name = "IDResourceDataGridViewTextBoxColumn"
        Me.IDResourceDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDResourceDataGridViewTextBoxColumn.Visible = False
        '
        'PlanDateDataGridViewTextBoxColumn
        '
        Me.PlanDateDataGridViewTextBoxColumn.DataPropertyName = "PlanDate"
        Me.PlanDateDataGridViewTextBoxColumn.HeaderText = "PlanDate"
        Me.PlanDateDataGridViewTextBoxColumn.Name = "PlanDateDataGridViewTextBoxColumn"
        Me.PlanDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONCATHOURh00DataGridViewTextBoxColumn
        '
        Me.CONCATHOURh00DataGridViewTextBoxColumn.DataPropertyName = "CONCAT(HOUR, 'h00')"
        Me.CONCATHOURh00DataGridViewTextBoxColumn.HeaderText = "CONCAT(HOUR, 'h00')"
        Me.CONCATHOURh00DataGridViewTextBoxColumn.Name = "CONCATHOURh00DataGridViewTextBoxColumn"
        Me.CONCATHOURh00DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEIDProjectDataGridViewTextBoxColumn
        '
        Me.CEIDProjectDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn.HeaderText = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn.Name = "CEIDProjectDataGridViewTextBoxColumn"
        Me.CEIDProjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDProjectDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectMemberDataGridViewTextBoxColumn
        '
        Me.ProjectMemberDataGridViewTextBoxColumn.DataPropertyName = "ProjectMember"
        Me.ProjectMemberDataGridViewTextBoxColumn.HeaderText = "ProjectMember"
        Me.ProjectMemberDataGridViewTextBoxColumn.Name = "ProjectMemberDataGridViewTextBoxColumn"
        Me.ProjectMemberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Dsvprojectliststatistiquesexecutedresources
        '
        Me.Dsvprojectliststatistiquesexecutedresources.DataSetName = "dsvprojectliststatistiquesexecutedresources"
        Me.Dsvprojectliststatistiquesexecutedresources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectliststatistiquesexecutedresourcesBindingSource
        '
        Me.VprojectliststatistiquesexecutedresourcesBindingSource.DataMember = "vprojectliststatistiquesexecutedresources"
        Me.VprojectliststatistiquesexecutedresourcesBindingSource.DataSource = Me.Dsvprojectliststatistiquesexecutedresources
        '
        'VprojectliststatistiquesexecutedresourcesTableAdapter
        '
        Me.VprojectliststatistiquesexecutedresourcesTableAdapter.ClearBeforeFill = True
        '
        'IDResourceDataGridViewTextBoxColumn1
        '
        Me.IDResourceDataGridViewTextBoxColumn1.DataPropertyName = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn1.HeaderText = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn1.Name = "IDResourceDataGridViewTextBoxColumn1"
        Me.IDResourceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDResourceDataGridViewTextBoxColumn1.Visible = False
        '
        'PlanDateDataGridViewTextBoxColumn1
        '
        Me.PlanDateDataGridViewTextBoxColumn1.DataPropertyName = "PlanDate"
        Me.PlanDateDataGridViewTextBoxColumn1.HeaderText = "PlanDate"
        Me.PlanDateDataGridViewTextBoxColumn1.Name = "PlanDateDataGridViewTextBoxColumn1"
        Me.PlanDateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CONCATHOURh00DataGridViewTextBoxColumn1
        '
        Me.CONCATHOURh00DataGridViewTextBoxColumn1.DataPropertyName = "CONCAT(HOUR, 'h00')"
        Me.CONCATHOURh00DataGridViewTextBoxColumn1.HeaderText = "CONCAT(HOUR, 'h00')"
        Me.CONCATHOURh00DataGridViewTextBoxColumn1.Name = "CONCATHOURh00DataGridViewTextBoxColumn1"
        Me.CONCATHOURh00DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CEIDProjectDataGridViewTextBoxColumn1
        '
        Me.CEIDProjectDataGridViewTextBoxColumn1.DataPropertyName = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn1.HeaderText = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn1.Name = "CEIDProjectDataGridViewTextBoxColumn1"
        Me.CEIDProjectDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CEIDProjectDataGridViewTextBoxColumn1.Visible = False
        '
        'ProjectMemberDataGridViewTextBoxColumn1
        '
        Me.ProjectMemberDataGridViewTextBoxColumn1.DataPropertyName = "ProjectMember"
        Me.ProjectMemberDataGridViewTextBoxColumn1.HeaderText = "ProjectMember"
        Me.ProjectMemberDataGridViewTextBoxColumn1.Name = "ProjectMemberDataGridViewTextBoxColumn1"
        Me.ProjectMemberDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'texEffectivePlusEstimatedResources
        '
        Me.texEffectivePlusEstimatedResources.Location = New System.Drawing.Point(1061, 78)
        Me.texEffectivePlusEstimatedResources.Name = "texEffectivePlusEstimatedResources"
        Me.texEffectivePlusEstimatedResources.ReadOnly = True
        Me.texEffectivePlusEstimatedResources.Size = New System.Drawing.Size(115, 20)
        Me.texEffectivePlusEstimatedResources.TabIndex = 36
        '
        'labEffectivePlusEstimatedResources
        '
        Me.labEffectivePlusEstimatedResources.AutoSize = True
        Me.labEffectivePlusEstimatedResources.Location = New System.Drawing.Point(839, 78)
        Me.labEffectivePlusEstimatedResources.Name = "labEffectivePlusEstimatedResources"
        Me.labEffectivePlusEstimatedResources.Size = New System.Drawing.Size(150, 13)
        Me.labEffectivePlusEstimatedResources.TabIndex = 35
        Me.labEffectivePlusEstimatedResources.Text = "Heures planifiées et travaillées"
        '
        'texProjectRate
        '
        Me.texProjectRate.Location = New System.Drawing.Point(669, 78)
        Me.texProjectRate.Name = "texProjectRate"
        Me.texProjectRate.ReadOnly = True
        Me.texProjectRate.Size = New System.Drawing.Size(115, 20)
        Me.texProjectRate.TabIndex = 29
        '
        'labProjectRate
        '
        Me.labProjectRate.AutoSize = True
        Me.labProjectRate.Location = New System.Drawing.Point(483, 81)
        Me.labProjectRate.Name = "labProjectRate"
        Me.labProjectRate.Size = New System.Drawing.Size(178, 13)
        Me.labProjectRate.TabIndex = 28
        Me.labProjectRate.Text = "Taux réalisation ( planifié / exécuté )"
        '
        'texProjectInitialPlaned
        '
        Me.texProjectInitialPlaned.Location = New System.Drawing.Point(1061, 52)
        Me.texProjectInitialPlaned.Name = "texProjectInitialPlaned"
        Me.texProjectInitialPlaned.ReadOnly = True
        Me.texProjectInitialPlaned.Size = New System.Drawing.Size(115, 20)
        Me.texProjectInitialPlaned.TabIndex = 27
        '
        'labProjectInitialPlaned
        '
        Me.labProjectInitialPlaned.AutoSize = True
        Me.labProjectInitialPlaned.Location = New System.Drawing.Point(839, 55)
        Me.labProjectInitialPlaned.Name = "labProjectInitialPlaned"
        Me.labProjectInitialPlaned.Size = New System.Drawing.Size(137, 13)
        Me.labProjectInitialPlaned.TabIndex = 26
        Me.labProjectInitialPlaned.Text = "Heures initialement prévues"
        '
        'texProjectDeadline
        '
        Me.texProjectDeadline.Location = New System.Drawing.Point(669, 52)
        Me.texProjectDeadline.Name = "texProjectDeadline"
        Me.texProjectDeadline.ReadOnly = True
        Me.texProjectDeadline.Size = New System.Drawing.Size(115, 20)
        Me.texProjectDeadline.TabIndex = 25
        '
        'labProjectDeadline
        '
        Me.labProjectDeadline.AutoSize = True
        Me.labProjectDeadline.Location = New System.Drawing.Point(483, 55)
        Me.labProjectDeadline.Name = "labProjectDeadline"
        Me.labProjectDeadline.Size = New System.Drawing.Size(49, 13)
        Me.labProjectDeadline.TabIndex = 24
        Me.labProjectDeadline.Text = "Deadline"
        '
        'frmStatistiquesProjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 497)
        Me.Controls.Add(Me.texEffectivePlusEstimatedResources)
        Me.Controls.Add(Me.labEffectivePlusEstimatedResources)
        Me.Controls.Add(Me.texProjectRate)
        Me.Controls.Add(Me.labProjectRate)
        Me.Controls.Add(Me.texProjectInitialPlaned)
        Me.Controls.Add(Me.labProjectInitialPlaned)
        Me.Controls.Add(Me.texProjectDeadline)
        Me.Controls.Add(Me.labProjectDeadline)
        Me.Controls.Add(Me.dgvExecutedResources)
        Me.Controls.Add(Me.dgvProjectsList)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.labTotalExecutedResources)
        Me.Controls.Add(Me.labTotalPlanResources)
        Me.Controls.Add(Me.labExecutedResources)
        Me.Controls.Add(Me.labPlanResources)
        Me.Controls.Add(Me.labProjectNumber)
        Me.Controls.Add(Me.grpProjects)
        Me.Controls.Add(Me.dgvPlanResources)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStatistiquesProjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistiques des projets"
        Me.grpProjects.ResumeLayout(False)
        Me.grpProjects.PerformLayout()
        CType(Me.dgvProjectsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectliststatistiquesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjectListStatistques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPlanResources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExecutedResources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjectListStatisquesPlanResources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectliststatisquesplanresourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dsvprojectliststatistiquesexecutedresources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectliststatistiquesexecutedresourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btcClose As Button
    Friend WithEvents labTotalExecutedResources As Label
    Friend WithEvents labTotalPlanResources As Label
    Friend WithEvents labExecutedResources As Label
    Friend WithEvents labPlanResources As Label
    Friend WithEvents labProjectNumber As Label
    Friend WithEvents grpProjects As GroupBox
    Friend WithEvents radProjectsAll As RadioButton
    Friend WithEvents radProjectsInWork As RadioButton
    Friend WithEvents dgvProjectsList As DataGridView
    Friend WithEvents DsProjectListStatistques As dsProjectListStatistques
    Friend WithEvents VprojectliststatistiquesBindingSource As BindingSource
    Friend WithEvents VprojectliststatistiquesTableAdapter As dsProjectListStatistquesTableAdapters.vprojectliststatistiquesTableAdapter
    Friend WithEvents ID_Project As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusProjectInWorkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvPlanResources As DataGridView
    Friend WithEvents dgvExecutedResources As DataGridView
    Friend WithEvents DsProjectListStatisquesPlanResources As dsProjectListStatisquesPlanResources
    Friend WithEvents VprojectliststatisquesplanresourcesBindingSource As BindingSource
    Friend WithEvents VprojectliststatisquesplanresourcesTableAdapter As dsProjectListStatisquesPlanResourcesTableAdapters.vprojectliststatisquesplanresourcesTableAdapter
    Friend WithEvents IDResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlanDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONCATHOURh00DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProjectMemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Dsvprojectliststatistiquesexecutedresources As dsvprojectliststatistiquesexecutedresources
    Friend WithEvents VprojectliststatistiquesexecutedresourcesBindingSource As BindingSource
    Friend WithEvents VprojectliststatistiquesexecutedresourcesTableAdapter As dsvprojectliststatistiquesexecutedresourcesTableAdapters.vprojectliststatistiquesexecutedresourcesTableAdapter
    Friend WithEvents IDResourceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PlanDateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CONCATHOURh00DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProjectMemberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents texEffectivePlusEstimatedResources As TextBox
    Friend WithEvents labEffectivePlusEstimatedResources As Label
    Friend WithEvents texProjectRate As TextBox
    Friend WithEvents labProjectRate As Label
    Friend WithEvents texProjectInitialPlaned As TextBox
    Friend WithEvents labProjectInitialPlaned As Label
    Friend WithEvents texProjectDeadline As TextBox
    Friend WithEvents labProjectDeadline As Label
End Class
