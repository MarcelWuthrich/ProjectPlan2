<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProjectplanDataSet1 = New ProjectPlan.projectplanDataSet1()
        Me.VstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VstatusTableAdapter = New ProjectPlan.projectplanDataSet1TableAdapters.vstatusTableAdapter()
        Me.IDStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DisplayOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectplanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDStatusDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.EnableDataGridViewTextBoxColumn, Me.DisplayOrderDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VstatusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(64, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(683, 350)
        Me.DataGridView1.TabIndex = 0
        '
        'ProjectplanDataSet1
        '
        Me.ProjectplanDataSet1.DataSetName = "projectplanDataSet1"
        Me.ProjectplanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VstatusBindingSource
        '
        Me.VstatusBindingSource.DataMember = "vstatus"
        Me.VstatusBindingSource.DataSource = Me.ProjectplanDataSet1
        '
        'VstatusTableAdapter
        '
        Me.VstatusTableAdapter.ClearBeforeFill = True
        '
        'IDStatusDataGridViewTextBoxColumn
        '
        Me.IDStatusDataGridViewTextBoxColumn.DataPropertyName = "ID_Status"
        Me.IDStatusDataGridViewTextBoxColumn.HeaderText = "ID_Status"
        Me.IDStatusDataGridViewTextBoxColumn.Name = "IDStatusDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
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
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTest"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectplanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectplanDataSet1 As projectplanDataSet1
    Friend WithEvents VstatusBindingSource As BindingSource
    Friend WithEvents VstatusTableAdapter As projectplanDataSet1TableAdapters.vstatusTableAdapter
    Friend WithEvents IDStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DisplayOrderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
