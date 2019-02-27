<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YugioCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YugioCollection))
        Me.dgvYugiohCollection = New System.Windows.Forms.DataGridView()
        Me.txtHackThePlanet = New System.Windows.Forms.TextBox()
        Me.btnBackGround = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtSpecification = New System.Windows.Forms.TextBox()
        Me.lblFilterby = New System.Windows.Forms.Label()
        Me.cbxFilterMethod = New System.Windows.Forms.ComboBox()
        CType(Me.dgvYugiohCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvYugiohCollection
        '
        Me.dgvYugiohCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYugiohCollection.Location = New System.Drawing.Point(32, 255)
        Me.dgvYugiohCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvYugiohCollection.Name = "dgvYugiohCollection"
        Me.dgvYugiohCollection.Size = New System.Drawing.Size(1381, 649)
        Me.dgvYugiohCollection.TabIndex = 0
        '
        'txtHackThePlanet
        '
        Me.txtHackThePlanet.Location = New System.Drawing.Point(308, 36)
        Me.txtHackThePlanet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHackThePlanet.Multiline = True
        Me.txtHackThePlanet.Name = "txtHackThePlanet"
        Me.txtHackThePlanet.Size = New System.Drawing.Size(881, 98)
        Me.txtHackThePlanet.TabIndex = 13
        '
        'btnBackGround
        '
        Me.btnBackGround.Location = New System.Drawing.Point(1297, 15)
        Me.btnBackGround.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBackGround.Name = "btnBackGround"
        Me.btnBackGround.Size = New System.Drawing.Size(145, 28)
        Me.btnBackGround.TabIndex = 12
        Me.btnBackGround.Text = "Show Background"
        Me.btnBackGround.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(975, 188)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(100, 28)
        Me.btnFilter.TabIndex = 11
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtSpecification
        '
        Me.txtSpecification.Location = New System.Drawing.Point(708, 191)
        Me.txtSpecification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSpecification.Name = "txtSpecification"
        Me.txtSpecification.Size = New System.Drawing.Size(235, 22)
        Me.txtSpecification.TabIndex = 10
        '
        'lblFilterby
        '
        Me.lblFilterby.AutoSize = True
        Me.lblFilterby.Location = New System.Drawing.Point(363, 194)
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
        Me.cbxFilterMethod.Location = New System.Drawing.Point(433, 191)
        Me.cbxFilterMethod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxFilterMethod.Name = "cbxFilterMethod"
        Me.cbxFilterMethod.Size = New System.Drawing.Size(235, 24)
        Me.cbxFilterMethod.Sorted = True
        Me.cbxFilterMethod.TabIndex = 8
        '
        'YugioCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1459, 943)
        Me.Controls.Add(Me.txtHackThePlanet)
        Me.Controls.Add(Me.btnBackGround)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtSpecification)
        Me.Controls.Add(Me.lblFilterby)
        Me.Controls.Add(Me.cbxFilterMethod)
        Me.Controls.Add(Me.dgvYugiohCollection)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "YugioCollection"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "YugioCollection"
        CType(Me.dgvYugiohCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvYugiohCollection As DataGridView
    Friend WithEvents txtHackThePlanet As TextBox
    Friend WithEvents btnBackGround As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents txtSpecification As TextBox
    Friend WithEvents lblFilterby As Label
    Friend WithEvents cbxFilterMethod As ComboBox
End Class
