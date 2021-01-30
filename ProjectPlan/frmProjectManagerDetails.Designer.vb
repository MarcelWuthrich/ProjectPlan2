<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectManagerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectManagerDetails))
        Me.labID_ProjectManager = New System.Windows.Forms.Label()
        Me.texID_ProjectManager = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.labNom = New System.Windows.Forms.Label()
        Me.texNom = New System.Windows.Forms.TextBox()
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.texPrenom = New System.Windows.Forms.TextBox()
        Me.btcAnnuler = New System.Windows.Forms.Button()
        Me.btcOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labID_ProjectManager
        '
        Me.labID_ProjectManager.AutoSize = True
        Me.labID_ProjectManager.Location = New System.Drawing.Point(20, 22)
        Me.labID_ProjectManager.Name = "labID_ProjectManager"
        Me.labID_ProjectManager.Size = New System.Drawing.Size(18, 13)
        Me.labID_ProjectManager.TabIndex = 66
        Me.labID_ProjectManager.Text = "ID"
        '
        'texID_ProjectManager
        '
        Me.texID_ProjectManager.Location = New System.Drawing.Point(69, 19)
        Me.texID_ProjectManager.Name = "texID_ProjectManager"
        Me.texID_ProjectManager.ReadOnly = True
        Me.texID_ProjectManager.Size = New System.Drawing.Size(213, 20)
        Me.texID_ProjectManager.TabIndex = 65
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(69, 98)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 62
        Me.chkActive.Text = "Activé"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'labNom
        '
        Me.labNom.AutoSize = True
        Me.labNom.Location = New System.Drawing.Point(20, 75)
        Me.labNom.Name = "labNom"
        Me.labNom.Size = New System.Drawing.Size(29, 13)
        Me.labNom.TabIndex = 64
        Me.labNom.Text = "Nom"
        '
        'texNom
        '
        Me.texNom.Location = New System.Drawing.Point(69, 72)
        Me.texNom.Name = "texNom"
        Me.texNom.Size = New System.Drawing.Size(213, 20)
        Me.texNom.TabIndex = 61
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Location = New System.Drawing.Point(20, 49)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(43, 13)
        Me.labPrenom.TabIndex = 63
        Me.labPrenom.Text = "Prénom"
        '
        'texPrenom
        '
        Me.texPrenom.Location = New System.Drawing.Point(69, 46)
        Me.texPrenom.Name = "texPrenom"
        Me.texPrenom.Size = New System.Drawing.Size(213, 20)
        Me.texPrenom.TabIndex = 60
        '
        'btcAnnuler
        '
        Me.btcAnnuler.Location = New System.Drawing.Point(69, 140)
        Me.btcAnnuler.Name = "btcAnnuler"
        Me.btcAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btcAnnuler.TabIndex = 59
        Me.btcAnnuler.Text = "Annuler"
        Me.btcAnnuler.UseVisualStyleBackColor = True
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(207, 140)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 58
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'frmProjectManagerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 193)
        Me.Controls.Add(Me.labID_ProjectManager)
        Me.Controls.Add(Me.texID_ProjectManager)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.labNom)
        Me.Controls.Add(Me.texNom)
        Me.Controls.Add(Me.labPrenom)
        Me.Controls.Add(Me.texPrenom)
        Me.Controls.Add(Me.btcAnnuler)
        Me.Controls.Add(Me.btcOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectManagerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Détails du chef de projet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labID_ProjectManager As Label
    Friend WithEvents texID_ProjectManager As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents labNom As Label
    Friend WithEvents texNom As TextBox
    Friend WithEvents labPrenom As Label
    Friend WithEvents texPrenom As TextBox
    Friend WithEvents btcAnnuler As Button
    Friend WithEvents btcOK As Button
End Class
