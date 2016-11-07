'
' 日付: 2016/05/05
'
Imports System.IO
Imports Common.Account

''' <summary>
''' ログインフォーム。
''' </summary>
Public Partial Class LoginForm
	''' ログインフォームのシングルトンインスタンス	
	Private Shared _instance As LoginForm	
	Public Shared ReadOnly Property Instance() As LoginForm
		Get
			Return _instance
		End Get
	End Property
	
	''' このアプリケーションのバージョン番号
	Private _version As Version
	Public ReadOnly Property Version() As Version
		Get
			Return _version
		End Get
	End Property
	
	''' このアプリケーションの設定ファイル
	Private _properties As MyProperties
	Public ReadOnly Property Properties() As MyProperties
		Get
			Return _properties
		End Get
	End Property
	
	''' ログインしたユーザの情報
	Private _userInfo As UserInfo
	Public ReadOnly Property UserInfo() As UserInfo
		Get
			Return _userInfo
		End Get
	End Property
	
	''' 全ユーザ情報を管理するクラス
	Private userInfoManager As UserInfoManager
	
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Sub LoginFormLoad(sender As Object, e As EventArgs)
		' フォーカスがTextBoxにあるとき、キーが押されたときに実行するコールバックをセット
		AddHandler txtID.KeyDown, New KeyEventHandler(AddressOf Me.CallbackKeyDown)
		AddHandler txtPassword.KeyDown, New KeyEventHandler(AddressOf Me.CallbackKeyDown)
		
		'Common.IO.Log.SetFilePath("log.txt")
		
		_instance = Me
		' バージョン情報取得
		_version = My.Application.Info.Version
		' アプリケーションプロパティ生成
		_properties = New MyProperties("./application.properties")
		' アップデート
		AutoUpdate()

	End Sub
	
	''' <summary>
	''' 最新バージョンファイルがある場合、アップデートスクリプトを実行する。
	''' </summary>
	Private Sub AutoUpdate()
		' アップデートを有効にしているかどうかチェックする
		Dim isUpdate As String = _properties.GetValue(MyProperties.KEY_IS_UPDATE_RUNNABLE).GetOrDefault("")
		If isUpdate.ToLower = "true" Then
			' バージョンファイルのパスと更新スクリプトのパスが設定されているかチェックする
			Dim versionFilePath As String = _properties.GetValue(MyProperties.KEY_VERSION_FILEPATH).GetOrDefault("")
			Dim exeFilesDir As String = _properties.GetValue(MyProperties.KEY_LATEST_EXE_FILES_DIR).GetOrDefault("")
			If versionFilePath <> String.Empty AndAlso File.Exists(versionFilePath) AndAlso _
				 exeFilesDir     <> String.Empty AndAlso Directory.Exists(exeFilesDir) Then
				' バージョンが更新されたならスクリプトを実行する。
				Dim update As New MyUpdate(versionFilePath, exeFilesDir)
				If update.existsUpdateVersion(_version) Then
				  MsgBox.Show(
						"最新バージョンにアップデートします。" & Environment.NewLine &
						"再起動してください。",
						"更新")
					' スクリプトを作成
					update.CreateUpdateBatch()
					Me.Close()
					' スクリプトを実行
					update.RunUpdateBatch(_version)
				End If
			End If
		End If
	End Sub
	
	''' <summary>
	''' Loginボタンが押されたときに実行する。
	''' </summary>
	Sub BtnLoginClick(sender As Object, e As EventArgs)
		Login()
	End Sub
	
	''' <summary>
	''' キャンセルボタンが押されたときに実行する。
	''' </summary>
	Sub BtnCancelClick(sender As Object, e As EventArgs)
		Me.Close
	End Sub
	
	''' <summary>
	''' キーが押されたときに実行する
	''' </summary>
	Private Sub CallbackKeyDown(sender As Object, e As KeyEventArgs)
		'Enterキーが押されているか確認
		'AltかCtrlキーが押されている時は無視する
		If e.KeyCode = Keys.Enter AndAlso Not e.Alt AndAlso Not e.Control Then
			' ログインする	
			Login()
			e.Handled = True
			e.SuppressKeyPress = True
		End If
	End Sub
	
	''' <summary>
	''' ログインする。
	''' </summary>
	Private Sub Login()
		' ユーザ情報の読み込み
		If txtID.Text = String.Empty Then
			' IDの未入力警告文を表示
			lblAttentionID.Visible = True
			lblAttentionPassword.Visible = False
		ElseIf txtPassword.Text = String.Empty
			' パスワードの未入力警告文を表示
			lblAttentionID.Visible = False
			lblAttentionPassword.Visible = True
		Else
			' 未入力警告文を非表示
			lblAttentionID.Visible = False
			lblAttentionPassword.Visible = False
			
			Try
				' ユーザ管理クラスを生成
				If userInfoManager Is Nothing Then
					userInfoManager = UserInfoManager.Create(_properties.GetValue(MyProperties.KEY_USERS_FILEPATH).GetOrDefault(""))
				End If
				
				' ID, パスワード認証を行う
				If userInfoManager.Certify(txtID.Text, txtPassword.Text) Then
					_userInfo = userInfoManager.GetUserInfo(txtID.Text, txtPassword.Text)
					Me.Hide()
					MainForm.ShowDialog()
					Me.Show()
				Else
					MsgBox.Show("IDとパスワードが一致しません。", "認証失敗")
				End If
			Catch ex As Exception
				MsgBox.ShowError(ex)
			End Try
		End If			
	End Sub
End Class
