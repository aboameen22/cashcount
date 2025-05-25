Public Class CLS_PUBLIC_
    Public Shared Sub COUNT_HEADER(DGV) ' ترقيم تلقائي للاسطر
        If DGV IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (DGV.Rows.Count - 1))
                DGV.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
        DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
    End Sub
End Class
