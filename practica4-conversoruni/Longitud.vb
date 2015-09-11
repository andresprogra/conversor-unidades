Public Class longitud

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
    
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim km, millas, yardas, ft, metros, inches As Decimal
        If TextBox1.Text = "" Then
            MsgBox("Porfavor introduce un valor en el área de texto.")
        Else
            Select Case ComboBox1.SelectedIndex
                Case 0 'kilometro
                    millas = TextBox1.Text * 0.62137119
                    yardas = TextBox1.Text * 1093.6133
                    ft = TextBox1.Text * 3280.8399
                    metros = TextBox1.Text * 1000
                    inches = TextBox1.Text * 39370.0787
                    TextBox2.Text = TextBox1.Text
                    TextBox3.Text = FormatNumber((Val(TextBox1.Text) * 0.62137119), -1)

                    'TextBox3.Text = millas
                    'TextBox4.Text = yardas
                    TextBox4.Text = FormatNumber((Val(yardas)), -1)
                    'TextBox5.Text = ft
                    TextBox5.Text = FormatNumber((Val(ft)), -1)
                    'TextBox6.Text = metros
                    TextBox6.Text = FormatNumber((Val(metros)), -1)
                    'TextBox7.Text = inches
                    TextBox7.Text = FormatNumber((Val(inches)), -1)
                    TextBox1.Enabled = False
                    Label1.Visible = True
                    ComboBox1.Enabled = False
                Case 1 'millas
                    km = TextBox1.Text * 1.609344
                    yardas = TextBox1.Text * 1760
                    ft = TextBox1.Text * 5280
                    metros = TextBox1.Text * 1609.344
                    inches = TextBox1.Text * 63360
                    'TextBox2.Text = FormatNumber()
                    TextBox3.Text = TextBox1.Text
                    TextBox4.Text = yardas
                    TextBox5.Text = ft
                    TextBox6.Text = metros
                    TextBox7.Text = inches
                    TextBox1.Enabled = False
                    Label1.Visible = True
                    ComboBox1.Enabled = False
                Case 2 'yardas
                    km = TextBox1.Text * 0.0009144
                    millas = TextBox1.Text * 0.000568181818
                    yardas = TextBox1.Text * 1
                    ft = TextBox1.Text * 3
                    metros = TextBox1.Text * 0.9144
                    inches = TextBox1.Text * 36
                    TextBox2.Text = km
                    TextBox3.Text = millas
                    TextBox4.Text = yardas
                    TextBox5.Text = ft
                    TextBox6.Text = metros
                    TextBox7.Text = inches
                    TextBox1.Enabled = False
                    Label1.Visible = True
                    ComboBox1.Enabled = False
                Case 3 'pies
                    km = TextBox1.Text * 0.0003048
                    millas = TextBox1.Text * 0.000189393939
                    yardas = TextBox1.Text * 0.333333333
                    ft = TextBox1.Text * 1
                    metros = TextBox1.Text * 0.3048
                    inches = TextBox1.Text * 12
                    TextBox2.Text = km
                    TextBox3.Text = millas
                    TextBox4.Text = yardas
                    TextBox5.Text = ft
                    TextBox6.Text = metros
                    TextBox7.Text = inches
                    TextBox1.Enabled = False
                    Label1.Visible = True
                    ComboBox1.Enabled = False
                Case 4 'metros
                    km = TextBox1.Text * 0.001
                    millas = TextBox1.Text * 0.000621371192
                    yardas = TextBox1.Text * 1.0936133
                    ft = TextBox1.Text * 3.2808399
                    metros = TextBox1.Text * 1
                    inches = TextBox1.Text * 39.3700787
                    'Resultados
                    TextBox2.Text = km
                    TextBox3.Text = millas
                    TextBox4.Text = yardas
                    TextBox5.Text = ft
                    TextBox6.Text = metros
                    TextBox7.Text = inches
                    TextBox1.Enabled = False
                    Label1.Visible = True
                    ComboBox1.Enabled = False
                Case 5 'inches
                    km = (TextBox1.Text * 0.00127) / 50
                    millas = (TextBox1.Text * 0.1578125) / 9999
                    yardas = TextBox1.Text * 0.0277777778
                    ft = TextBox1.Text * 0.0833333333
                    metros = TextBox1.Text * 0.0254
                    inches = TextBox1.Text * 1
                    'Resultados
                    'TextBox2.Text = km
                    TextBox2.Text = FormatNumber((Val(km)), -1)
                    'TextBox3.Text = millas
                    TextBox3.Text = FormatNumber((Val(millas)), -1)
                    'TextBox4.Text = yardas
                    TextBox4.Text = FormatNumber((Val(yardas)), -1)
                    'TextBox5.Text = ft
                    TextBox5.Text = FormatNumber((Val(ft)), -1)
                    'TextBox6.Text = metros
                    TextBox6.Text = FormatNumber((Val(metros)), -1)
                    'TextBox7.Text = inches
                    TextBox7.Text = FormatNumber((Val(inches)), -1)
                    TextBox1.Enabled = False
                    Label1.Visible = True
                    ComboBox1.Enabled = False

            End Select
        End If
    End Sub

   

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        inicio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = True
        Label1.Visible = False
        ComboBox1.Enabled = True

        TextBox1.Text = ""
        ComboBox1.Text = "Selecciona una opción."
        TextBox2.Text = "-"
        TextBox3.Text = "-"
        TextBox4.Text = "-"
        TextBox5.Text = "-"
        TextBox6.Text = "-"
        TextBox7.Text = "-"






    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged




    End Sub

    Private Sub longitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = Me.Text
        Label1.Visible = False


        TextBox1.Text = ""
        ComboBox1.Text = "Selecciona una opción."
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class