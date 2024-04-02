Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Dim conn As MySqlConnection
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=ness;database=students"

        Try
            conn.Open()

            Dim id = CInt(TextBox1.Text)
            Dim teachername As String = TextBox2.Text
            Dim course As String = TextBox3.Text
            Dim courseid = CInt(TextBox4.Text)

            Dim stm As String = $"INSERT INTO teachers (teacher_id, teacher_name, dept, course_id) VALUES ({id}, '{teachername}', '{course}', {courseid})"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=ness;database=students"

        Try
            conn.Open()


            Dim name As String = TextBox2.Text
            Dim stm As String = $"SELECT teacher_id, teacher_name, dept FROM teachers WHERE teacher_name = '{name}'"
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=ness;database=students"

        Try
            conn.Open()


            Dim name As String = TextBox2.Text
            Dim stm As String = $"DELETE FROM teachers WHERE teacher_name = '{name}'"
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