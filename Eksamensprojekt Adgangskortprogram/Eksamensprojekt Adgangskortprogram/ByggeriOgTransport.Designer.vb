<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ByggeriOgTransport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Lbl_Overskrift_Byggeri = New System.Windows.Forms.Label()
        Me.Lbl_Overskrift_Transport = New System.Windows.Forms.Label()
        Me.LBox_Byggeri = New System.Windows.Forms.ListBox()
        Me.LBox_Transport = New System.Windows.Forms.ListBox()
        Me.But_Tilbage_ByggeriOgTransport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Overskrift_Byggeri
        '
        Me.Lbl_Overskrift_Byggeri.AutoSize = True
        Me.Lbl_Overskrift_Byggeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Overskrift_Byggeri.Location = New System.Drawing.Point(72, 9)
        Me.Lbl_Overskrift_Byggeri.Name = "Lbl_Overskrift_Byggeri"
        Me.Lbl_Overskrift_Byggeri.Size = New System.Drawing.Size(124, 37)
        Me.Lbl_Overskrift_Byggeri.TabIndex = 0
        Me.Lbl_Overskrift_Byggeri.Text = "Byggeri"
        Me.Lbl_Overskrift_Byggeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Overskrift_Transport
        '
        Me.Lbl_Overskrift_Transport.AutoSize = True
        Me.Lbl_Overskrift_Transport.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Overskrift_Transport.Location = New System.Drawing.Point(342, 9)
        Me.Lbl_Overskrift_Transport.Name = "Lbl_Overskrift_Transport"
        Me.Lbl_Overskrift_Transport.Size = New System.Drawing.Size(156, 37)
        Me.Lbl_Overskrift_Transport.TabIndex = 1
        Me.Lbl_Overskrift_Transport.Text = "Transport"
        Me.Lbl_Overskrift_Transport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBox_Byggeri
        '
        Me.LBox_Byggeri.FormattingEnabled = True
        Me.LBox_Byggeri.Location = New System.Drawing.Point(29, 63)
        Me.LBox_Byggeri.Name = "LBox_Byggeri"
        Me.LBox_Byggeri.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LBox_Byggeri.Size = New System.Drawing.Size(235, 342)
        Me.LBox_Byggeri.TabIndex = 2
        '
        'LBox_Transport
        '
        Me.LBox_Transport.FormattingEnabled = True
        Me.LBox_Transport.Location = New System.Drawing.Point(301, 63)
        Me.LBox_Transport.Name = "LBox_Transport"
        Me.LBox_Transport.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LBox_Transport.Size = New System.Drawing.Size(235, 342)
        Me.LBox_Transport.TabIndex = 3
        '
        'But_Tilbage_ByggeriOgTransport
        '
        Me.But_Tilbage_ByggeriOgTransport.Location = New System.Drawing.Point(199, 415)
        Me.But_Tilbage_ByggeriOgTransport.Name = "But_Tilbage_ByggeriOgTransport"
        Me.But_Tilbage_ByggeriOgTransport.Size = New System.Drawing.Size(164, 23)
        Me.But_Tilbage_ByggeriOgTransport.TabIndex = 4
        Me.But_Tilbage_ByggeriOgTransport.Text = "Tilbage"
        Me.But_Tilbage_ByggeriOgTransport.UseVisualStyleBackColor = True
        '
        'ByggeriOgTransport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 450)
        Me.Controls.Add(Me.But_Tilbage_ByggeriOgTransport)
        Me.Controls.Add(Me.LBox_Transport)
        Me.Controls.Add(Me.LBox_Byggeri)
        Me.Controls.Add(Me.Lbl_Overskrift_Transport)
        Me.Controls.Add(Me.Lbl_Overskrift_Byggeri)
        Me.Name = "ByggeriOgTransport"
        Me.Text = "ByggeriOgTransport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Overskrift_Byggeri As Label
    Friend WithEvents Lbl_Overskrift_Transport As Label
    Friend WithEvents LBox_Byggeri As ListBox
    Friend WithEvents LBox_Transport As ListBox
    Friend WithEvents But_Tilbage_ByggeriOgTransport As Button
End Class
