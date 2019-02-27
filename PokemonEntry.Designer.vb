<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PokemonEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PokemonEntry))
        Me.pbxPokemon = New System.Windows.Forms.PictureBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCardName = New System.Windows.Forms.Label()
        Me.txtAttack1 = New System.Windows.Forms.TextBox()
        Me.txtAttack1Power = New System.Windows.Forms.TextBox()
        Me.txtAttack2Power = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtAttack2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAbility = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWeakness = New System.Windows.Forms.TextBox()
        Me.lblWeakness = New System.Windows.Forms.Label()
        Me.lblResistance = New System.Windows.Forms.Label()
        Me.txtResistance = New System.Windows.Forms.TextBox()
        Me.lblRetreat = New System.Windows.Forms.Label()
        Me.txtRetreat = New System.Windows.Forms.TextBox()
        Me.lblAttack1Cost = New System.Windows.Forms.Label()
        Me.lblAttack2Cost = New System.Windows.Forms.Label()
        Me.txtAttack2Cost = New System.Windows.Forms.TextBox()
        Me.txtAttack1Cost = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAttack3Cost = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAttack3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAttack3Strength = New System.Windows.Forms.TextBox()
        Me.txtAttack3Name = New System.Windows.Forms.TextBox()
        Me.txtAttack2Name = New System.Windows.Forms.TextBox()
        Me.txtAttack1Name = New System.Windows.Forms.TextBox()
        Me.lblRelease = New System.Windows.Forms.Label()
        Me.txtRelease = New System.Windows.Forms.TextBox()
        Me.txtElement = New System.Windows.Forms.TextBox()
        Me.chkElement = New System.Windows.Forms.CheckBox()
        Me.chkCreature = New System.Windows.Forms.CheckBox()
        CType(Me.pbxPokemon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxPokemon
        '
        Me.pbxPokemon.BackgroundImage = CType(resources.GetObject("pbxPokemon.BackgroundImage"), System.Drawing.Image)
        Me.pbxPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxPokemon.Location = New System.Drawing.Point(8, 626)
        Me.pbxPokemon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbxPokemon.Name = "pbxPokemon"
        Me.pbxPokemon.Size = New System.Drawing.Size(297, 249)
        Me.pbxPokemon.TabIndex = 1
        Me.pbxPokemon.TabStop = False
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.Location = New System.Drawing.Point(475, 106)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 22)
        Me.txtName.TabIndex = 2
        Me.txtName.Text = "Cardname + ex or 100 or level up"
        '
        'lblCardName
        '
        Me.lblCardName.AutoSize = True
        Me.lblCardName.Location = New System.Drawing.Point(471, 70)
        Me.lblCardName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCardName.Name = "lblCardName"
        Me.lblCardName.Size = New System.Drawing.Size(67, 17)
        Me.lblCardName.TabIndex = 69
        Me.lblCardName.Text = "Pokemon"
        '
        'txtAttack1
        '
        Me.txtAttack1.Location = New System.Drawing.Point(377, 329)
        Me.txtAttack1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack1.Multiline = True
        Me.txtAttack1.Name = "txtAttack1"
        Me.txtAttack1.Size = New System.Drawing.Size(268, 100)
        Me.txtAttack1.TabIndex = 6
        '
        'txtAttack1Power
        '
        Me.txtAttack1Power.Location = New System.Drawing.Point(757, 337)
        Me.txtAttack1Power.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack1Power.Name = "txtAttack1Power"
        Me.txtAttack1Power.Size = New System.Drawing.Size(64, 22)
        Me.txtAttack1Power.TabIndex = 7
        '
        'txtAttack2Power
        '
        Me.txtAttack2Power.Location = New System.Drawing.Point(756, 470)
        Me.txtAttack2Power.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack2Power.Name = "txtAttack2Power"
        Me.txtAttack2Power.Size = New System.Drawing.Size(65, 22)
        Me.txtAttack2Power.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(671, 450)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Attack 2 Strength"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(671, 309)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Attack 1 Strength"
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(736, 106)
        Me.txtHP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(53, 22)
        Me.txtHP.TabIndex = 3
        '
        'txtAttack2
        '
        Me.txtAttack2.Location = New System.Drawing.Point(381, 470)
        Me.txtAttack2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack2.Multiline = True
        Me.txtAttack2.Name = "txtAttack2"
        Me.txtAttack2.Size = New System.Drawing.Size(268, 128)
        Me.txtAttack2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(377, 309)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Attacks 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 450)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Attack 2"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(19, 246)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(292, 22)
        Me.txtLocation.TabIndex = 18
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(15, 226)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(116, 17)
        Me.lblLocation.TabIndex = 77
        Me.lblLocation.Text = "Storage Location"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(736, 847)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 28)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "Add Card"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(52, 70)
        Me.lblElement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 17)
        Me.lblElement.TabIndex = 80
        Me.lblElement.Text = "Element"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(377, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Stage"
        '
        'txtStage
        '
        Me.txtStage.Location = New System.Drawing.Point(381, 106)
        Me.txtStage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStage.Name = "txtStage"
        Me.txtStage.Size = New System.Drawing.Size(84, 22)
        Me.txtStage.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(732, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "HP"
        '
        'txtAbility
        '
        Me.txtAbility.Location = New System.Drawing.Point(377, 204)
        Me.txtAbility.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAbility.Multiline = True
        Me.txtAbility.Name = "txtAbility"
        Me.txtAbility.Size = New System.Drawing.Size(268, 100)
        Me.txtAbility.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 185)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Ability/Effect"
        '
        'txtWeakness
        '
        Me.txtWeakness.Location = New System.Drawing.Point(313, 816)
        Me.txtWeakness.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWeakness.Name = "txtWeakness"
        Me.txtWeakness.Size = New System.Drawing.Size(139, 22)
        Me.txtWeakness.TabIndex = 14
        '
        'lblWeakness
        '
        Me.lblWeakness.AutoSize = True
        Me.lblWeakness.Location = New System.Drawing.Point(345, 796)
        Me.lblWeakness.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeakness.Name = "lblWeakness"
        Me.lblWeakness.Size = New System.Drawing.Size(74, 17)
        Me.lblWeakness.TabIndex = 87
        Me.lblWeakness.Text = "Weakness"
        '
        'lblResistance
        '
        Me.lblResistance.AutoSize = True
        Me.lblResistance.Location = New System.Drawing.Point(503, 796)
        Me.lblResistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResistance.Name = "lblResistance"
        Me.lblResistance.Size = New System.Drawing.Size(78, 17)
        Me.lblResistance.TabIndex = 89
        Me.lblResistance.Text = "Resistance"
        '
        'txtResistance
        '
        Me.txtResistance.Location = New System.Drawing.Point(471, 816)
        Me.txtResistance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtResistance.Name = "txtResistance"
        Me.txtResistance.Size = New System.Drawing.Size(139, 22)
        Me.txtResistance.TabIndex = 15
        '
        'lblRetreat
        '
        Me.lblRetreat.AutoSize = True
        Me.lblRetreat.Location = New System.Drawing.Point(677, 796)
        Me.lblRetreat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRetreat.Name = "lblRetreat"
        Me.lblRetreat.Size = New System.Drawing.Size(55, 17)
        Me.lblRetreat.TabIndex = 91
        Me.lblRetreat.Text = "Retreat"
        '
        'txtRetreat
        '
        Me.txtRetreat.Location = New System.Drawing.Point(645, 816)
        Me.txtRetreat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRetreat.Name = "txtRetreat"
        Me.txtRetreat.Size = New System.Drawing.Size(139, 22)
        Me.txtRetreat.TabIndex = 16
        '
        'lblAttack1Cost
        '
        Me.lblAttack1Cost.AutoSize = True
        Me.lblAttack1Cost.Location = New System.Drawing.Point(253, 309)
        Me.lblAttack1Cost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAttack1Cost.Name = "lblAttack1Cost"
        Me.lblAttack1Cost.Size = New System.Drawing.Size(91, 17)
        Me.lblAttack1Cost.TabIndex = 97
        Me.lblAttack1Cost.Text = "Attack 1 Cost"
        '
        'lblAttack2Cost
        '
        Me.lblAttack2Cost.AutoSize = True
        Me.lblAttack2Cost.Location = New System.Drawing.Point(253, 450)
        Me.lblAttack2Cost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAttack2Cost.Name = "lblAttack2Cost"
        Me.lblAttack2Cost.Size = New System.Drawing.Size(91, 17)
        Me.lblAttack2Cost.TabIndex = 96
        Me.lblAttack2Cost.Text = "Attack 2 Cost"
        '
        'txtAttack2Cost
        '
        Me.txtAttack2Cost.Location = New System.Drawing.Point(307, 470)
        Me.txtAttack2Cost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack2Cost.Name = "txtAttack2Cost"
        Me.txtAttack2Cost.Size = New System.Drawing.Size(65, 22)
        Me.txtAttack2Cost.TabIndex = 8
        '
        'txtAttack1Cost
        '
        Me.txtAttack1Cost.Location = New System.Drawing.Point(308, 337)
        Me.txtAttack1Cost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack1Cost.Name = "txtAttack1Cost"
        Me.txtAttack1Cost.Size = New System.Drawing.Size(64, 22)
        Me.txtAttack1Cost.TabIndex = 5
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(849, 28)
        Me.MenuStrip1.TabIndex = 98
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CollectionToolStripMenuItem, Me.CardToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'CollectionToolStripMenuItem
        '
        Me.CollectionToolStripMenuItem.Name = "CollectionToolStripMenuItem"
        Me.CollectionToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.CollectionToolStripMenuItem.Text = "Collection"
        '
        'CardToolStripMenuItem
        '
        Me.CardToolStripMenuItem.Name = "CardToolStripMenuItem"
        Me.CardToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.CardToolStripMenuItem.Text = "Card"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 618)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 17)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Attack 3 Cost"
        '
        'txtAttack3Cost
        '
        Me.txtAttack3Cost.Location = New System.Drawing.Point(307, 638)
        Me.txtAttack3Cost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack3Cost.Name = "txtAttack3Cost"
        Me.txtAttack3Cost.Size = New System.Drawing.Size(65, 22)
        Me.txtAttack3Cost.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(377, 618)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 17)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Attack 3"
        '
        'txtAttack3
        '
        Me.txtAttack3.Location = New System.Drawing.Point(381, 638)
        Me.txtAttack3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack3.Multiline = True
        Me.txtAttack3.Name = "txtAttack3"
        Me.txtAttack3.Size = New System.Drawing.Size(268, 128)
        Me.txtAttack3.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(671, 618)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 17)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Attack 3 Strength"
        '
        'txtAttack3Strength
        '
        Me.txtAttack3Strength.Location = New System.Drawing.Point(756, 638)
        Me.txtAttack3Strength.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack3Strength.Name = "txtAttack3Strength"
        Me.txtAttack3Strength.Size = New System.Drawing.Size(65, 22)
        Me.txtAttack3Strength.TabIndex = 13
        '
        'txtAttack3Name
        '
        Me.txtAttack3Name.Location = New System.Drawing.Point(444, 613)
        Me.txtAttack3Name.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAttack3Name.Name = "txtAttack3Name"
        Me.txtAttack3Name.Size = New System.Drawing.Size(205, 22)
        Me.txtAttack3Name.TabIndex = 105
        '
        'txtAttack2Name
        '
        Me.txtAttack2Name.Location = New System.Drawing.Point(444, 447)
        Me.txtAttack2Name.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAttack2Name.Name = "txtAttack2Name"
        Me.txtAttack2Name.Size = New System.Drawing.Size(201, 22)
        Me.txtAttack2Name.TabIndex = 106
        '
        'txtAttack1Name
        '
        Me.txtAttack1Name.Location = New System.Drawing.Point(451, 306)
        Me.txtAttack1Name.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAttack1Name.Name = "txtAttack1Name"
        Me.txtAttack1Name.Size = New System.Drawing.Size(194, 22)
        Me.txtAttack1Name.TabIndex = 107
        '
        'lblRelease
        '
        Me.lblRelease.AutoSize = True
        Me.lblRelease.Location = New System.Drawing.Point(10, 185)
        Me.lblRelease.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRelease.Name = "lblRelease"
        Me.lblRelease.Size = New System.Drawing.Size(60, 17)
        Me.lblRelease.TabIndex = 108
        Me.lblRelease.Text = "Release"
        '
        'txtRelease
        '
        Me.txtRelease.Location = New System.Drawing.Point(78, 182)
        Me.txtRelease.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRelease.Name = "txtRelease"
        Me.txtRelease.Size = New System.Drawing.Size(235, 22)
        Me.txtRelease.TabIndex = 109
        '
        'txtElement
        '
        Me.txtElement.Location = New System.Drawing.Point(13, 91)
        Me.txtElement.Margin = New System.Windows.Forms.Padding(4)
        Me.txtElement.Name = "txtElement"
        Me.txtElement.Size = New System.Drawing.Size(300, 22)
        Me.txtElement.TabIndex = 110
        '
        'chkElement
        '
        Me.chkElement.AutoSize = True
        Me.chkElement.Location = New System.Drawing.Point(13, 138)
        Me.chkElement.Name = "chkElement"
        Me.chkElement.Size = New System.Drawing.Size(115, 21)
        Me.chkElement.TabIndex = 111
        Me.chkElement.Text = "Multi-Element"
        Me.chkElement.UseVisualStyleBackColor = True
        '
        'chkCreature
        '
        Me.chkCreature.AutoSize = True
        Me.chkCreature.Location = New System.Drawing.Point(134, 138)
        Me.chkCreature.Name = "chkCreature"
        Me.chkCreature.Size = New System.Drawing.Size(116, 21)
        Me.chkCreature.TabIndex = 112
        Me.chkCreature.Text = "Non-Creature"
        Me.chkCreature.UseVisualStyleBackColor = True
        '
        'PokemonEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 895)
        Me.Controls.Add(Me.chkCreature)
        Me.Controls.Add(Me.chkElement)
        Me.Controls.Add(Me.txtElement)
        Me.Controls.Add(Me.txtRelease)
        Me.Controls.Add(Me.lblRelease)
        Me.Controls.Add(Me.txtAttack1Name)
        Me.Controls.Add(Me.txtAttack2Name)
        Me.Controls.Add(Me.txtAttack3Name)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAttack3Cost)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAttack3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAttack3Strength)
        Me.Controls.Add(Me.lblAttack1Cost)
        Me.Controls.Add(Me.lblAttack2Cost)
        Me.Controls.Add(Me.txtAttack2Cost)
        Me.Controls.Add(Me.txtAttack1Cost)
        Me.Controls.Add(Me.lblRetreat)
        Me.Controls.Add(Me.txtRetreat)
        Me.Controls.Add(Me.lblResistance)
        Me.Controls.Add(Me.txtResistance)
        Me.Controls.Add(Me.lblWeakness)
        Me.Controls.Add(Me.txtWeakness)
        Me.Controls.Add(Me.txtAbility)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtStage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAttack2)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAttack2Power)
        Me.Controls.Add(Me.txtAttack1Power)
        Me.Controls.Add(Me.txtAttack1)
        Me.Controls.Add(Me.lblCardName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.pbxPokemon)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PokemonEntry"
        Me.Text = "PokemonEntry"
        CType(Me.pbxPokemon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxPokemon As PictureBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblCardName As Label
    Friend WithEvents txtAttack1 As TextBox
    Friend WithEvents txtAttack1Power As TextBox
    Friend WithEvents txtAttack2Power As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtAttack2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblLocation As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblElement As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAbility As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtWeakness As TextBox
    Friend WithEvents lblWeakness As Label
    Friend WithEvents lblResistance As Label
    Friend WithEvents txtResistance As TextBox
    Friend WithEvents lblRetreat As Label
    Friend WithEvents txtRetreat As TextBox
    Friend WithEvents lblAttack1Cost As Label
    Friend WithEvents lblAttack2Cost As Label
    Friend WithEvents txtAttack2Cost As TextBox
    Friend WithEvents txtAttack1Cost As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAttack3Cost As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAttack3 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAttack3Strength As TextBox
    Friend WithEvents txtAttack3Name As TextBox
    Friend WithEvents txtAttack2Name As TextBox
    Friend WithEvents txtAttack1Name As TextBox
    Friend WithEvents lblRelease As Label
    Friend WithEvents txtRelease As TextBox
    Friend WithEvents txtElement As TextBox
    Friend WithEvents chkElement As CheckBox
    Friend WithEvents chkCreature As CheckBox
End Class
