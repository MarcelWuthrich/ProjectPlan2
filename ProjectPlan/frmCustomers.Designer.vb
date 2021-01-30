<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Me.btcDelete = New System.Windows.Forms.Button()
        Me.btcClose = New System.Windows.Forms.Button()
        Me.btcEdit = New System.Windows.Forms.Button()
        Me.btcAdd = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.IDCustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VcustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCustomers = New ProjectPlan.dsCustomers()
        Me.VcustomersTableAdapter = New ProjectPlan.dsCustomersTableAdapters.vcustomersTableAdapter()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VcustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcDelete
        '
        Me.btcDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btcDelete.Location = New System.Drawing.Point(678, 156)
        Me.btcDelete.Name = "btcDelete"
        Me.btcDelete.Size = New System.Drawing.Size(75, 23)
        Me.btcDelete.TabIndex = 10
        Me.btcDelete.Text = "Supprimer"
        Me.btcDelete.UseVisualStyleBackColor = False
        '
        'btcClose
        '
        Me.btcClose.Location = New System.Drawing.Point(678, 268)
        Me.btcClose.Name = "btcClose"
        Me.btcClose.Size = New System.Drawing.Size(75, 23)
        Me.btcClose.TabIndex = 9
        Me.btcClose.Text = "Fermer"
        Me.btcClose.UseVisualStyleBackColor = True
        '
        'btcEdit
        '
        Me.btcEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btcEdit.Location = New System.Drawing.Point(678, 127)
        Me.btcEdit.Name = "btcEdit"
        Me.btcEdit.Size = New System.Drawing.Size(75, 23)
        Me.btcEdit.TabIndex = 8
        Me.btcEdit.Text = "Modifier"
        Me.btcEdit.UseVisualStyleBackColor = False
        '
        'btcAdd
        '
        Me.btcAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btcAdd.Location = New System.Drawing.Point(678, 98)
        Me.btcAdd.Name = "btcAdd"
        Me.btcAdd.Size = New System.Drawing.Size(75, 23)
        Me.btcAdd.TabIndex = 7
        Me.btcAdd.Text = "Ajouter"
        Me.btcAdd.UseVisualStyleBackColor = False
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AutoGenerateColumns = False
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCustomerDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.CompanyNameDataGridViewTextBoxColumn, Me.CompanyLocationDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn, Me.DisplayOrderDataGridViewTextBoxColumn})
        Me.dgvCustomers.DataSource = Me.VcustomersBindingSource
        Me.dgvCustomers.Location = New System.Drawing.Point(25, 27)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(617, 266)
        Me.dgvCustomers.TabIndex = 6
        '
        'IDCustomerDataGridViewTextBoxColumn
        '
        Me.IDCustomerDataGridViewTextBoxColumn.DataPropertyName = "ID_Customer"
        Me.IDCustomerDataGridViewTextBoxColumn.HeaderText = "ID_Customer"
        Me.IDCustomerDataGridViewTextBoxColumn.Name = "IDCustomerDataGridViewTextBoxColumn"
        Me.IDCustomerDataGridViewTextBoxColumn.ReadOnly = True
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
        'CompanyNameDataGridViewTextBoxColumn
        '
        Me.CompanyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName"
        Me.CompanyNameDataGridViewTextBoxColumn.Name = "CompanyNameDataGridViewTextBoxColumn"
        Me.CompanyNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompanyLocationDataGridViewTextBoxColumn
        '
        Me.CompanyLocationDataGridViewTextBoxColumn.DataPropertyName = "CompanyLocation"
        Me.CompanyLocationDataGridViewTextBoxColumn.HeaderText = "CompanyLocation"
        Me.CompanyLocationDataGridViewTextBoxColumn.Name = "CompanyLocationDataGridViewTextBoxColumn"
        Me.CompanyLocationDataGridViewTextBoxColumn.ReadOnly = True
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
        'VcustomersBindingSource
        '
        Me.VcustomersBindingSource.DataMember = "vcustomers"
        Me.VcustomersBindingSource.DataSource = Me.DsCustomers
        '
        'DsCustomers
        '
        Me.DsCustomers.DataSetName = "dsCustomers"
        Me.DsCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VcustomersTableAdapter
        '
        Me.VcustomersTableAdapter.ClearBeforeFill = True
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btcDelete)
        Me.Controls.Add(Me.btcClose)
        Me.Controls.Add(Me.btcEdit)
        Me.Controls.Add(Me.btcAdd)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des commanditaires"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VcustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Protected Friend WithEvents btcDelete As Button
    Friend WithEvents btcClose As Button
    Friend WithEvents btcEdit As Button
    Friend WithEvents btcAdd As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents DsCustomers As dsCustomers
    Friend WithEvents VcustomersBindingSource As BindingSource
    Friend WithEvents VcustomersTableAdapter As dsCustomersTableAdapters.vcustomersTableAdapter
    Friend WithEvents IDCustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompanyLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
