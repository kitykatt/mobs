Public Class Form9001
    Dim pic As Integer = 1
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
            health.Text = 40
            damage.Text = 7
            effect.Text = "none"
            name1.Text = "enderman"
        End If
        If pic = 2 Then
            PictureBox2.Visible = True
            health.Text = 20
            damage.Text = 22
            effect.Text = "none"
            name1.Text = "creeper"
        End If
        If pic = 3 Then
            PictureBox3.Visible = True
            health.Text = 100
            damage.Text = 10
            effect.Text = "none"
            name1.Text = "iron golem"
        End If
        If pic = 4 Then
            PictureBox4.Visible = True
            health.Text = 20
            damage.Text = 6
            effect.Text = "none"
            name1.Text = "panda"
        End If
        If pic = 5 Then
            PictureBox5.Visible = True
            health.Text = 20
            damage.Text = 2
            effect.Text = "none"
            name1.Text = "phantom"
        End If
        If pic = 6 Then
            PictureBox6.Visible = True
            health.Text = 30
            damage.Text = 4
            effect.Text = "levitation"
            name1.Text = "shulker"
        End If
        If pic = 7 Then
            PictureBox7.Visible = True
            health.Text = 20
            damage.Text = 8
            effect.Text = "wither"
            name1.Text = "wither skeleton"
        End If
        If pic = 8 Then
            PictureBox8.Visible = True
            health.Text = 20
            damage.Text = 3
            effect.Text = "none"
            name1.Text = "zombie"
        End If
        If pic = 9 Then
            PictureBox9.Visible = True
            health.Text = 10
            damage.Text = 2
            effect.Text = "poison"
            name1.Text = "bee"
        End If
        If pic = 10 Then
            PictureBox10.Visible = True
            health.Text = 20
            damage.Text = 4
            effect.Text = "none"
            name1.Text = "skeleton"
        End If
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
