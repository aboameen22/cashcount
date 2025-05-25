
Imports System.Data.SQLite

Public Class CLS_CON
    Public SQLCON As New SQLiteConnection

    Public Sub New()
        SQLCON = New SQLiteConnection("Data Source=" & Application.StartupPath & "\CASHCOUNT_DB.db")
    End Sub
    Public Sub OPEN_SQLCON()
        If SQLCON.State = ConnectionState.Closed Then
            SQLCON.Open()
        End If
    End Sub
    'اغلاق الاتصال
    Public Sub CLOSE_SQLCON()
        If SQLCON.State = ConnectionState.Open Then
            SQLCON.Close()
        End If
    End Sub
    Function SELECT_TXT(TXT_ As String) As DataTable
        Dim DT As New DataTable
        DT.Clear()
        Dim ADP As New SQLiteDataAdapter(TXT_, SQLCON)
        ADP.Fill(DT) 'تعبئة السيليكت في الداتا تيبل
        Return DT 'لاستخدامه مرة اخرى
    End Function
    Public Sub EXECUTE_TXT(TXT_ As String)
        Dim CMD As New SQLiteCommand 'اضافة الكومند
        CMD.CommandType = CommandType.Text 'تحديد نوع الكومند
        CMD.Connection = SQLCON 'تحديد الكونكشن الخاص بالكومند
        OPEN_SQLCON() 'فتح الاتنصال
        CMD = New SQLiteCommand(TXT_, SQLCON)
        CMD.ExecuteNonQuery() ' تنفيذ الكومند
        CLOSE_SQLCON() ' اغلاق الاتصال
    End Sub
    ' تنفيذ استعلام SELECT مع باراميترات
    Public Function SELECT_TXT_WITH_PARAMS(query As String, params As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable
        OPEN_SQLCON()
        Using cmd As New SQLiteCommand(query, SQLCON)
            For Each param In params
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next
            Using adapter As New SQLiteDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using
        CLOSE_SQLCON()
        Return dt
    End Function

    ' تنفيذ استعلام INSERT/UPDATE/DELETE مع باراميترات
    Public Sub EXECUTE_TXT_WITH_PARAMS(query As String, params As Dictionary(Of String, Object))
        OPEN_SQLCON()
        Using cmd As New SQLiteCommand(query, SQLCON)
            For Each param In params
                cmd.Parameters.AddWithValue(param.Key, param.Value)
            Next
            cmd.ExecuteNonQuery()
        End Using
        CLOSE_SQLCON()
    End Sub
End Class
