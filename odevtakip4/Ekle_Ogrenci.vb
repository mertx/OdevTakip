Public Class Ekle_Ogrenci
    Dim degisiklik(8) As Boolean
    Dim filepath As String
    Dim bitmapp As Bitmap
    Private Sub Buttoniptal_Click(sender As Object, e As EventArgs) Handles Buttoniptal.Click
        MainForm.ShowModalPanel(_MetroOgrenci, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Private Sub Buttontamam_Click(sender As Object, e As EventArgs) Handles Buttontamam.Click
        Dim msg As New message_control
        If degisiklik(0) = True And degisiklik(1) = True And degisiklik(2) = True And degisiklik(3) = True And degisiklik(4) = True And degisiklik(5) = True And degisiklik(6) = True And degisiklik(7) = True And degisiklik(8) = True Then
            If _EkleOgrenci({_MetroOgrenci.Container1.Tag, TextBoxAdi.Text, TextBoxSoyadi.Text, TextBoxNumarasi.Text, TextBoxAnneAdi.Text, TextBoxBabaAdi.Text, TextBoxAnneTel.Text, TextBoxBabaTel.Text, TextBoxTC.Text}, bitmapp) = True Then
                msg.LabelMessage.Text = "Öğrenci eklendi"
            Else
                msg.LabelMessage.Text = "Öğrenci eklenemedi"
            End If
            MainForm.ShowModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            MainForm.CloseModalPanel(Me, DevComponents.DotNetBar.Controls.eSlideSide.Right)
            Threading.Thread.Sleep(400)
            _YukleOgrenci(_MetroOgrenci.Container1.Tag, _MetroOgrenci.Container1.TitleText)
            MainForm.CloseModalPanel(msg, DevComponents.DotNetBar.Controls.eSlideSide.Right)
        ElseIf degisiklik(0) = False Or degisiklik(1) = False Or degisiklik(2) = False Or degisiklik(3) = False Or degisiklik(4) = False Or degisiklik(5) = False Or degisiklik(6) = False Or degisiklik(7) = False Or degisiklik(8) = False Then
            If degisiklik(0) = False Then Highlighter1.SetHighlightColor(TextBoxAdi, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(1) = False Then Highlighter1.SetHighlightColor(TextBoxSoyadi, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(2) = False Then Highlighter1.SetHighlightColor(TextBoxNumarasi, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(3) = False Then Highlighter1.SetHighlightColor(TextBoxTC, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(4) = False Then Highlighter1.SetHighlightColor(TextBoxAnneAdi, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(5) = False Then Highlighter1.SetHighlightColor(TextBoxAnneTel, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(6) = False Then Highlighter1.SetHighlightColor(TextBoxBabaAdi, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(7) = False Then Highlighter1.SetHighlightColor(TextBoxBabaTel, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            If degisiklik(8) = False Then Highlighter1.SetHighlightColor(ButtonX1, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
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

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If OpenFile.ShowDialog = DialogResult.OK Then
            degisiklik(8) = True
            filepath = OpenFile.FileName
            bitmapp = New Bitmap(filepath, False)
            bitmapp = New Bitmap(bitmapp, New Size(225, 300))
            ReflectionImage1.Image = bitmapp
            Highlighter1.SetHighlightColor(ButtonX1, DevComponents.DotNetBar.Validator.eHighlightColor.None)
        ElseIf DialogResult.Cancel Then
            degisiklik(8) = False
            filepath = ""
        End If
    End Sub

    Private Sub Ekle_Ogrenci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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


End Class
