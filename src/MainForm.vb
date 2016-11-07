'
' 日付: 2016/05/05
'
Imports Common.Account
Imports Common.COM
Imports Common.Util
Imports WorkReport.MainForm

''' <summary>
''' 作業情報を記録するフォーム。
''' </summary>
Public Partial Class MainForm
  ''' メインフォームのシングルトンインスタンス	
  Private Shared _instance As MainForm	
  Public Shared ReadOnly Property Instance() As MainForm
    Get
      Return _instance
    End Get
  End Property
  
  ''' このアプリケーションのバージョン番号	
  Private version As Version
  ''' このアプリケーションの設定
  Private appSettings As MyProperties
  ''' ログインしているユーザの情報	
  Private userInfo As UserInfo
  ''' Excelの設定
  Private excelSettings As New ExcelProperties("./excel.properties")
  ''' Excelにアクセスするクラス
  Private excel As ExcelAccessor
  
  ''' 作業項目を表すコントロール群を管理する。
  Private _workItemManager As WorkItemManager
  Public ReadOnly Property WorkItemManager As WorkItemManager
    Get
      Return Me._workItemManager
    End Get
  End Property
  
  ''' 現在表示されている日付
  Private currentDate As Date
  
  ''' 初期処理を行ったかどうか
  Private initialized As Boolean = False
  
  Public Sub New()
    Me.InitializeComponent()
  End Sub
  
  ''' <summary>
  ''' フォーム生成時に呼び出される。
  ''' </summary>
  Sub MainFormLoad(sender As Object, e As EventArgs)
    _instance = Me
    
    ' Common.IO.Log.SetFilePath("log.txt")
    
    ' フォーム下部のテキストを消去
    Me.toolStripStatusLabel1.Text = ""
    
    ' バージョン情報取得
    version = LoginForm.Instance.Version
    ' アプリケーションプロパティ生成
    appSettings = LoginForm.Instance.Properties
    ' ユーザ情報セット
    userInfo = LoginForm.Instance.UserInfo
    ' 現在表示されている日付
    currentDate = Me.dateTimePicker1.Value
    
    Try
      ' Excelの初期化を行う
      InitExcel()
      ' 作業項目フォームの管理オブジェクトのセットアップ
      InitWorkItemManger()
      
      If initialized = False Then
        ' 作業項目のフォームを作成
        CreateWorkItemForm()
        
        ' データやセッティングをロード
        LoadTitleBar()
        LoadLabel()
        LoadSelectableDateRange()
        LoadReport()
        
        initialized = True
      End If
    Catch ex As Exception
      MsgBox.ShowError(ex)
    End Try
  End Sub
  
  ''' <summary>
  ''' フォームがアクティブになると呼び出される。
  ''' </summary>
  Sub MainFormActivated(sender As Object, e As EventArgs)
  End Sub
  
  ''' <summary>
  ''' 現在の作業項目フォームの表示が切り替わるときに行われるべき処理。
  ''' 表示を切り替えてもよい場合はTrueを返す。
  ''' </summary>
  Function MainFormExpressionChanging() As Boolean
    ' 作業時間の更新漏れがないか確認する
    If Not Me._workItemManager.WasWrittenAllWorkTime Then
      MessageBox.Show(
        "作業時間を更新していない可能性があるので確認して下さい。" & Environment.NewLine &
        "作業件数変更後は作業時間の更新が必要です。",
        "警告",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation)
      Me._workItemManager.ChangeColorOfUnwrittenWorkTimeButton
      
      Return False
    Else
      Return True
    End If	  
  End Function
  
  ''' <summary>
  ''' フォームを閉じる直前に呼び出される。
  ''' </summary>
  Sub MainFormClosing(sender As Object, e As System.ComponentModel.CancelEventArgs)
    '		' ストップウォッチが開かれてないか確認する
    '		If StopWatchForm.Visible Then
    '			Dim res As DialogResult = 
    '				MessageBox.Show(
    '  				"ストップウォッチが開かれていますが、ウィンドウを閉じてよろしいですか？",
    '  				"確認",
    '  				MessageBoxButtons.OKCancel,
    '  				MessageBoxIcon.Exclamation)
    '			If res = DialogResult.Cancel Then
    '				e.Cancel = True
    '				Return
    '			End If
    '		End If
    
    ' 表示が切り替わるときに行われるべき処理
    If Not MainFormExpressionChanging() Then
      e.Cancel = True
      Return
    End If
    
    '		' ストップウォッチのフォームがまだある場合は閉じる
    '		If StopWatchForm.Visible Then
    '			StopWatchForm.Close()
    '			' ストップウォッチフォームの終了がキャンセルされた場合
    '			If StopWatchForm.Visible Then
    '				e.Cancel = True
    '				Return
    '			End If
    '		End If
    
    Me.toolStripStatusLabel1.Text = "終了処理をしています..."
    excel.Quit
    excel = Nothing
  End Sub
  
  ''' <summary>
  ''' Excelにアクセスする準備を行う。
  ''' </summary>
  Private Sub InitExcel()
    Me.excel = New ExcelAccessor(Me.userInfo, Me.excelSettings, Me.dateTimePicker1)
    ' 書き込みスレッドの中で例外が発生した場合のイベントハンドラを設定
    Me.excel.SetWritingThreadExceptionEventHandeler(
      Sub(ex)
        Me.Invoke(
          New ThreadExceptionEventHandlerDelegate(AddressOf WritingThreadExceptionEventHandler),
          New Object() {ex})
      End Sub)
    
    Me.excel.Init()		
  End Sub
  
  ''' <summary>
  ''' Excelを読み込む。
  ''' </summary>
  ''' <returns></returns>
  Private Function ReadFromExcel(col As String) As String
    If Me.excel Is Nothing Then Throw New NullReferenceException("excel is null")
    
    If Cell.ValidColumn(col) Then
      Return Me.excel.Read(col)
    Else
      Return String.Empty
    End If
  End Function
  
  ''' <summary>
  ''' Excelに書き込む。
  ''' </summary>
  Private Sub WriteToExcel(text As String, col As String)
    If Me.excel Is Nothing Then Throw New NullReferenceException("excel is null")
    
    If Cell.ValidColumn(col) Then
      Me.excel.Write(text, col)
    End If
  End Sub
  
  ''' <summary>
  ''' 作業項目管理オブジェクトの準備を行う。
  ''' </summary>
  Private Sub InitWorkItemManger()
    If Me.excel Is Nothing Then Throw New NullReferenceException("excel is null.")
    
    If Me._workItemManager Is Nothing Then
      Me._workItemManager = New WorkItemManager(Me.excel)
    Else
      Me._workItemManager.Excel = Me.excel
    End If
  End Sub
  
  ''' <summary>
  ''' 作業項目のフォームを作成する。
  ''' </summary>
  Private Sub CreateWorkItemForm()
    If Me._workItemManager Is Nothing Then Throw New NullReferenceException("WorkItemManager is null.")
    
    Dim idx = 1
    Dim x = 13
    Dim y = 80
    
    While True
      Dim params As ExcelProperties.WorkItemParams = Me.excelSettings.GetWorkItemParams(idx)
      
      ' すべての項目が空文字になったらフォームの生成をやめる
      If params.Name = String.Empty AndAlso params.WorkCountCol = String.Empty AndAlso params.WorkTimeCol = String.Empty Then
        Exit While
      End If
      
      ' ウィンドウに作業項目のフォームを追加する
      Dim panel As Panel = Me._workItemManager.CreatePanel(params)
      panel.Location = New Point(x, y)
      Me.Controls.Add(panel)
      
      y += 28
      idx += 1
    End While
    
    ' ウィンドウのサイズをセットする
    Me.Size = New Size(653, y + 123)
  End Sub
  
  ''' <summary>
  ''' タイトルバーにアプリケーション名とバージョン番号をセットする。
  ''' </summary>
  Private Sub LoadTitleBar()
    Dim title As String = appSettings.GetValue(MyProperties.KEY_APPLICATION_TITLE).GetOrDefault("")
    Me.Text = title & " Ver." & version.ToString
  End Sub
  
  ''' <summary>
  ''' ラベル名をロードする。
  ''' </summary>
  Private Sub LoadLabel()
    ' ユーザ名
    Me.lblUserName.Text = userInfo.GetName
    ' 備考欄名
    Me.lblNote.Text = Me.excelSettings.NoteName
  End Sub
  
  ''' <summary>
  ''' 選択可能な日付の範囲をセットする。
  ''' </summary>
  Private Sub LoadSelectableDateRange()
    Me.dateTimePicker1.MinDate = Me.excelSettings.BeginDate
    Me.dateTimePicker1.MaxDate = Me.excelSettings.EndDate
  End Sub
  
  ''' <summary>
  ''' 外部に保存した作業情報を読み込んで表示する。
  ''' </summary>
  Private Sub LoadReport()
    Me._workItemManager.LoadAll
    ' 備考欄を読み込む
    Me.txtNote.Text = ReadFromExcel(Me.excelSettings.NoteCol)
  End Sub
  
  ''' <summary>
  ''' DateTimePickerの日付が変更されたときに呼び出される。
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  Sub DateTimePicker1ValueChanged(sender As Object, e As EventArgs)
    If Me.dateTimePicker1.Value = currentDate Then
      Return
    ElseIf Me.MainFormExpressionChanging() Then
      currentDate = Me.dateTimePicker1.Value
      Try
        LoadReport()
      Catch ex As Exception
        MsgBox.ShowError(ex)
      End Try
    Else
      Me.dateTimePicker1.Value = currentDate
    End If
  End Sub
  
  ''' <summary>
  ''' 備考欄を書き込む。
  ''' </summary>
  Sub BtnWriteNoteClick(sender As Object, e As EventArgs)
    Try
      WriteToExcel(txtNote.Text, Me.excelSettings.NoteCol)
      MsgBox.Show("送信しました。", "確認")
    Catch ex As Exception
      MsgBox.ShowError(ex)
    End Try
  End Sub
  
  ''' <summary>
  ''' 再読み込みボタンが押されたときに呼び出される。
  ''' </summary>
  Sub BtnReloadClick(sender As Object, e As EventArgs)
    Try
      LoadReport()	
    Catch ex As Exception
      MsgBox.ShowError(ex)
    End Try		
  End Sub
  
  ''' <summary>
  ''' 閉じるボタンが押されたときに呼び出される。
  ''' </summary>
  ''' <param name="sender"></param>
  ''' <param name="e"></param>
  Sub BtnCloseClick(sender As Object, e As EventArgs)
    Me.Close()
  End Sub
  
  ''' <summary>
  ''' 書き込みスレッド中に例外が発生した場合に呼び出される。
  ''' </summary>
  ''' <param name="ex"></param>
  Private Sub WritingThreadExceptionEventHandler(ex As Exception)
    Dim msg As String =
      "作業件数を書き込み中にエラーが発生しました。" & Environment.NewLine &
      "作業件数を元の状態に戻します。" & Environment.NewLine &
      "安全のためアプリを再起動してください。" & Environment.NewLine & Environment.NewLine &
      ex.ToString
    
    MessageBox.Show(
      msg,
      "エラー",
      MessageBoxButtons.OK,
      MessageBoxIcon.Error)
    LoadReport()
  End Sub
  
  Private Delegate Sub ThreadExceptionEventHandlerDelegate(ex As Exception)
  
  '	Sub ストップウォッチToolStripMenuItemClick(sender As Object, e As EventArgs)
  '		If StopWatchFormModel.Visible = False Then		
  '			StopWatchForm.Show()
  '		Else
  '			StopWatchForm.Activate()
  '		End If
  '	End Sub
End Class
