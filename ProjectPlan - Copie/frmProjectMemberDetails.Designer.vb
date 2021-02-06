<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectMemberDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectMemberDetails))
        Me.btcOK = New System.Windows.Forms.Button()
        Me.btcAnnuler = New System.Windows.Forms.Button()
        Me.labTache = New System.Windows.Forms.Label()
        Me.lovTasks = New System.Windows.Forms.ComboBox()
        Me.labID_ProjectMember = New System.Windows.Forms.Label()
        Me.texID_ProjectMember = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.labNom = New System.Windows.Forms.Label()
        Me.texNom = New System.Windows.Forms.TextBox()
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.texPrenom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(232, 178)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 0
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'btcAnnuler
        '
        Me.btcAnnuler.Location = New System.Drawing.Point(94, 178)
        Me.btcAnnuler.Name = "btcAnnuler"
        Me.btcAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btcAnnuler.TabIndex = 1
        Me.btcAnnuler.Text = "Annuler"
        Me.btcAnnuler.UseVisualStyleBackColor = True
        '
        'labTache
        '
        Me.labTache.AutoSize = True
        Me.labTache.Location = New System.Drawing.Point(45, 111)
        Me.labTache.Name = "labTache"
        Me.labTache.Size = New System.Drawing.Size(38, 13)
        Me.labTache.TabIndex = 57
        Me.labTache.Text = "Tâche"
        '
        'lovTasks
        '
        Me.lovTasks.FormattingEnabled = True
        Me.lovTasks.Location = New System.Drawing.Point(94, 108)
        Me.lovTasks.Name = "lovTasks"
        Me.lovTasks.Size = New System.Drawing.Size(213, 21)
        Me.lovTasks.TabIndex = 56
        '
        'labID_ProjectMember
        '
        Me.labID_ProjectMember.AutoSize = True
        Me.labID_ProjectMember.Location = New System.Drawing.Point(45, 31)
        Me.labID_ProjectMember.Name = "labID_ProjectMember"
        Me.labID_ProjectMember.Size = New System.Drawing.Size(18, 13)
        Me.labID_ProjectMember.TabIndex = 55
        Me.labID_ProjectMember.Text = "ID"
        '
        'texID_ProjectMember
        '
        Me.texID_ProjectMember.Location = New System.Drawing.Point(94, 28)
        Me.texID_ProjectMember.Name = "texID_ProjectMember"
        Me.texID_ProjectMember.ReadOnly = True
        Me.texID_ProjectMember.Size = New System.Drawing.Size(213, 20)
        Me.texID_ProjectMember.TabIndex = 54
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(94, 133)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 51
        Me.chkActive.Text = "Activé"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'labNom
        '
        Me.labNom.AutoSize = True
        Me.labNom.Location = New System.Drawing.Point(45, 84)
        Me.labNom.Name = "labNom"
        Me.labNom.Size = New System.Drawing.Size(29, 13)
        Me.labNom.TabIndex = 53
        Me.labNom.Text = "Nom"
        '
        'texNom
        '
        Me.texNom.Location = New System.Drawing.Point(94, 81)
        Me.texNom.Name = "texNom"
        Me.texNom.Size = New System.Drawing.Size(213, 20)
        Me.texNom.TabIndex = 50
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Location = New System.Drawing.Point(45, 58)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(43, 13)
        Me.labPrenom.TabIndex = 52
        Me.labPrenom.Text = "Prénom"
        '
        'texPrenom
        '
        Me.texPrenom.Location = New System.Drawing.Point(94, 55)
        Me.texPrenom.Name = "texPrenom"
        Me.texPrenom.Size = New System.Drawing.Size(213, 20)
        Me.texPrenom.TabIndex = 49
        '
        'frmProjectMemberDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 241)
        Me.Controls.Add(Me.labTache)
        Me.Controls.Add(Me.lovTasks)
        Me.Controls.Add(Me.labID_ProjectMember)
        Me.Controls.Add(Me.texID_ProjectMember)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.labNom)
        Me.Controls.Add(Me.texNom)
        Me.Controls.Add(Me.labPrenom)
        Me.Controls.Add(Me.texPrenom)
        Me.Controls.Add(Me.btcAnnuler)
        Me.Controls.Add(Me.btcOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectMemberDetails"
        Me.Text = "Détails des membres des projets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btcOK As Button
    Friend WithEvents btcAnnuler As Button
    Friend WithEvents labTache As Label
    Friend WithEvents lovTasks As ComboBox
    Friend WithEvents labID_ProjectMember As Label
    Friend WithEvents texID_ProjectMember As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents labNom As Label
    Friend WithEvents texNom As TextBox
    Friend WithEvents labPrenom As Label
    Friend WithEvents texPrenom As TextBox
End Class
