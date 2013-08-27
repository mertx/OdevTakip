Public Class MetroTile_Konu
    Inherits DevComponents.DotNetBar.Metro.MetroTileItem

    Private Sub MetroTile_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        If _selectedMetroTileKonu Is Me Or Nothing Then
            Me.Checked = False
            _selectedMetroTileKonu = Nothing
        ElseIf _selectedMetroTileKonu Is Nothing Then
            Me.Checked = True
            _selectedMetroTileKonu = Me
        Else
            Me.Checked = True
            _selectedMetroTileKonu.Checked = False
            _selectedMetroTileKonu = Me
        End If
        _MetroKonu.ButtonSil.Visible = Me.Checked
        _MetroKonu.ButtonDuzenle.Visible = Me.Checked
    End Sub

End Class
