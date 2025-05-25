Imports System.Data.SqlClient
Public Class CLS_CALCU
    Function ALL_() As DataTable 'فنكشن بحث كامل الحسابات عن طريق لايك للبحث عن بواسطة الاسم
        Dim DT As New DataTable
        Dim CON As New CLS_CON
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT * FROM CATEGORY ")
        Return DT
    End Function
    Public Function MAX_1() As DataTable ' جلب اخر رقم
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT IFNULL(MAX(NUMBER_)+1,1) FROM CASH_1 ")
        Return DT
    End Function
    Public Function MAX_() As DataTable ' جلب اخر رقم
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT IFNULL(MAX(NUMBER_),1) FROM CASH_1 ")
        Return DT
    End Function
    Public Function MIN_() As DataTable ' جلب اول رقم
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT IFNULL(MIN(NUMBER_),1) FROM CASH_1 ")
        Return DT
    End Function
    'Public Function GUID_(PARENT_GUID As String, NUMBER As Integer) As DataTable ' جلب الجابد الخاص ل بل 1 وربطه مع بل 2 عن طريق بارنت جايد
    '    Dim CON As New CLS_CON
    '    Dim DT As New DataTable
    '    DT.Clear()
    '    DT = CON.SELECT_TXT("SELECT GUID_ FROM BILL1 WHERE (PARENT_GUID ='" & PARENT_GUID & "') AND (NUMBER = " & NUMBER & ") ") ' عن طريق رقم ونوع الفاتورة
    '    Return DT
    'End Function

    Sub ADD_CASH_1(Guid_ As String, NUMBER As Integer, DATE_ As String, NOTE_ As String, CASH_ As Decimal, SALES1 As Decimal,
                   SALES2 As Decimal, SUM_SALE_ As Decimal, SUM_CASH As Decimal,
                   WITHDRAWE_ As Decimal, NET_CASH_ As Decimal, COUNT_ As Decimal, DIFFERENCE_ As Decimal)  'اضافة الراس
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("INSERT INTO CASH_1(GUID_ , NUMBER_ , DATE_ , NOTE_ , CASH_  ,SALES_1 ,
SALES_2 , SUM_SALE , SUM_CASH_ , WITHDRAWE_ , NET_CASH , COUNT_ , DIFFERENCE_ , POST_)
        VALUES('" & Guid_ & "'," & NUMBER & " , '" & DATE_ & "' , '" & NOTE_ & "' , " & CASH_ & " , " & SALES1 & ",
        " & SALES2 & " , " & SUM_SALE_ & " , " & SUM_CASH & " , " & WITHDRAWE_ & " , " & NET_CASH_ & " , " & COUNT_ & " , " & DIFFERENCE_ & ",'0')")
    End Sub
    Sub ADD_CASH_2(Guid_ As String, PARENT_GUID As String, CATEGORY_GUID As String, CATEGORY_NAME As String,
                   CATEGORY_AMOUNT As Decimal, NUMBEROFCAT As Decimal, SUM_ As Decimal) ' اضافة معلومات الجريد
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("INSERT INTO CASH_2(GUID_ , PARENT_GUID , CATEGORY_GUID , CATEGORY_NAME ,
CATEGORYAMOUNT , NUMBEROFCAT , SUM_)
        VALUES('" & Guid_ & "' ,'" & PARENT_GUID & "' , '" & CATEGORY_GUID & "' , '" & CATEGORY_NAME & "' ,
        " & CATEGORY_AMOUNT & " , " & NUMBEROFCAT & " , " & SUM_ & ")")
    End Sub
    Sub Update_Cash_In(CASH_IN_ As Decimal) 'تدوير الجرد
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE SETTING_CONFIG SET  CASH_IN = " & CASH_IN_ & "  ")
    End Sub
    Sub UPDATE_(DATE_ As String, NOTE_ As String, CASH_ As Decimal, SALES_1 As Decimal, SALES_2 As Decimal,
                SUM_SALE_ As Decimal, SUM_CASH As Decimal, WITHDRAWE_ As Decimal, NET_CASH_ As Decimal, COUNT_ As Decimal, DIFFERENCE_ As Decimal, GUID_ As String) ' تعديل 
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE CASH_1 SET  DATE_= '" & DATE_ & "' , NOTE_='" & NOTE_ & "' ,
CASH_=" & CASH_ & " , SALES_1=" & SALES_1 & " , SALES_2=" & SALES_2 & " , SUM_SALE=" & SUM_SALE_ & ", SUM_CASH_=" & SUM_CASH & ",
WITHDRAWE_=" & WITHDRAWE_ & " , NET_CASH=" & NET_CASH_ & " , COUNT_=" & COUNT_ & " , DIFFERENCE_=" & DIFFERENCE_ & "
WHERE GUID_ = '" & GUID_ & "' ")
    End Sub
    Sub POST_(Guid_ As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE CASH_1 SET POST_ = '1' WHERE GUID_ = '" & Guid_ & "'  ")
    End Sub
    Public Sub UPDATE_2(NUMBEROFCAT_ As Decimal, SUM_ As Decimal, GUID_ As String) 'تعديل الباركود البديل للمادة
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE CASH_2 SET  NUMBEROFCAT= " & NUMBEROFCAT_ & " , SUM_ = " & SUM_ & "
WHERE GUID_ = '" & GUID_ & "' ")
    End Sub



    'Public Sub UPDATE_ITEMBARC(BARCODE2 As String, NAME_2 As String, ID As Integer, PARENT_ As String)
    '    Dim CON As New CLS_CON
    '    CON.EXECUTE_TXT("UPDATE ITEME_BARC Set BARCODE_2 ='" & BARCODE2 & "', NAME_2='" & NAME_2 & "' WHERE (ID =" & ID & ") AND (PARENT_GUID='" & PARENT_ & "')")
    'End Sub
    '    Public Function SHOW_(NUMBER_ As Integer) As DataTable 'جلب معلومات رأس السند
    '        Dim CON As New CLS_CON
    '        Dim DT As New DataTable
    '        DT.Clear()
    '        DT = CON.SELECT_TXT("SELECT dbo.CASH_2.ID_,dbo.CASH_2.CATEGORY_, dbo.CASH_2.CASH_1, dbo.CASH_2.SUM_1, dbo.CASH_2.CASH_2,dbo.CASH_2.SUM_2,
    'dbo.CASH_1.NUMBER_,dbo.CASH_1.CASH_, dbo.CASH_1.NOTE__, dbo.CASH_1.DATE_, dbo.CASH_1.SALES_1, dbo.CASH_1.SALES_2, dbo.CASH_1.WITHDRAWE_, dbo.CASH_1.COUNT_
    'FROM dbo.CASH_1 INNER JOIN
    'dbo.CASH_2 ON dbo.CASH_1.NUMBER_ = dbo.CASH_2.PARENT_GUID  WHERE dbo.CASH_1.NUMBER_ = " & NUMBER_ & "")
    '        Return DT
    '    End Function
    Public Function SHOW_CASH_1(NUMBER_ As Integer) As DataTable 'جلب معلومات رأس السند
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID_ , NUMBER_ , DATE_ , NOTE_ , CASH_ ,
SALES_1 , SALES_2 , SUM_SALE ,SUM_CASH_, WITHDRAWE_ , NET_CASH , COUNT_ , DIFFERENCE_ , POST_
FROM CASH_1 WHERE CASH_1.NUMBER_ = " & NUMBER_ & "")
        Return DT
    End Function
    'ORDER BY 
    'DATE_ DESC,
    'NUMBER_ DESC;
    Public Function SHOW_CASH_2(PARGUID_ As String) As DataTable
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT 
    CASH_2.ID_ ,CASH_2.GUID_ ,CASH_2.CATEGORY_GUID ,
CASH_2.CATEGORY_NAME ,CASH_2.CATEGORYAMOUNT ,CASH_2.NUMBEROFCAT ,CASH_2.SUM_ 
FROM CASH_2 WHERE CASH_2.PARENT_GUID = '" & PARGUID_ & "' ")
        Return DT
    End Function
    Public Function SHOW_CASH_1_REP(DATE_1 As String, DATE_2 As String) As DataTable 'جلب معلومات رأس السند
        '        Dim CON As New CLS_CON
        '        Dim DT As New DataTable
        '        DT.Clear()
        '        DT = CON.SELECT_TXT("SELECT  NUMBER_ , DATE_ , NOTE_ , CASH_ ,
        'SALES_1 , SALES_2 , SUM_SALE , SUM_CASH_ , WITHDRAWE_ , NET_CASH , COUNT_ , DIFFERENCE_ 
        'FROM CASH_1 WHERE DATE_ BETWEEN '" & DATE_1 & "' AND '" & DATE_2 & "' ")
        '        Return DT
        'Dim CON As New CLS_CON
        'Dim params As New Dictionary(Of String, Object) From {
        '    {"@date1", DATE_1.ToString("yyyy-MM-dd HH:mm:ss")},
        '    {"@date2", DATE_2.ToString("yyyy-MM-dd HH:mm:ss")}
        '}
        'Dim sql As String = "SELECT NUMBER_, DATE_, NOTE_, CASH_, SALES_1, SALES_2, SUM_SALE, SUM_CASH_, WITHDRAWE_, NET_CASH, COUNT_, DIFFERENCE_ 
        '                 FROM CASH_1 WHERE DATE_ BETWEEN @date1 AND @date2"
        'Return CON.SELECT_TXT_WITH_PARAMS(sql, params)

        Dim CON As New CLS_CON
        Dim params As New Dictionary(Of String, Object) From {
            {"@date1", DATE_1},
            {"@date2", DATE_2}
        }
        Dim sql As String = "SELECT NUMBER_, DATE_, NOTE_, CASH_, SALES_1, SALES_2, SUM_SALE, SUM_CASH_, WITHDRAWE_, NET_CASH, COUNT_, DIFFERENCE_ 
                         FROM CASH_1 WHERE DATE_ BETWEEN @date1 AND @date2"
        Return CON.SELECT_TXT_WITH_PARAMS(sql, params)
    End Function
End Class
