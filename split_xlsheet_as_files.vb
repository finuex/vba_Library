Sub SplitEachWorksheet()
Dim FPath As String
FPath = Application.ActiveWorkbook.Path
Application.ScreenUpdating = False
Application.DisplayAlerts = False
For Each ws In ThisWorkbook.Sheets
    If ws.Visible <> xlSheetHidden Then
        ws.Copy
        Application.ActiveWorkbook.SaveAs Filename:=FPath & "\" & ws.Name & ".xlsx"
        Application.ActiveWorkbook.Close False
    End If
Next
Application.DisplayAlerts = True
Application.ScreenUpdating = True
End Sub

