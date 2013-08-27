<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class message_control
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
        Me.LabelMessage = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'LabelMessage
        '
        '
        '
        '
        Me.LabelMessage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LabelMessage.Location = New System.Drawing.Point(10, 10)
        Me.LabelMessage.Name = "LabelMessage"
        Me.LabelMessage.Size = New System.Drawing.Size(571, 29)
        Me.LabelMessage.TabIndex = 37
        Me.LabelMessage.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'message_control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LabelMessage)
        Me.Name = "message_control"
        Me.Size = New System.Drawing.Size(591, 49)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelMessage As DevComponents.DotNetBar.LabelX

End Class
