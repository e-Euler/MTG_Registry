Imports System.Data
Imports System.Data.SqlClient
Public Class YugiohEntry
    'setup the form for sql queries
    Dim mycollectionset As New DataSet()
    Dim mycollectiontable As String = "Pokemon_Collection_Base"
    Dim connectionstring As String = "Data Source=gaming.tstc.edu;Initial Catalog=JPhillipsPROJ1ITSE2334;User ID=jphillips; Password=1574438"
    Dim mycollectionconnection As New SqlConnection(connectionstring)
    Dim mycollectionadapter As New SqlDataAdapter()
    Dim command As SqlCommand
    Dim query As String = ""

    Private Sub CollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollectionToolStripMenuItem.Click
        ' view the entire collection
        Dim collection As New YugioCollection()
        collection.Show()
    End Sub

    Private Sub YugiohEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load formating
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' translate all input information to variables for input to database
        Dim cardname As String = txtCardName.Text()
        Dim element As String = cbxElement.SelectedText()
        Dim release As String = txtRelease.Text()
        Dim type As String = txtType.Text()
        Dim text As String = txtText.Text()
        Dim attack As Integer = txtAttack.Text()
        Dim defense As Integer = txtDefense.Text()
        Dim quantity As Integer = 1
        Dim storage As String = txtStorage.Text()
        'general query setup
        query = "Insert Into Yugio_Collection_Base
                (CardName,
                Release,
                Element,
                CardType)
                Values
                ('" & cardname & "',
                '" & release & "',
                 '" & element & "',
                '" & type & "');"
        'execut general query
        Try
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
            MessageBox.Show("Card added", "", MessageBoxButtons.OK)
        Catch ex As Exception
            mycollectionconnection.Close()
            query = "UPDATE Yugioh_Collection_Base Set QTY = QTY +1 Where CardName = '" & Name & "' "
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
        End Try
        ' in depth query to send to the database
        query = "Insert Into Yugioh_Collection_Depth  
                    (CardName,  
                    Release,  
                    Element,
                    CardType,  
                    Cost,
                    Type,  
                    Text,
                    Attack,  
                    Defense,
                    Qty,  
                    Storage)
                    Values
                    ('" & cardname & "'
                    '" & release & "'
                    '" & element & "'
                    '" & type & "'
                    '" & txtCost.Text & "'
                    '" & text & "'
                    '" & attack & "'
                    '" & defense & "'
                    '" & quantity & "'
                    '" & storage & "';"
        'execute in depth query
        Try
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
            MessageBox.Show("Card added", "", MessageBoxButtons.OK)
        Catch ex As Exception
            mycollectionconnection.Close()
            query = "UPDATE Yugioh_Collection_Depth Set QTY = QTY +1 Where CardName = '" & Name & "' "
            command = New SqlCommand(query, mycollectionconnection)
            mycollectionconnection.Open()
            command.ExecuteNonQuery()
            mycollectionconnection.Close()
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class