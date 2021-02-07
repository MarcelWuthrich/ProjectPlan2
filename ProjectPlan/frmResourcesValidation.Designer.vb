<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResourcesValidation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResourcesValidation))
        Me.btcValidate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpResources = New System.Windows.Forms.GroupBox()
        Me.chkSelection = New System.Windows.Forms.CheckBox()
        Me.dptDateTo = New System.Windows.Forms.DateTimePicker()
        Me.chkDateTo = New System.Windows.Forms.CheckBox()
        Me.dgvPlanResources = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VplanresourcetodayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsVResourceToday = New ProjectPlan.dsVResourceToday()
        Me.btcFermer = New System.Windows.Forms.Button()
        Me.VplanresourcetodayTableAdapter = New ProjectPlan.dsVResourceTodayTableAdapters.vplanresourcetodayTableAdapter()
        Me.grpResources.SuspendLayout()
        CType(Me.dgvPlanResources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VplanresourcetodayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVResourceToday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcValidate
        '
        Me.btcValidate.Location = New System.Drawing.Point(707, 28)
        Me.btcValidate.Name = "btcValidate"
        Me.btcValidate.Size = New System.Drawing.Size(75, 23)
        Me.btcValidate.TabIndex = 6
        Me.btcValidate.Text = "Valider"
        Me.btcValidate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Valider toutes les ressources"
        '
        'grpResources
        '
        Me.grpResources.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpResources.Controls.Add(Me.chkSelection)
        Me.grpResources.Controls.Add(Me.dptDateTo)
        Me.grpResources.Controls.Add(Me.chkDateTo)
        Me.grpResources.Controls.Add(Me.btcValidate)
        Me.grpResources.Controls.Add(Me.Label3)
        Me.grpResources.Controls.Add(Me.dgvPlanResources)
        Me.grpResources.Location = New System.Drawing.Point(32, 31)
        Me.grpResources.Name = "grpResources"
        Me.grpResources.Size = New System.Drawing.Size(919, 366)
        Me.grpResources.TabIndex = 15
        Me.grpResources.TabStop = False
        Me.grpResources.Text = "Ressources"
        '
        'chkSelection
        '
        Me.chkSelection.AutoSize = True
        Me.chkSelection.Checked = True
        Me.chkSelection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSelection.Location = New System.Drawing.Point(508, 27)
        Me.chkSelection.Name = "chkSelection"
        Me.chkSelection.Size = New System.Drawing.Size(139, 17)
        Me.chkSelection.TabIndex = 19
        Me.chkSelection.Text = "Uniquement la sélection"
        Me.chkSelection.UseVisualStyleBackColor = True
        '
        'dptDateTo
        '
        Me.dptDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptDateTo.Location = New System.Drawing.Point(315, 25)
        Me.dptDateTo.Name = "dptDateTo"
        Me.dptDateTo.Size = New System.Drawing.Size(143, 20)
        Me.dptDateTo.TabIndex = 10
        '
        'chkDateTo
        '
        Me.chkDateTo.AutoSize = True
        Me.chkDateTo.Checked = True
        Me.chkDateTo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDateTo.Location = New System.Drawing.Point(181, 27)
        Me.chkDateTo.Name = "chkDateTo"
        Me.chkDateTo.Size = New System.Drawing.Size(125, 17)
        Me.chkDateTo.TabIndex = 9
        Me.chkDateTo.Text = "Uniquement jusqu'au"
        Me.chkDateTo.UseVisualStyleBackColor = True
        '
        'dgvPlanResources
        '
        Me.dgvPlanResources.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlanResources.AutoGenerateColumns = False
        Me.dgvPlanResources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlanResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanResources.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgvPlanResources.DataSource = Me.VplanresourcetodayBindingSource
        Me.dgvPlanResources.Location = New System.Drawing.Point(9, 75)
        Me.dgvPlanResources.Name = "dgvPlanResources"
        Me.dgvPlanResources.ReadOnly = True
        Me.dgvPlanResources.RowHeadersVisible = False
        Me.dgvPlanResources.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlanResources.Size = New System.Drawing.Size(893, 273)
        Me.dgvPlanResources.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Resource"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Resource"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PlanDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Hour"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Heure"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prénom"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "AdminResource"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ressource adminsitrative"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Projet"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'VplanresourcetodayBindingSource
        '
        Me.VplanresourcetodayBindingSource.DataMember = "vplanresourcetoday"
        Me.VplanresourcetodayBindingSource.DataSource = Me.DsVResourceToday
        '
        'DsVResourceToday
        '
        Me.DsVResourceToday.DataSetName = "dsVResourceToday"
        Me.DsVResourceToday.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btcFermer
        '
        Me.btcFermer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btcFermer.Location = New System.Drawing.Point(980, 58)
        Me.btcFermer.Name = "btcFermer"
        Me.btcFermer.Size = New System.Drawing.Size(75, 23)
        Me.btcFermer.TabIndex = 16
        Me.btcFermer.Text = "Fermer"
        Me.btcFermer.UseVisualStyleBackColor = True
        '
        'VplanresourcetodayTableAdapter
        '
        Me.VplanresourcetodayTableAdapter.ClearBeforeFill = True
        '
        'frmResourcesValidation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 521)
        Me.Controls.Add(Me.btcFermer)
        Me.Controls.Add(Me.grpResources)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResourcesValidation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validation des ressources"
        Me.grpResources.ResumeLayout(False)
        Me.grpResources.PerformLayout()
        CType(Me.dgvPlanResources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VplanresourcetodayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsVResourceToday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btcValidate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents grpResources As GroupBox
    Friend WithEvents dptDateTo As DateTimePicker
    Friend WithEvents chkDateTo As CheckBox
    Friend WithEvents btcFermer As Button
    Friend WithEvents dgvPlanResources As DataGridView
    Friend WithEvents IDResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlanDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DsVResourceToday As dsVResourceToday
    Friend WithEvents VplanresourcetodayBindingSource As BindingSource
    Friend WithEvents VplanresourcetodayTableAdapter As dsVResourceTodayTableAdapters.vplanresourcetodayTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents chkSelection As CheckBox
End Class
