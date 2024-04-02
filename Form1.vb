Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Form1
    Dim conn As MySqlConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.IsMdiContainer = True
        With Form2
            'sets the current multiple-document interface(MDI) parent form of this form
            .MdiParent = Me
            'show the form2
            .Show()
        End With



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.IsMdiContainer = True
        With Form3
            'sets the current multiple-document interface(MDI) parent form of this form
            .MdiParent = Me
            'show the form3
            .Show()
        End With

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


    End Sub
End Class

