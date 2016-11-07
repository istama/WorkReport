'
' 日付: 2016/05/05
'
Partial Class MainForm
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
	  Me.lblUserName = New System.Windows.Forms.Label()
	  Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker()
	  Me.label4 = New System.Windows.Forms.Label()
	  Me.label5 = New System.Windows.Forms.Label()
	  Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
	  Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
	  Me.btnWriteNote = New System.Windows.Forms.Button()
	  Me.txtNote = New System.Windows.Forms.TextBox()
	  Me.lblNote = New System.Windows.Forms.Label()
	  Me.btnClose = New System.Windows.Forms.Button()
	  Me.btnReload = New System.Windows.Forms.Button()
	  Me.label24 = New System.Windows.Forms.Label()
	  Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
	  Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
	  Me.statusStrip1.SuspendLayout
	  Me.menuStrip1.SuspendLayout
	  Me.SuspendLayout
	  '
	  'lblUserName
	  '
	  Me.lblUserName.Font = New System.Drawing.Font("MS UI Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
	  Me.lblUserName.Location = New System.Drawing.Point(13, 35)
	  Me.lblUserName.Name = "lblUserName"
	  Me.lblUserName.Size = New System.Drawing.Size(129, 23)
	  Me.lblUserName.TabIndex = 0
	  Me.lblUserName.Text = "名前"
	  '
	  'dateTimePicker1
	  '
	  Me.dateTimePicker1.Location = New System.Drawing.Point(408, 36)
	  Me.dateTimePicker1.Name = "dateTimePicker1"
	  Me.dateTimePicker1.Size = New System.Drawing.Size(200, 19)
	  Me.dateTimePicker1.TabIndex = 1
	  AddHandler Me.dateTimePicker1.ValueChanged, AddressOf Me.DateTimePicker1ValueChanged
	  '
	  'label4
	  '
	  Me.label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
	  	  	  Or System.Windows.Forms.AnchorStyles.Left)  _
	  	  	  Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
	  Me.label4.AutoSize = true
	  Me.label4.Location = New System.Drawing.Point(400, 65)
	  Me.label4.Name = "label4"
	  Me.label4.Size = New System.Drawing.Size(77, 12)
	  Me.label4.TabIndex = 3
	  Me.label4.Text = "合計作業時間"
	  '
	  'label5
	  '
	  Me.label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
	  	  	  Or System.Windows.Forms.AnchorStyles.Left)  _
	  	  	  Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
	  Me.label5.AutoSize = true
	  Me.label5.Location = New System.Drawing.Point(110, 65)
	  Me.label5.Name = "label5"
	  Me.label5.Size = New System.Drawing.Size(53, 12)
	  Me.label5.TabIndex = 4
	  Me.label5.Text = "作業件数"
	  '
	  'statusStrip1
	  '
	  Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
	  Me.statusStrip1.Location = New System.Drawing.Point(0, 337)
	  Me.statusStrip1.Name = "statusStrip1"
	  Me.statusStrip1.Size = New System.Drawing.Size(637, 22)
	  Me.statusStrip1.TabIndex = 5
	  Me.statusStrip1.Text = "statusStrip1"
	  '
	  'toolStripStatusLabel1
	  '
	  Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
	  Me.toolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
	  '
	  'btnWriteNote
	  '
	  Me.btnWriteNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
	  Me.btnWriteNote.Location = New System.Drawing.Point(560, 276)
	  Me.btnWriteNote.Name = "btnWriteNote"
	  Me.btnWriteNote.Size = New System.Drawing.Size(60, 25)
	  Me.btnWriteNote.TabIndex = 10
	  Me.btnWriteNote.Text = "上書き"
	  Me.btnWriteNote.UseVisualStyleBackColor = true
	  AddHandler Me.btnWriteNote.Click, AddressOf Me.BtnWriteNoteClick
	  '
	  'txtNote
	  '
	  Me.txtNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
	  Me.txtNote.Location = New System.Drawing.Point(110, 279)
	  Me.txtNote.Name = "txtNote"
	  Me.txtNote.Size = New System.Drawing.Size(430, 19)
	  Me.txtNote.TabIndex = 11
	  '
	  'lblNote
	  '
	  Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
	  Me.lblNote.AutoSize = true
	  Me.lblNote.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
	  Me.lblNote.Location = New System.Drawing.Point(16, 280)
	  Me.lblNote.Name = "lblNote"
	  Me.lblNote.Size = New System.Drawing.Size(9, 12)
	  Me.lblNote.TabIndex = 12
	  Me.lblNote.Text = " "
	  '
	  'btnClose
	  '
	  Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
	  Me.btnClose.Location = New System.Drawing.Point(560, 304)
	  Me.btnClose.Name = "btnClose"
	  Me.btnClose.Size = New System.Drawing.Size(60, 25)
	  Me.btnClose.TabIndex = 13
	  Me.btnClose.Text = "閉じる"
	  Me.btnClose.UseVisualStyleBackColor = true
	  AddHandler Me.btnClose.Click, AddressOf Me.BtnCloseClick
	  '
	  'btnReload
	  '
	  Me.btnReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
	  Me.btnReload.Location = New System.Drawing.Point(492, 304)
	  Me.btnReload.Name = "btnReload"
	  Me.btnReload.Size = New System.Drawing.Size(60, 25)
	  Me.btnReload.TabIndex = 14
	  Me.btnReload.Text = "再読込"
	  Me.btnReload.UseVisualStyleBackColor = true
	  AddHandler Me.btnReload.Click, AddressOf Me.BtnReloadClick
	  '
	  'label24
	  '
	  Me.label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
	  Me.label24.AutoSize = true
	  Me.label24.Location = New System.Drawing.Point(110, 303)
	  Me.label24.Name = "label24"
	  Me.label24.Size = New System.Drawing.Size(308, 12)
	  Me.label24.TabIndex = 15
	  Me.label24.Text = "※備考を追記するときは元々ある文章を消さずに続けて書いてね"
	  '
	  'menuStrip1
	  '
	  Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1})
	  Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
	  Me.menuStrip1.Name = "menuStrip1"
	  Me.menuStrip1.Size = New System.Drawing.Size(637, 26)
	  Me.menuStrip1.TabIndex = 16
	  Me.menuStrip1.Text = "menuStrip1"
	  '
	  'toolStripMenuItem1
	  '
	  Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
	  Me.toolStripMenuItem1.Size = New System.Drawing.Size(56, 22)
	  Me.toolStripMenuItem1.Text = "ツール"
	  '
	  'MainForm
	  '
	  Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
	  Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	  Me.ClientSize = New System.Drawing.Size(637, 359)
	  Me.Controls.Add(Me.label24)
	  Me.Controls.Add(Me.btnReload)
	  Me.Controls.Add(Me.btnClose)
	  Me.Controls.Add(Me.lblNote)
	  Me.Controls.Add(Me.txtNote)
	  Me.Controls.Add(Me.btnWriteNote)
	  Me.Controls.Add(Me.statusStrip1)
	  Me.Controls.Add(Me.menuStrip1)
	  Me.Controls.Add(Me.label5)
	  Me.Controls.Add(Me.label4)
	  Me.Controls.Add(Me.dateTimePicker1)
	  Me.Controls.Add(Me.lblUserName)
	  Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
	  Me.MainMenuStrip = Me.menuStrip1
	  Me.MaximizeBox = false
	  Me.Name = "MainForm"
	  Me.Text = "WorkReport"
	  AddHandler Activated, AddressOf Me.MainFormActivated
	  AddHandler Closing, AddressOf Me.MainFormClosing
	  AddHandler Load, AddressOf Me.MainFormLoad
	  Me.statusStrip1.ResumeLayout(false)
	  Me.statusStrip1.PerformLayout
	  Me.menuStrip1.ResumeLayout(false)
	  Me.menuStrip1.PerformLayout
	  Me.ResumeLayout(false)
	  Me.PerformLayout
	End Sub
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private label24 As System.Windows.Forms.Label
	Private btnReload As System.Windows.Forms.Button
	Private btnClose As System.Windows.Forms.Button
	Private lblNote As System.Windows.Forms.Label
	Private txtNote As System.Windows.Forms.TextBox
	Private btnWriteNote As System.Windows.Forms.Button
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private lblUserName As System.Windows.Forms.Label
	
End Class
