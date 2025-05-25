Imports DocumentFormat.OpenXml.Wordprocessing

Public Class FRM_REP_CALCU
    ReadOnly CLS_CALCU_ As New CLS_CALCU
    Public Function SHOW_CASH_1_REP(DATE_1 As String, DATE_2 As String) As DataTable 'جلب معلومات رأس السند
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT  NUMBER_ , DATE_ , NOTE_ , CASH_ ,
SALES_1 , SALES_2 , SUM_SALE , SUM_CASH_ , WITHDRAWE_ , NET_CASH , COUNT_ , DIFFERENCE_ 
FROM CASH_1 WHERE DATE_ BETWEEN '" & DATE_1 & "' AND '" & DATE_2 & "' ")
        Return DT
    End Function
    Private Sub BTN_SHOW__Click(sender As Object, e As EventArgs) Handles BTN_SHOW_.Click
        SHOW_REP()
    End Sub
    Sub SHOW_REP()
        Try
            Dim F As New FRM_SHOW_REP_CALCU
            Dim dt As New DataTable
            Dim con As New CLS_CON
            dt.Clear()
            dt = CLS_CALCU_.SHOW_CASH_1_REP(DTP1.Value.ToString("yyyy-MM-dd HH:mm:ss"), DTP2.Value.ToString("yyyy-MM-dd HH:mm:ss"))
            If dt.Rows.Count > 0 Then
                F.DGV.DataSource = dt
                F.Show()
            Else
                MessageBox.Show("لا توجد بيانات حسب التاريخ المدخل", "تقرير", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FRM_REP_CALCU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim D_ As Date = DTP1.Value
        DTP1.Value = New DateTime(D_.Year, 1, 1, 0, 0, 0) 'وضع التاريخ حسب أول يوم في السنة
    End Sub
End Class