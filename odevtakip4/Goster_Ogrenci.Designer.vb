<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Goster_Ogrenci
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
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.ButtonGeri = New DevComponents.DotNetBar.ButtonX()
        Me.LabelAdi = New DevComponents.DotNetBar.LabelX()
        Me.LabelSoyadi = New DevComponents.DotNetBar.LabelX()
        Me.LabelNumarasi = New DevComponents.DotNetBar.LabelX()
        Me.LabelSinif = New DevComponents.DotNetBar.LabelX()
        Me.LabelAnneAdi = New DevComponents.DotNetBar.LabelX()
        Me.LabelBabaAdi = New DevComponents.DotNetBar.LabelX()
        Me.LabelBabaTel = New DevComponents.DotNetBar.LabelX()
        Me.LabelAnneTel = New DevComponents.DotNetBar.LabelX()
        Me.LabelTC = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.SuspendLayout()
        '
        'ReflectionImage1
        '
        Me.ReflectionImage1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReflectionImage1.BackColor = System.Drawing.SystemColors.ButtonShadow
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Highlighter1.SetHighlightColor(Me.ReflectionImage1, DevComponents.DotNetBar.Validator.eHighlightColor.Orange)
        Me.ReflectionImage1.Location = New System.Drawing.Point(85, 33)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.ReflectionEnabled = False
        Me.ReflectionImage1.Size = New System.Drawing.Size(225, 300)
        Me.ReflectionImage1.TabIndex = 0
        '
        'ButtonGeri
        '
        Me.ButtonGeri.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonGeri.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange
        Me.ButtonGeri.DisabledImage = Global.odevtakip4.My.Resources.Resources.back2
        Me.ButtonGeri.Image = Global.odevtakip4.My.Resources.Resources.back1
        Me.ButtonGeri.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonGeri.ImageTextSpacing = 1
        Me.ButtonGeri.Location = New System.Drawing.Point(12, 30)
        Me.ButtonGeri.Name = "ButtonGeri"
        Me.ButtonGeri.Size = New System.Drawing.Size(50, 50)
        Me.ButtonGeri.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonGeri.TabIndex = 17
        '
        'LabelAdi
        '
        Me.LabelAdi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelAdi.AutoSize = True
        '
        '
        '
        Me.LabelAdi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelAdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAdi.Location = New System.Drawing.Point(356, 33)
        Me.LabelAdi.Name = "LabelAdi"
        Me.LabelAdi.Size = New System.Drawing.Size(73, 24)
        Me.LabelAdi.TabIndex = 40
        Me.LabelAdi.Text = "-----------"
        '
        'LabelSoyadi
        '
        Me.LabelSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelSoyadi.AutoSize = True
        '
        '
        '
        Me.LabelSoyadi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelSoyadi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSoyadi.Location = New System.Drawing.Point(379, 63)
        Me.LabelSoyadi.Name = "LabelSoyadi"
        Me.LabelSoyadi.Size = New System.Drawing.Size(54, 24)
        Me.LabelSoyadi.TabIndex = 41
        Me.LabelSoyadi.Text = "--------"
        '
        'LabelNumarasi
        '
        Me.LabelNumarasi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelNumarasi.AutoSize = True
        '
        '
        '
        Me.LabelNumarasi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelNumarasi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelNumarasi.Location = New System.Drawing.Point(400, 93)
        Me.LabelNumarasi.Name = "LabelNumarasi"
        Me.LabelNumarasi.Size = New System.Drawing.Size(43, 24)
        Me.LabelNumarasi.TabIndex = 42
        Me.LabelNumarasi.Text = "******"
        '
        'LabelSinif
        '
        Me.LabelSinif.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelSinif.AutoSize = True
        '
        '
        '
        Me.LabelSinif.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelSinif.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSinif.Location = New System.Drawing.Point(367, 123)
        Me.LabelSinif.Name = "LabelSinif"
        Me.LabelSinif.Size = New System.Drawing.Size(22, 24)
        Me.LabelSinif.TabIndex = 43
        Me.LabelSinif.Text = "*/*"
        '
        'LabelAnneAdi
        '
        Me.LabelAnneAdi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelAnneAdi.AutoSize = True
        '
        '
        '
        Me.LabelAnneAdi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelAnneAdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAnneAdi.Location = New System.Drawing.Point(395, 199)
        Me.LabelAnneAdi.Name = "LabelAnneAdi"
        Me.LabelAnneAdi.Size = New System.Drawing.Size(43, 24)
        Me.LabelAnneAdi.TabIndex = 44
        Me.LabelAnneAdi.Text = "******"
        '
        'LabelBabaAdi
        '
        Me.LabelBabaAdi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelBabaAdi.AutoSize = True
        '
        '
        '
        Me.LabelBabaAdi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelBabaAdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBabaAdi.Location = New System.Drawing.Point(393, 275)
        Me.LabelBabaAdi.Name = "LabelBabaAdi"
        Me.LabelBabaAdi.Size = New System.Drawing.Size(43, 24)
        Me.LabelBabaAdi.TabIndex = 45
        Me.LabelBabaAdi.Text = "******"
        '
        'LabelBabaTel
        '
        Me.LabelBabaTel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelBabaTel.AutoSize = True
        '
        '
        '
        Me.LabelBabaTel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelBabaTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelBabaTel.Location = New System.Drawing.Point(430, 305)
        Me.LabelBabaTel.Name = "LabelBabaTel"
        Me.LabelBabaTel.Size = New System.Drawing.Size(43, 24)
        Me.LabelBabaTel.TabIndex = 47
        Me.LabelBabaTel.Text = "******"
        '
        'LabelAnneTel
        '
        Me.LabelAnneTel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelAnneTel.AutoSize = True
        '
        '
        '
        Me.LabelAnneTel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelAnneTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelAnneTel.Location = New System.Drawing.Point(432, 229)
        Me.LabelAnneTel.Name = "LabelAnneTel"
        Me.LabelAnneTel.Size = New System.Drawing.Size(43, 24)
        Me.LabelAnneTel.TabIndex = 46
        Me.LabelAnneTel.Text = "******"
        '
        'LabelTC
        '
        Me.LabelTC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelTC.AutoSize = True
        '
        '
        '
        Me.LabelTC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelTC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelTC.Location = New System.Drawing.Point(420, 153)
        Me.LabelTC.Name = "LabelTC"
        Me.LabelTC.Size = New System.Drawing.Size(76, 24)
        Me.LabelTC.TabIndex = 48
        Me.LabelTC.Text = "***********"
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(316, 199)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(73, 24)
        Me.LabelX1.TabIndex = 49
        Me.LabelX1.Text = "Anne adı :"
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(316, 275)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(71, 24)
        Me.LabelX2.TabIndex = 50
        Me.LabelX2.Text = "Baba adı :"
        '
        'LabelX3
        '
        Me.LabelX3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(316, 305)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(108, 24)
        Me.LabelX3.TabIndex = 52
        Me.LabelX3.Text = "Baba telefonu :"
        '
        'LabelX4
        '
        Me.LabelX4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(316, 229)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(110, 24)
        Me.LabelX4.TabIndex = 51
        Me.LabelX4.Text = "Anne telefonu :"
        '
        'LabelX5
        '
        Me.LabelX5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(316, 153)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(98, 24)
        Me.LabelX5.TabIndex = 53
        Me.LabelX5.Text = "TC Kimlik no :"
        '
        'LabelX6
        '
        Me.LabelX6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(316, 33)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(34, 24)
        Me.LabelX6.TabIndex = 54
        Me.LabelX6.Text = "Adı :"
        '
        'LabelX7
        '
        Me.LabelX7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(316, 63)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(57, 24)
        Me.LabelX7.TabIndex = 55
        Me.LabelX7.Text = "Soyadı :"
        '
        'LabelX8
        '
        Me.LabelX8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(316, 93)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(78, 24)
        Me.LabelX8.TabIndex = 56
        Me.LabelX8.Text = "Numarası :"
        '
        'LabelX9
        '
        Me.LabelX9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(316, 123)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(45, 24)
        Me.LabelX9.TabIndex = 57
        Me.LabelX9.Text = "Sınıfı :"
        '
        'Line1
        '
        Me.Line1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Line1.Location = New System.Drawing.Point(316, 183)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(180, 10)
        Me.Line1.TabIndex = 58
        Me.Line1.Text = "Line1"
        '
        'Line2
        '
        Me.Line2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Line2.Location = New System.Drawing.Point(316, 259)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(180, 10)
        Me.Line2.TabIndex = 59
        Me.Line2.Text = "Line2"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'Goster_Ogrenci
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.LabelX9)
        Me.Controls.Add(Me.LabelX8)
        Me.Controls.Add(Me.LabelX7)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.LabelTC)
        Me.Controls.Add(Me.LabelBabaTel)
        Me.Controls.Add(Me.LabelAnneTel)
        Me.Controls.Add(Me.LabelBabaAdi)
        Me.Controls.Add(Me.LabelAnneAdi)
        Me.Controls.Add(Me.LabelSinif)
        Me.Controls.Add(Me.LabelNumarasi)
        Me.Controls.Add(Me.LabelSoyadi)
        Me.Controls.Add(Me.LabelAdi)
        Me.Controls.Add(Me.ButtonGeri)
        Me.Controls.Add(Me.ReflectionImage1)
        Me.Name = "Goster_Ogrenci"
        Me.Size = New System.Drawing.Size(536, 348)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Public WithEvents ButtonGeri As DevComponents.DotNetBar.ButtonX
    Public WithEvents LabelAdi As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelSoyadi As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelNumarasi As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelSinif As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelAnneAdi As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelBabaAdi As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelBabaTel As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelAnneTel As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelTC As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Public WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter

End Class
