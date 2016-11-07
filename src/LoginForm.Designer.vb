'
' 日付: 2016/05/05
'
Partial Class LoginForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.txtID = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.txtPassword = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.lblAttentionID = New System.Windows.Forms.Label()
		Me.lblAttentionPassword = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'txtID
		'
		Me.txtID.Location = New System.Drawing.Point(17, 26)
		Me.txtID.Name = "txtID"
		Me.txtID.Size = New System.Drawing.Size(200, 19)
		Me.txtID.TabIndex = 0
		'
		'label1
		'
		Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(14, 11)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(16, 12)
		Me.label1.TabIndex = 1
		Me.label1.Text = "ID"
		'
		'label2
		'
		Me.label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(14, 52)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(54, 12)
		Me.label2.TabIndex = 2
		Me.label2.Text = "Password"
		'
		'txtPassword
		'
		Me.txtPassword.Location = New System.Drawing.Point(14, 67)
		Me.txtPassword.Name = "txtPassword"
		Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.txtPassword.Size = New System.Drawing.Size(203, 19)
		Me.txtPassword.TabIndex = 3
		'
		'btnCancel
		'
		Me.btnCancel.Location = New System.Drawing.Point(142, 98)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(75, 23)
		Me.btnCancel.TabIndex = 5
		Me.btnCancel.Text = "キャンセル"
		Me.btnCancel.UseVisualStyleBackColor = true
		AddHandler Me.btnCancel.Click, AddressOf Me.BtnCancelClick
		'
		'btnLogin
		'
		Me.btnLogin.Location = New System.Drawing.Point(61, 98)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(75, 23)
		Me.btnLogin.TabIndex = 4
		Me.btnLogin.Text = "ログイン"
		Me.btnLogin.UseVisualStyleBackColor = true
		AddHandler Me.btnLogin.Click, AddressOf Me.btnLoginClick
		'
		'lblAttentionID
		'
		Me.lblAttentionID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.lblAttentionID.AutoSize = true
		Me.lblAttentionID.ForeColor = System.Drawing.Color.Red
		Me.lblAttentionID.Location = New System.Drawing.Point(36, 11)
		Me.lblAttentionID.Name = "lblAttentionID"
		Me.lblAttentionID.Size = New System.Drawing.Size(73, 12)
		Me.lblAttentionID.TabIndex = 6
		Me.lblAttentionID.Text = "※未入力です"
		Me.lblAttentionID.Visible = false
		'
		'lblAttentionPassword
		'
		Me.lblAttentionPassword.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.lblAttentionPassword.AutoSize = true
		Me.lblAttentionPassword.ForeColor = System.Drawing.Color.Red
		Me.lblAttentionPassword.Location = New System.Drawing.Point(74, 52)
		Me.lblAttentionPassword.Name = "lblAttentionPassword"
		Me.lblAttentionPassword.Size = New System.Drawing.Size(73, 12)
		Me.lblAttentionPassword.TabIndex = 7
		Me.lblAttentionPassword.Text = "※未入力です"
		Me.lblAttentionPassword.Visible = false
		'
		'LoginForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(234, 133)
		Me.Controls.Add(Me.lblAttentionPassword)
		Me.Controls.Add(Me.lblAttentionID)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.txtPassword)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.txtID)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MaximizeBox = false
		Me.MinimizeBox = false
		Me.Name = "LoginForm"
		Me.Text = "ログイン"
		AddHandler Load, AddressOf Me.LoginFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private lblAttentionID As System.Windows.Forms.Label
	Private lblAttentionPassword As System.Windows.Forms.Label
	Private btnCancel As System.Windows.Forms.Button
	Private btnLogin As System.Windows.Forms.Button
	Private txtPassword As System.Windows.Forms.TextBox
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private txtID As System.Windows.Forms.TextBox
End Class
