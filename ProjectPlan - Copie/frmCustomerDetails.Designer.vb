<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerDetails))
        Me.labID_ProjectManager = New System.Windows.Forms.Label()
        Me.texID_Customer = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.labLastname = New System.Windows.Forms.Label()
        Me.texLastname = New System.Windows.Forms.TextBox()
        Me.labFirstname = New System.Windows.Forms.Label()
        Me.texFirstname = New System.Windows.Forms.TextBox()
        Me.btcAnnuler = New System.Windows.Forms.Button()
        Me.btcOK = New System.Windows.Forms.Button()
        Me.labCompanyName = New System.Windows.Forms.Label()
        Me.texCompanyName = New System.Windows.Forms.TextBox()
        Me.labCompanyLocation = New System.Windows.Forms.Label()
        Me.texCompanyLocation = New System.Windows.Forms.TextBox()
        Me.labDisplayOrder = New System.Windows.Forms.Label()
        Me.texDisplayOrder = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'labID_ProjectManager
        '
        Me.labID_ProjectManager.AutoSize = True
        Me.labID_ProjectManager.Location = New System.Drawing.Point(99, 15)
        Me.labID_ProjectManager.Name = "labID_ProjectManager"
        Me.labID_ProjectManager.Size = New System.Drawing.Size(18, 13)
        Me.labID_ProjectManager.TabIndex = 75
        Me.labID_ProjectManager.Text = "ID"
        '
        'texID_Customer
        '
        Me.texID_Customer.Location = New System.Drawing.Point(123, 12)
        Me.texID_Customer.Name = "texID_Customer"
        Me.texID_Customer.ReadOnly = True
        Me.texID_Customer.Size = New System.Drawing.Size(213, 20)
        Me.texID_Customer.TabIndex = 74
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(123, 183)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 6
        Me.chkActive.Text = "Activé"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'labLastname
        '
        Me.labLastname.AutoSize = True
        Me.labLastname.Location = New System.Drawing.Point(88, 68)
        Me.labLastname.Name = "labLastname"
        Me.labLastname.Size = New System.Drawing.Size(29, 13)
        Me.labLastname.TabIndex = 73
        Me.labLastname.Text = "Nom"
        '
        'texLastname
        '
        Me.texLastname.Location = New System.Drawing.Point(123, 65)
        Me.texLastname.Name = "texLastname"
        Me.texLastname.Size = New System.Drawing.Size(213, 20)
        Me.texLastname.TabIndex = 2
        '
        'labFirstname
        '
        Me.labFirstname.AutoSize = True
        Me.labFirstname.Location = New System.Drawing.Point(74, 42)
        Me.labFirstname.Name = "labFirstname"
        Me.labFirstname.Size = New System.Drawing.Size(43, 13)
        Me.labFirstname.TabIndex = 72
        Me.labFirstname.Text = "Prénom"
        '
        'texFirstname
        '
        Me.texFirstname.Location = New System.Drawing.Point(123, 39)
        Me.texFirstname.Name = "texFirstname"
        Me.texFirstname.Size = New System.Drawing.Size(213, 20)
        Me.texFirstname.TabIndex = 1
        '
        'btcAnnuler
        '
        Me.btcAnnuler.Location = New System.Drawing.Point(123, 219)
        Me.btcAnnuler.Name = "btcAnnuler"
        Me.btcAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btcAnnuler.TabIndex = 7
        Me.btcAnnuler.Text = "Annuler"
        Me.btcAnnuler.UseVisualStyleBackColor = True
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(261, 219)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 8
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'labCompanyName
        '
        Me.labCompanyName.AutoSize = True
        Me.labCompanyName.Location = New System.Drawing.Point(74, 94)
        Me.labCompanyName.Name = "labCompanyName"
        Me.labCompanyName.Size = New System.Drawing.Size(43, 13)
        Me.labCompanyName.TabIndex = 77
        Me.labCompanyName.Text = "Société"
        '
        'texCompanyName
        '
        Me.texCompanyName.Location = New System.Drawing.Point(123, 91)
        Me.texCompanyName.Name = "texCompanyName"
        Me.texCompanyName.Size = New System.Drawing.Size(213, 20)
        Me.texCompanyName.TabIndex = 3
        '
        'labCompanyLocation
        '
        Me.labCompanyLocation.AutoSize = True
        Me.labCompanyLocation.Location = New System.Drawing.Point(10, 120)
        Me.labCompanyLocation.Name = "labCompanyLocation"
        Me.labCompanyLocation.Size = New System.Drawing.Size(107, 13)
        Me.labCompanyLocation.TabIndex = 79
        Me.labCompanyLocation.Text = "Localité de la société"
        '
        'texCompanyLocation
        '
        Me.texCompanyLocation.Location = New System.Drawing.Point(123, 117)
        Me.texCompanyLocation.Name = "texCompanyLocation"
        Me.texCompanyLocation.Size = New System.Drawing.Size(213, 20)
        Me.texCompanyLocation.TabIndex = 4
        '
        'labDisplayOrder
        '
        Me.labDisplayOrder.AutoSize = True
        Me.labDisplayOrder.Location = New System.Drawing.Point(10, 146)
        Me.labDisplayOrder.Name = "labDisplayOrder"
        Me.labDisplayOrder.Size = New System.Drawing.Size(88, 13)
        Me.labDisplayOrder.TabIndex = 81
        Me.labDisplayOrder.Text = "Ordre d'affichage"
        '
        'texDisplayOrder
        '
        Me.texDisplayOrder.Location = New System.Drawing.Point(123, 143)
        Me.texDisplayOrder.Name = "texDisplayOrder"
        Me.texDisplayOrder.Size = New System.Drawing.Size(213, 20)
        Me.texDisplayOrder.TabIndex = 5
        '
        'frmCustomerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 299)
        Me.Controls.Add(Me.labDisplayOrder)
        Me.Controls.Add(Me.texDisplayOrder)
        Me.Controls.Add(Me.labCompanyLocation)
        Me.Controls.Add(Me.texCompanyLocation)
        Me.Controls.Add(Me.labCompanyName)
        Me.Controls.Add(Me.texCompanyName)
        Me.Controls.Add(Me.labID_ProjectManager)
        Me.Controls.Add(Me.texID_Customer)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.labLastname)
        Me.Controls.Add(Me.texLastname)
        Me.Controls.Add(Me.labFirstname)
        Me.Controls.Add(Me.texFirstname)
        Me.Controls.Add(Me.btcAnnuler)
        Me.Controls.Add(Me.btcOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomerDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Détails du commanditaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labID_ProjectManager As Label
    Friend WithEvents texID_Customer As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents labLastname As Label
    Friend WithEvents texLastname As TextBox
    Friend WithEvents labFirstname As Label
    Friend WithEvents texFirstname As TextBox
    Friend WithEvents btcAnnuler As Button
    Friend WithEvents btcOK As Button
    Friend WithEvents labCompanyName As Label
    Friend WithEvents texCompanyName As TextBox
    Friend WithEvents labCompanyLocation As Label
    Friend WithEvents texCompanyLocation As TextBox
    Friend WithEvents labDisplayOrder As Label
    Friend WithEvents texDisplayOrder As TextBox
End Class
