<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(25, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(742, 62)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(310, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 25)
        Label1.TabIndex = 0
        Label1.Text = "TEACHERS"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(25, 108)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(300, 262)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(117, 201)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(150, 31)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(117, 147)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(117, 89)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(117, 28)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(0, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 25)
        Label5.TabIndex = 3
        Label5.Text = "Courseid"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 25)
        Label4.TabIndex = 2
        Label4.Text = "COURSE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 1
        Label3.Text = "NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 25)
        Label2.TabIndex = 0
        Label2.Text = "TEACHER ID"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Location = New Point(467, 118)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(300, 150)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 30)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(288, 103)
        DataGridView1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(35, 390)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 3
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(190, 390)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 4
        Button2.Text = "SEARCH"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(356, 390)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 5
        Button3.Text = "VIEW"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(511, 390)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 6
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(676, 390)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 7
        Button5.Text = "CLOSE"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
