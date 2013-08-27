Public Class Ekle_Konu
    Dim degisiklik As Boolean

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        MainForm.ShowModalPanel(_MetroKonu, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik = True Then
            If _EkleKonu({_MetroKonu.Container1.Tag, TextBoxKonu.Text}) = True Then
                msg.LabelMessage.Text = "Konu eklendi"
            Else
                msg.LabelMessage.Text = "Konu eklenemedi"
            End If
        ElseIf degisiklik = False Then
            msg.LabelMessage.Text = "Konu eklenmedi"
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleKonu(_MetroKonu.Container1.Tag, _MetroKonu.Container1.TitleText)
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub TextBoxKonu_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKonu.TextChanged
        If Not TextBoxKonu.Text = "" Then degisiklik = True Else degisiklik = False
    End Sub


    Private Sub Ekle_Konu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        degisiklik = False
    End Sub
End Class
