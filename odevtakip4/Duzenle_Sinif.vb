Public Class Duzenle_Sinif
    Dim degisiklik(2) As Boolean
    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        _selectedMetroTileSinif.Checked = False
        _selectedMetroTileSinif = Nothing
        MainForm.ShowModalPanel(_MetroSinif, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik(0) = True Or degisiklik(1) = True Or degisiklik(2) = True Then
            If _GuncelleSinif({(SuperTabSinif.SelectedTabIndex + 8), TextBoxSube.Text, TextBoxOgretmen.Text}, _selectedMetroTileSinif.Tag) = True Then
                msg.LabelMessage.Text = "Sınıf düzenlendi"
            Else
                msg.LabelMessage.Text = "Sınıf düzenlenemedi"
            End If
        ElseIf degisiklik(0) = False And degisiklik(1) = False And degisiklik(2) = False Then
            msg.LabelMessage.Text = "Sınıf düzenlenmedi"
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleSinif()
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub

    Private Sub Duzenle_Sinif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            baglan.Open()
            komut = New System.Data.OleDb.OleDbCommand("SELECT * FROM sınıflar WHERE sinif_id= " + _selectedMetroTileSinif.Tag, baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            SuperTabSinif.SelectedTabIndex = CInt(oku("sinif").ToString) - 8
            TextBoxSube.Text = oku("sube").ToString
            TextBoxOgretmen.Text = oku("ogretmen").ToString
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        degisiklik(0) = False
        degisiklik(1) = False
        degisiklik(2) = False
    End Sub

    Private Sub SuperTabSinif_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabSinif.SelectedTabChanged
        degisiklik(0) = True
    End Sub

    Private Sub TextBoxSube_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSube.TextChanged
        If Not TextBoxSube.Text = "" Then degisiklik(1) = True Else degisiklik(1) = False
    End Sub

    Private Sub TextBoxOgretmen_TextChanged(sender As Object, e As EventArgs) Handles TextBoxOgretmen.TextChanged
        If Not TextBoxOgretmen.Text = "" Then degisiklik(2) = True Else degisiklik(2) = False
    End Sub
End Class
