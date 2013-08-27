'01100010 01111001 01010101 01101101 01110101 01110100
Imports System.Data.OleDb
Imports DevComponents.DotNetBar
Module ApplicationModule
    '############################################
    Public baglan As OleDbConnection
    Public komut As OleDbCommand
    Public oku As OleDbDataReader

    Public _databaseloc, _imgloc As String
    Public _itsFirstStart As Boolean = False                                                    '???????
    '############################################
    Dim w As New Welcome
    Public _StartControl As New StartControl With {.Dock = DockStyle.Fill}                      'Start
    '############################################
    Public _MetroSinif As New Metro_Sinif With {.Dock = DockStyle.Fill}                         'Sınıf
    Public _MetroOgrenci As New Metro_Ogrenci With {.Dock = DockStyle.Fill}                     'Öğrenciler
    Public _GosterOgrenci As New Goster_Ogrenci With {.Dock = DockStyle.Fill}                   'Öğrenci

    Public _MetroDers As New Metro_Ders With {.Dock = DockStyle.Fill}                           'Ders
    Public _MetroKonu As New Metro_Konu With {.Dock = DockStyle.Fill}                           'Konu

    Public _GosterKontrolSinif As New Goster_KontrolSinif With {.Dock = DockStyle.Fill}         'Kontrol Sınıf   
    Public _GosterKontrol As New Goster_Kontrol With {.Dock = DockStyle.Fill}                   'Kontrol
    '############################################
    Public _selectedMetroTileDers As MetroTile_Ders
    Public _selectedMetroTileKonu As MetroTile_Konu

    Public _selectedMetroTileSinif As MetroTile_Sinif
    Public _selectedMetroTileOgrenci As MetroTile_Ogrenci
    Public _seletedrenk As Metro.MetroTileItem
    '############################################
    Function _v(ByVal t As String) As String
        Return "', " + t + "'"
    End Function
    '############################################

    Public Sub _FirstStart()
        If Not My.Computer.FileSystem.DirectoryExists(_databaseloc) Then My.Computer.FileSystem.CreateDirectory(_databaseloc)
        If Not My.Computer.FileSystem.DirectoryExists(_imgloc) Then My.Computer.FileSystem.CreateDirectory(_imgloc)
        If My.Computer.FileSystem.FileExists(_databaseloc + "database.accdb") = False Then
            My.Computer.FileSystem.WriteAllBytes(_databaseloc + "database.accdb", My.Resources.database, False)
            _itsFirstStart = True                                                                                                   'wtf?
        End If
        baglan = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""" + _databaseloc + "database.accdb""")        ';Jet OLEDB:Database Password=""••••••••••••"""
        MainForm.ShowModalPanel(w, Controls.eSlideSide.Left)
    End Sub

