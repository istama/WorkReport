''
'' 日付: 2016/09/10
''
'Partial Class StopWatchForm
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
'		Me.btnClose = New System.Windows.Forms.Button()
'		Me.label3 = New System.Windows.Forms.Label()
'		Me.SuspendLayout
'		'
'		'btnClose
'		'
'		Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
'		Me.btnClose.Location = New System.Drawing.Point(205, 231)
'		Me.btnClose.Name = "btnClose"
'		Me.btnClose.Size = New System.Drawing.Size(75, 23)
'		Me.btnClose.TabIndex = 10
'		Me.btnClose.Text = "閉じる"
'		Me.btnClose.UseVisualStyleBackColor = true
'		AddHandler Me.btnClose.Click, AddressOf Me.BtnCloseClick
'		'
'		'label3
'		'
'		Me.label3.AutoSize = true
'		Me.label3.Location = New System.Drawing.Point(205, 11)
'		Me.label3.Name = "label3"
'		Me.label3.Size = New System.Drawing.Size(77, 12)
'		Me.label3.TabIndex = 11
'		Me.label3.Text = "合計作業時間"
'		'
'		'StopWatchForm
'		'
'		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
'		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'		Me.ClientSize = New System.Drawing.Size(296, 262)
'		Me.Controls.Add(Me.label3)
'		Me.Controls.Add(Me.btnClose)
'		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
'		Me.MaximizeBox = false
'		Me.Name = "StopWatchForm"
'		Me.Text = "ストップウォッチ"
'		AddHandler Load, AddressOf Me.StopWatchFormLoad
'		AddHandler Closing, AddressOf Me.StopWatchFormClosing
'		Me.ResumeLayout(false)
'		Me.PerformLayout
'	End Sub
'	Private label3 As System.Windows.Forms.Label
'	Private btnClose As System.Windows.Forms.Button
'End Class
