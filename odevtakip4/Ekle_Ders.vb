Public Class Ekle_Ders
    Dim degisiklik As Boolean

    Private Sub TextBoxDers_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDers.TextChanged
        If Not TextBoxDers.Text = "" Then degisiklik = True Else degisiklik = False
    End Sub

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        MainForm.ShowModalPanel(_MetroDers, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik = True Then
            If _EkleDers({(SuperTabSinif.SelectedTabIndex + 8), TextBoxDers.Text}) = True Then
                msg.LabelMessage.Text = "Ders eklendi"
            Else
                msg.LabelMessage.Text = "Ders eklenemedi"
            End If
        ElseIf degisiklik = False Then
            msg.LabelMessage.Text = "Ders eklenmedi"
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleDers()
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub Ekle_Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        degisiklik = False
    End Sub
End Class
