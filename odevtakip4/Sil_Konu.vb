Public Class Sil_Konu

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        _selectedMetroTileKonu.Checked = False
        _selectedMetroTileKonu = Nothing
        MainForm.ShowModalPanel(_MetroKonu, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttonsil_Click(sender As Object, e As EventArgs) Handles Buttonsil.Click
        Dim msg As New message_control
        If _SilKonu(_selectedMetroTileKonu.Tag) = True Then
            msg.LabelMessage.Text = "Konu başarıyla silindi."
        Else
            msg.LabelMessage.Text = "Konu silinemedi."
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleKonu(_MetroKonu.Container1.Tag, _MetroKonu.Container1.TitleText)
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