#Region "Yukle"

    Public Sub _YukleSinif()
        MainForm.StatusLabel.Text = "YÜKLENİYOR..."
        _TemizleSinif()
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT * FROM sınıflar ORDER BY sube ASC", baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                If oku("sinif").ToString = "8" Then
                    itemadd_sinif(_MetroSinif.Container8, "8/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "9" Then
                    itemadd_sinif(_MetroSinif.Container9, "9/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "10" Then
                    itemadd_sinif(_MetroSinif.Container10, "10/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "11" Then
                    itemadd_sinif(_MetroSinif.Container11, "11/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "12" Then
                    itemadd_sinif(_MetroSinif.Container12, "12/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                End If
            End While
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        _MetroSinif.MetroTilePanel.Refresh()
        MainForm.StatusLabel.Text = "HAZIR"
        MainForm.ShowModalPanel(_MetroSinif, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub
    Public Sub _YukleOgrenci(ByVal id As String, ByVal ContainerText As String)
        MainForm.StatusLabel.Text = "YÜKLENİYOR..."
        _TemizleOgrenci()
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT * FROM öğrenciler where sinifi_id = " + id + " ORDER BY ogrencinin_adi ASC", baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                itemadd_ogrenci(oku("ogrencinin_adi").ToString, oku("ogrencinin_soyadi").ToString, oku("ogrenci_id").ToString)
            End While
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        _MetroOgrenci.Container1.TitleText = ContainerText
        _MetroOgrenci.Container1.Tag = id 'sinif id
        _MetroOgrenci.MetroTilePanel.Refresh()
        MainForm.StatusLabel.Text = "HAZIR"
        MainForm.ShowModalPanel(_MetroOgrenci, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub
    Public Sub _YukleOgrenciBilgileri(ByVal id As String, ByVal Sinifid As String)
        MainForm.StatusLabel.Text = "YÜKLENİYOR..."
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT * FROM öğrenciler WHERE ogrenci_id = " + id, baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            _GosterOgrenci.LabelAdi.Text = oku("ogrencinin_adi").ToString()
            _GosterOgrenci.LabelSoyadi.Text = oku("ogrencinin_soyadi").ToString()
            _GosterOgrenci.LabelNumarasi.Text = oku("ogrencinin_numarasi").ToString()
            _GosterOgrenci.LabelAnneAdi.Text = oku("o_anneadi").ToString()
            _GosterOgrenci.LabelBabaAdi.Text = oku("o_babaadi").ToString()
            _GosterOgrenci.LabelAnneTel.Text = oku("o_annetel").ToString()
            _GosterOgrenci.LabelBabaTel.Text = oku("o_babatel").ToString()
            _GosterOgrenci.LabelTC.Text = oku("o_tcno").ToString()
            Dim bitmapp As Bitmap
            If My.Computer.FileSystem.FileExists(_imgloc + id + ".png") Then bitmapp = System.Drawing.Image.FromFile(_imgloc + id + ".png") Else bitmapp = My.Resources.nonepp
            _GosterOgrenci.ReflectionImage1.Image = bitmapp
            oku.Close()
            komut = New OleDbCommand("SELECT sinif,sube FROM sınıflar WHERE sinif_id = " + Sinifid, baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            _GosterOgrenci.LabelSinif.Text = oku("sinif").ToString + "/" + oku("sube").ToString
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        MainForm.StatusLabel.Text = "HAZIR"
        MainForm.ShowModalPanel(_GosterOgrenci, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub

    Public Sub _YukleDers()
        MainForm.StatusLabel.Text = "YÜKLENİYOR..."
        _TemizleDers()
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT * FROM dersler ORDER BY dersin_adi ASC", baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                If oku("dersin_sinifi").ToString = "8" Then
                    itemadd_ders(_MetroDers.Container8, oku("dersin_adi").ToString, "", oku("ders_id").ToString)
                ElseIf oku("dersin_sinifi").ToString = "9" Then
                    itemadd_ders(_MetroDers.Container9, oku("dersin_adi").ToString, "", oku("ders_id").ToString)
                ElseIf oku("dersin_sinifi").ToString = "10" Then
                    itemadd_ders(_MetroDers.Container10, oku("dersin_adi").ToString, "", oku("ders_id").ToString)
                ElseIf oku("dersin_sinifi").ToString = "11" Then
                    itemadd_ders(_MetroDers.Container11, oku("dersin_adi").ToString, "", oku("ders_id").ToString)
                ElseIf oku("dersin_sinifi").ToString = "12" Then
                    itemadd_ders(_MetroDers.Container12, oku("dersin_adi").ToString, "", oku("ders_id").ToString)
                End If
            End While

        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        _MetroDers.MetroTilePanel.Refresh()
        MainForm.StatusLabel.Text = "HAZIR"
        MainForm.ShowModalPanel(_MetroDers, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub
    Public Sub _YukleKonu(ByVal id As String, ByVal ContainerText As String)
        MainForm.StatusLabel.Text = "YÜKLENİYOR..."
        _TemizleKonu()
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT * FROM konular where ders_id = " + id, baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                itemadd_konu(oku("konunun_adı").ToString, oku("konu_id").ToString)
            End While
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        _MetroKonu.Container1.TitleText = ContainerText
        _MetroKonu.Container1.Tag = id
        _MetroKonu.MetroTilePanel.Refresh()
        MainForm.StatusLabel.Text = "HAZIR"
        MainForm.ShowModalPanel(_MetroKonu, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub


    Public Sub _YukleKontrolSinif()
        MainForm.StatusLabel.Text = "YÜKLENİYOR..."
        _TemizleKontrolSinif()
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT * FROM sınıflar ORDER BY sube ASC", baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                If oku("sinif").ToString = "8" Then
                    itemadd_kontrolsinif(_GosterKontrolSinif.Container8, "8/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "9" Then
                    itemadd_kontrolsinif(_GosterKontrolSinif.Container9, "9/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "10" Then
                    itemadd_kontrolsinif(_GosterKontrolSinif.Container10, "10/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "11" Then
                    itemadd_kontrolsinif(_GosterKontrolSinif.Container11, "11/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                ElseIf oku("sinif").ToString = "12" Then
                    itemadd_kontrolsinif(_GosterKontrolSinif.Container12, "12/" + oku("sube").ToString, oku("ogretmen").ToString, oku("sinif_id").ToString)
                End If
            End While
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        _GosterKontrolSinif.MetroTilePanel.Refresh()
        MainForm.StatusLabel.Text = "HAZIR"
        MainForm.ShowModalPanel(_GosterKontrolSinif, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub
    Public Sub _YukleKontrol(ByVal id As String, ByVal SinifText As String)
        MainForm.StatusLabel.Text = "YÜKLENİYOR..."
        _TemizleKontrol()
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT ogrenci_id,ogrencinin_adi,ogrencinin_soyadi FROM öğrenciler where sinifi_id = " + id + " ORDER BY ogrencinin_adi ASC", baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                itemadd_kontrol_tab_ogrenci(oku("ogrenci_id").ToString, oku("ogrencinin_adi").ToString + " " + oku("ogrencinin_soyadi").ToString)
            End While
            oku.Close()
            Dim a() As String = SinifText.Split("/")
            komut = New OleDbCommand("SELECT * FROM dersler where dersin_sinifi=" + a(0) + " ORDER BY dersin_adi ASC", baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                itemadd_kontrol_tab_ders(oku("ders_id").ToString, oku("dersin_adi").ToString)
            End While
            _GosterKontrol.SuperTabOgrenciler.SelectedTabIndex = 0
            _GosterKontrol.SuperTabDersler.SelectedTabIndex = 0
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        oku.Close()
        baglan.Close()
        _GosterKontrol.LabelSinif.Text = SinifText
        MainForm.StatusLabel.Text = "HAZIR"
        MainForm.ShowModalPanel(_GosterKontrol, DevComponents.DotNetBar.Controls.eSlideSide.Left)
    End Sub
    Public Sub _secOgrencitab()
        If Not baglan.State = ConnectionState.Open Then
            Try
                baglan.Open()
                _GosterKontrol.SuperGrid.PrimaryGrid.Rows.Clear()
                Dim komut1 As OleDbCommand
                Dim oku1 As OleDbDataReader
                komut = New OleDbCommand("SELECT * FROM konular WHERE ders_id = " + _GosterKontrol.SuperTabDersler.SelectedTab.Tag, baglan)
                oku = komut.ExecuteReader()
                While oku.Read()
                    komut1 = New OleDbCommand("SELECT * FROM kontrol WHERE konu_id = " + oku("konu_id").ToString + " AND ogrenci_id = " + _GosterKontrol.SuperTabOgrenciler.SelectedTab.Tag, baglan)
                    oku1 = komut1.ExecuteReader()
                    oku1.Read()
                    Dim rw As New DevComponents.DotNetBar.SuperGrid.GridRow(oku("konunun_adı").ToString, oku1("kontrol_1"), oku1("kontrol_2"), oku1("kontrol_3"), oku1("kontrol_4"), oku1("kontrol_5"))
                    rw.Tag = oku1("kontrol_id".ToString)
                    _GosterKontrol.SuperGrid.PrimaryGrid.Rows.Add(rw)
                    oku1.Close()
                End While
            Catch ex As Exception
                DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            oku.Close()
            baglan.Close()
        End If
    End Sub
    Public Sub _secDerstab()
        If baglan.State = ConnectionState.Open Then
            Try
                _GosterKontrol.SuperGrid.PrimaryGrid.Rows.Clear()
                Dim komut1, komut2 As OleDbCommand
                Dim oku1, oku2 As OleDbDataReader
                komut1 = New OleDbCommand("SELECT * FROM konular WHERE ders_id = " + _GosterKontrol.SuperTabDersler.SelectedTab.Tag, baglan)
                oku1 = komut1.ExecuteReader()
                While oku1.Read()
                    komut2 = New OleDbCommand("SELECT * FROM kontrol WHERE konu_id = " + oku1("konu_id").ToString + " AND ogrenci_id = " + _GosterKontrol.SuperTabOgrenciler.SelectedTab.Tag, baglan)
                    oku2 = komut2.ExecuteReader()
                    oku2.Read()
                    Dim rw As New DevComponents.DotNetBar.SuperGrid.GridRow(oku1("konunun_adı").ToString, oku2("kontrol_1"), oku2("kontrol_2"), oku2("kontrol_3"), oku2("kontrol_4"), oku2("kontrol_5"))
                    rw.Tag = oku2("kontrol_id".ToString)
                    _GosterKontrol.SuperGrid.PrimaryGrid.Rows.Add(rw)
                    oku2.Close()
                End While
                oku1.Close()
            Catch ex As Exception
                DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                baglan.Open()
                _GosterKontrol.SuperGrid.PrimaryGrid.Rows.Clear()
                Dim komut1 As OleDbCommand
                Dim oku1 As OleDbDataReader
                komut = New OleDbCommand("SELECT * FROM konular WHERE ders_id = " + _GosterKontrol.SuperTabDersler.SelectedTab.Tag, baglan)
                oku = komut.ExecuteReader()
                While oku.Read()
                    komut1 = New OleDbCommand("SELECT * FROM kontrol WHERE konu_id = " + oku("konu_id").ToString + " AND ogrenci_id = " + _GosterKontrol.SuperTabOgrenciler.SelectedTab.Tag, baglan)
                    oku1 = komut1.ExecuteReader()
                    oku1.Read()
                    Dim rw As New DevComponents.DotNetBar.SuperGrid.GridRow(oku("konunun_adı").ToString, oku1("kontrol_1"), oku1("kontrol_2"), oku1("kontrol_3"), oku1("kontrol_4"), oku1("kontrol_5"))
                    rw.Tag = oku1("kontrol_id".ToString)
                    _GosterKontrol.SuperGrid.PrimaryGrid.Rows.Add(rw)
                    oku1.Close()
                End While
            Catch ex As Exception
                DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            oku.Close()
            baglan.Close()
        End If
    End Sub


#End Region

#Region "ItemAdd_Yukle"

    Public Sub itemadd_ders(ByVal where As DevComponents.DotNetBar.ItemContainer, ByVal text As String, ByVal titletext As String, ByVal tag As String)
        Dim item As New MetroTile_Ders
        item.TileColor = Rnd() * 10
        item.Text = text
        item.TitleText = titletext
        item.TitleTextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        item.Tag = tag
        where.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {item})
    End Sub
    Public Sub itemadd_konu(ByVal text As String, ByVal tag As String)
        Dim item As New MetroTile_Konu
        item.TileColor = Rnd() * 10
        item.Text = text
        item.Tag = tag
        item.TitleTextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        _MetroKonu.Container1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {item})
    End Sub

    Public Sub itemadd_sinif(ByVal where As DevComponents.DotNetBar.ItemContainer, ByVal text As String, ByVal titletext As String, ByVal tag As String)
        Dim item As New MetroTile_Sinif
        item.TileColor = Rnd() * 10
        item.Text = text
        item.TitleText = titletext
        item.TitleTextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        item.Tag = tag
        where.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {item})
    End Sub
    Public Sub itemadd_ogrenci(ByVal text As String, ByVal titletext As String, ByVal tag As String)
        Dim item As New MetroTile_Ogrenci
        item.TileColor = Rnd() * 10
        item.Text = text
        item.TitleText = titletext
        item.TitleTextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        item.Tag = tag
        _MetroOgrenci.Container1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {item})
    End Sub

    Public Sub itemadd_kontrolsinif(ByVal where As DevComponents.DotNetBar.ItemContainer, ByVal text As String, ByVal titletext As String, ByVal tag As String)
        Dim item As New MetroTile_KontrolSinif
        item.TileColor = Rnd() * 10
        item.Text = text
        item.TitleText = titletext
        item.TitleTextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        item.Tag = tag
        where.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {item})
    End Sub
    Public Sub itemadd_kontrol_tab_ogrenci(ByVal tag As String, ByVal text As String)
        Dim tab As New DevComponents.DotNetBar.SuperTabItem
        tab.Tag = tag
        tab.Text = text
        _GosterKontrol.SuperTabOgrenciler.Tabs.Add(tab)
    End Sub
    Public Sub itemadd_kontrol_tab_ders(ByVal tag As String, ByVal text As String)
        Dim tab As New DevComponents.DotNetBar.SuperTabItem
        tab.Tag = tag
        tab.Text = text
        _GosterKontrol.SuperTabDersler.Tabs.Add(tab)
    End Sub
#End Region

#Region "Ekle"

    Public Function _EkleDers(ByVal values() As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("INSERT INTO dersler(dersin_sinifi,dersin_adi) values('" + values(0) + _v("") + values(1) + "')", baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function
    Public Function _EkleKonu(ByVal values() As String) As Boolean
        Try
            Dim komut1, komut2 As OleDbCommand
            Dim oku1 As OleDbDataReader
            baglan.Open()
            komut = New OleDbCommand("INSERT INTO konular(ders_id,konunun_adı) values('" + values(0) + _v("") + values(1) + "')", baglan)
            komut.ExecuteNonQuery()
            komut = New OleDbCommand("SELECT konu_id FROM konular WHERE konunun_adı = '" + values(1) + "'", baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            Dim konuid As String = oku("konu_id").ToString
            komut = New OleDbCommand("SELECT dersin_sinifi FROM dersler WHERE ders_id = " + values(0), baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            komut = New OleDbCommand("SELECT sinif_id FROM sınıflar WHERE sinif = " + oku("dersin_sinifi").ToString, baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                komut1 = New OleDbCommand("SELECT ogrenci_id FROM öğrenciler WHERE sinifi_id = " + oku("sinif_id").ToString, baglan)
                oku1 = komut1.ExecuteReader()
                While oku1.Read()
                    komut2 = New OleDbCommand("INSERT INTO kontrol(konu_id,ogrenci_id) values('" + konuid + _v("") + oku1("ogrenci_id").ToString + "')", baglan)
                    komut2.ExecuteNonQuery()
                End While
                oku1.Close()
            End While
            oku.Close()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function

    Public Function _EkleSinif(ByVal values() As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("INSERT INTO sınıflar(sinif,sube,ogretmen) values('" + values(0) + _v("") + values(1) + _v("") + values(2) + "')", baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function
    Public Function _EkleOgrenci(ByVal values() As String, ByVal bit As Bitmap) As Boolean
        Try
            Dim komut1, komut2 As OleDbCommand
            Dim oku1 As OleDbDataReader
            baglan.Open()
            komut = New OleDbCommand("INSERT INTO öğrenciler(sinifi_id,ogrencinin_adi,ogrencinin_soyadi,ogrencinin_numarasi,o_anneadi,o_babaadi,o_annetel,o_babatel,o_tcno) values('" + values(0) + _v("") + values(1) + _v("") + values(2) + _v("") + values(3) + _v("") + values(4) + _v("") + values(5) + _v("") + values(6) + _v("") + values(7) + _v("") + values(8) + "')", baglan)
            komut.ExecuteNonQuery()
            komut = New OleDbCommand("SELECT ogrenci_id FROM öğrenciler WHERE o_tcno = '" + values(8) + "' AND ogrencinin_soyadi = '" + values(2) + "'", baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            Dim ogrenci_id As String = oku("ogrenci_id").ToString
            bit.Save(_imgloc + ogrenci_id + ".png", Imaging.ImageFormat.Png)
            komut = New OleDbCommand("SELECT sinif FROM sınıflar WHERE sinif_id = " + values(0), baglan)
            oku = komut.ExecuteReader()
            oku.Read()
            komut = New OleDbCommand("SELECT ders_id FROM dersler WHERE dersin_sinifi = " + oku("sinif").ToString, baglan)
            oku = komut.ExecuteReader()
            While oku.Read()
                komut1 = New OleDbCommand("SELECT konu_id FROM konular WHERE ders_id = " + oku("ders_id").ToString, baglan)
                oku1 = komut1.ExecuteReader()
                While oku1.Read()
                    komut2 = New OleDbCommand("INSERT INTO kontrol(konu_id,ogrenci_id) values ('" + oku1("konu_id").ToString + _v("") + ogrenci_id + "')", baglan)
                    komut2.ExecuteNonQuery()
                End While
                oku1.Close()
            End While
            oku.Close()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function

#End Region

#Region "Guncelle"

    Public Function _GuncelleDers(ByVal values() As String, ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("UPDATE dersler SET dersin_sinifi='" + values(0) + _v("dersin_adi=") + values(1) + "' WHERE ders_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function
    Public Function _GuncelleKonu(ByVal values() As String, ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("UPDATE konular SET konunun_adı='" + values(0) + "' WHERE konu_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function

    Public Function _GuncelleOgrenci(ByVal values() As String, ByVal bit As Bitmap, ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("UPDATE öğrenciler SET sinifi_id='" + values(0) + _v("ogrencinin_adi=") + values(1) + _v("ogrencinin_soyadi=") + values(2) + _v("ogrencinin_numarasi=") + values(3) + _v("o_anneadi=") + values(4) + _v("o_babaadi=") + values(5) + _v("o_annetel=") + values(6) + _v("o_babatel=") + values(7) + _v("o_tcno=") + values(8) + "' WHERE ogrenci_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            bit.Save(_imgloc + where + ".png", Imaging.ImageFormat.Png)
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function
    Public Function _GuncelleSinif(ByVal values() As String, ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("UPDATE sınıflar SET sinif='" + values(0) + _v("sube=") + values(1) + _v("ogretmen=") + values(2) + "' WHERE sinif_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function

    Public Sub _GuncelleKontrol(ByVal column As String, ByVal where As String, ByVal value As Boolean)
        'Try
        baglan.Open()
        komut = New OleDbCommand("UPDATE kontrol SET kontrol_" + column + "=" + value.ToString + " WHERE kontrol_id=" + where, baglan)
        komut.ExecuteNonQuery()
        'Catch ex As Exception
        '    DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try  
        baglan.Close()
    End Sub

#End Region

#Region "Sil"

    Public Function _SilDers(ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT konu_id FROM konular WHERE ders_id=" + where, baglan)
            oku = komut.ExecuteReader()
            Dim komut2 As OleDbCommand
            While oku.Read()
                komut2 = New OleDbCommand("DELETE FROM kontrol WHERE ders_id=" + oku("konu_id").ToString, baglan)
                komut2.ExecuteNonQuery()
            End While
            oku.Close()
            komut = New OleDbCommand("DELETE FROM konular WHERE ders_id=" + where, baglan)
            komut.ExecuteNonQuery()
            komut = New OleDbCommand("DELETE FROM dersler WHERE ders_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function
    Public Function _SilKonu(ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("DELETE FROM kontrol WHERE konu_id=" + where, baglan)
            komut.ExecuteNonQuery()
            komut = New OleDbCommand("DELETE FROM konular WHERE konu_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function

    Public Function _SilOgrenci(ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("DELETE FROM kontrol WHERE ogrenci_id=" + where, baglan)
            komut.ExecuteNonQuery()
            komut = New OleDbCommand("DELETE FROM öğrenciler WHERE ogrenci_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function
    Public Function _SilSinif(ByVal where As String) As Boolean
        Try
            baglan.Open()
            komut = New OleDbCommand("SELECT ogrenci_id FROM öğrenciler WHERE sinifi_id=" + where, baglan) 'kontrol verisini sil(öğrenci
            oku = komut.ExecuteReader()
            Dim komut2 As OleDbCommand
            While oku.Read()
                komut2 = New OleDbCommand("DELETE FROM kontrol WHERE ogrenci_id=" + oku("ogrenci_id").ToString, baglan)
                komut2.ExecuteNonQuery()
            End While
            oku.Close()
            komut = New OleDbCommand("DELETE FROM öğrenciler WHERE sinifi_id=" + where, baglan)
            komut.ExecuteNonQuery()
            komut = New OleDbCommand("DELETE FROM sınıflar WHERE sinif_id=" + where, baglan)
            komut.ExecuteNonQuery()
            baglan.Close()
            Return True
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show("Bir hata oluştu :" + vbCrLf + ex.Message.ToString, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            baglan.Close()
            Return False
        End Try
    End Function

#End Region

#Region "Temizle"
    Public Sub _TemizleDers()
        With _MetroDers
            .Container8.SubItems.Clear()
            .Container9.SubItems.Clear()
            .Container10.SubItems.Clear()
            .Container11.SubItems.Clear()
            .Container12.SubItems.Clear()
            .ButtonDuzenle.Visible = False
            .ButtonSil.Visible = False
        End With
        _selectedMetroTileDers = Nothing
    End Sub
    Public Sub _TemizleKonu()
        With _MetroKonu
            .Container1.SubItems.Clear()
            .ButtonDuzenle.Visible = False
            .ButtonSil.Visible = False
        End With
        _selectedMetroTileKonu = Nothing
    End Sub

    Public Sub _TemizleSinif()
        With _MetroSinif
            .Container8.SubItems.Clear()
            .Container9.SubItems.Clear()
            .Container10.SubItems.Clear()
            .Container11.SubItems.Clear()
            .Container12.SubItems.Clear()
            .ButtonDuzenle.Visible = False
            .ButtonSil.Visible = False
        End With
        _selectedMetroTileSinif = Nothing
    End Sub
    Public Sub _TemizleOgrenci()
        With _MetroOgrenci
            .Container1.SubItems.Clear()
            .ButtonDuzenle.Visible = False
            .ButtonSil.Visible = False
        End With
        _selectedMetroTileOgrenci = Nothing
    End Sub

    Public Sub _TemizleKontrolSinif()
        With _GosterKontrolSinif
            .Container8.SubItems.Clear()
            .Container9.SubItems.Clear()
            .Container10.SubItems.Clear()
            .Container11.SubItems.Clear()
            .Container12.SubItems.Clear()
        End With
    End Sub
    Public Sub _TemizleKontrol()
        With _GosterKontrol
            .SuperTabDersler.Tabs.Clear()
            .SuperTabOgrenciler.Tabs.Clear()
            .SuperGrid.PrimaryGrid.Rows.Clear()
        End With
    End Sub

#End Region

End Module
