Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Form1
    Dim conn As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=ness;database=world"

        Try
            conn.Open()
            Dim strInput As String

            Dim country As String = TextBox1.Text
            Dim stm As String = $"SELECT `Name`, `Continent`, `Region`, `Population`, `LifeExpectancy` FROM country WHERE `Continent` = '{country}' "
            Dim da As New MySqlDataAdapter(stm, conn)
            Dim ds As New DataSet()
            If da.Fill(ds) Then
                DataGridView1.DataSource = ds.Tables(0)
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub
End Class

