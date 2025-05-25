<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CATEGORY
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

    'NOTE_: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BTN_NEW = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_ADD = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_UPDATE = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_DELETE = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buttonexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHB_SERH = New System.Windows.Forms.CheckBox()
        Me.BTN_MIN = New System.Windows.Forms.Button()
        Me.BTN_DOWN = New System.Windows.Forms.Button()
        Me.BTN_MAX = New System.Windows.Forms.Button()
        Me.BTN_UP = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_GUID = New System.Windows.Forms.TextBox()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_NOTE_ = New System.Windows.Forms.TextBox()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_AMOUNT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 43)
        Me.Panel1.TabIndex = 77
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTN_NEW, Me.BTN_ADD, Me.BTN_UPDATE, Me.BTN_DELETE, Me.Buttonexit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(516, 43)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(66, 39)
        Me.BTN_NEW.Text = "جديد F2"
        '
        'BTN_ADD
        '
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(75, 39)
        Me.BTN_ADD.Text = "إضافة F5"
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(71, 39)
        Me.BTN_UPDATE.Text = "تعديل F6"
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.Name = "BTN_DELETE"
        Me.BTN_DELETE.Size = New System.Drawing.Size(45, 39)
        Me.BTN_DELETE.Text = "حذف"
        '
        'Buttonexit
        '
        Me.Buttonexit.Name = "Buttonexit"
        Me.Buttonexit.Size = New System.Drawing.Size(52, 39)
        Me.Buttonexit.Text = "خروج"
        '
        'CHB_SERH
        '
        Me.CHB_SERH.AutoSize = True
        Me.CHB_SERH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHB_SERH.Location = New System.Drawing.Point(116, 100)
        Me.CHB_SERH.Name = "CHB_SERH"
        Me.CHB_SERH.Size = New System.Drawing.Size(48, 19)
        Me.CHB_SERH.TabIndex = 7
        Me.CHB_SERH.Text = "بحث"
        Me.CHB_SERH.UseVisualStyleBackColor = True
        '
        'BTN_MIN
        '
        Me.BTN_MIN.BackgroundImage = Global.cashcount.My.Resources.Resources.Down
        Me.BTN_MIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_MIN.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MIN.Location = New System.Drawing.Point(138, 48)
        Me.BTN_MIN.Name = "BTN_MIN"
        Me.BTN_MIN.Size = New System.Drawing.Size(35, 30)
        Me.BTN_MIN.TabIndex = 6
        Me.BTN_MIN.UseVisualStyleBackColor = True
        '
        'BTN_DOWN
        '
        Me.BTN_DOWN.BackgroundImage = Global.cashcount.My.Resources.Resources.Left
        Me.BTN_DOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DOWN.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_DOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DOWN.Location = New System.Drawing.Point(175, 48)
        Me.BTN_DOWN.Name = "BTN_DOWN"
        Me.BTN_DOWN.Size = New System.Drawing.Size(35, 30)
        Me.BTN_DOWN.TabIndex = 5
        Me.BTN_DOWN.UseVisualStyleBackColor = True
        '
        'BTN_MAX
        '
        Me.BTN_MAX.BackgroundImage = Global.cashcount.My.Resources.Resources.Up
        Me.BTN_MAX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_MAX.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_MAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MAX.Location = New System.Drawing.Point(361, 48)
        Me.BTN_MAX.Name = "BTN_MAX"
        Me.BTN_MAX.Size = New System.Drawing.Size(35, 30)
        Me.BTN_MAX.TabIndex = 3
        Me.BTN_MAX.UseVisualStyleBackColor = True
        '
        'BTN_UP
        '
        Me.BTN_UP.BackgroundImage = Global.cashcount.My.Resources.Resources.Right
        Me.BTN_UP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_UP.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_UP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_UP.Location = New System.Drawing.Point(324, 48)
        Me.BTN_UP.Name = "BTN_UP"
        Me.BTN_UP.Size = New System.Drawing.Size(35, 30)
        Me.BTN_UP.TabIndex = 4
        Me.BTN_UP.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "اسم الفئة"
        '
        'TXT_GUID
        '
        Me.TXT_GUID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_GUID.Location = New System.Drawing.Point(20, 71)
        Me.TXT_GUID.Name = "TXT_GUID"
        Me.TXT_GUID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_GUID.Size = New System.Drawing.Size(59, 29)
        Me.TXT_GUID.TabIndex = 9
        Me.TXT_GUID.TabStop = False
        Me.TXT_GUID.Visible = False
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NAME.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME.Location = New System.Drawing.Point(172, 97)
        Me.TXT_NAME.MaxLength = 50
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NAME.Size = New System.Drawing.Size(184, 29)
        Me.TXT_NAME.TabIndex = 0
        '
        'TXT_NOTE_
        '
        Me.TXT_NOTE_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOTE_.Location = New System.Drawing.Point(172, 185)
        Me.TXT_NOTE_.MaxLength = 50
        Me.TXT_NOTE_.Name = "TXT_NOTE_"
        Me.TXT_NOTE_.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NOTE_.Size = New System.Drawing.Size(184, 29)
        Me.TXT_NOTE_.TabIndex = 2
        '
        'TXT_ID
        '
        Me.TXT_ID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ID.Location = New System.Drawing.Point(216, 50)
        Me.TXT_ID.MaxLength = 10
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(100, 26)
        Me.TXT_ID.TabIndex = 8
        Me.TXT_ID.TabStop = False
        Me.TXT_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "ملاحظات"
        '
        'TXT_AMOUNT
        '
        Me.TXT_AMOUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_AMOUNT.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_AMOUNT.Location = New System.Drawing.Point(172, 137)
        Me.TXT_AMOUNT.MaxLength = 50
        Me.TXT_AMOUNT.Name = "TXT_AMOUNT"
        Me.TXT_AMOUNT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_AMOUNT.Size = New System.Drawing.Size(184, 29)
        Me.TXT_AMOUNT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "مبلغ الفئة"
        '
        'FRM_CATEGORY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(516, 271)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_AMOUNT)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CHB_SERH)
        Me.Controls.Add(Me.BTN_MIN)
        Me.Controls.Add(Me.BTN_DOWN)
        Me.Controls.Add(Me.BTN_MAX)
        Me.Controls.Add(Me.BTN_UP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_GUID)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.TXT_NOTE_)
        Me.Controls.Add(Me.TXT_ID)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(532, 310)
        Me.Name = "FRM_CATEGORY"
        Me.Text = "فئات النقد"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BTN_NEW As ToolStripMenuItem
    Friend WithEvents BTN_ADD As ToolStripMenuItem
    Friend WithEvents BTN_UPDATE As ToolStripMenuItem
    Friend WithEvents BTN_DELETE As ToolStripMenuItem
    Friend WithEvents Buttonexit As ToolStripMenuItem
    Friend WithEvents CHB_SERH As CheckBox
    Friend WithEvents BTN_MIN As Button
    Friend WithEvents BTN_DOWN As Button
    Friend WithEvents BTN_MAX As Button
    Friend WithEvents BTN_UP As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_GUID As TextBox
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents TXT_NOTE_ As TextBox
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_AMOUNT As TextBox
    Friend WithEvents Label2 As Label
End Class
