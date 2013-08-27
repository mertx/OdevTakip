<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sil_Konu
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
        Me.Buttoniptal = New DevComponents.DotNetBar.ButtonX()
        Me.Buttonsil = New DevComponents.DotNetBar.ButtonX()
        Me.LabelSoru = New DevComponents.DotNetBar.LabelX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.SuspendLayout()
        '
        'Buttoniptal
        '
        Me.Buttoniptal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttoniptal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttoniptal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.Buttoniptal, True)
        Me.Buttoniptal.Location = New System.Drawing.Point(273, 38)
        Me.Buttoniptal.Name = "Buttoniptal"
        Me.Buttoniptal.Size = New System.Drawing.Size(88, 29)
        Me.Buttoniptal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Buttoniptal.TabIndex = 1
        Me.Buttoniptal.Text = "İptal"
        '
        'Buttonsil
        '
        Me.Buttonsil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttonsil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttonsil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.Buttonsil, True)
        Me.Buttonsil.Location = New System.Drawing.Point(367, 38)
        Me.Buttonsil.Name = "Buttonsil"
        Me.Buttonsil.Size = New System.Drawing.Size(88, 29)
        Me.Buttonsil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Buttonsil.TabIndex = 0
        Me.Buttonsil.Text = "Sil"
        '
        'LabelSoru
        '
        '
        '
        '
        Me.LabelSoru.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelSoru.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelSoru.Location = New System.Drawing.Point(7, 3)
        Me.LabelSoru.Name = "LabelSoru"
        Me.LabelSoru.Size = New System.Drawing.Size(448, 29)
        Me.LabelSoru.TabIndex = 2
        Me.LabelSoru.Text = "Konuyu ve kontrol bilgilerini silmek istediğinize emin misiniz ?"
        Me.LabelSoru.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'Sil_Konu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Buttoniptal)
        Me.Controls.Add(Me.Buttonsil)
        Me.Controls.Add(Me.LabelSoru)
        Me.Name = "Sil_Konu"
        Me.Size = New System.Drawing.Size(458, 74)
        Me.ResumeLayout(False)

    End Sub
        Friend WithEvents Buttoniptal As DevComponents.DotNetBar.ButtonX
        Friend WithEvents Buttonsil As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelSoru As DevComponents.DotNetBar.LabelX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter

    End Class
