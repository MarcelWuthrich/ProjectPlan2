<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStatistiquesMembers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatistiquesMembers))
        Me.btcFermer = New System.Windows.Forms.Button()
        Me.dgvProjectMembers = New System.Windows.Forms.DataGridView()
        Me.VprojectmembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsvProjectMembers = New ProjectPlan.dsvProjectMembers()
        Me.VprojectmembersTableAdapter = New ProjectPlan.dsvProjectMembersTableAdapters.vprojectmembersTableAdapter()
        Me.dgvNumberPlanedHourOnProjects = New System.Windows.Forms.DataGridView()
        Me.CountIDResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectMemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VstatistiquesnumberofdaysplanonprojectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNumberPlanedHourOnProjects = New ProjectPlan.dsNumberPlanedHourOnProjects()
        Me.dgvNumberPlanedHourOnAdmin = New System.Windows.Forms.DataGridView()
        Me.CountIDResourceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectMemberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDAdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VstatistiquesnumberofdaysplanonadminresourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsNumberPlanedHourOnAdmin = New ProjectPlan.dsNumberPlanedHourOnAdmin()
        Me.VstatistiquesnumberofdaysplanonprojectsTableAdapter = New ProjectPlan.dsNumberPlanedHourOnProjectsTableAdapters.vstatistiquesnumberofdaysplanonprojectsTableAdapter()
        Me.VstatistiquesnumberofdaysplanonadminresourcesTableAdapter = New ProjectPlan.dsNumberPlanedHourOnAdminTableAdapters.vstatistiquesnumberofdaysplanonadminresourcesTableAdapter()
        Me.labNumberPlanedHourOnProjects = New System.Windows.Forms.Label()
        Me.labNumberPlanedHourOnAdmin = New System.Windows.Forms.Label()
        Me.texProjectMember = New System.Windows.Forms.TextBox()
        Me.labEndYear = New System.Windows.Forms.Label()
        Me.texStatAdminEndYear = New System.Windows.Forms.TextBox()
        Me.texStatFreeEndYear = New System.Windows.Forms.TextBox()
        Me.texStatProjectsEndYear = New System.Windows.Forms.TextBox()
        Me.texStatFree3Month = New System.Windows.Forms.TextBox()
        Me.lab12mois = New System.Windows.Forms.Label()
        Me.texStatProjects3Month = New System.Windows.Forms.TextBox()
        Me.texStatAdmin3Month = New System.Windows.Forms.TextBox()
        Me.texStatAdmin12Month = New System.Windows.Forms.TextBox()
        Me.lab1mois = New System.Windows.Forms.Label()
        Me.lab3mois = New System.Windows.Forms.Label()
        Me.texStatFree12Month = New System.Windows.Forms.TextBox()
        Me.texStatAdmin1Month = New System.Windows.Forms.TextBox()
        Me.labNumberHourProjects = New System.Windows.Forms.Label()
        Me.texStatProjects6Month = New System.Windows.Forms.TextBox()
        Me.texStatProjects12Month = New System.Windows.Forms.TextBox()
        Me.labNumberHourAdmin = New System.Windows.Forms.Label()
        Me.texStatProjects1Month = New System.Windows.Forms.TextBox()
        Me.texStatFree6Month = New System.Windows.Forms.TextBox()
        Me.lab6mois = New System.Windows.Forms.Label()
        Me.texStatFree1Month = New System.Windows.Forms.TextBox()
        Me.labNumberHourFree = New System.Windows.Forms.Label()
        Me.texStatAdmin6Month = New System.Windows.Forms.TextBox()
        Me.labProjectMember = New System.Windows.Forms.Label()
        Me.IDProjectMemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDTaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProjectMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectmembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsvProjectMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNumberPlanedHourOnProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VstatistiquesnumberofdaysplanonprojectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNumberPlanedHourOnProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvNumberPlanedHourOnAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VstatistiquesnumberofdaysplanonadminresourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNumberPlanedHourOnAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcFermer
        '
        Me.btcFermer.Location = New System.Drawing.Point(974, 458)
        Me.btcFermer.Name = "btcFermer"
        Me.btcFermer.Size = New System.Drawing.Size(75, 23)
        Me.btcFermer.TabIndex = 0
        Me.btcFermer.Text = "Fermer"
        Me.btcFermer.UseVisualStyleBackColor = True
        '
        'dgvProjectMembers
        '
        Me.dgvProjectMembers.AllowUserToAddRows = False
        Me.dgvProjectMembers.AllowUserToDeleteRows = False
        Me.dgvProjectMembers.AutoGenerateColumns = False
        Me.dgvProjectMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectMemberDataGridViewTextBoxColumn, Me.CEIDTaskDataGridViewTextBoxColumn, Me.TaskDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn})
        Me.dgvProjectMembers.DataSource = Me.VprojectmembersBindingSource
        Me.dgvProjectMembers.Location = New System.Drawing.Point(32, 25)
        Me.dgvProjectMembers.MultiSelect = False
        Me.dgvProjectMembers.Name = "dgvProjectMembers"
        Me.dgvProjectMembers.ReadOnly = True
        Me.dgvProjectMembers.RowHeadersVisible = False
        Me.dgvProjectMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectMembers.Size = New System.Drawing.Size(355, 224)
        Me.dgvProjectMembers.TabIndex = 1
        '
        'VprojectmembersBindingSource
        '
        Me.VprojectmembersBindingSource.DataMember = "vprojectmembers"
        Me.VprojectmembersBindingSource.DataSource = Me.DsvProjectMembers
        '
        'DsvProjectMembers
        '
        Me.DsvProjectMembers.DataSetName = "dsvProjectMembers"
        Me.DsvProjectMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectmembersTableAdapter
        '
        Me.VprojectmembersTableAdapter.ClearBeforeFill = True
        '
        'dgvNumberPlanedHourOnProjects
        '
        Me.dgvNumberPlanedHourOnProjects.AllowUserToAddRows = False
        Me.dgvNumberPlanedHourOnProjects.AllowUserToDeleteRows = False
        Me.dgvNumberPlanedHourOnProjects.AutoGenerateColumns = False
        Me.dgvNumberPlanedHourOnProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNumberPlanedHourOnProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumberPlanedHourOnProjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountIDResourceDataGridViewTextBoxColumn, Me.CEIDProjectMemberDataGridViewTextBoxColumn, Me.CEIDProjectDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvNumberPlanedHourOnProjects.DataSource = Me.VstatistiquesnumberofdaysplanonprojectsBindingSource
        Me.dgvNumberPlanedHourOnProjects.Location = New System.Drawing.Point(32, 380)
        Me.dgvNumberPlanedHourOnProjects.MultiSelect = False
        Me.dgvNumberPlanedHourOnProjects.Name = "dgvNumberPlanedHourOnProjects"
        Me.dgvNumberPlanedHourOnProjects.ReadOnly = True
        Me.dgvNumberPlanedHourOnProjects.RowHeadersVisible = False
        Me.dgvNumberPlanedHourOnProjects.Size = New System.Drawing.Size(355, 210)
        Me.dgvNumberPlanedHourOnProjects.TabIndex = 2
        '
        'CountIDResourceDataGridViewTextBoxColumn
        '
        Me.CountIDResourceDataGridViewTextBoxColumn.DataPropertyName = "Count_ID_Resource"
        Me.CountIDResourceDataGridViewTextBoxColumn.HeaderText = "Count_ID_Resource"
        Me.CountIDResourceDataGridViewTextBoxColumn.Name = "CountIDResourceDataGridViewTextBoxColumn"
        Me.CountIDResourceDataGridViewTextBoxColumn.ReadOnly = True
        Me.CountIDResourceDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDProjectMemberDataGridViewTextBoxColumn
        '
        Me.CEIDProjectMemberDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_ProjectMember"
        Me.CEIDProjectMemberDataGridViewTextBoxColumn.HeaderText = "CE_ID_ProjectMember"
        Me.CEIDProjectMemberDataGridViewTextBoxColumn.Name = "CEIDProjectMemberDataGridViewTextBoxColumn"
        Me.CEIDProjectMemberDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDProjectMemberDataGridViewTextBoxColumn.Visible = False
        '
        'CEIDProjectDataGridViewTextBoxColumn
        '
        Me.CEIDProjectDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn.HeaderText = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn.Name = "CEIDProjectDataGridViewTextBoxColumn"
        Me.CEIDProjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDProjectDataGridViewTextBoxColumn.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Visible = False
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VstatistiquesnumberofdaysplanonprojectsBindingSource
        '
        Me.VstatistiquesnumberofdaysplanonprojectsBindingSource.DataMember = "vstatistiquesnumberofdaysplanonprojects"
        Me.VstatistiquesnumberofdaysplanonprojectsBindingSource.DataSource = Me.DsNumberPlanedHourOnProjects
        '
        'DsNumberPlanedHourOnProjects
        '
        Me.DsNumberPlanedHourOnProjects.DataSetName = "dsNumberPlanedHourOnProjects"
        Me.DsNumberPlanedHourOnProjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvNumberPlanedHourOnAdmin
        '
        Me.dgvNumberPlanedHourOnAdmin.AllowUserToAddRows = False
        Me.dgvNumberPlanedHourOnAdmin.AllowUserToDeleteRows = False
        Me.dgvNumberPlanedHourOnAdmin.AutoGenerateColumns = False
        Me.dgvNumberPlanedHourOnAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNumberPlanedHourOnAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNumberPlanedHourOnAdmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountIDResourceDataGridViewTextBoxColumn1, Me.CEIDProjectMemberDataGridViewTextBoxColumn1, Me.CEIDAdminResourceDataGridViewTextBoxColumn, Me.AdminResourceDataGridViewTextBoxColumn, Me.Total})
        Me.dgvNumberPlanedHourOnAdmin.DataSource = Me.VstatistiquesnumberofdaysplanonadminresourcesBindingSource
        Me.dgvNumberPlanedHourOnAdmin.Location = New System.Drawing.Point(568, 380)
        Me.dgvNumberPlanedHourOnAdmin.MultiSelect = False
        Me.dgvNumberPlanedHourOnAdmin.Name = "dgvNumberPlanedHourOnAdmin"
        Me.dgvNumberPlanedHourOnAdmin.ReadOnly = True
        Me.dgvNumberPlanedHourOnAdmin.RowHeadersVisible = False
        Me.dgvNumberPlanedHourOnAdmin.Size = New System.Drawing.Size(355, 210)
        Me.dgvNumberPlanedHourOnAdmin.TabIndex = 3
        '
        'CountIDResourceDataGridViewTextBoxColumn1
        '
        Me.CountIDResourceDataGridViewTextBoxColumn1.DataPropertyName = "Count_ID_Resource"
        Me.CountIDResourceDataGridViewTextBoxColumn1.HeaderText = "Count_ID_Resource"
        Me.CountIDResourceDataGridViewTextBoxColumn1.Name = "CountIDResourceDataGridViewTextBoxColumn1"
        Me.CountIDResourceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CountIDResourceDataGridViewTextBoxColumn1.Visible = False
        '
        'CEIDProjectMemberDataGridViewTextBoxColumn1
        '
        Me.CEIDProjectMemberDataGridViewTextBoxColumn1.DataPropertyName = "CE_ID_ProjectMember"
        Me.CEIDProjectMemberDataGridViewTextBoxColumn1.HeaderText = "CE_ID_ProjectMember"
        Me.CEIDProjectMemberDataGridViewTextBoxColumn1.Name = "CEIDProjectMemberDataGridViewTextBoxColumn1"
        Me.CEIDProjectMemberDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CEIDProjectMemberDataGridViewTextBoxColumn1.Visible = False
        '
        'CEIDAdminResourceDataGridViewTextBoxColumn
        '
        Me.CEIDAdminResourceDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_AdminResource"
        Me.CEIDAdminResourceDataGridViewTextBoxColumn.HeaderText = "CE_ID_AdminResource"
        Me.CEIDAdminResourceDataGridViewTextBoxColumn.Name = "CEIDAdminResourceDataGridViewTextBoxColumn"
        Me.CEIDAdminResourceDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDAdminResourceDataGridViewTextBoxColumn.Visible = False
        '
        'AdminResourceDataGridViewTextBoxColumn
        '
        Me.AdminResourceDataGridViewTextBoxColumn.DataPropertyName = "AdminResource"
        Me.AdminResourceDataGridViewTextBoxColumn.HeaderText = "AdminResource"
        Me.AdminResourceDataGridViewTextBoxColumn.Name = "AdminResourceDataGridViewTextBoxColumn"
        Me.AdminResourceDataGridViewTextBoxColumn.ReadOnly = True
        Me.AdminResourceDataGridViewTextBoxColumn.Visible = False
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'VstatistiquesnumberofdaysplanonadminresourcesBindingSource
        '
        Me.VstatistiquesnumberofdaysplanonadminresourcesBindingSource.DataMember = "vstatistiquesnumberofdaysplanonadminresources"
        Me.VstatistiquesnumberofdaysplanonadminresourcesBindingSource.DataSource = Me.DsNumberPlanedHourOnAdmin
        '
        'DsNumberPlanedHourOnAdmin
        '
        Me.DsNumberPlanedHourOnAdmin.DataSetName = "dsNumberPlanedHourOnAdmin"
        Me.DsNumberPlanedHourOnAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VstatistiquesnumberofdaysplanonprojectsTableAdapter
        '
        Me.VstatistiquesnumberofdaysplanonprojectsTableAdapter.ClearBeforeFill = True
        '
        'VstatistiquesnumberofdaysplanonadminresourcesTableAdapter
        '
        Me.VstatistiquesnumberofdaysplanonadminresourcesTableAdapter.ClearBeforeFill = True
        '
        'labNumberPlanedHourOnProjects
        '
        Me.labNumberPlanedHourOnProjects.AutoSize = True
        Me.labNumberPlanedHourOnProjects.Location = New System.Drawing.Point(29, 349)
        Me.labNumberPlanedHourOnProjects.Name = "labNumberPlanedHourOnProjects"
        Me.labNumberPlanedHourOnProjects.Size = New System.Drawing.Size(205, 13)
        Me.labNumberPlanedHourOnProjects.TabIndex = 4
        Me.labNumberPlanedHourOnProjects.Text = "Nombre d'heures planifiées sur des projets"
        '
        'labNumberPlanedHourOnAdmin
        '
        Me.labNumberPlanedHourOnAdmin.AutoSize = True
        Me.labNumberPlanedHourOnAdmin.Location = New System.Drawing.Point(565, 349)
        Me.labNumberPlanedHourOnAdmin.Name = "labNumberPlanedHourOnAdmin"
        Me.labNumberPlanedHourOnAdmin.Size = New System.Drawing.Size(297, 13)
        Me.labNumberPlanedHourOnAdmin.TabIndex = 5
        Me.labNumberPlanedHourOnAdmin.Text = "Nombre d'heures planifiées sur des ressources administratives"
        '
        'texProjectMember
        '
        Me.texProjectMember.Location = New System.Drawing.Point(568, 25)
        Me.texProjectMember.Name = "texProjectMember"
        Me.texProjectMember.ReadOnly = True
        Me.texProjectMember.Size = New System.Drawing.Size(225, 20)
        Me.texProjectMember.TabIndex = 6
        '
        'labEndYear
        '
        Me.labEndYear.AutoSize = True
        Me.labEndYear.Location = New System.Drawing.Point(886, 109)
        Me.labEndYear.Name = "labEndYear"
        Me.labEndYear.Size = New System.Drawing.Size(49, 13)
        Me.labEndYear.TabIndex = 53
        Me.labEndYear.Text = "End year"
        '
        'texStatAdminEndYear
        '
        Me.texStatAdminEndYear.Location = New System.Drawing.Point(887, 151)
        Me.texStatAdminEndYear.Name = "texStatAdminEndYear"
        Me.texStatAdminEndYear.ReadOnly = True
        Me.texStatAdminEndYear.Size = New System.Drawing.Size(48, 20)
        Me.texStatAdminEndYear.TabIndex = 52
        Me.texStatAdminEndYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatFreeEndYear
        '
        Me.texStatFreeEndYear.Location = New System.Drawing.Point(887, 177)
        Me.texStatFreeEndYear.Name = "texStatFreeEndYear"
        Me.texStatFreeEndYear.ReadOnly = True
        Me.texStatFreeEndYear.Size = New System.Drawing.Size(48, 20)
        Me.texStatFreeEndYear.TabIndex = 51
        Me.texStatFreeEndYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatProjectsEndYear
        '
        Me.texStatProjectsEndYear.Location = New System.Drawing.Point(887, 125)
        Me.texStatProjectsEndYear.Name = "texStatProjectsEndYear"
        Me.texStatProjectsEndYear.ReadOnly = True
        Me.texStatProjectsEndYear.Size = New System.Drawing.Size(48, 20)
        Me.texStatProjectsEndYear.TabIndex = 50
        Me.texStatProjectsEndYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatFree3Month
        '
        Me.texStatFree3Month.Location = New System.Drawing.Point(725, 177)
        Me.texStatFree3Month.Name = "texStatFree3Month"
        Me.texStatFree3Month.ReadOnly = True
        Me.texStatFree3Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatFree3Month.TabIndex = 39
        Me.texStatFree3Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lab12mois
        '
        Me.lab12mois.AutoSize = True
        Me.lab12mois.Location = New System.Drawing.Point(835, 109)
        Me.lab12mois.Name = "lab12mois"
        Me.lab12mois.Size = New System.Drawing.Size(43, 13)
        Me.lab12mois.TabIndex = 49
        Me.lab12mois.Text = "12 mois"
        '
        'texStatProjects3Month
        '
        Me.texStatProjects3Month.Location = New System.Drawing.Point(725, 125)
        Me.texStatProjects3Month.Name = "texStatProjects3Month"
        Me.texStatProjects3Month.ReadOnly = True
        Me.texStatProjects3Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatProjects3Month.TabIndex = 38
        Me.texStatProjects3Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatAdmin3Month
        '
        Me.texStatAdmin3Month.Location = New System.Drawing.Point(725, 151)
        Me.texStatAdmin3Month.Name = "texStatAdmin3Month"
        Me.texStatAdmin3Month.ReadOnly = True
        Me.texStatAdmin3Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatAdmin3Month.TabIndex = 40
        Me.texStatAdmin3Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatAdmin12Month
        '
        Me.texStatAdmin12Month.Location = New System.Drawing.Point(833, 151)
        Me.texStatAdmin12Month.Name = "texStatAdmin12Month"
        Me.texStatAdmin12Month.ReadOnly = True
        Me.texStatAdmin12Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatAdmin12Month.TabIndex = 48
        Me.texStatAdmin12Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lab1mois
        '
        Me.lab1mois.AutoSize = True
        Me.lab1mois.Location = New System.Drawing.Point(676, 109)
        Me.lab1mois.Name = "lab1mois"
        Me.lab1mois.Size = New System.Drawing.Size(37, 13)
        Me.lab1mois.TabIndex = 37
        Me.lab1mois.Text = "1 mois"
        '
        'lab3mois
        '
        Me.lab3mois.AutoSize = True
        Me.lab3mois.Location = New System.Drawing.Point(730, 109)
        Me.lab3mois.Name = "lab3mois"
        Me.lab3mois.Size = New System.Drawing.Size(37, 13)
        Me.lab3mois.TabIndex = 41
        Me.lab3mois.Text = "3 mois"
        '
        'texStatFree12Month
        '
        Me.texStatFree12Month.Location = New System.Drawing.Point(833, 177)
        Me.texStatFree12Month.Name = "texStatFree12Month"
        Me.texStatFree12Month.ReadOnly = True
        Me.texStatFree12Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatFree12Month.TabIndex = 47
        Me.texStatFree12Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatAdmin1Month
        '
        Me.texStatAdmin1Month.Location = New System.Drawing.Point(671, 151)
        Me.texStatAdmin1Month.Name = "texStatAdmin1Month"
        Me.texStatAdmin1Month.ReadOnly = True
        Me.texStatAdmin1Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatAdmin1Month.TabIndex = 36
        Me.texStatAdmin1Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labNumberHourProjects
        '
        Me.labNumberHourProjects.AutoSize = True
        Me.labNumberHourProjects.Location = New System.Drawing.Point(476, 128)
        Me.labNumberHourProjects.Name = "labNumberHourProjects"
        Me.labNumberHourProjects.Size = New System.Drawing.Size(151, 13)
        Me.labNumberHourProjects.TabIndex = 31
        Me.labNumberHourProjects.Text = "Nbre d'heures pour des projets"
        '
        'texStatProjects6Month
        '
        Me.texStatProjects6Month.Location = New System.Drawing.Point(779, 125)
        Me.texStatProjects6Month.Name = "texStatProjects6Month"
        Me.texStatProjects6Month.ReadOnly = True
        Me.texStatProjects6Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatProjects6Month.TabIndex = 42
        Me.texStatProjects6Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatProjects12Month
        '
        Me.texStatProjects12Month.Location = New System.Drawing.Point(833, 125)
        Me.texStatProjects12Month.Name = "texStatProjects12Month"
        Me.texStatProjects12Month.ReadOnly = True
        Me.texStatProjects12Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatProjects12Month.TabIndex = 46
        Me.texStatProjects12Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labNumberHourAdmin
        '
        Me.labNumberHourAdmin.AutoSize = True
        Me.labNumberHourAdmin.Location = New System.Drawing.Point(476, 154)
        Me.labNumberHourAdmin.Name = "labNumberHourAdmin"
        Me.labNumberHourAdmin.Size = New System.Drawing.Size(145, 13)
        Me.labNumberHourAdmin.TabIndex = 35
        Me.labNumberHourAdmin.Text = "Nbre d'heures administratives"
        '
        'texStatProjects1Month
        '
        Me.texStatProjects1Month.Location = New System.Drawing.Point(671, 125)
        Me.texStatProjects1Month.Name = "texStatProjects1Month"
        Me.texStatProjects1Month.ReadOnly = True
        Me.texStatProjects1Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatProjects1Month.TabIndex = 32
        Me.texStatProjects1Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'texStatFree6Month
        '
        Me.texStatFree6Month.Location = New System.Drawing.Point(779, 177)
        Me.texStatFree6Month.Name = "texStatFree6Month"
        Me.texStatFree6Month.ReadOnly = True
        Me.texStatFree6Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatFree6Month.TabIndex = 43
        Me.texStatFree6Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lab6mois
        '
        Me.lab6mois.AutoSize = True
        Me.lab6mois.Location = New System.Drawing.Point(784, 109)
        Me.lab6mois.Name = "lab6mois"
        Me.lab6mois.Size = New System.Drawing.Size(37, 13)
        Me.lab6mois.TabIndex = 45
        Me.lab6mois.Text = "6 mois"
        '
        'texStatFree1Month
        '
        Me.texStatFree1Month.Location = New System.Drawing.Point(671, 177)
        Me.texStatFree1Month.Name = "texStatFree1Month"
        Me.texStatFree1Month.ReadOnly = True
        Me.texStatFree1Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatFree1Month.TabIndex = 34
        Me.texStatFree1Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labNumberHourFree
        '
        Me.labNumberHourFree.AutoSize = True
        Me.labNumberHourFree.Location = New System.Drawing.Point(476, 180)
        Me.labNumberHourFree.Name = "labNumberHourFree"
        Me.labNumberHourFree.Size = New System.Drawing.Size(114, 13)
        Me.labNumberHourFree.TabIndex = 33
        Me.labNumberHourFree.Text = "Nombre d'heures libres"
        '
        'texStatAdmin6Month
        '
        Me.texStatAdmin6Month.Location = New System.Drawing.Point(779, 151)
        Me.texStatAdmin6Month.Name = "texStatAdmin6Month"
        Me.texStatAdmin6Month.ReadOnly = True
        Me.texStatAdmin6Month.Size = New System.Drawing.Size(48, 20)
        Me.texStatAdmin6Month.TabIndex = 44
        Me.texStatAdmin6Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labProjectMember
        '
        Me.labProjectMember.AutoSize = True
        Me.labProjectMember.Location = New System.Drawing.Point(447, 28)
        Me.labProjectMember.Name = "labProjectMember"
        Me.labProjectMember.Size = New System.Drawing.Size(94, 13)
        Me.labProjectMember.TabIndex = 54
        Me.labProjectMember.Text = "Membre de projets"
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
        'TaskDataGridViewTextBoxColumn
        '
        Me.TaskDataGridViewTextBoxColumn.DataPropertyName = "Task"
        Me.TaskDataGridViewTextBoxColumn.HeaderText = "Task"
        Me.TaskDataGridViewTextBoxColumn.Name = "TaskDataGridViewTextBoxColumn"
        Me.TaskDataGridViewTextBoxColumn.ReadOnly = True
        Me.TaskDataGridViewTextBoxColumn.Visible = False
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
        'EnableDataGridViewTextBoxColumn
        '
        Me.EnableDataGridViewTextBoxColumn.DataPropertyName = "Enable"
        Me.EnableDataGridViewTextBoxColumn.HeaderText = "Enable"
        Me.EnableDataGridViewTextBoxColumn.Name = "EnableDataGridViewTextBoxColumn"
        Me.EnableDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnableDataGridViewTextBoxColumn.Visible = False
        '
        'frmStatistiquesMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 627)
        Me.Controls.Add(Me.labProjectMember)
        Me.Controls.Add(Me.labEndYear)
        Me.Controls.Add(Me.texStatAdminEndYear)
        Me.Controls.Add(Me.texStatFreeEndYear)
        Me.Controls.Add(Me.texStatProjectsEndYear)
        Me.Controls.Add(Me.texStatFree3Month)
        Me.Controls.Add(Me.lab12mois)
        Me.Controls.Add(Me.texStatProjects3Month)
        Me.Controls.Add(Me.texStatAdmin3Month)
        Me.Controls.Add(Me.texStatAdmin12Month)
        Me.Controls.Add(Me.lab1mois)
        Me.Controls.Add(Me.lab3mois)
        Me.Controls.Add(Me.texStatFree12Month)
        Me.Controls.Add(Me.texStatAdmin1Month)
        Me.Controls.Add(Me.labNumberHourProjects)
        Me.Controls.Add(Me.texStatProjects6Month)
        Me.Controls.Add(Me.texStatProjects12Month)
        Me.Controls.Add(Me.labNumberHourAdmin)
        Me.Controls.Add(Me.texStatProjects1Month)
        Me.Controls.Add(Me.texStatFree6Month)
        Me.Controls.Add(Me.lab6mois)
        Me.Controls.Add(Me.texStatFree1Month)
        Me.Controls.Add(Me.labNumberHourFree)
        Me.Controls.Add(Me.texStatAdmin6Month)
        Me.Controls.Add(Me.texProjectMember)
        Me.Controls.Add(Me.labNumberPlanedHourOnAdmin)
        Me.Controls.Add(Me.labNumberPlanedHourOnProjects)
        Me.Controls.Add(Me.dgvNumberPlanedHourOnAdmin)
        Me.Controls.Add(Me.dgvNumberPlanedHourOnProjects)
        Me.Controls.Add(Me.dgvProjectMembers)
        Me.Controls.Add(Me.btcFermer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStatistiquesMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistiques des members de projets"
        CType(Me.dgvProjectMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectmembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsvProjectMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNumberPlanedHourOnProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VstatistiquesnumberofdaysplanonprojectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNumberPlanedHourOnProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvNumberPlanedHourOnAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VstatistiquesnumberofdaysplanonadminresourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNumberPlanedHourOnAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btcFermer As Button
    Friend WithEvents dgvProjectMembers As DataGridView
    Friend WithEvents DsvProjectMembers As dsvProjectMembers
    Friend WithEvents VprojectmembersBindingSource As BindingSource
    Friend WithEvents VprojectmembersTableAdapter As dsvProjectMembersTableAdapters.vprojectmembersTableAdapter
    Friend WithEvents dgvNumberPlanedHourOnProjects As DataGridView
    Friend WithEvents dgvNumberPlanedHourOnAdmin As DataGridView
    Friend WithEvents DsNumberPlanedHourOnProjects As dsNumberPlanedHourOnProjects
    Friend WithEvents VstatistiquesnumberofdaysplanonprojectsBindingSource As BindingSource
    Friend WithEvents VstatistiquesnumberofdaysplanonprojectsTableAdapter As dsNumberPlanedHourOnProjectsTableAdapters.vstatistiquesnumberofdaysplanonprojectsTableAdapter
    Friend WithEvents CountIDResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectMemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DsNumberPlanedHourOnAdmin As dsNumberPlanedHourOnAdmin
    Friend WithEvents VstatistiquesnumberofdaysplanonadminresourcesBindingSource As BindingSource
    Friend WithEvents VstatistiquesnumberofdaysplanonadminresourcesTableAdapter As dsNumberPlanedHourOnAdminTableAdapters.vstatistiquesnumberofdaysplanonadminresourcesTableAdapter
    Friend WithEvents CountIDResourceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectMemberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CEIDAdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents labNumberPlanedHourOnProjects As Label
    Friend WithEvents labNumberPlanedHourOnAdmin As Label
    Friend WithEvents texProjectMember As TextBox
    Friend WithEvents labEndYear As Label
    Friend WithEvents texStatAdminEndYear As TextBox
    Friend WithEvents texStatFreeEndYear As TextBox
    Friend WithEvents texStatProjectsEndYear As TextBox
    Friend WithEvents texStatFree3Month As TextBox
    Friend WithEvents lab12mois As Label
    Friend WithEvents texStatProjects3Month As TextBox
    Friend WithEvents texStatAdmin3Month As TextBox
    Friend WithEvents texStatAdmin12Month As TextBox
    Friend WithEvents lab1mois As Label
    Friend WithEvents lab3mois As Label
    Friend WithEvents texStatFree12Month As TextBox
    Friend WithEvents texStatAdmin1Month As TextBox
    Friend WithEvents labNumberHourProjects As Label
    Friend WithEvents texStatProjects6Month As TextBox
    Friend WithEvents texStatProjects12Month As TextBox
    Friend WithEvents labNumberHourAdmin As Label
    Friend WithEvents texStatProjects1Month As TextBox
    Friend WithEvents texStatFree6Month As TextBox
    Friend WithEvents lab6mois As Label
    Friend WithEvents texStatFree1Month As TextBox
    Friend WithEvents labNumberHourFree As Label
    Friend WithEvents texStatAdmin6Month As TextBox
    Friend WithEvents labProjectMember As Label
    Friend WithEvents IDProjectMemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDTaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
