Public Class Tiempo

    Private Sub Tiempo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = Me.Text

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub
    Dim min, horas, segundos, dias, meses, años As Double

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Enabled = False
        ComboBox1.Enabled = False
        Label1.Text = "-"
        Label2.Text = "-"
        Label6.Text = "-"
        Label5.Text = "-"
        Label10.Text = "-"
        Label12.Text = "-"

        Select Case ComboBox1.SelectedIndex
            Case 0
                min = TextBox1.Text
                horas = TextBox1.Text * 0.0166666667
                segundos = TextBox1.Text * 60
                dias = TextBox1.Text * 0.000694444444
                meses = (TextBox1.Text * 0.00136895463) / 60
                años = (TextBox1.Text * 0.000114079553) / 60
                Label1.Text = FormatNumber((Val(min)), -1)
                Label2.Text = FormatNumber((Val(horas)), -1)
                Label6.Text = FormatNumber((Val(segundos)), -1)
                Label5.Text = FormatNumber((Val(dias)), -1)
                Label10.Text = FormatNumber((Val(meses)), -1)
                Label12.Text = FormatNumber((Val(años)), -1)
            Case 1
                min = TextBox1.Text / 60
                horas = TextBox1.Text
                segundos = TextBox1.Text * 3600
                dias = TextBox1.Text * 0.0416666667
                meses = TextBox1.Text * 0.00136895463
                años = TextBox1.Text * 0.000114079553
                Label1.Text = FormatNumber((Val(min)), -1)
                Label2.Text = FormatNumber((Val(horas)), -1)
                Label6.Text = FormatNumber((Val(segundos)), -1)
                Label5.Text = FormatNumber((Val(dias)), -1)
                Label10.Text = FormatNumber((Val(meses)), -1)
                Label12.Text = FormatNumber((Val(años)), -1)
            Case 2
                min = TextBox1.Text * 0.0166666667
                horas = TextBox1.Text * 0.000277777778
                segundos = TextBox1.Text
                dias = (TextBox1.Text * 0.000694444444) / 60
                meses = (TextBox1.Text * 0.00136895463) / 3600
                años = (TextBox1.Text * 0.000114079553) / 3600
                Label1.Text = FormatNumber((Val(min)), -1)
                Label2.Text = FormatNumber((Val(horas)), -1)
                Label6.Text = FormatNumber((Val(segundos)), -1)
                Label5.Text = FormatNumber((Val(dias)), -1)
                Label10.Text = FormatNumber((Val(meses)), -1)
                Label12.Text = FormatNumber((Val(años)), -1)
            Case 3
                min = TextBox1.Text * 1440
                horas = TextBox1.Text * 24
                segundos = TextBox1.Text * 86400
                dias = TextBox1.Text
                meses = TextBox1.Text / 30
                años = TextBox1.Text / 365
                Label1.Text = FormatNumber((Val(min)), -1)
                Label2.Text = FormatNumber((Val(horas)), -1)
                Label6.Text = FormatNumber((Val(segundos)), -1)
                Label5.Text = FormatNumber((Val(dias)), -1)
                Label10.Text = FormatNumber((Val(meses)), -1)
                Label12.Text = FormatNumber((Val(años)), -1)
            Case 4
                min = TextBox1.Text * 43200
                horas = TextBox1.Text * 720
                segundos = TextBox1.Text * 2592000
                dias = TextBox1.Text * 30
                meses = TextBox1.Text
                años = TextBox1.Text / 12
                Label1.Text = FormatNumber((Val(min)), -1)
                Label2.Text = FormatNumber((Val(horas)), -1)
                Label6.Text = FormatNumber((Val(segundos)), -1)
                Label5.Text = FormatNumber((Val(dias)), -1)
                Label10.Text = FormatNumber((Val(meses)), -1)
                Label12.Text = FormatNumber((Val(años)), -1)
            Case 5
                min = TextBox1.Text * 518400
                horas = TextBox1.Text * 8640
                segundos = TextBox1.Text * 31104000
                dias = TextBox1.Text * 360
                años = TextBox1.Text
                Label1.Text = FormatNumber((Val(min)), -1)
                Label2.Text = FormatNumber((Val(horas)), -1)
                Label6.Text = FormatNumber((Val(segundos)), -1)
                Label5.Text = FormatNumber((Val(dias)), -1)
                Label10.Text = FormatNumber((Val(meses)), -1)
                Label12.Text = FormatNumber((Val(años)), -1)
        End Select
    End Sub
End Class