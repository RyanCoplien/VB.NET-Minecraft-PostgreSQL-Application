<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseProject
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim HealthLabel As System.Windows.Forms.Label
        Dim Can_be_bredLabel As System.Windows.Forms.Label
        Dim Mob_type_idLabel As System.Windows.Forms.Label
        Dim Mob_aggression_idLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label36 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim Label41 As System.Windows.Forms.Label
        Dim Label42 As System.Windows.Forms.Label
        Dim Label46 As System.Windows.Forms.Label
        Dim Label47 As System.Windows.Forms.Label
        Dim Label51 As System.Windows.Forms.Label
        Dim Label52 As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnBiomesDelete = New System.Windows.Forms.Button()
        Me.btnBiomesUpdate = New System.Windows.Forms.Button()
        Me.btnBiomesInsert = New System.Windows.Forms.Button()
        Me.txtBoxBiomesName = New System.Windows.Forms.TextBox()
        Me.txtBoxBiomesTemp = New System.Windows.Forms.TextBox()
        Me.txtBoxBiomesTypeID = New System.Windows.Forms.TextBox()
        Me.BiomesDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBlocksUpdate = New System.Windows.Forms.Button()
        Me.btnBlocksInsert = New System.Windows.Forms.Button()
        Me.txtBoxBlocksName = New System.Windows.Forms.TextBox()
        Me.BlocksDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnItemsDelete = New System.Windows.Forms.Button()
        Me.btnItemsUpdate = New System.Windows.Forms.Button()
        Me.btnItemsInsert = New System.Windows.Forms.Button()
        Me.txtBoxItemsName = New System.Windows.Forms.TextBox()
        Me.ItemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnMobsDelete = New System.Windows.Forms.Button()
        Me.btnMobsUpdate = New System.Windows.Forms.Button()
        Me.btnMobsInsert = New System.Windows.Forms.Button()
        Me.txtBoxNameMobs = New System.Windows.Forms.TextBox()
        Me.txtBoxHealthMobs = New System.Windows.Forms.TextBox()
        Me.txtBoxBredMobs = New System.Windows.Forms.TextBox()
        Me.txtBoxTypeMobs = New System.Windows.Forms.TextBox()
        Me.txtBoxAggMobs = New System.Windows.Forms.TextBox()
        Me.MobsDataGridView = New System.Windows.Forms.DataGridView()
        Me.MobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnBiomeTypesDelete = New System.Windows.Forms.Button()
        Me.btnBiomeTypesUpdate = New System.Windows.Forms.Button()
        Me.btnBiomeTypesInsert = New System.Windows.Forms.Button()
        Me.txtBoxBiomeTypesName = New System.Windows.Forms.TextBox()
        Me.Biome_typesDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnBiomeBlocksDelete = New System.Windows.Forms.Button()
        Me.btnBiomeBlocksUpdate = New System.Windows.Forms.Button()
        Me.btnBiomeBlocksInsert = New System.Windows.Forms.Button()
        Me.txtBoxBiomeBlocksBlockID = New System.Windows.Forms.TextBox()
        Me.txtBoxBiomeBlocksBiomeID = New System.Windows.Forms.TextBox()
        Me.Biome_blocksDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btnMobAggDelete = New System.Windows.Forms.Button()
        Me.btnMobAggUpdate = New System.Windows.Forms.Button()
        Me.btnMobAggInsert = New System.Windows.Forms.Button()
        Me.txtBoxMobAggName = New System.Windows.Forms.TextBox()
        Me.Mob_aggressionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.btnMobTypesDelete = New System.Windows.Forms.Button()
        Me.btnMobTypesUpdate = New System.Windows.Forms.Button()
        Me.btnMobTypesInsert = New System.Windows.Forms.Button()
        Me.txtBoxMobTypesName = New System.Windows.Forms.TextBox()
        Me.Mob_typesDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.btnMobBreedItemsDelete = New System.Windows.Forms.Button()
        Me.btnMobBreedUpdate = New System.Windows.Forms.Button()
        Me.btnMobBreedInsert = New System.Windows.Forms.Button()
        Me.txtBoxMobBreedMobID = New System.Windows.Forms.TextBox()
        Me.txtBoxMobBreedBreedID = New System.Windows.Forms.TextBox()
        Me.Mob_breeding_itemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.btnBrewRecDelete = New System.Windows.Forms.Button()
        Me.btnBrewRecUpdate = New System.Windows.Forms.Button()
        Me.btnBrewRecInsert = New System.Windows.Forms.Button()
        Me.txtBoxBrewRecPotionID = New System.Windows.Forms.TextBox()
        Me.txtBoxBrewRecIngredID = New System.Windows.Forms.TextBox()
        Me.Brewing_recipiesDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.btnMobItemDropsDelete = New System.Windows.Forms.Button()
        Me.btnMobItemDropsUpdate = New System.Windows.Forms.Button()
        Me.btnMobItemDropsInsert = New System.Windows.Forms.Button()
        Me.txtBoxMobitemDropsMobID = New System.Windows.Forms.TextBox()
        Me.txtBoxMobItemDropsDropItemID = New System.Windows.Forms.TextBox()
        Me.Mob_item_dropsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.btnBiomeMobsDelete = New System.Windows.Forms.Button()
        Me.btnBiomeMobsUpdate = New System.Windows.Forms.Button()
        Me.btnBiomeMobsInsert = New System.Windows.Forms.Button()
        Me.txtBoxBiomeMobsBiomeID = New System.Windows.Forms.TextBox()
        Me.txtBoxBiomeMobsMobID = New System.Windows.Forms.TextBox()
        Me.Biome_mobsDataGridView = New System.Windows.Forms.DataGridView()
        Me.lblInsert = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BiomesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Team_09DataSet = New Team_09_Course_Project.team_09DataSet()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HealthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanbebredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobtypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobaggressionidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdatedatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeletedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Team09DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biome_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biome_blocksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mob_aggressionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mob_typesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mob_breeding_itemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brewing_recipiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mob_item_dropsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Biome_mobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobsTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.mobsTableAdapter()
        Me.TableAdapterManager = New Team_09_Course_Project.team_09DataSetTableAdapters.TableAdapterManager()
        Me.BiomesTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.biomesTableAdapter()
        Me.BlocksTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.blocksTableAdapter()
        Me.Biome_typesTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.biome_typesTableAdapter()
        Me.Biome_blocksTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.biome_blocksTableAdapter()
        Me.Mob_aggressionsTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.mob_aggressionsTableAdapter()
        Me.Mob_typesTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.mob_typesTableAdapter()
        Me.Mob_breeding_itemsTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.mob_breeding_itemsTableAdapter()
        Me.Brewing_recipiesTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.brewing_recipiesTableAdapter()
        Me.Mob_item_dropsTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.mob_item_dropsTableAdapter()
        Me.Biome_mobsTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.biome_mobsTableAdapter()
        Me.ItemsTableAdapter = New Team_09_Course_Project.team_09DataSetTableAdapters.itemsTableAdapter()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.DataGridViewSelect = New System.Windows.Forms.DataGridView()
        Me.comboBoxMainTable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxViewCustom = New System.Windows.Forms.TextBox()
        Me.btnViewRun = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        HealthLabel = New System.Windows.Forms.Label()
        Can_be_bredLabel = New System.Windows.Forms.Label()
        Mob_type_idLabel = New System.Windows.Forms.Label()
        Mob_aggression_idLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label36 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        Label41 = New System.Windows.Forms.Label()
        Label42 = New System.Windows.Forms.Label()
        Label46 = New System.Windows.Forms.Label()
        Label47 = New System.Windows.Forms.Label()
        Label51 = New System.Windows.Forms.Label()
        Label52 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BiomesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BlocksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.MobsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Biome_typesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.Biome_blocksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.Mob_aggressionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.Mob_typesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.Mob_breeding_itemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage10.SuspendLayout()
        CType(Me.Brewing_recipiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        CType(Me.Mob_item_dropsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage12.SuspendLayout()
        CType(Me.Biome_mobsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BiomesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Team_09DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Team09DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biome_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biome_blocksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mob_aggressionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mob_typesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mob_breeding_itemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Brewing_recipiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mob_item_dropsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Biome_mobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage13.SuspendLayout()
        CType(Me.DataGridViewSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(47, 29)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'HealthLabel
        '
        HealthLabel.AutoSize = True
        HealthLabel.Location = New System.Drawing.Point(47, 55)
        HealthLabel.Name = "HealthLabel"
        HealthLabel.Size = New System.Drawing.Size(41, 13)
        HealthLabel.TabIndex = 5
        HealthLabel.Text = "Health:"
        '
        'Can_be_bredLabel
        '
        Can_be_bredLabel.AutoSize = True
        Can_be_bredLabel.Location = New System.Drawing.Point(47, 77)
        Can_be_bredLabel.Name = "Can_be_bredLabel"
        Can_be_bredLabel.Size = New System.Drawing.Size(70, 13)
        Can_be_bredLabel.TabIndex = 7
        Can_be_bredLabel.Text = "Can Be Bred:"
        '
        'Mob_type_idLabel
        '
        Mob_type_idLabel.AutoSize = True
        Mob_type_idLabel.Location = New System.Drawing.Point(47, 130)
        Mob_type_idLabel.Name = "Mob_type_idLabel"
        Mob_type_idLabel.Size = New System.Drawing.Size(72, 13)
        Mob_type_idLabel.TabIndex = 9
        Mob_type_idLabel.Text = "Mob Type ID:"
        '
        'Mob_aggression_idLabel
        '
        Mob_aggression_idLabel.AutoSize = True
        Mob_aggression_idLabel.Location = New System.Drawing.Point(47, 104)
        Mob_aggression_idLabel.Name = "Mob_aggression_idLabel"
        Mob_aggression_idLabel.Size = New System.Drawing.Size(100, 13)
        Mob_aggression_idLabel.TabIndex = 11
        Mob_aggression_idLabel.Text = "Mob Aggression ID:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(63, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(38, 13)
        Label1.TabIndex = 15
        Label1.Text = "Name:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(63, 48)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(70, 13)
        Label2.TabIndex = 17
        Label2.Text = "Temperature:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(63, 70)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(80, 13)
        Label3.TabIndex = 19
        Label3.Text = "Biome Type ID:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(58, 26)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(38, 13)
        Label6.TabIndex = 15
        Label6.Text = "Name:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(42, 24)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(38, 13)
        Label11.TabIndex = 15
        Label11.Text = "Name:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(43, 30)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(38, 13)
        Label16.TabIndex = 15
        Label16.Text = "Name:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Location = New System.Drawing.Point(45, 25)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(51, 13)
        Label21.TabIndex = 15
        Label21.Text = "Block ID:"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Location = New System.Drawing.Point(45, 51)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(53, 13)
        Label22.TabIndex = 17
        Label22.Text = "Biome ID:"
        '
        'Label26
        '
        Label26.AutoSize = True
        Label26.Location = New System.Drawing.Point(58, 29)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(38, 13)
        Label26.TabIndex = 15
        Label26.Text = "Name:"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Location = New System.Drawing.Point(46, 29)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(38, 13)
        Label31.TabIndex = 15
        Label31.Text = "Name:"
        '
        'Label36
        '
        Label36.AutoSize = True
        Label36.Location = New System.Drawing.Point(50, 26)
        Label36.Name = "Label36"
        Label36.Size = New System.Drawing.Size(45, 13)
        Label36.TabIndex = 15
        Label36.Text = "Mob ID:"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Location = New System.Drawing.Point(50, 52)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(89, 13)
        Label37.TabIndex = 17
        Label37.Text = "Breeding Item ID:"
        '
        'Label41
        '
        Label41.AutoSize = True
        Label41.Location = New System.Drawing.Point(42, 30)
        Label41.Name = "Label41"
        Label41.Size = New System.Drawing.Size(77, 13)
        Label41.TabIndex = 15
        Label41.Text = "Potion Item ID:"
        '
        'Label42
        '
        Label42.AutoSize = True
        Label42.Location = New System.Drawing.Point(42, 56)
        Label42.Name = "Label42"
        Label42.Size = New System.Drawing.Size(94, 13)
        Label42.TabIndex = 17
        Label42.Text = "Ingredient Item ID:"
        '
        'Label46
        '
        Label46.AutoSize = True
        Label46.Location = New System.Drawing.Point(41, 35)
        Label46.Name = "Label46"
        Label46.Size = New System.Drawing.Size(45, 13)
        Label46.TabIndex = 15
        Label46.Text = "Mob ID:"
        '
        'Label47
        '
        Label47.AutoSize = True
        Label47.Location = New System.Drawing.Point(41, 61)
        Label47.Name = "Label47"
        Label47.Size = New System.Drawing.Size(70, 13)
        Label47.TabIndex = 17
        Label47.Text = "Drop Item ID:"
        '
        'Label51
        '
        Label51.AutoSize = True
        Label51.Location = New System.Drawing.Point(42, 34)
        Label51.Name = "Label51"
        Label51.Size = New System.Drawing.Size(53, 13)
        Label51.TabIndex = 15
        Label51.Text = "Biome ID:"
        '
        'Label52
        '
        Label52.AutoSize = True
        Label52.Location = New System.Drawing.Point(42, 60)
        Label52.Name = "Label52"
        Label52.Size = New System.Drawing.Size(45, 13)
        Label52.TabIndex = 17
        Label52.Text = "Mob ID:"
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.TabControl1.Controls.Add(Me.TabPage13)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Location = New System.Drawing.Point(1, -1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(809, 493)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.btnBiomesDelete)
        Me.TabPage1.Controls.Add(Me.btnBiomesUpdate)
        Me.TabPage1.Controls.Add(Me.btnBiomesInsert)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.txtBoxBiomesName)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(Me.txtBoxBiomesTemp)
        Me.TabPage1.Controls.Add(Label3)
        Me.TabPage1.Controls.Add(Me.txtBoxBiomesTypeID)
        Me.TabPage1.Controls.Add(Me.BiomesDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(801, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Biomes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnBiomesDelete
        '
        Me.btnBiomesDelete.Location = New System.Drawing.Point(596, 13)
        Me.btnBiomesDelete.Name = "btnBiomesDelete"
        Me.btnBiomesDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomesDelete.TabIndex = 27
        Me.btnBiomesDelete.Text = "Delete Selected Row"
        Me.btnBiomesDelete.UseVisualStyleBackColor = True
        '
        'btnBiomesUpdate
        '
        Me.btnBiomesUpdate.Location = New System.Drawing.Point(460, 48)
        Me.btnBiomesUpdate.Name = "btnBiomesUpdate"
        Me.btnBiomesUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomesUpdate.TabIndex = 26
        Me.btnBiomesUpdate.Text = "Update"
        Me.btnBiomesUpdate.UseVisualStyleBackColor = True
        '
        'btnBiomesInsert
        '
        Me.btnBiomesInsert.Location = New System.Drawing.Point(460, 13)
        Me.btnBiomesInsert.Name = "btnBiomesInsert"
        Me.btnBiomesInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomesInsert.TabIndex = 25
        Me.btnBiomesInsert.Text = "Insert"
        Me.btnBiomesInsert.UseVisualStyleBackColor = True
        '
        'txtBoxBiomesName
        '
        Me.txtBoxBiomesName.Location = New System.Drawing.Point(164, 15)
        Me.txtBoxBiomesName.Name = "txtBoxBiomesName"
        Me.txtBoxBiomesName.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomesName.TabIndex = 16
        '
        'txtBoxBiomesTemp
        '
        Me.txtBoxBiomesTemp.Location = New System.Drawing.Point(164, 41)
        Me.txtBoxBiomesTemp.Name = "txtBoxBiomesTemp"
        Me.txtBoxBiomesTemp.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomesTemp.TabIndex = 18
        '
        'txtBoxBiomesTypeID
        '
        Me.txtBoxBiomesTypeID.Location = New System.Drawing.Point(164, 67)
        Me.txtBoxBiomesTypeID.Name = "txtBoxBiomesTypeID"
        Me.txtBoxBiomesTypeID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomesTypeID.TabIndex = 20
        '
        'BiomesDataGridView
        '
        Me.BiomesDataGridView.AllowUserToAddRows = False
        Me.BiomesDataGridView.AllowUserToDeleteRows = False
        Me.BiomesDataGridView.AutoGenerateColumns = False
        Me.BiomesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BiomesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.BiomesDataGridView.DataSource = Me.BiomesBindingSource
        Me.BiomesDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.BiomesDataGridView.Name = "BiomesDataGridView"
        Me.BiomesDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.BiomesDataGridView.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.btnBlocksUpdate)
        Me.TabPage2.Controls.Add(Me.btnBlocksInsert)
        Me.TabPage2.Controls.Add(Label6)
        Me.TabPage2.Controls.Add(Me.txtBoxBlocksName)
        Me.TabPage2.Controls.Add(Me.BlocksDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(801, 467)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Blocks"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(593, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Delete Selected Row"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBlocksUpdate
        '
        Me.btnBlocksUpdate.Location = New System.Drawing.Point(455, 52)
        Me.btnBlocksUpdate.Name = "btnBlocksUpdate"
        Me.btnBlocksUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnBlocksUpdate.TabIndex = 26
        Me.btnBlocksUpdate.Text = "Update"
        Me.btnBlocksUpdate.UseVisualStyleBackColor = True
        '
        'btnBlocksInsert
        '
        Me.btnBlocksInsert.Location = New System.Drawing.Point(455, 17)
        Me.btnBlocksInsert.Name = "btnBlocksInsert"
        Me.btnBlocksInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnBlocksInsert.TabIndex = 25
        Me.btnBlocksInsert.Text = "Insert"
        Me.btnBlocksInsert.UseVisualStyleBackColor = True
        '
        'txtBoxBlocksName
        '
        Me.txtBoxBlocksName.Location = New System.Drawing.Point(159, 19)
        Me.txtBoxBlocksName.Name = "txtBoxBlocksName"
        Me.txtBoxBlocksName.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBlocksName.TabIndex = 16
        '
        'BlocksDataGridView
        '
        Me.BlocksDataGridView.AllowUserToAddRows = False
        Me.BlocksDataGridView.AllowUserToDeleteRows = False
        Me.BlocksDataGridView.AutoGenerateColumns = False
        Me.BlocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BlocksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.BlocksDataGridView.DataSource = Me.BlocksBindingSource
        Me.BlocksDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.BlocksDataGridView.Name = "BlocksDataGridView"
        Me.BlocksDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.BlocksDataGridView.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnItemsDelete)
        Me.TabPage3.Controls.Add(Me.btnItemsUpdate)
        Me.TabPage3.Controls.Add(Me.btnItemsInsert)
        Me.TabPage3.Controls.Add(Label11)
        Me.TabPage3.Controls.Add(Me.txtBoxItemsName)
        Me.TabPage3.Controls.Add(Me.ItemsDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(801, 467)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Items"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnItemsDelete
        '
        Me.btnItemsDelete.Location = New System.Drawing.Point(574, 15)
        Me.btnItemsDelete.Name = "btnItemsDelete"
        Me.btnItemsDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnItemsDelete.TabIndex = 28
        Me.btnItemsDelete.Text = "Delete Selected Row"
        Me.btnItemsDelete.UseVisualStyleBackColor = True
        '
        'btnItemsUpdate
        '
        Me.btnItemsUpdate.Location = New System.Drawing.Point(439, 50)
        Me.btnItemsUpdate.Name = "btnItemsUpdate"
        Me.btnItemsUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnItemsUpdate.TabIndex = 26
        Me.btnItemsUpdate.Text = "Update"
        Me.btnItemsUpdate.UseVisualStyleBackColor = True
        '
        'btnItemsInsert
        '
        Me.btnItemsInsert.Location = New System.Drawing.Point(439, 15)
        Me.btnItemsInsert.Name = "btnItemsInsert"
        Me.btnItemsInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnItemsInsert.TabIndex = 25
        Me.btnItemsInsert.Text = "Insert"
        Me.btnItemsInsert.UseVisualStyleBackColor = True
        '
        'txtBoxItemsName
        '
        Me.txtBoxItemsName.Location = New System.Drawing.Point(143, 17)
        Me.txtBoxItemsName.Name = "txtBoxItemsName"
        Me.txtBoxItemsName.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxItemsName.TabIndex = 16
        '
        'ItemsDataGridView
        '
        Me.ItemsDataGridView.AllowUserToAddRows = False
        Me.ItemsDataGridView.AllowUserToDeleteRows = False
        Me.ItemsDataGridView.AutoGenerateColumns = False
        Me.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn58, Me.DataGridViewTextBoxColumn59, Me.DataGridViewTextBoxColumn60, Me.DataGridViewTextBoxColumn61, Me.DataGridViewTextBoxColumn62})
        Me.ItemsDataGridView.DataSource = Me.ItemsBindingSource
        Me.ItemsDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.ItemsDataGridView.Name = "ItemsDataGridView"
        Me.ItemsDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.ItemsDataGridView.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.btnMobsDelete)
        Me.TabPage4.Controls.Add(Me.btnMobsUpdate)
        Me.TabPage4.Controls.Add(Me.btnMobsInsert)
        Me.TabPage4.Controls.Add(NameLabel)
        Me.TabPage4.Controls.Add(Me.txtBoxNameMobs)
        Me.TabPage4.Controls.Add(HealthLabel)
        Me.TabPage4.Controls.Add(Me.txtBoxHealthMobs)
        Me.TabPage4.Controls.Add(Can_be_bredLabel)
        Me.TabPage4.Controls.Add(Me.txtBoxBredMobs)
        Me.TabPage4.Controls.Add(Mob_type_idLabel)
        Me.TabPage4.Controls.Add(Me.txtBoxTypeMobs)
        Me.TabPage4.Controls.Add(Mob_aggression_idLabel)
        Me.TabPage4.Controls.Add(Me.txtBoxAggMobs)
        Me.TabPage4.Controls.Add(Me.MobsDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(801, 467)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Mobs"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnMobsDelete
        '
        Me.btnMobsDelete.Location = New System.Drawing.Point(579, 20)
        Me.btnMobsDelete.Name = "btnMobsDelete"
        Me.btnMobsDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnMobsDelete.TabIndex = 28
        Me.btnMobsDelete.Text = "Delete Selected Row"
        Me.btnMobsDelete.UseVisualStyleBackColor = True
        '
        'btnMobsUpdate
        '
        Me.btnMobsUpdate.Location = New System.Drawing.Point(444, 55)
        Me.btnMobsUpdate.Name = "btnMobsUpdate"
        Me.btnMobsUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnMobsUpdate.TabIndex = 14
        Me.btnMobsUpdate.Text = "Update"
        Me.btnMobsUpdate.UseVisualStyleBackColor = True
        '
        'btnMobsInsert
        '
        Me.btnMobsInsert.Location = New System.Drawing.Point(444, 20)
        Me.btnMobsInsert.Name = "btnMobsInsert"
        Me.btnMobsInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnMobsInsert.TabIndex = 13
        Me.btnMobsInsert.Text = "Insert"
        Me.btnMobsInsert.UseVisualStyleBackColor = True
        '
        'txtBoxNameMobs
        '
        Me.txtBoxNameMobs.Location = New System.Drawing.Point(148, 22)
        Me.txtBoxNameMobs.Name = "txtBoxNameMobs"
        Me.txtBoxNameMobs.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxNameMobs.TabIndex = 4
        '
        'txtBoxHealthMobs
        '
        Me.txtBoxHealthMobs.Location = New System.Drawing.Point(148, 48)
        Me.txtBoxHealthMobs.Name = "txtBoxHealthMobs"
        Me.txtBoxHealthMobs.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxHealthMobs.TabIndex = 6
        '
        'txtBoxBredMobs
        '
        Me.txtBoxBredMobs.Location = New System.Drawing.Point(148, 74)
        Me.txtBoxBredMobs.Name = "txtBoxBredMobs"
        Me.txtBoxBredMobs.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBredMobs.TabIndex = 8
        '
        'txtBoxTypeMobs
        '
        Me.txtBoxTypeMobs.Location = New System.Drawing.Point(148, 123)
        Me.txtBoxTypeMobs.Name = "txtBoxTypeMobs"
        Me.txtBoxTypeMobs.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxTypeMobs.TabIndex = 10
        '
        'txtBoxAggMobs
        '
        Me.txtBoxAggMobs.Location = New System.Drawing.Point(148, 97)
        Me.txtBoxAggMobs.Name = "txtBoxAggMobs"
        Me.txtBoxAggMobs.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxAggMobs.TabIndex = 12
        '
        'MobsDataGridView
        '
        Me.MobsDataGridView.AllowUserToAddRows = False
        Me.MobsDataGridView.AllowUserToDeleteRows = False
        Me.MobsDataGridView.AutoGenerateColumns = False
        Me.MobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MobsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.HealthDataGridViewTextBoxColumn, Me.CanbebredDataGridViewTextBoxColumn, Me.MobtypeidDataGridViewTextBoxColumn, Me.MobaggressionidDataGridViewTextBoxColumn, Me.CreatedatDataGridViewTextBoxColumn, Me.UpdatedatDataGridViewTextBoxColumn, Me.DeletedDataGridViewTextBoxColumn})
        Me.MobsDataGridView.DataSource = Me.MobsBindingSource
        Me.MobsDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.MobsDataGridView.Name = "MobsDataGridView"
        Me.MobsDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.MobsDataGridView.TabIndex = 0
        '
        'MobsBindingSource
        '
        Me.MobsBindingSource.DataMember = "mobs"
        Me.MobsBindingSource.DataSource = Me.Team09DataSetBindingSource
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.btnBiomeTypesDelete)
        Me.TabPage5.Controls.Add(Me.btnBiomeTypesUpdate)
        Me.TabPage5.Controls.Add(Me.btnBiomeTypesInsert)
        Me.TabPage5.Controls.Add(Label16)
        Me.TabPage5.Controls.Add(Me.txtBoxBiomeTypesName)
        Me.TabPage5.Controls.Add(Me.Biome_typesDataGridView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(801, 467)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Biome Types"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnBiomeTypesDelete
        '
        Me.btnBiomeTypesDelete.Location = New System.Drawing.Point(576, 21)
        Me.btnBiomeTypesDelete.Name = "btnBiomeTypesDelete"
        Me.btnBiomeTypesDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeTypesDelete.TabIndex = 28
        Me.btnBiomeTypesDelete.Text = "Delete Selected Row"
        Me.btnBiomeTypesDelete.UseVisualStyleBackColor = True
        '
        'btnBiomeTypesUpdate
        '
        Me.btnBiomeTypesUpdate.Location = New System.Drawing.Point(440, 56)
        Me.btnBiomeTypesUpdate.Name = "btnBiomeTypesUpdate"
        Me.btnBiomeTypesUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeTypesUpdate.TabIndex = 26
        Me.btnBiomeTypesUpdate.Text = "Update"
        Me.btnBiomeTypesUpdate.UseVisualStyleBackColor = True
        '
        'btnBiomeTypesInsert
        '
        Me.btnBiomeTypesInsert.Location = New System.Drawing.Point(440, 21)
        Me.btnBiomeTypesInsert.Name = "btnBiomeTypesInsert"
        Me.btnBiomeTypesInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeTypesInsert.TabIndex = 25
        Me.btnBiomeTypesInsert.Text = "Insert"
        Me.btnBiomeTypesInsert.UseVisualStyleBackColor = True
        '
        'txtBoxBiomeTypesName
        '
        Me.txtBoxBiomeTypesName.Location = New System.Drawing.Point(144, 23)
        Me.txtBoxBiomeTypesName.Name = "txtBoxBiomeTypesName"
        Me.txtBoxBiomeTypesName.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomeTypesName.TabIndex = 16
        '
        'Biome_typesDataGridView
        '
        Me.Biome_typesDataGridView.AllowUserToAddRows = False
        Me.Biome_typesDataGridView.AllowUserToDeleteRows = False
        Me.Biome_typesDataGridView.AutoGenerateColumns = False
        Me.Biome_typesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Biome_typesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.Biome_typesDataGridView.DataSource = Me.Biome_typesBindingSource
        Me.Biome_typesDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Biome_typesDataGridView.Name = "Biome_typesDataGridView"
        Me.Biome_typesDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Biome_typesDataGridView.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnBiomeBlocksDelete)
        Me.TabPage6.Controls.Add(Me.btnBiomeBlocksUpdate)
        Me.TabPage6.Controls.Add(Me.btnBiomeBlocksInsert)
        Me.TabPage6.Controls.Add(Label21)
        Me.TabPage6.Controls.Add(Me.txtBoxBiomeBlocksBlockID)
        Me.TabPage6.Controls.Add(Label22)
        Me.TabPage6.Controls.Add(Me.txtBoxBiomeBlocksBiomeID)
        Me.TabPage6.Controls.Add(Me.Biome_blocksDataGridView)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(801, 467)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Biome Blocks"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnBiomeBlocksDelete
        '
        Me.btnBiomeBlocksDelete.Location = New System.Drawing.Point(577, 16)
        Me.btnBiomeBlocksDelete.Name = "btnBiomeBlocksDelete"
        Me.btnBiomeBlocksDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeBlocksDelete.TabIndex = 28
        Me.btnBiomeBlocksDelete.Text = "Delete Selected Row"
        Me.btnBiomeBlocksDelete.UseVisualStyleBackColor = True
        '
        'btnBiomeBlocksUpdate
        '
        Me.btnBiomeBlocksUpdate.Location = New System.Drawing.Point(442, 51)
        Me.btnBiomeBlocksUpdate.Name = "btnBiomeBlocksUpdate"
        Me.btnBiomeBlocksUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeBlocksUpdate.TabIndex = 26
        Me.btnBiomeBlocksUpdate.Text = "Update"
        Me.btnBiomeBlocksUpdate.UseVisualStyleBackColor = True
        '
        'btnBiomeBlocksInsert
        '
        Me.btnBiomeBlocksInsert.Location = New System.Drawing.Point(442, 16)
        Me.btnBiomeBlocksInsert.Name = "btnBiomeBlocksInsert"
        Me.btnBiomeBlocksInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeBlocksInsert.TabIndex = 25
        Me.btnBiomeBlocksInsert.Text = "Insert"
        Me.btnBiomeBlocksInsert.UseVisualStyleBackColor = True
        '
        'txtBoxBiomeBlocksBlockID
        '
        Me.txtBoxBiomeBlocksBlockID.Location = New System.Drawing.Point(146, 18)
        Me.txtBoxBiomeBlocksBlockID.Name = "txtBoxBiomeBlocksBlockID"
        Me.txtBoxBiomeBlocksBlockID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomeBlocksBlockID.TabIndex = 16
        '
        'txtBoxBiomeBlocksBiomeID
        '
        Me.txtBoxBiomeBlocksBiomeID.Location = New System.Drawing.Point(146, 44)
        Me.txtBoxBiomeBlocksBiomeID.Name = "txtBoxBiomeBlocksBiomeID"
        Me.txtBoxBiomeBlocksBiomeID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomeBlocksBiomeID.TabIndex = 18
        '
        'Biome_blocksDataGridView
        '
        Me.Biome_blocksDataGridView.AllowUserToAddRows = False
        Me.Biome_blocksDataGridView.AllowUserToDeleteRows = False
        Me.Biome_blocksDataGridView.AutoGenerateColumns = False
        Me.Biome_blocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Biome_blocksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.Biome_blocksDataGridView.DataSource = Me.Biome_blocksBindingSource
        Me.Biome_blocksDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Biome_blocksDataGridView.Name = "Biome_blocksDataGridView"
        Me.Biome_blocksDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Biome_blocksDataGridView.TabIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.AutoScroll = True
        Me.TabPage7.Controls.Add(Me.btnMobAggDelete)
        Me.TabPage7.Controls.Add(Me.btnMobAggUpdate)
        Me.TabPage7.Controls.Add(Me.btnMobAggInsert)
        Me.TabPage7.Controls.Add(Label26)
        Me.TabPage7.Controls.Add(Me.txtBoxMobAggName)
        Me.TabPage7.Controls.Add(Me.Mob_aggressionsDataGridView)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(801, 467)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "Mob Aggressions"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'btnMobAggDelete
        '
        Me.btnMobAggDelete.Location = New System.Drawing.Point(589, 20)
        Me.btnMobAggDelete.Name = "btnMobAggDelete"
        Me.btnMobAggDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnMobAggDelete.TabIndex = 28
        Me.btnMobAggDelete.Text = "Delete Selected Row"
        Me.btnMobAggDelete.UseVisualStyleBackColor = True
        '
        'btnMobAggUpdate
        '
        Me.btnMobAggUpdate.Location = New System.Drawing.Point(455, 55)
        Me.btnMobAggUpdate.Name = "btnMobAggUpdate"
        Me.btnMobAggUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnMobAggUpdate.TabIndex = 26
        Me.btnMobAggUpdate.Text = "Update"
        Me.btnMobAggUpdate.UseVisualStyleBackColor = True
        '
        'btnMobAggInsert
        '
        Me.btnMobAggInsert.Location = New System.Drawing.Point(455, 20)
        Me.btnMobAggInsert.Name = "btnMobAggInsert"
        Me.btnMobAggInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnMobAggInsert.TabIndex = 25
        Me.btnMobAggInsert.Text = "Insert"
        Me.btnMobAggInsert.UseVisualStyleBackColor = True
        '
        'txtBoxMobAggName
        '
        Me.txtBoxMobAggName.Location = New System.Drawing.Point(159, 22)
        Me.txtBoxMobAggName.Name = "txtBoxMobAggName"
        Me.txtBoxMobAggName.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxMobAggName.TabIndex = 16
        '
        'Mob_aggressionsDataGridView
        '
        Me.Mob_aggressionsDataGridView.AllowUserToAddRows = False
        Me.Mob_aggressionsDataGridView.AllowUserToDeleteRows = False
        Me.Mob_aggressionsDataGridView.AutoGenerateColumns = False
        Me.Mob_aggressionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mob_aggressionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.Mob_aggressionsDataGridView.DataSource = Me.Mob_aggressionsBindingSource
        Me.Mob_aggressionsDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Mob_aggressionsDataGridView.Name = "Mob_aggressionsDataGridView"
        Me.Mob_aggressionsDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Mob_aggressionsDataGridView.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.btnMobTypesDelete)
        Me.TabPage8.Controls.Add(Me.btnMobTypesUpdate)
        Me.TabPage8.Controls.Add(Me.btnMobTypesInsert)
        Me.TabPage8.Controls.Add(Label31)
        Me.TabPage8.Controls.Add(Me.txtBoxMobTypesName)
        Me.TabPage8.Controls.Add(Me.Mob_typesDataGridView)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(801, 467)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "Mob Types"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnMobTypesDelete
        '
        Me.btnMobTypesDelete.Location = New System.Drawing.Point(578, 20)
        Me.btnMobTypesDelete.Name = "btnMobTypesDelete"
        Me.btnMobTypesDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnMobTypesDelete.TabIndex = 28
        Me.btnMobTypesDelete.Text = "Delete Selected Row"
        Me.btnMobTypesDelete.UseVisualStyleBackColor = True
        '
        'btnMobTypesUpdate
        '
        Me.btnMobTypesUpdate.Location = New System.Drawing.Point(443, 55)
        Me.btnMobTypesUpdate.Name = "btnMobTypesUpdate"
        Me.btnMobTypesUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnMobTypesUpdate.TabIndex = 26
        Me.btnMobTypesUpdate.Text = "Update"
        Me.btnMobTypesUpdate.UseVisualStyleBackColor = True
        '
        'btnMobTypesInsert
        '
        Me.btnMobTypesInsert.Location = New System.Drawing.Point(443, 20)
        Me.btnMobTypesInsert.Name = "btnMobTypesInsert"
        Me.btnMobTypesInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnMobTypesInsert.TabIndex = 25
        Me.btnMobTypesInsert.Text = "Insert"
        Me.btnMobTypesInsert.UseVisualStyleBackColor = True
        '
        'txtBoxMobTypesName
        '
        Me.txtBoxMobTypesName.Location = New System.Drawing.Point(147, 22)
        Me.txtBoxMobTypesName.Name = "txtBoxMobTypesName"
        Me.txtBoxMobTypesName.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxMobTypesName.TabIndex = 16
        '
        'Mob_typesDataGridView
        '
        Me.Mob_typesDataGridView.AllowUserToAddRows = False
        Me.Mob_typesDataGridView.AllowUserToDeleteRows = False
        Me.Mob_typesDataGridView.AutoGenerateColumns = False
        Me.Mob_typesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mob_typesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33})
        Me.Mob_typesDataGridView.DataSource = Me.Mob_typesBindingSource
        Me.Mob_typesDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Mob_typesDataGridView.Name = "Mob_typesDataGridView"
        Me.Mob_typesDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Mob_typesDataGridView.TabIndex = 0
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.btnMobBreedItemsDelete)
        Me.TabPage9.Controls.Add(Me.btnMobBreedUpdate)
        Me.TabPage9.Controls.Add(Me.btnMobBreedInsert)
        Me.TabPage9.Controls.Add(Label36)
        Me.TabPage9.Controls.Add(Me.txtBoxMobBreedMobID)
        Me.TabPage9.Controls.Add(Label37)
        Me.TabPage9.Controls.Add(Me.txtBoxMobBreedBreedID)
        Me.TabPage9.Controls.Add(Me.Mob_breeding_itemsDataGridView)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(801, 467)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "Mob Breeding Items"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'btnMobBreedItemsDelete
        '
        Me.btnMobBreedItemsDelete.Location = New System.Drawing.Point(582, 17)
        Me.btnMobBreedItemsDelete.Name = "btnMobBreedItemsDelete"
        Me.btnMobBreedItemsDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnMobBreedItemsDelete.TabIndex = 28
        Me.btnMobBreedItemsDelete.Text = "Delete Selected Row"
        Me.btnMobBreedItemsDelete.UseVisualStyleBackColor = True
        '
        'btnMobBreedUpdate
        '
        Me.btnMobBreedUpdate.Location = New System.Drawing.Point(447, 52)
        Me.btnMobBreedUpdate.Name = "btnMobBreedUpdate"
        Me.btnMobBreedUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnMobBreedUpdate.TabIndex = 26
        Me.btnMobBreedUpdate.Text = "Update"
        Me.btnMobBreedUpdate.UseVisualStyleBackColor = True
        '
        'btnMobBreedInsert
        '
        Me.btnMobBreedInsert.Location = New System.Drawing.Point(447, 17)
        Me.btnMobBreedInsert.Name = "btnMobBreedInsert"
        Me.btnMobBreedInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnMobBreedInsert.TabIndex = 25
        Me.btnMobBreedInsert.Text = "Insert"
        Me.btnMobBreedInsert.UseVisualStyleBackColor = True
        '
        'txtBoxMobBreedMobID
        '
        Me.txtBoxMobBreedMobID.Location = New System.Drawing.Point(151, 19)
        Me.txtBoxMobBreedMobID.Name = "txtBoxMobBreedMobID"
        Me.txtBoxMobBreedMobID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxMobBreedMobID.TabIndex = 16
        '
        'txtBoxMobBreedBreedID
        '
        Me.txtBoxMobBreedBreedID.Location = New System.Drawing.Point(151, 45)
        Me.txtBoxMobBreedBreedID.Name = "txtBoxMobBreedBreedID"
        Me.txtBoxMobBreedBreedID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxMobBreedBreedID.TabIndex = 18
        '
        'Mob_breeding_itemsDataGridView
        '
        Me.Mob_breeding_itemsDataGridView.AllowUserToAddRows = False
        Me.Mob_breeding_itemsDataGridView.AllowUserToDeleteRows = False
        Me.Mob_breeding_itemsDataGridView.AutoGenerateColumns = False
        Me.Mob_breeding_itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mob_breeding_itemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39})
        Me.Mob_breeding_itemsDataGridView.DataSource = Me.Mob_breeding_itemsBindingSource
        Me.Mob_breeding_itemsDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Mob_breeding_itemsDataGridView.Name = "Mob_breeding_itemsDataGridView"
        Me.Mob_breeding_itemsDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Mob_breeding_itemsDataGridView.TabIndex = 0
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.btnBrewRecDelete)
        Me.TabPage10.Controls.Add(Me.btnBrewRecUpdate)
        Me.TabPage10.Controls.Add(Me.btnBrewRecInsert)
        Me.TabPage10.Controls.Add(Label41)
        Me.TabPage10.Controls.Add(Me.txtBoxBrewRecPotionID)
        Me.TabPage10.Controls.Add(Label42)
        Me.TabPage10.Controls.Add(Me.txtBoxBrewRecIngredID)
        Me.TabPage10.Controls.Add(Me.Brewing_recipiesDataGridView)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(801, 467)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "Brewing Recipies"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'btnBrewRecDelete
        '
        Me.btnBrewRecDelete.Location = New System.Drawing.Point(574, 20)
        Me.btnBrewRecDelete.Name = "btnBrewRecDelete"
        Me.btnBrewRecDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnBrewRecDelete.TabIndex = 28
        Me.btnBrewRecDelete.Text = "Delete Selected Row"
        Me.btnBrewRecDelete.UseVisualStyleBackColor = True
        '
        'btnBrewRecUpdate
        '
        Me.btnBrewRecUpdate.Location = New System.Drawing.Point(439, 56)
        Me.btnBrewRecUpdate.Name = "btnBrewRecUpdate"
        Me.btnBrewRecUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnBrewRecUpdate.TabIndex = 26
        Me.btnBrewRecUpdate.Text = "Update"
        Me.btnBrewRecUpdate.UseVisualStyleBackColor = True
        '
        'btnBrewRecInsert
        '
        Me.btnBrewRecInsert.Location = New System.Drawing.Point(439, 21)
        Me.btnBrewRecInsert.Name = "btnBrewRecInsert"
        Me.btnBrewRecInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnBrewRecInsert.TabIndex = 25
        Me.btnBrewRecInsert.Text = "Insert"
        Me.btnBrewRecInsert.UseVisualStyleBackColor = True
        '
        'txtBoxBrewRecPotionID
        '
        Me.txtBoxBrewRecPotionID.Location = New System.Drawing.Point(143, 23)
        Me.txtBoxBrewRecPotionID.Name = "txtBoxBrewRecPotionID"
        Me.txtBoxBrewRecPotionID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBrewRecPotionID.TabIndex = 16
        '
        'txtBoxBrewRecIngredID
        '
        Me.txtBoxBrewRecIngredID.Location = New System.Drawing.Point(143, 49)
        Me.txtBoxBrewRecIngredID.Name = "txtBoxBrewRecIngredID"
        Me.txtBoxBrewRecIngredID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBrewRecIngredID.TabIndex = 18
        '
        'Brewing_recipiesDataGridView
        '
        Me.Brewing_recipiesDataGridView.AllowUserToAddRows = False
        Me.Brewing_recipiesDataGridView.AllowUserToDeleteRows = False
        Me.Brewing_recipiesDataGridView.AutoGenerateColumns = False
        Me.Brewing_recipiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Brewing_recipiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45})
        Me.Brewing_recipiesDataGridView.DataSource = Me.Brewing_recipiesBindingSource
        Me.Brewing_recipiesDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Brewing_recipiesDataGridView.Name = "Brewing_recipiesDataGridView"
        Me.Brewing_recipiesDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Brewing_recipiesDataGridView.TabIndex = 0
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.btnMobItemDropsDelete)
        Me.TabPage11.Controls.Add(Me.btnMobItemDropsUpdate)
        Me.TabPage11.Controls.Add(Me.btnMobItemDropsInsert)
        Me.TabPage11.Controls.Add(Label46)
        Me.TabPage11.Controls.Add(Me.txtBoxMobitemDropsMobID)
        Me.TabPage11.Controls.Add(Label47)
        Me.TabPage11.Controls.Add(Me.txtBoxMobItemDropsDropItemID)
        Me.TabPage11.Controls.Add(Me.Mob_item_dropsDataGridView)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(801, 467)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "Mob Item Drops"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'btnMobItemDropsDelete
        '
        Me.btnMobItemDropsDelete.Location = New System.Drawing.Point(576, 26)
        Me.btnMobItemDropsDelete.Name = "btnMobItemDropsDelete"
        Me.btnMobItemDropsDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnMobItemDropsDelete.TabIndex = 28
        Me.btnMobItemDropsDelete.Text = "Delete Selected Row"
        Me.btnMobItemDropsDelete.UseVisualStyleBackColor = True
        '
        'btnMobItemDropsUpdate
        '
        Me.btnMobItemDropsUpdate.Location = New System.Drawing.Point(438, 61)
        Me.btnMobItemDropsUpdate.Name = "btnMobItemDropsUpdate"
        Me.btnMobItemDropsUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnMobItemDropsUpdate.TabIndex = 26
        Me.btnMobItemDropsUpdate.Text = "Update"
        Me.btnMobItemDropsUpdate.UseVisualStyleBackColor = True
        '
        'btnMobItemDropsInsert
        '
        Me.btnMobItemDropsInsert.Location = New System.Drawing.Point(438, 26)
        Me.btnMobItemDropsInsert.Name = "btnMobItemDropsInsert"
        Me.btnMobItemDropsInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnMobItemDropsInsert.TabIndex = 25
        Me.btnMobItemDropsInsert.Text = "Insert"
        Me.btnMobItemDropsInsert.UseVisualStyleBackColor = True
        '
        'txtBoxMobitemDropsMobID
        '
        Me.txtBoxMobitemDropsMobID.Location = New System.Drawing.Point(142, 28)
        Me.txtBoxMobitemDropsMobID.Name = "txtBoxMobitemDropsMobID"
        Me.txtBoxMobitemDropsMobID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxMobitemDropsMobID.TabIndex = 16
        '
        'txtBoxMobItemDropsDropItemID
        '
        Me.txtBoxMobItemDropsDropItemID.Location = New System.Drawing.Point(142, 54)
        Me.txtBoxMobItemDropsDropItemID.Name = "txtBoxMobItemDropsDropItemID"
        Me.txtBoxMobItemDropsDropItemID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxMobItemDropsDropItemID.TabIndex = 18
        '
        'Mob_item_dropsDataGridView
        '
        Me.Mob_item_dropsDataGridView.AllowUserToAddRows = False
        Me.Mob_item_dropsDataGridView.AllowUserToDeleteRows = False
        Me.Mob_item_dropsDataGridView.AutoGenerateColumns = False
        Me.Mob_item_dropsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mob_item_dropsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn46, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51})
        Me.Mob_item_dropsDataGridView.DataSource = Me.Mob_item_dropsBindingSource
        Me.Mob_item_dropsDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Mob_item_dropsDataGridView.Name = "Mob_item_dropsDataGridView"
        Me.Mob_item_dropsDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Mob_item_dropsDataGridView.TabIndex = 0
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.btnBiomeMobsDelete)
        Me.TabPage12.Controls.Add(Me.btnBiomeMobsUpdate)
        Me.TabPage12.Controls.Add(Me.btnBiomeMobsInsert)
        Me.TabPage12.Controls.Add(Label51)
        Me.TabPage12.Controls.Add(Me.txtBoxBiomeMobsBiomeID)
        Me.TabPage12.Controls.Add(Label52)
        Me.TabPage12.Controls.Add(Me.txtBoxBiomeMobsMobID)
        Me.TabPage12.Controls.Add(Me.Biome_mobsDataGridView)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(801, 467)
        Me.TabPage12.TabIndex = 11
        Me.TabPage12.Text = "Biome Mobs"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'btnBiomeMobsDelete
        '
        Me.btnBiomeMobsDelete.Location = New System.Drawing.Point(575, 25)
        Me.btnBiomeMobsDelete.Name = "btnBiomeMobsDelete"
        Me.btnBiomeMobsDelete.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeMobsDelete.TabIndex = 28
        Me.btnBiomeMobsDelete.Text = "Delete Selected Row"
        Me.btnBiomeMobsDelete.UseVisualStyleBackColor = True
        '
        'btnBiomeMobsUpdate
        '
        Me.btnBiomeMobsUpdate.Location = New System.Drawing.Point(439, 60)
        Me.btnBiomeMobsUpdate.Name = "btnBiomeMobsUpdate"
        Me.btnBiomeMobsUpdate.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeMobsUpdate.TabIndex = 26
        Me.btnBiomeMobsUpdate.Text = "Update"
        Me.btnBiomeMobsUpdate.UseVisualStyleBackColor = True
        '
        'btnBiomeMobsInsert
        '
        Me.btnBiomeMobsInsert.Location = New System.Drawing.Point(439, 25)
        Me.btnBiomeMobsInsert.Name = "btnBiomeMobsInsert"
        Me.btnBiomeMobsInsert.Size = New System.Drawing.Size(119, 23)
        Me.btnBiomeMobsInsert.TabIndex = 25
        Me.btnBiomeMobsInsert.Text = "Insert"
        Me.btnBiomeMobsInsert.UseVisualStyleBackColor = True
        '
        'txtBoxBiomeMobsBiomeID
        '
        Me.txtBoxBiomeMobsBiomeID.Location = New System.Drawing.Point(143, 27)
        Me.txtBoxBiomeMobsBiomeID.Name = "txtBoxBiomeMobsBiomeID"
        Me.txtBoxBiomeMobsBiomeID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomeMobsBiomeID.TabIndex = 16
        '
        'txtBoxBiomeMobsMobID
        '
        Me.txtBoxBiomeMobsMobID.Location = New System.Drawing.Point(143, 53)
        Me.txtBoxBiomeMobsMobID.Name = "txtBoxBiomeMobsMobID"
        Me.txtBoxBiomeMobsMobID.Size = New System.Drawing.Size(200, 20)
        Me.txtBoxBiomeMobsMobID.TabIndex = 18
        '
        'Biome_mobsDataGridView
        '
        Me.Biome_mobsDataGridView.AllowUserToAddRows = False
        Me.Biome_mobsDataGridView.AllowUserToDeleteRows = False
        Me.Biome_mobsDataGridView.AutoGenerateColumns = False
        Me.Biome_mobsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Biome_mobsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57})
        Me.Biome_mobsDataGridView.DataSource = Me.Biome_mobsBindingSource
        Me.Biome_mobsDataGridView.Location = New System.Drawing.Point(25, 180)
        Me.Biome_mobsDataGridView.Name = "Biome_mobsDataGridView"
        Me.Biome_mobsDataGridView.Size = New System.Drawing.Size(750, 220)
        Me.Biome_mobsDataGridView.TabIndex = 0
        '
        'lblInsert
        '
        Me.lblInsert.AutoSize = True
        Me.lblInsert.Location = New System.Drawing.Point(339, 503)
        Me.lblInsert.Name = "lblInsert"
        Me.lblInsert.Size = New System.Drawing.Size(145, 13)
        Me.lblInsert.TabIndex = 14
        Me.lblInsert.Text = "Text For Inserts appears here"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "temperature"
        Me.DataGridViewTextBoxColumn3.HeaderText = "temperature"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "biome_type_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "biome_type_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn5.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn6.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn7.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'BiomesBindingSource
        '
        Me.BiomesBindingSource.DataMember = "biomes"
        Me.BiomesBindingSource.DataSource = Me.Team_09DataSet
        '
        'Team_09DataSet
        '
        Me.Team_09DataSet.DataSetName = "team_09DataSet"
        Me.Team_09DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn10.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn11.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn12.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'BlocksBindingSource
        '
        Me.BlocksBindingSource.DataMember = "blocks"
        Me.BlocksBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn58
        '
        Me.DataGridViewTextBoxColumn58.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn58.HeaderText = "id"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        '
        'DataGridViewTextBoxColumn59
        '
        Me.DataGridViewTextBoxColumn59.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn59.HeaderText = "name"
        Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
        '
        'DataGridViewTextBoxColumn60
        '
        Me.DataGridViewTextBoxColumn60.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn60.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
        '
        'DataGridViewTextBoxColumn61
        '
        Me.DataGridViewTextBoxColumn61.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn61.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
        '
        'DataGridViewTextBoxColumn62
        '
        Me.DataGridViewTextBoxColumn62.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn62.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "items"
        Me.ItemsBindingSource.DataSource = Me.Team_09DataSet
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'HealthDataGridViewTextBoxColumn
        '
        Me.HealthDataGridViewTextBoxColumn.DataPropertyName = "health"
        Me.HealthDataGridViewTextBoxColumn.HeaderText = "health"
        Me.HealthDataGridViewTextBoxColumn.Name = "HealthDataGridViewTextBoxColumn"
        '
        'CanbebredDataGridViewTextBoxColumn
        '
        Me.CanbebredDataGridViewTextBoxColumn.DataPropertyName = "can_be_bred"
        Me.CanbebredDataGridViewTextBoxColumn.HeaderText = "can_be_bred"
        Me.CanbebredDataGridViewTextBoxColumn.Name = "CanbebredDataGridViewTextBoxColumn"
        '
        'MobtypeidDataGridViewTextBoxColumn
        '
        Me.MobtypeidDataGridViewTextBoxColumn.DataPropertyName = "mob_type_id"
        Me.MobtypeidDataGridViewTextBoxColumn.HeaderText = "mob_type_id"
        Me.MobtypeidDataGridViewTextBoxColumn.Name = "MobtypeidDataGridViewTextBoxColumn"
        '
        'MobaggressionidDataGridViewTextBoxColumn
        '
        Me.MobaggressionidDataGridViewTextBoxColumn.DataPropertyName = "mob_aggression_id"
        Me.MobaggressionidDataGridViewTextBoxColumn.HeaderText = "mob_aggression_id"
        Me.MobaggressionidDataGridViewTextBoxColumn.Name = "MobaggressionidDataGridViewTextBoxColumn"
        '
        'CreatedatDataGridViewTextBoxColumn
        '
        Me.CreatedatDataGridViewTextBoxColumn.DataPropertyName = "created_at"
        Me.CreatedatDataGridViewTextBoxColumn.HeaderText = "created_at"
        Me.CreatedatDataGridViewTextBoxColumn.Name = "CreatedatDataGridViewTextBoxColumn"
        '
        'UpdatedatDataGridViewTextBoxColumn
        '
        Me.UpdatedatDataGridViewTextBoxColumn.DataPropertyName = "updated_at"
        Me.UpdatedatDataGridViewTextBoxColumn.HeaderText = "updated_at"
        Me.UpdatedatDataGridViewTextBoxColumn.Name = "UpdatedatDataGridViewTextBoxColumn"
        '
        'DeletedDataGridViewTextBoxColumn
        '
        Me.DeletedDataGridViewTextBoxColumn.DataPropertyName = "deleted"
        Me.DeletedDataGridViewTextBoxColumn.HeaderText = "deleted"
        Me.DeletedDataGridViewTextBoxColumn.Name = "DeletedDataGridViewTextBoxColumn"
        '
        'Team09DataSetBindingSource
        '
        Me.Team09DataSetBindingSource.DataSource = Me.Team_09DataSet
        Me.Team09DataSetBindingSource.Position = 0
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn15.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn16.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn17.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'Biome_typesBindingSource
        '
        Me.Biome_typesBindingSource.DataMember = "biome_types"
        Me.Biome_typesBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn18.HeaderText = "id"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "biome_id"
        Me.DataGridViewTextBoxColumn19.HeaderText = "biome_id"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "block_id"
        Me.DataGridViewTextBoxColumn20.HeaderText = "block_id"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn21.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn22.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn23.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'Biome_blocksBindingSource
        '
        Me.Biome_blocksBindingSource.DataMember = "biome_blocks"
        Me.Biome_blocksBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn24.HeaderText = "id"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn25.HeaderText = "name"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn26.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn27.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn28.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'Mob_aggressionsBindingSource
        '
        Me.Mob_aggressionsBindingSource.DataMember = "mob_aggressions"
        Me.Mob_aggressionsBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn29.HeaderText = "id"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn30.HeaderText = "name"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn31.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn32.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn33.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'Mob_typesBindingSource
        '
        Me.Mob_typesBindingSource.DataMember = "mob_types"
        Me.Mob_typesBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn34.HeaderText = "id"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "mob_id"
        Me.DataGridViewTextBoxColumn35.HeaderText = "mob_id"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "breeding_item_id"
        Me.DataGridViewTextBoxColumn36.HeaderText = "breeding_item_id"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn37.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn38.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn39.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'Mob_breeding_itemsBindingSource
        '
        Me.Mob_breeding_itemsBindingSource.DataMember = "mob_breeding_items"
        Me.Mob_breeding_itemsBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn40.HeaderText = "id"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "potion_item_id"
        Me.DataGridViewTextBoxColumn41.HeaderText = "potion_item_id"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "ingredient_item_id"
        Me.DataGridViewTextBoxColumn42.HeaderText = "ingredient_item_id"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn43.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn44.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn45.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'Brewing_recipiesBindingSource
        '
        Me.Brewing_recipiesBindingSource.DataMember = "brewing_recipies"
        Me.Brewing_recipiesBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn46.HeaderText = "id"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "mob_id"
        Me.DataGridViewTextBoxColumn47.HeaderText = "mob_id"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "drop_item_id"
        Me.DataGridViewTextBoxColumn48.HeaderText = "drop_item_id"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn49.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn50.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn51.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'Mob_item_dropsBindingSource
        '
        Me.Mob_item_dropsBindingSource.DataMember = "mob_item_drops"
        Me.Mob_item_dropsBindingSource.DataSource = Me.Team_09DataSet
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn52.HeaderText = "id"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "biome_id"
        Me.DataGridViewTextBoxColumn53.HeaderText = "biome_id"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "mob_id"
        Me.DataGridViewTextBoxColumn54.HeaderText = "mob_id"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "created_at"
        Me.DataGridViewTextBoxColumn55.HeaderText = "created_at"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "updated_at"
        Me.DataGridViewTextBoxColumn56.HeaderText = "updated_at"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "deleted"
        Me.DataGridViewTextBoxColumn57.HeaderText = "deleted"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        '
        'Biome_mobsBindingSource
        '
        Me.Biome_mobsBindingSource.DataMember = "biome_mobs"
        Me.Biome_mobsBindingSource.DataSource = Me.Team_09DataSet
        '
        'MobsBindingSource1
        '
        Me.MobsBindingSource1.DataMember = "mobs"
        Me.MobsBindingSource1.DataSource = Me.Team_09DataSet
        '
        'MobsTableAdapter
        '
        Me.MobsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.biome_blocksTableAdapter = Nothing
        Me.TableAdapterManager.biome_mobsTableAdapter = Nothing
        Me.TableAdapterManager.biome_typesTableAdapter = Nothing
        Me.TableAdapterManager.biomesTableAdapter = Me.BiomesTableAdapter
        Me.TableAdapterManager.blocksTableAdapter = Me.BlocksTableAdapter
        Me.TableAdapterManager.brewing_recipiesTableAdapter = Nothing
        Me.TableAdapterManager.itemsTableAdapter = Nothing
        Me.TableAdapterManager.mob_aggressionsTableAdapter = Nothing
        Me.TableAdapterManager.mob_breeding_itemsTableAdapter = Nothing
        Me.TableAdapterManager.mob_item_dropsTableAdapter = Nothing
        Me.TableAdapterManager.mob_typesTableAdapter = Nothing
        Me.TableAdapterManager.mobsTableAdapter = Me.MobsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Team_09_Course_Project.team_09DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BiomesTableAdapter
        '
        Me.BiomesTableAdapter.ClearBeforeFill = True
        '
        'BlocksTableAdapter
        '
        Me.BlocksTableAdapter.ClearBeforeFill = True
        '
        'Biome_typesTableAdapter
        '
        Me.Biome_typesTableAdapter.ClearBeforeFill = True
        '
        'Biome_blocksTableAdapter
        '
        Me.Biome_blocksTableAdapter.ClearBeforeFill = True
        '
        'Mob_aggressionsTableAdapter
        '
        Me.Mob_aggressionsTableAdapter.ClearBeforeFill = True
        '
        'Mob_typesTableAdapter
        '
        Me.Mob_typesTableAdapter.ClearBeforeFill = True
        '
        'Mob_breeding_itemsTableAdapter
        '
        Me.Mob_breeding_itemsTableAdapter.ClearBeforeFill = True
        '
        'Brewing_recipiesTableAdapter
        '
        Me.Brewing_recipiesTableAdapter.ClearBeforeFill = True
        '
        'Mob_item_dropsTableAdapter
        '
        Me.Mob_item_dropsTableAdapter.ClearBeforeFill = True
        '
        'Biome_mobsTableAdapter
        '
        Me.Biome_mobsTableAdapter.ClearBeforeFill = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.btnViewRun)
        Me.TabPage13.Controls.Add(Me.txtBoxViewCustom)
        Me.TabPage13.Controls.Add(Me.Label5)
        Me.TabPage13.Controls.Add(Me.Label4)
        Me.TabPage13.Controls.Add(Me.comboBoxMainTable)
        Me.TabPage13.Controls.Add(Me.DataGridViewSelect)
        Me.TabPage13.Location = New System.Drawing.Point(4, 22)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(801, 467)
        Me.TabPage13.TabIndex = 12
        Me.TabPage13.Text = "View"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'DataGridViewSelect
        '
        Me.DataGridViewSelect.AllowUserToAddRows = False
        Me.DataGridViewSelect.AllowUserToDeleteRows = False
        Me.DataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSelect.Location = New System.Drawing.Point(25, 180)
        Me.DataGridViewSelect.Name = "DataGridViewSelect"
        Me.DataGridViewSelect.ReadOnly = True
        Me.DataGridViewSelect.Size = New System.Drawing.Size(750, 220)
        Me.DataGridViewSelect.TabIndex = 0
        '
        'comboBoxMainTable
        '
        Me.comboBoxMainTable.FormattingEnabled = True
        Me.comboBoxMainTable.Items.AddRange(New Object() {"Biomes", "Blocks", "Items", "Mobs", "Biome Blocks", "Biome Types", "Mob Types", "Mob Aggressions", "Mob Breeding Items", "Brewing Recipies", "Mob Item Drops", "Biome Mobs"})
        Me.comboBoxMainTable.Location = New System.Drawing.Point(63, 53)
        Me.comboBoxMainTable.Name = "comboBoxMainTable"
        Me.comboBoxMainTable.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxMainTable.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Select EZView Table"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(581, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Custom Query:"
        '
        'txtBoxViewCustom
        '
        Me.txtBoxViewCustom.Location = New System.Drawing.Point(475, 54)
        Me.txtBoxViewCustom.Name = "txtBoxViewCustom"
        Me.txtBoxViewCustom.Size = New System.Drawing.Size(300, 20)
        Me.txtBoxViewCustom.TabIndex = 4
        '
        'btnViewRun
        '
        Me.btnViewRun.Location = New System.Drawing.Point(582, 80)
        Me.btnViewRun.Name = "btnViewRun"
        Me.btnViewRun.Size = New System.Drawing.Size(75, 23)
        Me.btnViewRun.TabIndex = 5
        Me.btnViewRun.Text = "Run"
        Me.btnViewRun.UseVisualStyleBackColor = True
        '
        'CourseProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 532)
        Me.Controls.Add(Me.lblInsert)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CourseProject"
        Me.Text = "Database GUI"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BiomesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BlocksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ItemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.MobsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.Biome_typesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.Biome_blocksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        CType(Me.Mob_aggressionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.Mob_typesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.Mob_breeding_itemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        CType(Me.Brewing_recipiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        CType(Me.Mob_item_dropsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        CType(Me.Biome_mobsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BiomesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Team_09DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Team09DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biome_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biome_blocksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mob_aggressionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mob_typesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mob_breeding_itemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Brewing_recipiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mob_item_dropsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Biome_mobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        CType(Me.DataGridViewSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Team_09DataSet As team_09DataSet
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents MobsDataGridView As DataGridView
    Friend WithEvents Team09DataSetBindingSource As BindingSource
    Friend WithEvents MobsBindingSource As BindingSource
    Friend WithEvents MobsTableAdapter As team_09DataSetTableAdapters.mobsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HealthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CanbebredDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobtypeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobaggressionidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UpdatedatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeletedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As team_09DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BiomesTableAdapter As team_09DataSetTableAdapters.biomesTableAdapter
    Friend WithEvents BiomesBindingSource As BindingSource
    Friend WithEvents BiomesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents BlocksTableAdapter As team_09DataSetTableAdapters.blocksTableAdapter
    Friend WithEvents BlocksBindingSource As BindingSource
    Friend WithEvents BlocksDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Biome_typesBindingSource As BindingSource
    Friend WithEvents Biome_typesTableAdapter As team_09DataSetTableAdapters.biome_typesTableAdapter
    Friend WithEvents Biome_typesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents Biome_blocksBindingSource As BindingSource
    Friend WithEvents Biome_blocksTableAdapter As team_09DataSetTableAdapters.biome_blocksTableAdapter
    Friend WithEvents Biome_blocksDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Mob_aggressionsBindingSource As BindingSource
    Friend WithEvents Mob_aggressionsTableAdapter As team_09DataSetTableAdapters.mob_aggressionsTableAdapter
    Friend WithEvents Mob_aggressionsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents Mob_typesBindingSource As BindingSource
    Friend WithEvents Mob_typesTableAdapter As team_09DataSetTableAdapters.mob_typesTableAdapter
    Friend WithEvents Mob_typesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents Mob_breeding_itemsBindingSource As BindingSource
    Friend WithEvents Mob_breeding_itemsTableAdapter As team_09DataSetTableAdapters.mob_breeding_itemsTableAdapter
    Friend WithEvents Mob_breeding_itemsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents Brewing_recipiesBindingSource As BindingSource
    Friend WithEvents Brewing_recipiesTableAdapter As team_09DataSetTableAdapters.brewing_recipiesTableAdapter
    Friend WithEvents Brewing_recipiesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents Mob_item_dropsBindingSource As BindingSource
    Friend WithEvents Mob_item_dropsTableAdapter As team_09DataSetTableAdapters.mob_item_dropsTableAdapter
    Friend WithEvents Mob_item_dropsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents Biome_mobsBindingSource As BindingSource
    Friend WithEvents Biome_mobsTableAdapter As team_09DataSetTableAdapters.biome_mobsTableAdapter
    Friend WithEvents Biome_mobsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As team_09DataSetTableAdapters.itemsTableAdapter
    Friend WithEvents ItemsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn59 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn60 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn61 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn62 As DataGridViewTextBoxColumn
    Friend WithEvents txtBoxNameMobs As TextBox
    Friend WithEvents MobsBindingSource1 As BindingSource
    Friend WithEvents txtBoxHealthMobs As TextBox
    Friend WithEvents txtBoxBredMobs As TextBox
    Friend WithEvents txtBoxTypeMobs As TextBox
    Friend WithEvents txtBoxAggMobs As TextBox
    Friend WithEvents btnMobsInsert As Button
    Friend WithEvents lblInsert As Label
    Friend WithEvents btnMobsUpdate As Button
    Friend WithEvents btnBiomesUpdate As Button
    Friend WithEvents btnBiomesInsert As Button
    Friend WithEvents txtBoxBiomesName As TextBox
    Friend WithEvents txtBoxBiomesTemp As TextBox
    Friend WithEvents txtBoxBiomesTypeID As TextBox
    Friend WithEvents btnBlocksUpdate As Button
    Friend WithEvents btnBlocksInsert As Button
    Friend WithEvents txtBoxBlocksName As TextBox
    Friend WithEvents btnItemsUpdate As Button
    Friend WithEvents btnItemsInsert As Button
    Friend WithEvents txtBoxItemsName As TextBox
    Friend WithEvents btnBiomeTypesUpdate As Button
    Friend WithEvents btnBiomeTypesInsert As Button
    Friend WithEvents txtBoxBiomeTypesName As TextBox
    Friend WithEvents btnBiomeBlocksUpdate As Button
    Friend WithEvents btnBiomeBlocksInsert As Button
    Friend WithEvents txtBoxBiomeBlocksBlockID As TextBox
    Friend WithEvents txtBoxBiomeBlocksBiomeID As TextBox
    Friend WithEvents btnMobAggUpdate As Button
    Friend WithEvents btnMobAggInsert As Button
    Friend WithEvents txtBoxMobAggName As TextBox
    Friend WithEvents btnMobTypesUpdate As Button
    Friend WithEvents btnMobTypesInsert As Button
    Friend WithEvents txtBoxMobTypesName As TextBox
    Friend WithEvents btnMobBreedUpdate As Button
    Friend WithEvents btnMobBreedInsert As Button
    Friend WithEvents txtBoxMobBreedMobID As TextBox
    Friend WithEvents txtBoxMobBreedBreedID As TextBox
    Friend WithEvents btnBrewRecUpdate As Button
    Friend WithEvents btnBrewRecInsert As Button
    Friend WithEvents txtBoxBrewRecPotionID As TextBox
    Friend WithEvents txtBoxBrewRecIngredID As TextBox
    Friend WithEvents btnMobItemDropsUpdate As Button
    Friend WithEvents btnMobItemDropsInsert As Button
    Friend WithEvents txtBoxMobitemDropsMobID As TextBox
    Friend WithEvents txtBoxMobItemDropsDropItemID As TextBox
    Friend WithEvents btnBiomeMobsUpdate As Button
    Friend WithEvents btnBiomeMobsInsert As Button
    Friend WithEvents txtBoxBiomeMobsBiomeID As TextBox
    Friend WithEvents txtBoxBiomeMobsMobID As TextBox
    Friend WithEvents btnBiomesDelete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnItemsDelete As Button
    Friend WithEvents btnMobsDelete As Button
    Friend WithEvents btnBiomeTypesDelete As Button
    Friend WithEvents btnBiomeBlocksDelete As Button
    Friend WithEvents btnMobAggDelete As Button
    Friend WithEvents btnMobTypesDelete As Button
    Friend WithEvents btnMobBreedItemsDelete As Button
    Friend WithEvents btnBrewRecDelete As Button
    Friend WithEvents btnMobItemDropsDelete As Button
    Friend WithEvents btnBiomeMobsDelete As Button
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents DataGridViewSelect As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents comboBoxMainTable As ComboBox
    Friend WithEvents txtBoxViewCustom As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnViewRun As Button
End Class
