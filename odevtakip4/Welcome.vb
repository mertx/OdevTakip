Public Class Welcome

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        MainForm.ShowModalPanel(_StartControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
