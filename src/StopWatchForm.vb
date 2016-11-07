''
'' 日付: 2016/09/10
''
'Public Partial Class StopWatchForm
'	Private workItemManager As WorkItemManager
'	
'	Private stopWatchManager As New StopWatchItemManager
'	
'	Public Sub New()
'		Me.InitializeComponent()
'	End Sub
'	
'	Sub StopWatchFormLoad(sender As Object, e As EventArgs)
'		Me.workItemManager = MainForm.Instance.WorkItemManager
'		
'		CreateStopWatchItemForm()
'		
'		LoadCurrentTime()
'	End Sub
'	
'	Sub StopWatchFormClosing(sender As Object, e As System.ComponentModel.CancelEventArgs)
'		If stopWatchManager.Running Then
'			Dim res As DialogResult = 
'				MessageBox.Show(
'				"稼働中のタイマーがありますが、ウィンドウを閉じてよろしいですか？",
'				"確認",
'				MessageBoxButtons.OKCancel,
'				MessageBoxIcon.Exclamation)
'			If res = DialogResult.Cancel Then
'				e.Cancel = True
'				Return
'			End If
'		End If		
'	End Sub
'	
'	Private Sub CreateStopWatchItemForm()
'		If Me.stopWatchManager.Count = 0 Then
'			Dim x As Integer = 12
'			Dim y As Integer = 28
'			
'			For i As Integer = 0 To Me.workItemManager.Count - 1
'			  Dim item As WorkItemManager.WorkItem = Me.workItemManager(i)
'			  
'			  ' 作業時間フォームが存在するか確かめる
'			  ' WorkTimeはフォームが存在しない場合、-1を返す
'			  If item.WorkTime >= 0 Then
'  				Dim panel As Panel = stopWatchManager.CreateStopWatchPanel(item)
'  				panel.Location = New Point(x, y)
'  				
'  				Me.Controls.Add(panel)
'  				
'  				y += 29
'  			End If
'			Next
'			
'			Me.Size = New Size(306, y + 63)
'		End If
'	End Sub
'	
'	Private Sub LoadCurrentTime()
'		Me.stopWatchManager.LoadAll
'	End Sub
'	
'	Sub BtnCloseClick(sender As Object, e As EventArgs)
'		Dim isClosing As Boolean = True
'		
'
'		
'		If isClosing Then
'			Me.Close		
'		End if
'	End Sub
'End Class
