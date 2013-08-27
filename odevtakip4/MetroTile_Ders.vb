Public Class MetroTile_Ders
    Inherits DevComponents.DotNetBar.Metro.MetroTileItem

    Private Sub MetroTile_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        If _selectedMetroTileDers Is Me Or Nothing Then
            Me.Checked = False
            _selectedMetroTileDers = Nothing
        ElseIf _selectedMetroTileDers Is Nothing Then
            Me.Checked = True
            _selectedMetroTileDers = Me
        Else
            Me.Checked = True
            _selectedMetroTileDers.Checked = False
            _selectedMetroTileDers = Me
        End If
        _MetroDers.ButtonSil.Visible = Me.Checked
        _MetroDers.ButtonDuzenle.Visible = Me.Checked
    End Sub

    Private Sub MetroTile_Click(sender As Object, e As EventArgs) Handles Me.Click
        _YukleKonu(Me.Tag, Me.Text)
        MainForm.CloseModalPanel(_MetroDers, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
