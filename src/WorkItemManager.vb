'
' 日付: 2016/09/25
'
Imports Common.Extensions
Imports Common.Util

Public Class WorkItemManager
  
  ''' 作業項目の状態
  Private Class WorkItemStatus
    Public workCount As Integer          = 0
    Public workTime As Double            = 0.0
    Public wasWrittenWorkTime As Boolean = True
    Public params As ExcelProperties.WorkItemParams
  End Class
  
  Private _excel As ExcelAccessor	
  Public WriteOnly Property Excel As ExcelAccessor
    Set(excel As ExcelAccessor)
      If Excel Is Nothing Then Throw New ArgumentNullException("excel is null")
      _excel = excel
    End Set
  End Property
  
  ''' 作業項目とその状態をペアにしたコレクション
  Private workItemStatusMap As IDictionary(Of WorkItemControls, WorkItemStatus)
  
  Public Sub New(excel As ExcelAccessor)
    Me._excel = excel
    Me.workItemStatusMap = New Dictionary(Of WorkItemControls, WorkItemStatus)
  End Sub
  
  ''' <summary>
  ''' 作業項目を新規作成し、その入力フォームのパネルを返す。
  ''' </summary>
  ''' <param name="workItemParams"></param>
  ''' <returns></returns>
  Public Function CreatePanel(workItemParams As ExcelProperties.WorkItemParams) As Panel
    Dim item As New WorkItemControls(Me, workItemParams)
    Dim status As New WorkItemStatus
    status.params = workItemParams
    
    Me.workItemStatusMap.Add(item, status)
    Return item.Panel
  End Function
  
  Public Function Count() As Integer
    Return Me.workItemStatusMap.Count
  End Function
  
  '  Public Function TryGetStoredWorkItemParams(id As Integer, ByRef params As ExcelProperties.WorkItemParams) As Boolean
  '    Dim status As WorkItemStatus = Me.workItemStatusMap.Values.Find(Function(item) item.params.Id = id)
  '    
  '    If status IsNot Nothing Then
  '      params = status.params
  '      Return True
  '    Else
  '      Return False
  '    End If
  '  End Function
  
  '  Public Function StoredWorkItemParams() As IEnumerable(Of ExcelProperties.WorkItemParams)
  '    Dim l As IEnumerable(Of ExcelProperties.WorkItemParams) =
  '      Me.workItemStatusMap.Values.Convert(Function(item) item.params)
  '    
  '    
  '  End Function
  
  ''' <summary>
  ''' すべての作業項目のフォームをロードする。
  ''' </summary>
  Public Sub LoadAll()
    Me.workItemStatusMap.Keys.ForEach(Sub(item) Me.Load(item))
  End Sub
  
  ''' <summary>
  ''' 指定した作業項目のフォームをロードする。
  ''' </summary>
  ''' <param name="workItem"></param>
  Public Sub Load(workItem As WorkItemControls)
    If workItem Is Nothing Then Throw New ArgumentNullException("workItem is null")
    
    Dim status As New WorkItemStatus
    If Not workItemStatusMap.TryGetValue(workItem, status) Then
      Throw New ArgumentException("登録されていない作業項目です。")
    End If
    
    ' 作業件数をExcelから読み込みフォームを更新する
    Dim cntStr As String = _excel.Read(status.params.WorkCountCol)
    If Not Integer.TryParse(cntStr, status.workCount) Then
      status.workCount = 0
    End If
    workItem.UpdateWorkCount(status.workCount)
    
    ' 作業時間をExcelから読み込みフォームを更新する
    Dim timeStr As String = _excel.Read(status.params.WorkTimeCol)
    If Not Double.TryParse(timeStr, status.workTime) Then
      status.workTime = 0.0
    End If
    Dim hour As Integer = CType(Math.Truncate(status.workTime), Integer)
    Dim min As Integer = TimeUtils.ToMinute(status.workTime, 5) - hour
    workItem.UpdateWorkTime(hour, min)
    
    status.wasWrittenWorkTime = True
  End Sub
  
  ''' <summary>
  ''' すべての作業項目が作業時間を更新しているならTrueを返す。
  ''' </summary>
  Public Function WasWrittenAllWorkTime() As Boolean
    Return Me.workItemStatusMap.Values.All(Function(status) status.wasWrittenWorkTime)
  End Function
  
  ''' <summary>
  ''' 作業時間が更新されていないボタンの色を変える。
  ''' </summary>
  ''' <returns></returns>
  Public Sub ChangeColorOfUnwrittenWorkTimeButton()
    Me.workItemStatusMap.Keys.ForEach(
      Sub(key)
      Dim status As WorkItemStatus = Me.workItemStatusMap(key)
      If Not status.wasWrittenWorkTime Then
        key.ChangeColorOfUpdateWorkTimeButton(Color.MediumVioletRed)
      End If
    End Sub)
  End Sub
  
  ''' <summary>
  ''' 指定した作業項目の作業件数を追加する。
  ''' </summary>
  ''' <param name="workItem"></param>
  ''' <param name="count"></param>
  Public Sub AddWorkCount(workItem As WorkItemControls, count As Integer)
    If workItem Is Nothing Then Throw New ArgumentNullException("workItem is null")
    
    Dim status As New WorkItemStatus
    If Not workItemStatusMap.TryGetValue(workItem, status) Then
      Throw New ArgumentException("登録されていない作業項目です。")
    End If
    
    status.workCount += count
    workItem.UpdateWorkCount(status.workCount)
    
    ' 作業時間を未更新状態にする
    If status.params.WorkTimeCol <> String.Empty Then
      status.wasWrittenWorkTime = False
    End If
    'Me.workItemStatusMap(workItem) = status
    
    _excel.Write(status.workCount.ToString, status.params.WorkCountCol)
  End Sub
  
  ''' <summary>
  ''' 指定した作業項目の作業時間を更新する。
  ''' </summary>
  ''' <param name="workItem"></param>
  ''' <param name="hour"></param>
  ''' <param name="minute"></param>
  Public Sub UpdateWorkTime(workItem As WorkItemControls, hour As Integer, minute As Integer)
    If workItem Is Nothing Then Throw New ArgumentNullException("workItem is null")
    
    Dim status As New WorkItemStatus
    If Not workItemStatusMap.TryGetValue(workItem, status) Then
      Throw New ArgumentException("登録されていない作業項目です。")
    End If
    
    status.workTime = hour + TimeUtils.ToHour(minute, 2)
    
    ' 作業時間を更新済み状態にする
    status.wasWrittenWorkTime = True
    ' ボタンの色を通常の色に変更する
    workItem.ChangeColorOfUpdateWorkTimeButton(Color.Black)
    
    Me.workItemStatusMap(workItem) = status
    
    _excel.Write(status.workTime.ToString, status.params.WorkTimeCol)
    
    MsgBox.Show("送信しました。", "確認")
  End Sub
End Class
