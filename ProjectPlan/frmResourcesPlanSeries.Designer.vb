<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourcesPlanSeries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResourcesPlanSeries))
        Me.btcPlanFree = New System.Windows.Forms.Button()
        Me.btcPlan = New System.Windows.Forms.Button()
        Me.btcFermer = New System.Windows.Forms.Button()
        Me.VprojectmembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsProjectPlan = New ProjectPlan.projectplanDataSet()
        Me.VprojectmembersTableAdapter = New ProjectPlan.projectplanDataSetTableAdapters.vprojectmembersTableAdapter()
        Me.dgvResourcesAdmin = New System.Windows.Forms.DataGridView()
        Me.IDAdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymbolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VresourcesadminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsResoucesAdmin = New ProjectPlan.dsResoucesAdmin()
        Me.VresourcesadminTableAdapter = New ProjectPlan.dsResoucesAdminTableAdapters.vresourcesadminTableAdapter()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.IDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeadlineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDUrgencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeginDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImplementationRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectiveResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProjects = New ProjectPlan.dsProjects()
        Me.ProjectsTableAdapter = New ProjectPlan.dsProjectsTableAdapters.projectsTableAdapter()
        Me.tabResources = New System.Windows.Forms.TabControl()
        Me.tabPageAdmin = New System.Windows.Forms.TabPage()
        Me.tabPageProjects = New System.Windows.Forms.TabPage()
        Me.texMessage = New System.Windows.Forms.TextBox()
        Me.dgvProjectMembers = New System.Windows.Forms.DataGridView()
        Me.IDProjectMemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDTaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpSchedule = New System.Windows.Forms.GroupBox()
        Me.radWeekly = New System.Windows.Forms.RadioButton()
        Me.radDaily = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.grpDaily = New System.Windows.Forms.GroupBox()
        Me.labDayTo = New System.Windows.Forms.Label()
        Me.labDayFrom = New System.Windows.Forms.Label()
        Me.texDayTo = New System.Windows.Forms.TextBox()
        Me.texDayFrom = New System.Windows.Forms.TextBox()
        Me.radDays = New System.Windows.Forms.RadioButton()
        Me.radWeekDays = New System.Windows.Forms.RadioButton()
        Me.texNumberOfDays = New System.Windows.Forms.TextBox()
        Me.labNumberOfDays = New System.Windows.Forms.Label()
        Me.grpWeekly = New System.Windows.Forms.GroupBox()
        Me.chkMonday = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.texWeekTo = New System.Windows.Forms.TextBox()
        Me.texWeekFrom = New System.Windows.Forms.TextBox()
        Me.texNumberOfWeeks = New System.Windows.Forms.TextBox()
        Me.labNumberOfWeeks = New System.Windows.Forms.Label()
        Me.chkTuesday = New System.Windows.Forms.CheckBox()
        Me.chkWednesday = New System.Windows.Forms.CheckBox()
        Me.chkSunday = New System.Windows.Forms.CheckBox()
        Me.chkThursday = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkFriday = New System.Windows.Forms.CheckBox()
        Me.labProjectMember = New System.Windows.Forms.Label()
        CType(Me.VprojectmembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProjectPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResourcesAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VresourcesadminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsResoucesAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResources.SuspendLayout()
        Me.tabPageAdmin.SuspendLayout()
        Me.tabPageProjects.SuspendLayout()
        CType(Me.dgvProjectMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSchedule.SuspendLayout()
        Me.grpDaily.SuspendLayout()
        Me.grpWeekly.SuspendLayout()
        Me.SuspendLayout()
        '
        'btcPlanFree
        '
        Me.btcPlanFree.Location = New System.Drawing.Point(868, 464)
        Me.btcPlanFree.Name = "btcPlanFree"
        Me.btcPlanFree.Size = New System.Drawing.Size(75, 23)
        Me.btcPlanFree.TabIndex = 33
        Me.btcPlanFree.Text = "Jours libres"
        Me.btcPlanFree.UseVisualStyleBackColor = True
        '
        'btcPlan
        '
        Me.btcPlan.Location = New System.Drawing.Point(763, 464)
        Me.btcPlan.Name = "btcPlan"
        Me.btcPlan.Size = New System.Drawing.Size(75, 23)
        Me.btcPlan.TabIndex = 28
        Me.btcPlan.Text = "Planifie"
        Me.btcPlan.UseVisualStyleBackColor = True
        '
        'btcFermer
        '
        Me.btcFermer.Location = New System.Drawing.Point(656, 464)
        Me.btcFermer.Name = "btcFermer"
        Me.btcFermer.Size = New System.Drawing.Size(75, 23)
        Me.btcFermer.TabIndex = 26
        Me.btcFermer.Text = "&Fermer"
        Me.btcFermer.UseVisualStyleBackColor = True
        '
        'VprojectmembersBindingSource
        '
        Me.VprojectmembersBindingSource.DataMember = "vprojectmembers"
        Me.VprojectmembersBindingSource.DataSource = Me.dsProjectPlan
        '
        'dsProjectPlan
        '
        Me.dsProjectPlan.DataSetName = "dsProjectPlan"
        Me.dsProjectPlan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectmembersTableAdapter
        '
        Me.VprojectmembersTableAdapter.ClearBeforeFill = True
        '
        'dgvResourcesAdmin
        '
        Me.dgvResourcesAdmin.AllowUserToAddRows = False
        Me.dgvResourcesAdmin.AllowUserToDeleteRows = False
        Me.dgvResourcesAdmin.AllowUserToResizeRows = False
        Me.dgvResourcesAdmin.AutoGenerateColumns = False
        Me.dgvResourcesAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResourcesAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResourcesAdmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAdminResourceDataGridViewTextBoxColumn, Me.AdminResourceDataGridViewTextBoxColumn, Me.SymbolDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn1, Me.DisplayOrderDataGridViewTextBoxColumn})
        Me.dgvResourcesAdmin.DataSource = Me.VresourcesadminBindingSource
        Me.dgvResourcesAdmin.Location = New System.Drawing.Point(10, 10)
        Me.dgvResourcesAdmin.Name = "dgvResourcesAdmin"
        Me.dgvResourcesAdmin.ReadOnly = True
        Me.dgvResourcesAdmin.RowHeadersVisible = False
        Me.dgvResourcesAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResourcesAdmin.Size = New System.Drawing.Size(500, 200)
        Me.dgvResourcesAdmin.TabIndex = 35
        '
        'IDAdminResourceDataGridViewTextBoxColumn
        '
        Me.IDAdminResourceDataGridViewTextBoxColumn.DataPropertyName = "ID_AdminResource"
        Me.IDAdminResourceDataGridViewTextBoxColumn.HeaderText = "ID_AdminResource"
        Me.IDAdminResourceDataGridViewTextBoxColumn.Name = "IDAdminResourceDataGridViewTextBoxColumn"
        Me.IDAdminResourceDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDAdminResourceDataGridViewTextBoxColumn.Visible = False
        '
        'AdminResourceDataGridViewTextBoxColumn
        '
        Me.AdminResourceDataGridViewTextBoxColumn.DataPropertyName = "AdminResource"
        Me.AdminResourceDataGridViewTextBoxColumn.HeaderText = "Ressource"
        Me.AdminResourceDataGridViewTextBoxColumn.Name = "AdminResourceDataGridViewTextBoxColumn"
        Me.AdminResourceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SymbolDataGridViewTextBoxColumn
        '
        Me.SymbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol"
        Me.SymbolDataGridViewTextBoxColumn.HeaderText = "Symbol"
        Me.SymbolDataGridViewTextBoxColumn.Name = "SymbolDataGridViewTextBoxColumn"
        Me.SymbolDataGridViewTextBoxColumn.ReadOnly = True
        Me.SymbolDataGridViewTextBoxColumn.Visible = False
        '
        'EnableDataGridViewTextBoxColumn1
        '
        Me.EnableDataGridViewTextBoxColumn1.DataPropertyName = "Enable"
        Me.EnableDataGridViewTextBoxColumn1.HeaderText = "Enable"
        Me.EnableDataGridViewTextBoxColumn1.Name = "EnableDataGridViewTextBoxColumn1"
        Me.EnableDataGridViewTextBoxColumn1.ReadOnly = True
        Me.EnableDataGridViewTextBoxColumn1.Visible = False
        '
        'DisplayOrderDataGridViewTextBoxColumn
        '
        Me.DisplayOrderDataGridViewTextBoxColumn.DataPropertyName = "DisplayOrder"
        Me.DisplayOrderDataGridViewTextBoxColumn.HeaderText = "DisplayOrder"
        Me.DisplayOrderDataGridViewTextBoxColumn.Name = "DisplayOrderDataGridViewTextBoxColumn"
        Me.DisplayOrderDataGridViewTextBoxColumn.ReadOnly = True
        Me.DisplayOrderDataGridViewTextBoxColumn.Visible = False
        '
        'VresourcesadminBindingSource
        '
        Me.VresourcesadminBindingSource.DataMember = "vresourcesadmin"
        Me.VresourcesadminBindingSource.DataSource = Me.DsResoucesAdmin
        '
        'DsResoucesAdmin
        '
        Me.DsResoucesAdmin.DataSetName = "dsResoucesAdmin"
        Me.DsResoucesAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VresourcesadminTableAdapter
        '
        Me.VresourcesadminTableAdapter.ClearBeforeFill = True
        '
        'dgvProjects
        '
        Me.dgvProjects.AutoGenerateColumns = False
        Me.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectDataGridViewTextBoxColumn, Me.DeadlineDataGridViewTextBoxColumn, Me.CEIDStatusDataGridViewTextBoxColumn, Me.CEIDProjectManagerDataGridViewTextBoxColumn, Me.CEIDPriorityDataGridViewTextBoxColumn, Me.CEIDCategoryDataGridViewTextBoxColumn, Me.CEIDCustomerDataGridViewTextBoxColumn, Me.CEIDUrgencyDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.BeginDateDataGridViewTextBoxColumn, Me.EstimatedResourcesDataGridViewTextBoxColumn, Me.ImplementationRateDataGridViewTextBoxColumn, Me.EffectiveResourcesDataGridViewTextBoxColumn})
        Me.dgvProjects.DataSource = Me.ProjectsBindingSource
        Me.dgvProjects.Location = New System.Drawing.Point(10, 10)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.ReadOnly = True
        Me.dgvProjects.RowHeadersVisible = False
        Me.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjects.Size = New System.Drawing.Size(500, 200)
        Me.dgvProjects.TabIndex = 36
        '
        'IDProjectDataGridViewTextBoxColumn
        '
        Me.IDProjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IDProjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.HeaderText = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.Name = "IDProjectDataGridViewTextBoxColumn"
        Me.IDProjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDProjectDataGridViewTextBoxColumn.Width = 82
        '
        'DeadlineDataGridViewTextBoxColumn
        '
        Me.DeadlineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DeadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.HeaderText = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.Name = "DeadlineDataGridViewTextBoxColumn"
        Me.DeadlineDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeadlineDataGridViewTextBoxColumn.Width = 74
        '
        'CEIDStatusDataGridViewTextBoxColumn
        '
        Me.CEIDStatusDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Status"
        Me.CEIDStatusDataGridViewTextBoxColumn.HeaderText = "CE_ID_Status"
        Me.CEIDStatusDataGridViewTextBoxColumn.Name = "CEIDStatusDataGridViewTextBoxColumn"
        Me.CEIDStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDStatusDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDProjectManagerDataGridViewTextBoxColumn
        '
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_ProjectManager"
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.HeaderText = "CE_ID_ProjectManager"
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.Name = "CEIDProjectManagerDataGridViewTextBoxColumn"
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDPriorityDataGridViewTextBoxColumn
        '
        Me.CEIDPriorityDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Priority"
        Me.CEIDPriorityDataGridViewTextBoxColumn.HeaderText = "CE_ID_Priority"
        Me.CEIDPriorityDataGridViewTextBoxColumn.Name = "CEIDPriorityDataGridViewTextBoxColumn"
        Me.CEIDPriorityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDPriorityDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDCategoryDataGridViewTextBoxColumn
        '
        Me.CEIDCategoryDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Category"
        Me.CEIDCategoryDataGridViewTextBoxColumn.HeaderText = "CE_ID_Category"
        Me.CEIDCategoryDataGridViewTextBoxColumn.Name = "CEIDCategoryDataGridViewTextBoxColumn"
        Me.CEIDCategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDCategoryDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDCustomerDataGridViewTextBoxColumn
        '
        Me.CEIDCustomerDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Customer"
        Me.CEIDCustomerDataGridViewTextBoxColumn.HeaderText = "CE_ID_Customer"
        Me.CEIDCustomerDataGridViewTextBoxColumn.Name = "CEIDCustomerDataGridViewTextBoxColumn"
        Me.CEIDCustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDCustomerDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDUrgencyDataGridViewTextBoxColumn
        '
        Me.CEIDUrgencyDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Urgency"
        Me.CEIDUrgencyDataGridViewTextBoxColumn.HeaderText = "CE_ID_Urgency"
        Me.CEIDUrgencyDataGridViewTextBoxColumn.Name = "CEIDUrgencyDataGridViewTextBoxColumn"
        Me.CEIDUrgencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDUrgencyDataGridViewTextBoxColumn.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'BeginDateDataGridViewTextBoxColumn
        '
        Me.BeginDateDataGridViewTextBoxColumn.DataPropertyName = "BeginDate"
        Me.BeginDateDataGridViewTextBoxColumn.HeaderText = "BeginDate"
        Me.BeginDateDataGridViewTextBoxColumn.Name = "BeginDateDataGridViewTextBoxColumn"
        Me.BeginDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.BeginDateDataGridViewTextBoxColumn.Visible = False
        '
        'EstimatedResourcesDataGridViewTextBoxColumn
        '
        Me.EstimatedResourcesDataGridViewTextBoxColumn.DataPropertyName = "EstimatedResources"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.HeaderText = "EstimatedResources"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.Name = "EstimatedResourcesDataGridViewTextBoxColumn"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstimatedResourcesDataGridViewTextBoxColumn.Visible = False
        '
        'ImplementationRateDataGridViewTextBoxColumn
        '
        Me.ImplementationRateDataGridViewTextBoxColumn.DataPropertyName = "ImplementationRate"
        Me.ImplementationRateDataGridViewTextBoxColumn.HeaderText = "ImplementationRate"
        Me.ImplementationRateDataGridViewTextBoxColumn.Name = "ImplementationRateDataGridViewTextBoxColumn"
        Me.ImplementationRateDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImplementationRateDataGridViewTextBoxColumn.Visible = False
        '
        'EffectiveResourcesDataGridViewTextBoxColumn
        '
        Me.EffectiveResourcesDataGridViewTextBoxColumn.DataPropertyName = "EffectiveResources"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.HeaderText = "EffectiveResources"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.Name = "EffectiveResourcesDataGridViewTextBoxColumn"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.ReadOnly = True
        Me.EffectiveResourcesDataGridViewTextBoxColumn.Visible = False
        '
        'ProjectsBindingSource
        '
        Me.ProjectsBindingSource.DataMember = "projects"
        Me.ProjectsBindingSource.DataSource = Me.DsProjects
        '
        'DsProjects
        '
        Me.DsProjects.DataSetName = "dsProjects"
        Me.DsProjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjectsTableAdapter
        '
        Me.ProjectsTableAdapter.ClearBeforeFill = True
        '
        'tabResources
        '
        Me.tabResources.Controls.Add(Me.tabPageAdmin)
        Me.tabResources.Controls.Add(Me.tabPageProjects)
        Me.tabResources.Location = New System.Drawing.Point(26, 30)
        Me.tabResources.Name = "tabResources"
        Me.tabResources.SelectedIndex = 0
        Me.tabResources.Size = New System.Drawing.Size(526, 250)
        Me.tabResources.TabIndex = 38
        '
        'tabPageAdmin
        '
        Me.tabPageAdmin.Controls.Add(Me.dgvResourcesAdmin)
        Me.tabPageAdmin.Location = New System.Drawing.Point(4, 22)
        Me.tabPageAdmin.Name = "tabPageAdmin"
        Me.tabPageAdmin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageAdmin.Size = New System.Drawing.Size(518, 224)
        Me.tabPageAdmin.TabIndex = 0
        Me.tabPageAdmin.Text = "Administratif"
        Me.tabPageAdmin.UseVisualStyleBackColor = True
        '
        'tabPageProjects
        '
        Me.tabPageProjects.Controls.Add(Me.dgvProjects)
        Me.tabPageProjects.Location = New System.Drawing.Point(4, 22)
        Me.tabPageProjects.Name = "tabPageProjects"
        Me.tabPageProjects.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageProjects.Size = New System.Drawing.Size(518, 224)
        Me.tabPageProjects.TabIndex = 1
        Me.tabPageProjects.Text = "Projets"
        Me.tabPageProjects.UseVisualStyleBackColor = True
        '
        'texMessage
        '
        Me.texMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.texMessage.Location = New System.Drawing.Point(603, 302)
        Me.texMessage.Multiline = True
        Me.texMessage.Name = "texMessage"
        Me.texMessage.ReadOnly = True
        Me.texMessage.Size = New System.Drawing.Size(374, 74)
        Me.texMessage.TabIndex = 39
        Me.texMessage.TabStop = False
        Me.texMessage.Text = "Message days"
        Me.texMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvProjectMembers
        '
        Me.dgvProjectMembers.AllowUserToAddRows = False
        Me.dgvProjectMembers.AllowUserToDeleteRows = False
        Me.dgvProjectMembers.AllowUserToResizeRows = False
        Me.dgvProjectMembers.AutoGenerateColumns = False
        Me.dgvProjectMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectMemberDataGridViewTextBoxColumn, Me.CEIDTaskDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.TaskDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn})
        Me.dgvProjectMembers.DataSource = Me.VprojectmembersBindingSource
        Me.dgvProjectMembers.Location = New System.Drawing.Point(30, 318)
        Me.dgvProjectMembers.Name = "dgvProjectMembers"
        Me.dgvProjectMembers.ReadOnly = True
        Me.dgvProjectMembers.RowHeadersVisible = False
        Me.dgvProjectMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectMembers.Size = New System.Drawing.Size(510, 215)
        Me.dgvProjectMembers.TabIndex = 42
        '
        'IDProjectMemberDataGridViewTextBoxColumn
        '
        Me.IDProjectMemberDataGridViewTextBoxColumn.DataPropertyName = "ID_ProjectMember"
        Me.IDProjectMemberDataGridViewTextBoxColumn.HeaderText = "ID_ProjectMember"
        Me.IDProjectMemberDataGridViewTextBoxColumn.Name = "IDProjectMemberDataGridViewTextBoxColumn"
        Me.IDProjectMemberDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDProjectMemberDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDTaskDataGridViewTextBoxColumn
        '
        Me.CEIDTaskDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Task"
        Me.CEIDTaskDataGridViewTextBoxColumn.HeaderText = "CE_ID_Task"
        Me.CEIDTaskDataGridViewTextBoxColumn.Name = "CEIDTaskDataGridViewTextBoxColumn"
        Me.CEIDTaskDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDTaskDataGridViewTextBoxColumn.Visible = False
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TaskDataGridViewTextBoxColumn
        '
        Me.TaskDataGridViewTextBoxColumn.DataPropertyName = "Task"
        Me.TaskDataGridViewTextBoxColumn.HeaderText = "Activité"
        Me.TaskDataGridViewTextBoxColumn.Name = "TaskDataGridViewTextBoxColumn"
        Me.TaskDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EnableDataGridViewTextBoxColumn
        '
        Me.EnableDataGridViewTextBoxColumn.DataPropertyName = "Enable"
        Me.EnableDataGridViewTextBoxColumn.HeaderText = "Enable"
        Me.EnableDataGridViewTextBoxColumn.Name = "EnableDataGridViewTextBoxColumn"
        Me.EnableDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnableDataGridViewTextBoxColumn.Visible = False
        '
        'grpSchedule
        '
        Me.grpSchedule.Controls.Add(Me.radWeekly)
        Me.grpSchedule.Controls.Add(Me.radDaily)
        Me.grpSchedule.Controls.Add(Me.dtpDate)
        Me.grpSchedule.Controls.Add(Me.grpWeekly)
        Me.grpSchedule.Controls.Add(Me.grpDaily)
        Me.grpSchedule.Location = New System.Drawing.Point(603, 52)
        Me.grpSchedule.Name = "grpSchedule"
        Me.grpSchedule.Size = New System.Drawing.Size(374, 236)
        Me.grpSchedule.TabIndex = 41
        Me.grpSchedule.TabStop = False
        Me.grpSchedule.Text = "Planification des jours"
        '
        'radWeekly
        '
        Me.radWeekly.AutoSize = True
        Me.radWeekly.Location = New System.Drawing.Point(82, 30)
        Me.radWeekly.Name = "radWeekly"
        Me.radWeekly.Size = New System.Drawing.Size(94, 17)
        Me.radWeekly.TabIndex = 5
        Me.radWeekly.TabStop = True
        Me.radWeekly.Text = "Hebdomadaire"
        Me.radWeekly.UseVisualStyleBackColor = True
        '
        'radDaily
        '
        Me.radDaily.AutoSize = True
        Me.radDaily.Location = New System.Drawing.Point(6, 30)
        Me.radDaily.Name = "radDaily"
        Me.radDaily.Size = New System.Drawing.Size(70, 17)
        Me.radDaily.TabIndex = 4
        Me.radDaily.TabStop = True
        Me.radDaily.Text = "Journalier"
        Me.radDaily.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(6, 57)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(344, 20)
        Me.dtpDate.TabIndex = 1
        '
        'grpDaily
        '
        Me.grpDaily.Controls.Add(Me.labDayTo)
        Me.grpDaily.Controls.Add(Me.labDayFrom)
        Me.grpDaily.Controls.Add(Me.texDayTo)
        Me.grpDaily.Controls.Add(Me.texDayFrom)
        Me.grpDaily.Controls.Add(Me.radDays)
        Me.grpDaily.Controls.Add(Me.radWeekDays)
        Me.grpDaily.Controls.Add(Me.texNumberOfDays)
        Me.grpDaily.Controls.Add(Me.labNumberOfDays)
        Me.grpDaily.Location = New System.Drawing.Point(6, 83)
        Me.grpDaily.Name = "grpDaily"
        Me.grpDaily.Size = New System.Drawing.Size(344, 143)
        Me.grpDaily.TabIndex = 18
        Me.grpDaily.TabStop = False
        '
        'labDayTo
        '
        Me.labDayTo.AutoSize = True
        Me.labDayTo.Location = New System.Drawing.Point(168, 86)
        Me.labDayTo.Name = "labDayTo"
        Me.labDayTo.Size = New System.Drawing.Size(14, 13)
        Me.labDayTo.TabIndex = 22
        Me.labDayTo.Text = "A"
        '
        'labDayFrom
        '
        Me.labDayFrom.AutoSize = True
        Me.labDayFrom.Location = New System.Drawing.Point(80, 86)
        Me.labDayFrom.Name = "labDayFrom"
        Me.labDayFrom.Size = New System.Drawing.Size(21, 13)
        Me.labDayFrom.TabIndex = 20
        Me.labDayFrom.Text = "De"
        '
        'texDayTo
        '
        Me.texDayTo.Location = New System.Drawing.Point(188, 83)
        Me.texDayTo.Name = "texDayTo"
        Me.texDayTo.Size = New System.Drawing.Size(38, 20)
        Me.texDayTo.TabIndex = 21
        Me.texDayTo.Text = "10"
        Me.texDayTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texDayFrom
        '
        Me.texDayFrom.Location = New System.Drawing.Point(107, 83)
        Me.texDayFrom.Name = "texDayFrom"
        Me.texDayFrom.Size = New System.Drawing.Size(38, 20)
        Me.texDayFrom.TabIndex = 20
        Me.texDayFrom.Text = "8"
        Me.texDayFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'radDays
        '
        Me.radDays.AutoSize = True
        Me.radDays.Location = New System.Drawing.Point(167, 49)
        Me.radDays.Name = "radDays"
        Me.radDays.Size = New System.Drawing.Size(128, 17)
        Me.radDays.TabIndex = 10
        Me.radDays.Text = "Semaine et week-end"
        Me.radDays.UseVisualStyleBackColor = True
        '
        'radWeekDays
        '
        Me.radWeekDays.AutoSize = True
        Me.radWeekDays.Checked = True
        Me.radWeekDays.Location = New System.Drawing.Point(167, 22)
        Me.radWeekDays.Name = "radWeekDays"
        Me.radWeekDays.Size = New System.Drawing.Size(124, 17)
        Me.radWeekDays.TabIndex = 9
        Me.radWeekDays.TabStop = True
        Me.radWeekDays.Text = "Uniquement semaine"
        Me.radWeekDays.UseVisualStyleBackColor = True
        '
        'texNumberOfDays
        '
        Me.texNumberOfDays.Location = New System.Drawing.Point(105, 46)
        Me.texNumberOfDays.Name = "texNumberOfDays"
        Me.texNumberOfDays.Size = New System.Drawing.Size(38, 20)
        Me.texNumberOfDays.TabIndex = 7
        Me.texNumberOfDays.Text = "1"
        Me.texNumberOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labNumberOfDays
        '
        Me.labNumberOfDays.AutoSize = True
        Me.labNumberOfDays.Location = New System.Drawing.Point(15, 49)
        Me.labNumberOfDays.Name = "labNumberOfDays"
        Me.labNumberOfDays.Size = New System.Drawing.Size(84, 13)
        Me.labNumberOfDays.TabIndex = 8
        Me.labNumberOfDays.Text = "Nombre de jours"
        '
        'grpWeekly
        '
        Me.grpWeekly.Controls.Add(Me.chkMonday)
        Me.grpWeekly.Controls.Add(Me.Label1)
        Me.grpWeekly.Controls.Add(Me.Label2)
        Me.grpWeekly.Controls.Add(Me.texWeekTo)
        Me.grpWeekly.Controls.Add(Me.texWeekFrom)
        Me.grpWeekly.Controls.Add(Me.texNumberOfWeeks)
        Me.grpWeekly.Controls.Add(Me.labNumberOfWeeks)
        Me.grpWeekly.Controls.Add(Me.chkTuesday)
        Me.grpWeekly.Controls.Add(Me.chkWednesday)
        Me.grpWeekly.Controls.Add(Me.chkSunday)
        Me.grpWeekly.Controls.Add(Me.chkThursday)
        Me.grpWeekly.Controls.Add(Me.chkSaturday)
        Me.grpWeekly.Controls.Add(Me.chkFriday)
        Me.grpWeekly.Location = New System.Drawing.Point(6, 83)
        Me.grpWeekly.Name = "grpWeekly"
        Me.grpWeekly.Size = New System.Drawing.Size(315, 143)
        Me.grpWeekly.TabIndex = 19
        Me.grpWeekly.TabStop = False
        '
        'chkMonday
        '
        Me.chkMonday.AutoSize = True
        Me.chkMonday.Location = New System.Drawing.Point(15, 17)
        Me.chkMonday.Name = "chkMonday"
        Me.chkMonday.Size = New System.Drawing.Size(48, 17)
        Me.chkMonday.TabIndex = 9
        Me.chkMonday.Text = "lundi"
        Me.chkMonday.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "De"
        '
        'texWeekTo
        '
        Me.texWeekTo.Location = New System.Drawing.Point(124, 105)
        Me.texWeekTo.Name = "texWeekTo"
        Me.texWeekTo.Size = New System.Drawing.Size(38, 20)
        Me.texWeekTo.TabIndex = 25
        Me.texWeekTo.Text = "10"
        '
        'texWeekFrom
        '
        Me.texWeekFrom.Location = New System.Drawing.Point(43, 105)
        Me.texWeekFrom.Name = "texWeekFrom"
        Me.texWeekFrom.Size = New System.Drawing.Size(38, 20)
        Me.texWeekFrom.TabIndex = 24
        Me.texWeekFrom.Text = "8"
        '
        'texNumberOfWeeks
        '
        Me.texNumberOfWeeks.Location = New System.Drawing.Point(124, 79)
        Me.texNumberOfWeeks.Name = "texNumberOfWeeks"
        Me.texNumberOfWeeks.Size = New System.Drawing.Size(38, 20)
        Me.texNumberOfWeeks.TabIndex = 16
        Me.texNumberOfWeeks.Text = "1"
        '
        'labNumberOfWeeks
        '
        Me.labNumberOfWeeks.AutoSize = True
        Me.labNumberOfWeeks.Location = New System.Drawing.Point(12, 82)
        Me.labNumberOfWeeks.Name = "labNumberOfWeeks"
        Me.labNumberOfWeeks.Size = New System.Drawing.Size(106, 13)
        Me.labNumberOfWeeks.TabIndex = 17
        Me.labNumberOfWeeks.Text = "Nombre de semaines"
        '
        'chkTuesday
        '
        Me.chkTuesday.AutoSize = True
        Me.chkTuesday.Location = New System.Drawing.Point(15, 45)
        Me.chkTuesday.Name = "chkTuesday"
        Me.chkTuesday.Size = New System.Drawing.Size(51, 17)
        Me.chkTuesday.TabIndex = 10
        Me.chkTuesday.Text = "mardi"
        Me.chkTuesday.UseVisualStyleBackColor = True
        '
        'chkWednesday
        '
        Me.chkWednesday.AutoSize = True
        Me.chkWednesday.Location = New System.Drawing.Point(77, 17)
        Me.chkWednesday.Name = "chkWednesday"
        Me.chkWednesday.Size = New System.Drawing.Size(66, 17)
        Me.chkWednesday.TabIndex = 11
        Me.chkWednesday.Text = "mercredi"
        Me.chkWednesday.UseVisualStyleBackColor = True
        '
        'chkSunday
        '
        Me.chkSunday.AutoSize = True
        Me.chkSunday.Location = New System.Drawing.Point(222, 17)
        Me.chkSunday.Name = "chkSunday"
        Me.chkSunday.Size = New System.Drawing.Size(72, 17)
        Me.chkSunday.TabIndex = 15
        Me.chkSunday.Text = "dimanche"
        Me.chkSunday.UseVisualStyleBackColor = True
        '
        'chkThursday
        '
        Me.chkThursday.AutoSize = True
        Me.chkThursday.Location = New System.Drawing.Point(77, 45)
        Me.chkThursday.Name = "chkThursday"
        Me.chkThursday.Size = New System.Drawing.Size(48, 17)
        Me.chkThursday.TabIndex = 12
        Me.chkThursday.Text = "jeudi"
        Me.chkThursday.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(149, 45)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(59, 17)
        Me.chkSaturday.TabIndex = 14
        Me.chkSaturday.Text = "samedi"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkFriday
        '
        Me.chkFriday.AutoSize = True
        Me.chkFriday.Location = New System.Drawing.Point(149, 17)
        Me.chkFriday.Name = "chkFriday"
        Me.chkFriday.Size = New System.Drawing.Size(67, 17)
        Me.chkFriday.TabIndex = 13
        Me.chkFriday.Text = "vendredi"
        Me.chkFriday.UseVisualStyleBackColor = True
        '
        'labProjectMember
        '
        Me.labProjectMember.AutoSize = True
        Me.labProjectMember.Location = New System.Drawing.Point(27, 302)
        Me.labProjectMember.Name = "labProjectMember"
        Me.labProjectMember.Size = New System.Drawing.Size(94, 13)
        Me.labProjectMember.TabIndex = 40
        Me.labProjectMember.Text = "Membres de projet"
        '
        'frmPlanResources
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 585)
        Me.Controls.Add(Me.texMessage)
        Me.Controls.Add(Me.dgvProjectMembers)
        Me.Controls.Add(Me.grpSchedule)
        Me.Controls.Add(Me.labProjectMember)
        Me.Controls.Add(Me.tabResources)
        Me.Controls.Add(Me.btcPlanFree)
        Me.Controls.Add(Me.btcPlan)
        Me.Controls.Add(Me.btcFermer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPlanResources"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planification de ressources administratives"
        CType(Me.VprojectmembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProjectPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResourcesAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VresourcesadminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsResoucesAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResources.ResumeLayout(False)
        Me.tabPageAdmin.ResumeLayout(False)
        Me.tabPageProjects.ResumeLayout(False)
        CType(Me.dgvProjectMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSchedule.ResumeLayout(False)
        Me.grpSchedule.PerformLayout()
        Me.grpDaily.ResumeLayout(False)
        Me.grpDaily.PerformLayout()
        Me.grpWeekly.ResumeLayout(False)
        Me.grpWeekly.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btcPlanFree As Button
    Friend WithEvents btcPlan As Button
    Friend WithEvents btcFermer As Button
    Friend WithEvents dsProjectPlan As projectplanDataSet
    Friend WithEvents VprojectmembersBindingSource As BindingSource
    Friend WithEvents VprojectmembersTableAdapter As projectplanDataSetTableAdapters.vprojectmembersTableAdapter
    Friend WithEvents dgvResourcesAdmin As DataGridView
    Friend WithEvents DsResoucesAdmin As dsResoucesAdmin
    Friend WithEvents VresourcesadminBindingSource As BindingSource
    Friend WithEvents VresourcesadminTableAdapter As dsResoucesAdminTableAdapters.vresourcesadminTableAdapter
    Friend WithEvents IDAdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SymbolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvProjects As DataGridView
    Friend WithEvents DsProjects As dsProjects
    Friend WithEvents ProjectsBindingSource As BindingSource
    Friend WithEvents ProjectsTableAdapter As dsProjectsTableAdapters.projectsTableAdapter
    Friend WithEvents tabResources As TabControl
    Friend WithEvents tabPageAdmin As TabPage
    Friend WithEvents tabPageProjects As TabPage
    Friend WithEvents texMessage As TextBox
    Friend WithEvents dgvProjectMembers As DataGridView
    Friend WithEvents IDProjectMemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDTaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents grpSchedule As GroupBox
    Friend WithEvents radWeekly As RadioButton
    Friend WithEvents radDaily As RadioButton
    Private WithEvents dtpDate As DateTimePicker
    Friend WithEvents grpDaily As GroupBox
    Friend WithEvents labDayTo As Label
    Friend WithEvents labDayFrom As Label
    Friend WithEvents texDayTo As TextBox
    Friend WithEvents texDayFrom As TextBox
    Friend WithEvents radDays As RadioButton
    Friend WithEvents radWeekDays As RadioButton
    Friend WithEvents texNumberOfDays As TextBox
    Friend WithEvents labNumberOfDays As Label
    Friend WithEvents grpWeekly As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents texWeekTo As TextBox
    Friend WithEvents texWeekFrom As TextBox
    Friend WithEvents texNumberOfWeeks As TextBox
    Friend WithEvents chkMonday As CheckBox
    Friend WithEvents labNumberOfWeeks As Label
    Friend WithEvents chkTuesday As CheckBox
    Friend WithEvents chkWednesday As CheckBox
    Friend WithEvents chkSunday As CheckBox
    Friend WithEvents chkThursday As CheckBox
    Friend WithEvents chkSaturday As CheckBox
    Friend WithEvents chkFriday As CheckBox
    Friend WithEvents labProjectMember As Label
    Friend WithEvents IDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeadlineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectManagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDPriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDCustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDUrgencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeginDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImplementationRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectiveResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
