Public Class Ekle_Sinif
    Dim degisiklik(2) As Boolean
    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        MainForm.ShowModalPanel(_MetroSinif, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik(1) = True And degisiklik(2) = True Then
            If _EkleSinif({(SuperTabSinif.SelectedTabIndex + 8), TextBoxSube.Text, TextBoxOgretmen.Text}) = True Then
                msg.LabelMessage.Text = "Sınıf eklendi"
            Else
                msg.LabelMessage.Text = "Sınıf eklenemedi"
            End If
        ElseIf degisiklik(1) = False Or degisiklik(2) = False Then
            msg.LabelMessage.Text = "Sınıf eklenmedi"
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleSinif()
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub TextBoxSube_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSube.TextChanged
        If Not TextBoxSube.Text = "" Then degisiklik(1) = True Else degisiklik(1) = False
    End Sub

    Private Sub TextBoxOgretmen_TextChanged(sender As Object, e As EventArgs) Handles TextBoxOgretmen.TextChanged
        If Not TextBoxOgretmen.Text = "" Then degisiklik(2) = True Else degisiklik(2) = False
    End Sub

    Private Sub Ekle_Sinif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        degisiklik(1) = False
        degisiklik(2) = False
    End Sub
End Class
