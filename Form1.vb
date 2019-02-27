Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    'Set up form to submit sql queries for storing data
    Dim mycollectionset As New DataSet()
    Dim mycollectiontable As String = "Magic_Colletion_Base"
    Dim connectionstring As String = "Data Source=gaming.tstc.edu;Initial Catalog=JPhillipsPROJ1ITSE2334;User ID=jphillips; Password=1574438"
    Dim mycollectionconnection As New SqlConnection(connectionstring)
    Dim mycollectionadapter As New SqlDataAdapter()
    Dim command As SqlCommand
    Dim query As String = ""


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'format form for awesome viewing such as
        'background and coheasion of colors
        Me.StartPosition = FormStartPosition.CenterScreen
        txtColorlessCost.Text = 0
        txtColorCost.Text = 0
        txtPower.Text = 0
        txtToughness.Text = 0
        gbxColorlessCost.ForeColor = Color.White
        btnSubmit.ForeColor = Color.Black
        tsmSymbolMenu.ToolTipText = "Select a Symbol to autofill the 'Release' box"
        '
        'Auto Complete for Name field to save time for the user
        '
        'Dim autocollection As New AutoCompleteSource()
        'Dim x As Integer = 0
        'Dim y As Integer = mycollectionset.Tables("Collection").Rows.Count
        'For x = 0 To y
        '    autocollection.(mycollectionset.Tables("Collection").Rows(x)(0).ToString)
        'Next
        'txtName.AutoCompleteCustomSource = autocollection




    End Sub

    Public Property gs_query()
        Get
            Return query
        End Get
        Set(value)
            query = value
        End Set
    End Property




    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'it is good practice to initialize variable
        'before use
        Dim colortype As String = ""
        Dim color As String = ""
        Dim cardname As String = ""
        Dim totalcost As Integer = 0
        Dim colorlesscost As Integer = 0
        Dim colorcost As Integer = 0
        Dim supertype As String = ""
        Dim subtype As String = ""
        Dim release As String = ""
        Dim abilities As String = ""
        Dim flavortext As String = ""
        Dim power As Integer = 0
        Dim toughness As Integer = 0
        Dim storage As String = ""
        Dim quantity As Integer = 1
        'work with text boxes to include all colors for 
        'multicolored creatures and eldrazi type makeups
        If chkArtifact.Checked = True Then
            color = color + "Colorless "
        End If
        If chkBlack.Checked = True Then
            color = color + "Black "
        End If
        If chkBlue.Checked = True Then
            color = color + "Blue "
        End If
        If chkDevoid.Checked = True Then
            color = color + "Devoid "
        End If
        If chkGreen.Checked = True Then
            color = color + "Green "
        End If
        If chkRed.Checked = True Then
            color = color + "Red "
        End If
        If chkWhite.Checked = True Then
            color = color + "White "
        End If

        If chkMulticolored.Checked = True Then
            colortype = "Multi-colored"
        Else
            colortype = "Mono-colored"
        End If

        If chkCreature.Checked = True Then
            supertype = supertype + "Creature "
        End If

        If chkEnchantment.Checked = True Then
            supertype = supertype + "Enchantment "
        End If

        If chkInstant.Checked = True Then
            supertype = supertype + "Instant "
        End If
        If chkSorcery.Checked = True Then
            supertype = supertype + "Sorcery "
        End If
        If chkLand.Checked = True Then
            supertype = supertype + "Land "
        End If
        ' transfer info to variables for easier 
        ' use 
        cardname = txtName.Text
        colorlesscost = txtColorlessCost.Text
        colorcost = txtColorCost.Text
        totalcost = colorcost + colorlesscost
        subtype = txtType.Text
        release = txtRelease.Text
        abilities = txtAbilities.Text
        flavortext = txtFlavorText.Text
        power = txtPower.Text
        toughness = txtToughness.Text
        storage = txtLocation.Text
        quantity = 1
        storage = storage.Replace("'", "")
        cardname = cardname.Replace("'", "")
        abilities = abilities.Replace("'", "")
        flavortext = flavortext.Replace("'", "")
        ' set query for the base table
        query = "Insert Into Magic_Collection_Base(CardName, Release, Color, CardType) Values ( '" & cardname & "','" & release & "','" & color & "','" & supertype & "');"
        'card added message for feed back to the user
        Try
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
            MessageBox.Show("Card added", "", MessageBoxButtons.OK)
        Catch ex As Exception
            mycollectionconnection.Close()
            query = "UPDATE Magic_Collection_Base Set QTY = QTY +1 Where CardName = '" & cardname & "' "
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
        End Try
        'set query for the in depth information database of the card
        query = "Insert Into Magic_Colletion_Depth  
               (CardName ,
                Release ,           
                Color, 
                CardType,                            
                ColorType,                       
                TotalCost, 
                ColorCost, 
                ColorlessCost, 
                SuperType, 
                Subtype, 
                Text, 
                FlavorText,
                Power, 
                Toughness, 
                QTY , 
                Storage)
                Values
                ('" & cardname & "',
                 '" & release & "',
                '" & color & "',
                '" & supertype & "',
                '" & colortype & "',
                '" & totalcost & "',
                '" & colorcost & "',
                '" & colorlesscost & "',
                '" & supertype & "',
                '" & subtype & "',
                '" & abilities & "',
                '" & flavortext & "',
                '" & power & "',
                '" & toughness & "',
                '" & quantity & "',
                '" & storage & "')"
        'card added message for feed back to the user
        ' duplicat added message to tell the user that 
        'the quantitiy has been incremented
        Try
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
            MessageBox.Show("Card added", "", MessageBoxButtons.OK)
        Catch ex As Exception
            mycollectionconnection.Close()
            query = "UPDATE Magic_Colletion_Depth Set QTY = QTY +1 Where CardName = '" & cardname & "' "
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
            MessageBox.Show(ex, "Duplicate added", "", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub MyCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MyCollectionToolStripMenuItem.Click
        Dim collection = New MyCollection()
        collection.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' click events to auto fill the release text box with the name of the release based on symbol
    Private Sub KaladeshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaladeshToolStripMenuItem.Click
        txtRelease.Text = "Kaladesh"
    End Sub

    Private Sub NissaVsObNixilisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NissaVsObNixilisToolStripMenuItem.Click
        txtRelease.Text = "Nissa vs Ob Nixilis"
    End Sub

    Private Sub ConspiracyTakeTheCrownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConspiracyTakeTheCrownToolStripMenuItem.Click
        txtRelease.Text = "Conspiracy: Take The Crown"
    End Sub

    Private Sub FromTheVaultLoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromTheVaultLoreToolStripMenuItem.Click
        txtRelease.Text = "From the Vault: Lore"
    End Sub

    Private Sub EldritchMoonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EldritchMoonToolStripMenuItem.Click
        txtRelease.Text = "Eldritch Moon"
    End Sub

    Private Sub EternalMastersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EternalMastersToolStripMenuItem.Click
        txtRelease.Text = "Eternal Masters"
    End Sub

    Private Sub ShadowsOverInnistradToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShadowsOverInnistradToolStripMenuItem.Click
        txtRelease.Text = "Shadows Over Innistrad"
    End Sub

    Private Sub BlessedVsCursedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlessedVsCursedToolStripMenuItem.Click
        txtRelease.Text = "Blessed vs. Cursed"
    End Sub

    Private Sub OathOfTheGarewatchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OathOfTheGarewatchToolStripMenuItem.Click
        txtRelease.Text = "Oath of the Gatewatch"
    End Sub

    Private Sub LegendaryCubeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LegendaryCubeToolStripMenuItem.Click
        txtRelease.Text = "Legendary Cube"
    End Sub

    Private Sub Commander2015ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Commander2015ToolStripMenuItem.Click
        txtRelease.Text = "Commander 2015"
    End Sub

    Private Sub ZendikarExpeditionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZendikarExpeditionsToolStripMenuItem.Click
        txtRelease.Text = "Zendikar Expeditions"
    End Sub

    Private Sub BattleForZendikarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BattleForZendikarToolStripMenuItem.Click
        txtRelease.Text = "Battle for Zendikar"
    End Sub

    Private Sub ZendikarVsEldraziToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZendikarVsEldraziToolStripMenuItem.Click
        txtRelease.Text = "Zendikar vs.Eldrazi"
    End Sub

    Private Sub FromTheVaultAngelsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromTheVaultAngelsToolStripMenuItem.Click
        txtRelease.Text = "From the Vault: Angels"
    End Sub

    Private Sub MagicOriginsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MagicOriginsToolStripMenuItem.Click
        txtRelease.Text = "Magic Origins"
    End Sub

    Private Sub ModernMasters2015ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModernMasters2015ToolStripMenuItem.Click
        txtRelease.Text = "Modern Masters 2015"
    End Sub

    Private Sub DragonsOfTarkirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DragonsOfTarkirToolStripMenuItem.Click
        txtRelease.Text = "Dragons of Tarkir"
    End Sub

    Private Sub ElspethVsKioraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElspethVsKioraToolStripMenuItem.Click
        txtRelease.Text = "Elspeth vs. Kiora"
    End Sub

    Private Sub FateReforgedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FateReforgedToolStripMenuItem.Click
        txtRelease.Text = "Fate Reforged"
    End Sub

    Private Sub AnthologyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnthologyToolStripMenuItem.Click
        txtRelease.Text = "Anthology"
    End Sub

    Private Sub KhansOfTarkirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhansOfTarkirToolStripMenuItem.Click
        txtRelease.Text = "Khans of Tarkir"
    End Sub

    Private Sub SpeedVsCunningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeedVsCunningToolStripMenuItem.Click
        txtRelease.Text = "Speed vs. Cunning"
    End Sub

    Private Sub AnnihilationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnihilationToolStripMenuItem.Click
        txtRelease.Text = "Annihilation"
    End Sub

    Private Sub Magic2015ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Magic2015ToolStripMenuItem.Click
        txtRelease.Text = "Magic 2015"
    End Sub

    Private Sub LegendaryCubeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LegendaryCubeToolStripMenuItem.Click
        txtRelease.Text = "Legendary Cube"
    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged



    End Sub
End Class
