﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.dptDateTo = New System.Windows.Forms.DateTimePicker()
        Me.chkDateTo = New System.Windows.Forms.CheckBox()
        Me.dgvPlanResources = New System.Windows.Forms.DataGridView()
        Me.btcFermer = New System.Windows.Forms.Button()
        Me.DsVPlanResourceToday = New ProjectPlan.dsVPlanResourceToday()
        Me.VplanresourcetodayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VplanresourcetodayTableAdapter = New ProjectPlan.dsVPlanResourceTodayTableAdapters.vplanresourcetodayTableAdapter()
        Me.IDResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdminResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpResources.SuspendLayout()
        CType(Me.dgvPlanResources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsVPlanResourceToday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VplanresourcetodayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btcValidate
        '
        Me.btcValidate.Location = New System.Drawing.Point(522, 23)
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
        Me.grpResources.Controls.Add(Me.dptDateTo)
        Me.grpResources.Controls.Add(Me.chkDateTo)
        Me.grpResources.Controls.Add(Me.btcValidate)
        Me.grpResources.Controls.Add(Me.Label3)
        Me.grpResources.Controls.Add(Me.dgvPlanResources)
        Me.grpResources.Location = New System.Drawing.Point(32, 31)
        Me.grpResources.Name = "grpResources"
        Me.grpResources.Size = New System.Drawing.Size(626, 366)
        Me.grpResources.TabIndex = 15
        Me.grpResources.TabStop = False
        Me.grpResources.Text = "Ressources"
        '
        'dptDateTo
        '
        Me.dptDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dptDateTo.Location = New System.Drawing.Point(323, 22)
        Me.dptDateTo.Name = "dptDateTo"
        Me.dptDateTo.Size = New System.Drawing.Size(143, 20)
        Me.dptDateTo.TabIndex = 10
        '
        'chkDateTo
        '
        Me.chkDateTo.AutoSize = True
        Me.chkDateTo.Location = New System.Drawing.Point(183, 27)
        Me.chkDateTo.Name = "chkDateTo"
        Me.chkDateTo.Size = New System.Drawing.Size(125, 17)
        Me.chkDateTo.TabIndex = 9
        Me.chkDateTo.Text = "Uniquement jusqu'au"
        Me.chkDateTo.UseVisualStyleBackColor = True
        '
        'dgvPlanResources
        '
        Me.dgvPlanResources.AutoGenerateColumns = False
        Me.dgvPlanResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlanResources.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDResourceDataGridViewTextBoxColumn, Me.PlanDateDataGridViewTextBoxColumn, Me.HourDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AdminResourceDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn})
        Me.dgvPlanResources.DataSource = Me.VplanresourcetodayBindingSource
        Me.dgvPlanResources.Location = New System.Drawing.Point(9, 75)
        Me.dgvPlanResources.Name = "dgvPlanResources"
        Me.dgvPlanResources.Size = New System.Drawing.Size(588, 264)
        Me.dgvPlanResources.TabIndex = 17
        '
        'btcFermer
        '
        Me.btcFermer.Location = New System.Drawing.Point(808, 106)
        Me.btcFermer.Name = "btcFermer"
        Me.btcFermer.Size = New System.Drawing.Size(75, 23)
        Me.btcFermer.TabIndex = 16
        Me.btcFermer.Text = "Fermer"
        Me.btcFermer.UseVisualStyleBackColor = True
        '
        'DsVPlanResourceToday
        '
        Me.DsVPlanResourceToday.DataSetName = "dsVPlanResourceToday"
        Me.DsVPlanResourceToday.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VplanresourcetodayBindingSource
        '
        Me.VplanresourcetodayBindingSource.DataMember = "vplanresourcetoday"
        Me.VplanresourcetodayBindingSource.DataSource = Me.DsVPlanResourceToday
        '
        'VplanresourcetodayTableAdapter
        '
        Me.VplanresourcetodayTableAdapter.ClearBeforeFill = True
        '
        'IDResourceDataGridViewTextBoxColumn
        '
        Me.IDResourceDataGridViewTextBoxColumn.DataPropertyName = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn.HeaderText = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn.Name = "IDResourceDataGridViewTextBoxColumn"
        '
        'PlanDateDataGridViewTextBoxColumn
        '
        Me.PlanDateDataGridViewTextBoxColumn.DataPropertyName = "PlanDate"
        Me.PlanDateDataGridViewTextBoxColumn.HeaderText = "PlanDate"
        Me.PlanDateDataGridViewTextBoxColumn.Name = "PlanDateDataGridViewTextBoxColumn"
        '
        'HourDataGridViewTextBoxColumn
        '
        Me.HourDataGridViewTextBoxColumn.DataPropertyName = "Hour"
        Me.HourDataGridViewTextBoxColumn.HeaderText = "Hour"
        Me.HourDataGridViewTextBoxColumn.Name = "HourDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AdminResourceDataGridViewTextBoxColumn
        '
        Me.AdminResourceDataGridViewTextBoxColumn.DataPropertyName = "AdminResource"
        Me.AdminResourceDataGridViewTextBoxColumn.HeaderText = "AdminResource"
        Me.AdminResourceDataGridViewTextBoxColumn.Name = "AdminResourceDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
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
        CType(Me.DsVPlanResourceToday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VplanresourcetodayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btcValidate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents grpResources As GroupBox
    Friend WithEvents dptDateTo As DateTimePicker
    Friend WithEvents chkDateTo As CheckBox
    Friend WithEvents btcFermer As Button
    Friend WithEvents dgvPlanResources As DataGridView
    Friend WithEvents DsVPlanResourceToday As dsVPlanResourceToday
    Friend WithEvents VplanresourcetodayBindingSource As BindingSource
    Friend WithEvents VplanresourcetodayTableAdapter As dsVPlanResourceTodayTableAdapters.vplanresourcetodayTableAdapter
    Friend WithEvents IDResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlanDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdminResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class