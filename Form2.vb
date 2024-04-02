Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Form2
    Dim conn As MySqlConnection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=ness;database=students"

        Try
            conn.Open()

            Dim id = CInt(TextBox1.Text)
            Dim studentname As String = TextBox3.Text
            Dim gender As String = TextBox2.Text
            Dim course As String = TextBox4.Text
            Dim year = CInt(TextBox5.Text)
            Dim hall As String = TextBox6.Text
            Dim grades As String = TextBox7.Text
            Dim stm As String = $"INSERT INTO student_details (ID, name, dept, hall, studentgrades, gender, year) VALUES ({id}, '{studentname}', '{course}', '{hall}', '{grades}', '{gender}', {year})"
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



            Dim stm As String = "SELECT `ID`, `name`, `dept`, `hall`, `studentgrades`, `gender`, `year` FROM student_details "
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=ness;database=students"

        Try
            conn.Open()


            Dim name As String = TextBox3.Text
            Dim stm As String = $"DELETE FROM student_details WHERE name = '{name}'"
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

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=ness;database=students"

        Try
            conn.Open()


            Dim studentname As String = TextBox3.Text
            Dim stm As String = $"SELECT ID, name, dept, hall, studentgrades, gender, year FROM student_details WHERE name = '{studentname}'"
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