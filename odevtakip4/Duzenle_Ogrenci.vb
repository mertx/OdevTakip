Public Class Duzenle_Ogrenci
    Dim degisiklik(8) As Boolean
    Dim filepath As String
    Dim bitmapp As Bitmap

    Private Sub Duzenle_Ogrenci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            baglan.Open()
            komut = New System.Data.OleDb.OleDbCommand("SELECT * FROM öğrenciler WHERE ogrenci_id= " + _selectedMetroTileOgrenci.Tag, baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            TextBoxAdi.Text = oku("ogrencinin_adi").ToString
            TextBoxSoyadi.Text = oku("ogrencinin_soyadi").ToString
            TextBoxNumarasi.Text = oku("ogrencinin_numarasi").ToString
            TextBoxAnneAdi.Text = oku("o_anneadi").ToString()
            TextBoxBabaAdi.Text = oku("o_babaadi").ToString()
            TextBoxAnneTel.Text = oku("o_annetel").ToString()
            TextBoxBabaTel.Text = oku("o_babatel").ToString()
            TextBoxTC.Text = oku("o_tcno").ToString()
            If My.Computer.FileSystem.FileExists(_imgloc + _selectedMetroTileOgrenci.Tag.ToString + ".png") Then bitmapp = System.Drawing.Image.FromFile(_imgloc + _selectedMetroTileOgrenci.Tag.ToString + ".png") Else bitmapp = My.Resources.nonepp
            ReflectionImage1.Image = bitmapp
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        degisiklik(0) = False
        degisiklik(1) = False
        degisiklik(2) = False
        degisiklik(3) = False
        degisiklik(4) = False
        degisiklik(5) = False
        degisiklik(6) = False
        degisiklik(7) = False
        degisiklik(8) = False
    End Sub

    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        MainForm.ShowModalPanel(_MetroOgrenci, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If OpenFile.ShowDialog = DialogResult.OK Then
            degisiklik(8) = True
            filepath = OpenFile.FileName
            bitmapp.Dispose()
            bitmapp = New Bitmap(filepath, False)
            bitmapp = New Bitmap(bitmapp, New Size(225, 300))
            ReflectionImage1.Image = bitmapp
            Highlighter1.SetHighlightColor(ButtonX1, DevComponents.DotNetBar.Validator.eHighlightColor.None)
        ElseIf DialogResult.Cancel Then
            degisiklik(8) = False
            filepath = ""
        End If
    End Sub

    Private Sub TextBoxAdi_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAdi.TextChanged
        If Not TextBoxAdi.Text = "" Then degisiklik(0) = True : Highlighter1.SetHighlightColor(TextBoxAdi, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(0) = False
    End Sub

    Private Sub TextBoxSoyadi_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSoyadi.TextChanged
        If Not TextBoxSoyadi.Text = "" Then degisiklik(1) = True : Highlighter1.SetHighlightColor(TextBoxSoyadi, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(1) = False
    End Sub

    Private Sub TextBoxNumarasi_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumarasi.TextChanged
        If Not TextBoxNumarasi.Text = "" Then degisiklik(2) = True : Highlighter1.SetHighlightColor(TextBoxNumarasi, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(2) = False
    End Sub

    Private Sub TextBoxX5_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTC.TextChanged
        If Not TextBoxTC.Text = "" Then degisiklik(3) = True : Highlighter1.SetHighlightColor(TextBoxTC, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(3) = False
    End Sub

    Private Sub TextBoxX3_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAnneAdi.TextChanged
        If Not TextBoxAnneAdi.Text = "" Then degisiklik(4) = True : Highlighter1.SetHighlightColor(TextBoxAnneAdi, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(4) = False
    End Sub

    Private Sub TextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAnneTel.TextChanged
        If Not TextBoxAnneTel.Text = "" Then degisiklik(5) = True : Highlighter1.SetHighlightColor(TextBoxAnneTel, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(5) = False
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBabaAdi.TextChanged
        If Not TextBoxBabaAdi.Text = "" Then degisiklik(6) = True : Highlighter1.SetHighlightColor(TextBoxBabaAdi, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(6) = False
    End Sub

    Private Sub TextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBabaTel.TextChanged
        If Not TextBoxBabaTel.Text = "" Then degisiklik(7) = True : Highlighter1.SetHighlightColor(TextBoxBabaTel, DevComponents.DotNetBar.Validator.eHighlightColor.None) Else degisiklik(7) = False
    End Sub


    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik(0) = True Or degisiklik(1) = True Or degisiklik(2) = True Or degisiklik(3) = True Or degisiklik(4) = True Or degisiklik(5) = True Or degisiklik(6) = True Or degisiklik(7) = True Or degisiklik(8) = True Then
            If _GuncelleOgrenci({_MetroOgrenci.Container1.Tag, TextBoxAdi.Text, TextBoxSoyadi.Text, TextBoxNumarasi.Text, TextBoxAnneAdi.Text, TextBoxBabaAdi.Text, TextBoxAnneTel.Text, TextBoxBabaTel.Text, TextBoxTC.Text}, bitmapp, _selectedMetroTileOgrenci.Tag) = True Then
                msg.LabelMessage.Text = "Öğrenci eklendi"
                If degisiklik(8) = True Then If My.Computer.FileSystem.FileExists(_imgloc + _selectedMetroTileOgrenci.Tag.ToString + ".png") Then My.Computer.FileSystem.DeleteFile(_imgloc + _selectedMetroTileOgrenci.Tag.ToString + ".png")
            Else
                msg.LabelMessage.Text = "Öğrenci eklenemedi"
            End If
        ElseIf degisiklik(0) = False And degisiklik(1) = False And degisiklik(2) = False And degisiklik(3) = False And degisiklik(4) = False And degisiklik(5) = False And degisiklik(6) = False And degisiklik(7) = False And degisiklik(8) = False Then
            msg.LabelMessage.Text = "Değişiklik yapılmadı."
        End If
        MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        Threading.Thread.Sleep(400)
        _YukleOgrenci(_MetroOgrenci.Container1.Tag, _MetroOgrenci.Container1.TitleText)
        MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
    End Sub
End Class
