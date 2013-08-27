Public Class Duzenle_Ders
    Dim degisiklik(1) As Boolean
    Private Sub SuperTabSinif_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabSinif.SelectedTabChanged
        degisiklik(0) = True
    End Sub

    Private Sub TextBoxDers_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDers.TextChanged
        If Not TextBoxDers.Text = "" Then degisiklik(1) = True Else degisiklik(1) = False
    End Sub

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        _selectedMetroTileDers.Checked = False
        _selectedMetroTileDers = Nothing
        MainForm.ShowModalPanel(_MetroDers, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik(0) = True Or degisiklik(1) = True Then
            If _GuncelleDers({(SuperTabSinif.SelectedTabIndex + 8), TextBoxDers.Text}, _selectedMetroTileDers.Tag) = True Then
                msg.LabelMessage.Text = "Ders düzenlendi"
            Else
                msg.LabelMessage.Text = "Ders düzenlenemedi"
            End If
        ElseIf degisiklik(0) = False And degisiklik(1) = False Then
            msg.LabelMessage.Text = "Ders düzenlenmedi"
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleDers()
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub Ekle_Ders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxDers.Text = _selectedMetroTileDers.Text
        Try
            baglan.Open()
            komut = New System.Data.OleDb.OleDbCommand("SELECT dersin_sinifi FROM dersler WHERE ders_id= " + _selectedMetroTileDers.Tag, baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            SuperTabSinif.SelectedTabIndex = CInt(oku("dersin_sinifi").ToString) - 8
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        degisiklik(0) = False
        degisiklik(1) = False
    End Sub
End Class
