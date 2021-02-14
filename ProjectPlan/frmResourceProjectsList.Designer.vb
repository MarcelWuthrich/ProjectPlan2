<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourceProjectsList
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
        Me.dgvProjectsList = New System.Windows.Forms.DataGridView()
        Me.VprojectlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsResourceProjectsList = New ProjectPlan.dsResourceProjectsList()
        Me.VprojectlistTableAdapter = New ProjectPlan.dsResourceProjectsListTableAdapters.vprojectlistTableAdapter()
        Me.IDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeginDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeadlineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImplementationRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectiveResourcesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProjectsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsResourceProjectsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProjectsList
        '
        Me.dgvProjectsList.AllowUserToAddRows = False
        Me.dgvProjectsList.AllowUserToDeleteRows = False
        Me.dgvProjectsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProjectsList.AutoGenerateColumns = False
        Me.dgvProjectsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.CEIDStatusDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.CEIDProjectManagerDataGridViewTextBoxColumn, Me.ManagerFirstnameDataGridViewTextBoxColumn, Me.ManagerLastnameDataGridViewTextBoxColumn, Me.CEIDPriorityDataGridViewTextBoxColumn, Me.PriorityDataGridViewTextBoxColumn, Me.CEIDCategoryDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.CEIDCustomerDataGridViewTextBoxColumn, Me.CustomerFirstnameDataGridViewTextBoxColumn, Me.CustomerLastnameDataGridViewTextBoxColumn, Me.CEIDUrgencyDataGridViewTextBoxColumn, Me.UrgencyDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.BeginDateDataGridViewTextBoxColumn, Me.DeadlineDataGridViewTextBoxColumn, Me.EstimatedResourcesDataGridViewTextBoxColumn, Me.ImplementationRateDataGridViewTextBoxColumn, Me.EffectiveResourcesDataGridViewTextBoxColumn})
        Me.dgvProjectsList.DataSource = Me.VprojectlistBindingSource
        Me.dgvProjectsList.Location = New System.Drawing.Point(24, 31)
        Me.dgvProjectsList.Name = "dgvProjectsList"
        Me.dgvProjectsList.ReadOnly = True
        Me.dgvProjectsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectsList.Size = New System.Drawing.Size(861, 284)
        Me.dgvProjectsList.TabIndex = 0
        '
        'VprojectlistBindingSource
        '
        Me.VprojectlistBindingSource.DataMember = "vprojectlist"
        Me.VprojectlistBindingSource.DataSource = Me.DsResourceProjectsList
        '
        'DsResourceProjectsList
        '
        Me.DsResourceProjectsList.DataSetName = "dsResourceProjectsList"
        Me.DsResourceProjectsList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectlistTableAdapter
        '
        Me.VprojectlistTableAdapter.ClearBeforeFill = True
        '
        'IDProjectDataGridViewTextBoxColumn
        '
        Me.IDProjectDataGridViewTextBoxColumn.DataPropertyName = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.HeaderText = "ID_Project"
        Me.IDProjectDataGridViewTextBoxColumn.Name = "IDProjectDataGridViewTextBoxColumn"
        Me.IDProjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDProjectDataGridViewTextBoxColumn.Visible = False
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ManagerFirstnameDataGridViewTextBoxColumn.Visible = False
        '
        'ManagerLastnameDataGridViewTextBoxColumn
        '
        Me.ManagerLastnameDataGridViewTextBoxColumn.DataPropertyName = "ManagerLastname"
        Me.ManagerLastnameDataGridViewTextBoxColumn.HeaderText = "ManagerLastname"
        Me.ManagerLastnameDataGridViewTextBoxColumn.Name = "ManagerLastnameDataGridViewTextBoxColumn"
        Me.ManagerLastnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ManagerLastnameDataGridViewTextBoxColumn.Visible = False
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
        Me.PriorityDataGridViewTextBoxColumn.Visible = False
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
        Me.CategoryDataGridViewTextBoxColumn.Visible = False
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
        Me.CustomerFirstnameDataGridViewTextBoxColumn.Visible = False
        '
        'CustomerLastnameDataGridViewTextBoxColumn
        '
        Me.CustomerLastnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerLastname"
        Me.CustomerLastnameDataGridViewTextBoxColumn.HeaderText = "CustomerLastname"
        Me.CustomerLastnameDataGridViewTextBoxColumn.Name = "CustomerLastnameDataGridViewTextBoxColumn"
        Me.CustomerLastnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerLastnameDataGridViewTextBoxColumn.Visible = False
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
        Me.UrgencyDataGridViewTextBoxColumn.Visible = False
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
        'frmResourceProjectsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 338)
        Me.Controls.Add(Me.dgvProjectsList)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResourceProjectsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des projets"
        CType(Me.dgvProjectsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsResourceProjectsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvProjectsList As DataGridView
    Friend WithEvents DsResourceProjectsList As dsResourceProjectsList
    Friend WithEvents VprojectlistBindingSource As BindingSource
    Friend WithEvents VprojectlistTableAdapter As dsResourceProjectsListTableAdapters.vprojectlistTableAdapter
    Friend WithEvents IDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BeginDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeadlineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImplementationRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EffectiveResourcesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
