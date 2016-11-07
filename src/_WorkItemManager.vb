''
'' 日付: 2016/09/07
''
'Imports Common.Util
'
'''' <summary>
'''' 作業項目を表すコントロール群を生成、管理する。
'''' 
'''' CreateWorkItemPanel()メソッドで1つの作業項目にあたる入力フォームを生成し、
'''' このクラスの管理下に置く。
'''' 
'''' 外部のExcelファイルにアクセスするにはExcelプロパティとDateTImePickerプロパティにセットすることが必須。
'''' </summary>
'Public Class WorkItemManager
'	Private _excel As ExcelAccessor	
'	Public WriteOnly Property Excel As ExcelAccessor
'		Set(excel As ExcelAccessor)
'			_excel = excel
'		End Set
'	End Property
'	
'	Private _dateTimePicker As DateTimePicker
'	Public WriteOnly Property DateTimePicker As DateTimePicker
'		Set(dateTimePicker As DateTimePicker)
'			_dateTimePicker = dateTimePicker
'		End Set
'	End Property
'	
'	Private cboxHourItems As New List(Of String)
'	ReadOnly Property ComboBoxHourItems As List(Of String)
'		Get
'			Return cboxHourItems
'		End Get
'	End Property
'	
'	Private cboxMinItems As New List(Of String)
'	ReadOnly Property ComboBoxMinItems As List(Of String)
'		Get
'			Return cboxMinItems
'		End Get
'	End Property
'	
'	Private WorkItemList As New List(Of WorkItem)
'	
'	Public Sub New()
'		' コンボボックスの要素のコレクションを初期化する
'		For i As Integer = 0 To 15
'			cboxHourItems.Add(i.ToString.PadLeft(2, "0"c))
'		Next
'		For i As Integer = 0 To 11
'			cboxMinItems.Add((i * 5).ToString.PadLeft(2, "0"c))
'		Next		
'	End Sub
'	
'	Public Function CreateWorkItemPanel(values As ExcelProperties.WorkItemParams) As Panel
'		Dim workItem As New WorkItem(Me, values)
'		Me.WorkItemList.Add(workItem)
'		
'		Return workItem.Panel
'	End Function
'	
'	Public Sub LoadAll()
'		WorkItemList.ForEach(Sub(i) i.Load)
'	End Sub
'	
'	Public Function Count() As Integer
'		Return WorkItemList.Count
'	End Function
'	
'	Public Default ReadOnly Property WorkItemArray(index As Integer) As WorkItem
'		Get
'			If index < 0 OrElse index >= Count() Then Throw New ArgumentOutOfRangeException()
'			
'			Return WorkItemList(index)
'		End Get
'	End Property
'	
'	Public Function NotOverwrittenWorkTimeExists() As Boolean
'		Return WorkItemList.Exists(Function(i) Not i.WasWorkTimeWritten)
'	End Function
'	
'	Public Sub ChangeColorOfButtonThatNotOverwrite()
'		Me.WorkItemList.ForEach(
'			Sub(i)
'				If Not i.WasWorkTimeWritten Then
'					i.ChangeColorOfButtonToWriteWorkTime
'				End If
'			End Sub)
'	End Sub
'	
'	''' <summary>
'	''' Excelの指定した列に文字列を書き込む。
'	''' </summary>
'	''' <param name="text">書き込む文字列</param>
'	''' <param name="col">書き込み先の列</param>
'	Private Sub WriteToExcel(text As String, col As String)
'		If _excel Is Nothing Then Throw New InvalidOperationException("プロパティExcelがセットされていません。")
'		If _dateTimePicker Is Nothing Then Throw New InvalidOperationException("プロパティDateTimePickerがセットされていません。")
'		
'		Dim d As DateTime = _dateTimePicker.Value
'		_excel.Write(text, d.Month, d.Day, col) 
'	End Sub
'	
'	''' <summary>
'	''' 指定した列のExcelの列を読み込む。
'	''' </summary>
'	''' <param name="col">読み込む列</param>
'	Private Function ReadFromExcel(col As String) As String
'		Dim d As DateTime = _dateTimePicker.Value
'		Return _excel.Read(d.Month, d.Day, col)
'	End Function
'	
'	Public Class WorkItem
'		Private ReadOnly manager As WorkItemManager		
'		Private ReadOnly values As ExcelProperties.WorkItemParams
'		
'		Private ReadOnly _panel As Panel
'		Public ReadOnly Property Panel As Panel
'			Get
'				Return _panel
'			End Get
'		End Property
'		
'		Private ReadOnly lblName As Label
'		Private ReadOnly tboxWorkCount As TextBox
'		Private ReadOnly btn10 As Button
'		Private ReadOnly btn5 As Button
'		Private ReadOnly btn1 As Button
'		Private ReadOnly btnM1 As Button
'		Private ReadOnly cboxHour As ComboBox
'		Private ReadOnly cboxMin As ComboBox
'		Private ReadOnly lblHour As Label
'		Private ReadOnly lblMin As Label
'		Private ReadOnly btnToWriteWorkTime As Button
'		
'		Private _WasWorkTimeWritten As Boolean = True
'		Public ReadOnly Property WasWorkTimeWritten As Boolean
'			Get
'				Return _WasWorkTimeWritten
'			End Get
'		End Property
'		
'		Private ReadOnly originalButtonColor As Color
'		
'		Private _StopWatchTime As Double = 0.0
'		Public Property StopWatchTIme As Double
'		  Get
'		    Return _StopWatchTime
'		  End Get
'		  Set (time As Double)
'		    _StopWatchTime = time
'		  End Set
'		End Property
'		
'		Sub New(manager As WorkItemManager, values As ExcelProperties.WorkItemParams)
'			Me.manager = manager
'			Me.values = values
'			
'			_panel = DynamicControlGenerator.CreatePanel().Size(618, 25).Create
'			
'			' 作業項目名が存在する場合、ラベルを作成する
'			If values.Name <> String.Empty Then
'				lblName = DynamicControlGenerator.CreateLabel(values.Name).AutoSize(True).Location(3, 6).Margin(3, 0, 3, 0).Create
'				_panel.Controls.Add(lblName)
'			Else
'				lblName = Nothing
'			End If
'			
'			' 作業件数のExcel列が設定されている場合、件数のフォームを作成する
'			If values.WorkCountCol <> String.Empty Then
'				tboxWorkCount = DynamicControlGenerator.CreateTextBox(String.Empty, True).Location(97, 3).Size(50, 19).Create
'				_panel.Controls.Add(tboxWorkCount)
'				
'				btn10 = DynamicControlGenerator.CreateCountButton(10).Location(153, 0).Size(50, 25).Margin(3).Create
'				AddHandler btn10.Click, CreateEventHandlerToAddWorkCount(10)
'				_panel.Controls.Add(btn10)
'				
'				btn5 = DynamicControlGenerator.CreateCountButton(5).Location(207, 0).Size(50, 25).Margin(3).Create
'				AddHandler btn5.Click, CreateEventHandlerToAddWorkCount(5)
'				_panel.Controls.Add(btn5)
'				
'				btn1 = DynamicControlGenerator.CreateCountButton(1).Location(261, 0).Size(50, 25).Margin(3).Create
'				AddHandler btn1.Click, CreateEventHandlerToAddWorkCount(1)
'				_panel.Controls.Add(btn1)
'				
'				btnM1 = DynamicControlGenerator.CreateCountButton(-1).Location(315, 0).Size(50, 25).Margin(3).Create
'				AddHandler btnM1.Click, CreateEventHandlerToAddWorkCount(-1)
'				_panel.Controls.Add(btnM1)
'			Else
'				tboxWorkCount = Nothing
'				btn10 = Nothing
'				btn5  = Nothing
'				btn1  = Nothing
'				btnM1 = Nothing
'			End If
'			
'			' 作業時間のExcelの列が設定されている場合、作業時間のフォームを作成する
'			If values.WorkTimeCol <> String.Empty Then
'				cboxHour = DynamicControlGenerator.CreateComboBox(manager.cboxHourItems, ComboBoxStyle.DropDownList).Location(387, 2).Size(45, 20).Create
'				_panel.Controls.Add(cboxHour)
'				
'				lblHour = DynamicControlGenerator.CreateLabel("時間").Location(437, 6).AutoSize(True).Create
'				_panel.Controls.Add(lblHour)
'				
'				cboxMin = DynamicControlGenerator.CreateComboBox(manager.cboxMinItems, ComboBoxStyle.DropDownList).Location(472, 2).Size(45, 20).Create
'				_panel.Controls.Add(cboxMin)
'				
'				lblMin = DynamicControlGenerator.CreateLabel("分").Location(522, 6).AutoSize(True).Create
'				_panel.Controls.Add(lblMin)
'				
'				btnToWriteWorkTime = DynamicControlGenerator.CreateButton("上書き").Location(547, 0).Size(60, 25).Margin(3).Create
'				originalButtonColor = btnToWriteWorkTime.ForeColor
'				AddHandler btnToWriteWorkTime.Click, CreateEventHandlerToWriteWorkTime()
'				_panel.Controls.Add(btnToWriteWorkTime)
'			Else
'				cboxHour = Nothing
'				lblHour  = Nothing
'				cboxMin  = Nothing
'				lblMin   = Nothing
'				btnToWriteWorkTime = Nothing
'			End If
'			
'		End Sub
'		
'		''' <summary>
'		''' 指定した日付の作業件数をロードする。
'		''' </summary>
'		''' <param name="d">ロードするデータの日付</param>
'		''' <param name="col">Excelファイル上の作業件数の列</param>
'		Public Sub Load()
'			' テキストボックスを更新する
'			SetWorkCount(manager.ReadFromExcel(values.WorkCountCol))
'			
'			Dim time As Double
'			Dim minute As Integer = 0
'			
'			' 時間を表す文字列を実数に変換する
'			If Double.TryParse(manager.ReadFromExcel(values.WorkTimeCol), time) Then
'			  ' 時間(hour)単位の実数を分単位の整数に変換する
'			  ' 変換後の値は５分間隔に切り詰める
'			  minute = TimeUtils.ToMinute(Math.Round(time, 2), 5)
'			End If
'			
'			Dim hour As Integer = minute \ 60
'			Dim min As Integer = minute Mod 60
'			
'			' コンボボックスの表示を更新する
'			SetWorkTime(Me.cboxHour, hour)
'			SetWorkTime(Me.cboxMin, min)
'		End Sub
'		
'		Public Sub ChangeColorOfButtonToWriteWorkTime()
'			Me.btnToWriteWorkTime.ForeColor = Color.MediumVioletRed
'		End Sub
'		
'		''' <summary>
'		''' 作業項目の名前を取得。
'		''' </summary>
'		Public Function Name As String
'		  If lblName Is Nothing Then Return String.Empty
'		  
'			Return lblName.Text
'		End Function
'		
'		''' <summary>
'		''' 指定した値を作業件数のテキストボックスにセットする。
'		''' 数字以外の文字列が渡された場合は0にする。
'		''' </summary>
'		Private Sub SetWorkCount(value As String)
'		  If Me.tboxWorkCount Is Nothing Then Return
'		  
'			' このメソッドが描画スレッド以外から呼び出された場合、このメソッドを描画スレッドに投げそこで処理が行われるようにする
'			If Me.tboxWorkCount.InvokeRequired Then
'				Me.tboxWorkCount.Invoke(
'					New SetWorkCountDelegate(AddressOf SetWorkCount),
'					New Object() {value}
'				)
'			Else
'				If System.Text.RegularExpressions.Regex.IsMatch(value, "^[0-9]+$") Then
'					Me.tboxWorkCount.Text = value
'				Else
'					Me.tboxWorkCount.Text = "0"
'				End If				
'			End If
'		End Sub
'		
'		''' <summary>
'		''' 作業件数を取得する。
'		''' 作業件数フォームが存在しない場合は-1を返す。
'		''' </summary>
'		Public Function WorkCount() As Integer
'		  If tboxWorkCount Is Nothing Then Return -1
'		  
'		  Dim count As Integer
'			If Not Integer.TryParse(tboxWorkCount.Text, count) Then
'				count = 0
'			End If
'			
'			Return count
'		End Function
'		
'		''' <summary>
'		''' コンボボックスの表示を指定した値の要素に変換する。
'		''' </summary>
'		''' <param name="comboBox"></param>
'		''' <param name="value"></param>
'		Private Sub SetWorkTime(comboBox As ComboBox, value As Integer)
'		  If comboBox Is Nothing Then Return
'		  
'			Dim idx As Integer = 0
'			
'			For i As Integer = 1 To comboBox.Items.Count - 1
'				' 引数の値に一致する要素がなかった場合に備えて、
'				' 「引数の値以下の値のうちの最大値」の要素のインデックスをセットする
'				If value < Integer.Parse(comboBox.GetItemText(comboBox.Items(i))) Then
'					idx = i - 1
'					Exit For
'				End If
'			Next
'			
'			SetIndexTo(comboBox, idx)
'		End Sub
'		
'		''' <summary>
'		''' コンボボックスの表示を指定したインデックスの要素に更新する。
'		''' </summary>
'		''' <param name="comboBox"></param>
'		''' <param name="idx"></param>
'		Private Sub SetIndexTo(comboBox As ComboBox, idx As Integer)
'		  If comboBox Is Nothing Then Return
'		  
'			' 描画スレッドから呼び出されなかった場合、描画スレッドに処理を移譲する
'			If comboBox.InvokeRequired Then
'				comboBox.Invoke(
'					New SetWorkTimeDelegate(AddressOf SetIndexTo),
'					New Object() {comboBox, idx}
'				)
'			Else
'				comboBox.SelectedIndex = idx
'			End If
'		End Sub
'		
'		''' <summary>
'		''' 作業時間を時間（hour）単位で取得する。
'		''' 作業時間フォームが存在しない場合は-1.0を返す。
'		''' </summary>
'		''' <returns></returns>
'		Public Function WorkTime() As Double
'		  If Me.cboxHour Is Nothing OrElse Me.cboxMin Is Nothing Then Return -1.0
'		  
'			Dim h As Integer = Integer.Parse(Me.cboxHour.SelectedItem.ToString) * 60
'			Dim m As Integer = Integer.Parse(Me.cboxMin.SelectedItem.ToString)
'			Return TimeUtils.ToHour(h + m, 2)
'		End Function
'		
'		''' <summary>
'		''' 件数ボタンが押されたときのハンドラを生成する。
'		''' </summary>
'		''' <param name="addedCount"></param>
'		Private Function CreateEventHandlerToAddWorkCount(addedCount As Integer) As EventHandler
'			Return New EventHandler(
'				Sub()
'					Try
'						Dim currentCount As Integer
'						If Not Integer.TryParse(tboxWorkCount.Text, currentCount) Then
'							currentCount = 0
'						End If
'						
'						Dim count As Integer = currentCount + addedCount
'						
'						SetWorkCount(count.ToString)
'						manager.WriteToExcel(count.ToString, Me.values.WorkCountCol)
'						
'						Me._WasWorkTimeWritten = False
'					Catch ex As Exception
'						MsgBox.ShowError(ex)					
'					End Try
'				End Sub)
'		End Function
'		
'		''' <summary>
'		''' 作業時間上書きボタンが押されたときのハンドラを生成する。
'		''' </summary>
'		Private Function CreateEventHandlerToWriteWorkTime() As EventHandler
'			Return New EventHandler(
'				Sub()
'				Try
'					manager.WriteToExcel(WorkTime().ToString, Me.values.WorkTimeCol)
'					
'					Me._WasWorkTimeWritten = True
'					Me.btnToWriteWorkTime.ForeColor = Me.originalButtonColor
'				Catch ex As Exception
'					MsgBox.ShowError(ex)
'				End Try
'				End Sub)
'		End Function
'		
'		Private Delegate Sub SetWorkCountDelegate(text As String)
'		Private Delegate Sub SetWorkTimeDelegate(comboBox As ComboBox, idx As Integer)
'	End Class
'End Class
