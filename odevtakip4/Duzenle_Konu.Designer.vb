<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Duzenle_Konu
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
        Me.TextBoxKonu = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Buttoniptal = New DevComponents.DotNetBar.ButtonX()
        Me.Buttontamam = New DevComponents.DotNetBar.ButtonX()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.SuspendLayout()
        '
        'TextBoxKonu
        '
        Me.TextBoxKonu.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.TextBoxKonu.Border.Class = "TextBoxBorder"
        Me.TextBoxKonu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxKonu.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TextBoxKonu.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.TextBoxKonu, True)
        Me.TextBoxKonu.Location = New System.Drawing.Point(106, 56)
        Me.TextBoxKonu.Name = "TextBoxKonu"
        Me.TextBoxKonu.Size = New System.Drawing.Size(239, 29)
        Me.TextBoxKonu.TabIndex = 0
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(16, 54)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(84, 29)
        Me.LabelX3.TabIndex = 3
        Me.LabelX3.Text = "Konu adı :"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Buttoniptal
        '
        Me.Buttoniptal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttoniptal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttoniptal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.Buttoniptal, True)
        Me.Buttoniptal.Location = New System.Drawing.Point(163, 91)
        Me.Buttoniptal.Name = "Buttoniptal"
        Me.Buttoniptal.Size = New System.Drawing.Size(88, 29)
        Me.Buttoniptal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Buttoniptal.TabIndex = 2
        Me.Buttoniptal.Text = "İptal"
        '
        'Buttontamam
        '
        Me.Buttontamam.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Buttontamam.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Buttontamam.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Highlighter1.SetHighlightOnFocus(Me.Buttontamam, True)
        Me.Buttontamam.Location = New System.Drawing.Point(257, 91)
        Me.Buttontamam.Name = "Buttontamam"
        Me.Buttontamam.Size = New System.Drawing.Size(88, 29)
        Me.Buttontamam.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Buttontamam.TabIndex = 1
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
        Me.labelX5.TabIndex = 4
        Me.labelX5.Text = "Konuyu Düzenle"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'Duzenle_Konu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBoxKonu)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.Buttoniptal)
        Me.Controls.Add(Me.Buttontamam)
        Me.Controls.Add(Me.labelX5)
        Me.Name = "Duzenle_Konu"
        Me.Size = New System.Drawing.Size(354, 130)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBoxKonu As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
        Friend WithEvents Buttoniptal As DevComponents.DotNetBar.ButtonX
        Friend WithEvents Buttontamam As DevComponents.DotNetBar.ButtonX
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter

    End Class
