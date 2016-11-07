''
'' 日付: 2016/09/25
''
'Public Class StopWatchItemControls
'	Private ReadOnly manager As StopWatchItemManager
'	Private ReadOnly params As ExcelProperties.WorkItemParams
'	
'	Private ReadOnly _panel As Panel
'	Public ReadOnly Property Panel As Panel
'		Get
'			Return _panel
'		End Get
'	End Property
'	
'	Private ReadOnly lblName As Label
'	Private ReadOnly btnRunning As Button
'	Private ReadOnly lblTime As Label
'	
'	Sub New(manager As StopWatchItemManager, params As ExcelProperties.WorkItemParams)
'		Me.manager = manager
'		Me.params = params
'		
'		_panel = DynamicControlGenerator.CreatePanel().Size(270, 23).Create
'		
'		' 作業項目名
'		lblName = DynamicControlGenerator.CreateLabel(params.Name).AutoSize(True).Location(3, 5).Create
'		_panel.Controls.Add(lblName)
'		
'		' ストップウォッチのスタート/ストップのボタン
'		btnRunning = DynamicControlGenerator.CreateButton("スタート").Location(112, 0).Size(75, 23).Create
'		_panel.Controls.Add(btnRunning)
'		AddHandler btnRunning.Click, AddressOf Run
'		
'		' 経過時間
'		lblTime = DynamicControlGenerator.CreateLabel(Me.ToStringFrom(0, 0, 0)).AutoSize(True).Location(210, 5).Create
'  	_panel.Controls.Add(lblTime)
'	End Sub
'	
'	''' <summary>
'	''' スタート/ストップのボタンの作用を許可するかどうかセットする。
'	''' </summary>
'	''' <param name="enabled"></param>
'	Public Sub EnabledRunningButton(enabled As Boolean)
'		' このメソッドが描画スレッド以外から呼び出された場合、このメソッドを描画スレッドに投げそこで処理が行われるようにする
'		If Me.btnRunning.InvokeRequired Then
'			Me.btnRunning.Invoke(
'				New SetBooleanDelegate(AddressOf EnabledRunningButton),
'				New Object() {enabled}
'			)
'		Else
'			Me.btnRunning.Enabled = enabled
'		End If
'	End Sub
'		
'  ''' <summary>
'  ''' ストップウォッチを状態を変える。
'  ''' 停止中のときは起動し、起動中のときは停止させる。
'  ''' </summary>
'  Private Sub Run()
'    manager.Run(Me)
'	End Sub
'	
'	''' <summary>
'	''' 表示時間を更新する。
'	''' </summary>
'	''' <param name="t"></param>
'	Public Sub UpdateTimer(t As TimeSpan)
'		If lblTime.InvokeRequired Then
'			' 描画スレッドでラベルを書き換える
'			lblTime.Invoke(
'				New SetTimeSpanDelegate(AddressOf UpdateTimer),
'				New Object() { t })
'		Else
'			lblTime.Text = ToStringFrom(t)
'		End If
'	End Sub
'	
'	''' <summary>
'	''' ボタンの名前を更新する。
'	''' </summary>
'	''' <param name="text"></param>
'	Public Sub UpdateRunningButtonName(text As String)
'		If btnRunning.InvokeRequired Then
'			' 描画スレッドでラベルを書き換える
'			btnRunning.Invoke(
'				New SetStringDelegate(AddressOf UpdateRunningButtonName),
'				New Object() { text })
'		Else
'			btnRunning.Text = text
'		End If	  
'	End Sub
'	''' <summary>
'	''' TimeSpanを文字列に変換する。
'	''' </summary>
'	''' <param name="t"></param>
'	''' <returns></returns>
'	Private Function ToStringFrom(t As TimeSpan) As String
'		Return ToStringFrom(t.Hours, t.Minutes, t.Seconds)
'	End Function
'	
'	''' <summary>
'	''' 時分秒の値を文字列に変換する。
'	''' </summary>
'	''' <returns></returns>
'	Private Function ToStringFrom(hour As Integer, min As Integer, sec As Integer) As String
'	  Return String.Format("{0:00}:{1:00}:{2:00}", hour, min, sec)
'	End Function
'	
'	Private Delegate Sub SetStringDelegate(text As String)
'	Private Delegate Sub SetBooleanDelegate(bool As Boolean)
'	Private Delegate Sub SetTimeSpanDelegate(t As TimeSpan)
'End Class
