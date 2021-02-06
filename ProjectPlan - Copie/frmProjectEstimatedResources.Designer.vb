<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectEstimatedResources
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectEstimatedResources))
        Me.labID_Project = New System.Windows.Forms.Label()
        Me.texID_Project = New System.Windows.Forms.TextBox()
        Me.texProjectTitle = New System.Windows.Forms.TextBox()
        Me.labProjectTitle = New System.Windows.Forms.Label()
        Me.lovTasks = New System.Windows.Forms.ComboBox()
        Me.labTaches = New System.Windows.Forms.Label()
        Me.texEstimatRedesource = New System.Windows.Forms.TextBox()
        Me.labEstimatRedesource = New System.Windows.Forms.Label()
        Me.BtcCancel = New System.Windows.Forms.Button()
        Me.btcOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labID_Project
        '
        Me.labID_Project.AutoSize = True
        Me.labID_Project.Location = New System.Drawing.Point(15, 19)
        Me.labID_Project.Name = "labID_Project"
        Me.labID_Project.Size = New System.Drawing.Size(62, 13)
        Me.labID_Project.TabIndex = 0
        Me.labID_Project.Text = "ID de projet"
        '
        'texID_Project
        '
        Me.texID_Project.Location = New System.Drawing.Point(83, 16)
        Me.texID_Project.Name = "texID_Project"
        Me.texID_Project.ReadOnly = True
        Me.texID_Project.Size = New System.Drawing.Size(347, 20)
        Me.texID_Project.TabIndex = 1
        '
        'texProjectTitle
        '
        Me.texProjectTitle.Location = New System.Drawing.Point(83, 42)
        Me.texProjectTitle.Name = "texProjectTitle"
        Me.texProjectTitle.ReadOnly = True
        Me.texProjectTitle.Size = New System.Drawing.Size(347, 20)
        Me.texProjectTitle.TabIndex = 3
        '
        'labProjectTitle
        '
        Me.labProjectTitle.AutoSize = True
        Me.labProjectTitle.Location = New System.Drawing.Point(43, 45)
        Me.labProjectTitle.Name = "labProjectTitle"
        Me.labProjectTitle.Size = New System.Drawing.Size(34, 13)
        Me.labProjectTitle.TabIndex = 2
        Me.labProjectTitle.Text = "Projet"
        '
        'lovTasks
        '
        Me.lovTasks.FormattingEnabled = True
        Me.lovTasks.Location = New System.Drawing.Point(83, 68)
        Me.lovTasks.Name = "lovTasks"
        Me.lovTasks.Size = New System.Drawing.Size(109, 21)
        Me.lovTasks.TabIndex = 4
        '
        'labTaches
        '
        Me.labTaches.AutoSize = True
        Me.labTaches.Location = New System.Drawing.Point(34, 71)
        Me.labTaches.Name = "labTaches"
        Me.labTaches.Size = New System.Drawing.Size(43, 13)
        Me.labTaches.TabIndex = 5
        Me.labTaches.Text = "Tâches"
        '
        'texEstimatRedesource
        '
        Me.texEstimatRedesource.Location = New System.Drawing.Point(321, 68)
        Me.texEstimatRedesource.Name = "texEstimatRedesource"
        Me.texEstimatRedesource.Size = New System.Drawing.Size(109, 20)
        Me.texEstimatRedesource.TabIndex = 6
        '
        'labEstimatRedesource
        '
        Me.labEstimatRedesource.AutoSize = True
        Me.labEstimatRedesource.Location = New System.Drawing.Point(197, 71)
        Me.labEstimatRedesource.Name = "labEstimatRedesource"
        Me.labEstimatRedesource.Size = New System.Drawing.Size(122, 13)
        Me.labEstimatRedesource.TabIndex = 7
        Me.labEstimatRedesource.Text = "Ressources estimées (h)"
        '
        'BtcCancel
        '
        Me.BtcCancel.Location = New System.Drawing.Point(117, 120)
        Me.BtcCancel.Name = "BtcCancel"
        Me.BtcCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtcCancel.TabIndex = 8
        Me.BtcCancel.Text = "Annuler"
        Me.BtcCancel.UseVisualStyleBackColor = True
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(273, 120)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 9
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'frmProjectEstimatedResources
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 190)
        Me.Controls.Add(Me.btcOK)
        Me.Controls.Add(Me.BtcCancel)
        Me.Controls.Add(Me.labEstimatRedesource)
        Me.Controls.Add(Me.texEstimatRedesource)
        Me.Controls.Add(Me.labTaches)
        Me.Controls.Add(Me.lovTasks)
        Me.Controls.Add(Me.texProjectTitle)
        Me.Controls.Add(Me.labProjectTitle)
        Me.Controls.Add(Me.texID_Project)
        Me.Controls.Add(Me.labID_Project)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectEstimatedResources"
        Me.ShowInTaskbar = False
        Me.Text = "Estimation des ressources de projet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labID_Project As Label
    Friend WithEvents texID_Project As TextBox
    Friend WithEvents texProjectTitle As TextBox
    Friend WithEvents labProjectTitle As Label
    Friend WithEvents lovTasks As ComboBox
    Friend WithEvents labTaches As Label
    Friend WithEvents texEstimatRedesource As TextBox
    Friend WithEvents labEstimatRedesource As Label
    Friend WithEvents BtcCancel As Button
    Friend WithEvents btcOK As Button
End Class
