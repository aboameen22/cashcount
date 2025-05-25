Imports System.IO
Imports ClosedXML.Excel

Public Class FRM_SHOW_REP_CALCU
    ReadOnly CLS_CALCU_ As New CLS_CALCU
    Private Sub FRM_REP_CALCU_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV.CellFormatting
        Dim I As Integer = e.RowIndex
        Dim J As Integer = e.ColumnIndex
        If DGV.Rows(I).Cells(0).Value <> Nothing Then
            If IsNumeric(DGV.Rows(I).Cells(J).Value) Then
                If Not J = 0 Or J = 1 Or J = 2 Then '& e.RowIndex = DGV.NewRowIndex 
                    'Dim val_ As Decimal = Decimal.Parse(e.Value.ToString)
                    e.Value = Convert.ToDouble(e.Value).ToString("N" & CUR_DEC_M) 'CUR_DEC_
                End If
            End If
        End If
    End Sub

    Private Sub BTN_EXCEL_Click(sender As Object, e As EventArgs) Handles BTN_EXCEL.Click

        Try
            ' تأكد أن هناك بيانات
            If DGV.Rows.Count = 0 Then
                MessageBox.Show("لا توجد بيانات للتصدير.")
                Return
            End If

            ' إنشاء مصنف Excel
            Dim wb As New XLWorkbook()
            Dim ws = wb.Worksheets.Add("البيانات")

            ' إضافة رؤوس الأعمدة
            For col As Integer = 0 To DGV.Columns.Count - 1
                ws.Cell(1, col + 1).Value = DGV.Columns(col).HeaderText
                ws.Cell(1, col + 1).Style.Font.Bold = True
            Next

            ' إضافة الصفوف
            For row As Integer = 0 To DGV.Rows.Count - 1
                For col As Integer = 0 To DGV.Columns.Count - 1
                    ws.Cell(row + 2, col + 1).Value = DGV.Rows(row).Cells(col).Value?.ToString()
                Next
            Next

            ' تحديد المسار لحفظ الملف
            Dim Date_ = Now.ToString.Replace("/", " ")
            Date_ = Date_.Replace(":", " ")
            Dim saveDialog As New SaveFileDialog With {
                .Filter = "Excel Files|*.xlsx",
                .Title = "حفظ الملف",
                .FileName = Date_ & " " & "تقرير جرد الصندوق.xlsx"
            }

            If saveDialog.ShowDialog() = DialogResult.OK Then
                Try
                    wb.SaveAs(saveDialog.FileName)
                    'MessageBox.Show("تم تصدير البيانات بنجاح!", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If MessageBox.Show("هل تريد فتح الملف ؟", "فتح ملف الأكسل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) = MsgBoxResult.Yes Then
                        Process.Start(saveDialog.FileName)
                    End If
                Catch ex As Exception
                    MessageBox.Show("خطأ أثناء الحفظ: " & ex.Message)
                End Try
            End If
            'Dim sfd As New SaveFileDialog()
            'sfd.Filter = "Excel Workbook|*.xlsx"
            'sfd.Title = "تصدير إلى Excel"
            'If sfd.ShowDialog() = DialogResult.OK Then
            '    Using wb As New XLWorkbook()
            '        Dim ws = wb.Worksheets.Add(dt, "البيانات")

            '        ' جعل الورقة من اليمين لليسار
            '        ws.RightToLeft = True

            '        ' تنسيق العناوين Bold
            '        ws.Row(1).Style.Font.Bold = True

            '        ' Auto adjust columns
            '        ws.Columns().AdjustToContents()

            '        ' حفظ الملف
            '        wb.SaveAs(sfd.FileName)

            '        If MessageBox.Show("تم الحفظ، هل تريد فتح الملف؟", "فتح", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) = DialogResult.Yes Then
            '            Process.Start(sfd.FileName)
            '        End If
            '    End Using
            'End If
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
    End Sub

    'Private Sub ExportToCSV(filePath As String)
    '    Using sw As New StreamWriter(filePath, False, System.Text.Encoding.UTF8)
    '        ' رؤوس الأعمدة
    '        Dim header As String = String.Join(";", DGV.Columns.Cast(Of DataGridViewColumn).Select(Function(c) c.HeaderText))
    '        sw.WriteLine(header)

    '        ' الصفوف
    '        For Each row As DataGridViewRow In DGV.Rows
    '            If Not row.IsNewRow Then
    '                Dim cells As New List(Of String)
    '                For Each cell As DataGridViewCell In row.Cells
    '                    Dim val As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
    '                    ' نحذف الفواصل إن وجدت داخل القيمة ونضعها بين ""
    '                    val = """" & val.Replace("""", """""") & """"
    '                    cells.Add(val)
    '                Next
    '                sw.WriteLine(String.Join(";", cells))
    '            End If
    '        Next
    '    End Using

    '    ' فتح الملف في Excel مباشرة
    '    Process.Start("explorer.exe", filePath)
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim sfd As New SaveFileDialog()
    '    sfd.Filter = "CSV files (*.csv)|*.csv"
    '    sfd.FileName = "تقرير.csv"
    '    If sfd.ShowDialog() = DialogResult.OK Then
    '        ExportToCSV(sfd.FileName)
    '    End If
    'End Sub
End Class