<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_REP_CALCU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_REP_CALCU))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.DTP2 = New System.Windows.Forms.DateTimePicker()
        Me.BTN_SHOW_ = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTN_SHOW_)
        Me.Panel1.Controls.Add(Me.DTP2)
        Me.Panel1.Controls.Add(Me.DTP1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 198)
        Me.Panel1.TabIndex = 0
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "tt ss:mm:hh - yyyy-MM-dd"
        Me.DTP1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(12, 23)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTP1.RightToLeftLayout = True
        Me.DTP1.Size = New System.Drawing.Size(268, 29)
        Me.DTP1.TabIndex = 93
        '
        'DTP2
        '
        Me.DTP2.CustomFormat = "tt ss:mm:hh - yyyy-MM-dd"
        Me.DTP2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP2.Location = New System.Drawing.Point(12, 72)
        Me.DTP2.Name = "DTP2"
        Me.DTP2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTP2.RightToLeftLayout = True
        Me.DTP2.Size = New System.Drawing.Size(268, 29)
        Me.DTP2.TabIndex = 94
        '
        'BTN_SHOW_
        '
        Me.BTN_SHOW_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SHOW_.Location = New System.Drawing.Point(140, 133)
        Me.BTN_SHOW_.Name = "BTN_SHOW_"
        Me.BTN_SHOW_.Size = New System.Drawing.Size(100, 30)
        Me.BTN_SHOW_.TabIndex = 95
        Me.BTN_SHOW_.Text = "إظهار"
        Me.BTN_SHOW_.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 21)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "من"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 21)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "إلى"
        '
        'FRM_REP_CALCU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 198)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_REP_CALCU"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تقرير"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Public WithEvents DTP2 As DateTimePicker
    Public WithEvents DTP1 As DateTimePicker
    Friend WithEvents BTN_SHOW_ As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
