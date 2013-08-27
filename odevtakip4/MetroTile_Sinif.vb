Public Class MetroTile_Sinif
    Inherits DevComponents.DotNetBar.Metro.MetroTileItem

    Private Sub MetroTile_CheckedChanged(sender As Object, e As EventArgs) Handles Me.CheckedChanged
        If _selectedMetroTileSinif Is Me Or Nothing Then
            Me.Checked = False
            _selectedMetroTileSinif = Nothing
        ElseIf _selectedMetroTileSinif Is Nothing Then
            Me.Checked = True
            _selectedMetroTileSinif = Me
        Else
            Me.Checked = True
            _selectedMetroTileSinif.Checked = False
            _selectedMetroTileSinif = Me
        End If
        _MetroSinif.ButtonSil.Visible = Me.Checked
        _MetroSinif.ButtonDuzenle.Visible = Me.Checked
    End Sub

    Private Sub MetroTile_Click(sender As Object, e As EventArgs) Handles Me.Click
        _YukleOgrenci(Me.Tag, Me.Text)
        MainForm.CloseModalPanel(_MetroSinif, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
