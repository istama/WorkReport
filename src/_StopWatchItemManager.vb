''
'' 日付: 2016/09/10
''
'Imports System.Threading
'Imports System.Threading.Tasks
'
'Imports Common.Util
'
'Public Class StopWatchItemManager2
'	Private stopWatchItemList As New List(Of StopWatchItem)
'	
'	Public Sub New()
'	End Sub
'	
'	Public Function CreateStopWatchPanel(item As WorkItemManager.WorkItem) As Panel
'		Dim swItem As New StopWatchItem(Me, item)
'		stopWatchItemList.Add(swItem)
'		
'		Return swItem.Panel
'	End Function
'	
'	Public Function Count() As Integer
'		Return stopWatchItemList.Count
'	End Function
'	
'	Public Sub LoadAll()
'		stopWatchItemList.ForEach(Sub(i) i.Load)
'	End Sub
'	
'	Public Function Running() As Boolean
'		Return stopWatchItemList.Exists(Function(i) i.Running)
'	End Function
'	
'	Private Class StopWatchItem
'		Private ReadOnly manager As StopWatchItemManager
'		Private ReadOnly workItem As WorkItemManager.WorkItem
'		
'		Private ReadOnly _panel As Panel
'		Public ReadOnly Property Panel As Panel
'			Get
'				Return _panel
'			End Get
'		End Property
'		
'		Private ReadOnly lblName As Label
'		Private ReadOnly btnRunning As Button
'		Private ReadOnly lblTime As Label
'		
'		Private totalTime As TimeSpan
'		
'		Private _running As Boolean = False
'		Public ReadOnly Property Running As Boolean
'			Get
'				Return _running
'			End Get
'		End Property
'		
'		Private task As Task
'		
'		Sub New(manager As StopWatchItemManager, item As WorkItemManager.WorkItem)
'			Me.manager = manager
'			Me.workItem = item
'			
'			_panel = DynamicControlGenerator.CreatePanel().Size(270, 23).Create
'			
'			lblName = DynamicControlGenerator.CreateLabel(item.Name).AutoSize(True).Location(3, 5).Create
'			_panel.Controls.Add(lblName)
'			
'			btnRunning = DynamicControlGenerator.CreateButton("スタート").Location(112, 0).Size(75, 23).Create
'			_panel.Controls.Add(btnRunning)
'			AddHandler btnRunning.Click, AddressOf EventHandlerForStopwatch
'			
'			Dim totalTime As TimeSpan = TimeUtils.ToTimeSpanFrom(item.WorkTime)
'			Dim stopWatchTIme As TimeSpan = TimeUtils.ToTimeSpanFrom(item.StopWatchTIme)
'			
'			Dim time As TimeSpan
'			If stopWatchTIme > totalTime Then
'			  time = stopWatchTIme
'			Else
'			  time = totalTime
'			End If
' 		  lblTime = DynamicControlGenerator.CreateLabel(ToStringFrom(time)).AutoSize(True).Location(210, 5).Create
'	  	_panel.Controls.Add(lblTime)
'		End Sub
'		
'		Public Sub EnabledRunning(enabled As Boolean)
'			Me.btnRunning.Enabled = enabled
'		End Sub
'		
'		Public Sub Load
'		 	Dim totalTime As TimeSpan = TimeUtils.ToTimeSpanFrom(Me.workItem.WorkTime)
'			Dim stopWatchTIme As TimeSpan = TimeUtils.ToTimeSpanFrom(Me.workItem.StopWatchTIme)
'			
'			Dim time As TimeSpan
'			If stopWatchTIme > totalTime Then
'			  time = stopWatchTIme
'			Else
'			  time = totalTime
'			End If
'			
'			UpdateTimer(time)
'		End Sub
'		
'		Private Sub EventHandlerForStopwatch
'			If Not _running Then
'				StartTimer()
'			Else
'				StopTimer()
'			End If
'		End Sub
'		
'		Private Sub StartTimer()
'			_running = True
'			
'			Me.task = Task.Factory.StartNew(Sub() Me.TimerTask)
'			
'			manager.stopWatchItemList.ForEach(
'				Sub(i) If i IsNot Me Then i.EnabledRunning(False))
'			
'			btnRunning.Text = "ストップ"
'		End Sub
'	
'		Private Sub StopTimer()
'			If _running Then
'				_running = False
'				
'				Me.task.Wait
'				
'				manager.stopWatchItemList.ForEach(
'					Sub(i) If i IsNot Me Then i.EnabledRunning(True))
'				
'				btnRunning.Text = "スタート"
'			End If
'		End Sub
'		
'		Private Sub TimerTask()
'			Dim base As TimeSpan
'			If TimeSpan.TryParse(lblTime.Text, base) = False Then
'				base = New TimeSpan(0, 0, 0)
'			End If
'			
'			Dim start As Long = Date.Now.Ticks
'			
'			Try
'				Do While _running
'					Dim progress As Long = Date.Now.Ticks - start + base.Ticks
'					Dim time As New TimeSpan(progress)
'					
'					UpdateTimer(time)
'					
'					Thread.Sleep(1000)
'				Loop
'			Catch ex As Exception
'			End Try
'		End Sub
'		
'		
'		Private Delegate Sub UpdateTimerDelegate(t As TimeSpan)
'		
'		Private Sub UpdateTimer(t As TimeSpan)
'			If lblTime.InvokeRequired Then
'				' 描画スレッドでラベルを書き換える
'				lblTime.Invoke(
'					New UpdateTimerDelegate(AddressOf UpdateTimer),
'					New Object() { t })
'			ElseIf t > totalTime
'				totalTime = t
'				lblTime.Text = ToStringFrom(totalTime)
'			End If
'		End Sub
'		
'		Private Function ToStringFrom(t As TimeSpan) As String
'			Return String.Format("{0:00}:{1:00}:{2:00}", t.Hours, t.Minutes, t.Seconds)
'		End Function
'	End Class
'End Class
