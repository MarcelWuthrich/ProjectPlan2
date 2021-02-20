<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResourceAdminDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResourceAdminDetails))
        Me.labID_ResourceAdmin = New System.Windows.Forms.Label()
        Me.texID_ResourceAdmin = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.labDisplayOrder = New System.Windows.Forms.Label()
        Me.texDisplayOrder = New System.Windows.Forms.TextBox()
        Me.labResourceAdmin = New System.Windows.Forms.Label()
        Me.texResourceAdmin = New System.Windows.Forms.TextBox()
        Me.btcAnnuler = New System.Windows.Forms.Button()
        Me.btcOK = New System.Windows.Forms.Button()
        Me.labResourceAdminSymbol = New System.Windows.Forms.Label()
        Me.texResourceAdminSymbol = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'labID_ResourceAdmin
        '
        Me.labID_ResourceAdmin.AutoSize = True
        Me.labID_ResourceAdmin.Location = New System.Drawing.Point(122, 26)
        Me.labID_ResourceAdmin.Name = "labID_ResourceAdmin"
        Me.labID_ResourceAdmin.Size = New System.Drawing.Size(18, 13)
        Me.labID_ResourceAdmin.TabIndex = 67
        Me.labID_ResourceAdmin.Text = "ID"
        '
        'texID_ResourceAdmin
        '
        Me.texID_ResourceAdmin.Location = New System.Drawing.Point(146, 23)
        Me.texID_ResourceAdmin.Name = "texID_ResourceAdmin"
        Me.texID_ResourceAdmin.ReadOnly = True
        Me.texID_ResourceAdmin.Size = New System.Drawing.Size(213, 20)
        Me.texID_ResourceAdmin.TabIndex = 66
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(146, 128)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 4
        Me.chkActive.Text = "Activé"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'labDisplayOrder
        '
        Me.labDisplayOrder.AutoSize = True
        Me.labDisplayOrder.Location = New System.Drawing.Point(52, 105)
        Me.labDisplayOrder.Name = "labDisplayOrder"
        Me.labDisplayOrder.Size = New System.Drawing.Size(88, 13)
        Me.labDisplayOrder.TabIndex = 65
        Me.labDisplayOrder.Text = "Ordre d'affichage"
        '
        'texDisplayOrder
        '
        Me.texDisplayOrder.Location = New System.Drawing.Point(146, 102)
        Me.texDisplayOrder.Name = "texDisplayOrder"
        Me.texDisplayOrder.Size = New System.Drawing.Size(213, 20)
        Me.texDisplayOrder.TabIndex = 3
        '
        'labResourceAdmin
        '
        Me.labResourceAdmin.AutoSize = True
        Me.labResourceAdmin.Location = New System.Drawing.Point(15, 52)
        Me.labResourceAdmin.Name = "labResourceAdmin"
        Me.labResourceAdmin.Size = New System.Drawing.Size(125, 13)
        Me.labResourceAdmin.TabIndex = 64
        Me.labResourceAdmin.Text = "Ressource administrative"
        '
        'texResourceAdmin
        '
        Me.texResourceAdmin.Location = New System.Drawing.Point(146, 49)
        Me.texResourceAdmin.Name = "texResourceAdmin"
        Me.texResourceAdmin.Size = New System.Drawing.Size(213, 20)
        Me.texResourceAdmin.TabIndex = 1
        '
        'btcAnnuler
        '
        Me.btcAnnuler.Location = New System.Drawing.Point(146, 166)
        Me.btcAnnuler.Name = "btcAnnuler"
        Me.btcAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btcAnnuler.TabIndex = 5
        Me.btcAnnuler.Text = "Annuler"
        Me.btcAnnuler.UseVisualStyleBackColor = True
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(284, 166)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 6
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'labResourceAdminSymbol
        '
        Me.labResourceAdminSymbol.AutoSize = True
        Me.labResourceAdminSymbol.Location = New System.Drawing.Point(93, 79)
        Me.labResourceAdminSymbol.Name = "labResourceAdminSymbol"
        Me.labResourceAdminSymbol.Size = New System.Drawing.Size(47, 13)
        Me.labResourceAdminSymbol.TabIndex = 69
        Me.labResourceAdminSymbol.Text = "Symbôle"
        '
        'texResourceAdminSymbol
        '
        Me.texResourceAdminSymbol.Location = New System.Drawing.Point(146, 76)
        Me.texResourceAdminSymbol.Name = "texResourceAdminSymbol"
        Me.texResourceAdminSymbol.Size = New System.Drawing.Size(213, 20)
        Me.texResourceAdminSymbol.TabIndex = 2
        '
        'frmResourceAdminDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 228)
        Me.Controls.Add(Me.labResourceAdminSymbol)
        Me.Controls.Add(Me.texResourceAdminSymbol)
        Me.Controls.Add(Me.labID_ResourceAdmin)
        Me.Controls.Add(Me.texID_ResourceAdmin)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.labDisplayOrder)
        Me.Controls.Add(Me.texDisplayOrder)
        Me.Controls.Add(Me.labResourceAdmin)
        Me.Controls.Add(Me.texResourceAdmin)
        Me.Controls.Add(Me.btcAnnuler)
        Me.Controls.Add(Me.btcOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResourceAdminDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Détails des ressources administratives"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labID_ResourceAdmin As Label
    Friend WithEvents texID_ResourceAdmin As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents labDisplayOrder As Label
    Friend WithEvents texDisplayOrder As TextBox
    Friend WithEvents labResourceAdmin As Label
    Friend WithEvents texResourceAdmin As TextBox
    Friend WithEvents btcAnnuler As Button
    Friend WithEvents btcOK As Button
    Friend WithEvents labResourceAdminSymbol As Label
    Friend WithEvents texResourceAdminSymbol As TextBox
End Class
