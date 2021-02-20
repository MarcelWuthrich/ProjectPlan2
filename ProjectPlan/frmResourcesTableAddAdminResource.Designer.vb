<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourcesTableAddAdminResource
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
        Me.dgvAdminResources = New System.Windows.Forms.DataGridView()
        Me.IDAdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymbolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VresourcesadminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsResourcesAdmin = New ProjectPlan.dsResourcesAdmin()
        Me.VresourcesadminTableAdapter = New ProjectPlan.dsResourcesAdminTableAdapters.vresourcesadminTableAdapter()
        CType(Me.dgvAdminResources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VresourcesadminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsResourcesAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAdminResources
        '
        Me.dgvAdminResources.AllowUserToAddRows = False
        Me.dgvAdminResources.AllowUserToDeleteRows = False
        Me.dgvAdminResources.AutoGenerateColumns = False
        Me.dgvAdminResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAdminResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdminResources.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAdminResourceDataGridViewTextBoxColumn, Me.AdminResourceDataGridViewTextBoxColumn, Me.SymbolDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn, Me.DisplayOrderDataGridViewTextBoxColumn})
        Me.dgvAdminResources.DataSource = Me.VresourcesadminBindingSource
        Me.dgvAdminResources.Location = New System.Drawing.Point(37, 44)
        Me.dgvAdminResources.MultiSelect = False
        Me.dgvAdminResources.Name = "dgvAdminResources"
        Me.dgvAdminResources.ReadOnly = True
        Me.dgvAdminResources.RowHeadersVisible = False
        Me.dgvAdminResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdminResources.Size = New System.Drawing.Size(419, 259)
        Me.dgvAdminResources.TabIndex = 0
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
        Me.AdminResourceDataGridViewTextBoxColumn.HeaderText = "AdminResource"
        Me.AdminResourceDataGridViewTextBoxColumn.Name = "AdminResourceDataGridViewTextBoxColumn"
        Me.AdminResourceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SymbolDataGridViewTextBoxColumn
        '
        Me.SymbolDataGridViewTextBoxColumn.DataPropertyName = "Symbol"
        Me.SymbolDataGridViewTextBoxColumn.HeaderText = "Symbol"
        Me.SymbolDataGridViewTextBoxColumn.Name = "SymbolDataGridViewTextBoxColumn"
        Me.SymbolDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EnableDataGridViewTextBoxColumn
        '
        Me.EnableDataGridViewTextBoxColumn.DataPropertyName = "Enable"
        Me.EnableDataGridViewTextBoxColumn.HeaderText = "Enable"
        Me.EnableDataGridViewTextBoxColumn.Name = "EnableDataGridViewTextBoxColumn"
        Me.EnableDataGridViewTextBoxColumn.ReadOnly = True
        Me.EnableDataGridViewTextBoxColumn.Visible = False
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
        Me.VresourcesadminBindingSource.DataSource = Me.DsResourcesAdmin
        '
        'DsResourcesAdmin
        '
        Me.DsResourcesAdmin.DataSetName = "dsResourcesAdmin"
        Me.DsResourcesAdmin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VresourcesadminTableAdapter
        '
        Me.VresourcesadminTableAdapter.ClearBeforeFill = True
        '
        'frmResourcesTableAddAdminResource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 328)
        Me.Controls.Add(Me.dgvAdminResources)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResourcesTableAddAdminResource"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des ressources administratives"
        CType(Me.dgvAdminResources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VresourcesadminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsResourcesAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAdminResources As DataGridView
    Friend WithEvents DsResourcesAdmin As dsResourcesAdmin
    Friend WithEvents VresourcesadminBindingSource As BindingSource
    Friend WithEvents VresourcesadminTableAdapter As dsResourcesAdminTableAdapters.vresourcesadminTableAdapter
    Friend WithEvents IDAdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SymbolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
