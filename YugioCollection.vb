Imports System.Data
Imports System.Data.SqlClient

Public Class YugioCollection
    'setup for the use of sql queries
    Dim mycollectionset As New DataSet()
    Dim mycollectiontable As String = "Pokemon_Collection_Depth"
    Dim connectionstring As String = "Data Source=gaming.tstc.edu;Initial Catalog=JPhillipsPROJ1ITSE2334;User ID=jphillips; Password=1574438"
    Dim mycollectionconnection As New SqlConnection(connectionstring)
    Dim mycollectionadapter As New SqlDataAdapter()
    Dim command As SqlCommand
    Dim query As String = ""
    Private Sub btnBackGround_Click(sender As Object, e As EventArgs) Handles btnBackGround.Click
        'allow user to view background
        If (btnBackGround.Text = "Show Background") Then
            dgvYugiohCollection.Visible = False
            cbxFilterMethod.Visible = False
            txtSpecification.Visible = False
            btnBackGround.Text = "Show Data"
            btnFilter.Visible = False
        ElseIf (btnBackGround.Text = "Show Data") Then
            dgvYugiohCollection.Visible = True
            cbxFilterMethod.Visible = True
            txtSpecification.Visible = True
            btnBackGround.Text = "Show Background"
            btnFilter.Visible = True
        End If
    End Sub

    Private Sub YugioCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load format adjustments
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackgroundImageLayout = ImageLayout.Stretch
        txtHackThePlanet.Visible = False
        'initial load data display
        txtHackThePlanet.Text = "Table Name = Yugioh_Collection_Base"
        query = "Select * from " + mycollectiontable
        cbxFilterMethod.SelectedText = "Color"
        Try
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionadapter.SelectCommand = command
            mycollectionconnection.Open()
            mycollectionset.Clear()
            mycollectionadapter.Fill(mycollectionset, mycollectiontable)
            mycollectionconnection.Close()
        Catch ex As Exception
            MessageBox.Show("Database connection problems!" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        'format datagrid view
        dgvYugiohCollection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvYugiohCollection.DataSource = mycollectionset.Tables(mycollectiontable)
        dgvYugiohCollection.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvYugiohCollection.EditMode = DataGridViewEditMode.EditProgrammatically
    End Sub

    Private Sub dgvYugiohCollection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYugiohCollection.CellContentClick
        Dim card As New frmCardvb()
        'pass all information to the card form to view the card in easy to view format

        'unfortunatly i have run out of time and need to take my kid the the hospital
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'card.lblCardName.Text = dgvYugiohCollection.SelectedRows(0).Cells(0).Value.ToString()
        'card.lblTypeandSubType.Text = dgvYugiohCollection.SelectedRows(0).Cells(3).Value.ToString() + " - " + dgvYugiohCollection.SelectedRows(0).Cells(7).Value.ToString()
        'card.lblColorlessCost.Text = dgvYugiohCollection.SelectedRows(0).Cells(5).Value.ToString()
        'card.lblColorCost.Text = dgvYugiohCollection.SelectedRows(0).Cells(6).Value.ToString()
        'card.lblAbilities.Text = dgvYugiohCollection.SelectedRows(0).Cells(9).Value.ToString()
        'card.lblFlavortext.Text = dgvYugiohCollection.SelectedRows(0).Cells(10).Value.ToString()
        'card.lblPower.Text = dgvYugiohCollection.SelectedRows(0).Cells(11).Value.ToString()
        'card.lblToughness.Text = dgvYugiohCollection.SelectedRows(0).Cells(12).Value.ToString()
        'card.lblRelease.Text = dgvYugiohCollection.SelectedRows(0).Cells(8).Value.ToString()
        'card.Show()
    End Sub
End Class