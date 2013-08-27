<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Goster_Kontrol
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
        Dim GridColumn1 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn2 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn3 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn4 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn5 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Dim GridColumn6 As DevComponents.DotNetBar.SuperGrid.GridColumn = New DevComponents.DotNetBar.SuperGrid.GridColumn()
        Me.SuperTabDersler = New DevComponents.DotNetBar.SuperTabStrip()
        Me.SuperTabOgrenciler = New DevComponents.DotNetBar.SuperTabStrip()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.SuperGrid = New DevComponents.DotNetBar.SuperGrid.SuperGridControl()
        Me.ButtonGeri = New DevComponents.DotNetBar.ButtonX()
        Me.LabelSinif = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        CType(Me.SuperTabDersler, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperTabOgrenciler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SuperTabDersler
        '
        Me.SuperTabDersler.AutoSelectAttachedControl = False
        Me.SuperTabDersler.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.SuperTabDersler.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SuperTabDersler.ContainerControlProcessDialogKey = True
        '
        '
        '
        '
        '
        '
        Me.SuperTabDersler.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabDersler.ControlBox.MenuBox.Name = ""
        Me.SuperTabDersler.ControlBox.MenuBox.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Fade
        Me.SuperTabDersler.ControlBox.Name = ""
        Me.SuperTabDersler.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabDersler.ControlBox.MenuBox, Me.SuperTabDersler.ControlBox.CloseBox})
        Me.SuperTabDersler.Dock = System.Windows.Forms.DockStyle.Top
        Me.SuperTabDersler.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperTabDersler.ForeColor = System.Drawing.Color.Black
        Me.SuperTabDersler.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabDersler.Name = "SuperTabDersler"
        Me.SuperTabDersler.ReorderTabsEnabled = False
        Me.SuperTabDersler.SelectedTabFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperTabDersler.SelectedTabIndex = -1
        Me.SuperTabDersler.Size = New System.Drawing.Size(866, 10)
        Me.SuperTabDersler.TabCloseButtonHot = Nothing
        Me.SuperTabDersler.TabFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperTabDersler.TabIndex = 33
        Me.SuperTabDersler.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit
        Me.SuperTabDersler.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabDersler.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        '
        'SuperTabOgrenciler
        '
        Me.SuperTabOgrenciler.AutoSelectAttachedControl = False
        Me.SuperTabOgrenciler.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.SuperTabOgrenciler.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SuperTabOgrenciler.ContainerControlProcessDialogKey = True
        '
        '
        '
        '
        '
        '
        Me.SuperTabOgrenciler.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabOgrenciler.ControlBox.MenuBox.Name = ""
        Me.SuperTabOgrenciler.ControlBox.Name = ""
        Me.SuperTabOgrenciler.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabOgrenciler.ControlBox.MenuBox, Me.SuperTabOgrenciler.ControlBox.CloseBox})
        Me.SuperTabOgrenciler.Dock = System.Windows.Forms.DockStyle.Left
        Me.SuperTabOgrenciler.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperTabOgrenciler.ForeColor = System.Drawing.Color.Black
        Me.SuperTabOgrenciler.Location = New System.Drawing.Point(0, 0)
        Me.SuperTabOgrenciler.Name = "SuperTabOgrenciler"
        Me.SuperTabOgrenciler.ReorderTabsEnabled = False
        Me.SuperTabOgrenciler.SelectedTabFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperTabOgrenciler.SelectedTabIndex = -1
        Me.SuperTabOgrenciler.Size = New System.Drawing.Size(10, 371)
        Me.SuperTabOgrenciler.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.SuperTabOgrenciler.TabCloseButtonHot = Nothing
        Me.SuperTabOgrenciler.TabFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperTabOgrenciler.TabHorizontalSpacing = 10
        Me.SuperTabOgrenciler.TabIndex = 36
        Me.SuperTabOgrenciler.TabLayoutType = DevComponents.DotNetBar.eSuperTabLayoutType.SingleLineFit
        Me.SuperTabOgrenciler.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.SuperTabOgrenciler.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.SuperGrid)
        Me.PanelEx1.Controls.Add(Me.SuperTabDersler)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(10, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(866, 371)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 37
        '
        'SuperGrid
        '
        Me.SuperGrid.BackColor = System.Drawing.Color.White
        Me.SuperGrid.DefaultVisualStyles.CellStyles.Default.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperGrid.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed
        Me.SuperGrid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.SuperGrid.ForeColor = System.Drawing.Color.Black
        Me.SuperGrid.Location = New System.Drawing.Point(0, 10)
        Me.SuperGrid.Name = "SuperGrid"
        GridColumn1.AllowEdit = False
        GridColumn1.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill
        GridColumn1.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.None
        GridColumn1.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        GridColumn1.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridLabelXEditControl)
        GridColumn1.HeaderStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleLeft
        GridColumn1.Name = "Kontrol"
        GridColumn1.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None
        GridColumn2.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.None
        GridColumn2.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
        GridColumn2.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn2.Name = "1"
        GridColumn2.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None
        GridColumn2.Width = 65
        GridColumn3.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.None
        GridColumn3.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
        GridColumn3.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn3.Name = "2"
        GridColumn3.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None
        GridColumn3.Width = 65
        GridColumn4.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.None
        GridColumn4.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
        GridColumn4.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn4.Name = "3"
        GridColumn4.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None
        GridColumn4.Width = 65
        GridColumn5.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.None
        GridColumn5.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
        GridColumn5.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn5.Name = "4"
        GridColumn5.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None
        GridColumn5.Width = 65
        GridColumn6.CellHighlightMode = DevComponents.DotNetBar.SuperGrid.Style.CellHighlightMode.None
        GridColumn6.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.TopCenter
        GridColumn6.EditorType = GetType(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl)
        GridColumn6.Name = "5"
        GridColumn6.ResizeMode = DevComponents.DotNetBar.SuperGrid.ColumnResizeMode.None
        GridColumn6.Width = 65
        Me.SuperGrid.PrimaryGrid.Columns.Add(GridColumn1)
        Me.SuperGrid.PrimaryGrid.Columns.Add(GridColumn2)
        Me.SuperGrid.PrimaryGrid.Columns.Add(GridColumn3)
        Me.SuperGrid.PrimaryGrid.Columns.Add(GridColumn4)
        Me.SuperGrid.PrimaryGrid.Columns.Add(GridColumn5)
        Me.SuperGrid.PrimaryGrid.Columns.Add(GridColumn6)
        Me.SuperGrid.PrimaryGrid.MultiSelect = False
        Me.SuperGrid.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row
        Me.SuperGrid.PrimaryGrid.UseAlternateRowStyle = True
        Me.SuperGrid.Size = New System.Drawing.Size(866, 361)
        Me.SuperGrid.TabIndex = 34
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
        Me.ButtonGeri.TabIndex = 16
        Me.ButtonGeri.Tooltip = "Geri"
        '
        'LabelSinif
        '
        '
        '
        '
        Me.LabelSinif.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelSinif.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSinif.Location = New System.Drawing.Point(85, 33)
        Me.LabelSinif.Name = "LabelSinif"
        Me.LabelSinif.Size = New System.Drawing.Size(153, 50)
        Me.LabelSinif.TabIndex = 39
        Me.LabelSinif.Text = "*/*"
        '
        'PanelEx2
        '
        Me.PanelEx2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.PanelEx1)
        Me.PanelEx2.Controls.Add(Me.SuperTabOgrenciler)
        Me.PanelEx2.Location = New System.Drawing.Point(86, 84)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(876, 371)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 40
        '
        'Goster_Kontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.LabelSinif)
        Me.Controls.Add(Me.ButtonGeri)
        Me.Name = "Goster_Kontrol"
        Me.Size = New System.Drawing.Size(979, 474)
        CType(Me.SuperTabDersler, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperTabOgrenciler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents ButtonGeri As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SuperTabDersler As DevComponents.DotNetBar.SuperTabStrip
    Friend WithEvents SuperTabOgrenciler As DevComponents.DotNetBar.SuperTabStrip
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents SuperGrid As DevComponents.DotNetBar.SuperGrid.SuperGridControl
    Public WithEvents LabelSinif As DevComponents.DotNetBar.LabelX

End Class
