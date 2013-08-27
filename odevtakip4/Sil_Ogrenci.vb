Public Class Sil_Ogrenci

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        _selectedMetroTileOgrenci.Checked = False
        _selectedMetroTileOgrenci = Nothing
        MainForm.ShowModalPanel(_MetroOgrenci, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttonsil_Click(sender As Object, e As EventArgs) Handles Buttonsil.Click
        Dim msg As New message_control
        If _SilOgrenci(_selectedMetroTileOgrenci.Tag) = True Then
            msg.LabelMessage.Text = "Öğrenci başarıyla silindi."
        Else
            msg.LabelMessage.Text = "Öğrenci silinemedi."
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleOgrenci(_MetroOgrenci.Container1.Tag, _MetroOgrenci.Container1.TitleText)
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
