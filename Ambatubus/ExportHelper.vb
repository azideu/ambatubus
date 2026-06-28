Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Public Class ExportHelper
    ''' <summary>
    ''' Exports a DataTable to a CSV file safely handling commas, quotes, and newlines.
    ''' </summary>
    Public Shared Sub ExportDataTableToCsv(dt As DataTable, filePath As String)
        Try
            Dim sb As New StringBuilder()

            ' Write Headers
            Dim headers As String() = dt.Columns.Cast(Of DataColumn)().Select(Function(c) EscapeCsvField(c.ColumnName)).ToArray()
            sb.AppendLine(String.Join(",", headers))

            ' Write Rows
            For Each row As DataRow In dt.Rows
                Dim fields As String() = row.ItemArray.Select(Function(f) EscapeCsvField(If(f IsNot Nothing, f.ToString(), ""))).ToArray()
                sb.AppendLine(String.Join(",", fields))
            Next

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8)
            MessageBox.Show($"Data successfully exported to {vbCrLf}{filePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to export data: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Shared Function EscapeCsvField(field As String) As String
        If field Is Nothing Then Return ""
        
        Dim mustQuote As Boolean = field.Contains(",") OrElse field.Contains("""") OrElse field.Contains(vbCr) OrElse field.Contains(vbLf)
        If mustQuote Then
            Return """" & field.Replace("""", """""") & """"
        Else
            Return field
        End If
    End Function
End Class
