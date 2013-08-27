Public Class Goster_Kontrol

    Private Sub SuperTabOgrenciler_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabOgrenciler.SelectedTabChanged
        _secOgrencitab()
    End Sub

    Private Sub SuperTabDersler_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabDersler.SelectedTabChanged
        _secDerstab()
    End Sub

    Private Sub ButtonGeri_Click(sender As Object, e As EventArgs) Handles ButtonGeri.Click
        _YukleKontrolSinif()
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub


    Private Sub SuperGrid_CellValueChanged(sender As Object, e As DevComponents.DotNetBar.SuperGrid.GridCellValueChangedEventArgs) Handles SuperGrid.CellValueChanged
        _GuncelleKontrol(e.GridCell.GridColumn.Name.ToString, e.GridCell.Parent.Tag, e.NewValue)
    End Sub
End Class
