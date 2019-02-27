<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YugiohEntry
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YugiohEntry))
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.txtAttack = New System.Windows.Forms.TextBox()
        Me.txtDefense = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtRelease = New System.Windows.Forms.TextBox()
        Me.cbxElement = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtStorage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCardName
        '
        Me.txtCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardName.Location = New System.Drawing.Point(47, 44)
        Me.txtCardName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(485, 37)
        Me.txtCardName.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCardName, "Enter the Card Name")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(635, 28)
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
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(536, 103)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(53, 37)
        Me.txtCost.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtCost, "Enter a number describing the cost of the card" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(47, 645)
        Me.txtType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(473, 22)
        Me.txtType.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtType, "Enter the Card Type Here")
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(47, 666)
        Me.txtText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(543, 110)
        Me.txtText.TabIndex = 4
        '
        'txtAttack
        '
        Me.txtAttack.Location = New System.Drawing.Point(399, 784)
        Me.txtAttack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAttack.Name = "txtAttack"
        Me.txtAttack.Size = New System.Drawing.Size(63, 22)
        Me.txtAttack.TabIndex = 5
        '
        'txtDefense
        '
        Me.txtDefense.Location = New System.Drawing.Point(527, 784)
        Me.txtDefense.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDefense.Name = "txtDefense"
        Me.txtDefense.Size = New System.Drawing.Size(63, 22)
        Me.txtDefense.TabIndex = 6
        '
        'txtRelease
        '
        Me.txtRelease.Location = New System.Drawing.Point(467, 625)
        Me.txtRelease.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRelease.Name = "txtRelease"
        Me.txtRelease.Size = New System.Drawing.Size(133, 22)
        Me.txtRelease.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtRelease, "Enter the Card Type Here")
        '
        'cbxElement
        '
        Me.cbxElement.FormattingEnabled = True
        Me.cbxElement.Location = New System.Drawing.Point(536, 44)
        Me.cbxElement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxElement.Name = "cbxElement"
        Me.cbxElement.Size = New System.Drawing.Size(53, 24)
        Me.cbxElement.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(527, 833)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 28)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Enter Card"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtStorage
        '
        Me.txtStorage.Location = New System.Drawing.Point(36, 831)
        Me.txtStorage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStorage.Name = "txtStorage"
        Me.txtStorage.Size = New System.Drawing.Size(473, 22)
        Me.txtStorage.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.txtStorage, "Enter the Card Type Here")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 807)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Storage Location"
        '
        'YugiohEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 866)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStorage)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtRelease)
        Me.Controls.Add(Me.cbxElement)
        Me.Controls.Add(Me.txtDefense)
        Me.Controls.Add(Me.txtAttack)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "YugiohEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YugiohEntry"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardName As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtCost As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtType As TextBox
    Friend WithEvents txtText As TextBox
    Friend WithEvents txtAttack As TextBox
    Friend WithEvents txtDefense As TextBox
    Friend WithEvents cbxElement As ComboBox
    Friend WithEvents txtRelease As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtStorage As TextBox
    Friend WithEvents Label1 As Label
End Class
