<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PokemonCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PokemonCollection))
        Me.dgvPokemonCollection = New System.Windows.Forms.DataGridView()
        Me.txtHackThePlanet = New System.Windows.Forms.TextBox()
        Me.btnBackGround = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtSpecification = New System.Windows.Forms.TextBox()
        Me.lblFilterby = New System.Windows.Forms.Label()
        Me.cbxFilterMethod = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvPokemonCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPokemonCollection
        '
        Me.dgvPokemonCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPokemonCollection.Location = New System.Drawing.Point(16, 187)
        Me.dgvPokemonCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvPokemonCollection.Name = "dgvPokemonCollection"
        Me.dgvPokemonCollection.Size = New System.Drawing.Size(1469, 609)
        Me.dgvPokemonCollection.TabIndex = 0
        '
        'txtHackThePlanet
        '
        Me.txtHackThePlanet.Location = New System.Drawing.Point(429, 32)
        Me.txtHackThePlanet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHackThePlanet.Multiline = True
        Me.txtHackThePlanet.Name = "txtHackThePlanet"
        Me.txtHackThePlanet.Size = New System.Drawing.Size(783, 98)
        Me.txtHackThePlanet.TabIndex = 13
        '
        'btnBackGround
        '
        Me.btnBackGround.Location = New System.Drawing.Point(1348, 12)
        Me.btnBackGround.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBackGround.Name = "btnBackGround"
        Me.btnBackGround.Size = New System.Drawing.Size(145, 28)
        Me.btnBackGround.TabIndex = 12
        Me.btnBackGround.Text = "Show Background"
        Me.btnBackGround.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(1084, 135)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(100, 28)
        Me.btnFilter.TabIndex = 11
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtSpecification
        '
        Me.txtSpecification.Location = New System.Drawing.Point(817, 138)
        Me.txtSpecification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSpecification.Name = "txtSpecification"
        Me.txtSpecification.Size = New System.Drawing.Size(235, 22)
        Me.txtSpecification.TabIndex = 10
        '
        'lblFilterby
        '
        Me.lblFilterby.AutoSize = True
        Me.lblFilterby.Location = New System.Drawing.Point(472, 142)
        Me.lblFilterby.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilterby.Name = "lblFilterby"
        Me.lblFilterby.Size = New System.Drawing.Size(63, 17)
        Me.lblFilterby.TabIndex = 9
        Me.lblFilterby.Text = "Filter By:"
        '
        'cbxFilterMethod
        '
        Me.cbxFilterMethod.FormattingEnabled = True
        Me.cbxFilterMethod.Items.AddRange(New Object() {"Abilities", "Card Name", "Color", "Color Cost", "Colorless Cost", "No Filter", "Power", "Quantity", "Release", "SubType", "SuperType", "Total Cost", "Toughness"})
        Me.cbxFilterMethod.Location = New System.Drawing.Point(543, 138)
        Me.cbxFilterMethod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxFilterMethod.Name = "cbxFilterMethod"
        Me.cbxFilterMethod.Size = New System.Drawing.Size(235, 24)
        Me.cbxFilterMethod.Sorted = True
        Me.cbxFilterMethod.TabIndex = 8
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1509, 28)
        Me.MenuStrip1.TabIndex = 14
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
        'PokemonCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1509, 817)
        Me.Controls.Add(Me.txtHackThePlanet)
        Me.Controls.Add(Me.btnBackGround)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtSpecification)
        Me.Controls.Add(Me.lblFilterby)
        Me.Controls.Add(Me.cbxFilterMethod)
        Me.Controls.Add(Me.dgvPokemonCollection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PokemonCollection"
        Me.Text = "PokemonCollection"
        CType(Me.dgvPokemonCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPokemonCollection As DataGridView
    Friend WithEvents txtHackThePlanet As TextBox
    Friend WithEvents btnBackGround As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents txtSpecification As TextBox
    Friend WithEvents lblFilterby As Label
    Friend WithEvents cbxFilterMethod As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
