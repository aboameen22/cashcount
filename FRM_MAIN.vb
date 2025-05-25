Public Class FRM_MAIN
    ReadOnly CLS_SETTINGS_ As New CLS_SETTINGS
    Private Sub FRM_MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SHOW_SETTING()
    End Sub
    Private Sub Btn_FRM_CALCU_Click(sender As Object, e As EventArgs) Handles Btn_FRM_CALCU.Click
        Try
            Dim F As New FRM_CALCU
            F.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_FRM_CATEGORY_Click(sender As Object, e As EventArgs) Handles Btn_FRM_CATEGORY.Click
        Try
            Dim F As New FRM_CATEGORY
            F.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Setting_Click(sender As Object, e As EventArgs) Handles Btn_Setting.Click
        Try
            Dim F As New FRM_SETTING
            F.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Try
            Dim result As DialogResult = MessageBox.Show("هل تريد الخروج من البرنامج", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SHOW_SETTING()
        Dim DT As New DataTable
        DT = CLS_SETTINGS_.SHOW_SETTING_()
        If DT.Rows.Count > 0 Then
            CUR_DEC_M = Val(DT.Rows(0).Item("CUR_DEC_").ToString)
            CASH_IN_M = Val(DT.Rows(0).Item("CASH_IN").ToString)
            CASH_ROTATE_M = Val(DT.Rows(0).Item("CASH_ROTATE").ToString)
        End If
    End Sub

    Private Sub BTN_REP_CALCU_Click(sender As Object, e As EventArgs) Handles BTN_REP_CALCU.Click
        Try
            Dim F As New FRM_REP_CALCU
            F.Show()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class