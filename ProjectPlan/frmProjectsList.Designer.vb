<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProjectsList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectsList))
        Me.chkAllProjects = New System.Windows.Forms.CheckBox()
        Me.labFilterCategory = New System.Windows.Forms.Label()
        Me.labFilterStatus = New System.Windows.Forms.Label()
        Me.LabFilterText = New System.Windows.Forms.Label()
        Me.labProjectsNumber = New System.Windows.Forms.Label()
        Me.lovFilterCategory = New System.Windows.Forms.ComboBox()
        Me.lovFilterStatus = New System.Windows.Forms.ComboBox()
        Me.btcFilterClear = New System.Windows.Forms.Button()
        Me.btcFilter = New System.Windows.Forms.Button()
        Me.texFilter = New System.Windows.Forms.TextBox()
        Me.btcModifyProject = New System.Windows.Forms.Button()
        Me.btcAddProject = New System.Windows.Forms.Button()
        Me.grpFilters = New System.Windows.Forms.GroupBox()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.dgvProjets = New System.Windows.Forms.DataGridView()
        Me.IDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerFirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerLastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerFirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerLastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDUrgencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrgencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeginDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeadlineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImplementationRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectiveResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VprojectlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProjectsList = New ProjectPlan.dsProjectsList()
        Me.VprojectlistTableAdapter = New ProjectPlan.dsProjectsListTableAdapters.vprojectlistTableAdapter()
        Me.grpFilters.SuspendLayout()
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjectsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAllProjects
        '
        Me.chkAllProjects.AutoSize = True
        Me.chkAllProjects.Location = New System.Drawing.Point(452, 45)
        Me.chkAllProjects.Name = "chkAllProjects"
        Me.chkAllProjects.Size = New System.Drawing.Size(95, 17)
        Me.chkAllProjects.TabIndex = 19
        Me.chkAllProjects.Text = "Project inactifs"
        Me.chkAllProjects.UseVisualStyleBackColor = True
        '
        'labFilterCategory
        '
        Me.labFilterCategory.AutoSize = True
        Me.labFilterCategory.Location = New System.Drawing.Point(328, 24)
        Me.labFilterCategory.Name = "labFilterCategory"
        Me.labFilterCategory.Size = New System.Drawing.Size(52, 13)
        Me.labFilterCategory.TabIndex = 18
        Me.labFilterCategory.Text = "Catégorie"
        '
        'labFilterStatus
        '
        Me.labFilterStatus.AutoSize = True
        Me.labFilterStatus.Location = New System.Drawing.Point(202, 24)
        Me.labFilterStatus.Name = "labFilterStatus"
        Me.labFilterStatus.Size = New System.Drawing.Size(35, 13)
        Me.labFilterStatus.TabIndex = 17
        Me.labFilterStatus.Text = "Statut"
        '
        'LabFilterText
        '
        Me.LabFilterText.AutoSize = True
        Me.LabFilterText.Location = New System.Drawing.Point(14, 24)
        Me.LabFilterText.Name = "LabFilterText"
        Me.LabFilterText.Size = New System.Drawing.Size(34, 13)
        Me.LabFilterText.TabIndex = 16
        Me.LabFilterText.Text = "Texte"
        '
        'labProjectsNumber
        '
        Me.labProjectsNumber.Location = New System.Drawing.Point(801, 42)
        Me.labProjectsNumber.Name = "labProjectsNumber"
        Me.labProjectsNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labProjectsNumber.Size = New System.Drawing.Size(118, 21)
        Me.labProjectsNumber.TabIndex = 15
        Me.labProjectsNumber.Text = "Projets : 10/10"
        Me.labProjectsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lovFilterCategory
        '
        Me.lovFilterCategory.FormattingEnabled = True
        Me.lovFilterCategory.Location = New System.Drawing.Point(325, 42)
        Me.lovFilterCategory.Name = "lovFilterCategory"
        Me.lovFilterCategory.Size = New System.Drawing.Size(121, 21)
        Me.lovFilterCategory.TabIndex = 14
        '
        'lovFilterStatus
        '
        Me.lovFilterStatus.FormattingEnabled = True
        Me.lovFilterStatus.Location = New System.Drawing.Point(198, 42)
        Me.lovFilterStatus.Name = "lovFilterStatus"
        Me.lovFilterStatus.Size = New System.Drawing.Size(121, 21)
        Me.lovFilterStatus.TabIndex = 13
        '
        'btcFilterClear
        '
        Me.btcFilterClear.Image = CType(resources.GetObject("btcFilterClear.Image"), System.Drawing.Image)
        Me.btcFilterClear.Location = New System.Drawing.Point(634, 40)
        Me.btcFilterClear.Name = "btcFilterClear"
        Me.btcFilterClear.Size = New System.Drawing.Size(23, 23)
        Me.btcFilterClear.TabIndex = 12
        Me.btcFilterClear.UseVisualStyleBackColor = True
        '
        'btcFilter
        '
        Me.btcFilter.Location = New System.Drawing.Point(553, 40)
        Me.btcFilter.Name = "btcFilter"
        Me.btcFilter.Size = New System.Drawing.Size(75, 23)
        Me.btcFilter.TabIndex = 11
        Me.btcFilter.Text = "Filtre"
        Me.btcFilter.UseVisualStyleBackColor = True
        '
        'texFilter
        '
        Me.texFilter.Location = New System.Drawing.Point(11, 42)
        Me.texFilter.Name = "texFilter"
        Me.texFilter.Size = New System.Drawing.Size(180, 20)
        Me.texFilter.TabIndex = 9
        '
        'btcModifyProject
        '
        Me.btcModifyProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcModifyProject.Location = New System.Drawing.Point(1172, 267)
        Me.btcModifyProject.Name = "btcModifyProject"
        Me.btcModifyProject.Size = New System.Drawing.Size(107, 23)
        Me.btcModifyProject.TabIndex = 8
        Me.btcModifyProject.Text = "Modifier"
        Me.btcModifyProject.UseVisualStyleBackColor = True
        '
        'btcAddProject
        '
        Me.btcAddProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcAddProject.Location = New System.Drawing.Point(1172, 238)
        Me.btcAddProject.Name = "btcAddProject"
        Me.btcAddProject.Size = New System.Drawing.Size(107, 23)
        Me.btcAddProject.TabIndex = 7
        Me.btcAddProject.Text = "Ajouter"
        Me.btcAddProject.UseVisualStyleBackColor = True
        '
        'grpFilters
        '
        Me.grpFilters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFilters.Controls.Add(Me.lovFilterCategory)
        Me.grpFilters.Controls.Add(Me.btcFilterClear)
        Me.grpFilters.Controls.Add(Me.chkAllProjects)
        Me.grpFilters.Controls.Add(Me.lovFilterStatus)
        Me.grpFilters.Controls.Add(Me.labFilterCategory)
        Me.grpFilters.Controls.Add(Me.texFilter)
        Me.grpFilters.Controls.Add(Me.labFilterStatus)
        Me.grpFilters.Controls.Add(Me.labProjectsNumber)
        Me.grpFilters.Controls.Add(Me.btcFilter)
        Me.grpFilters.Controls.Add(Me.LabFilterText)
        Me.grpFilters.Location = New System.Drawing.Point(12, 12)
        Me.grpFilters.Name = "grpFilters"
        Me.grpFilters.Size = New System.Drawing.Size(1130, 102)
        Me.grpFilters.TabIndex = 20
        Me.grpFilters.TabStop = False
        Me.grpFilters.Text = "Filtres"
        '
        'btcClose
        '
        Me.btcClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcClose.Location = New System.Drawing.Point(1172, 296)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(107, 23)
        Me.btcClose.TabIndex = 21
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'dgvProjets
        '
        Me.dgvProjets.AllowUserToAddRows = False
        Me.dgvProjets.AllowUserToDeleteRows = False
        Me.dgvProjets.AllowUserToOrderColumns = True
        Me.dgvProjets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProjets.AutoGenerateColumns = False
        Me.dgvProjets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectDataGridViewTextBoxColumn, Me.CEIDStatusDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.CEIDProjectManagerDataGridViewTextBoxColumn, Me.ManagerFirstnameDataGridViewTextBoxColumn, Me.ManagerLastnameDataGridViewTextBoxColumn, Me.CEIDPriorityDataGridViewTextBoxColumn, Me.PriorityDataGridViewTextBoxColumn, Me.CEIDCategoryDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.CEIDCustomerDataGridViewTextBoxColumn, Me.CustomerFirstnameDataGridViewTextBoxColumn, Me.CustomerLastnameDataGridViewTextBoxColumn, Me.CEIDUrgencyDataGridViewTextBoxColumn, Me.UrgencyDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.BeginDateDataGridViewTextBoxColumn, Me.DeadlineDataGridViewTextBoxColumn, Me.EstimatedResourcesDataGridViewTextBoxColumn, Me.ImplementationRateDataGridViewTextBoxColumn, Me.EffectiveResourcesDataGridViewTextBoxColumn})
        Me.dgvProjets.DataSource = Me.VprojectlistBindingSource
        Me.dgvProjets.Location = New System.Drawing.Point(12, 120)
        Me.dgvProjets.Name = "dgvProjets"
        Me.dgvProjets.ReadOnly = True
        Me.dgvProjets.RowHeadersVisible = False
        Me.dgvProjets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjets.Size = New System.Drawing.Size(1130, 540)
        Me.dgvProjets.TabIndex = 22
        '
        'IDProjectDataGridViewTextBoxColumn
        '
        Me.IDProjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.HeaderText = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.Name = "IDProjectDataGridViewTextBoxColumn"
        Me.IDProjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEIDStatusDataGridViewTextBoxColumn
        '
        Me.CEIDStatusDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Status"
        Me.CEIDStatusDataGridViewTextBoxColumn.HeaderText = "CE_ID_Status"
        Me.CEIDStatusDataGridViewTextBoxColumn.Name = "CEIDStatusDataGridViewTextBoxColumn"
        Me.CEIDStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDStatusDataGridViewTextBoxColumn.Visible = False
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEIDProjectManagerDataGridViewTextBoxColumn
        '
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_ProjectManager"
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.HeaderText = "CE_ID_ProjectManager"
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.Name = "CEIDProjectManagerDataGridViewTextBoxColumn"
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDProjectManagerDataGridViewTextBoxColumn.Visible = False
        '
        'ManagerFirstnameDataGridViewTextBoxColumn
        '
        Me.ManagerFirstnameDataGridViewTextBoxColumn.DataPropertyName = "ManagerFirstname"
        Me.ManagerFirstnameDataGridViewTextBoxColumn.HeaderText = "ManagerFirstname"
        Me.ManagerFirstnameDataGridViewTextBoxColumn.Name = "ManagerFirstnameDataGridViewTextBoxColumn"
        Me.ManagerFirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ManagerLastnameDataGridViewTextBoxColumn
        '
        Me.ManagerLastnameDataGridViewTextBoxColumn.DataPropertyName = "ManagerLastname"
        Me.ManagerLastnameDataGridViewTextBoxColumn.HeaderText = "ManagerLastname"
        Me.ManagerLastnameDataGridViewTextBoxColumn.Name = "ManagerLastnameDataGridViewTextBoxColumn"
        Me.ManagerLastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEIDPriorityDataGridViewTextBoxColumn
        '
        Me.CEIDPriorityDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Priority"
        Me.CEIDPriorityDataGridViewTextBoxColumn.HeaderText = "CE_ID_Priority"
        Me.CEIDPriorityDataGridViewTextBoxColumn.Name = "CEIDPriorityDataGridViewTextBoxColumn"
        Me.CEIDPriorityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDPriorityDataGridViewTextBoxColumn.Visible = False
        '
        'PriorityDataGridViewTextBoxColumn
        '
        Me.PriorityDataGridViewTextBoxColumn.DataPropertyName = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.HeaderText = "Priority"
        Me.PriorityDataGridViewTextBoxColumn.Name = "PriorityDataGridViewTextBoxColumn"
        Me.PriorityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEIDCategoryDataGridViewTextBoxColumn
        '
        Me.CEIDCategoryDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Category"
        Me.CEIDCategoryDataGridViewTextBoxColumn.HeaderText = "CE_ID_Category"
        Me.CEIDCategoryDataGridViewTextBoxColumn.Name = "CEIDCategoryDataGridViewTextBoxColumn"
        Me.CEIDCategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDCategoryDataGridViewTextBoxColumn.Visible = False
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEIDCustomerDataGridViewTextBoxColumn
        '
        Me.CEIDCustomerDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Customer"
        Me.CEIDCustomerDataGridViewTextBoxColumn.HeaderText = "CE_ID_Customer"
        Me.CEIDCustomerDataGridViewTextBoxColumn.Name = "CEIDCustomerDataGridViewTextBoxColumn"
        Me.CEIDCustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDCustomerDataGridViewTextBoxColumn.Visible = False
        '
        'CustomerFirstnameDataGridViewTextBoxColumn
        '
        Me.CustomerFirstnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerFirstname"
        Me.CustomerFirstnameDataGridViewTextBoxColumn.HeaderText = "CustomerFirstname"
        Me.CustomerFirstnameDataGridViewTextBoxColumn.Name = "CustomerFirstnameDataGridViewTextBoxColumn"
        Me.CustomerFirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerLastnameDataGridViewTextBoxColumn
        '
        Me.CustomerLastnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastname"
        Me.CustomerLastnameDataGridViewTextBoxColumn.HeaderText = "CustomerLastname"
        Me.CustomerLastnameDataGridViewTextBoxColumn.Name = "CustomerLastnameDataGridViewTextBoxColumn"
        Me.CustomerLastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CEIDUrgencyDataGridViewTextBoxColumn
        '
        Me.CEIDUrgencyDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Urgency"
        Me.CEIDUrgencyDataGridViewTextBoxColumn.HeaderText = "CE_ID_Urgency"
        Me.CEIDUrgencyDataGridViewTextBoxColumn.Name = "CEIDUrgencyDataGridViewTextBoxColumn"
        Me.CEIDUrgencyDataGridViewTextBoxColumn.ReadOnly = True
        Me.CEIDUrgencyDataGridViewTextBoxColumn.Visible = False
        '
        'UrgencyDataGridViewTextBoxColumn
        '
        Me.UrgencyDataGridViewTextBoxColumn.DataPropertyName = "Urgency"
        Me.UrgencyDataGridViewTextBoxColumn.HeaderText = "Urgency"
        Me.UrgencyDataGridViewTextBoxColumn.Name = "UrgencyDataGridViewTextBoxColumn"
        Me.UrgencyDataGridViewTextBoxColumn.ReadOnly = True
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
        '
        'BeginDateDataGridViewTextBoxColumn
        '
        Me.BeginDateDataGridViewTextBoxColumn.DataPropertyName = "BeginDate"
        Me.BeginDateDataGridViewTextBoxColumn.HeaderText = "BeginDate"
        Me.BeginDateDataGridViewTextBoxColumn.Name = "BeginDateDataGridViewTextBoxColumn"
        Me.BeginDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeadlineDataGridViewTextBoxColumn
        '
        Me.DeadlineDataGridViewTextBoxColumn.DataPropertyName = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.HeaderText = "Deadline"
        Me.DeadlineDataGridViewTextBoxColumn.Name = "DeadlineDataGridViewTextBoxColumn"
        Me.DeadlineDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstimatedResourcesDataGridViewTextBoxColumn
        '
        Me.EstimatedResourcesDataGridViewTextBoxColumn.DataPropertyName = "EstimatedResources"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.HeaderText = "EstimatedResources"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.Name = "EstimatedResourcesDataGridViewTextBoxColumn"
        Me.EstimatedResourcesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImplementationRateDataGridViewTextBoxColumn
        '
        Me.ImplementationRateDataGridViewTextBoxColumn.DataPropertyName = "ImplementationRate"
        Me.ImplementationRateDataGridViewTextBoxColumn.HeaderText = "ImplementationRate"
        Me.ImplementationRateDataGridViewTextBoxColumn.Name = "ImplementationRateDataGridViewTextBoxColumn"
        Me.ImplementationRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EffectiveResourcesDataGridViewTextBoxColumn
        '
        Me.EffectiveResourcesDataGridViewTextBoxColumn.DataPropertyName = "EffectiveResources"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.HeaderText = "EffectiveResources"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.Name = "EffectiveResourcesDataGridViewTextBoxColumn"
        Me.EffectiveResourcesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VprojectlistBindingSource
        '
        Me.VprojectlistBindingSource.DataMember = "vprojectlist"
        Me.VprojectlistBindingSource.DataSource = Me.DsProjectsList
        '
        'DsProjectsList
        '
        Me.DsProjectsList.DataSetName = "dsProjectsList"
        Me.DsProjectsList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectlistTableAdapter
        '
        Me.VprojectlistTableAdapter.ClearBeforeFill = True
        '
        'frmProjectsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 681)
        Me.Controls.Add(Me.dgvProjets)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.grpFilters)
        Me.Controls.Add(Me.btcAddProject)
        Me.Controls.Add(Me.btcModifyProject)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectsList"
        Me.Text = "Liste des projets"
        Me.grpFilters.ResumeLayout(False)
        Me.grpFilters.PerformLayout()
        CType(Me.dgvProjets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjectsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkAllProjects As CheckBox
    Friend WithEvents labFilterCategory As Label
    Friend WithEvents labFilterStatus As Label
    Friend WithEvents LabFilterText As Label
    Friend WithEvents labProjectsNumber As Label
    Friend WithEvents lovFilterCategory As ComboBox
    Friend WithEvents lovFilterStatus As ComboBox
    Friend WithEvents btcFilterClear As Button
    Friend WithEvents btcFilter As Button
    Friend WithEvents texFilter As TextBox
    Friend WithEvents btcModifyProject As Button
    Friend WithEvents btcAddProject As Button
    Friend WithEvents grpFilters As GroupBox
    Friend WithEvents btcClose As Button
    Friend WithEvents dgvProjets As DataGridView
    Friend WithEvents IDCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDCategoryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IDStatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DsProjectsList As dsProjectsList
    Friend WithEvents VprojectlistBindingSource As BindingSource
    Friend WithEvents VprojectlistTableAdapter As dsProjectsListTableAdapters.vprojectlistTableAdapter
    Friend WithEvents IDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectManagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerFirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerLastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDPriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDCustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerFirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerLastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDUrgencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrgencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeginDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeadlineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImplementationRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectiveResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
