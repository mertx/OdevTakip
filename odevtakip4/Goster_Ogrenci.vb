Public Class Goster_Ogrenci

    Private Sub ButtonGeri_Click(sender As Object, e As EventArgs) Handles ButtonGeri.Click
        MainForm.ShowModalPanel(_MetroOgrenci, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
    Private Sub ButtonGeri_MouseEnter(sender As Object, e As EventArgs) Handles ButtonGeri.MouseEnter
        DevComponents.DotNetBar.ToastNotification.Show(Me, "Geri", 1000, DevComponents.DotNetBar.eToastPosition.BottomCenter)
    End Sub
End Class
