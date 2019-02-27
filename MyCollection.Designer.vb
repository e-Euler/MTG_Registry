<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyCollection))
        Me.dgvMyCollection = New System.Windows.Forms.DataGridView()
        Me.MyCollectionDataSet = New MTG_Registry.MyCollectionDataSet()
        Me.CollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CollectionTableAdapter = New MTG_Registry.MyCollectionDataSetTableAdapters.CollectionTableAdapter()
        Me.cbxFilterMethod = New System.Windows.Forms.ComboBox()
        Me.lblFilterby = New System.Windows.Forms.Label()
        Me.txtSpecification = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnBackGround = New System.Windows.Forms.Button()
        Me.txtHackThePlanet = New System.Windows.Forms.TextBox()
        CType(Me.dgvMyCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMyCollection
        '
        Me.dgvMyCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMyCollection.Location = New System.Drawing.Point(16, 185)
        Me.dgvMyCollection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvMyCollection.Name = "dgvMyCollection"
        Me.dgvMyCollection.Size = New System.Drawing.Size(1120, 602)
        Me.dgvMyCollection.TabIndex = 0
        '
        'MyCollectionDataSet
        '
        Me.MyCollectionDataSet.DataSetName = "MyCollectionDataSet"
        Me.MyCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CollectionBindingSource
        '
        Me.CollectionBindingSource.DataMember = "Collection"
        Me.CollectionBindingSource.DataSource = Me.MyCollectionDataSet
        '
        'CollectionTableAdapter
        '
        Me.CollectionTableAdapter.ClearBeforeFill = True
        '
        'cbxFilterMethod
        '
        Me.cbxFilterMethod.FormattingEnabled = True
        Me.cbxFilterMethod.Items.AddRange(New Object() {"Abilities", "Card Name", "Color", "Color Cost", "Colorless Cost", "No Filter", "Power", "Quantity", "Release", "SubType", "SuperType", "Total Cost", "Toughness"})
        Me.cbxFilterMethod.Location = New System.Drawing.Point(295, 123)
        Me.cbxFilterMethod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxFilterMethod.Name = "cbxFilterMethod"
        Me.cbxFilterMethod.Size = New System.Drawing.Size(235, 24)
        Me.cbxFilterMethod.Sorted = True
        Me.cbxFilterMethod.TabIndex = 1
        '
        'lblFilterby
        '
        Me.lblFilterby.AutoSize = True
        Me.lblFilterby.Location = New System.Drawing.Point(224, 127)
        Me.lblFilterby.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilterby.Name = "lblFilterby"
        Me.lblFilterby.Size = New System.Drawing.Size(63, 17)
        Me.lblFilterby.TabIndex = 2
        Me.lblFilterby.Text = "Filter By:"
        '
        'txtSpecification
        '
        Me.txtSpecification.Location = New System.Drawing.Point(569, 123)
        Me.txtSpecification.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSpecification.Name = "txtSpecification"
        Me.txtSpecification.Size = New System.Drawing.Size(235, 22)
        Me.txtSpecification.TabIndex = 3
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(836, 121)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(100, 28)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnBackGround
        '
        Me.btnBackGround.Location = New System.Drawing.Point(991, 15)
        Me.btnBackGround.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBackGround.Name = "btnBackGround"
        Me.btnBackGround.Size = New System.Drawing.Size(145, 28)
        Me.btnBackGround.TabIndex = 6
        Me.btnBackGround.Text = "Show Background"
        Me.btnBackGround.UseVisualStyleBackColor = True
        '
        'txtHackThePlanet
        '
        Me.txtHackThePlanet.Location = New System.Drawing.Point(180, 15)
        Me.txtHackThePlanet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHackThePlanet.Multiline = True
        Me.txtHackThePlanet.Name = "txtHackThePlanet"
        Me.txtHackThePlanet.Size = New System.Drawing.Size(783, 98)
        Me.txtHackThePlanet.TabIndex = 7
        '
        'MyCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1152, 801)
        Me.Controls.Add(Me.txtHackThePlanet)
        Me.Controls.Add(Me.btnBackGround)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.txtSpecification)
        Me.Controls.Add(Me.lblFilterby)
        Me.Controls.Add(Me.cbxFilterMethod)
        Me.Controls.Add(Me.dgvMyCollection)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MyCollection"
        Me.Text = "MyCollection"
        CType(Me.dgvMyCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMyCollection As DataGridView
    Friend WithEvents MyCollectionDataSet As MyCollectionDataSet
    Friend WithEvents CollectionBindingSource As BindingSource
    Friend WithEvents CollectionTableAdapter As MyCollectionDataSetTableAdapters.CollectionTableAdapter
    Friend WithEvents cbxFilterMethod As ComboBox
    Friend WithEvents lblFilterby As Label
    Friend WithEvents txtSpecification As TextBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnBackGround As Button
    Friend WithEvents txtHackThePlanet As TextBox
End Class
