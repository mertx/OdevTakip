Imports DevComponents.DotNetBar
Public Class StartControl
    Inherits DevComponents.DotNetBar.Controls.SlidePanel

    Private Sub MetroTileItemSiniflar_Click(sender As Object, e As EventArgs) Handles MetroTileItemSiniflar.Click
        _YukleSinif()
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub MetroTileItemDersler_Click(sender As Object, e As EventArgs) Handles MetroTileItemDersler.Click
        _YukleDers()
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub MetroTileItemKontrol_Click(sender As Object, e As EventArgs) Handles MetroTileItemKontrol.Click
        _YukleKontrolSinif()
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub


    Private Sub MetroTileItemSiniflar_MouseEnter(sender As Object, e As EventArgs) Handles MetroTileItemSiniflar.MouseEnter
        ToastNotification.Show(Me, Space(3) + "Sınıfları ve öğrencileri düzenle" + Space(3), 1500, eToastPosition.BottomCenter)
    End Sub

    Private Sub MetroTileItemDersler_MouseEnter(sender As Object, e As EventArgs) Handles MetroTileItemDersler.MouseEnter
        ToastNotification.Show(Me, Space(5) + "Dersleri ve konuları düzenle" + Space(5), 1500, eToastPosition.BottomCenter)
    End Sub

    Private Sub MetroTileItemKontrol_MouseEnter(sender As Object, e As EventArgs) Handles MetroTileItemKontrol.MouseEnter
        ToastNotification.Show(Me, Space(17) + "Ödev kontrolü" + Space(17), 1500, eToastPosition.BottomCenter)
    End Sub

End Class
