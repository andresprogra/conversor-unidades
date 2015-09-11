Public Class Datos

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = Me.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub
    Dim kb, mb, gb, tb As Double
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                Label1.Text = TextBox1.Text
                mb = TextBox1.Text * 0.001
                gb = (TextBox1.Text * 0.0110241) / 10241
                tb = (TextBox1.Text * 0.000100241) / 100241
                'Label1.Text = FormatNumber((Val(kb)),-1)
                Label2.Text = FormatNumber((Val(mb)), -1)
                Label3.Text = FormatNumber((Val(gb)), -1)
                Label4.Text = FormatNumber((Val(tb)), -1)
            Case 1
                kb = TextBox1.Text * 1024
                mb = TextBox1.Text
                gb = TextBox1.Text / 1024
                tb = TextBox1.Text * 0.0000000953674316
                Label1.Text = FormatNumber((Val(kb)), -1)
                Label2.Text = FormatNumber((Val(mb)), -1)
                Label3.Text = FormatNumber((Val(gb)), -1)
                Label4.Text = FormatNumber((Val(tb)), -1)
            Case 2
                kb = TextBox1.Text * 1048576
                mb = TextBox1.Text * 1024
                gb = TextBox1.Text
                tb = TextBox1.Text / 1024
                Label1.Text = FormatNumber((Val(kb)), -1)
                Label2.Text = FormatNumber((Val(mb)), -1)
                Label3.Text = FormatNumber((Val(gb)), -1)
                Label4.Text = FormatNumber((Val(tb)), -1)
            Case 3
                kb = TextBox1.Text * 1073741824
                mb = TextBox1.Text * 1048576
                gb = TextBox1.Text * 1024
                tb = TextBox1.Text
                Label1.Text = FormatNumber((Val(kb)), -1)
                Label2.Text = FormatNumber((Val(mb)), -1)
                Label3.Text = FormatNumber((Val(gb)), -1)
                Label4.Text = FormatNumber((Val(tb)), -1)




        End Select

    End Sub
End Class