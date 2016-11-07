'' 日付: 2016/09/25
''
'Imports System.Threading
'Imports System.Threading.Tasks
'
'Imports Common.Extensions
'
'Public Class StopWatchItemManager
'  Private ReadOnly workItemManager As WorkItemManager
'  
'  Private Class StopWatchItemStatus
'    Public running As Boolean = False
'    Public time As New TimeSpan(0)
'  End Class
'  
'  Private stopWatchItemStatusMap As IDictionary(Of StopWatchItemControls, StopWatchItemStatus)
'  
'  Private task As Task
'  
'  Public Sub New(workItemManager As WorkItemManager)
'    If workItemManager Is Nothing Then Throw New ArgumentNullException("workItemManager is null")
'    
'    Me.workItemManager = workItemManager
'  End Sub
'  
'  ''' <summary>
'  ''' １つの作業項目のストップウォッチのフォームを構築したパネルを返す。
'  ''' </summary>
'  ''' <param name="params"></param>
'  ''' <returns></returns>
'  Public Function CreatePanel(params As ExcelProperties.WorkItemParams) As Panel
'    ' TODO workItemManagerからStopWatchControlのインスタンスを生成するようにしたい
'    '      workItemManagerの各StatusとstopWatchManagerの各Statusを紐付けるようにしたい
'    '      そうしないと作業時間の読み込みができない
''    For i As Integer In 1 To Me.workItemManager.Count
''      
''    Next
'    
'    Dim item As New StopWatchItemControls(Me, params)
'    Dim status As New StopWatchItemStatus
'    
'    Me.stopWatchItemStatusMap.Add(item, status)
'    
'    Return item.Panel
'  End Function
'  
'  
'  Public Sub Load(stopWatchItem As StopWatchItemControls)
'    If stopWatchItem Is Nothing Then Throw New ArgumentNullException("stopWatchItem is null")
'    
'    Dim status As New StopWatchItemStatus
'    If Not Me.stopWatchItemStatusMap.TryGetValue(stopWatchItem, status) Then
'      Throw New ArgumentException("登録されていない作業項目です。")
'    End If
'    
'    
'  End Sub
'  
'  ''' <summary>
'  ''' 指定した作業項目のストップウォッチを起動/停止させ、
'  ''' ほかの作業項目のストップウォッチの状態を変化させる。
'  ''' このストップウォッチを起動させた場合は、ほかのストップウォッチを無効化し、
'  ''' 停止させた場合は、有効化する。
'  ''' </summary>
'  ''' <param name="stopWatchItem"></param>
'  Public Sub Run(stopWatchItem As StopWatchItemControls)
'    If stopWatchItem Is Nothing Then Throw New ArgumentNullException("stopWatchItem is null")
'    
'    Dim status As New StopWatchItemStatus
'    If Not Me.stopWatchItemStatusMap.TryGetValue(stopWatchItem, status) Then
'      Throw New ArgumentException("登録されていない作業項目です。")
'    End If
'    
'    Dim enabled As Boolean
'    Dim btnName As String
'    ' ストップウォッチを起動/停止させる
'    If status.running Then
'      StopTimer(stopWatchItem, status)
'      btnName = "スタート"
'      enabled = True
'    Else
'      StartTimer(stopWatchItem, status)
'      btnName = "ストップ"
'      enabled = False
'    End If
'    
'    ' ボタンの名前を更新する
'    stopWatchItem.UpdateRunningButtonName(btnName)
'    
'    ' ほかのストップウォッチを無効化/有効化させる
'    Me.stopWatchItemStatusMap.Keys.ForEach(
'      Sub(item) 
'        If item IsNot stopWatchItem Then
'          item.EnabledRunningButton(enabled)
'        End If
'      End Sub)
'  End Sub
'  
' 	''' <summary>
'	''' ストップウォッチを起動させる。
'	''' </summary>
'	Private Sub StartTimer(item As StopWatchItemControls, status As StopWatchItemStatus)
'		status.running = True
'		Me.task = Task.Factory.StartNew(Sub() Me.TimerTask(item, status))
'	End Sub
'	
'	Private Sub StopTimer(item As StopWatchItemControls, status As StopWatchItemStatus)
'		If status.running Then
'		  status.running = False
'		  ' タスクが終了するまで待つ
'			Me.task.Wait
'		End If
'	End Sub
'
'  ''' <summary>
'  ''' ストップウォッチのタスク。
'  ''' </summary>
'  ''' <param name="item"></param>
'  ''' <param name="status"></param>
'  Private Sub TimerTask(item As StopWatchItemControls, status As StopWatchItemStatus)
'    Dim base As Long = status.time.Ticks
'		Dim start As Long = Date.Now.Ticks
'		
'		Try
'			Do While status.running
'				Dim progress As Long = Date.Now.Ticks - start + base
'				status.time = New TimeSpan(progress)
'				
'				item.UpdateTimer(status.time)
'				
'				Thread.Sleep(1000)
'			Loop
'		Catch ex As Exception
'		End Try
'	End Sub
'End Class
