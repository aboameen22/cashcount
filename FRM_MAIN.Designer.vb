<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MAIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MAIN))
        Me.PNL_MAIN = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStrip_MAIN = New System.Windows.Forms.ToolStrip()
        Me.Btn_FRM_CALCU = New System.Windows.Forms.ToolStripButton()
        Me.Btn_FRM_CATEGORY = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Setting = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Exit = New System.Windows.Forms.ToolStripButton()
        Me.BTN_REP_CALCU = New System.Windows.Forms.ToolStripButton()
        Me.PNL_MAIN.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip_MAIN.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL_MAIN
        '
        Me.PNL_MAIN.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PNL_MAIN.Controls.Add(Me.PictureBox1)
        Me.PNL_MAIN.Controls.Add(Me.ToolStrip_MAIN)
        Me.PNL_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_MAIN.Location = New System.Drawing.Point(0, 0)
        Me.PNL_MAIN.Name = "PNL_MAIN"
        Me.PNL_MAIN.Size = New System.Drawing.Size(800, 450)
        Me.PNL_MAIN.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 400)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ToolStrip_MAIN
        '
        Me.ToolStrip_MAIN.AutoSize = False
        Me.ToolStrip_MAIN.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip_MAIN.GripMargin = New System.Windows.Forms.Padding(10, 2, 2, 2)
        Me.ToolStrip_MAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_FRM_CALCU, Me.Btn_FRM_CATEGORY, Me.Btn_Setting, Me.Btn_Exit, Me.BTN_REP_CALCU})
        Me.ToolStrip_MAIN.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip_MAIN.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip_MAIN.Name = "ToolStrip_MAIN"
        Me.ToolStrip_MAIN.Size = New System.Drawing.Size(800, 50)
        Me.ToolStrip_MAIN.Stretch = True
        Me.ToolStrip_MAIN.TabIndex = 0
        Me.ToolStrip_MAIN.Text = "ToolStrip1"
        '
        'Btn_FRM_CALCU
        '
        Me.Btn_FRM_CALCU.AutoSize = False
        Me.Btn_FRM_CALCU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_FRM_CALCU.Image = CType(resources.GetObject("Btn_FRM_CALCU.Image"), System.Drawing.Image)
        Me.Btn_FRM_CALCU.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_FRM_CALCU.Name = "Btn_FRM_CALCU"
        Me.Btn_FRM_CALCU.Size = New System.Drawing.Size(100, 50)
        Me.Btn_FRM_CALCU.Text = "إدخال جرد"
        '
        'Btn_FRM_CATEGORY
        '
        Me.Btn_FRM_CATEGORY.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_FRM_CATEGORY.AutoSize = False
        Me.Btn_FRM_CATEGORY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_FRM_CATEGORY.Image = CType(resources.GetObject("Btn_FRM_CATEGORY.Image"), System.Drawing.Image)
        Me.Btn_FRM_CATEGORY.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_FRM_CATEGORY.Name = "Btn_FRM_CATEGORY"
        Me.Btn_FRM_CATEGORY.Size = New System.Drawing.Size(100, 50)
        Me.Btn_FRM_CATEGORY.Text = "الفئات"
        '
        'Btn_Setting
        '
        Me.Btn_Setting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Btn_Setting.AutoSize = False
        Me.Btn_Setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_Setting.Image = CType(resources.GetObject("Btn_Setting.Image"), System.Drawing.Image)
        Me.Btn_Setting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Setting.Name = "Btn_Setting"
        Me.Btn_Setting.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Setting.Text = "إعدادات"
        '
        'Btn_Exit
        '
        Me.Btn_Exit.AutoSize = False
        Me.Btn_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Btn_Exit.Image = CType(resources.GetObject("Btn_Exit.Image"), System.Drawing.Image)
        Me.Btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Exit.Text = "خروج"
        '
        'BTN_REP_CALCU
        '
        Me.BTN_REP_CALCU.AutoSize = False
        Me.BTN_REP_CALCU.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BTN_REP_CALCU.Image = CType(resources.GetObject("BTN_REP_CALCU.Image"), System.Drawing.Image)
        Me.BTN_REP_CALCU.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_REP_CALCU.Name = "BTN_REP_CALCU"
        Me.BTN_REP_CALCU.Size = New System.Drawing.Size(100, 50)
        Me.BTN_REP_CALCU.Text = "تقرير"
        '
        'FRM_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PNL_MAIN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FRM_MAIN"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "برنامج جرد الصندوق"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PNL_MAIN.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip_MAIN.ResumeLayout(False)
        Me.ToolStrip_MAIN.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL_MAIN As Panel
    Friend WithEvents ToolStrip_MAIN As ToolStrip
    Friend WithEvents Btn_FRM_CALCU As ToolStripButton
    Friend WithEvents Btn_FRM_CATEGORY As ToolStripButton
    Friend WithEvents Btn_Setting As ToolStripButton
    Friend WithEvents Btn_Exit As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTN_REP_CALCU As ToolStripButton
End Class
