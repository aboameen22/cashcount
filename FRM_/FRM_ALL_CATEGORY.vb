Public Class FRM_ALL_CATEGORY
    ReadOnly CLS_CAT_ As New CLS_CATEGORY
    Public IS_YES As Boolean = False
    Private Sub FRM_ALL_CATEGORY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SEARSH_() ' اظهار باللود
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Sub SEARSH_() ' البحث
        Dim DT As New DataTable
        DT.Clear()
        DT = CLS_CAT_.SELECT_CATEGORY(TXT_SEARSH_.Text)
        DGV.DataSource = DT
        DGV.RowHeadersWidth = 50
        'DGV.Columns(0).HeaderText = " الرقم "
        'DGV.Columns(0).FillWeight = 35
        DGV.Columns(2).HeaderText = " الاسم "
        DGV.Columns(2).FillWeight = 125

        DGV.Columns(3).HeaderText = " المبلغ "
        DGV.Columns(3).FillWeight = 75

        DGV.Columns(4).HeaderText = " ملاحظات "
        DGV.Columns(4).FillWeight = 35

        DGV.Columns(0).Visible = False
        DGV.Columns(1).Visible = False
        CLS_PUBLIC_.COUNT_HEADER(DGV) ' ترقيم تلقائي للاسطر)
        If DT.Rows.Count > 300 Then
            TXT_SEARSH_.Enabled = False
        End If
    End Sub

    Private Sub TXT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXT_SEARSH_.TextChanged
        Try
            SEARSH_()  ' للبحث  في تكست البحث
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DGV_SALM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Try ' لكتابة الاسم عند الضغط عليها في شاشة البحث
            IS_YES = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub FRM_ALL_GROUP_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Close()
            End If
            'في هذا الفورم لا تربط الإنتر مع التاب لانه تم تخصيص كبسة الإنتر لنقل رقم المادة للفاتورة
            If e.KeyCode = Keys.Enter Then 'نقل رقم المادة للفاتورة
                e.Handled = True
                IS_YES = True
                Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class