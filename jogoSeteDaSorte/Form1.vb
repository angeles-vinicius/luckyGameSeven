Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles num3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        PictureBox1.Visible = False
        Randomize()
        num1.Text = CStr(Int(Rnd() * 10))
        num2.Text = CStr(Int(Rnd() * 10))
        num3.Text = CStr(Int(Rnd() * 10))
        'This code is to test 3 numbers seven
        'num1.Text = 7
        'num2.Text = 7
        'num3.Text = 7
        'if all numbers are seven'
        If (num1.Text = "7") And (num2.Text = "7") And (num3.Text = "7") Then
            PictureBox1.Image = Image.FromFile("C:\angeles\jogoSeteDaSorteSln\winMax.png")
            PictureBox1.Visible = True
            Beep()
        ElseIf (num1.Text = "7") Or (num2.Text = "7") Or (num3.Text = "7") Then
            PictureBox1.Image = Image.FromFile("C:\angeles\jogoSeteDaSorteSln\win.png")
            PictureBox1.Visible = True
            Beep()
        Else
            PictureBox1.Image = Image.FromFile("C:\angeles\jogoSeteDaSorteSln\tryAgain.png")
            PictureBox1.Visible = True
            Beep()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click

    End Sub
End Class
