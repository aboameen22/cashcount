<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_SETTING
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXT_CASH_IN = New System.Windows.Forms.TextBox()
        Me.CBX_CASH_R = New System.Windows.Forms.CheckBox()
        Me.CBX_CASH_F = New System.Windows.Forms.CheckBox()
        Me.BTN_SAVE_DEC = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_CUR_DEC = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.TXT_CASH_IN)
        Me.Panel1.Controls.Add(Me.CBX_CASH_R)
        Me.Panel1.Controls.Add(Me.CBX_CASH_F)
        Me.Panel1.Controls.Add(Me.BTN_SAVE_DEC)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TXT_CUR_DEC)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 252)
        Me.Panel1.TabIndex = 0
        '
        'TXT_CASH_IN
        '
        Me.TXT_CASH_IN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CASH_IN.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CASH_IN.Location = New System.Drawing.Point(116, 10)
        Me.TXT_CASH_IN.MaxLength = 25
        Me.TXT_CASH_IN.Name = "TXT_CASH_IN"
        Me.TXT_CASH_IN.Size = New System.Drawing.Size(100, 29)
        Me.TXT_CASH_IN.TabIndex = 100
        Me.TXT_CASH_IN.TabStop = False
        '
        'CBX_CASH_R
        '
        Me.CBX_CASH_R.AutoSize = True
        Me.CBX_CASH_R.Checked = True
        Me.CBX_CASH_R.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBX_CASH_R.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBX_CASH_R.Location = New System.Drawing.Point(25, 16)
        Me.CBX_CASH_R.Name = "CBX_CASH_R"
        Me.CBX_CASH_R.Size = New System.Drawing.Size(71, 17)
        Me.CBX_CASH_R.TabIndex = 99
        Me.CBX_CASH_R.Text = "تدوير الجرد"
        Me.CBX_CASH_R.UseVisualStyleBackColor = True
        '
        'CBX_CASH_F
        '
        Me.CBX_CASH_F.AutoSize = True
        Me.CBX_CASH_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBX_CASH_F.Location = New System.Drawing.Point(222, 17)
        Me.CBX_CASH_F.Name = "CBX_CASH_F"
        Me.CBX_CASH_F.Size = New System.Drawing.Size(69, 17)
        Me.CBX_CASH_F.TabIndex = 98
        Me.CBX_CASH_F.Text = "عهدة ثابتة"
        Me.CBX_CASH_F.UseVisualStyleBackColor = True
        '
        'BTN_SAVE_DEC
        '
        Me.BTN_SAVE_DEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SAVE_DEC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE_DEC.Location = New System.Drawing.Point(226, 186)
        Me.BTN_SAVE_DEC.Name = "BTN_SAVE_DEC"
        Me.BTN_SAVE_DEC.Size = New System.Drawing.Size(90, 30)
        Me.BTN_SAVE_DEC.TabIndex = 97
        Me.BTN_SAVE_DEC.Text = "حفظ"
        Me.BTN_SAVE_DEC.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(443, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 21)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "الخانات العشرية"
        '
        'TXT_CUR_DEC
        '
        Me.TXT_CUR_DEC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CUR_DEC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CUR_DEC.Location = New System.Drawing.Point(323, 11)
        Me.TXT_CUR_DEC.Name = "TXT_CUR_DEC"
        Me.TXT_CUR_DEC.Size = New System.Drawing.Size(100, 29)
        Me.TXT_CUR_DEC.TabIndex = 95
        Me.TXT_CUR_DEC.TabStop = False
        '
        'FRM_SETTING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 252)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRM_SETTING"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "الإعدادات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_CUR_DEC As TextBox
    Friend WithEvents BTN_SAVE_DEC As Button
    Friend WithEvents CBX_CASH_R As CheckBox
    Friend WithEvents CBX_CASH_F As CheckBox
    Friend WithEvents TXT_CASH_IN As TextBox
End Class
