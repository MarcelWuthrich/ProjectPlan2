<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourceAdminList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResourceAdminList))
        Me.dgvAdminResources = New System.Windows.Forms.DataGridView()
        Me.IDAdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymbolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VresourcesadminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsResourcesAdmin = New ProjectPlan.dsResourcesAdmin()
        Me.VresourcesadminTableAdapter = New ProjectPlan.dsResourcesAdminTableAdapters.vresourcesadminTableAdapter()
        Me.btcDelete = New System.Windows.Forms.Button()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.btcEdit = New System.Windows.Forms.Button()
        Me.btcAdd = New System.Windows.Forms.Button()
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
        '
        'DisplayOrderDataGridViewTextBoxColumn
        '
        Me.DisplayOrderDataGridViewTextBoxColumn.DataPropertyName = "DisplayOrder"
        Me.DisplayOrderDataGridViewTextBoxColumn.HeaderText = "DisplayOrder"
        Me.DisplayOrderDataGridViewTextBoxColumn.Name = "DisplayOrderDataGridViewTextBoxColumn"
        Me.DisplayOrderDataGridViewTextBoxColumn.ReadOnly = True
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
        'btcDelete
        '
        Me.btcDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btcDelete.Location = New System.Drawing.Point(495, 168)
        Me.btcDelete.Name = "btcDelete"
        Me.btcDelete.Size = New System.Drawing.Size(75, 23)
        Me.btcDelete.TabIndex = 14
        Me.btcDelete.Text = "Supprimer"
        Me.btcDelete.UseVisualStyleBackColor = False
        '
        'btcClose
        '
        Me.btcClose.Location = New System.Drawing.Point(495, 280)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(75, 23)
        Me.btcClose.TabIndex = 13
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'btcEdit
        '
        Me.btcEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btcEdit.Location = New System.Drawing.Point(495, 139)
        Me.btcEdit.Name = "btcEdit"
        Me.btcEdit.Size = New System.Drawing.Size(75, 23)
        Me.btcEdit.TabIndex = 12
        Me.btcEdit.Text = "Modifier"
        Me.btcEdit.UseVisualStyleBackColor = False
        '
        'btcAdd
        '
        Me.btcAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btcAdd.Location = New System.Drawing.Point(495, 110)
        Me.btcAdd.Name = "btcAdd"
        Me.btcAdd.Size = New System.Drawing.Size(75, 23)
        Me.btcAdd.TabIndex = 11
        Me.btcAdd.Text = "Ajouter"
        Me.btcAdd.UseVisualStyleBackColor = False
        '
        'frmResourceAdminList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 328)
        Me.Controls.Add(Me.btcDelete)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.btcEdit)
        Me.Controls.Add(Me.btcAdd)
        Me.Controls.Add(Me.dgvAdminResources)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResourceAdminList"
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
    Protected Friend WithEvents btcDelete As Button
    Friend WithEvents btcClose As Button
    Friend WithEvents btcEdit As Button
    Friend WithEvents btcAdd As Button
End Class
