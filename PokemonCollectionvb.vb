Imports System.Data
Imports System.Data.SqlClient

Public Class PokemonCollection
    'setup the form to perform sql queries
    Dim mycollectionset As New DataSet()
    Dim mycollectiontable As String = "Pokemon_Collection_Depth"
    Dim connectionstring As String = "Data Source=gaming.tstc.edu;Initial Catalog=JPhillipsPROJ1ITSE2334;User ID=jphillips; Password=1574438"
    Dim mycollectionconnection As New SqlConnection(connectionstring)
    Dim mycollectionadapter As New SqlDataAdapter()
    Dim command As SqlCommand
    Dim query As String = ""

    Private Sub btnBackGround_Click(sender As Object, e As EventArgs) Handles btnBackGround.Click
        ' allow the user to view the background
        If btnBackGround.Text = "Show Background" Then

            cbxFilterMethod.Visible = False
            btnFilter.Visible = False
            lblFilterby.Visible = False
            txtSpecification.Visible = False
            dgvPokemonCollection.Visible = False
            btnBackGround.Text = "Show Data"
        Else
            lblFilterby.Visible = True
            cbxFilterMethod.Visible = True
            btnFilter.Visible = True
            txtSpecification.Visible = True
            dgvPokemonCollection.Visible = True
            btnBackGround.Text = "Show Background"
        End If
    End Sub

    Private Sub dgvPokemonCollection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPokemonCollection.CellContentClick
        Dim card As New PokemonCard()
        ' send all collected data to the next form to put it in card layout for full viewing of the card
        card.txtCardName.Text = dgvPokemonCollection.SelectedRows(0).Cells(0).Value.ToString()
        card.txtHP.Text = dgvPokemonCollection.SelectedRows(0).Cells(18).Value.ToString()
        card.txtAbility.Text = dgvPokemonCollection.SelectedRows(0).Cells(5).Value.ToString()
        card.txtAttack1Name.Text = dgvPokemonCollection.SelectedRows(0).Cells(6).Value.ToString() + vbCrLf +
            dgvPokemonCollection.SelectedRows(0).Cells(9).Value.ToString()
        card.txtAttack1Cost.Text = dgvPokemonCollection.SelectedRows(0).Cells(7).Value.ToString()
        card.txtAttack1power.Text = dgvPokemonCollection.SelectedRows(0).Cells(8).Value.ToString()

        'card.lblColorlessCost.Text = dgvPokemonCollection.SelectedRows(0).Cells(5).Value.ToString()
        'card.lblColorCost.Text = dgvPokemonCollection.SelectedRows(0).Cells(6).Value.ToString()
        'card.lblAbilities.Text = dgvPokemonCollection.SelectedRows(0).Cells(9).Value.ToString()
        'card.lblFlavortext.Text = dgvPokemonCollection.SelectedRows(0).Cells(10).Value.ToString()
        'card.lblPower.Text = dgvPokemonCollection.SelectedRows(0).Cells(11).Value.ToString()
        'card.lblToughness.Text = dgvPokemonCollection.SelectedRows(0).Cells(12).Value.ToString()
        'card.lblRelease.Text = dgvPokemonCollection.SelectedRows(0).Cells(8).Value.ToString()
        card.Show()
    End Sub

    Private Sub PokemonCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the form in a easy to view format
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackgroundImageLayout = ImageLayout.Stretch
        txtHackThePlanet.Visible = False
        ' load all information for viewing on load
        txtHackThePlanet.Text = "Table Name = Pokemon_Collection_Base"
        query = "Select * from " + mycollectiontable
        cbxFilterMethod.SelectedText = "Color"
        ' execute load query
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
        ' format data grid view
        dgvPokemonCollection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPokemonCollection.DataSource = mycollectionset.Tables(mycollectiontable)
        dgvPokemonCollection.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPokemonCollection.EditMode = DataGridViewEditMode.EditProgrammatically
    End Sub
End Class