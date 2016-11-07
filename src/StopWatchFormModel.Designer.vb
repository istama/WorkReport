''
'' 日付: 2016/05/22
''
'Partial Class StopWatchFormModel
'	Inherits System.Windows.Forms.Form
'	
'	''' <summary>
'	''' Designer variable used to keep track of non-visual components.
'	''' </summary>
'	Private components As System.ComponentModel.IContainer
'	
'	''' <summary>
'	''' Disposes resources used by the form.
'	''' </summary>
'	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
'	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'		If disposing Then
'			If components IsNot Nothing Then
'				components.Dispose()
'			End If
'		End If
'		MyBase.Dispose(disposing)
'	End Sub
'	
'	''' <summary>
'	''' This method is required for Windows Forms designer support.
'	''' Do not change the method contents inside the source code editor. The Forms designer might
'	''' not be able to load this method if it was changed manually.
'	''' </summary>
'	Private Sub InitializeComponent()
'		Me.lblItemName1 = New System.Windows.Forms.Label()
'		Me.btnTimer1 = New System.Windows.Forms.Button()
'		Me.panel1 = New System.Windows.Forms.Panel()
'		Me.lblTimer1 = New System.Windows.Forms.Label()
'		Me.label3 = New System.Windows.Forms.Label()
'		Me.panel2 = New System.Windows.Forms.Panel()
'		Me.lblTimer2 = New System.Windows.Forms.Label()
'		Me.btnTimer2 = New System.Windows.Forms.Button()
'		Me.lblItemName2 = New System.Windows.Forms.Label()
'		Me.panel3 = New System.Windows.Forms.Panel()
'		Me.lblTimer3 = New System.Windows.Forms.Label()
'		Me.btnTimer3 = New System.Windows.Forms.Button()
'		Me.lblItemName3 = New System.Windows.Forms.Label()
'		Me.panel4 = New System.Windows.Forms.Panel()
'		Me.lblTimer4 = New System.Windows.Forms.Label()
'		Me.btnTimer4 = New System.Windows.Forms.Button()
'		Me.lblItemName4 = New System.Windows.Forms.Label()
'		Me.panel5 = New System.Windows.Forms.Panel()
'		Me.lblTimer5 = New System.Windows.Forms.Label()
'		Me.btnTimer5 = New System.Windows.Forms.Button()
'		Me.lblItemName5 = New System.Windows.Forms.Label()
'		Me.panel6 = New System.Windows.Forms.Panel()
'		Me.lblTimer6 = New System.Windows.Forms.Label()
'		Me.btnTimer6 = New System.Windows.Forms.Button()
'		Me.lblItemName6 = New System.Windows.Forms.Label()
'		Me.panel7 = New System.Windows.Forms.Panel()
'		Me.lblTimer7 = New System.Windows.Forms.Label()
'		Me.btnTimer7 = New System.Windows.Forms.Button()
'		Me.lblItemName7 = New System.Windows.Forms.Label()
'		Me.btnClose = New System.Windows.Forms.Button()
'		Me.panel1.SuspendLayout
'		Me.panel2.SuspendLayout
'		Me.panel3.SuspendLayout
'		Me.panel4.SuspendLayout
'		Me.panel5.SuspendLayout
'		Me.panel6.SuspendLayout
'		Me.panel7.SuspendLayout
'		Me.SuspendLayout
'		'
'		'lblItemName1
'		'
'		Me.lblItemName1.AutoSize = true
'		Me.lblItemName1.Location = New System.Drawing.Point(3, 5)
'		Me.lblItemName1.Name = "lblItemName1"
'		Me.lblItemName1.Size = New System.Drawing.Size(62, 12)
'		Me.lblItemName1.TabIndex = 0
'		Me.lblItemName1.Text = "ItemName1"
'		'
'		'btnTimer1
'		'
'		Me.btnTimer1.Location = New System.Drawing.Point(112, 0)
'		Me.btnTimer1.Name = "btnTimer1"
'		Me.btnTimer1.Size = New System.Drawing.Size(75, 23)
'		Me.btnTimer1.TabIndex = 1
'		Me.btnTimer1.Text = "スタート"
'		Me.btnTimer1.UseVisualStyleBackColor = true
'		'
'		'panel1
'		'
'		Me.panel1.Controls.Add(Me.lblTimer1)
'		Me.panel1.Controls.Add(Me.btnTimer1)
'		Me.panel1.Controls.Add(Me.lblItemName1)
'		Me.panel1.Location = New System.Drawing.Point(12, 28)
'		Me.panel1.Name = "panel1"
'		Me.panel1.Size = New System.Drawing.Size(270, 23)
'		Me.panel1.TabIndex = 2
'		'
'		'lblTimer1
'		'
'		Me.lblTimer1.AutoSize = true
'		Me.lblTimer1.Location = New System.Drawing.Point(210, 5)
'		Me.lblTimer1.Name = "lblTimer1"
'		Me.lblTimer1.Size = New System.Drawing.Size(45, 12)
'		Me.lblTimer1.TabIndex = 3
'		Me.lblTimer1.Text = "00:00:00"
'		'
'		'label3
'		'
'		Me.label3.AutoSize = true
'		Me.label3.Location = New System.Drawing.Point(205, 11)
'		Me.label3.Name = "label3"
'		Me.label3.Size = New System.Drawing.Size(77, 12)
'		Me.label3.TabIndex = 3
'		Me.label3.Text = "合計作業時間"
'		AddHandler Me.label3.Click, AddressOf Me.Label3Click
'		'
'		'panel2
'		'
'		Me.panel2.Controls.Add(Me.lblTimer2)
'		Me.panel2.Controls.Add(Me.btnTimer2)
'		Me.panel2.Controls.Add(Me.lblItemName2)
'		Me.panel2.Location = New System.Drawing.Point(12, 57)
'		Me.panel2.Name = "panel2"
'		Me.panel2.Size = New System.Drawing.Size(270, 23)
'		Me.panel2.TabIndex = 4
'		'
'		'lblTimer2
'		'
'		Me.lblTimer2.AutoSize = true
'		Me.lblTimer2.Location = New System.Drawing.Point(210, 5)
'		Me.lblTimer2.Name = "lblTimer2"
'		Me.lblTimer2.Size = New System.Drawing.Size(45, 12)
'		Me.lblTimer2.TabIndex = 3
'		Me.lblTimer2.Text = "00:00:00"
'		'
'		'btnTimer2
'		'
'		Me.btnTimer2.Location = New System.Drawing.Point(112, 0)
'		Me.btnTimer2.Name = "btnTimer2"
'		Me.btnTimer2.Size = New System.Drawing.Size(75, 23)
'		Me.btnTimer2.TabIndex = 1
'		Me.btnTimer2.Text = "スタート"
'		Me.btnTimer2.UseVisualStyleBackColor = true
'		'
'		'lblItemName2
'		'
'		Me.lblItemName2.AutoSize = true
'		Me.lblItemName2.Location = New System.Drawing.Point(3, 5)
'		Me.lblItemName2.Name = "lblItemName2"
'		Me.lblItemName2.Size = New System.Drawing.Size(62, 12)
'		Me.lblItemName2.TabIndex = 0
'		Me.lblItemName2.Text = "ItemName1"
'		'
'		'panel3
'		'
'		Me.panel3.Controls.Add(Me.lblTimer3)
'		Me.panel3.Controls.Add(Me.btnTimer3)
'		Me.panel3.Controls.Add(Me.lblItemName3)
'		Me.panel3.Location = New System.Drawing.Point(12, 86)
'		Me.panel3.Name = "panel3"
'		Me.panel3.Size = New System.Drawing.Size(270, 23)
'		Me.panel3.TabIndex = 5
'		'
'		'lblTimer3
'		'
'		Me.lblTimer3.AutoSize = true
'		Me.lblTimer3.Location = New System.Drawing.Point(210, 5)
'		Me.lblTimer3.Name = "lblTimer3"
'		Me.lblTimer3.Size = New System.Drawing.Size(45, 12)
'		Me.lblTimer3.TabIndex = 3
'		Me.lblTimer3.Text = "00:00:00"
'		'
'		'btnTimer3
'		'
'		Me.btnTimer3.Location = New System.Drawing.Point(112, 0)
'		Me.btnTimer3.Name = "btnTimer3"
'		Me.btnTimer3.Size = New System.Drawing.Size(75, 23)
'		Me.btnTimer3.TabIndex = 1
'		Me.btnTimer3.Text = "スタート"
'		Me.btnTimer3.UseVisualStyleBackColor = true
'		'
'		'lblItemName3
'		'
'		Me.lblItemName3.AutoSize = true
'		Me.lblItemName3.Location = New System.Drawing.Point(3, 5)
'		Me.lblItemName3.Name = "lblItemName3"
'		Me.lblItemName3.Size = New System.Drawing.Size(62, 12)
'		Me.lblItemName3.TabIndex = 0
'		Me.lblItemName3.Text = "ItemName1"
'		'
'		'panel4
'		'
'		Me.panel4.Controls.Add(Me.lblTimer4)
'		Me.panel4.Controls.Add(Me.btnTimer4)
'		Me.panel4.Controls.Add(Me.lblItemName4)
'		Me.panel4.Location = New System.Drawing.Point(12, 115)
'		Me.panel4.Name = "panel4"
'		Me.panel4.Size = New System.Drawing.Size(270, 23)
'		Me.panel4.TabIndex = 6
'		'
'		'lblTimer4
'		'
'		Me.lblTimer4.AutoSize = true
'		Me.lblTimer4.Location = New System.Drawing.Point(210, 5)
'		Me.lblTimer4.Name = "lblTimer4"
'		Me.lblTimer4.Size = New System.Drawing.Size(45, 12)
'		Me.lblTimer4.TabIndex = 3
'		Me.lblTimer4.Text = "00:00:00"
'		'
'		'btnTimer4
'		'
'		Me.btnTimer4.Location = New System.Drawing.Point(112, 0)
'		Me.btnTimer4.Name = "btnTimer4"
'		Me.btnTimer4.Size = New System.Drawing.Size(75, 23)
'		Me.btnTimer4.TabIndex = 1
'		Me.btnTimer4.Text = "スタート"
'		Me.btnTimer4.UseVisualStyleBackColor = true
'		'
'		'lblItemName4
'		'
'		Me.lblItemName4.AutoSize = true
'		Me.lblItemName4.Location = New System.Drawing.Point(3, 5)
'		Me.lblItemName4.Name = "lblItemName4"
'		Me.lblItemName4.Size = New System.Drawing.Size(62, 12)
'		Me.lblItemName4.TabIndex = 0
'		Me.lblItemName4.Text = "ItemName1"
'		'
'		'panel5
'		'
'		Me.panel5.Controls.Add(Me.lblTimer5)
'		Me.panel5.Controls.Add(Me.btnTimer5)
'		Me.panel5.Controls.Add(Me.lblItemName5)
'		Me.panel5.Location = New System.Drawing.Point(12, 144)
'		Me.panel5.Name = "panel5"
'		Me.panel5.Size = New System.Drawing.Size(270, 23)
'		Me.panel5.TabIndex = 5
'		'
'		'lblTimer5
'		'
'		Me.lblTimer5.AutoSize = true
'		Me.lblTimer5.Location = New System.Drawing.Point(210, 5)
'		Me.lblTimer5.Name = "lblTimer5"
'		Me.lblTimer5.Size = New System.Drawing.Size(45, 12)
'		Me.lblTimer5.TabIndex = 3
'		Me.lblTimer5.Text = "00:00:00"
'		'
'		'btnTimer5
'		'
'		Me.btnTimer5.Location = New System.Drawing.Point(112, 0)
'		Me.btnTimer5.Name = "btnTimer5"
'		Me.btnTimer5.Size = New System.Drawing.Size(75, 23)
'		Me.btnTimer5.TabIndex = 1
'		Me.btnTimer5.Text = "スタート"
'		Me.btnTimer5.UseVisualStyleBackColor = true
'		'
'		'lblItemName5
'		'
'		Me.lblItemName5.AutoSize = true
'		Me.lblItemName5.Location = New System.Drawing.Point(3, 5)
'		Me.lblItemName5.Name = "lblItemName5"
'		Me.lblItemName5.Size = New System.Drawing.Size(62, 12)
'		Me.lblItemName5.TabIndex = 0
'		Me.lblItemName5.Text = "ItemName1"
'		'
'		'panel6
'		'
'		Me.panel6.Controls.Add(Me.lblTimer6)
'		Me.panel6.Controls.Add(Me.btnTimer6)
'		Me.panel6.Controls.Add(Me.lblItemName6)
'		Me.panel6.Location = New System.Drawing.Point(12, 173)
'		Me.panel6.Name = "panel6"
'		Me.panel6.Size = New System.Drawing.Size(270, 23)
'		Me.panel6.TabIndex = 7
'		'
'		'lblTimer6
'		'
'		Me.lblTimer6.AutoSize = true
'		Me.lblTimer6.Location = New System.Drawing.Point(210, 5)
'		Me.lblTimer6.Name = "lblTimer6"
'		Me.lblTimer6.Size = New System.Drawing.Size(45, 12)
'		Me.lblTimer6.TabIndex = 3
'		Me.lblTimer6.Text = "00:00:00"
'		'
'		'btnTimer6
'		'
'		Me.btnTimer6.Location = New System.Drawing.Point(112, 0)
'		Me.btnTimer6.Name = "btnTimer6"
'		Me.btnTimer6.Size = New System.Drawing.Size(75, 23)
'		Me.btnTimer6.TabIndex = 1
'		Me.btnTimer6.Text = "スタート"
'		Me.btnTimer6.UseVisualStyleBackColor = true
'		'
'		'lblItemName6
'		'
'		Me.lblItemName6.AutoSize = true
'		Me.lblItemName6.Location = New System.Drawing.Point(3, 5)
'		Me.lblItemName6.Name = "lblItemName6"
'		Me.lblItemName6.Size = New System.Drawing.Size(62, 12)
'		Me.lblItemName6.TabIndex = 0
'		Me.lblItemName6.Text = "ItemName1"
'		'
'		'panel7
'		'
'		Me.panel7.Controls.Add(Me.lblTimer7)
'		Me.panel7.Controls.Add(Me.btnTimer7)
'		Me.panel7.Controls.Add(Me.lblItemName7)
'		Me.panel7.Location = New System.Drawing.Point(12, 202)
'		Me.panel7.Name = "panel7"
'		Me.panel7.Size = New System.Drawing.Size(270, 23)
'		Me.panel7.TabIndex = 8
'		'
'		'lblTimer7
'		'
'		Me.lblTimer7.AutoSize = true
'		Me.lblTimer7.Location = New System.Drawing.Point(210, 5)
'		Me.lblTimer7.Name = "lblTimer7"
'		Me.lblTimer7.Size = New System.Drawing.Size(45, 12)
'		Me.lblTimer7.TabIndex = 3
'		Me.lblTimer7.Text = "00:00:00"
'		'
'		'btnTimer7
'		'
'		Me.btnTimer7.Location = New System.Drawing.Point(112, 0)
'		Me.btnTimer7.Name = "btnTimer7"
'		Me.btnTimer7.Size = New System.Drawing.Size(75, 23)
'		Me.btnTimer7.TabIndex = 1
'		Me.btnTimer7.Text = "スタート"
'		Me.btnTimer7.UseVisualStyleBackColor = true
'		'
'		'lblItemName7
'		'
'		Me.lblItemName7.AutoSize = true
'		Me.lblItemName7.Location = New System.Drawing.Point(3, 5)
'		Me.lblItemName7.Name = "lblItemName7"
'		Me.lblItemName7.Size = New System.Drawing.Size(62, 12)
'		Me.lblItemName7.TabIndex = 0
'		Me.lblItemName7.Text = "ItemName1"
'		'
'		'btnClose
'		'
'		Me.btnClose.Location = New System.Drawing.Point(205, 231)
'		Me.btnClose.Name = "btnClose"
'		Me.btnClose.Size = New System.Drawing.Size(75, 23)
'		Me.btnClose.TabIndex = 9
'		Me.btnClose.Text = "閉じる"
'		Me.btnClose.UseVisualStyleBackColor = true
'		AddHandler Me.btnClose.Click, AddressOf Me.BtnCloseClick
'		'
'		'TimerForm
'		'
'		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
'		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'		Me.ClientSize = New System.Drawing.Size(296, 262)
'		Me.Controls.Add(Me.btnClose)
'		Me.Controls.Add(Me.panel7)
'		Me.Controls.Add(Me.panel6)
'		Me.Controls.Add(Me.panel5)
'		Me.Controls.Add(Me.panel4)
'		Me.Controls.Add(Me.panel3)
'		Me.Controls.Add(Me.panel2)
'		Me.Controls.Add(Me.label3)
'		Me.Controls.Add(Me.panel1)
'		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
'		Me.MaximizeBox = false
'		Me.Name = "TimerForm"
'		Me.Text = "ストップウォッチ"
'		AddHandler Closing, AddressOf Me.TimerFormClosing
'		AddHandler Load, AddressOf Me.TimerFormLoad
'		Me.panel1.ResumeLayout(false)
'		Me.panel1.PerformLayout
'		Me.panel2.ResumeLayout(false)
'		Me.panel2.PerformLayout
'		Me.panel3.ResumeLayout(false)
'		Me.panel3.PerformLayout
'		Me.panel4.ResumeLayout(false)
'		Me.panel4.PerformLayout
'		Me.panel5.ResumeLayout(false)
'		Me.panel5.PerformLayout
'		Me.panel6.ResumeLayout(false)
'		Me.panel6.PerformLayout
'		Me.panel7.ResumeLayout(false)
'		Me.panel7.PerformLayout
'		Me.ResumeLayout(false)
'		Me.PerformLayout
'	End Sub
'	Private btnClose As System.Windows.Forms.Button
'	Private lblItemName7 As System.Windows.Forms.Label
'	Private btnTimer7 As System.Windows.Forms.Button
'	Private lblTimer7 As System.Windows.Forms.Label
'	Private panel7 As System.Windows.Forms.Panel
'	Private lblItemName6 As System.Windows.Forms.Label
'	Private btnTimer6 As System.Windows.Forms.Button
'	Private lblTimer6 As System.Windows.Forms.Label
'	Private panel6 As System.Windows.Forms.Panel
'	Private lblItemName5 As System.Windows.Forms.Label
'	Private btnTimer5 As System.Windows.Forms.Button
'	Private lblTimer5 As System.Windows.Forms.Label
'	Private panel5 As System.Windows.Forms.Panel
'	Private lblItemName4 As System.Windows.Forms.Label
'	Private btnTimer4 As System.Windows.Forms.Button
'	Private lblTimer4 As System.Windows.Forms.Label
'	Private panel4 As System.Windows.Forms.Panel
'	Private lblItemName3 As System.Windows.Forms.Label
'	Private btnTimer3 As System.Windows.Forms.Button
'	Private lblTimer3 As System.Windows.Forms.Label
'	Private panel3 As System.Windows.Forms.Panel
'	Private lblItemName2 As System.Windows.Forms.Label
'	Private btnTimer2 As System.Windows.Forms.Button
'	Private lblTimer2 As System.Windows.Forms.Label
'	Private panel2 As System.Windows.Forms.Panel
'	Private label3 As System.Windows.Forms.Label
'	Private lblTimer1 As System.Windows.Forms.Label
'	Private panel1 As System.Windows.Forms.Panel
'	Private btnTimer1 As System.Windows.Forms.Button
'	Private lblItemName1 As System.Windows.Forms.Label
'End Class
