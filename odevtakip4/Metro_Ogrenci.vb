Public Class Metro_Ogrenci

    Private Sub ButtonGeri_Click(sender As Object, e As EventArgs) Handles ButtonGeri.Click
        _YukleSinif()
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub ButtonSil_Click(sender As Object, e As EventArgs) Handles ButtonSil.Click
        Dim m As New Sil_Ogrenci
        MainForm.ShowModalPanel(m, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub ButtonDuzenle_Click(sender As Object, e As EventArgs) Handles ButtonDuzenle.Click
        Dim m As New Duzenle_Ogrenci
        MainForm.ShowModalPanel(m, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub ButtonEkle_Click(sender As Object, e As EventArgs) Handles ButtonEkle.Click
        Dim m As New Ekle_Ogrenci
        MainForm.ShowModalPanel(m, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
    Private Sub ButtonGeri_MouseEnter(sender As Object, e As EventArgs) Handles ButtonGeri.MouseEnter
        DevComponents.DotNetBar.ToastNotification.Show(Me, "Geri", 1000, DevComponents.DotNetBar.eToastPosition.BottomCenter)
    End Sub
    Private Sub ButtonSil_MouseEnter(sender As Object, e As EventArgs) Handles ButtonSil.MouseEnter
        DevComponents.DotNetBar.ToastNotification.Show(Me, "Seçili öğrenciyi sil", 1000, DevComponents.DotNetBar.eToastPosition.BottomCenter)
    End Sub

    Private Sub ButtonDuzenle_MouseEnter(sender As Object, e As EventArgs) Handles ButtonDuzenle.MouseEnter
        DevComponents.DotNetBar.ToastNotification.Show(Me, "Seçili öğrenciyi düzenle", 1000, DevComponents.DotNetBar.eToastPosition.BottomCenter)
    End Sub

    Private Sub ButtonEkle_MouseEnter(sender As Object, e As EventArgs) Handles ButtonEkle.MouseEnter
        DevComponents.DotNetBar.ToastNotification.Show(Me, "Yeni öğrenci ekle", 1000, DevComponents.DotNetBar.eToastPosition.BottomCenter)
    End Sub
End Class
