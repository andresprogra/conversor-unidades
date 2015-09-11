Public Class Peso

    Private Sub Peso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = Me.Text
        ComboBox1.Text = "Selecciona una opción."
        Label6.Visible = False


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        inicio.Show()
        






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label6.Visible = False
        ComboBox1.Enabled = True
        TextBox1.Enabled = True

        TextBox1.Text = ""
        ComboBox1.Text = "Selecionna una opción."
        Label1.Text = "-"
        Label2.Text = "-"
        Label3.Text = "-"
        Label4.Text = "-"
        Label5.Text = "-"

    End Sub
    Dim kg, lb, gr, tn, mg As Double
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox1.Enabled = False
        TextBox1.Enabled = False
        Label6.Visible = True





        Select Case ComboBox1.SelectedIndex

            Case 0
                kg = TextBox1.Text
                lb = TextBox1.Text * 2.20462262
                gr = TextBox1.Text * 1000
                tn = TextBox1.Text * 0.00110231131
                mg = TextBox1.Text * 1000000
                Label1.Text = FormatNumber((Val(kg)), -1)
                Label2.Text = FormatNumber((Val(lb)), -1)
                Label3.Text = FormatNumber((Val(gr)), -1)
                Label4.Text = FormatNumber((Val(tn)), -1)
                Label5.Text = FormatNumber((Val(mg)), -1)

            Case 1
                kg = TextBox1.Text * 0.45359237
                lb = TextBox1.Text
                gr = TextBox1.Text * 453.59237
                tn = TextBox1.Text * 0.0005
                mg = TextBox1.Text * 453592.37
                Label1.Text = FormatNumber((Val(kg)), -1)
                Label2.Text = FormatNumber((Val(lb)), -1)
                Label3.Text = FormatNumber((Val(gr)), -1)
                Label4.Text = FormatNumber((Val(tn)), -1)
                Label5.Text = FormatNumber((Val(mg)), -1)
            Case 2
                kg = TextBox1.Text * 0.001
                lb = TextBox1.Text * 0.00220462262
                gr = TextBox1.Text
                tn = (TextBox1.Text * 0.00110231131) / 1000
                mg = TextBox1.Text * 1000
                Label1.Text = FormatNumber((Val(kg)), -1)
                Label2.Text = FormatNumber((Val(lb)), -1)
                Label3.Text = FormatNumber((Val(gr)), -1)
                Label4.Text = FormatNumber((Val(tn)), -1)
                Label5.Text = FormatNumber((Val(mg)), -1)
            Case 3
                kg = TextBox1.Text * 907.18474
                lb = TextBox1.Text * 2000
                gr = TextBox1.Text * 907184.74
                tn = TextBox1.Text
                mg = TextBox1.Text * 907184740
                Label1.Text = FormatNumber((Val(kg)), -1)
                Label2.Text = FormatNumber((Val(lb)), -1)
                Label3.Text = FormatNumber((Val(gr)), -1)
                Label4.Text = FormatNumber((Val(tn)), -1)
                Label5.Text = FormatNumber((Val(mg)), -1)
            Case 4
                kg = (TextBox1.Text * 0.0005) / 500
                lb = (TextBox1.Text * 0.00110231131) / 500
                gr = (TextBox1.Text * 0.5) / 500
                tn = (TextBox1.Text * 0.000110231131) / 100000
                mg = TextBox1.Text * 1
                Label1.Text = FormatNumber((Val(kg)), 5)
                Label2.Text = FormatNumber((Val(lb)), 5)
                Label3.Text = FormatNumber((Val(gr)), 5)
                Label4.Text = FormatNumber((Val(tn)), 5)
                Label5.Text = FormatNumber((Val(mg)), 5)

        End Select
    End Sub
End Class