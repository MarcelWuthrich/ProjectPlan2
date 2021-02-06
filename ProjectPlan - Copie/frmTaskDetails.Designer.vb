<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaskDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTaskDetails))
        Me.btcOK = New System.Windows.Forms.Button()
        Me.btcAnnuler = New System.Windows.Forms.Button()
        Me.labID_Task = New System.Windows.Forms.Label()
        Me.texID_Task = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.labDisplayOrder = New System.Windows.Forms.Label()
        Me.texDisplayOrder = New System.Windows.Forms.TextBox()
        Me.labTask = New System.Windows.Forms.Label()
        Me.texTask = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(257, 145)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 0
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'btcAnnuler
        '
        Me.btcAnnuler.Location = New System.Drawing.Point(119, 145)
        Me.btcAnnuler.Name = "btcAnnuler"
        Me.btcAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btcAnnuler.TabIndex = 1
        Me.btcAnnuler.Text = "Annuler"
        Me.btcAnnuler.UseVisualStyleBackColor = True
        '
        'labID_Task
        '
        Me.labID_Task.AutoSize = True
        Me.labID_Task.Location = New System.Drawing.Point(95, 31)
        Me.labID_Task.Name = "labID_Task"
        Me.labID_Task.Size = New System.Drawing.Size(18, 13)
        Me.labID_Task.TabIndex = 55
        Me.labID_Task.Text = "ID"
        '
        'texID_Task
        '
        Me.texID_Task.Location = New System.Drawing.Point(119, 28)
        Me.texID_Task.Name = "texID_Task"
        Me.texID_Task.ReadOnly = True
        Me.texID_Task.Size = New System.Drawing.Size(213, 20)
        Me.texID_Task.TabIndex = 54
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(119, 107)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 51
        Me.chkActive.Text = "Activé"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'labDisplayOrder
        '
        Me.labDisplayOrder.AutoSize = True
        Me.labDisplayOrder.Location = New System.Drawing.Point(25, 84)
        Me.labDisplayOrder.Name = "labDisplayOrder"
        Me.labDisplayOrder.Size = New System.Drawing.Size(88, 13)
        Me.labDisplayOrder.TabIndex = 53
        Me.labDisplayOrder.Text = "Ordre d'affichage"
        '
        'texDisplayOrder
        '
        Me.texDisplayOrder.Location = New System.Drawing.Point(119, 81)
        Me.texDisplayOrder.Name = "texDisplayOrder"
        Me.texDisplayOrder.Size = New System.Drawing.Size(213, 20)
        Me.texDisplayOrder.TabIndex = 50
        '
        'labTask
        '
        Me.labTask.AutoSize = True
        Me.labTask.Location = New System.Drawing.Point(19, 58)
        Me.labTask.Name = "labTask"
        Me.labTask.Size = New System.Drawing.Size(94, 13)
        Me.labTask.TabIndex = 52
        Me.labTask.Text = "Domaine d'activité"
        '
        'texTask
        '
        Me.texTask.Location = New System.Drawing.Point(119, 55)
        Me.texTask.Name = "texTask"
        Me.texTask.Size = New System.Drawing.Size(213, 20)
        Me.texTask.TabIndex = 49
        '
        'frmTaskDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 209)
        Me.Controls.Add(Me.labID_Task)
        Me.Controls.Add(Me.texID_Task)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.labDisplayOrder)
        Me.Controls.Add(Me.texDisplayOrder)
        Me.Controls.Add(Me.labTask)
        Me.Controls.Add(Me.texTask)
        Me.Controls.Add(Me.btcAnnuler)
        Me.Controls.Add(Me.btcOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTaskDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Détails des membres des projets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btcOK As Button
    Friend WithEvents btcAnnuler As Button
    Friend WithEvents labID_Task As Label
    Friend WithEvents texID_Task As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents labDisplayOrder As Label
    Friend WithEvents texDisplayOrder As TextBox
    Friend WithEvents labTask As Label
    Friend WithEvents texTask As TextBox
End Class
