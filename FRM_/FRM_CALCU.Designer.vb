<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_CALCU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CALCU))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.C0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBL_RESULT = New System.Windows.Forms.Label()
        Me.BTN_POST = New System.Windows.Forms.Button()
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_DEFR = New System.Windows.Forms.TextBox()
        Me.TXT_COUNT = New System.Windows.Forms.TextBox()
        Me.TXT_NET = New System.Windows.Forms.TextBox()
        Me.TXT_WD = New System.Windows.Forms.TextBox()
        Me.TXT_SALE = New System.Windows.Forms.TextBox()
        Me.TXT_CASH = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TXT_SUM_CASH = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.BTN_UPDATE = New System.Windows.Forms.Button()
        Me.BTN_NEW = New System.Windows.Forms.Button()
        Me.TXT_GUID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_SUM_SALE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_NOTE_ = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTN_MIN = New System.Windows.Forms.Button()
        Me.BTN_DOWN = New System.Windows.Forms.Button()
        Me.BTN_MAX = New System.Windows.Forms.Button()
        Me.BTN_UP = New System.Windows.Forms.Button()
        Me.TXT_ID2 = New System.Windows.Forms.TextBox()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.TXT_SALE_2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.DGV)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(371, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 560)
        Me.Panel1.TabIndex = 2
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C0, Me.C1, Me.C2, Me.C3, Me.C4, Me.C5, Me.C6, Me.C7})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.RowHeadersWidth = 51
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.DGV.RowTemplate.Height = 35
        Me.DGV.Size = New System.Drawing.Size(410, 560)
        Me.DGV.TabIndex = 0
        '
        'C0
        '
        Me.C0.FillWeight = 58.02778!
        Me.C0.HeaderText = "ID"
        Me.C0.MinimumWidth = 6
        Me.C0.Name = "C0"
        Me.C0.ReadOnly = True
        Me.C0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.C0.Visible = False
        '
        'C1
        '
        Me.C1.FillWeight = 108.9005!
        Me.C1.HeaderText = "GUID_"
        Me.C1.MaxInputLength = 200
        Me.C1.MinimumWidth = 6
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        Me.C1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.C1.ToolTipText = "اسم الفئة"
        Me.C1.Visible = False
        '
        'C2
        '
        Me.C2.HeaderText = "CATEGORY_ID"
        Me.C2.MinimumWidth = 6
        Me.C2.Name = "C2"
        Me.C2.ReadOnly = True
        Me.C2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.C2.Visible = False
        '
        'C3
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.C3.DefaultCellStyle = DataGridViewCellStyle2
        Me.C3.FillWeight = 80.92908!
        Me.C3.HeaderText = "CATEGORY_GUID"
        Me.C3.MaxInputLength = 50
        Me.C3.MinimumWidth = 6
        Me.C3.Name = "C3"
        Me.C3.ReadOnly = True
        Me.C3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.C3.Visible = False
        '
        'C4
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.C4.DefaultCellStyle = DataGridViewCellStyle3
        Me.C4.FillWeight = 80.92908!
        Me.C4.HeaderText = "اسم الفئة"
        Me.C4.MaxInputLength = 50
        Me.C4.MinimumWidth = 6
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        Me.C4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C5
        '
        DataGridViewCellStyle4.NullValue = Nothing
        Me.C5.DefaultCellStyle = DataGridViewCellStyle4
        Me.C5.FillWeight = 80.92908!
        Me.C5.HeaderText = "مبلغ الفئة"
        Me.C5.MaxInputLength = 50
        Me.C5.MinimumWidth = 6
        Me.C5.Name = "C5"
        Me.C5.ReadOnly = True
        Me.C5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C6
        '
        DataGridViewCellStyle5.NullValue = Nothing
        Me.C6.DefaultCellStyle = DataGridViewCellStyle5
        Me.C6.FillWeight = 80.92908!
        Me.C6.HeaderText = "عدد أوراق الجرد"
        Me.C6.MaxInputLength = 20
        Me.C6.MinimumWidth = 6
        Me.C6.Name = "C6"
        Me.C6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C7
        '
        DataGridViewCellStyle6.NullValue = Nothing
        Me.C7.DefaultCellStyle = DataGridViewCellStyle6
        Me.C7.FillWeight = 80.92908!
        Me.C7.HeaderText = "المجموع"
        Me.C7.MinimumWidth = 6
        Me.C7.Name = "C7"
        Me.C7.ReadOnly = True
        Me.C7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'LBL_RESULT
        '
        Me.LBL_RESULT.AutoSize = True
        Me.LBL_RESULT.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_RESULT.Location = New System.Drawing.Point(19, 434)
        Me.LBL_RESULT.MinimumSize = New System.Drawing.Size(150, 40)
        Me.LBL_RESULT.Name = "LBL_RESULT"
        Me.LBL_RESULT.Size = New System.Drawing.Size(150, 40)
        Me.LBL_RESULT.TabIndex = 15
        Me.LBL_RESULT.Text = "النتيجة"
        Me.LBL_RESULT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_POST
        '
        Me.BTN_POST.Enabled = False
        Me.BTN_POST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_POST.Location = New System.Drawing.Point(9, 513)
        Me.BTN_POST.Name = "BTN_POST"
        Me.BTN_POST.Size = New System.Drawing.Size(100, 30)
        Me.BTN_POST.TabIndex = 14
        Me.BTN_POST.Text = "إغلاق التعديل"
        Me.BTN_POST.UseVisualStyleBackColor = True
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_SAVE.Location = New System.Drawing.Point(258, 513)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(100, 30)
        Me.BTN_SAVE.TabIndex = 5
        Me.BTN_SAVE.Text = "إضافة"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "الفرق"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(167, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "الجرد"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(165, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "صافي النقد"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(164, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "المسحوب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "المبيعات النقدية"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "العهدة"
        '
        'TXT_DEFR
        '
        Me.TXT_DEFR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_DEFR.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DEFR.Location = New System.Drawing.Point(24, 407)
        Me.TXT_DEFR.MaximumSize = New System.Drawing.Size(150, 40)
        Me.TXT_DEFR.MaxLength = 40
        Me.TXT_DEFR.Name = "TXT_DEFR"
        Me.TXT_DEFR.ReadOnly = True
        Me.TXT_DEFR.Size = New System.Drawing.Size(130, 26)
        Me.TXT_DEFR.TabIndex = 5
        Me.TXT_DEFR.TabStop = False
        '
        'TXT_COUNT
        '
        Me.TXT_COUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_COUNT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COUNT.Location = New System.Drawing.Point(24, 376)
        Me.TXT_COUNT.MaxLength = 40
        Me.TXT_COUNT.Name = "TXT_COUNT"
        Me.TXT_COUNT.Size = New System.Drawing.Size(130, 26)
        Me.TXT_COUNT.TabIndex = 4
        '
        'TXT_NET
        '
        Me.TXT_NET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NET.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NET.Location = New System.Drawing.Point(24, 345)
        Me.TXT_NET.MaxLength = 40
        Me.TXT_NET.Name = "TXT_NET"
        Me.TXT_NET.ReadOnly = True
        Me.TXT_NET.Size = New System.Drawing.Size(130, 26)
        Me.TXT_NET.TabIndex = 3
        Me.TXT_NET.TabStop = False
        '
        'TXT_WD
        '
        Me.TXT_WD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_WD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_WD.Location = New System.Drawing.Point(24, 308)
        Me.TXT_WD.MaxLength = 40
        Me.TXT_WD.Name = "TXT_WD"
        Me.TXT_WD.Size = New System.Drawing.Size(130, 26)
        Me.TXT_WD.TabIndex = 3
        '
        'TXT_SALE
        '
        Me.TXT_SALE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_SALE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SALE.Location = New System.Drawing.Point(24, 181)
        Me.TXT_SALE.MaxLength = 40
        Me.TXT_SALE.Name = "TXT_SALE"
        Me.TXT_SALE.Size = New System.Drawing.Size(130, 26)
        Me.TXT_SALE.TabIndex = 1
        '
        'TXT_CASH
        '
        Me.TXT_CASH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CASH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CASH.Location = New System.Drawing.Point(24, 152)
        Me.TXT_CASH.MaxLength = 40
        Me.TXT_CASH.Name = "TXT_CASH"
        Me.TXT_CASH.Size = New System.Drawing.Size(130, 26)
        Me.TXT_CASH.TabIndex = 0
        Me.TXT_CASH.Tag = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TXT_SUM_CASH)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.DTP1)
        Me.Panel2.Controls.Add(Me.BTN_UPDATE)
        Me.Panel2.Controls.Add(Me.BTN_NEW)
        Me.Panel2.Controls.Add(Me.TXT_GUID)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TXT_SUM_SALE)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TXT_NOTE_)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.BTN_MIN)
        Me.Panel2.Controls.Add(Me.BTN_DOWN)
        Me.Panel2.Controls.Add(Me.BTN_MAX)
        Me.Panel2.Controls.Add(Me.BTN_UP)
        Me.Panel2.Controls.Add(Me.TXT_ID2)
        Me.Panel2.Controls.Add(Me.TXT_ID)
        Me.Panel2.Controls.Add(Me.TXT_SALE_2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LBL_RESULT)
        Me.Panel2.Controls.Add(Me.TXT_CASH)
        Me.Panel2.Controls.Add(Me.BTN_POST)
        Me.Panel2.Controls.Add(Me.TXT_SALE)
        Me.Panel2.Controls.Add(Me.BTN_SAVE)
        Me.Panel2.Controls.Add(Me.TXT_WD)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TXT_NET)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TXT_COUNT)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TXT_DEFR)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(371, 560)
        Me.Panel2.TabIndex = 16
        '
        'TXT_SUM_CASH
        '
        Me.TXT_SUM_CASH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_SUM_CASH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SUM_CASH.Location = New System.Drawing.Point(24, 277)
        Me.TXT_SUM_CASH.MaxLength = 40
        Me.TXT_SUM_CASH.Name = "TXT_SUM_CASH"
        Me.TXT_SUM_CASH.ReadOnly = True
        Me.TXT_SUM_CASH.Size = New System.Drawing.Size(130, 26)
        Me.TXT_SUM_CASH.TabIndex = 93
        Me.TXT_SUM_CASH.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(160, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "مجموع النقد"
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "tt ss:mm:hh - yyyy-MM-dd"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(9, 70)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTP1.RightToLeftLayout = True
        Me.DTP1.Size = New System.Drawing.Size(247, 26)
        Me.DTP1.TabIndex = 92
        '
        'BTN_UPDATE
        '
        Me.BTN_UPDATE.Enabled = False
        Me.BTN_UPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_UPDATE.Location = New System.Drawing.Point(139, 513)
        Me.BTN_UPDATE.Name = "BTN_UPDATE"
        Me.BTN_UPDATE.Size = New System.Drawing.Size(100, 30)
        Me.BTN_UPDATE.TabIndex = 91
        Me.BTN_UPDATE.Text = "تعديل"
        Me.BTN_UPDATE.UseVisualStyleBackColor = True
        '
        'BTN_NEW
        '
        Me.BTN_NEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_NEW.Location = New System.Drawing.Point(276, 24)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(75, 27)
        Me.BTN_NEW.TabIndex = 90
        Me.BTN_NEW.Text = "جديد"
        Me.BTN_NEW.UseVisualStyleBackColor = False
        '
        'TXT_GUID
        '
        Me.TXT_GUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_GUID.Location = New System.Drawing.Point(178, 443)
        Me.TXT_GUID.Name = "TXT_GUID"
        Me.TXT_GUID.Size = New System.Drawing.Size(20, 26)
        Me.TXT_GUID.TabIndex = 89
        Me.TXT_GUID.TabStop = False
        Me.TXT_GUID.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(272, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 19)
        Me.Label11.TabIndex = 88
        Me.Label11.Text = "التاريخ"
        '
        'TXT_SUM_SALE
        '
        Me.TXT_SUM_SALE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_SUM_SALE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SUM_SALE.Location = New System.Drawing.Point(24, 247)
        Me.TXT_SUM_SALE.MaxLength = 40
        Me.TXT_SUM_SALE.Name = "TXT_SUM_SALE"
        Me.TXT_SUM_SALE.ReadOnly = True
        Me.TXT_SUM_SALE.Size = New System.Drawing.Size(130, 26)
        Me.TXT_SUM_SALE.TabIndex = 83
        Me.TXT_SUM_SALE.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(160, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 25)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "مجموع المبيعات"
        '
        'TXT_NOTE_
        '
        Me.TXT_NOTE_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_NOTE_.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NOTE_.Location = New System.Drawing.Point(3, 120)
        Me.TXT_NOTE_.MaxLength = 40
        Me.TXT_NOTE_.Name = "TXT_NOTE_"
        Me.TXT_NOTE_.Size = New System.Drawing.Size(361, 26)
        Me.TXT_NOTE_.TabIndex = 81
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(178, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 25)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "ملاحظات"
        '
        'BTN_MIN
        '
        Me.BTN_MIN.BackgroundImage = Global.cashcount.My.Resources.Resources.drop_down
        Me.BTN_MIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_MIN.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MIN.Location = New System.Drawing.Point(9, 24)
        Me.BTN_MIN.Name = "BTN_MIN"
        Me.BTN_MIN.Size = New System.Drawing.Size(35, 30)
        Me.BTN_MIN.TabIndex = 78
        Me.BTN_MIN.UseVisualStyleBackColor = True
        '
        'BTN_DOWN
        '
        Me.BTN_DOWN.BackgroundImage = Global.cashcount.My.Resources.Resources.prev
        Me.BTN_DOWN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_DOWN.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_DOWN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_DOWN.Location = New System.Drawing.Point(45, 24)
        Me.BTN_DOWN.Name = "BTN_DOWN"
        Me.BTN_DOWN.Size = New System.Drawing.Size(35, 30)
        Me.BTN_DOWN.TabIndex = 77
        Me.BTN_DOWN.UseVisualStyleBackColor = True
        '
        'BTN_MAX
        '
        Me.BTN_MAX.BackgroundImage = Global.cashcount.My.Resources.Resources.up_squared_
        Me.BTN_MAX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_MAX.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_MAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_MAX.Location = New System.Drawing.Point(221, 24)
        Me.BTN_MAX.Name = "BTN_MAX"
        Me.BTN_MAX.Size = New System.Drawing.Size(35, 30)
        Me.BTN_MAX.TabIndex = 76
        Me.BTN_MAX.UseVisualStyleBackColor = True
        '
        'BTN_UP
        '
        Me.BTN_UP.BackgroundImage = Global.cashcount.My.Resources.Resources.right_button
        Me.BTN_UP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_UP.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.BTN_UP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_UP.Location = New System.Drawing.Point(185, 24)
        Me.BTN_UP.Name = "BTN_UP"
        Me.BTN_UP.Size = New System.Drawing.Size(35, 30)
        Me.BTN_UP.TabIndex = 75
        Me.BTN_UP.UseVisualStyleBackColor = True
        '
        'TXT_ID2
        '
        Me.TXT_ID2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_ID2.Location = New System.Drawing.Point(82, 26)
        Me.TXT_ID2.MaxLength = 10
        Me.TXT_ID2.Name = "TXT_ID2"
        Me.TXT_ID2.Size = New System.Drawing.Size(100, 26)
        Me.TXT_ID2.TabIndex = 73
        Me.TXT_ID2.TabStop = False
        Me.TXT_ID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(82, 26)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(100, 26)
        Me.TXT_ID.TabIndex = 74
        Me.TXT_ID.TabStop = False
        '
        'TXT_SALE_2
        '
        Me.TXT_SALE_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_SALE_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SALE_2.Location = New System.Drawing.Point(24, 209)
        Me.TXT_SALE_2.MaxLength = 40
        Me.TXT_SALE_2.Name = "TXT_SALE_2"
        Me.TXT_SALE_2.Size = New System.Drawing.Size(130, 26)
        Me.TXT_SALE_2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(160, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "المبيعات الأخرى"
        '
        'FRM_CALCU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 560)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "FRM_CALCU"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "جرد الصندوق"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBL_RESULT As Label
    Friend WithEvents BTN_POST As Button
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_DEFR As TextBox
    Friend WithEvents TXT_COUNT As TextBox
    Friend WithEvents TXT_NET As TextBox
    Friend WithEvents TXT_WD As TextBox
    Friend WithEvents TXT_SALE As TextBox
    Friend WithEvents TXT_CASH As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents TXT_NOTE_ As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BTN_MIN As Button
    Friend WithEvents BTN_DOWN As Button
    Friend WithEvents BTN_MAX As Button
    Friend WithEvents BTN_UP As Button
    Friend WithEvents TXT_ID2 As TextBox
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents TXT_SALE_2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_SUM_SALE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_GUID As TextBox
    Friend WithEvents BTN_NEW As Button
    Friend WithEvents BTN_UPDATE As Button
    Public WithEvents DTP1 As DateTimePicker
    Friend WithEvents TXT_SUM_CASH As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents C0 As DataGridViewTextBoxColumn
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents C6 As DataGridViewTextBoxColumn
    Friend WithEvents C7 As DataGridViewTextBoxColumn
End Class
