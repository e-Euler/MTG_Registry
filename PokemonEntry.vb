Imports System.Data
Imports System.Data.SqlClient

Public Class PokemonEntry
    'setup for to execute sql queries
    Dim mycollectionset As New DataSet()
    Dim mycollectiontable As String = "Pokemon_Collection_Base"
    Dim connectionstring As String = "Data Source=gaming.tstc.edu;Initial Catalog=JPhillipsPROJ1ITSE2334;User ID=jphillips; Password=1574438"
    Dim mycollectionconnection As New SqlConnection(connectionstring)
    Dim mycollectionadapter As New SqlDataAdapter()
    Dim command As SqlCommand
    Dim query As String = ""
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click, Label7.Click

    End Sub

    Private Sub CollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionToolStripMenuItem.Click
        'move to collection view
        Dim pokecollect As New PokemonCollection()
        pokecollect.Show()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'translate all form input into variables
        Dim element As String = txtElement.Text()
        Dim stage As String = txtStage.Text()
        Dim Name As String = txtName.Text()
        Dim HP As Integer = txtHP.Text()
        Dim Ability As String = txtAbility.Text()
        Dim attack1cost As Integer = txtAttack1Cost.Text()
        Dim attack1text As String = txtAttack1.Text()
        Dim attack1power As Integer = txtAttack1Power.Text()
        Dim attack2cost As Integer = txtAttack2Cost.Text()
        Dim attack2text As String = txtAttack2.Text()
        Dim attack2power As Integer = txtAttack2Power.Text()
        Dim attack3cost As Integer = txtAttack3Cost.Text()
        Dim attack3text As String = txtAttack3.Text()
        Dim attack3power As Integer = txtAttack3Strength.Text()
        Dim weakness As String = txtWeakness.Text()
        Dim Resistance As String = txtResistance.Text()
        Dim retreatcost As Integer = txtRetreat.Text()
        Dim storage As String = txtLocation.Text()
        Dim typemakup As String = ""
        ' looks to see if the multielemnt box is checked
        If chkElement.Checked = True Then
            typemakup = "Multi-Element"
        Else
            typemakup = "Single Element"
        End If
        Dim quantity As Integer = 1
        Dim cardtype As String = ""
        If chkCreature.Checked = True Then
            cardtype = "Non-Creature"
        Else
            cardtype = "Creature"
        End If

        'setup base table query
        query = "Insert Into Pokemon_Collection_Base
                (CardName,
                Release,
                Element,
                CardType)
                Values
                ('" & Name & "',
                '" & txtRelease.Text & "',
                '" & element & "',
                '" & cardtype & "')"
        ' execute query
        Try
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
            MessageBox.Show("Card added", "", MessageBoxButtons.OK)
        Catch ex As Exception
            mycollectionconnection.Close()
            query = "UPDATE Pokemon_Collection_Base Set QTY = QTY +1 Where CardName = '" & Name & "' "
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
        End Try
        ' setup in depth table query for execution
        query = "Insert Into Pokemon_Collection_Depth
                (CardName,
                Release,
                element,
                TypeMakeup,
                stage,
                Ability_Effect,
                Attack1Name,
                attack1cost,
                attack1power,
                attack1text,
                Attack2Name,
                attack2cost,
                attack2power,
                attack2text,
                Attack3Name,
                attack3cost,
                attack3power,
                attack3text,
                HP,
                retreatcost,
                storage,
                weakness,
                Resistance,
                Qty)
                Values
                ('" & Name & "',
                '" & txtRelease.Text & "',
                '" & element & "',
                '" & typemakup & "',
                '" & stage & "',
                '" & Ability & "',
                '" & txtAttack1Name.Text() & "',
                '" & attack1cost & "',
                '" & attack1power & "',
                '" & attack1text & "',
                '" & txtAttack2Name.Text() & "',
                '" & attack2cost & "',
                '" & attack2power & "',
                '" & attack2text & "',
                '" & txtAttack3Name.Text() & "',
                '" & attack3cost & "',
                '" & attack3power & "',
                '" & attack3text & "',
                '" & HP & "',
                '" & retreatcost & "',
                '" & storage & "',
                '" & weakness & "',
                '" & Resistance & "',
                '" & quantity & "')"
        'execute in depth query
        Try
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
            MessageBox.Show("Card added", "", MessageBoxButtons.OK)
        Catch ex As Exception
            mycollectionconnection.Close()
            query = "UPDATE Pokemon_Collection_Depth Set QTY = QTY +1 Where CardName = '" & Name & "' "
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
        End Try

    End Sub

    Private Sub PokemonEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' set text boxes that need integer values to a default integer
        txtAttack1Power.Text = 0
        txtAttack2Power.Text = 0
        txtAttack3Strength.Text = 0
        txtAttack3Cost.Text = 0
        txtAttack2Cost.Text = 0
        txtHP.Text = 0

    End Sub
End Class