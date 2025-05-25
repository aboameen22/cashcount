Public Class CLS_SETTINGS
    Public Function SHOW_SETTING_() As DataTable 'جلب معلومات رأس السند
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT CUR_DEC_ , CASH_IN , CASH_ROTATE
FROM SETTING_CONFIG ")
        Return DT
    End Function
    Sub SETTING_CONFIG(CUR_DEC_ As String, CASH_IN_ As Decimal, CASH_ROTATE_ As Integer)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE SETTING_CONFIG SET CUR_DEC_ = '" & CUR_DEC_ & "' , CASH_IN = " & CASH_IN_ & " , CASH_ROTATE = " & CASH_ROTATE_ & " ")
    End Sub

End Class
