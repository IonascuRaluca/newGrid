Imports System.Data.SqlClient
Public Class Form1

    Dim ServerName As String = "DESKTOP-FGDCK43\SQLEXPRESS"
    Dim DataBaseName As String = "Tema"
    Dim cnn As New SqlConnection("Data Source=" & ServerName & ";Initial Catalog=" & DataBaseName & ";User ID=sa;Password=deviz;Pooling=True;")


    Dim adp As New SqlDataAdapter
    Dim cmd As New SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPersoane.Click
        Dim dt As New DataTable
        DataGridView1.DataSource = dt


        adp.SelectCommand = cmd
        cmd.CommandText = "Select * from Persoane"
        cmd.Connection = cnn

        adp.Fill(dt)

    End Sub

    Private Sub BtnFacultate_Click(sender As Object, e As EventArgs) Handles BtnFacultate.Click
        Dim dt As New DataTable
        DataGridView1.DataSource = dt


        adp.SelectCommand = cmd
        cmd.CommandText = "Select * from Facultate"
        cmd.Connection = cnn

        adp.Fill(dt)
    End Sub

    Private Sub BtnJudet_Click(sender As Object, e As EventArgs) Handles BtnJudet.Click
        Dim dt As New DataTable
        DataGridView1.DataSource = dt


        adp.SelectCommand = cmd
        cmd.CommandText = "Select * from Judet"
        cmd.Connection = cnn

        adp.Fill(dt)

    End Sub
End Class
