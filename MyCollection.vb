Imports System.Data
Imports System.Data.SqlClient
Public Class MyCollection
    'setup for use of sql queries to populate the dgv
    Dim mycollectionset As New DataSet()
    Dim mycollectiontable As String = "Magic_Colletion_Depth"
    Dim connectionstring As String = "Data Source=gaming.tstc.edu;Initial Catalog=JPhillipsPROJ1ITSE2334;User ID=jphillips; Password=1574438"
    Dim mycollectionconnection As New SqlConnection(connectionstring)
    Dim mycollectionadapter As New SqlDataAdapter()
    Dim command As SqlCommand
    Dim query As String = ""
    Private Sub MyCollection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'setup back door sql section
        Me.BackgroundImageLayout = ImageLayout.Stretch
        txtHackThePlanet.Visible = False
        txtHackThePlanet.Text = "Table Name = Magic_Colletion_Depth"
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
        'set format of form for quality viewing
        dgvMyCollection.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMyCollection.DataSource = mycollectionset.Tables(mycollectiontable)
        dgvMyCollection.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyCollection.EditMode = DataGridViewEditMode.EditProgrammatically
    End Sub

    Private Sub dgvMyCollection_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMyCollection.CellContentDoubleClick
        Dim card As New frmCardvb()
        ' setup and show the individual card information form
        card.lblCardName.Text = dgvMyCollection.SelectedRows(0).Cells(1).Value.ToString()
        card.lblTypeandSubType.Text = dgvMyCollection.SelectedRows(0).Cells(3).Value.ToString() + " - " + dgvMyCollection.SelectedRows(0).Cells(7).Value.ToString()
        card.lblColorlessCost.Text = dgvMyCollection.SelectedRows(0).Cells(5).Value.ToString()
        card.lblColorCost.Text = dgvMyCollection.SelectedRows(0).Cells(6).Value.ToString()
        card.lblAbilities.Text = dgvMyCollection.SelectedRows(0).Cells(9).Value.ToString()
        card.lblFlavortext.Text = dgvMyCollection.SelectedRows(0).Cells(10).Value.ToString()
        card.lblPower.Text = dgvMyCollection.SelectedRows(0).Cells(11).Value.ToString()
        card.lblToughness.Text = dgvMyCollection.SelectedRows(0).Cells(12).Value.ToString()
        card.lblRelease.Text = dgvMyCollection.SelectedRows(0).Cells(8).Value.ToString()
        card.Show()
    End Sub

    Private Sub cbxFilterMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFilterMethod.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ' setup filters
        ' and give a hint to required input for numeric fields
        If cbxFilterMethod.Text = "Color" Then
            query = "Select * from " + mycollectiontable + " Where Color Like '%" & txtSpecification.Text & "%'"
        End If
        If cbxFilterMethod.Text = "Card Name" Then
            query = "Select * from " + mycollectiontable + " Where CardName LIKE '%" & txtSpecification.Text & "%'"
        End If
        Try
            If cbxFilterMethod.Text = "Total Cost" Then
                Dim totalcost As Integer = txtSpecification.Text
                query = "Select * from " + mycollectiontable + " Where TotalCost = '" & totalcost & "'"
            End If
        Catch
            MessageBox.Show("Power requires a numeric value", "", MessageBoxButtons.OK)
        End Try
        If cbxFilterMethod.Text = "Color Cost" Then
            Try
                Dim colorcost As Integer = txtSpecification.Text
                query = "Select * from " + mycollectiontable + " Where ColorCost = '" & colorcost & "'"
            Catch
                MessageBox.Show("Power requires a numeric value", "", MessageBoxButtons.OK)
            End Try
        End If
        If cbxFilterMethod.Text = "Colorless Cost" Then
            Try
                Dim colorlesscost As Integer = txtSpecification.Text
                query = "Select * from " + mycollectiontable + " Where ColorlessCost = '" & colorlesscost & "'"
            Catch
                MessageBox.Show("Power requires a numeric value", "", MessageBoxButtons.OK)
            End Try
        End If
        If cbxFilterMethod.Text = "Release" Then
            query = "Select * from " + mycollectiontable + " Where Release = '" & txtSpecification.Text & "'"
        End If
        If cbxFilterMethod.Text = "SuperType" Then
            query = "Select * from " + mycollectiontable + " Where SuperType = '" & txtSpecification.Text & "'"
        End If
        If cbxFilterMethod.Text = "SubType" Then
            query = "Select * from " + mycollectiontable + " Where Subtype = '" & txtSpecification.Text & "'"
        End If
        Try
            If cbxFilterMethod.Text = "Power" Then
                Dim power As Integer = txtSpecification.Text
                query = "Select * from " + mycollectiontable + " Where Power = " & power & ""
            End If
        Catch
            MessageBox.Show("Power requires a numeric value", "", MessageBoxButtons.OK)
        End Try
        Try
            If cbxFilterMethod.Text = "Toughness" Then
                Dim toughness As Integer = txtSpecification.Text
                query = "Select * from " + mycollectiontable + " Where Toughness = " & toughness & ""
            End If
        Catch
            MessageBox.Show("Toughness requires a numeric value", "", MessageBoxButtons.OK)
        End Try
        Try
            If cbxFilterMethod.Text = "Quantity" Then
                Dim quantity As Integer = txtSpecification.Text
                query = "Select * from " + mycollectiontable + " Where QTY = " & quantity & ""
            End If
        Catch
            MessageBox.Show("Quantity requires a numeric value", "", MessageBoxButtons.OK)
        End Try
        If cbxFilterMethod.Text = "Abilities" Then
            query = "Select * from " + mycollectiontable + " Where Abilities LIKE '%" & txtSpecification.Text & "%'"
        End If
        If cbxFilterMethod.Text = "No Filter" Then
            query = "Select * From " + mycollectiontable + ""
        End If
        If txtSpecification.Text = "Planet Hacked!" Then
            txtHackThePlanet.Visible = False
            txtSpecification.Clear()
            query = "Select * from Magic_" + mycollectiontable + "_Base"
        End If
        If txtHackThePlanet.Visible.Equals(True) Then
            Try
                query = txtHackThePlanet.Text
            Catch ex As Exception
                MessageBox.Show("It Didn't Work")
            End Try
        End If
        If txtSpecification.Text = "Hack the Planet!" Then
            txtHackThePlanet.Visible = True
            txtSpecification.Clear()
            query = "Select * from " + mycollectiontable
        End If

        'after query is built submit it to the database
        Try
            mycollectionconnection.Close()
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionadapter.SelectCommand = command
            mycollectionconnection.Open()
            mycollectionset.Clear()
            mycollectionadapter.Fill(mycollectionset, mycollectiontable)
            mycollectionconnection.Close()
        Catch ex As Exception
            MessageBox.Show("Database connection problems!" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        dgvMyCollection.DataSource = mycollectionset.Tables(mycollectiontable)



    End Sub

    Private Sub btnBackGround_Click(sender As Object, e As EventArgs) Handles btnBackGround.Click
        'allow the user to view the background and/or hide the card information
        If btnBackGround.Text = "Show Background" Then

            cbxFilterMethod.Visible = False
            btnFilter.Visible = False
            lblFilterby.Visible = False
            txtSpecification.Visible = False
            dgvMyCollection.Visible = False
            btnBackGround.Text = "Show Data"
        Else
            lblFilterby.Visible = True
            cbxFilterMethod.Visible = True
            btnFilter.Visible = True
            txtSpecification.Visible = True
            dgvMyCollection.Visible = True
            btnBackGround.Text = "Show Background"
        End If
    End Sub

    Private Sub dgvMyCollection_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMyCollection.CellContentClick
        Dim card = New frmCardvb()
        ' card.lblCardName = 
    End Sub
End Class