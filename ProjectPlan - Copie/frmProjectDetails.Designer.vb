<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProjectDetails
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjectDetails))
        Me.texTitre = New System.Windows.Forms.TextBox()
        Me.labTitre = New System.Windows.Forms.Label()
        Me.labCategorie = New System.Windows.Forms.Label()
        Me.labDescription = New System.Windows.Forms.Label()
        Me.texDescription = New System.Windows.Forms.TextBox()
        Me.labDeadline = New System.Windows.Forms.Label()
        Me.dtpDeadline = New System.Windows.Forms.DateTimePicker()
        Me.lovProjectManager = New System.Windows.Forms.ComboBox()
        Me.labChefProjet = New System.Windows.Forms.Label()
        Me.labStatut = New System.Windows.Forms.Label()
        Me.lovStatus = New System.Windows.Forms.ComboBox()
        Me.btcAnnuler = New System.Windows.Forms.Button()
        Me.btcOK = New System.Windows.Forms.Button()
        Me.labImplementationRate = New System.Windows.Forms.Label()
        Me.texImplementationRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labID_Project = New System.Windows.Forms.Label()
        Me.texID_Project = New System.Windows.Forms.TextBox()
        Me.lovPriority = New System.Windows.Forms.ComboBox()
        Me.labPriority = New System.Windows.Forms.Label()
        Me.lovProjectCategory = New System.Windows.Forms.ComboBox()
        Me.labClient = New System.Windows.Forms.Label()
        Me.lovCustomer = New System.Windows.Forms.ComboBox()
        Me.texPlanResources = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labPlanResources = New System.Windows.Forms.Label()
        Me.labExecutedResources = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.texExecutedResources = New System.Windows.Forms.TextBox()
        Me.btcComments = New System.Windows.Forms.Button()
        Me.lovUrgency = New System.Windows.Forms.ComboBox()
        Me.labUrgency = New System.Windows.Forms.Label()
        Me.dtpBegin = New System.Windows.Forms.DateTimePicker()
        Me.labBegin = New System.Windows.Forms.Label()
        Me.labRemarks = New System.Windows.Forms.Label()
        Me.dgvProjectRemarks = New System.Windows.Forms.DataGridView()
        Me.btcRemarkAdd = New System.Windows.Forms.Button()
        Me.btcRemarkRemove = New System.Windows.Forms.Button()
        Me.btcRemardModify = New System.Windows.Forms.Button()
        Me.btcRessourceModify = New System.Windows.Forms.Button()
        Me.btcRessourceRemove = New System.Windows.Forms.Button()
        Me.btcRessourceAdd = New System.Windows.Forms.Button()
        Me.dgvProjectRessources = New System.Windows.Forms.DataGridView()
        Me.labRessources = New System.Windows.Forms.Label()
        Me.labEstimatedResources = New System.Windows.Forms.Label()
        Me.texEstimatedResources = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DsProjectEstimatedResources = New ProjectPlan.dsProjectEstimatedResources()
        Me.VprojectestimatedresourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VprojectestimatedresourcesTableAdapter = New ProjectPlan.dsProjectEstimatedResourcesTableAdapters.vprojectestimatedresourcesTableAdapter()
        Me.IDResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDProjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEIDTaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaskDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstimatedResourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastModifyDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvProjectRemarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProjectRessources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProjectEstimatedResources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VprojectestimatedresourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'texTitre
        '
        Me.texTitre.Location = New System.Drawing.Point(164, 49)
        Me.texTitre.Name = "texTitre"
        Me.texTitre.Size = New System.Drawing.Size(647, 20)
        Me.texTitre.TabIndex = 1
        '
        'labTitre
        '
        Me.labTitre.AutoSize = True
        Me.labTitre.Location = New System.Drawing.Point(130, 52)
        Me.labTitre.Name = "labTitre"
        Me.labTitre.Size = New System.Drawing.Size(28, 13)
        Me.labTitre.TabIndex = 1
        Me.labTitre.Text = "Titre"
        '
        'labCategorie
        '
        Me.labCategorie.AutoSize = True
        Me.labCategorie.Location = New System.Drawing.Point(106, 214)
        Me.labCategorie.Name = "labCategorie"
        Me.labCategorie.Size = New System.Drawing.Size(52, 13)
        Me.labCategorie.TabIndex = 3
        Me.labCategorie.Text = "Categorie"
        '
        'labDescription
        '
        Me.labDescription.AutoSize = True
        Me.labDescription.Location = New System.Drawing.Point(98, 78)
        Me.labDescription.Name = "labDescription"
        Me.labDescription.Size = New System.Drawing.Size(60, 13)
        Me.labDescription.TabIndex = 5
        Me.labDescription.Text = "Description"
        '
        'texDescription
        '
        Me.texDescription.Location = New System.Drawing.Point(164, 75)
        Me.texDescription.Multiline = True
        Me.texDescription.Name = "texDescription"
        Me.texDescription.Size = New System.Drawing.Size(647, 103)
        Me.texDescription.TabIndex = 8
        '
        'labDeadline
        '
        Me.labDeadline.AutoSize = True
        Me.labDeadline.Location = New System.Drawing.Point(530, 268)
        Me.labDeadline.Name = "labDeadline"
        Me.labDeadline.Size = New System.Drawing.Size(53, 13)
        Me.labDeadline.TabIndex = 7
        Me.labDeadline.Text = "DeadLine"
        '
        'dtpDeadline
        '
        Me.dtpDeadline.Location = New System.Drawing.Point(589, 265)
        Me.dtpDeadline.Name = "dtpDeadline"
        Me.dtpDeadline.Size = New System.Drawing.Size(221, 20)
        Me.dtpDeadline.TabIndex = 5
        '
        'lovProjectManager
        '
        Me.lovProjectManager.FormattingEnabled = True
        Me.lovProjectManager.Location = New System.Drawing.Point(590, 184)
        Me.lovProjectManager.Name = "lovProjectManager"
        Me.lovProjectManager.Size = New System.Drawing.Size(221, 21)
        Me.lovProjectManager.Sorted = True
        Me.lovProjectManager.TabIndex = 3
        '
        'labChefProjet
        '
        Me.labChefProjet.AutoSize = True
        Me.labChefProjet.Location = New System.Drawing.Point(511, 187)
        Me.labChefProjet.Name = "labChefProjet"
        Me.labChefProjet.Size = New System.Drawing.Size(73, 13)
        Me.labChefProjet.TabIndex = 10
        Me.labChefProjet.Text = "Chef de projet"
        '
        'labStatut
        '
        Me.labStatut.AutoSize = True
        Me.labStatut.Location = New System.Drawing.Point(549, 214)
        Me.labStatut.Name = "labStatut"
        Me.labStatut.Size = New System.Drawing.Size(35, 13)
        Me.labStatut.TabIndex = 11
        Me.labStatut.Text = "Statut"
        '
        'lovStatus
        '
        Me.lovStatus.FormattingEnabled = True
        Me.lovStatus.Items.AddRange(New Object() {"1 ; sijfiej", "2 ; ifjwijfe"})
        Me.lovStatus.Location = New System.Drawing.Point(590, 211)
        Me.lovStatus.Name = "lovStatus"
        Me.lovStatus.Size = New System.Drawing.Size(221, 21)
        Me.lovStatus.TabIndex = 4
        '
        'btcAnnuler
        '
        Me.btcAnnuler.Location = New System.Drawing.Point(350, 683)
        Me.btcAnnuler.Name = "btcAnnuler"
        Me.btcAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.btcAnnuler.TabIndex = 9
        Me.btcAnnuler.Text = "Annuler"
        Me.btcAnnuler.UseVisualStyleBackColor = True
        '
        'btcOK
        '
        Me.btcOK.Location = New System.Drawing.Point(462, 683)
        Me.btcOK.Name = "btcOK"
        Me.btcOK.Size = New System.Drawing.Size(75, 23)
        Me.btcOK.TabIndex = 10
        Me.btcOK.Text = "OK"
        Me.btcOK.UseVisualStyleBackColor = True
        '
        'labImplementationRate
        '
        Me.labImplementationRate.AutoSize = True
        Me.labImplementationRate.Location = New System.Drawing.Point(487, 346)
        Me.labImplementationRate.Name = "labImplementationRate"
        Me.labImplementationRate.Size = New System.Drawing.Size(96, 13)
        Me.labImplementationRate.TabIndex = 18
        Me.labImplementationRate.Text = "Taux de réalisation"
        '
        'texImplementationRate
        '
        Me.texImplementationRate.Location = New System.Drawing.Point(589, 343)
        Me.texImplementationRate.Name = "texImplementationRate"
        Me.texImplementationRate.ReadOnly = True
        Me.texImplementationRate.Size = New System.Drawing.Size(221, 20)
        Me.texImplementationRate.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(816, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "( % )"
        '
        'labID_Project
        '
        Me.labID_Project.AutoSize = True
        Me.labID_Project.Location = New System.Drawing.Point(140, 26)
        Me.labID_Project.Name = "labID_Project"
        Me.labID_Project.Size = New System.Drawing.Size(18, 13)
        Me.labID_Project.TabIndex = 39
        Me.labID_Project.Text = "ID"
        '
        'texID_Project
        '
        Me.texID_Project.Location = New System.Drawing.Point(164, 23)
        Me.texID_Project.Name = "texID_Project"
        Me.texID_Project.ReadOnly = True
        Me.texID_Project.Size = New System.Drawing.Size(121, 20)
        Me.texID_Project.TabIndex = 38
        '
        'lovPriority
        '
        Me.lovPriority.FormattingEnabled = True
        Me.lovPriority.Location = New System.Drawing.Point(164, 238)
        Me.lovPriority.Name = "lovPriority"
        Me.lovPriority.Size = New System.Drawing.Size(221, 21)
        Me.lovPriority.TabIndex = 40
        '
        'labPriority
        '
        Me.labPriority.AutoSize = True
        Me.labPriority.Location = New System.Drawing.Point(119, 241)
        Me.labPriority.Name = "labPriority"
        Me.labPriority.Size = New System.Drawing.Size(39, 13)
        Me.labPriority.TabIndex = 41
        Me.labPriority.Text = "Priorité"
        '
        'lovProjectCategory
        '
        Me.lovProjectCategory.FormattingEnabled = True
        Me.lovProjectCategory.Location = New System.Drawing.Point(164, 211)
        Me.lovProjectCategory.Name = "lovProjectCategory"
        Me.lovProjectCategory.Size = New System.Drawing.Size(221, 21)
        Me.lovProjectCategory.TabIndex = 42
        '
        'labClient
        '
        Me.labClient.AutoSize = True
        Me.labClient.Location = New System.Drawing.Point(82, 187)
        Me.labClient.Name = "labClient"
        Me.labClient.Size = New System.Drawing.Size(76, 13)
        Me.labClient.TabIndex = 44
        Me.labClient.Text = "Commanditaire"
        '
        'lovCustomer
        '
        Me.lovCustomer.FormattingEnabled = True
        Me.lovCustomer.Location = New System.Drawing.Point(164, 184)
        Me.lovCustomer.Name = "lovCustomer"
        Me.lovCustomer.Size = New System.Drawing.Size(221, 21)
        Me.lovCustomer.Sorted = True
        Me.lovCustomer.TabIndex = 43
        '
        'texPlanResources
        '
        Me.texPlanResources.Location = New System.Drawing.Point(588, 317)
        Me.texPlanResources.Name = "texPlanResources"
        Me.texPlanResources.ReadOnly = True
        Me.texPlanResources.Size = New System.Drawing.Size(221, 20)
        Me.texPlanResources.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(815, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "( heures )"
        '
        'labPlanResources
        '
        Me.labPlanResources.AutoSize = True
        Me.labPlanResources.Location = New System.Drawing.Point(472, 320)
        Me.labPlanResources.Name = "labPlanResources"
        Me.labPlanResources.Size = New System.Drawing.Size(110, 13)
        Me.labPlanResources.TabIndex = 47
        Me.labPlanResources.Text = "Ressources planifiées"
        '
        'labExecutedResources
        '
        Me.labExecutedResources.AutoSize = True
        Me.labExecutedResources.Location = New System.Drawing.Point(52, 346)
        Me.labExecutedResources.Name = "labExecutedResources"
        Me.labExecutedResources.Size = New System.Drawing.Size(107, 13)
        Me.labExecutedResources.TabIndex = 50
        Me.labExecutedResources.Text = "Ressources réalisées"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(391, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "( heures )"
        '
        'texExecutedResources
        '
        Me.texExecutedResources.Location = New System.Drawing.Point(164, 343)
        Me.texExecutedResources.Name = "texExecutedResources"
        Me.texExecutedResources.ReadOnly = True
        Me.texExecutedResources.Size = New System.Drawing.Size(221, 20)
        Me.texExecutedResources.TabIndex = 48
        '
        'btcComments
        '
        Me.btcComments.Location = New System.Drawing.Point(576, 683)
        Me.btcComments.Name = "btcComments"
        Me.btcComments.Size = New System.Drawing.Size(81, 23)
        Me.btcComments.TabIndex = 51
        Me.btcComments.Text = "Commentaires"
        Me.btcComments.UseVisualStyleBackColor = True
        Me.btcComments.Visible = False
        '
        'lovUrgency
        '
        Me.lovUrgency.FormattingEnabled = True
        Me.lovUrgency.Location = New System.Drawing.Point(590, 238)
        Me.lovUrgency.Name = "lovUrgency"
        Me.lovUrgency.Size = New System.Drawing.Size(221, 21)
        Me.lovUrgency.TabIndex = 52
        '
        'labUrgency
        '
        Me.labUrgency.AutoSize = True
        Me.labUrgency.Location = New System.Drawing.Point(536, 241)
        Me.labUrgency.Name = "labUrgency"
        Me.labUrgency.Size = New System.Drawing.Size(48, 13)
        Me.labUrgency.TabIndex = 53
        Me.labUrgency.Text = "Urgence"
        '
        'dtpBegin
        '
        Me.dtpBegin.Location = New System.Drawing.Point(164, 265)
        Me.dtpBegin.Name = "dtpBegin"
        Me.dtpBegin.Size = New System.Drawing.Size(221, 20)
        Me.dtpBegin.TabIndex = 54
        '
        'labBegin
        '
        Me.labBegin.AutoSize = True
        Me.labBegin.Location = New System.Drawing.Point(122, 271)
        Me.labBegin.Name = "labBegin"
        Me.labBegin.Size = New System.Drawing.Size(36, 13)
        Me.labBegin.TabIndex = 55
        Me.labBegin.Text = "Début"
        '
        'labRemarks
        '
        Me.labRemarks.AutoSize = True
        Me.labRemarks.Location = New System.Drawing.Point(98, 538)
        Me.labRemarks.Name = "labRemarks"
        Me.labRemarks.Size = New System.Drawing.Size(61, 13)
        Me.labRemarks.TabIndex = 70
        Me.labRemarks.Text = "Remarques"
        '
        'dgvProjectRemarks
        '
        Me.dgvProjectRemarks.AllowUserToAddRows = False
        Me.dgvProjectRemarks.AllowUserToDeleteRows = False
        Me.dgvProjectRemarks.AllowUserToResizeColumns = False
        Me.dgvProjectRemarks.AllowUserToResizeRows = False
        Me.dgvProjectRemarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectRemarks.Location = New System.Drawing.Point(164, 538)
        Me.dgvProjectRemarks.Name = "dgvProjectRemarks"
        Me.dgvProjectRemarks.Size = New System.Drawing.Size(647, 111)
        Me.dgvProjectRemarks.TabIndex = 71
        '
        'btcRemarkAdd
        '
        Me.btcRemarkAdd.Location = New System.Drawing.Point(814, 538)
        Me.btcRemarkAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btcRemarkAdd.Name = "btcRemarkAdd"
        Me.btcRemarkAdd.Size = New System.Drawing.Size(77, 23)
        Me.btcRemarkAdd.TabIndex = 72
        Me.btcRemarkAdd.Text = "Ajouter"
        Me.btcRemarkAdd.UseVisualStyleBackColor = True
        '
        'btcRemarkRemove
        '
        Me.btcRemarkRemove.Location = New System.Drawing.Point(814, 590)
        Me.btcRemarkRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.btcRemarkRemove.Name = "btcRemarkRemove"
        Me.btcRemarkRemove.Size = New System.Drawing.Size(77, 23)
        Me.btcRemarkRemove.TabIndex = 73
        Me.btcRemarkRemove.Text = "Supprimer"
        Me.btcRemarkRemove.UseVisualStyleBackColor = True
        '
        'btcRemardModify
        '
        Me.btcRemardModify.Location = New System.Drawing.Point(814, 564)
        Me.btcRemardModify.Name = "btcRemardModify"
        Me.btcRemardModify.Size = New System.Drawing.Size(77, 23)
        Me.btcRemardModify.TabIndex = 74
        Me.btcRemardModify.Text = "Modifier"
        Me.btcRemardModify.UseVisualStyleBackColor = True
        '
        'btcRessourceModify
        '
        Me.btcRessourceModify.Location = New System.Drawing.Point(813, 421)
        Me.btcRessourceModify.Name = "btcRessourceModify"
        Me.btcRessourceModify.Size = New System.Drawing.Size(77, 23)
        Me.btcRessourceModify.TabIndex = 79
        Me.btcRessourceModify.Text = "Modifier"
        Me.btcRessourceModify.UseVisualStyleBackColor = True
        '
        'btcRessourceRemove
        '
        Me.btcRessourceRemove.Location = New System.Drawing.Point(813, 447)
        Me.btcRessourceRemove.Margin = New System.Windows.Forms.Padding(0)
        Me.btcRessourceRemove.Name = "btcRessourceRemove"
        Me.btcRessourceRemove.Size = New System.Drawing.Size(77, 23)
        Me.btcRessourceRemove.TabIndex = 78
        Me.btcRessourceRemove.Text = "Supprimer"
        Me.btcRessourceRemove.UseVisualStyleBackColor = True
        '
        'btcRessourceAdd
        '
        Me.btcRessourceAdd.Location = New System.Drawing.Point(813, 395)
        Me.btcRessourceAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.btcRessourceAdd.Name = "btcRessourceAdd"
        Me.btcRessourceAdd.Size = New System.Drawing.Size(77, 23)
        Me.btcRessourceAdd.TabIndex = 77
        Me.btcRessourceAdd.Text = "Ajouter"
        Me.btcRessourceAdd.UseVisualStyleBackColor = True
        '
        'dgvProjectRessources
        '
        Me.dgvProjectRessources.AllowUserToAddRows = False
        Me.dgvProjectRessources.AllowUserToDeleteRows = False
        Me.dgvProjectRessources.AllowUserToResizeRows = False
        Me.dgvProjectRessources.AutoGenerateColumns = False
        Me.dgvProjectRessources.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjectRessources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjectRessources.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDResourceDataGridViewTextBoxColumn, Me.CEIDProjectDataGridViewTextBoxColumn, Me.CEIDTaskDataGridViewTextBoxColumn, Me.TaskDataGridViewTextBoxColumn, Me.EstimatedResourceDataGridViewTextBoxColumn, Me.CreationDateDataGridViewTextBoxColumn, Me.LastModifyDateDataGridViewTextBoxColumn})
        Me.dgvProjectRessources.DataSource = Me.VprojectestimatedresourcesBindingSource
        Me.dgvProjectRessources.Location = New System.Drawing.Point(163, 395)
        Me.dgvProjectRessources.Name = "dgvProjectRessources"
        Me.dgvProjectRessources.Size = New System.Drawing.Size(647, 111)
        Me.dgvProjectRessources.TabIndex = 76
        '
        'labRessources
        '
        Me.labRessources.AutoSize = True
        Me.labRessources.Location = New System.Drawing.Point(51, 395)
        Me.labRessources.Name = "labRessources"
        Me.labRessources.Size = New System.Drawing.Size(107, 13)
        Me.labRessources.TabIndex = 75
        Me.labRessources.Text = "Ressources estimées"
        '
        'labEstimatedResources
        '
        Me.labEstimatedResources.AutoSize = True
        Me.labEstimatedResources.Location = New System.Drawing.Point(51, 320)
        Me.labEstimatedResources.Name = "labEstimatedResources"
        Me.labEstimatedResources.Size = New System.Drawing.Size(107, 13)
        Me.labEstimatedResources.TabIndex = 81
        Me.labEstimatedResources.Text = "Ressources estimées"
        '
        'texEstimatedResources
        '
        Me.texEstimatedResources.Location = New System.Drawing.Point(164, 317)
        Me.texEstimatedResources.Name = "texEstimatedResources"
        Me.texEstimatedResources.ReadOnly = True
        Me.texEstimatedResources.Size = New System.Drawing.Size(221, 20)
        Me.texEstimatedResources.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 320)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "( heures )"
        '
        'DsProjectEstimatedResources
        '
        Me.DsProjectEstimatedResources.DataSetName = "dsProjectEstimatedResources"
        Me.DsProjectEstimatedResources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VprojectestimatedresourcesBindingSource
        '
        Me.VprojectestimatedresourcesBindingSource.DataMember = "vprojectestimatedresources"
        Me.VprojectestimatedresourcesBindingSource.DataSource = Me.DsProjectEstimatedResources
        Me.VprojectestimatedresourcesBindingSource.Filter = ""
        '
        'VprojectestimatedresourcesTableAdapter
        '
        Me.VprojectestimatedresourcesTableAdapter.ClearBeforeFill = True
        '
        'IDResourceDataGridViewTextBoxColumn
        '
        Me.IDResourceDataGridViewTextBoxColumn.DataPropertyName = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn.HeaderText = "ID_Resource"
        Me.IDResourceDataGridViewTextBoxColumn.Name = "IDResourceDataGridViewTextBoxColumn"
        '
        'CEIDProjectDataGridViewTextBoxColumn
        '
        Me.CEIDProjectDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn.HeaderText = "CE_ID_Project"
        Me.CEIDProjectDataGridViewTextBoxColumn.Name = "CEIDProjectDataGridViewTextBoxColumn"
        '
        'CEIDTaskDataGridViewTextBoxColumn
        '
        Me.CEIDTaskDataGridViewTextBoxColumn.DataPropertyName = "CE_ID_Task"
        Me.CEIDTaskDataGridViewTextBoxColumn.HeaderText = "CE_ID_Task"
        Me.CEIDTaskDataGridViewTextBoxColumn.Name = "CEIDTaskDataGridViewTextBoxColumn"
        Me.CEIDTaskDataGridViewTextBoxColumn.Visible = False
        '
        'TaskDataGridViewTextBoxColumn
        '
        Me.TaskDataGridViewTextBoxColumn.DataPropertyName = "Task"
        Me.TaskDataGridViewTextBoxColumn.HeaderText = "Task"
        Me.TaskDataGridViewTextBoxColumn.Name = "TaskDataGridViewTextBoxColumn"
        '
        'EstimatedResourceDataGridViewTextBoxColumn
        '
        Me.EstimatedResourceDataGridViewTextBoxColumn.DataPropertyName = "EstimatedResource"
        Me.EstimatedResourceDataGridViewTextBoxColumn.HeaderText = "EstimatedResource"
        Me.EstimatedResourceDataGridViewTextBoxColumn.Name = "EstimatedResourceDataGridViewTextBoxColumn"
        '
        'CreationDateDataGridViewTextBoxColumn
        '
        Me.CreationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate"
        Me.CreationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate"
        Me.CreationDateDataGridViewTextBoxColumn.Name = "CreationDateDataGridViewTextBoxColumn"
        '
        'LastModifyDateDataGridViewTextBoxColumn
        '
        Me.LastModifyDateDataGridViewTextBoxColumn.DataPropertyName = "LastModifyDate"
        Me.LastModifyDateDataGridViewTextBoxColumn.HeaderText = "LastModifyDate"
        Me.LastModifyDateDataGridViewTextBoxColumn.Name = "LastModifyDateDataGridViewTextBoxColumn"
        '
        'frmProjectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 726)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labEstimatedResources)
        Me.Controls.Add(Me.texEstimatedResources)
        Me.Controls.Add(Me.btcRessourceModify)
        Me.Controls.Add(Me.btcRessourceRemove)
        Me.Controls.Add(Me.btcRessourceAdd)
        Me.Controls.Add(Me.dgvProjectRessources)
        Me.Controls.Add(Me.labRessources)
        Me.Controls.Add(Me.btcRemardModify)
        Me.Controls.Add(Me.btcRemarkRemove)
        Me.Controls.Add(Me.btcRemarkAdd)
        Me.Controls.Add(Me.dgvProjectRemarks)
        Me.Controls.Add(Me.labRemarks)
        Me.Controls.Add(Me.dtpBegin)
        Me.Controls.Add(Me.labBegin)
        Me.Controls.Add(Me.lovUrgency)
        Me.Controls.Add(Me.labUrgency)
        Me.Controls.Add(Me.btcComments)
        Me.Controls.Add(Me.labExecutedResources)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.texExecutedResources)
        Me.Controls.Add(Me.labPlanResources)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.texPlanResources)
        Me.Controls.Add(Me.labClient)
        Me.Controls.Add(Me.lovCustomer)
        Me.Controls.Add(Me.lovProjectCategory)
        Me.Controls.Add(Me.lovPriority)
        Me.Controls.Add(Me.labPriority)
        Me.Controls.Add(Me.labID_Project)
        Me.Controls.Add(Me.texID_Project)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.labImplementationRate)
        Me.Controls.Add(Me.texImplementationRate)
        Me.Controls.Add(Me.btcOK)
        Me.Controls.Add(Me.btcAnnuler)
        Me.Controls.Add(Me.lovStatus)
        Me.Controls.Add(Me.labStatut)
        Me.Controls.Add(Me.labChefProjet)
        Me.Controls.Add(Me.lovProjectManager)
        Me.Controls.Add(Me.dtpDeadline)
        Me.Controls.Add(Me.labDeadline)
        Me.Controls.Add(Me.labDescription)
        Me.Controls.Add(Me.texDescription)
        Me.Controls.Add(Me.labCategorie)
        Me.Controls.Add(Me.labTitre)
        Me.Controls.Add(Me.texTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details du projet"
        CType(Me.dgvProjectRemarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProjectRessources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProjectEstimatedResources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VprojectestimatedresourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents texTitre As TextBox
    Friend WithEvents labTitre As Label
    Friend WithEvents labCategorie As Label
    Friend WithEvents labDescription As Label
    Friend WithEvents texDescription As TextBox
    Friend WithEvents labDeadline As Label
    Friend WithEvents dtpDeadline As DateTimePicker
    Friend WithEvents lovProjectManager As ComboBox
    Friend WithEvents labChefProjet As Label
    Friend WithEvents labStatut As Label
    Friend WithEvents lovStatus As ComboBox
    Friend WithEvents btcAnnuler As Button
    Friend WithEvents btcOK As Button
    Friend WithEvents labImplementationRate As Label
    Friend WithEvents texImplementationRate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents labID_Project As Label
    Friend WithEvents texID_Project As TextBox
    Friend WithEvents lovPriority As ComboBox
    Friend WithEvents labPriority As Label
    Friend WithEvents lovProjectCategory As ComboBox
    Friend WithEvents labClient As Label
    Friend WithEvents lovCustomer As ComboBox
    Friend WithEvents texPlanResources As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents labPlanResources As Label
    Friend WithEvents labExecutedResources As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents texExecutedResources As TextBox
    Friend WithEvents btcComments As Button
    Friend WithEvents lovUrgency As ComboBox
    Friend WithEvents labUrgency As Label
    Friend WithEvents dtpBegin As DateTimePicker
    Friend WithEvents labBegin As Label
    Friend WithEvents labRemarks As Label
    Friend WithEvents dgvProjectRemarks As DataGridView
    Friend WithEvents btcRemarkAdd As Button
    Friend WithEvents btcRemarkRemove As Button
    Friend WithEvents btcRemardModify As Button
    Friend WithEvents btcRessourceModify As Button
    Friend WithEvents btcRessourceRemove As Button
    Friend WithEvents btcRessourceAdd As Button
    Friend WithEvents dgvProjectRessources As DataGridView
    Friend WithEvents labRessources As Label
    Friend WithEvents labEstimatedResources As Label
    Friend WithEvents texEstimatedResources As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DsProjectEstimatedResources As dsProjectEstimatedResources
    Friend WithEvents VprojectestimatedresourcesBindingSource As BindingSource
    Friend WithEvents VprojectestimatedresourcesTableAdapter As dsProjectEstimatedResourcesTableAdapters.vprojectestimatedresourcesTableAdapter
    Friend WithEvents IDResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDProjectDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEIDTaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaskDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstimatedResourceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastModifyDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
