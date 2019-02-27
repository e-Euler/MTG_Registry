Imports System.Data.SqlClient
Imports System.Data

Public Class GameChoice

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim magicentry As New Form1()
        'Show the magic entry form
        magicentry.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim pokemonentry As New PokemonEntry()
        'show the pokemon entry form
        pokemonentry.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim yugiohentry As New YugiohEntry()
        'show the yugioh entry form
        yugiohentry.Show()

    End Sub

    Private Sub GameChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub
End Class