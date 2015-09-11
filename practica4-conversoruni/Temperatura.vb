Public Class Temperatura

    Private Sub Temperatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = Me.Text
        ComboBox1.Text = "Selecciona una opción."


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

        inicio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Label1.Text = "-"
        Label2.Text = "-"
        ComboBox1.Enabled = True
        TextBox1.Enabled = True
        ComboBox1.Text = "Selecciona una opción."



    End Sub

    Public c, f As Double
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TextBox1.Text = "" Then
            MsgBox("Porfavor introduce un valor en el área de texto.")
        Else

            Select Case ComboBox1.SelectedIndex
                Case 0
                    Label1.Text = TextBox1.Text
                    f = 1.8 * TextBox1.Text + 32
                    'Label2.Text = f
                    Label2.Text = FormatNumber((Val(TextBox1.Text) + 32 * 1.8), -1)


                    TextBox1.Enabled = False
                    ComboBox1.Enabled = False


                Case 1
                    Label2.Text = TextBox1.Text
                    ' c = (TextBox1.Text - 32) / 1.8
                    ' Label1.Text = c
                    Label1.Text = FormatNumber((Val(TextBox1.Text) - 32 / 1.8), -1)
                    TextBox1.Enabled = False
                    ComboBox1.Enabled = False
            End Select
        End If



    End Sub
End Class