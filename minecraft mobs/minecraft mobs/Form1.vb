Public Class Form1
    Dim pic As Integer = 1
    Dim healthtxt As Integer
    Dim damagetxt As Integer
    Dim effecttxt As String
    Function picture() As Boolean
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        If pic = 1 Then
            PictureBox1.Visible = True
            healthtxt = 40
            damagetxt = 7
            effecttxt = "none"
        End If
        If pic = 2 Then
            PictureBox2.Visible = True
            healthtxt = 20
            damagetxt = 22
            effecttxt = "none"
        End If
        If pic = 3 Then
            PictureBox3.Visible = True
            healthtxt = 100
            damagetxt = 10
            effecttxt = "none"
        End If
        If pic = 4 Then
            PictureBox4.Visible = True
            healthtxt = 20
            damagetxt = 6
            effecttxt = "none"
        End If
        If pic = 5 Then
            PictureBox5.Visible = True
            healthtxt = 20
            damagetxt = 2
            effecttxt = "none"
        End If
        If pic = 6 Then
            PictureBox6.Visible = True
            healthtxt = 30
            damagetxt = 4
            effecttxt = "levitation"
        End If
        If pic = 7 Then
            PictureBox7.Visible = True
            healthtxt = 20
            damagetxt = 8
            effecttxt = "wither"
        End If
        If pic = 8 Then
            PictureBox8.Visible = True
            healthtxt = 20
            damagetxt = 3
            effecttxt = "none"
        End If
        If pic = 9 Then
            PictureBox9.Visible = True
            healthtxt = 10
            damagetxt = 2
            effecttxt = "poison"
        End If
        If pic = 10 Then
            PictureBox10.Visible = True
            healthtxt = 20
            damagetxt = 4
            effecttxt = "none"
        End If
        Label1.Text = healthtxt
        Label2.Text = damagetxt
        Label3.Text = effecttxt
    End Function
    Private Sub next_button_Click(sender As Object, e As EventArgs) Handles next_button.Click
        pic = pic + 1
        If pic = 11 Then
            pic = 1
        End If
        picture()
    End Sub

    Private Sub Prev_button_Click(sender As Object, e As EventArgs) Handles Prev_button.Click
        pic = pic - 1
        If pic = 0 Then
            pic = 10
        End If
        picture()
    End Sub

    Private Sub first_button_Click(sender As Object, e As EventArgs) Handles first_button.Click
        pic = 1
        picture()
    End Sub

    Private Sub last_button_Click(sender As Object, e As EventArgs) Handles last_button.Click
        pic = 10
        picture()
    End Sub
End Class
