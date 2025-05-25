Imports System.ComponentModel
Imports System.Globalization

Public Class FRM_CALCU
    ReadOnly CLS_CALCU_ As New CLS_CALCU
    ReadOnly CLS_CATEGORY_ As New CLS_CATEGORY
    Dim SAVED As Boolean = False
    'متغيرات التكست لأجل الجمع والإضافة
    Dim TXT_CASH_ As Decimal = 0D 'العهدة
    Dim TXT_SALE_ As Decimal = 0D 'المبيعات النقدية
    Dim TXT_SALE_2_ As Decimal = 0D ' المبيعات الأخرى
    Dim TXT_SUM_SLAE_ As Decimal = 0D 'مجموع المبيعات
    Dim TXT_SUM_CASH_ As Decimal = 0D ' مجموع النقد
    Dim TXT_WD_ As Decimal = 0D 'المسحوب
    Dim TXT_NET_ As Decimal = 0D ' صافي النقد
    Dim TXT_COUNT_ As Decimal = 0D ' الجرد
    Dim TXT_DEFR_ As Decimal = 0D ' الفرق

    Private Sub FRM_CALCU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MAX_1()  ' في اللود يعطي سجل جديد
            SEARCH_LOAD()
            TXT_SALE.Focus()
            COUNT_HEADER()
            TXT_SALE.Select()
            DTP1.Value = Now
            DGV.Columns(0).DefaultCellStyle.BackColor = Color.LightSteelBlue
            DGV.Columns(1).DefaultCellStyle.BackColor = Color.LightSteelBlue
            DGV.Columns(2).DefaultCellStyle.BackColor = Color.LightSteelBlue
            DGV.Columns(3).DefaultCellStyle.BackColor = Color.CadetBlue
            DGV.Columns(4).DefaultCellStyle.BackColor = Color.CadetBlue
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub COUNT_HEADER() ' ترقيم تلقائي للاسطر
        If DGV IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (DGV.Rows.Count - 1))
                DGV.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
    End Sub
    Sub SEARCH_LOAD()
        TXT_CASH.Text = CASH_IN_M
        ' تعبئة الفئات
        Dim COUNT_ As Integer = 0 'تعريف متغير للوب
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CATEGORY_.Show_LOAD()
        If DT.Rows.Count > 0 Then
            DGV.RowCount = DT.Rows.Count + 1 ' مهم جدا عدد الاسطر في الداتاجريد تساوي عدد الاسطر في الداتاتيبل ويضيف سطر
            For I As Integer = 0 To DT.Rows.Count - 1 ' تعبئة الداتاجريد بحيث يمر على الداتا تيبل بلوب
                DGV.Rows(COUNT_).Cells(2).Value = DT.Rows(I)(0).ToString 'ID
                DGV.Rows(COUNT_).Cells(3).Value = DT.Rows(I)(1).ToString 'GUID
                DGV.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(2).ToString 'اسم الفئة
                DGV.Rows(COUNT_).Cells(5).Value = DT.Rows(I)(3).ToString 'مبلغ الفئة

                COUNT_ += 1 ' بما أنه بدأ من السطر0 نزيده واحد في كل لوب
            Next
        End If
    End Sub
    Sub TOTAL_()
        Try
            Dim TOT_DGV As Decimal = 0D
            For i As Integer = 0 To DGV.Rows.Count - 1
                Dim AMOUNT As Decimal = Val(DGV.Rows(i).Cells(5).Value) ' مبلغ الفئة
                Dim CASH_ As Decimal = Val(DGV.Rows(i).Cells(6).Value) ' مجموع الجرد للسطر

                If DGV.Rows(i).Cells(5).Value <> Nothing And DGV.Rows(i).Cells(6).Value <> Nothing Then
                    DGV.Rows(i).Cells(7).Value = AMOUNT * CASH_
                    TOT_DGV = Val(TOT_DGV) + Val(DGV.Rows(i).Cells(7).Value)
                End If
                If TOT_DGV = 0 Then
                    TXT_COUNT.ReadOnly = False
                Else
                    TXT_COUNT.ReadOnly = True
                End If
            Next

            TXT_COUNT.Text = TOT_DGV.ToString("N" & CUR_DEC_M)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub TOTAL_2()
        Try
            TXT_SUM_SLAE_ = TXT_SALE_2_ + TXT_SALE_ 'مجموع المبيعات
            TXT_SUM_SALE.Text = TXT_SUM_SLAE_.ToString("N" & CUR_DEC_M)

            TXT_SUM_CASH_ = TXT_CASH_ + TXT_SALE_ 'مجموع النقد
            TXT_SUM_CASH.Text = TXT_SUM_CASH_.ToString("N" & CUR_DEC_M)

            TXT_NET_ = TXT_CASH_ + TXT_SALE_ - TXT_WD_ 'صافي النقد
            TXT_NET.Text = TXT_NET_.ToString("N" & CUR_DEC_M)

            TXT_DEFR_ = TXT_COUNT_ - TXT_NET_ 'الفرق
            TXT_DEFR.Text = TXT_DEFR_.ToString("N" & CUR_DEC_M)

            If TXT_COUNT.Text <> Nothing Then
                If TXT_DEFR.Text = 0 Then
                    TXT_DEFR.BackColor = Color.LawnGreen
                    LBL_RESULT.Text = "مطابق"
                ElseIf TXT_DEFR.Text > 0 Then
                    TXT_DEFR.BackColor = Color.BlueViolet
                    LBL_RESULT.Text = "زيادة"
                ElseIf TXT_DEFR.Text < 0 Then
                    TXT_DEFR.BackColor = Color.Red
                    LBL_RESULT.Text = "نقص"
                End If
            End If
            If TXT_COUNT.Text = Nothing Then
                TXT_DEFR.BackColor = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub DGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        TOTAL_() 'CellEndEdit
        TOTAL_2() 'CellEndEdit
        Dim J = DGV.CurrentCell.ColumnIndex
        Dim i = DGV.CurrentCell.RowIndex
        If DGV.Rows(i).Cells(6).Value = Nothing Then
            DGV.Rows(i).Cells(6).Value = 0
            DGV.Rows(i).Cells(7).Value = 0
        End If
    End Sub

    Sub ADD_CASH_1() ' اضافة الجزء العلوي
        SAVED = True '("yyyy-MM-dd HH:mm:ss")
        MAX_1() ' في سيكوال سيرفر عند الدخول لأكثر من مستخدم وفتح نفس السند يعطي قيمة جديدة لآخر حفظ
        SAVED = False
        Dim Guid_CASH_1 As String = Guid.NewGuid().ToString()
        If TXT_NOTE_.Text = Nothing Then
            TXT_NOTE_.Text = DTP1.Text + "  مستند رقم " + TXT_ID.Text
        End If
        CLS_CALCU_.ADD_CASH_1(Guid_CASH_1, Val(TXT_ID.Text), DTP1.Value.ToString("yyyy-MM-dd HH:mm:ss"), TXT_NOTE_.Text, TXT_CASH_,
        TXT_SALE_, TXT_SALE_2_, TXT_SUM_SLAE_, TXT_SUM_CASH_, TXT_WD_, TXT_NET_, TXT_COUNT_, TXT_DEFR_)
        TXT_GUID.Text = Guid_CASH_1
        If CASH_ROTATE_M = 1 Then
            CLS_CALCU_.Update_Cash_In(Val(TXT_COUNT.Text)) 'تدوير الجرد
        End If
    End Sub
    Sub ADD_CASH_2()
        For i As Integer = 0 To DGV.Rows.Count - 1
            Dim Guid_ As String = Guid.NewGuid().ToString()
            If DGV.Rows(i).Cells(7).Value <> Nothing Then
                CLS_CALCU_.ADD_CASH_2(Guid_, TXT_GUID.Text, DGV.Rows(i).Cells(3).Value.ToString, DGV.Rows(i).Cells(4).Value.ToString,
                 Val(DGV.Rows(i).Cells(5).Value), Val(DGV.Rows(i).Cells(6).Value), Val(DGV.Rows(i).Cells(7).Value))
            End If
        Next
    End Sub
    Sub UPDATE_CASH_()
        If TXT_NOTE_.Text = Nothing Then
            TXT_NOTE_.Text = DTP1.Text + "  مستند رقم" + TXT_ID.Text
        End If
        CLS_CALCU_.UPDATE_(DTP1.Value.ToString("yyyy-MM-dd HH:mm:ss"), TXT_NOTE_.Text, TXT_CASH_,
        TXT_SALE_, TXT_SALE_2_, TXT_SUM_SLAE_, TXT_SUM_CASH_, TXT_WD_, TXT_NET_, TXT_COUNT_, TXT_DEFR_, Trim(TXT_GUID.Text))
        If CASH_ROTATE_M = 1 Then
            CLS_CALCU_.Update_Cash_In(Val(TXT_COUNT.Text)) 'تدوير الجرد
        End If
    End Sub
    Sub UPDATE_CASH_2()
        Try
            If TXT_GUID.Text <> Nothing Then
                For i As Integer = 0 To DGV.Rows.Count - 1
                    If DGV.Rows(i).Cells(0).Value <> Nothing Then
                        CLS_CALCU_.UPDATE_2(Val(DGV.Rows(i).Cells(6).Value), Val(DGV.Rows(i).Cells(7).Value), DGV.Rows(i).Cells(1).Value.ToString)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub BTNSAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click 'إضافة
        Try
            If TXT_ID.Text = Nothing Then
                MessageBox.Show("لا يمكن الحفظ بدون رقم")
                Exit Sub
            End If
            If TXT_GUID.Text <> Nothing Then
                MessageBox.Show("المستند موجود من قبل")
                Exit Sub
            End If
            For Each tb As TextBox In Panel2.Controls.OfType(Of TextBox)()
                If tb.Name = "TXT_ID2" Or tb.Name = "TXT_NOTE_" Or tb.Name = "TXT_GUID" Then Continue For ' استثناء هذا التكست بوكس

                If String.IsNullOrWhiteSpace(tb.Text) Then
                    'MessageBox.Show("الرجاء تعبئة الحقل: " & tb.Name)
                    'tb.Focus()
                    tb.Text = "0"
                End If
            Next
            TXT_NOTE_.Focus()
            If TXT_GUID.Text = Nothing And TXT_NET.Text <> Nothing And Val(TXT_NET.Text) <> "0" Then
                If MessageBox.Show("سيتم حفظ جرد صندوق", "حفظ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    ADD_CASH_1()
                    ADD_CASH_2()
                    BTN_UPDATE.Enabled = True
                    BTN_POST.Enabled = True
                    MessageBox.Show("تم الحفظ بنجاح")
                End If
                Show_CASH_1()
                Show_CASH_2()
            Else
                MessageBox.Show("لا يوجد بيانات للحفظ")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub BTN_POST_Click(sender As Object, e As EventArgs) Handles BTN_POST.Click
        Try
            If TXT_GUID.Text <> Nothing Then
                If MessageBox.Show("سيتم إقفال التعديل", "إقفال", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    CLS_CALCU_.POST_(TXT_GUID.Text)
                    MessageBox.Show("تم إقفال التعديل بنجاح")
                End If
            Else
                MessageBox.Show("لا يوجد سند للتعديل")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click 'تعديل
        Try
            If TXT_ID.Text = Nothing Then
                MessageBox.Show("لا يمكن الحفظ بدون رقم")
                Exit Sub
            End If
            If TXT_GUID.Text <> Nothing And TXT_NET.Text <> Nothing And Val(TXT_NET.Text) <> "0" Then

                If MessageBox.Show("سيتم التعديل", "تعديل", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                    UPDATE_CASH_()
                    UPDATE_CASH_2()
                    MessageBox.Show("تم التعديل بنجاح")
                End If
            Else
                MessageBox.Show("لا يوجد بيانات للتعديل")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub MAX_1()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CALCU_.MAX_1()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MAX_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CALCU_.MAX_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MIN_()
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CALCU_.MIN_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub NEW_DAY()
        Try
            TXT_GUID.Clear()
            DTP1.Value = Today
            TXT_NOTE_.Clear()
            TXT_CASH.Text = "0"
            TXT_SALE.Text = "0"
            TXT_SALE_2.Text = "0"
            TXT_SUM_SALE.Text = "0"
            TXT_WD.Text = "0"
            TXT_NET.Text = "0"
            TXT_COUNT.Text = "0"
            TXT_DEFR.Text = "0"
            MAX_1() 'NEW_DAY
            DGV.Rows.Clear()
            COUNT_HEADER()
            SEARCH_LOAD()
            BTN_UPDATE.Enabled = False
            BTN_POST.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'DGV.Rows.Clear()
        'Dim index As Integer = DGV.Columns(3).Index
        'Dim column As DataGridViewColumn = DGV.Columns(3)
        'DGV.Columns.Remove(column)
        'DGV.Columns.Insert(index, column)
    End Sub
    Private Sub TXT_ID2_Validating(sender As Object, e As CancelEventArgs) Handles TXT_ID2.Validating
        Try
            TXT_ID.Text = TXT_ID2.Text
            If TXT_ID2.Text = Nothing Or TXT_ID2.Text = "0" Then
                NEW_DAY()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_ID_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID.TextChanged
        Try
            If TXT_ID.Text <> Nothing Then
                If SAVED = False Then
                    DGV.Rows.Clear()
                    Show_CASH_1()
                End If
            End If
            If TXT_GUID.Text <> Nothing Then ' اذا كانت الفاتورة يوجد فيها قيمة اعرض محتويات الفاتورة
                Show_CASH_2() 'TXT_ID.TextChanged
            End If
            'If TXT_ID.Text <> Nothing Then
            '    Show_()
            '    'TSMIstatus() ' اخفاء واظهار قوائم الحفظ والتعديل والحذف في السند
            'End If
            'Show_()
            TXT_ID2.Text = TXT_ID.Text
            COUNT_HEADER() ' ترقيم تلقائي للاسطر
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub Show_CASH_1() ' تعبئة الداتا جريد والمعلومات
        Try

            Dim COUNT_ As Integer = 0 'تعريف متغير للوب
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CALCU_.SHOW_CASH_1(Val(TXT_ID.Text))
            If DT.Rows.Count > 0 Then
                TXT_GUID.Text = DT.Rows(0)(0).ToString '
                DTP1.Value = DateTime.ParseExact(DT.Rows(0)(2).ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) '
                TXT_NOTE_.Text = DT.Rows(0)(3).ToString '
                TXT_CASH.Text = Val(DT.Rows(0)(4).ToString).ToString("N" & CUR_DEC_M) '
                TXT_SALE.Text = Val(DT.Rows(0)(5).ToString).ToString("N" & CUR_DEC_M) '
                TXT_SALE_2.Text = Val(DT.Rows(0)(6).ToString).ToString("N" & CUR_DEC_M) '
                TXT_SUM_SALE.Text = Val(DT.Rows(0)(7).ToString).ToString("N" & CUR_DEC_M) '
                TXT_SUM_CASH.Text = Val(DT.Rows(0)(8).ToString).ToString("N" & CUR_DEC_M) '
                TXT_WD.Text = Val(DT.Rows(0)(9).ToString).ToString("N" & CUR_DEC_M) '
                TXT_NET.Text = Val(DT.Rows(0)(10).ToString).ToString("N" & CUR_DEC_M) '
                TXT_COUNT.Text = Val(DT.Rows(0)(11).ToString).ToString("N" & CUR_DEC_M) '
                TXT_DEFR.Text = Val(DT.Rows(0)(12).ToString).ToString("N" & CUR_DEC_M) '
                If DT.Rows(0)(12).ToString = "1" Then
                    BTN_UPDATE.Enabled = False
                    BTN_POST.Enabled = False
                Else
                    BTN_UPDATE.Enabled = True
                    BTN_POST.Enabled = True
                End If
            Else
                NEW_DAY() 'Show_()
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Console.WriteLine(ex.ToString)
        End Try
        'Dim dateString As String = DT.Rows(0)(1).ToString()
        'Dim dtValue_1 As DateTime = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        'DTP1.Value = dtValue_1
    End Sub
    Sub Show_CASH_2() ' تعبئة الداتا جريد والمعلومات
        Try
            '            CASH_2.ID_ , CASH_2.GUID_, CASH_2.CATEGORY_GUID,
            'CASH_2.CATEGORY_NAME, CASH_2.CATEGORYAMOUNT, CASH_2.NUMBEROFCAT, CASH_2.SUM_ 
            Dim COUNT_ As Integer = 0 'تعريف متغير للوب
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CALCU_.SHOW_CASH_2(TXT_GUID.Text)
            If DT.Rows.Count > 0 Then
                DGV.RowCount = DT.Rows.Count + 1
                For I As Integer = 0 To DT.Rows.Count - 1 '
                    DGV.Rows(COUNT_).Cells(0).Value = DT.Rows(I)(0).ToString 'ID
                    DGV.Rows(COUNT_).Cells(1).Value = DT.Rows(I)(1).ToString 'GUID_
                    DGV.Rows(COUNT_).Cells(3).Value = DT.Rows(I)(2).ToString 'CATEGORY_GUID
                    DGV.Rows(COUNT_).Cells(4).Value = DT.Rows(I)(3).ToString 'اسم الفئة
                    DGV.Rows(COUNT_).Cells(5).Value = Val(DT.Rows(I)(4).ToString) 'مبلغ الفئة
                    DGV.Rows(COUNT_).Cells(6).Value = Val(DT.Rows(I)(5).ToString) 'عدد أوراق الجرد
                    DGV.Rows(COUNT_).Cells(7).Value = Val(DT.Rows(I)(6).ToString) 'مجموع الجرد
                    COUNT_ += 1 ' بما أنه بدأ من السطر0 نزيده واحد في كل لوب
                Next
            Else
                SEARCH_LOAD()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Console.WriteLine(ex.ToString)
        End Try
        'Dim dateString As String = DT.Rows(0)(1).ToString()
        'Dim dtValue_1 As DateTime = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
        'DTP1.Value = dtValue_1
    End Sub
    Private Sub BTN_MAX_Click(sender As Object, e As EventArgs) Handles BTN_MAX.Click ' آخر سند
        Try
            MAX_() ' عند الضغط على كبسة آخر سند يجلب آخر سند
            'TSMIstatus() ' اخفاء واظهار قوائم الحفظ والتعديل والحذف في السند
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub BTN_UP_Click(sender As Object, e As EventArgs) Handles BTN_UP.Click ' السند التالي
        Try
            Dim maxup As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CALCU_.MAX_()
            If DT.Rows.Count > 0 Then
                maxup = DT.Rows(0)(0).ToString()
            End If
            TXT_ID.Text = TXT_ID.Text + 1
            If Val(TXT_ID.Text) > Val(maxup) Then
                TXT_ID.Text = maxup
                MessageBox.Show("آخر سجل", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            COUNT_HEADER() ' ترقيم تلقائي للاسطر
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BTN_DOWN_Click(sender As Object, e As EventArgs) Handles BTN_DOWN.Click ' السند السابق
        Try
            Dim mindown As Double = 0
            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CALCU_.MIN_()
            If DT.Rows.Count > 0 Then
                mindown = DT.Rows(0)(0).ToString()
            End If
            TXT_ID.Text = TXT_ID.Text - 1
            If Val(TXT_ID.Text) < Val(mindown) And Val(TXT_ID.Text) <> 1 Then
                TXT_ID.Text = mindown
                MessageBox.Show("أول سند", "السندات", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            COUNT_HEADER() ' ترقيم تلقائي للاسطر
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BTN_MIN_Click(sender As Object, e As EventArgs) Handles BTN_MIN.Click ' أول سند
        Try
            MIN_() ' عند الضغط على كبسة أول سند يجلب أول سند
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        NEW_DAY() 'BTN_NEW
    End Sub
    Sub Closeform()
        Try ' صب اغلاق النموذج

            Dim close_ As String = MsgBox("هل تريد اغلاق البطاقة ???", vbYesNo, "خروج")
            If close_ = vbYes Then
                Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub FRM_CALCU_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Closeform()
        End If
        If e.KeyCode = Keys.F2 Then 'كبسة جديد
            BTN_NEW.PerformClick()
        End If
        If e.KeyCode = Keys.F5 Then 'كبسة اضافة
            BTN_SAVE.PerformClick()
        End If
        If e.KeyCode = Keys.F6 Then 'كبسة تعديل
            BTN_UPDATE.PerformClick()
        End If

        If e.KeyData = Keys.Enter Then 'ربط انتر مع تاب
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim I As Integer = e.RowIndex
        Dim J As Integer = e.ColumnIndex
        'If DGV3.Rows(e.RowIndex).Cells(0).Value <> Nothing Then
        If DGV.Rows(I).Cells(4).Value <> Nothing Then
            If IsNumeric(DGV.Rows(I).Cells(J).Value) Then
                If J = 5 Or J = 7 Then '& e.RowIndex = DGV.NewRowIndex 
                    'Dim val_ As Decimal = Decimal.Parse(e.Value.ToString)
                    e.Value = Convert.ToDouble(e.Value).ToString("N" & CUR_DEC_M) 'CUR_DEC_
                End If
                If J = 6 Then '& e.RowIndex = DGV.NewRowIndex 
                    'Dim val_ As Decimal = Decimal.Parse(e.Value.ToString)
                    e.Value = Convert.ToDouble(e.Value).ToString("N0") 'CUR_DEC_
                End If
            End If

        End If
    End Sub

    ' عند الدخول إلى TextBox (إزالة التنسيق لتسهيل الكتابة)
    Private Sub TXT_CASH_Enter(sender As Object, e As EventArgs) Handles TXT_CASH.Enter, TXT_SALE.Enter, TXT_SALE_2.Enter,
            TXT_SALE_2.Enter, TXT_WD.Enter, TXT_COUNT.Enter
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim value As Decimal
        If Decimal.TryParse(tb.Text, value) Then
            tb.Text = value.ToString("0.##") ' إظهار الرقم بدون فواصل
        End If
    End Sub
    ' عند الخروج من TextBox (إعادة تنسيقه)
    Private Sub TXT_CASH_Leave(sender As Object, e As EventArgs) Handles TXT_CASH.Leave, TXT_SALE.Leave, TXT_SALE_2.Leave,
            TXT_SALE_2.Leave, TXT_WD.Leave, TXT_COUNT.Leave
        TOTAL_() 'Leave
        TOTAL_2() 'Leave
        Dim tb As TextBox = DirectCast(sender, TextBox)
        Dim value As Decimal
        If Decimal.TryParse(tb.Text, value) Then
            tb.Text = value.ToString("N" & CUR_DEC_M) ' تنسيق مع فاصل عشري حسب النظام (مثلاً 1,234.56)
        Else
            tb.Text = "0.00"
        End If
    End Sub

    Private Sub TXT_CASH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CASH.KeyPress, TXT_SALE.KeyPress, TXT_SALE_2.KeyPress,
            TXT_SALE_2.KeyPress, TXT_WD.KeyPress, TXT_COUNT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso (e.KeyChar <> ChrW(46)) Then
            e.Handled = True 'منع الاحرف
        End If
        If (e.KeyChar = ".") AndAlso (sender.Text.IndexOf(".") > -1) Then 'منع أكثر من نقطة
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_CASH_TextChanged(sender As Object, e As EventArgs) Handles TXT_CASH.TextChanged
        If TXT_CASH.Text <> Nothing Then
            TXT_CASH_ = TXT_CASH.Text
        Else
            TXT_CASH_ = 0
        End If

    End Sub

    Private Sub TXT_SALE_TextChanged(sender As Object, e As EventArgs) Handles TXT_SALE.TextChanged
        If TXT_SALE.Text <> Nothing Then
            TXT_SALE_ = TXT_SALE.Text
        Else
            TXT_SALE_ = 0
        End If
    End Sub

    Private Sub TXT_SALE_2_TextChanged(sender As Object, e As EventArgs) Handles TXT_SALE_2.TextChanged
        If TXT_SALE_2.Text <> Nothing Then
            TXT_SALE_2_ = TXT_SALE_2.Text
        Else
            TXT_SALE_2_ = 0
        End If
    End Sub

    Private Sub TXT_WD_TextChanged(sender As Object, e As EventArgs) Handles TXT_WD.TextChanged
        If TXT_WD.Text <> Nothing Then
            TXT_WD_ = TXT_WD.Text
        Else
            TXT_WD_ = 0
        End If
    End Sub

    Private Sub TXT_COUNT_TextChanged(sender As Object, e As EventArgs) Handles TXT_COUNT.TextChanged
        If TXT_COUNT.Text <> Nothing Then
            TXT_COUNT_ = TXT_COUNT.Text
        Else
            TXT_COUNT_ = 0
        End If
    End Sub

    Private Sub Handel_Column_KeyPress(sender As System.Windows.Forms.DataGridViewTextBoxEditingControl, e As KeyPressEventArgs)
        'منع ادخال الحروف في خانات الارقام في الجردفيو
        Try
            Dim J = DGV.CurrentCell.ColumnIndex
            Dim i = DGV.CurrentCell.RowIndex

            If J = 6 Then ' يسمح في خانة المدين والدائن والعملة الارقام والفاصلة العشرية فقط
                Dim valid_entry = "0123456789" + ChrW(Keys.Back)
                If valid_entry.Contains(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub DGV_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGV.EditingControlShowing
        'منع ادخال الحروف في خانة الارقام في الجردفيو
        Dim J = DGV.CurrentCell.ColumnIndex
        If J = 6 Then
            AddHandler e.Control.KeyPress, AddressOf Handel_Column_KeyPress
        End If
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub TXT_ID2_TextChanged(sender As Object, e As EventArgs) Handles TXT_ID2.TextChanged

    End Sub


    'Try
    '    For i As Integer = 0 To DGV.Rows.Count - 1
    '        Dim CON As New CLS_CON
    '        If DGV.Rows(i).Cells(0).Value <> Nothing Then
    '            CON.EXECUTE_TXT("UPDATE CATEGORY SET NAMEE = '" & DGV.Rows(i).Cells(1).Value.ToString & "' , AMOUNT = " & DGV.Rows(i).Cells(2).Value.ToString & " WHERE ID_ = " & DGV.Rows(i).Cells(0).Value.ToString & " ")
    '        ElseIf DGV.Rows(i).Cells(0).Value = Nothing And DGV.Rows(i).Cells(1).Value <> Nothing And DGV.Rows(i).Cells(2).Value <> Nothing Then
    '            CON.EXECUTE_TXT("INSERT INTO CATEGORY (NAMEE , AMOUNT)VALUES('" & DGV.Rows(i).Cells(1).Value.ToString & "'," & DGV.Rows(i).Cells(2).Value.ToString & ")")
    '        Else
    '            Exit For
    '        End If
    '    Next
    '    CHB_MOD.Checked = False
    '    SEARCH_()
    '    MessageBox.Show("تم حفظ البيانات الأساسية")
    'Catch ex As Exception
    '    MessageBox.Show(ex.ToString)
    'End Try
    'TXT_CASH.Text = TXT_COUNT.Text
    'TXT_SALE.Text = Nothing
    'TXT_WD.Text = Nothing
    'TXT_COUNT.Text = Nothing

    'Dim CON As New CLS_CON
    'CON.OPEN_SQLCON()
    'If False Then
    'CON.EXECUTE_TXT("CREATE TABLE IF NOT EXISTS CATEGORY (ID_ INTEGER PRIMARY KEY AUTOINCREMENT, NAMEE TEXT, AMOUNT REAL)")
    'CON.EXECUTE_TXT("CREATE TABLE IF NOT EXISTS CASH (ID_ INTEGER PRIMARY KEY AUTOINCREMENT,GUID_ TEXT, CASH REAL, NOTE_ TEXT, DATE_ TEXT, SALE REAL, SALE_2 REAL, WD REAL, COUNT REAL)")
    'CON.EXECUTE_TXT("CREATE TABLE IF NOT EXISTS CASH_2 (ID_ INTEGER PRIMARY KEY AUTOINCREMENT,GUID_ TEXT, ID_CASH INTEGER, AMOUNT REAL, CASH1 REAL, TOTAL1 REAL, CASH2 REAL, TOTAL2 REAL)")
    'End If
    'If CON.SQLCON.State = 1 Then
    '    MessageBox.Show("تم الاتصال بقاعدة البيانات")
    '    MessageBox.Show(CON.SQLCON.DataSource)
    'Else
    '    MessageBox.Show("فشل الاتصال بقاعدة البيانات")
    'End If
End Class
