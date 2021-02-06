<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatusDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatusDetails))
        Me.labID_Status = New System.Windows.Forms.Label()
        Me.texID_Status = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.labDisplayOrder = New System.Windows.Forms.Label()
        Me.texDisplayOrder = New System.Windows.Forms.TextBox()
        Me.labStatus = New System.Windows.Forms.Label()
        Me.texStatus = New System.Windows.Forms.TextBox()
        Me.btcAnnuler = New System.Windows.Forms.Button()
        Me.btcOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labID_Status
        '
        Me.labID_Status.AutoSize = True
        Me.labID_Status.Location = New System.Drawing.Point(108, 28)
        Me.labID_Status.Name = "labID_Status"
        Me.labID_Status.Size = New System.Drawing.Size(18, 13)
        Me.labID_Status.TabIndex = 64
        Me.labID_Status.Text = "ID"
        '
        'texID_Status
        '
        Me.texID_Status.Location = New System.Drawing.Point(132, 25)
        Me.texID_Status.Name = "texID_Status"
        Me.texID_Status.ReadOnly = True
        Me.texID_Status.Size = New System.Drawing.Size(213, 20)
        Me.texID_Status.TabIndex = 63
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(132, 104)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 60
        Me.chkActive.Text = "Activé"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'labDisplayOrder
        '
        Me.labDisplayOrder.AutoSize = True
        Me.labDisplayOrder.Location = New System.Drawing.Point(38, 81)
        Me.labDisplayOrder.Name = "labDisplayOrder"
        Me.labDisplayOrder.Size = New System.Drawing.Size(88, 13)
        Me.labDisplayOrder.TabIndex = 62
        Me.labDisplayOrder.Text = "Ordre d'affichage"
        '
        'texDisplayOrder
        '
        Me.texDisplayOrder.Location = New System.Drawing.Point(132, 78)
        Me.texDisplayOrder.Name = "texDisplayOrder"
        Me.texDisplayOrder.Size = New System.Drawing.Size(213, 20)
        Me.texDisplayOrder.TabIndex = 59
        '
        'labStatus
        '
        Me.labStatus.AutoSize = True
        Me.labStatus.Location = New System.Drawing.Point(91, 55)
        Me.labStatus.Name = "labStatus"
        Me.labStatus.Size = New System.Drawing.Size(35, 13)
        Me.labStatus.TabIndex = 61
        Me.labStatus.Text = "Statut"
        '
        'texStatus
        '
        Me.texStatus.Location = New System.Drawing.Point(132, 52)
        Me.texStatus.Name = "texStatus"
        Me.texStatus.Size = New System.Drawing.Size(213, 20)
        Me.texStatus.TabIndex = 58
        '
        'btcAnnuler
        '
        Me.btcAnnuler.Location = New System.Drawing.Point(132, 142)
        Me.btcAnnuler.Name = "btcAnnuler"
        Me.btcAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btcAnnuler.TabIndex = 57
        Me.btcAnnuler.Text = "Annuler"
        Me.btcAnnuler.UseVisualStyleBackColor = True
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(270, 142)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 56
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'frmStatusDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 205)
        Me.Controls.Add(Me.labID_Status)
        Me.Controls.Add(Me.texID_Status)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.labDisplayOrder)
        Me.Controls.Add(Me.texDisplayOrder)
        Me.Controls.Add(Me.labStatus)
        Me.Controls.Add(Me.texStatus)
        Me.Controls.Add(Me.btcAnnuler)
        Me.Controls.Add(Me.btcOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStatusDetails"
        Me.Text = "Détails du statut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labID_Status As Label
    Friend WithEvents texID_Status As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents labDisplayOrder As Label
    Friend WithEvents texDisplayOrder As TextBox
    Friend WithEvents labStatus As Label
    Friend WithEvents texStatus As TextBox
    Friend WithEvents btcAnnuler As Button
    Friend WithEvents btcOK As Button
End Class
