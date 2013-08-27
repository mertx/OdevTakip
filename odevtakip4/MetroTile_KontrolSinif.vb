Public Class MetroTile_KontrolSinif
    Inherits DevComponents.DotNetBar.Metro.MetroTileItem

    Private Sub MetroTile_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        Me.Checked = False
    End Sub

    Private Sub MetroTile_Click(sender As Object, e As EventArgs) Handles Me.Click
        _YukleKontrol(Me.Tag, Me.Text)
        MainForm.CloseModalPanel(_GosterKontrolSinif, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
