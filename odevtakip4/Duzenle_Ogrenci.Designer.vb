<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Duzenle_Ogrenci
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.TextBoxAdi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Buttoniptal = New DevComponents.DotNetBar.ButtonX()
        Me.Buttontamam = New DevComponents.DotNetBar.ButtonX()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxSoyadi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxNumarasi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TextBoxBabaAdi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxAnneTel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxAnneAdi = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxBabaTel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxTC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'TextBoxAdi
        '
        Me.TextBoxAdi.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxAdi.Border.Class = "TextBoxBorder"
        Me.TextBoxAdi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxAdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxAdi.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxAdi, True)
        Me.TextBoxAdi.Location = New System.Drawing.Point(389, 51)
        Me.TextBoxAdi.Name = "TextBoxAdi"
        Me.TextBoxAdi.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxAdi.TabIndex = 0
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(271, 49)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(112, 29)
        Me.LabelX3.TabIndex = 19
        Me.LabelX3.Text = "Adı :"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Buttoniptal
        '
        Me.Buttoniptal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttoniptal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttoniptal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.Buttoniptal, True)
        Me.Buttoniptal.Location = New System.Drawing.Point(419, 355)
        Me.Buttoniptal.Name = "Buttoniptal"
        Me.Buttoniptal.Size = New System.Drawing.Size(88, 29)
        Me.Buttoniptal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Buttoniptal.TabIndex = 10
        Me.Buttoniptal.Text = "İptal"
        '
        'Buttontamam
        '
        Me.Buttontamam.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttontamam.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttontamam.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.Buttontamam, True)
        Me.Buttontamam.Location = New System.Drawing.Point(513, 355)
        Me.Buttontamam.Name = "Buttontamam"
        Me.Buttontamam.Size = New System.Drawing.Size(88, 29)
        Me.Buttontamam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Buttontamam.TabIndex = 9
        Me.Buttontamam.Text = "Tamam"
        '
        'labelX5
        '
        '
        '
        '
        Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelX5.Location = New System.Drawing.Point(16, 11)
        Me.labelX5.Name = "labelX5"
        Me.labelX5.Size = New System.Drawing.Size(294, 32)
        Me.labelX5.TabIndex = 20
        Me.labelX5.Text = "Öğrenci Ekle"
        '
        'TextBoxSoyadi
        '
        Me.TextBoxSoyadi.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxSoyadi.Border.Class = "TextBoxBorder"
        Me.TextBoxSoyadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxSoyadi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxSoyadi.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxSoyadi, True)
        Me.TextBoxSoyadi.Location = New System.Drawing.Point(389, 86)
        Me.TextBoxSoyadi.Name = "TextBoxSoyadi"
        Me.TextBoxSoyadi.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxSoyadi.TabIndex = 1
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(271, 84)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(112, 29)
        Me.LabelX4.TabIndex = 18
        Me.LabelX4.Text = "Soyadı :"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TextBoxNumarasi
        '
        Me.TextBoxNumarasi.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxNumarasi.Border.Class = "TextBoxBorder"
        Me.TextBoxNumarasi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxNumarasi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxNumarasi.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxNumarasi, True)
        Me.TextBoxNumarasi.Location = New System.Drawing.Point(389, 121)
        Me.TextBoxNumarasi.Name = "TextBoxNumarasi"
        Me.TextBoxNumarasi.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxNumarasi.TabIndex = 2
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(271, 119)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(112, 29)
        Me.LabelX6.TabIndex = 17
        Me.LabelX6.Text = "Numarası :"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TextBoxBabaAdi
        '
        Me.TextBoxBabaAdi.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxBabaAdi.Border.Class = "TextBoxBorder"
        Me.TextBoxBabaAdi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxBabaAdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxBabaAdi.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxBabaAdi, True)
        Me.TextBoxBabaAdi.Location = New System.Drawing.Point(389, 261)
        Me.TextBoxBabaAdi.Name = "TextBoxBabaAdi"
        Me.TextBoxBabaAdi.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxBabaAdi.TabIndex = 6
        '
        'TextBoxAnneTel
        '
        Me.TextBoxAnneTel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxAnneTel.Border.Class = "TextBoxBorder"
        Me.TextBoxAnneTel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxAnneTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxAnneTel.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxAnneTel, True)
        Me.TextBoxAnneTel.Location = New System.Drawing.Point(389, 226)
        Me.TextBoxAnneTel.Name = "TextBoxAnneTel"
        Me.TextBoxAnneTel.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxAnneTel.TabIndex = 5
        '
        'TextBoxAnneAdi
        '
        Me.TextBoxAnneAdi.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxAnneAdi.Border.Class = "TextBoxBorder"
        Me.TextBoxAnneAdi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxAnneAdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxAnneAdi.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxAnneAdi, True)
        Me.TextBoxAnneAdi.Location = New System.Drawing.Point(389, 191)
        Me.TextBoxAnneAdi.Name = "TextBoxAnneAdi"
        Me.TextBoxAnneAdi.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxAnneAdi.TabIndex = 4
        '
        'TextBoxBabaTel
        '
        Me.TextBoxBabaTel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxBabaTel.Border.Class = "TextBoxBorder"
        Me.TextBoxBabaTel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxBabaTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxBabaTel.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxBabaTel, True)
        Me.TextBoxBabaTel.Location = New System.Drawing.Point(389, 296)
        Me.TextBoxBabaTel.Name = "TextBoxBabaTel"
        Me.TextBoxBabaTel.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxBabaTel.TabIndex = 7
        '
        'TextBoxTC
        '
        Me.TextBoxTC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxTC.Border.Class = "TextBoxBorder"
        Me.TextBoxTC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxTC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxTC.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxTC, True)
        Me.TextBoxTC.Location = New System.Drawing.Point(389, 156)
        Me.TextBoxTC.Name = "TextBoxTC"
        Me.TextBoxTC.Size = New System.Drawing.Size(212, 29)
        Me.TextBoxTC.TabIndex = 3
        '
        'ReflectionImage1
        '
        Me.ReflectionImage1.BackColor = System.Drawing.SystemColors.ButtonShadow
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Highlighter1.SetHighlightColor(Me.ReflectionImage1, DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
        Me.Highlighter1.SetHighlightOnFocus(Me.ReflectionImage1, True)
        Me.ReflectionImage1.Location = New System.Drawing.Point(32, 49)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.ReflectionEnabled = False
        Me.ReflectionImage1.Size = New System.Drawing.Size(225, 300)
        Me.ReflectionImage1.TabIndex = 11
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.ButtonX1, True)
        Me.ButtonX1.Location = New System.Drawing.Point(32, 355)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(225, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 8
        Me.ButtonX1.Text = "Fotoğraf Seç"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(271, 259)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(112, 29)
        Me.LabelX1.TabIndex = 13
        Me.LabelX1.Text = "Baba adı :"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(271, 224)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(112, 29)
        Me.LabelX2.TabIndex = 14
        Me.LabelX2.Text = "Anne telefonu :"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(271, 189)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(112, 29)
        Me.LabelX7.TabIndex = 15
        Me.LabelX7.Text = "Anne adı :"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(271, 294)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(112, 29)
        Me.LabelX8.TabIndex = 12
        Me.LabelX8.Text = "Baba telefonu :"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(271, 154)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(112, 29)
        Me.LabelX9.TabIndex = 16
        Me.LabelX9.Text = "TC Kimlik no :"
        Me.LabelX9.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'OpenFile
        '
        Me.OpenFile.Filter = "Fotoğraf dosyaları|*.jpg;*.jpeg;*.png;*.bmp"
        Me.OpenFile.RestoreDirectory = True
        Me.OpenFile.Title = "Fotoğraf Seç"
        '
        'Duzenle_Ogrenci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Controls.Add(Me.TextBoxBabaTel)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.TextBoxTC)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.TextBoxBabaAdi)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.TextBoxAnneTel)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.TextBoxAnneAdi)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.TextBoxNumarasi)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.TextBoxSoyadi)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.TextBoxAdi)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.Buttoniptal)
        Me.Controls.Add(Me.Buttontamam)
        Me.Controls.Add(Me.labelX5)
        Me.Highlighter1.SetHighlightOnFocus(Me, True)
        Me.Name = "Duzenle_Ogrenci"
        Me.Size = New System.Drawing.Size(614, 394)
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents TextBoxAdi As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
        Friend WithEvents Buttoniptal As DevComponents.DotNetBar.ButtonX
        Friend WithEvents Buttontamam As DevComponents.DotNetBar.ButtonX
        Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
        Friend WithEvents TextBoxSoyadi As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
        Friend WithEvents TextBoxNumarasi As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
        Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
        Friend WithEvents TextBoxBabaTel As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
        Friend WithEvents TextBoxTC As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
        Friend WithEvents TextBoxBabaAdi As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
        Friend WithEvents TextBoxAnneTel As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
        Friend WithEvents TextBoxAnneAdi As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
        Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
        Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog

    End Class
