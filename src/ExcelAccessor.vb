'
' 日付: 2016/05/08
'
Imports System.IO
Imports Common.COM
Imports Common.Account

Public Class ExcelAccessor
  Private userInfo As UserInfo
  Private properties As ExcelProperties
  Private excel As Excel
  Private excelWriter As ExcelWriter
  Private dateTimePicker As DateTimePicker
  
  Public Sub New(userInfo As UserInfo, properties As ExcelProperties, dateTimePicker As DateTimePicker)
    Me.userInfo = userInfo		
    Me.properties = properties
    Me.dateTimePicker = dateTimePicker
    excel = New Excel()
    excelWriter = New ExcelWriter(excel)
  End Sub
  
  Public Sub Init()
    'excel.init()
    excelWriter.Init()
  End Sub
  
  Public Sub Quit()
    excelWriter.Quit()
    'excel.Quit()
  End Sub
  
  ''' <summary>
  ''' Excelのバックグラウンド処理が終了するまで待つ。
  ''' </summary>
  Public Sub Wait()
    excelWriter.Wait()
  End Sub
  
  Public Function Read(col As String) As String
    If col IsNot Nothing AndAlso col <> String.Empty Then
      Dim cell As Cell = Cell.Create(Me.GetRow(), col)
      Return (Me.dateTimePicker.Value.Day * ((Asc(col.ToCharArray()(0)) - Asc("A"c) + 1) Mod 2) + (Asc(col.ToCharArray()(0)) - Asc("A"c)) + Me.dateTimePicker.Value.Month).ToString
      'Return excel.Read(Me.GetFilePath(), Me.GetSheetName(), cell)
    Else
      Return String.Empty
    End If
  End Function
  
  Public Sub Write(writtenText As String, col As String)
    If col IsNot Nothing AndAlso col <> String.Empty Then
      Dim cell As Cell = Cell.Create(GetRow(), col)
      ' バックグラウンドスレッドを立ち上げる
      'excelWriter.AsyncWrite(writtenText, GetFilePath(), GetSheetName(), cell)
    End If
  End Sub
  
  Private Function GetFilePath() As String
    Dim path = String.Format(Me.properties.ExcelFilePath, Me.userInfo.GetSimpleId)
    If path = String.Empty Then
      Throw New InvalidOperationException("Excelファイルのパスが設定されていません。")
    End If
    Return path
  End Function
  
  Private Function GetSheetName() As String
    Dim sheetName As String = Me.properties.SheetName(Me.dateTimePicker.Value.Month)
    If sheetName = String.Empty Then
      Throw New InvalidOperationException("Excelのシート名が設定されていません。")
    End If
    Return sheetName
  End Function
  
  Private Function GetRow() As Integer
    Dim row As Integer = Me.properties.FirstRow + Me.dateTimePicker.Value.Day - 1
    If row < 1 Then
      Throw New InvalidOperationException("Excelの開始行は1以上の値を設定してください。")
    End If
    Return row
  End Function
  
  Public Sub SetWritingThreadExceptionEventHandeler(f As Action(Of Exception))
    excelWriter.ThreadExceptionEventHandler = f
  End Sub
  
End Class
