Public Class Duzenle_Konu
    Dim degisiklik As Boolean
    Private Sub TextBoxKonu_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKonu.TextChanged
        If Not TextBoxKonu.Text = "" Then degisiklik = True Else degisiklik = False
    End Sub

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        _selectedMetroTileKonu.Checked = False
        _selectedMetroTileKonu = Nothing
        MainForm.ShowModalPanel(_MetroKonu, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik = True Then
            If _GuncelleKonu({TextBoxKonu.Text}, _selectedMetroTileKonu.Tag) = True Then
                msg.LabelMessage.Text = "Konu düzenlendi"
            Else
                msg.LabelMessage.Text = "Konu düzenlenemedi"
            End If
        ElseIf degisiklik = False Then
            msg.LabelMessage.Text = "Konu düzenlenmedi"
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleKonu(_MetroKonu.Container1.Tag, _MetroKonu.Container1.TitleText)
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub Duzenle_Konu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxKonu.Text = _selectedMetroTileKonu.Text
        degisiklik = False
    End Sub
End Class
