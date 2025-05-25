Imports System.ComponentModel

Public Class FRM_CATEGORY
    ReadOnly CLS_CATEGORY_ As New CLS_CATEGORY
    Dim MAX_SAVE_ As Integer = 0 'خاص بجلب آخر اي دي لللإضافة
    Private Sub FRM_CATEGORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MAX_1()  ' في اللود يعطي سجل جديد
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub
    Sub MAX_1() 'جلب آخر رقم من الجدول
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CATEGORY_.MAX_1()
        'If DT.Rows.Count > 0 Then
        TXT_ID.Text = DT.Rows(0)(0).ToString()
        'End If
    End Sub
    Sub MAX_SAVE() ' خاص بإعطاء جايد في تكست الجايد
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CATEGORY_.MAX_2(TXT_ID.Text)
        If DT.Rows.Count > 0 Then
            MAX_SAVE_ = DT.Rows(0)(0).ToString()
            TXT_GUID.Text = "CAT_" & DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub ID_COUNT() 'إذا كان الجدول فارغ يعدل أول جايد حسب أول أي دي
        Dim CON As New CLS_CON
        Dim DT, DT2 As New DataTable
        DT.Clear()
        DT2.Clear()
        DT2 = CLS_CATEGORY_.SEARCH_ID
        If DT2.Rows.Count < 2 Then
            CLS_CATEGORY_.UPDATE_2("CAT_" & DT2.Rows(0)(0).ToString())
        Else
        End If
    End Sub

    Sub MAX_() 'نعمل صب لامكانية استخدامه في مكان آخر
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CATEGORY_.MAX_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Sub MIN_() 'نعمل صب لامكانية استخدامه في مكان آخر
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CATEGORY_.MIN_()
        If DT.Rows.Count > 0 Then
            TXT_ID.Text = DT.Rows(0)(0).ToString()
        End If
    End Sub
    Private Sub BTN_MAX_Click(sender As Object, e As EventArgs) Handles BTN_MAX.Click ' اخر سجل
        MAX_() ' عند الضغط على كبسة آخر سند يجلب آخر سند
        Show_() ' اخر سجل
    End Sub
    Private Sub BTN_MIN_Click(sender As Object, e As EventArgs) Handles BTN_MIN.Click ' أول سجل
        MIN_() ' عند الضغط على كبسة أول سند يجلب أول سند
        Show_() ' أول سجل
    End Sub
    Private Sub BTN_UP_Click(sender As Object, e As EventArgs) Handles BTN_UP.Click 'السجل التالي
        Try
            Dim CON As New CLS_CON
            Dim DT As New DataTable
            DT.Clear()
            DT = CON.SELECT_TXT("SELECT ID_ FROM CATEGORY WHERE ID_ = (SELECT MIN(ID_) FROM CATEGORY WHERE ID_ > " & TXT_ID.Text & " AND NAME_CAT <> '" & DBNull.Value & "')")
            If DT.Rows.Count > 0 Then
                TXT_ID.Text = DT.Rows(0)(0).ToString()
                Show_() 'السجل التالي
            Else
                MessageBox.Show("آخر سجل", "المجموعات", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BTN_DOWN_Click(sender As Object, e As EventArgs) Handles BTN_DOWN.Click 'السجل السابق
        Try
            Dim CON As New CLS_CON
            Dim DT As New DataTable
            DT.Clear()
            DT = CON.SELECT_TXT("SELECT ID_ FROM CATEGORY WHERE ID_ = (SELECT MAX(ID_) FROM CATEGORY WHERE ID_ < " & TXT_ID.Text & " AND NAME_CAT <> '" & DBNull.Value & "')")
            If DT.Rows.Count > 0 Then
                TXT_ID.Text = DT.Rows(0)(0).ToString()
                Show_() 'السجل السابق
            Else
                MessageBox.Show("أول سجل", "المجموعات", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub NEW_DAY()
        TXT_NAME.Clear()
        TXT_AMOUNT.Clear()
        TXT_NOTE_.Clear()
        TXT_GUID.Clear()
        CHB_SERH.Checked = False
        TXT_NAME.Focus()
        MAX_1()
    End Sub
    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        If TXT_NAME.Text <> Nothing Or TXT_NOTE_.Text <> Nothing Then
            If TXT_GUID.Text = Nothing Then
                Dim close_1 As String = MsgBox(" يوجد قيم لم تحفظ هل تريد جديد???", vbYesNo, "جديد")
                If close_1 = vbNo Then
                    Exit Sub
                Else
                    NEW_DAY()
                    Exit Sub
                End If
            End If
        End If
        NEW_DAY()
    End Sub
    Sub Show_() '  التنقل بين السجلات و تعبئة بقيمة التيكست اي دي
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CATEGORY_.Show_(Val(TXT_ID.Text))
        If DT.Rows.Count > 0 Then
            TXT_GUID.Text = DT.Rows(0)(1).ToString()
            TXT_NAME.Text = DT.Rows(0)(2).ToString
            TXT_AMOUNT.Text = DT.Rows(0)(3).ToString()
            TXT_NOTE_.Text = DT.Rows(0)(4).ToString()
        Else
            NEW_DAY()
            Exit Sub
        End If
    End Sub
    Private Sub TXT_ID_Validating(sender As Object, e As CancelEventArgs) Handles TXT_ID.Validating
        Show_() 'TXT_ID.Validating
        If TXT_ID.Text = Nothing Or TXT_ID.Text = "0" Then
            NEW_DAY()
        End If
    End Sub
    Private Sub TXT_NAME_Validating(sender As Object, e As CancelEventArgs) Handles TXT_NAME.Validating
        Try ' البحث عن طريق تكست الاسم وشيك بوكس
            Dim DT As New DataTable
            DT.Clear()
            'If TXT_GUID.Text = Nothing Then
            If CHB_SERH.Checked Then
                DT = CLS_CATEGORY_.SELECT_CATEGORY(Trim(TXT_NAME.Text))
                If DT.Rows.Count = 1 Then
                    TXT_ID.Text = DT.Rows(0)(0).ToString
                Else
                    Dim F As New FRM_ALL_CATEGORY
                    F.TXT_SEARSH_.Text = TXT_NAME.Text
                    F.ShowDialog()
                    If F.IS_YES = True Then
                        Dim I As Integer = F.DGV.CurrentRow.Index
                        TXT_ID.Text = F.DGV.Rows(I).Cells(0).Value.ToString
                        TXT_NOTE_.Focus()
                    Else
                        NEW_DAY()
                        Exit Sub
                    End If
                End If
                Show_()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub BTN_ADD_Click(sender As Object, e As EventArgs) Handles BTN_ADD.Click

        If TXT_NAME.Text = Nothing Then
            MessageBox.Show("يرجى ادخال الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If TXT_NAME.TextLength > 50 Then
            MessageBox.Show("أقصى عدد للحروف 50 حرف", "الاسم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim DT As New DataTable
        DT.Clear()

        DT = CLS_CATEGORY_.SEARCH_NAME(Trim(TXT_NAME.Text))
        If DT.Rows.Count > 0 Then
            MessageBox.Show("الاسم موجود من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'DT2 = CLS_CATEGORY_.SEARCH_ID(TXT_ID.Text)
        'If DT2.Rows.Count > 0 Then
        '    MessageBox.Show("الرقم موجودة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End If
        MAX_SAVE() 'يجلب آخر ماكس ويسند الماكس للجايد مع الحروف
        DT = CLS_CATEGORY_.SEARCH_GUID(TXT_GUID.Text)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("حصل خطأ يرجى المحاولة مرة أخرى", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NEW_DAY()
            Exit Sub
        End If
        Try
            CLS_CATEGORY_.Add_(MAX_SAVE_, TXT_GUID.Text, TXT_NAME.Text, TXT_AMOUNT.Text, TXT_NOTE_.Text)
            ID_COUNT() 'إذا كان الجدول فارغ يعدل أول جايد حسب أول أي دي
            MessageBox.Show("تمت عملية الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NEW_DAY()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Try
            If TXT_NAME.Text = Nothing Then
                MessageBox.Show("يرجى ادخال الاسم", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If TXT_NAME.TextLength > 50 Then
                MessageBox.Show("أقصى عدد للحروف 50 حرف", "اسم المجموعة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            Dim DT As New DataTable
            DT.Clear()
            DT = CLS_CATEGORY_.SEARCH_NAME(Trim(TXT_NAME.Text))
            If DT.Rows.Count > 0 Then
                If TXT_ID.Text <> DT.Rows(0)(0).ToString() Then
                    MessageBox.Show("الاسم موجودة من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            'SETTUPD()
            CLS_CATEGORY_.UPDATE_(TXT_NAME.Text, TXT_AMOUNT.Text, TXT_NOTE_.Text, TXT_GUID.Text)
            MessageBox.Show("تمت عملية التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'Sub SETTDELL() ' حذف الحساب في الأساسيات
    '    'If TXT_GUID.Text = TXT_CURNC_G Then
    '    '    My.Settings.TXT_CURNC_G = Nothing
    '    '    My.Settings.TXT_CURNC = Nothing
    '    '    My.Settings.TXT_CURNC_VAL = Nothing
    '    'End If
    'End Sub
    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Try
            If TXT_GUID.Text = Nothing Then
                MessageBox.Show(" لا يوجد سجل للحذف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Dim Dt, Dt2 As New DataTable
            'Dt.Clear()
            'Dt = CLS_CATEGORY_.GUID_SALESMAN_1(TXT_GUID.Text) ' البحث عن حركات في داي1
            'If Dt.Rows.Count > 0 Then
            '    MessageBox.Show(" يوجد عليه حركات ولا يمكن حذفه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            If MessageBox.Show(" سيتم حذف المجموعة???", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
                '  SETTDELL()
                'CLS_CATEGORY_.Delete_CUR(TXT_GUID.Text)
                CLS_CATEGORY_.UPDATE_("", "0", "", TXT_GUID.Text)
                MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TXT_GUID.Clear()
            End If
            NEW_DAY()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub ALL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress 'منع أدوات الرياضيات من الكتابة
        If e.KeyChar = "=" Or e.KeyChar = "+" Or e.KeyChar = "-" Or e.KeyChar = "*" Then
            e.Handled = True
        End If
    End Sub
    'Private Sub TXT_VAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_JOPNUM.KeyPress
    '    If Not VarChar.IsNumber(e.KeyChar) AndAlso Not VarChar.IsControl(e.KeyChar) AndAlso (e.KeyChar <> ChrW(46)) Then
    '        e.Handled = True
    '    End If ' منع كتابة الأحرف والسماح للنقطة
    'End Sub
    Sub Closeform()
        Try ' يبحث هل يوجد محتويات في السند تم ادخالها ولم تحفظ
            If TXT_NAME.Text <> Nothing Or TXT_NOTE_.Text <> Nothing Then
                If TXT_GUID.Text = Nothing Then
                    Dim close_1 As String = MsgBox(" يوجد قيم في السند هل تود الخروج???", vbYesNo, "خروج")
                    If close_1 = vbNo Then
                        Exit Sub
                    Else
                        Close()
                        Exit Sub
                    End If
                End If
            End If
            Dim close_ As String = MsgBox(" هل تريد الخروج ???", vbYesNo, "خروج")
            If close_ = vbYes Then
                Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub Buttonexit_Click(sender As Object, e As EventArgs) Handles Buttonexit.Click
        Closeform()
    End Sub

    Private Sub FRM_SALESMAN_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Closeform()
        End If
        If e.KeyCode = Keys.F2 Then 'كبسة جديد
            BTN_NEW.PerformClick()
        End If
        If e.KeyCode = Keys.F5 Then 'كبسة اضافة
            BTN_ADD.PerformClick()
        End If
        If e.KeyCode = Keys.F6 Then 'كبسة تعديل
            BTN_UPDATE.PerformClick()
        End If
        If e.KeyData = Keys.Enter Then 'ربط انتر مع تاب
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class