<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_SHOW_REP_CALCU
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.BTN_EXCEL = New System.Windows.Forms.Button()
        Me.C0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.BTN_EXCEL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 50)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.DGV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 400)
        Me.Panel2.TabIndex = 1
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C0, Me.C1, Me.C2, Me.C3, Me.C4, Me.C5, Me.C6, Me.C7, Me.C8, Me.C9, Me.C10, Me.C11})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DGV.RowHeadersWidth = 51
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle28
        Me.DGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.DGV.RowTemplate.Height = 35
        Me.DGV.Size = New System.Drawing.Size(800, 400)
        Me.DGV.TabIndex = 1
        '
        'BTN_EXCEL
        '
        Me.BTN_EXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EXCEL.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTN_EXCEL.Location = New System.Drawing.Point(12, 12)
        Me.BTN_EXCEL.Name = "BTN_EXCEL"
        Me.BTN_EXCEL.Size = New System.Drawing.Size(98, 30)
        Me.BTN_EXCEL.TabIndex = 46
        Me.BTN_EXCEL.Text = "EXCEL"
        Me.BTN_EXCEL.UseVisualStyleBackColor = True
        '
        'C0
        '
        Me.C0.DataPropertyName = "NUMBER_"
        Me.C0.FillWeight = 58.02778!
        Me.C0.HeaderText = "الرقم"
        Me.C0.MinimumWidth = 6
        Me.C0.Name = "C0"
        Me.C0.ReadOnly = True
        Me.C0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C1
        '
        Me.C1.DataPropertyName = "DATE_"
        Me.C1.FillWeight = 150.0!
        Me.C1.HeaderText = "التاريخ"
        Me.C1.MaxInputLength = 200
        Me.C1.MinimumWidth = 6
        Me.C1.Name = "C1"
        Me.C1.ReadOnly = True
        Me.C1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.C1.ToolTipText = "اسم الفئة"
        '
        'C2
        '
        Me.C2.DataPropertyName = "NOTE_"
        Me.C2.HeaderText = "ملاحظات"
        Me.C2.MinimumWidth = 6
        Me.C2.Name = "C2"
        Me.C2.ReadOnly = True
        Me.C2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C3
        '
        Me.C3.DataPropertyName = "CASH_"
        DataGridViewCellStyle23.Format = "N3"
        DataGridViewCellStyle23.NullValue = Nothing
        Me.C3.DefaultCellStyle = DataGridViewCellStyle23
        Me.C3.HeaderText = "العهدة"
        Me.C3.MaxInputLength = 50
        Me.C3.MinimumWidth = 6
        Me.C3.Name = "C3"
        Me.C3.ReadOnly = True
        Me.C3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C4
        '
        Me.C4.DataPropertyName = "SALES_1"
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.C4.DefaultCellStyle = DataGridViewCellStyle24
        Me.C4.HeaderText = "المبيعات النقدية"
        Me.C4.MaxInputLength = 50
        Me.C4.MinimumWidth = 6
        Me.C4.Name = "C4"
        Me.C4.ReadOnly = True
        Me.C4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C5
        '
        Me.C5.DataPropertyName = "SALES_2"
        DataGridViewCellStyle25.Format = "N3"
        DataGridViewCellStyle25.NullValue = Nothing
        Me.C5.DefaultCellStyle = DataGridViewCellStyle25
        Me.C5.HeaderText = "المبيعات الأخرى"
        Me.C5.MaxInputLength = 50
        Me.C5.MinimumWidth = 6
        Me.C5.Name = "C5"
        Me.C5.ReadOnly = True
        Me.C5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C6
        '
        Me.C6.DataPropertyName = "SUM_SALE"
        DataGridViewCellStyle26.Format = "N0"
        DataGridViewCellStyle26.NullValue = Nothing
        Me.C6.DefaultCellStyle = DataGridViewCellStyle26
        Me.C6.HeaderText = "مجموع المبيعات"
        Me.C6.MaxInputLength = 20
        Me.C6.MinimumWidth = 6
        Me.C6.Name = "C6"
        Me.C6.ReadOnly = True
        Me.C6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C7
        '
        Me.C7.DataPropertyName = "SUM_CASH_"
        DataGridViewCellStyle27.Format = "N3"
        DataGridViewCellStyle27.NullValue = Nothing
        Me.C7.DefaultCellStyle = DataGridViewCellStyle27
        Me.C7.HeaderText = "مجموع النقد"
        Me.C7.MinimumWidth = 6
        Me.C7.Name = "C7"
        Me.C7.ReadOnly = True
        Me.C7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'C8
        '
        Me.C8.DataPropertyName = "WITHDRAWE_"
        Me.C8.HeaderText = "المسحوب"
        Me.C8.Name = "C8"
        Me.C8.ReadOnly = True
        '
        'C9
        '
        Me.C9.DataPropertyName = "NET_CASH"
        Me.C9.HeaderText = "صافي النقد"
        Me.C9.Name = "C9"
        Me.C9.ReadOnly = True
        '
        'C10
        '
        Me.C10.DataPropertyName = "COUNT_"
        Me.C10.HeaderText = "الجرد"
        Me.C10.Name = "C10"
        Me.C10.ReadOnly = True
        '
        'C11
        '
        Me.C11.DataPropertyName = "DIFFERENCE_"
        Me.C11.HeaderText = "الفرق"
        Me.C11.Name = "C11"
        Me.C11.ReadOnly = True
        '
        'FRM_REP_CALCU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRM_REP_CALCU"
        Me.Text = "تقرير"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents BTN_EXCEL As Button
    Friend WithEvents C0 As DataGridViewTextBoxColumn
    Friend WithEvents C1 As DataGridViewTextBoxColumn
    Friend WithEvents C2 As DataGridViewTextBoxColumn
    Friend WithEvents C3 As DataGridViewTextBoxColumn
    Friend WithEvents C4 As DataGridViewTextBoxColumn
    Friend WithEvents C5 As DataGridViewTextBoxColumn
    Friend WithEvents C6 As DataGridViewTextBoxColumn
    Friend WithEvents C7 As DataGridViewTextBoxColumn
    Friend WithEvents C8 As DataGridViewTextBoxColumn
    Friend WithEvents C9 As DataGridViewTextBoxColumn
    Friend WithEvents C10 As DataGridViewTextBoxColumn
    Friend WithEvents C11 As DataGridViewTextBoxColumn
End Class
