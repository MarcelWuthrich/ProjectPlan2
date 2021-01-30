<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatus))
        Me.btcDelete = New System.Windows.Forms.Button()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.btcEdit = New System.Windows.Forms.Button()
        Me.btcAdd = New System.Windows.Forms.Button()
        Me.dgvStatus = New System.Windows.Forms.DataGridView()
        Me.IDStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsStatus = New ProjectPlan.dsStatus()
        Me.VstatusTableAdapter = New ProjectPlan.dsStatusTableAdapters.vstatusTableAdapter()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcDelete
        '
        Me.btcDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btcDelete.Location = New System.Drawing.Point(527, 153)
        Me.btcDelete.Name = "btcDelete"
        Me.btcDelete.Size = New System.Drawing.Size(75, 23)
        Me.btcDelete.TabIndex = 10
        Me.btcDelete.Text = "Supprimer"
        Me.btcDelete.UseVisualStyleBackColor = False
        '
        'btcClose
        '
        Me.btcClose.Location = New System.Drawing.Point(527, 265)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(75, 23)
        Me.btcClose.TabIndex = 9
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'btcEdit
        '
        Me.btcEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btcEdit.Location = New System.Drawing.Point(527, 124)
        Me.btcEdit.Name = "btcEdit"
        Me.btcEdit.Size = New System.Drawing.Size(75, 23)
        Me.btcEdit.TabIndex = 8
        Me.btcEdit.Text = "Modifier"
        Me.btcEdit.UseVisualStyleBackColor = False
        '
        'btcAdd
        '
        Me.btcAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btcAdd.Location = New System.Drawing.Point(527, 95)
        Me.btcAdd.Name = "btcAdd"
        Me.btcAdd.Size = New System.Drawing.Size(75, 23)
        Me.btcAdd.TabIndex = 7
        Me.btcAdd.Text = "Ajouter"
        Me.btcAdd.UseVisualStyleBackColor = False
        '
        'dgvStatus
        '
        Me.dgvStatus.AllowUserToAddRows = False
        Me.dgvStatus.AllowUserToDeleteRows = False
        Me.dgvStatus.AutoGenerateColumns = False
        Me.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDStatusDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn, Me.DisplayOrderDataGridViewTextBoxColumn})
        Me.dgvStatus.DataSource = Me.VstatusBindingSource
        Me.dgvStatus.Location = New System.Drawing.Point(23, 22)
        Me.dgvStatus.Name = "dgvStatus"
        Me.dgvStatus.ReadOnly = True
        Me.dgvStatus.RowHeadersVisible = False
        Me.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStatus.Size = New System.Drawing.Size(463, 266)
        Me.dgvStatus.TabIndex = 6
        '
        'IDStatusDataGridViewTextBoxColumn
        '
        Me.IDStatusDataGridViewTextBoxColumn.DataPropertyName = "ID_Status"
        Me.IDStatusDataGridViewTextBoxColumn.HeaderText = "ID_Status"
        Me.IDStatusDataGridViewTextBoxColumn.Name = "IDStatusDataGridViewTextBoxColumn"
        Me.IDStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
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
        'VstatusBindingSource
        '
        Me.VstatusBindingSource.DataMember = "vstatus"
        Me.VstatusBindingSource.DataSource = Me.DsStatus
        '
        'DsStatus
        '
        Me.DsStatus.DataSetName = "dsStatus"
        Me.DsStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VstatusTableAdapter
        '
        Me.VstatusTableAdapter.ClearBeforeFill = True
        '
        'frmStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 353)
        Me.Controls.Add(Me.btcDelete)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.btcEdit)
        Me.Controls.Add(Me.btcAdd)
        Me.Controls.Add(Me.dgvStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des statuts"
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents btcDelete As Button
    Friend WithEvents btcClose As Button
    Friend WithEvents btcEdit As Button
    Friend WithEvents btcAdd As Button
    Friend WithEvents dgvStatus As DataGridView
    Friend WithEvents DsStatus As dsStatus
    Friend WithEvents VstatusBindingSource As BindingSource
    Friend WithEvents VstatusTableAdapter As dsStatusTableAdapters.vstatusTableAdapter
    Friend WithEvents IDStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
