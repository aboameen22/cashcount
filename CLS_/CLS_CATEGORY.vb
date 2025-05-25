Public Class CLS_CATEGORY
    Public Function MAX_1() As DataTable ' جلب اخر سجل
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT IFNULL(MAX(ID_)+1,1) FROM CATEGORY")
        'DT = CON.SELECT_TXT("SELECT COALESCE(MAX(ID_) + 1, 1) FROM CATEGORY")
        Return DT
    End Function
    Public Function MAX_2(ID) As DataTable ' جلب اخر سجل
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT IFNULL(MAX(ID_)+1," & ID & ") FROM CATEGORY")
        Return DT
    End Function
    Public Function MAX_() As DataTable ' جلب اخر سجل
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT IFNULL(MAX(ID_),1) FROM CATEGORY")
        Return DT
    End Function
    Public Function MIN_() As DataTable ' جلب اول سجل
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT IFNULL(MIN(ID_),1) FROM CATEGORY")
        Return DT
    End Function
    Public Function Show_(ID_ As Integer) As DataTable ' فنكشن التنقل بين السجلات لتعبئة الجريد
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID_ , GUID_ , NAME_CAT , AMOUNT_ , NOTE_ FROM CATEGORY WHERE ID_ = " & ID_ & "")
        Return DT
    End Function
    Public Function Show_LOAD() As DataTable ' فنكشن التنقل بين السجلات لتعبئة الجريد
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID_ , GUID_ , NAME_CAT , AMOUNT_ , NOTE_ FROM CATEGORY ")
        Return DT
    End Function
    Public Sub Add_(ID_ As Integer, GUID_ As String, NAME_CAT As String, AMOUNT_ As Double, NOTE_ As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("INSERT INTO CATEGORY (ID_ , GUID_ , NAME_CAT , AMOUNT_ , NOTE_ )VALUES
    (" & ID_ & ",'" & GUID_ & "','" & NAME_CAT & "'," & AMOUNT_ & ",'" & NOTE_ & "')")
    End Sub


    Public Sub UPDATE_(NAME_CAT As String, AMOUNT_ As Double, NOTE_ As String, GUID_ As String)
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE CATEGORY SET NAME_CAT='" & NAME_CAT & "', AMOUNT_=" & AMOUNT_ & " , NOTE_='" & NOTE_ & "'  WHERE GUID_ = '" & GUID_ & "'")
    End Sub
    Public Sub UPDATE_2(GUID_ As String) 'خاص بتعديل الجايد لو كان أول سجل
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("UPDATE CATEGORY SET GUID_='" & GUID_ & "' ")
    End Sub
    Public Function SEARCH_ID() 'بحث الاي دي
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID_ FROM CATEGORY ")
        Return DT
    End Function
    Public Function SEARCH_NAME(NAME_ As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID_ , GUID_ , NAME_CAT , AMOUNT_ , NOTE_ FROM CATEGORY WHERE NAME_CAT = '" & NAME_ & "'")
        Return DT
    End Function
    Public Function SEARCH_GUID(GUID_ As String)
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID_ , GUID_ , NAME_CAT, AMOUNT_ , NOTE_  FROM CATEGORY WHERE GUID_ = '" & GUID_ & "'")
        Return DT
    End Function
    Public Function SELECT_CATEGORY(SEARSH_ As String) ' شاشة البحث
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT ID_ , GUID_ , NAME_CAT ,  AMOUNT_ ,NOTE_ FROM CATEGORY WHERE NAME_CAT LIKE '%" & SEARSH_ & "%' AND NAME_CAT <> '" & DBNull.Value & "' ORDER BY ID_")
        Return DT
    End Function

    Public Function SELECT_CATEGORY2(SEARSH_ As String) ' شاشة البحث
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("SELECT GUID_ , NAME_CAT FROM CATEGORY WHERE NAME_CAT = '" & SEARSH_ & "'")
        Return DT
    End Function

    Public Sub Delete_CUR(GUID_ As String) ' صب مسح حساب
        Dim CON As New CLS_CON
        CON.EXECUTE_TXT("DELETE FROM CATEGORY WHERE GUID_ ='" & GUID_ & "' ")
    End Sub

    Public Function RESET_ID() As DataTable ' إعادة ترقيم آي دي
        Dim CON As New CLS_CON
        Dim DT As New DataTable
        DT.Clear()
        DT = CON.SELECT_TXT("DBCC CHECKIDENT(CATEGORY, RESEED,0)")
        Return DT
    End Function

End Class
