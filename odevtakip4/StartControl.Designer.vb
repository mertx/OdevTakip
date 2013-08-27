<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartControl
    Inherits DevComponents.DotNetBar.Controls.SlidePanel

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
        Me.MetroTileItemSiniflar = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItemDersler = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItemKontrol = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroTilePanel1 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.ıtemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.SuspendLayout()
        '
        'MetroTileItemSiniflar
        '
        Me.MetroTileItemSiniflar.CheckBehavior = DevComponents.DotNetBar.Metro.eMetroTileCheckBehavior.None
        Me.MetroTileItemSiniflar.Image = Global.odevtakip4.My.Resources.Resources.student
        Me.MetroTileItemSiniflar.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.MetroTileItemSiniflar.Name = "MetroTileItemSiniflar"
        Me.MetroTileItemSiniflar.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItemSiniflar.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal
        Me.MetroTileItemSiniflar.TileSize = New System.Drawing.Size(312, 152)
        '
        '
        '
        Me.MetroTileItemSiniflar.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItemSiniflar.TitleText = "Sınıflar ve Öğrenciler"
        Me.MetroTileItemSiniflar.TitleTextFont = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        '
        'MetroTileItemDersler
        '
        Me.MetroTileItemDersler.CheckBehavior = DevComponents.DotNetBar.Metro.eMetroTileCheckBehavior.None
        Me.MetroTileItemDersler.Image = Global.odevtakip4.My.Resources.Resources.book
        Me.MetroTileItemDersler.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.MetroTileItemDersler.Name = "MetroTileItemDersler"
        Me.MetroTileItemDersler.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItemDersler.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive
        Me.MetroTileItemDersler.TileSize = New System.Drawing.Size(312, 152)
        '
        '
        '
        Me.MetroTileItemDersler.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItemDersler.TitleText = "Dersler ve Konular"
        Me.MetroTileItemDersler.TitleTextFont = New System.Drawing.Font("Segoe UI", 11.25!)
        '
        'MetroTileItemKontrol
        '
        Me.MetroTileItemKontrol.CheckBehavior = DevComponents.DotNetBar.Metro.eMetroTileCheckBehavior.None
        Me.MetroTileItemKontrol.Image = Global.odevtakip4.My.Resources.Resources.check1
        Me.MetroTileItemKontrol.ImageTextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.MetroTileItemKontrol.Name = "MetroTileItemKontrol"
        Me.MetroTileItemKontrol.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItemKontrol.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum
        Me.MetroTileItemKontrol.TileSize = New System.Drawing.Size(312, 152)
        '
        '
        '
        Me.MetroTileItemKontrol.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItemKontrol.TitleText = "Ödev Kontrolü"
        Me.MetroTileItemKontrol.TitleTextFont = New System.Drawing.Font("Segoe UI", 11.25!)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 58.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 104)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Başlangıç"
        '
        'MetroTilePanel1
        '
        Me.MetroTilePanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MetroTilePanel1.AutoScroll = False
        '
        '
        '
        Me.MetroTilePanel1.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel1.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ıtemContainer1})
        Me.MetroTilePanel1.Location = New System.Drawing.Point(70, 139)
        Me.MetroTilePanel1.Name = "MetroTilePanel1"
        Me.MetroTilePanel1.Size = New System.Drawing.Size(970, 202)
        Me.MetroTilePanel1.TabIndex = 6
        Me.MetroTilePanel1.Text = "MetroTilePanel1"
        '
        'ıtemContainer1
        '
        '
        '
        '
        Me.ıtemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ıtemContainer1.MultiLine = True
        Me.ıtemContainer1.Name = "ıtemContainer1"
        Me.ıtemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTileItemSiniflar, Me.MetroTileItemDersler, Me.MetroTileItemKontrol})
        '
        '
        '
        Me.ıtemContainer1.TitleStyle.Class = "MetroTileGroupTitle"
        Me.ıtemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'StartControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.MetroTilePanel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StartControl"
        Me.Size = New System.Drawing.Size(1110, 344)
        Me.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTileItemSiniflar As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItemDersler As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItemKontrol As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MetroTilePanel1 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents ıtemContainer1 As DevComponents.DotNetBar.ItemContainer

End Class
