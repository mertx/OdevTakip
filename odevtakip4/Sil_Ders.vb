Public Class Sil_Ders

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        _selectedMetroTileDers.Checked = False
        _selectedMetroTileDers = Nothing
        MainForm.ShowModalPanel(_MetroDers, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttonsil_Click(sender As Object, e As EventArgs) Handles Buttonsil.Click
        Dim msg As New message_control
        If _SilDers(_selectedMetroTileDers.Tag) = True Then
            msg.LabelMessage.Text = "Ders başarıyla silindi."
        Else
            msg.LabelMessage.Text = "Ders silinemedi."
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleDers()
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
