Public Class Sil_Sinif

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        _selectedMetroTileSinif.Checked = False
        _selectedMetroTileSinif = Nothing
        MainForm.ShowModalPanel(_MetroSinif, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttonsil_Click(sender As Object, e As EventArgs) Handles Buttonsil.Click
        Dim msg As New message_control
        If _SilSinif(_selectedMetroTileSinif.Tag) = True Then
            msg.LabelMessage.Text = _selectedMetroTileSinif.Text + " sınıfı başarıyla silindi."
        Else
            msg.LabelMessage.Text = _selectedMetroTileSinif.Text + " sınıfı silinemedi."         
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleSinif()
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

End Class
