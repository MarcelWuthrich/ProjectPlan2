<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTasks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTasks))
        Me.btcDelete = New System.Windows.Forms.Button()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.btcEdit = New System.Windows.Forms.Button()
        Me.btcAdd = New System.Windows.Forms.Button()
        Me.dgvTasks = New System.Windows.Forms.DataGridView()
        Me.IDTaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VtasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTasks = New ProjectPlan.dsTasks()
        Me.VtasksTableAdapter = New ProjectPlan.dsTasksTableAdapters.vtasksTableAdapter()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VtasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcDelete
        '
        Me.btcDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btcDelete.Location = New System.Drawing.Point(516, 156)
        Me.btcDelete.Name = "btcDelete"
        Me.btcDelete.Size = New System.Drawing.Size(75, 23)
        Me.btcDelete.TabIndex = 10
        Me.btcDelete.Text = "Supprimer"
        Me.btcDelete.UseVisualStyleBackColor = False
        '
        'btcClose
        '
        Me.btcClose.Location = New System.Drawing.Point(516, 268)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(75, 23)
        Me.btcClose.TabIndex = 9
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'btcEdit
        '
        Me.btcEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btcEdit.Location = New System.Drawing.Point(516, 127)
        Me.btcEdit.Name = "btcEdit"
        Me.btcEdit.Size = New System.Drawing.Size(75, 23)
        Me.btcEdit.TabIndex = 8
        Me.btcEdit.Text = "Modifier"
        Me.btcEdit.UseVisualStyleBackColor = False
        '
        'btcAdd
        '
        Me.btcAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btcAdd.Location = New System.Drawing.Point(516, 98)
        Me.btcAdd.Name = "btcAdd"
        Me.btcAdd.Size = New System.Drawing.Size(75, 23)
        Me.btcAdd.TabIndex = 7
        Me.btcAdd.Text = "Ajouter"
        Me.btcAdd.UseVisualStyleBackColor = False
        '
        'dgvTasks
        '
        Me.dgvTasks.AllowUserToAddRows = False
        Me.dgvTasks.AllowUserToDeleteRows = False
        Me.dgvTasks.AutoGenerateColumns = False
        Me.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDTaskDataGridViewTextBoxColumn, Me.TaskDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn, Me.DisplayOrderDataGridViewTextBoxColumn})
        Me.dgvTasks.DataSource = Me.VtasksBindingSource
        Me.dgvTasks.Location = New System.Drawing.Point(12, 25)
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.RowHeadersVisible = False
        Me.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTasks.Size = New System.Drawing.Size(463, 266)
        Me.dgvTasks.TabIndex = 6
        '
        'IDTaskDataGridViewTextBoxColumn
        '
        Me.IDTaskDataGridViewTextBoxColumn.DataPropertyName = "ID_Task"
        Me.IDTaskDataGridViewTextBoxColumn.HeaderText = "ID_Task"
        Me.IDTaskDataGridViewTextBoxColumn.Name = "IDTaskDataGridViewTextBoxColumn"
        '
        'TaskDataGridViewTextBoxColumn
        '
        Me.TaskDataGridViewTextBoxColumn.DataPropertyName = "Task"
        Me.TaskDataGridViewTextBoxColumn.HeaderText = "Task"
        Me.TaskDataGridViewTextBoxColumn.Name = "TaskDataGridViewTextBoxColumn"
        '
        'EnableDataGridViewTextBoxColumn
        '
        Me.EnableDataGridViewTextBoxColumn.DataPropertyName = "Enable"
        Me.EnableDataGridViewTextBoxColumn.HeaderText = "Enable"
        Me.EnableDataGridViewTextBoxColumn.Name = "EnableDataGridViewTextBoxColumn"
        '
        'DisplayOrderDataGridViewTextBoxColumn
        '
        Me.DisplayOrderDataGridViewTextBoxColumn.DataPropertyName = "DisplayOrder"
        Me.DisplayOrderDataGridViewTextBoxColumn.HeaderText = "DisplayOrder"
        Me.DisplayOrderDataGridViewTextBoxColumn.Name = "DisplayOrderDataGridViewTextBoxColumn"
        '
        'VtasksBindingSource
        '
        Me.VtasksBindingSource.DataMember = "vtasks"
        Me.VtasksBindingSource.DataSource = Me.DsTasks
        '
        'DsTasks
        '
        Me.DsTasks.DataSetName = "dsTasks"
        Me.DsTasks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VtasksTableAdapter
        '
        Me.VtasksTableAdapter.ClearBeforeFill = True
        '
        'frmTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 344)
        Me.Controls.Add(Me.btcDelete)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.btcEdit)
        Me.Controls.Add(Me.btcAdd)
        Me.Controls.Add(Me.dgvTasks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Domaines d'activités"
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VtasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents btcDelete As Button
    Friend WithEvents btcClose As Button
    Friend WithEvents btcEdit As Button
    Friend WithEvents btcAdd As Button
    Friend WithEvents dgvTasks As DataGridView
    Friend WithEvents DsTasks As dsTasks
    Friend WithEvents VtasksBindingSource As BindingSource
    Friend WithEvents VtasksTableAdapter As dsTasksTableAdapters.vtasksTableAdapter
    Friend WithEvents IDTaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
