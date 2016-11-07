'
' 日付: 2016/09/25
'
Public Class WorkItemControls
  Private Shared ReadOnly cboxHourItems As New List(Of String)
  Private Shared ReadOnly cboxMinItems As New List(Of String)
  
  Shared Sub New
    ' コンボボックスの要素のコレクションを初期化する
    For i As Integer = 0 To 15
      cboxHourItems.Add(i.ToString.PadLeft(2, "0"c))
    Next
    For i As Integer = 0 To 11
      cboxMinItems.Add((i * 5).ToString.PadLeft(2, "0"c))
    Next	    
  End Sub
  
  Private ReadOnly manager As WorkItemManager
  Private ReadOnly values As ExcelProperties.WorkItemParams
  
  Private ReadOnly _panel As Panel
  Public ReadOnly Property Panel As Panel
    Get
      Return _panel
    End Get
  End Property
  
  Private ReadOnly lblName As Label
  Private ReadOnly tboxWorkCount As TextBox
  Private ReadOnly btn10 As Button
  Private ReadOnly btn5 As Button
  Private ReadOnly btn1 As Button
  Private ReadOnly btnM1 As Button
  Private ReadOnly cboxHour As ComboBox
  Private ReadOnly cboxMin As ComboBox
  Private ReadOnly lblHour As Label
  Private ReadOnly lblMin As Label
  Private ReadOnly btnToWriteWorkTime As Button
  
  Private ReadOnly originalButtonColor As Color
  Private ReadOnly warningButtonColor As Color = Color.MediumVioletRed
  
  ''' <summary>
  ''' コンストラクタ。
  ''' </summary>
  ''' <param name="values">作業項目のプロパティ値</param>
  Sub New(manager As WorkItemManager, params As ExcelProperties.WorkItemParams)
    Me.manager = manager
    Me.values = params
    
    _panel = DynamicControlGenerator.CreatePanel().Size(618, 25).Create
    
    ' 作業項目名が存在する場合、ラベルを作成する
    If params.Name <> String.Empty Then
      lblName = DynamicControlGenerator.CreateLabel(params.Name).AutoSize(True).Location(3, 6).Margin(3, 0, 3, 0).Create
      _panel.Controls.Add(lblName)
    Else
      lblName = Nothing
    End If
    
    ' 作業件数のExcel列が設定されている場合、件数のフォームを作成する
    If params.WorkCountCol <> String.Empty Then
      tboxWorkCount = DynamicControlGenerator.CreateTextBox(String.Empty, True).Location(97, 3).Size(50, 19).Create
      _panel.Controls.Add(tboxWorkCount)
      
      btn10 = DynamicControlGenerator.CreateCountButton(10).Location(153, 0).Size(50, 25).Margin(3).Create
      AddHandler btn10.Click, CreateEventHandlerToAddWorkCount(10)
      _panel.Controls.Add(btn10)
      
      btn5 = DynamicControlGenerator.CreateCountButton(5).Location(207, 0).Size(50, 25).Margin(3).Create
      AddHandler btn5.Click, CreateEventHandlerToAddWorkCount(5)
      _panel.Controls.Add(btn5)
      
      btn1 = DynamicControlGenerator.CreateCountButton(1).Location(261, 0).Size(50, 25).Margin(3).Create
      AddHandler btn1.Click, CreateEventHandlerToAddWorkCount(1)
      _panel.Controls.Add(btn1)
      
      btnM1 = DynamicControlGenerator.CreateCountButton(-1).Location(315, 0).Size(50, 25).Margin(3).Create
      AddHandler btnM1.Click, CreateEventHandlerToAddWorkCount(-1)
      _panel.Controls.Add(btnM1)
    Else
      tboxWorkCount = Nothing
      btn10 = Nothing
      btn5  = Nothing
      btn1  = Nothing
      btnM1 = Nothing
    End If
    
    ' 作業時間のExcelの列が設定されている場合、作業時間のフォームを作成する
    If params.WorkTimeCol <> String.Empty Then
      cboxHour = DynamicControlGenerator.CreateComboBox(WorkItemControls.cboxHourItems, ComboBoxStyle.DropDownList).Location(387, 2).Size(45, 20).Create
      _panel.Controls.Add(cboxHour)
      
      lblHour = DynamicControlGenerator.CreateLabel("時間").Location(437, 6).AutoSize(True).Create
      _panel.Controls.Add(lblHour)
      
      cboxMin = DynamicControlGenerator.CreateComboBox(WorkItemControls.cboxMinItems, ComboBoxStyle.DropDownList).Location(472, 2).Size(45, 20).Create
      _panel.Controls.Add(cboxMin)
      
      lblMin = DynamicControlGenerator.CreateLabel("分").Location(522, 6).AutoSize(True).Create
      _panel.Controls.Add(lblMin)
      
      btnToWriteWorkTime = DynamicControlGenerator.CreateButton("上書き").Location(547, 0).Size(60, 25).Margin(3).Create
      originalButtonColor = btnToWriteWorkTime.ForeColor
      AddHandler btnToWriteWorkTime.Click, CreateEventHandlerToWriteWorkTime()
      _panel.Controls.Add(btnToWriteWorkTime)
    Else
      cboxHour = Nothing
      lblHour  = Nothing
      cboxMin  = Nothing
      lblMin   = Nothing
      btnToWriteWorkTime = Nothing
    End If
  End Sub
  
  ''' <summary>
  ''' 指定した値を作業件数のテキストボックスにセットする。
  ''' </summary>
  Public Sub UpdateWorkCount(count As Integer)
    If Me.tboxWorkCount Is Nothing Then Return
    
    ' このメソッドが描画スレッド以外から呼び出された場合、このメソッドを描画スレッドに投げそこで処理が行われるようにする
    If Me.tboxWorkCount.InvokeRequired Then
      Me.tboxWorkCount.Invoke(
        New SetIntegerDelegate(AddressOf UpdateWorkCount),
        New Object() {count})
    Else
      Me.tboxWorkCount.Text = count.ToString
    End If
  End Sub
  
  ''' <summary>
  ''' 指定した時間に作業時間のコンボボックスの表示を更新する。
  ''' </summary>
  ''' <param name="hour"></param>
  ''' <param name="min"></param>
  Public Sub UpdateWorkTime(hour As Integer, min As Integer)
    UpdateComboBoxOfNumber(Me.cboxHour, hour)
    UpdateComboBoxOfNumber(Me.cboxMin, min)
  End Sub
  
  Public Sub ChangeColorOfUpdateWorkTimeButton(color As Color)
    If Me.btnToWriteWorkTime Is Nothing Then Return
    
    ' このメソッドが描画スレッド以外から呼び出された場合、このメソッドを描画スレッドに投げそこで処理が行われるようにする
    If Me.btnToWriteWorkTime.InvokeRequired Then
      Me.btnToWriteWorkTime.Invoke(
        New SetColorDelegate(AddressOf ChangeColorOfUpdateWorkTimeButton),
        New Object() {color})
    Else
      Me.btnToWriteWorkTime.ForeColor = color
    End If	  
  End Sub
  
  ''' <summary>
  ''' コンボボックスの表示を指定した値の要素に変換する。
  ''' </summary>
  ''' <param name="comboBox"></param>
  ''' <param name="value"></param>
  Private Sub UpdateComboBoxOfNumber(comboBox As ComboBox, value As Integer)
    If comboBox Is Nothing Then Return
    
    Dim idx As Integer = 0
    
    For i As Integer = 1 To comboBox.Items.Count - 1
      ' 引数の値に一致する要素がなかった場合に備えて、
      ' 「引数の値以下の値のうちの最大値」の要素のインデックスをセットする
      If value < Integer.Parse(comboBox.GetItemText(comboBox.Items(i))) Then
        idx = i - 1
        Exit For
      ElseIf i = comboBox.Items.Count - 1
        idx = i
        Exit For
      End If
    Next
    
    UpdateComboBox(comboBox, idx)
  End Sub
  
  ''' <summary>
  ''' コンボボックスの表示を指定したインデックスの要素に更新する。
  ''' </summary>
  ''' <param name="comboBox"></param>
  ''' <param name="idx"></param>
  Private Sub UpdateComboBox(comboBox As ComboBox, idx As Integer)
    If comboBox Is Nothing Then Return
    
    ' 描画スレッドから呼び出されなかった場合、描画スレッドに処理を移譲する
    If comboBox.InvokeRequired Then
      comboBox.Invoke(
        New SetComboBoxAndIntegerDelegate(AddressOf UpdateComboBox),
        New Object() {comboBox, idx})
    Else
      comboBox.SelectedIndex = idx
    End If
  End Sub
  
  ''' <summary>
  ''' 件数ボタンが押されたときのハンドラを生成する。
  ''' </summary>
  ''' <param name="addedCount"></param>
  Private Function CreateEventHandlerToAddWorkCount(addedCount As Integer) As EventHandler
    Return New EventHandler(
      Sub()
        Try
          manager.AddWorkCount(Me, addedCount)
        Catch ex As Exception
          MsgBox.ShowError(ex)					
        End Try
      End Sub)
  End Function
  
  ''' <summary>
  ''' 作業時間上書きボタンが押されたときのハンドラを生成する。
  ''' </summary>
  Private Function CreateEventHandlerToWriteWorkTime() As EventHandler
    Return New EventHandler(
      Sub()
        Try
          Dim hour As Integer = Integer.Parse(Me.cboxHour.SelectedItem.ToString)
          Dim min As Integer  = Integer.Parse(Me.cboxMin.SelectedItem.ToString)
          manager.UpdateWorkTime(Me, hour, min)
        Catch ex As Exception
          MsgBox.ShowError(ex)
        End Try
      End Sub)
  End Function
  
  Private Delegate Sub SetIntegerDelegate(count As Integer)
  Private Delegate Sub SetComboBoxAndIntegerDelegate(comboBox As ComboBox, idx As Integer)
  Private Delegate Sub SetColorDelegate(color As Color)
End Class
