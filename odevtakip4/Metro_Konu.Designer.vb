<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Metro_Konu
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
        Me.MetroTilePanel = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.Container1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ButtonEkle = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonDuzenle = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonSil = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonGeri = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'MetroTilePanel
        '
        Me.MetroTilePanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTilePanel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.MetroTilePanel.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MetroTilePanel.ForeColor = System.Drawing.Color.Black
        Me.MetroTilePanel.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Container1})
        Me.MetroTilePanel.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.MetroTilePanel.Location = New System.Drawing.Point(68, 16)
        Me.MetroTilePanel.Name = "MetroTilePanel"
        Me.MetroTilePanel.Size = New System.Drawing.Size(898, 348)
        Me.MetroTilePanel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MetroTilePanel.TabIndex = 11
        '
        'Container1
        '
        '
        '
        '
        Me.Container1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Container1.MultiLine = True
        Me.Container1.Name = "Container1"
        '
        '
        '
        Me.Container1.TitleStyle.Class = "MetroTileGroupTitle"
        Me.Container1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'ButtonEkle
        '
        Me.ButtonEkle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonEkle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEkle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonEkle.Image = Global.odevtakip4.My.Resources.Resources.add
        Me.ButtonEkle.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonEkle.ImageTextSpacing = 3
        Me.ButtonEkle.Location = New System.Drawing.Point(894, 370)
        Me.ButtonEkle.Name = "ButtonEkle"
        Me.ButtonEkle.Size = New System.Drawing.Size(72, 91)
        Me.ButtonEkle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonEkle.TabIndex = 12
        Me.ButtonEkle.Text = "Ekle"
        '
        'ButtonDuzenle
        '
        Me.ButtonDuzenle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonDuzenle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDuzenle.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.ButtonDuzenle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonDuzenle.Image = Global.odevtakip4.My.Resources.Resources.edit
        Me.ButtonDuzenle.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonDuzenle.ImageTextSpacing = 3
        Me.ButtonDuzenle.Location = New System.Drawing.Point(816, 370)
        Me.ButtonDuzenle.Name = "ButtonDuzenle"
        Me.ButtonDuzenle.Size = New System.Drawing.Size(72, 91)
        Me.ButtonDuzenle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonDuzenle.TabIndex = 13
        Me.ButtonDuzenle.Text = "Düzenle"
        Me.ButtonDuzenle.Visible = False
        '
        'ButtonSil
        '
        Me.ButtonSil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonSil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSil.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground
        Me.ButtonSil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ButtonSil.Image = Global.odevtakip4.My.Resources.Resources.delete
        Me.ButtonSil.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonSil.ImageTextSpacing = 3
        Me.ButtonSil.Location = New System.Drawing.Point(738, 370)
        Me.ButtonSil.Name = "ButtonSil"
        Me.ButtonSil.Size = New System.Drawing.Size(72, 91)
        Me.ButtonSil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonSil.TabIndex = 14
        Me.ButtonSil.Text = "Sil"
        Me.ButtonSil.Visible = False
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
        Me.ButtonGeri.TabIndex = 15
        '
        'Metro_Konu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonGeri)
        Me.Controls.Add(Me.ButtonSil)
        Me.Controls.Add(Me.ButtonDuzenle)
        Me.Controls.Add(Me.ButtonEkle)
        Me.Controls.Add(Me.MetroTilePanel)
        Me.Name = "Metro_Konu"
        Me.Size = New System.Drawing.Size(979, 474)
        Me.ResumeLayout(False)

    End Sub
        Public WithEvents MetroTilePanel As DevComponents.DotNetBar.Metro.MetroTilePanel
        Public WithEvents Container1 As DevComponents.DotNetBar.ItemContainer
        Public WithEvents ButtonEkle As DevComponents.DotNetBar.ButtonX
        Public WithEvents ButtonDuzenle As DevComponents.DotNetBar.ButtonX
        Public WithEvents ButtonSil As DevComponents.DotNetBar.ButtonX
        Public WithEvents ButtonGeri As DevComponents.DotNetBar.ButtonX

    End Class

