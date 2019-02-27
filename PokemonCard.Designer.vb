<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PokemonCard
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
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.txtAbility = New System.Windows.Forms.TextBox()
        Me.txtAttack1Name = New System.Windows.Forms.TextBox()
        Me.txtAttack1power = New System.Windows.Forms.TextBox()
        Me.txtAttack1Cost = New System.Windows.Forms.TextBox()
        Me.txtAttack2Cost = New System.Windows.Forms.TextBox()
        Me.txtAttack2power = New System.Windows.Forms.TextBox()
        Me.txtAttack2Name = New System.Windows.Forms.TextBox()
        Me.txtAttack3cost = New System.Windows.Forms.TextBox()
        Me.txtAttack3power = New System.Windows.Forms.TextBox()
        Me.txtAttack3Name = New System.Windows.Forms.TextBox()
        Me.txtWeakness = New System.Windows.Forms.TextBox()
        Me.txtResistance = New System.Windows.Forms.TextBox()
        Me.txtRetreatCost = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCardName
        '
        Me.txtCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardName.Location = New System.Drawing.Point(12, 42)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(322, 30)
        Me.txtCardName.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(593, 28)
        Me.MenuStrip1.TabIndex = 1
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
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'txtHP
        '
        Me.txtHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHP.Location = New System.Drawing.Point(396, 42)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(101, 30)
        Me.txtHP.TabIndex = 2
        '
        'txtAbility
        '
        Me.txtAbility.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbility.Location = New System.Drawing.Point(91, 87)
        Me.txtAbility.Multiline = True
        Me.txtAbility.Name = "txtAbility"
        Me.txtAbility.Size = New System.Drawing.Size(382, 131)
        Me.txtAbility.TabIndex = 4
        '
        'txtAttack1Name
        '
        Me.txtAttack1Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack1Name.Location = New System.Drawing.Point(91, 224)
        Me.txtAttack1Name.Multiline = True
        Me.txtAttack1Name.Name = "txtAttack1Name"
        Me.txtAttack1Name.Size = New System.Drawing.Size(382, 131)
        Me.txtAttack1Name.TabIndex = 5
        '
        'txtAttack1power
        '
        Me.txtAttack1power.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack1power.Location = New System.Drawing.Point(479, 267)
        Me.txtAttack1power.Name = "txtAttack1power"
        Me.txtAttack1power.Size = New System.Drawing.Size(76, 30)
        Me.txtAttack1power.TabIndex = 6
        '
        'txtAttack1Cost
        '
        Me.txtAttack1Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack1Cost.Location = New System.Drawing.Point(9, 281)
        Me.txtAttack1Cost.Name = "txtAttack1Cost"
        Me.txtAttack1Cost.Size = New System.Drawing.Size(76, 30)
        Me.txtAttack1Cost.TabIndex = 7
        '
        'txtAttack2Cost
        '
        Me.txtAttack2Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack2Cost.Location = New System.Drawing.Point(9, 418)
        Me.txtAttack2Cost.Name = "txtAttack2Cost"
        Me.txtAttack2Cost.Size = New System.Drawing.Size(76, 30)
        Me.txtAttack2Cost.TabIndex = 10
        '
        'txtAttack2power
        '
        Me.txtAttack2power.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack2power.Location = New System.Drawing.Point(479, 404)
        Me.txtAttack2power.Name = "txtAttack2power"
        Me.txtAttack2power.Size = New System.Drawing.Size(76, 30)
        Me.txtAttack2power.TabIndex = 9
        '
        'txtAttack2Name
        '
        Me.txtAttack2Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack2Name.Location = New System.Drawing.Point(91, 361)
        Me.txtAttack2Name.Multiline = True
        Me.txtAttack2Name.Name = "txtAttack2Name"
        Me.txtAttack2Name.Size = New System.Drawing.Size(382, 131)
        Me.txtAttack2Name.TabIndex = 8
        '
        'txtAttack3cost
        '
        Me.txtAttack3cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack3cost.Location = New System.Drawing.Point(9, 555)
        Me.txtAttack3cost.Name = "txtAttack3cost"
        Me.txtAttack3cost.Size = New System.Drawing.Size(76, 30)
        Me.txtAttack3cost.TabIndex = 13
        '
        'txtAttack3power
        '
        Me.txtAttack3power.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack3power.Location = New System.Drawing.Point(479, 541)
        Me.txtAttack3power.Name = "txtAttack3power"
        Me.txtAttack3power.Size = New System.Drawing.Size(76, 30)
        Me.txtAttack3power.TabIndex = 12
        '
        'txtAttack3Name
        '
        Me.txtAttack3Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttack3Name.Location = New System.Drawing.Point(91, 498)
        Me.txtAttack3Name.Multiline = True
        Me.txtAttack3Name.Name = "txtAttack3Name"
        Me.txtAttack3Name.Size = New System.Drawing.Size(382, 131)
        Me.txtAttack3Name.TabIndex = 11
        '
        'txtWeakness
        '
        Me.txtWeakness.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeakness.Location = New System.Drawing.Point(12, 643)
        Me.txtWeakness.Name = "txtWeakness"
        Me.txtWeakness.Size = New System.Drawing.Size(139, 30)
        Me.txtWeakness.TabIndex = 14
        '
        'txtResistance
        '
        Me.txtResistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResistance.Location = New System.Drawing.Point(195, 643)
        Me.txtResistance.Name = "txtResistance"
        Me.txtResistance.Size = New System.Drawing.Size(193, 30)
        Me.txtResistance.TabIndex = 15
        '
        'txtRetreatCost
        '
        Me.txtRetreatCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetreatCost.Location = New System.Drawing.Point(458, 643)
        Me.txtRetreatCost.Name = "txtRetreatCost"
        Me.txtRetreatCost.Size = New System.Drawing.Size(97, 30)
        Me.txtRetreatCost.TabIndex = 16
        '
        'PokemonCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 685)
        Me.Controls.Add(Me.txtRetreatCost)
        Me.Controls.Add(Me.txtResistance)
        Me.Controls.Add(Me.txtWeakness)
        Me.Controls.Add(Me.txtAttack3cost)
        Me.Controls.Add(Me.txtAttack3power)
        Me.Controls.Add(Me.txtAttack3Name)
        Me.Controls.Add(Me.txtAttack2Cost)
        Me.Controls.Add(Me.txtAttack2power)
        Me.Controls.Add(Me.txtAttack2Name)
        Me.Controls.Add(Me.txtAttack1Cost)
        Me.Controls.Add(Me.txtAttack1power)
        Me.Controls.Add(Me.txtAttack1Name)
        Me.Controls.Add(Me.txtAbility)
        Me.Controls.Add(Me.txtHP)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PokemonCard"
        Me.Text = "PokemonCard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardName As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtHP As TextBox
    Friend WithEvents txtAbility As TextBox
    Friend WithEvents txtAttack1Name As TextBox
    Friend WithEvents txtAttack1power As TextBox
    Friend WithEvents txtAttack1Cost As TextBox
    Friend WithEvents txtAttack2Cost As TextBox
    Friend WithEvents txtAttack2power As TextBox
    Friend WithEvents txtAttack2Name As TextBox
    Friend WithEvents txtAttack3cost As TextBox
    Friend WithEvents txtAttack3power As TextBox
    Friend WithEvents txtAttack3Name As TextBox
    Friend WithEvents txtWeakness As TextBox
    Friend WithEvents txtResistance As TextBox
    Friend WithEvents txtRetreatCost As TextBox
End Class
