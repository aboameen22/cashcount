Imports System.ComponentModel

Public Class FRM_SETTING
    ReadOnly CLS_CALCU_ As New CLS_CALCU
    ReadOnly CLS_SETTINGS_ As New CLS_SETTINGS
    Private Sub FRM_SETTING_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SHOW_SETTING()
    End Sub
    Sub SHOW_SETTING()
        TXT_CUR_DEC.Text = CUR_DEC_M
        TXT_CASH_IN.Text = CASH_IN_M

        If CASH_ROTATE_M = 1 Then
            CBX_CASH_R.Checked = True
            CBX_CASH_F.Checked = False
        Else
            CBX_CASH_R.Checked = False
            CBX_CASH_F.Checked = True
        End If

    End Sub
    Private Sub BTN_SAVE_DEC_Click(sender As Object, e As EventArgs) Handles BTN_SAVE_DEC.Click
        Try
            If Trim(TXT_CASH_IN.Text) = Nothing Then
                TXT_CASH_IN.Text = 0
                TXT_CASH_IN.Focus()
            End If
            If Trim(TXT_CUR_DEC.Text) = Nothing Then
                TXT_CUR_DEC.Text = 0
                TXT_CUR_DEC.Focus()
            End If

            If TXT_CUR_DEC.Text <> Nothing Then
                Dim value As Integer
                If Not Integer.TryParse(TXT_CUR_DEC.Text, value) Then
                    MessageBox.Show("الرجاء إدخال رقم صحيح بدون كسور")
                    TXT_CUR_DEC.Focus()
                    Exit Sub
                End If
                If Val(TXT_CUR_DEC.Text) > 15 Then
                    MessageBox.Show("العدد تجاوز الحد المسموح")
                    TXT_CUR_DEC.Focus()
                    Exit Sub
                End If
                Dim CASH_ROTATE_ As Integer

                If CBX_CASH_R.Checked Then
                    CASH_ROTATE_ = 1 'تدوير الجرد
                Else
                    CASH_ROTATE_ = 0 ' عدم تدوير الجرد
                End If
                CLS_SETTINGS_.SETTING_CONFIG(Trim(TXT_CUR_DEC.Text), Val(TXT_CASH_IN.Text), CASH_ROTATE_)
                CUR_DEC_M = Val(TXT_CUR_DEC.Text)
                CASH_IN_M = Val(TXT_CASH_IN.Text)
                CASH_ROTATE_M = CASH_ROTATE_
                MessageBox.Show("تم الحفظ")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub TXT_CUR_DEC_Validating(sender As Object, e As CancelEventArgs) Handles TXT_CUR_DEC.Validating
        If TXT_CUR_DEC.Text <> Nothing Then
            Dim value As Integer
            If Not Integer.TryParse(TXT_CUR_DEC.Text, value) Then
                MessageBox.Show("الرجاء إدخال رقم صحيح بدون كسور")
                TXT_CUR_DEC.Focus()
                Exit Sub
            End If
            If Val(TXT_CUR_DEC.Text) > 15 Then
                MessageBox.Show("العدد تجاوز الحد المسموح")
                TXT_CUR_DEC.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub TXT_CUR_DEC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CUR_DEC.KeyPress
        ' اسمح فقط بالأرقام (0–9) وباستخدام backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True '
        End If
    End Sub

    Private Sub CBX_CASH_F_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_CASH_F.CheckedChanged
        If CBX_CASH_F.Checked Then
            CBX_CASH_R.Checked = False
        End If
    End Sub

    Private Sub CBX_CASH_R_CheckedChanged(sender As Object, e As EventArgs) Handles CBX_CASH_R.CheckedChanged
        If CBX_CASH_R.Checked Then
            CBX_CASH_F.Checked = False
        End If
    End Sub

    Private Sub TXT_CASH_IN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CASH_IN.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso (e.KeyChar <> ChrW(46)) Then
            e.Handled = True 'منع الاحرف
        End If
    End Sub
End Class