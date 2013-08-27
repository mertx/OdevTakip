Public Class MetroTile_Ogrenci
    Inherits DevComponents.DotNetBar.Metro.MetroTileItem

    Private Sub MetroTile_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        If _selectedMetroTileOgrenci Is Me Or Nothing Then
            Me.Checked = False
            _selectedMetroTileOgrenci = Nothing
        ElseIf _selectedMetroTileOgrenci Is Nothing Then
            Me.Checked = True
            _selectedMetroTileOgrenci = Me
        Else
            Me.Checked = True
            _selectedMetroTileOgrenci.Checked = False
            _selectedMetroTileOgrenci = Me
        End If
        _MetroOgrenci.ButtonSil.Visible = Me.Checked
        _MetroOgrenci.ButtonDuzenle.Visible = Me.Checked
    End Sub

    Private Sub MetroTile_Click(sender As Object, e As EventArgs) Handles Me.Click
        _YukleOgrenciBilgileri(Me.Tag, _MetroOgrenci.Container1.Tag)
        MainForm.CloseModalPanel(_MetroOgrenci, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
