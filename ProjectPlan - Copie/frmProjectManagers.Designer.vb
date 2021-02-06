<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectManagers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectManagers))
        Me.btcDelete = New System.Windows.Forms.Button()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.btcEdit = New System.Windows.Forms.Button()
        Me.btcAdd = New System.Windows.Forms.Button()
        Me.dgvProjectsManagers = New System.Windows.Forms.DataGridView()
        Me.IDProjectManagerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VprojectmanagersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProjectManagers = New ProjectPlan.dsProjectManagers()
        Me.VprojectmanagersTableAdapter = New ProjectPlan.dsProjectManagersTableAdapters.vprojectmanagersTableAdapter()
        CType(Me.dgvProjectsManagers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectmanagersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjectManagers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcDelete
        '
        Me.btcDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btcDelete.Location = New System.Drawing.Point(525, 154)
        Me.btcDelete.Name = "btcDelete"
        Me.btcDelete.Size = New System.Drawing.Size(75, 23)
        Me.btcDelete.TabIndex = 10
        Me.btcDelete.Text = "Supprimer"
        Me.btcDelete.UseVisualStyleBackColor = False
        '
        'btcClose
        '
        Me.btcClose.Location = New System.Drawing.Point(525, 266)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(75, 23)
        Me.btcClose.TabIndex = 9
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'btcEdit
        '
        Me.btcEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btcEdit.Location = New System.Drawing.Point(525, 125)
        Me.btcEdit.Name = "btcEdit"
        Me.btcEdit.Size = New System.Drawing.Size(75, 23)
        Me.btcEdit.TabIndex = 8
        Me.btcEdit.Text = "Modifier"
        Me.btcEdit.UseVisualStyleBackColor = False
        '
        'btcAdd
        '
        Me.btcAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btcAdd.Location = New System.Drawing.Point(525, 96)
        Me.btcAdd.Name = "btcAdd"
        Me.btcAdd.Size = New System.Drawing.Size(75, 23)
        Me.btcAdd.TabIndex = 7
        Me.btcAdd.Text = "Ajouter"
        Me.btcAdd.UseVisualStyleBackColor = False
        '
        'dgvProjectsManagers
        '
        Me.dgvProjectsManagers.AllowUserToAddRows = False
        Me.dgvProjectsManagers.AllowUserToDeleteRows = False
        Me.dgvProjectsManagers.AutoGenerateColumns = False
        Me.dgvProjectsManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectsManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectsManagers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProjectManagerDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn})
        Me.dgvProjectsManagers.DataSource = Me.VprojectmanagersBindingSource
        Me.dgvProjectsManagers.Location = New System.Drawing.Point(21, 23)
        Me.dgvProjectsManagers.MultiSelect = False
        Me.dgvProjectsManagers.Name = "dgvProjectsManagers"
        Me.dgvProjectsManagers.ReadOnly = True
        Me.dgvProjectsManagers.RowHeadersVisible = False
        Me.dgvProjectsManagers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjectsManagers.Size = New System.Drawing.Size(463, 266)
        Me.dgvProjectsManagers.TabIndex = 6
        '
        'IDProjectManagerDataGridViewTextBoxColumn
        '
        Me.IDProjectManagerDataGridViewTextBoxColumn.DataPropertyName = "ID_ProjectManager"
        Me.IDProjectManagerDataGridViewTextBoxColumn.HeaderText = "ID_ProjectManager"
        Me.IDProjectManagerDataGridViewTextBoxColumn.Name = "IDProjectManagerDataGridViewTextBoxColumn"
        Me.IDProjectManagerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EnableDataGridViewTextBoxColumn
        '
        Me.EnableDataGridViewTextBoxColumn.DataPropertyName = "Enable"
        Me.EnableDataGridViewTextBoxColumn.HeaderText = "Enable"
        Me.EnableDataGridViewTextBoxColumn.Name = "EnableDataGridViewTextBoxColumn"
        Me.EnableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VprojectmanagersBindingSource
        '
        Me.VprojectmanagersBindingSource.DataMember = "vprojectmanagers"
        Me.VprojectmanagersBindingSource.DataSource = Me.DsProjectManagers
        '
        'DsProjectManagers
        '
        Me.DsProjectManagers.DataSetName = "dsProjectManagers"
        Me.DsProjectManagers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectmanagersTableAdapter
        '
        Me.VprojectmanagersTableAdapter.ClearBeforeFill = True
        '
        'frmProjectManagers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 324)
        Me.Controls.Add(Me.btcDelete)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.btcEdit)
        Me.Controls.Add(Me.btcAdd)
        Me.Controls.Add(Me.dgvProjectsManagers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectManagers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chefs de projets"
        CType(Me.dgvProjectsManagers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectmanagersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjectManagers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents btcDelete As Button
    Friend WithEvents btcClose As Button
    Friend WithEvents btcEdit As Button
    Friend WithEvents btcAdd As Button
    Friend WithEvents dgvProjectsManagers As DataGridView
    Friend WithEvents DsProjectManagers As dsProjectManagers
    Friend WithEvents VprojectmanagersBindingSource As BindingSource
    Friend WithEvents VprojectmanagersTableAdapter As dsProjectManagersTableAdapters.vprojectmanagersTableAdapter
    Friend WithEvents IDProjectManagerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
