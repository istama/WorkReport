'
' 日付: 2016/09/06
'
Partial Class MainFormModel
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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.txtWorkCount1 = New System.Windows.Forms.TextBox()
		Me.btnWriteWorkTime1 = New System.Windows.Forms.Button()
		Me.label3 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.cboxWorkTimeByMinute1 = New System.Windows.Forms.ComboBox()
		Me.cboxWorkTimeByHour1 = New System.Windows.Forms.ComboBox()
		Me.btnMinus1_1 = New System.Windows.Forms.Button()
		Me.btnPlus1_1 = New System.Windows.Forms.Button()
		Me.btnPlus5_1 = New System.Windows.Forms.Button()
		Me.btnPlus10_1 = New System.Windows.Forms.Button()
		Me.lblItemName1 = New System.Windows.Forms.Label()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.txtWorkCount2 = New System.Windows.Forms.TextBox()
		Me.btnWriteWorkTime2 = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label6 = New System.Windows.Forms.Label()
		Me.cboxWorkTimeByMinute2 = New System.Windows.Forms.ComboBox()
		Me.cboxWorkTimeByHour2 = New System.Windows.Forms.ComboBox()
		Me.btnMinus1_2 = New System.Windows.Forms.Button()
		Me.btnPlus1_2 = New System.Windows.Forms.Button()
		Me.btnPlus5_2 = New System.Windows.Forms.Button()
		Me.btnPlus10_2 = New System.Windows.Forms.Button()
		Me.lblItemName2 = New System.Windows.Forms.Label()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.txtWorkCount3 = New System.Windows.Forms.TextBox()
		Me.btnWriteWorkTime3 = New System.Windows.Forms.Button()
		Me.label8 = New System.Windows.Forms.Label()
		Me.label9 = New System.Windows.Forms.Label()
		Me.cboxWorkTimeByMinute3 = New System.Windows.Forms.ComboBox()
		Me.cboxWorkTimeByHour3 = New System.Windows.Forms.ComboBox()
		Me.btnMinus1_3 = New System.Windows.Forms.Button()
		Me.btnPlus1_3 = New System.Windows.Forms.Button()
		Me.btnPlus5_3 = New System.Windows.Forms.Button()
		Me.btnPlus10_3 = New System.Windows.Forms.Button()
		Me.lblItemName3 = New System.Windows.Forms.Label()
		Me.panel4 = New System.Windows.Forms.Panel()
		Me.txtWorkCount4 = New System.Windows.Forms.TextBox()
		Me.btnWriteWorkTime4 = New System.Windows.Forms.Button()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.cboxWorkTimeByMinute4 = New System.Windows.Forms.ComboBox()
		Me.cboxWorkTimeByHour4 = New System.Windows.Forms.ComboBox()
		Me.btnMinus1_4 = New System.Windows.Forms.Button()
		Me.btnPlus1_4 = New System.Windows.Forms.Button()
		Me.btnPlus5_4 = New System.Windows.Forms.Button()
		Me.btnPlus10_4 = New System.Windows.Forms.Button()
		Me.lblItemName4 = New System.Windows.Forms.Label()
		Me.panel5 = New System.Windows.Forms.Panel()
		Me.txtWorkCount5 = New System.Windows.Forms.TextBox()
		Me.btnWriteWorkTime5 = New System.Windows.Forms.Button()
		Me.label14 = New System.Windows.Forms.Label()
		Me.label15 = New System.Windows.Forms.Label()
		Me.cboxWorkTimeByMinute5 = New System.Windows.Forms.ComboBox()
		Me.cboxWorkTimeByHour5 = New System.Windows.Forms.ComboBox()
		Me.btnMinus1_5 = New System.Windows.Forms.Button()
		Me.btnPlus1_5 = New System.Windows.Forms.Button()
		Me.btnPlus5_5 = New System.Windows.Forms.Button()
		Me.btnPlus10_5 = New System.Windows.Forms.Button()
		Me.lblItemName5 = New System.Windows.Forms.Label()
		Me.panel6 = New System.Windows.Forms.Panel()
		Me.txtWorkCount6 = New System.Windows.Forms.TextBox()
		Me.btnWriteWorkTime6 = New System.Windows.Forms.Button()
		Me.label17 = New System.Windows.Forms.Label()
		Me.label18 = New System.Windows.Forms.Label()
		Me.cboxWorkTimeByMinute6 = New System.Windows.Forms.ComboBox()
		Me.cboxWorkTimeByHour6 = New System.Windows.Forms.ComboBox()
		Me.btnMinus1_6 = New System.Windows.Forms.Button()
		Me.btnPlus1_6 = New System.Windows.Forms.Button()
		Me.btnPlus5_6 = New System.Windows.Forms.Button()
		Me.btnPlus10_6 = New System.Windows.Forms.Button()
		Me.lblItemName6 = New System.Windows.Forms.Label()
		Me.btnWriteNote = New System.Windows.Forms.Button()
		Me.txtNote = New System.Windows.Forms.TextBox()
		Me.lblNote = New System.Windows.Forms.Label()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnReload = New System.Windows.Forms.Button()
		Me.label24 = New System.Windows.Forms.Label()
		Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ストップウォッチToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.panel7 = New System.Windows.Forms.Panel()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.button1 = New System.Windows.Forms.Button()
		Me.label7 = New System.Windows.Forms.Label()
		Me.label10 = New System.Windows.Forms.Label()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.comboBox2 = New System.Windows.Forms.ComboBox()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.button5 = New System.Windows.Forms.Button()
		Me.label13 = New System.Windows.Forms.Label()
		Me.panel1.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.panel2.SuspendLayout
		Me.panel3.SuspendLayout
		Me.panel4.SuspendLayout
		Me.panel5.SuspendLayout
		Me.panel6.SuspendLayout
		Me.menuStrip1.SuspendLayout
		Me.panel7.SuspendLayout
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
		'
		'panel1
		'
		Me.panel1.Controls.Add(Me.txtWorkCount1)
		Me.panel1.Controls.Add(Me.btnWriteWorkTime1)
		Me.panel1.Controls.Add(Me.label3)
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.cboxWorkTimeByMinute1)
		Me.panel1.Controls.Add(Me.cboxWorkTimeByHour1)
		Me.panel1.Controls.Add(Me.btnMinus1_1)
		Me.panel1.Controls.Add(Me.btnPlus1_1)
		Me.panel1.Controls.Add(Me.btnPlus5_1)
		Me.panel1.Controls.Add(Me.btnPlus10_1)
		Me.panel1.Controls.Add(Me.lblItemName1)
		Me.panel1.Location = New System.Drawing.Point(13, 80)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(618, 25)
		Me.panel1.TabIndex = 2
		'
		'txtWorkCount1
		'
		Me.txtWorkCount1.Location = New System.Drawing.Point(97, 3)
		Me.txtWorkCount1.Name = "txtWorkCount1"
		Me.txtWorkCount1.ReadOnly = true
		Me.txtWorkCount1.Size = New System.Drawing.Size(50, 19)
		Me.txtWorkCount1.TabIndex = 3
		'
		'btnWriteWorkTime1
		'
		Me.btnWriteWorkTime1.Location = New System.Drawing.Point(557, 0)
		Me.btnWriteWorkTime1.Name = "btnWriteWorkTime1"
		Me.btnWriteWorkTime1.Size = New System.Drawing.Size(60, 25)
		Me.btnWriteWorkTime1.TabIndex = 9
		Me.btnWriteWorkTime1.Text = "上書き"
		Me.btnWriteWorkTime1.UseVisualStyleBackColor = true
		'
		'label3
		'
		Me.label3.AutoSize = true
		Me.label3.Location = New System.Drawing.Point(532, 6)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(17, 12)
		Me.label3.TabIndex = 8
		Me.label3.Text = "分"
		'
		'label2
		'
		Me.label2.AutoSize = true
		Me.label2.Location = New System.Drawing.Point(442, 6)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(29, 12)
		Me.label2.TabIndex = 7
		Me.label2.Text = "時間"
		'
		'cboxWorkTimeByMinute1
		'
		Me.cboxWorkTimeByMinute1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByMinute1.FormattingEnabled = true
		Me.cboxWorkTimeByMinute1.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
		Me.cboxWorkTimeByMinute1.Location = New System.Drawing.Point(477, 2)
		Me.cboxWorkTimeByMinute1.Name = "cboxWorkTimeByMinute1"
		Me.cboxWorkTimeByMinute1.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByMinute1.TabIndex = 6
		'
		'cboxWorkTimeByHour1
		'
		Me.cboxWorkTimeByHour1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByHour1.FormattingEnabled = true
		Me.cboxWorkTimeByHour1.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
		Me.cboxWorkTimeByHour1.Location = New System.Drawing.Point(387, 2)
		Me.cboxWorkTimeByHour1.Name = "cboxWorkTimeByHour1"
		Me.cboxWorkTimeByHour1.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByHour1.TabIndex = 5
		'
		'btnMinus1_1
		'
		Me.btnMinus1_1.Location = New System.Drawing.Point(315, 0)
		Me.btnMinus1_1.Name = "btnMinus1_1"
		Me.btnMinus1_1.Size = New System.Drawing.Size(50, 25)
		Me.btnMinus1_1.TabIndex = 4
		Me.btnMinus1_1.Text = "-1"
		Me.btnMinus1_1.UseVisualStyleBackColor = true
		'
		'btnPlus1_1
		'
		Me.btnPlus1_1.Location = New System.Drawing.Point(261, 0)
		Me.btnPlus1_1.Name = "btnPlus1_1"
		Me.btnPlus1_1.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus1_1.TabIndex = 3
		Me.btnPlus1_1.Text = "+1"
		Me.btnPlus1_1.UseVisualStyleBackColor = true
		'
		'btnPlus5_1
		'
		Me.btnPlus5_1.Location = New System.Drawing.Point(207, 0)
		Me.btnPlus5_1.Name = "btnPlus5_1"
		Me.btnPlus5_1.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus5_1.TabIndex = 2
		Me.btnPlus5_1.Text = "+5"
		Me.btnPlus5_1.UseVisualStyleBackColor = true
		'
		'btnPlus10_1
		'
		Me.btnPlus10_1.Location = New System.Drawing.Point(153, 0)
		Me.btnPlus10_1.Name = "btnPlus10_1"
		Me.btnPlus10_1.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus10_1.TabIndex = 1
		Me.btnPlus10_1.Text = "+10"
		Me.btnPlus10_1.UseVisualStyleBackColor = true
		'
		'lblItemName1
		'
		Me.lblItemName1.AutoSize = true
		Me.lblItemName1.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.lblItemName1.Location = New System.Drawing.Point(3, 6)
		Me.lblItemName1.Name = "lblItemName1"
		Me.lblItemName1.Size = New System.Drawing.Size(9, 12)
		Me.lblItemName1.TabIndex = 0
		Me.lblItemName1.Text = " "
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
		Me.statusStrip1.Size = New System.Drawing.Size(647, 22)
		Me.statusStrip1.TabIndex = 5
		Me.statusStrip1.Text = "statusStrip1"
		'
		'toolStripStatusLabel1
		'
		Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
		Me.toolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
		'
		'panel2
		'
		Me.panel2.Controls.Add(Me.txtWorkCount2)
		Me.panel2.Controls.Add(Me.btnWriteWorkTime2)
		Me.panel2.Controls.Add(Me.label1)
		Me.panel2.Controls.Add(Me.label6)
		Me.panel2.Controls.Add(Me.cboxWorkTimeByMinute2)
		Me.panel2.Controls.Add(Me.cboxWorkTimeByHour2)
		Me.panel2.Controls.Add(Me.btnMinus1_2)
		Me.panel2.Controls.Add(Me.btnPlus1_2)
		Me.panel2.Controls.Add(Me.btnPlus5_2)
		Me.panel2.Controls.Add(Me.btnPlus10_2)
		Me.panel2.Controls.Add(Me.lblItemName2)
		Me.panel2.Location = New System.Drawing.Point(13, 108)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(618, 25)
		Me.panel2.TabIndex = 6
		'
		'txtWorkCount2
		'
		Me.txtWorkCount2.Location = New System.Drawing.Point(97, 3)
		Me.txtWorkCount2.Name = "txtWorkCount2"
		Me.txtWorkCount2.ReadOnly = true
		Me.txtWorkCount2.Size = New System.Drawing.Size(50, 19)
		Me.txtWorkCount2.TabIndex = 3
		'
		'btnWriteWorkTime2
		'
		Me.btnWriteWorkTime2.Location = New System.Drawing.Point(557, 0)
		Me.btnWriteWorkTime2.Name = "btnWriteWorkTime2"
		Me.btnWriteWorkTime2.Size = New System.Drawing.Size(60, 25)
		Me.btnWriteWorkTime2.TabIndex = 9
		Me.btnWriteWorkTime2.Text = "上書き"
		Me.btnWriteWorkTime2.UseVisualStyleBackColor = true
		'
		'label1
		'
		Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label1.AutoSize = true
		Me.label1.Location = New System.Drawing.Point(532, 6)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(17, 12)
		Me.label1.TabIndex = 8
		Me.label1.Text = "分"
		'
		'label6
		'
		Me.label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label6.AutoSize = true
		Me.label6.Location = New System.Drawing.Point(442, 6)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(29, 12)
		Me.label6.TabIndex = 7
		Me.label6.Text = "時間"
		'
		'cboxWorkTimeByMinute2
		'
		Me.cboxWorkTimeByMinute2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByMinute2.FormattingEnabled = true
		Me.cboxWorkTimeByMinute2.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
		Me.cboxWorkTimeByMinute2.Location = New System.Drawing.Point(477, 2)
		Me.cboxWorkTimeByMinute2.Name = "cboxWorkTimeByMinute2"
		Me.cboxWorkTimeByMinute2.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByMinute2.TabIndex = 6
		'
		'cboxWorkTimeByHour2
		'
		Me.cboxWorkTimeByHour2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByHour2.FormattingEnabled = true
		Me.cboxWorkTimeByHour2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
		Me.cboxWorkTimeByHour2.Location = New System.Drawing.Point(387, 2)
		Me.cboxWorkTimeByHour2.Name = "cboxWorkTimeByHour2"
		Me.cboxWorkTimeByHour2.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByHour2.TabIndex = 5
		'
		'btnMinus1_2
		'
		Me.btnMinus1_2.Location = New System.Drawing.Point(315, 0)
		Me.btnMinus1_2.Name = "btnMinus1_2"
		Me.btnMinus1_2.Size = New System.Drawing.Size(50, 25)
		Me.btnMinus1_2.TabIndex = 4
		Me.btnMinus1_2.Text = "-1"
		Me.btnMinus1_2.UseVisualStyleBackColor = true
		'
		'btnPlus1_2
		'
		Me.btnPlus1_2.Location = New System.Drawing.Point(261, 0)
		Me.btnPlus1_2.Name = "btnPlus1_2"
		Me.btnPlus1_2.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus1_2.TabIndex = 3
		Me.btnPlus1_2.Text = "+1"
		Me.btnPlus1_2.UseVisualStyleBackColor = true
		'
		'btnPlus5_2
		'
		Me.btnPlus5_2.Location = New System.Drawing.Point(207, 0)
		Me.btnPlus5_2.Name = "btnPlus5_2"
		Me.btnPlus5_2.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus5_2.TabIndex = 2
		Me.btnPlus5_2.Text = "+5"
		Me.btnPlus5_2.UseVisualStyleBackColor = true
		'
		'btnPlus10_2
		'
		Me.btnPlus10_2.Location = New System.Drawing.Point(153, 0)
		Me.btnPlus10_2.Name = "btnPlus10_2"
		Me.btnPlus10_2.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus10_2.TabIndex = 1
		Me.btnPlus10_2.Text = "+10"
		Me.btnPlus10_2.UseVisualStyleBackColor = true
		'
		'lblItemName2
		'
		Me.lblItemName2.AutoSize = true
		Me.lblItemName2.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.lblItemName2.Location = New System.Drawing.Point(3, 6)
		Me.lblItemName2.Name = "lblItemName2"
		Me.lblItemName2.Size = New System.Drawing.Size(9, 12)
		Me.lblItemName2.TabIndex = 0
		Me.lblItemName2.Text = " "
		'
		'panel3
		'
		Me.panel3.Controls.Add(Me.txtWorkCount3)
		Me.panel3.Controls.Add(Me.btnWriteWorkTime3)
		Me.panel3.Controls.Add(Me.label8)
		Me.panel3.Controls.Add(Me.label9)
		Me.panel3.Controls.Add(Me.cboxWorkTimeByMinute3)
		Me.panel3.Controls.Add(Me.cboxWorkTimeByHour3)
		Me.panel3.Controls.Add(Me.btnMinus1_3)
		Me.panel3.Controls.Add(Me.btnPlus1_3)
		Me.panel3.Controls.Add(Me.btnPlus5_3)
		Me.panel3.Controls.Add(Me.btnPlus10_3)
		Me.panel3.Controls.Add(Me.lblItemName3)
		Me.panel3.Location = New System.Drawing.Point(13, 136)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(618, 25)
		Me.panel3.TabIndex = 7
		'
		'txtWorkCount3
		'
		Me.txtWorkCount3.Location = New System.Drawing.Point(97, 3)
		Me.txtWorkCount3.Name = "txtWorkCount3"
		Me.txtWorkCount3.ReadOnly = true
		Me.txtWorkCount3.Size = New System.Drawing.Size(50, 19)
		Me.txtWorkCount3.TabIndex = 3
		'
		'btnWriteWorkTime3
		'
		Me.btnWriteWorkTime3.Location = New System.Drawing.Point(557, 0)
		Me.btnWriteWorkTime3.Name = "btnWriteWorkTime3"
		Me.btnWriteWorkTime3.Size = New System.Drawing.Size(60, 25)
		Me.btnWriteWorkTime3.TabIndex = 9
		Me.btnWriteWorkTime3.Text = "上書き"
		Me.btnWriteWorkTime3.UseVisualStyleBackColor = true
		'
		'label8
		'
		Me.label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label8.AutoSize = true
		Me.label8.Location = New System.Drawing.Point(532, 6)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(17, 12)
		Me.label8.TabIndex = 8
		Me.label8.Text = "分"
		'
		'label9
		'
		Me.label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label9.AutoSize = true
		Me.label9.Location = New System.Drawing.Point(442, 6)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(29, 12)
		Me.label9.TabIndex = 7
		Me.label9.Text = "時間"
		'
		'cboxWorkTimeByMinute3
		'
		Me.cboxWorkTimeByMinute3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByMinute3.FormattingEnabled = true
		Me.cboxWorkTimeByMinute3.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
		Me.cboxWorkTimeByMinute3.Location = New System.Drawing.Point(477, 2)
		Me.cboxWorkTimeByMinute3.Name = "cboxWorkTimeByMinute3"
		Me.cboxWorkTimeByMinute3.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByMinute3.TabIndex = 6
		'
		'cboxWorkTimeByHour3
		'
		Me.cboxWorkTimeByHour3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByHour3.FormattingEnabled = true
		Me.cboxWorkTimeByHour3.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
		Me.cboxWorkTimeByHour3.Location = New System.Drawing.Point(387, 2)
		Me.cboxWorkTimeByHour3.Name = "cboxWorkTimeByHour3"
		Me.cboxWorkTimeByHour3.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByHour3.TabIndex = 5
		'
		'btnMinus1_3
		'
		Me.btnMinus1_3.Location = New System.Drawing.Point(315, 0)
		Me.btnMinus1_3.Name = "btnMinus1_3"
		Me.btnMinus1_3.Size = New System.Drawing.Size(50, 25)
		Me.btnMinus1_3.TabIndex = 4
		Me.btnMinus1_3.Text = "-1"
		Me.btnMinus1_3.UseVisualStyleBackColor = true
		'
		'btnPlus1_3
		'
		Me.btnPlus1_3.Location = New System.Drawing.Point(261, 0)
		Me.btnPlus1_3.Name = "btnPlus1_3"
		Me.btnPlus1_3.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus1_3.TabIndex = 3
		Me.btnPlus1_3.Text = "+1"
		Me.btnPlus1_3.UseVisualStyleBackColor = true
		'
		'btnPlus5_3
		'
		Me.btnPlus5_3.Location = New System.Drawing.Point(207, 0)
		Me.btnPlus5_3.Name = "btnPlus5_3"
		Me.btnPlus5_3.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus5_3.TabIndex = 2
		Me.btnPlus5_3.Text = "+5"
		Me.btnPlus5_3.UseVisualStyleBackColor = true
		'
		'btnPlus10_3
		'
		Me.btnPlus10_3.Location = New System.Drawing.Point(153, 0)
		Me.btnPlus10_3.Name = "btnPlus10_3"
		Me.btnPlus10_3.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus10_3.TabIndex = 1
		Me.btnPlus10_3.Text = "+10"
		Me.btnPlus10_3.UseVisualStyleBackColor = true
		'
		'lblItemName3
		'
		Me.lblItemName3.AutoSize = true
		Me.lblItemName3.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.lblItemName3.Location = New System.Drawing.Point(3, 6)
		Me.lblItemName3.Name = "lblItemName3"
		Me.lblItemName3.Size = New System.Drawing.Size(9, 12)
		Me.lblItemName3.TabIndex = 0
		Me.lblItemName3.Text = " "
		'
		'panel4
		'
		Me.panel4.Controls.Add(Me.txtWorkCount4)
		Me.panel4.Controls.Add(Me.btnWriteWorkTime4)
		Me.panel4.Controls.Add(Me.label11)
		Me.panel4.Controls.Add(Me.label12)
		Me.panel4.Controls.Add(Me.cboxWorkTimeByMinute4)
		Me.panel4.Controls.Add(Me.cboxWorkTimeByHour4)
		Me.panel4.Controls.Add(Me.btnMinus1_4)
		Me.panel4.Controls.Add(Me.btnPlus1_4)
		Me.panel4.Controls.Add(Me.btnPlus5_4)
		Me.panel4.Controls.Add(Me.btnPlus10_4)
		Me.panel4.Controls.Add(Me.lblItemName4)
		Me.panel4.Location = New System.Drawing.Point(13, 164)
		Me.panel4.Name = "panel4"
		Me.panel4.Size = New System.Drawing.Size(618, 25)
		Me.panel4.TabIndex = 8
		'
		'txtWorkCount4
		'
		Me.txtWorkCount4.Location = New System.Drawing.Point(97, 3)
		Me.txtWorkCount4.Name = "txtWorkCount4"
		Me.txtWorkCount4.ReadOnly = true
		Me.txtWorkCount4.Size = New System.Drawing.Size(50, 19)
		Me.txtWorkCount4.TabIndex = 3
		'
		'btnWriteWorkTime4
		'
		Me.btnWriteWorkTime4.Location = New System.Drawing.Point(557, 0)
		Me.btnWriteWorkTime4.Name = "btnWriteWorkTime4"
		Me.btnWriteWorkTime4.Size = New System.Drawing.Size(60, 25)
		Me.btnWriteWorkTime4.TabIndex = 9
		Me.btnWriteWorkTime4.Text = "上書き"
		Me.btnWriteWorkTime4.UseVisualStyleBackColor = true
		'
		'label11
		'
		Me.label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label11.AutoSize = true
		Me.label11.Location = New System.Drawing.Point(532, 6)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(17, 12)
		Me.label11.TabIndex = 8
		Me.label11.Text = "分"
		'
		'label12
		'
		Me.label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label12.AutoSize = true
		Me.label12.Location = New System.Drawing.Point(442, 6)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(29, 12)
		Me.label12.TabIndex = 7
		Me.label12.Text = "時間"
		'
		'cboxWorkTimeByMinute4
		'
		Me.cboxWorkTimeByMinute4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByMinute4.FormattingEnabled = true
		Me.cboxWorkTimeByMinute4.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
		Me.cboxWorkTimeByMinute4.Location = New System.Drawing.Point(477, 2)
		Me.cboxWorkTimeByMinute4.Name = "cboxWorkTimeByMinute4"
		Me.cboxWorkTimeByMinute4.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByMinute4.TabIndex = 6
		'
		'cboxWorkTimeByHour4
		'
		Me.cboxWorkTimeByHour4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByHour4.FormattingEnabled = true
		Me.cboxWorkTimeByHour4.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
		Me.cboxWorkTimeByHour4.Location = New System.Drawing.Point(387, 2)
		Me.cboxWorkTimeByHour4.Name = "cboxWorkTimeByHour4"
		Me.cboxWorkTimeByHour4.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByHour4.TabIndex = 5
		'
		'btnMinus1_4
		'
		Me.btnMinus1_4.Location = New System.Drawing.Point(315, 0)
		Me.btnMinus1_4.Name = "btnMinus1_4"
		Me.btnMinus1_4.Size = New System.Drawing.Size(50, 25)
		Me.btnMinus1_4.TabIndex = 4
		Me.btnMinus1_4.Text = "-1"
		Me.btnMinus1_4.UseVisualStyleBackColor = true
		'
		'btnPlus1_4
		'
		Me.btnPlus1_4.Location = New System.Drawing.Point(261, 0)
		Me.btnPlus1_4.Name = "btnPlus1_4"
		Me.btnPlus1_4.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus1_4.TabIndex = 3
		Me.btnPlus1_4.Text = "+1"
		Me.btnPlus1_4.UseVisualStyleBackColor = true
		'
		'btnPlus5_4
		'
		Me.btnPlus5_4.Location = New System.Drawing.Point(207, 0)
		Me.btnPlus5_4.Name = "btnPlus5_4"
		Me.btnPlus5_4.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus5_4.TabIndex = 2
		Me.btnPlus5_4.Text = "+5"
		Me.btnPlus5_4.UseVisualStyleBackColor = true
		'
		'btnPlus10_4
		'
		Me.btnPlus10_4.Location = New System.Drawing.Point(153, 0)
		Me.btnPlus10_4.Name = "btnPlus10_4"
		Me.btnPlus10_4.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus10_4.TabIndex = 1
		Me.btnPlus10_4.Text = "+10"
		Me.btnPlus10_4.UseVisualStyleBackColor = true
		'
		'lblItemName4
		'
		Me.lblItemName4.AutoSize = true
		Me.lblItemName4.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.lblItemName4.Location = New System.Drawing.Point(3, 6)
		Me.lblItemName4.Name = "lblItemName4"
		Me.lblItemName4.Size = New System.Drawing.Size(9, 12)
		Me.lblItemName4.TabIndex = 0
		Me.lblItemName4.Text = " "
		'
		'panel5
		'
		Me.panel5.Controls.Add(Me.txtWorkCount5)
		Me.panel5.Controls.Add(Me.btnWriteWorkTime5)
		Me.panel5.Controls.Add(Me.label14)
		Me.panel5.Controls.Add(Me.label15)
		Me.panel5.Controls.Add(Me.cboxWorkTimeByMinute5)
		Me.panel5.Controls.Add(Me.cboxWorkTimeByHour5)
		Me.panel5.Controls.Add(Me.btnMinus1_5)
		Me.panel5.Controls.Add(Me.btnPlus1_5)
		Me.panel5.Controls.Add(Me.btnPlus5_5)
		Me.panel5.Controls.Add(Me.btnPlus10_5)
		Me.panel5.Controls.Add(Me.lblItemName5)
		Me.panel5.Location = New System.Drawing.Point(13, 192)
		Me.panel5.Name = "panel5"
		Me.panel5.Size = New System.Drawing.Size(618, 25)
		Me.panel5.TabIndex = 9
		'
		'txtWorkCount5
		'
		Me.txtWorkCount5.Location = New System.Drawing.Point(97, 3)
		Me.txtWorkCount5.Name = "txtWorkCount5"
		Me.txtWorkCount5.ReadOnly = true
		Me.txtWorkCount5.Size = New System.Drawing.Size(50, 19)
		Me.txtWorkCount5.TabIndex = 3
		'
		'btnWriteWorkTime5
		'
		Me.btnWriteWorkTime5.Location = New System.Drawing.Point(557, 0)
		Me.btnWriteWorkTime5.Name = "btnWriteWorkTime5"
		Me.btnWriteWorkTime5.Size = New System.Drawing.Size(60, 25)
		Me.btnWriteWorkTime5.TabIndex = 9
		Me.btnWriteWorkTime5.Text = "上書き"
		Me.btnWriteWorkTime5.UseVisualStyleBackColor = true
		'
		'label14
		'
		Me.label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label14.AutoSize = true
		Me.label14.Location = New System.Drawing.Point(532, 6)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(17, 12)
		Me.label14.TabIndex = 8
		Me.label14.Text = "分"
		'
		'label15
		'
		Me.label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label15.AutoSize = true
		Me.label15.Location = New System.Drawing.Point(442, 6)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(29, 12)
		Me.label15.TabIndex = 7
		Me.label15.Text = "時間"
		'
		'cboxWorkTimeByMinute5
		'
		Me.cboxWorkTimeByMinute5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByMinute5.FormattingEnabled = true
		Me.cboxWorkTimeByMinute5.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
		Me.cboxWorkTimeByMinute5.Location = New System.Drawing.Point(477, 2)
		Me.cboxWorkTimeByMinute5.Name = "cboxWorkTimeByMinute5"
		Me.cboxWorkTimeByMinute5.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByMinute5.TabIndex = 6
		'
		'cboxWorkTimeByHour5
		'
		Me.cboxWorkTimeByHour5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByHour5.FormattingEnabled = true
		Me.cboxWorkTimeByHour5.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
		Me.cboxWorkTimeByHour5.Location = New System.Drawing.Point(387, 2)
		Me.cboxWorkTimeByHour5.Name = "cboxWorkTimeByHour5"
		Me.cboxWorkTimeByHour5.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByHour5.TabIndex = 5
		'
		'btnMinus1_5
		'
		Me.btnMinus1_5.Location = New System.Drawing.Point(315, 0)
		Me.btnMinus1_5.Name = "btnMinus1_5"
		Me.btnMinus1_5.Size = New System.Drawing.Size(50, 25)
		Me.btnMinus1_5.TabIndex = 4
		Me.btnMinus1_5.Text = "-1"
		Me.btnMinus1_5.UseVisualStyleBackColor = true
		'
		'btnPlus1_5
		'
		Me.btnPlus1_5.Location = New System.Drawing.Point(261, 0)
		Me.btnPlus1_5.Name = "btnPlus1_5"
		Me.btnPlus1_5.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus1_5.TabIndex = 3
		Me.btnPlus1_5.Text = "+1"
		Me.btnPlus1_5.UseVisualStyleBackColor = true
		'
		'btnPlus5_5
		'
		Me.btnPlus5_5.Location = New System.Drawing.Point(207, 0)
		Me.btnPlus5_5.Name = "btnPlus5_5"
		Me.btnPlus5_5.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus5_5.TabIndex = 2
		Me.btnPlus5_5.Text = "+5"
		Me.btnPlus5_5.UseVisualStyleBackColor = true
		'
		'btnPlus10_5
		'
		Me.btnPlus10_5.Location = New System.Drawing.Point(153, 0)
		Me.btnPlus10_5.Name = "btnPlus10_5"
		Me.btnPlus10_5.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus10_5.TabIndex = 1
		Me.btnPlus10_5.Text = "+10"
		Me.btnPlus10_5.UseVisualStyleBackColor = true
		'
		'lblItemName5
		'
		Me.lblItemName5.AutoSize = true
		Me.lblItemName5.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.lblItemName5.Location = New System.Drawing.Point(3, 6)
		Me.lblItemName5.Name = "lblItemName5"
		Me.lblItemName5.Size = New System.Drawing.Size(9, 12)
		Me.lblItemName5.TabIndex = 0
		Me.lblItemName5.Text = " "
		'
		'panel6
		'
		Me.panel6.Controls.Add(Me.txtWorkCount6)
		Me.panel6.Controls.Add(Me.btnWriteWorkTime6)
		Me.panel6.Controls.Add(Me.label17)
		Me.panel6.Controls.Add(Me.label18)
		Me.panel6.Controls.Add(Me.cboxWorkTimeByMinute6)
		Me.panel6.Controls.Add(Me.cboxWorkTimeByHour6)
		Me.panel6.Controls.Add(Me.btnMinus1_6)
		Me.panel6.Controls.Add(Me.btnPlus1_6)
		Me.panel6.Controls.Add(Me.btnPlus5_6)
		Me.panel6.Controls.Add(Me.btnPlus10_6)
		Me.panel6.Controls.Add(Me.lblItemName6)
		Me.panel6.Location = New System.Drawing.Point(13, 220)
		Me.panel6.Name = "panel6"
		Me.panel6.Size = New System.Drawing.Size(618, 25)
		Me.panel6.TabIndex = 10
		'
		'txtWorkCount6
		'
		Me.txtWorkCount6.Location = New System.Drawing.Point(97, 3)
		Me.txtWorkCount6.Name = "txtWorkCount6"
		Me.txtWorkCount6.ReadOnly = true
		Me.txtWorkCount6.Size = New System.Drawing.Size(50, 19)
		Me.txtWorkCount6.TabIndex = 3
		'
		'btnWriteWorkTime6
		'
		Me.btnWriteWorkTime6.Location = New System.Drawing.Point(557, 0)
		Me.btnWriteWorkTime6.Name = "btnWriteWorkTime6"
		Me.btnWriteWorkTime6.Size = New System.Drawing.Size(60, 25)
		Me.btnWriteWorkTime6.TabIndex = 9
		Me.btnWriteWorkTime6.Text = "上書き"
		Me.btnWriteWorkTime6.UseVisualStyleBackColor = true
		'
		'label17
		'
		Me.label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label17.AutoSize = true
		Me.label17.Location = New System.Drawing.Point(532, 6)
		Me.label17.Name = "label17"
		Me.label17.Size = New System.Drawing.Size(17, 12)
		Me.label17.TabIndex = 8
		Me.label17.Text = "分"
		'
		'label18
		'
		Me.label18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label18.AutoSize = true
		Me.label18.Location = New System.Drawing.Point(442, 6)
		Me.label18.Name = "label18"
		Me.label18.Size = New System.Drawing.Size(29, 12)
		Me.label18.TabIndex = 7
		Me.label18.Text = "時間"
		'
		'cboxWorkTimeByMinute6
		'
		Me.cboxWorkTimeByMinute6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByMinute6.FormattingEnabled = true
		Me.cboxWorkTimeByMinute6.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
		Me.cboxWorkTimeByMinute6.Location = New System.Drawing.Point(477, 2)
		Me.cboxWorkTimeByMinute6.Name = "cboxWorkTimeByMinute6"
		Me.cboxWorkTimeByMinute6.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByMinute6.TabIndex = 6
		'
		'cboxWorkTimeByHour6
		'
		Me.cboxWorkTimeByHour6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboxWorkTimeByHour6.FormattingEnabled = true
		Me.cboxWorkTimeByHour6.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
		Me.cboxWorkTimeByHour6.Location = New System.Drawing.Point(387, 2)
		Me.cboxWorkTimeByHour6.Name = "cboxWorkTimeByHour6"
		Me.cboxWorkTimeByHour6.Size = New System.Drawing.Size(50, 20)
		Me.cboxWorkTimeByHour6.TabIndex = 5
		'
		'btnMinus1_6
		'
		Me.btnMinus1_6.Location = New System.Drawing.Point(315, 0)
		Me.btnMinus1_6.Name = "btnMinus1_6"
		Me.btnMinus1_6.Size = New System.Drawing.Size(50, 25)
		Me.btnMinus1_6.TabIndex = 4
		Me.btnMinus1_6.Text = "-1"
		Me.btnMinus1_6.UseVisualStyleBackColor = true
		'
		'btnPlus1_6
		'
		Me.btnPlus1_6.Location = New System.Drawing.Point(261, 0)
		Me.btnPlus1_6.Name = "btnPlus1_6"
		Me.btnPlus1_6.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus1_6.TabIndex = 3
		Me.btnPlus1_6.Text = "+1"
		Me.btnPlus1_6.UseVisualStyleBackColor = true
		'
		'btnPlus5_6
		'
		Me.btnPlus5_6.Location = New System.Drawing.Point(207, 0)
		Me.btnPlus5_6.Name = "btnPlus5_6"
		Me.btnPlus5_6.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus5_6.TabIndex = 2
		Me.btnPlus5_6.Text = "+5"
		Me.btnPlus5_6.UseVisualStyleBackColor = true
		'
		'btnPlus10_6
		'
		Me.btnPlus10_6.Location = New System.Drawing.Point(153, 0)
		Me.btnPlus10_6.Name = "btnPlus10_6"
		Me.btnPlus10_6.Size = New System.Drawing.Size(50, 25)
		Me.btnPlus10_6.TabIndex = 1
		Me.btnPlus10_6.Text = "+10"
		Me.btnPlus10_6.UseVisualStyleBackColor = true
		'
		'lblItemName6
		'
		Me.lblItemName6.AutoSize = true
		Me.lblItemName6.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.lblItemName6.Location = New System.Drawing.Point(3, 6)
		Me.lblItemName6.Name = "lblItemName6"
		Me.lblItemName6.Size = New System.Drawing.Size(9, 12)
		Me.lblItemName6.TabIndex = 0
		Me.lblItemName6.Text = " "
		'
		'btnWriteNote
		'
		Me.btnWriteNote.Location = New System.Drawing.Point(570, 276)
		Me.btnWriteNote.Name = "btnWriteNote"
		Me.btnWriteNote.Size = New System.Drawing.Size(60, 25)
		Me.btnWriteNote.TabIndex = 10
		Me.btnWriteNote.Text = "上書き"
		Me.btnWriteNote.UseVisualStyleBackColor = true
		'
		'txtNote
		'
		Me.txtNote.Location = New System.Drawing.Point(110, 279)
		Me.txtNote.Name = "txtNote"
		Me.txtNote.Size = New System.Drawing.Size(430, 19)
		Me.txtNote.TabIndex = 11
		'
		'lblNote
		'
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
		Me.btnClose.Location = New System.Drawing.Point(570, 304)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(60, 25)
		Me.btnClose.TabIndex = 13
		Me.btnClose.Text = "閉じる"
		Me.btnClose.UseVisualStyleBackColor = true
		'
		'btnReload
		'
		Me.btnReload.Location = New System.Drawing.Point(502, 304)
		Me.btnReload.Name = "btnReload"
		Me.btnReload.Size = New System.Drawing.Size(60, 25)
		Me.btnReload.TabIndex = 14
		Me.btnReload.Text = "再読込"
		Me.btnReload.UseVisualStyleBackColor = true
		'
		'label24
		'
		Me.label24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label24.AutoSize = true
		Me.label24.Location = New System.Drawing.Point(110, 303)
		Me.label24.Name = "label24"
		Me.label24.Size = New System.Drawing.Size(266, 12)
		Me.label24.TabIndex = 15
		Me.label24.Text = "※備考を追記するときは既にある文章に続けて書いてね"
		'
		'menuStrip1
		'
		Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1})
		Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.menuStrip1.Name = "menuStrip1"
		Me.menuStrip1.Size = New System.Drawing.Size(647, 26)
		Me.menuStrip1.TabIndex = 16
		Me.menuStrip1.Text = "menuStrip1"
		'
		'toolStripMenuItem1
		'
		Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ストップウォッチToolStripMenuItem})
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(56, 22)
		Me.toolStripMenuItem1.Text = "ツール"
		'
		'ストップウォッチToolStripMenuItem
		'
		Me.ストップウォッチToolStripMenuItem.Name = "ストップウォッチToolStripMenuItem"
		Me.ストップウォッチToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
		Me.ストップウォッチToolStripMenuItem.Text = "ストップウォッチ"
		'
		'panel7
		'
		Me.panel7.Controls.Add(Me.textBox1)
		Me.panel7.Controls.Add(Me.button1)
		Me.panel7.Controls.Add(Me.label7)
		Me.panel7.Controls.Add(Me.label10)
		Me.panel7.Controls.Add(Me.comboBox1)
		Me.panel7.Controls.Add(Me.comboBox2)
		Me.panel7.Controls.Add(Me.button2)
		Me.panel7.Controls.Add(Me.button3)
		Me.panel7.Controls.Add(Me.button4)
		Me.panel7.Controls.Add(Me.button5)
		Me.panel7.Controls.Add(Me.label13)
		Me.panel7.Location = New System.Drawing.Point(13, 248)
		Me.panel7.Name = "panel7"
		Me.panel7.Size = New System.Drawing.Size(618, 25)
		Me.panel7.TabIndex = 17
		'
		'textBox1
		'
		Me.textBox1.Location = New System.Drawing.Point(97, 3)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ReadOnly = true
		Me.textBox1.Size = New System.Drawing.Size(50, 19)
		Me.textBox1.TabIndex = 3
		'
		'button1
		'
		Me.button1.Location = New System.Drawing.Point(557, 0)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(60, 25)
		Me.button1.TabIndex = 9
		Me.button1.Text = "上書き"
		Me.button1.UseVisualStyleBackColor = true
		'
		'label7
		'
		Me.label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label7.AutoSize = true
		Me.label7.Location = New System.Drawing.Point(532, 6)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(17, 12)
		Me.label7.TabIndex = 8
		Me.label7.Text = "分"
		'
		'label10
		'
		Me.label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
						Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label10.AutoSize = true
		Me.label10.Location = New System.Drawing.Point(442, 6)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(29, 12)
		Me.label10.TabIndex = 7
		Me.label10.Text = "時間"
		'
		'comboBox1
		'
		Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
		Me.comboBox1.Location = New System.Drawing.Point(477, 2)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(50, 20)
		Me.comboBox1.TabIndex = 6
		'
		'comboBox2
		'
		Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBox2.FormattingEnabled = true
		Me.comboBox2.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15"})
		Me.comboBox2.Location = New System.Drawing.Point(387, 2)
		Me.comboBox2.Name = "comboBox2"
		Me.comboBox2.Size = New System.Drawing.Size(50, 20)
		Me.comboBox2.TabIndex = 5
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(315, 0)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(50, 25)
		Me.button2.TabIndex = 4
		Me.button2.Text = "-1"
		Me.button2.UseVisualStyleBackColor = true
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(261, 0)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(50, 25)
		Me.button3.TabIndex = 3
		Me.button3.Text = "+1"
		Me.button3.UseVisualStyleBackColor = true
		'
		'button4
		'
		Me.button4.Location = New System.Drawing.Point(207, 0)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(50, 25)
		Me.button4.TabIndex = 2
		Me.button4.Text = "+5"
		Me.button4.UseVisualStyleBackColor = true
		'
		'button5
		'
		Me.button5.Location = New System.Drawing.Point(153, 0)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(50, 25)
		Me.button5.TabIndex = 1
		Me.button5.Text = "+10"
		Me.button5.UseVisualStyleBackColor = true
		'
		'label13
		'
		Me.label13.AutoSize = true
		Me.label13.Font = New System.Drawing.Font("MS UI Gothic", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128,Byte))
		Me.label13.Location = New System.Drawing.Point(3, 6)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(9, 12)
		Me.label13.TabIndex = 0
		Me.label13.Text = " "
		'
		'MainFormModel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(647, 359)
		Me.Controls.Add(Me.panel7)
		Me.Controls.Add(Me.label24)
		Me.Controls.Add(Me.btnReload)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.lblNote)
		Me.Controls.Add(Me.txtNote)
		Me.Controls.Add(Me.btnWriteNote)
		Me.Controls.Add(Me.panel6)
		Me.Controls.Add(Me.panel5)
		Me.Controls.Add(Me.panel4)
		Me.Controls.Add(Me.panel3)
		Me.Controls.Add(Me.panel2)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.menuStrip1)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.panel1)
		Me.Controls.Add(Me.dateTimePicker1)
		Me.Controls.Add(Me.lblUserName)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MainMenuStrip = Me.menuStrip1
		Me.MaximizeBox = false
		Me.Name = "MainFormModel"
		Me.Text = "WorkReport"
		Me.panel1.ResumeLayout(false)
		Me.panel1.PerformLayout
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.panel2.ResumeLayout(false)
		Me.panel2.PerformLayout
		Me.panel3.ResumeLayout(false)
		Me.panel3.PerformLayout
		Me.panel4.ResumeLayout(false)
		Me.panel4.PerformLayout
		Me.panel5.ResumeLayout(false)
		Me.panel5.PerformLayout
		Me.panel6.ResumeLayout(false)
		Me.panel6.PerformLayout
		Me.menuStrip1.ResumeLayout(false)
		Me.menuStrip1.PerformLayout
		Me.panel7.ResumeLayout(false)
		Me.panel7.PerformLayout
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private label13 As System.Windows.Forms.Label
	Private button5 As System.Windows.Forms.Button
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private comboBox2 As System.Windows.Forms.ComboBox
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private label10 As System.Windows.Forms.Label
	Private label7 As System.Windows.Forms.Label
	Private button1 As System.Windows.Forms.Button
	Private textBox1 As System.Windows.Forms.TextBox
	Private panel7 As System.Windows.Forms.Panel
	Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
	Private ストップウォッチToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
	Private menuStrip1 As System.Windows.Forms.MenuStrip
	Private label24 As System.Windows.Forms.Label
	Private btnReload As System.Windows.Forms.Button
	Private btnClose As System.Windows.Forms.Button
	Private lblNote As System.Windows.Forms.Label
	Private txtNote As System.Windows.Forms.TextBox
	Private btnWriteNote As System.Windows.Forms.Button
	Private lblItemName6 As System.Windows.Forms.Label
	Private btnPlus10_6 As System.Windows.Forms.Button
	Private btnPlus5_6 As System.Windows.Forms.Button
	Private btnPlus1_6 As System.Windows.Forms.Button
	Private btnMinus1_6 As System.Windows.Forms.Button
	Private cboxWorkTimeByHour6 As System.Windows.Forms.ComboBox
	Private cboxWorkTimeByMinute6 As System.Windows.Forms.ComboBox
	Private label18 As System.Windows.Forms.Label
	Private label17 As System.Windows.Forms.Label
	Private btnWriteWorkTime6 As System.Windows.Forms.Button
	Private txtWorkCount6 As System.Windows.Forms.TextBox
	Private panel6 As System.Windows.Forms.Panel
	Private lblItemName5 As System.Windows.Forms.Label
	Private btnPlus10_5 As System.Windows.Forms.Button
	Private btnPlus5_5 As System.Windows.Forms.Button
	Private btnPlus1_5 As System.Windows.Forms.Button
	Private btnMinus1_5 As System.Windows.Forms.Button
	Private cboxWorkTimeByHour5 As System.Windows.Forms.ComboBox
	Private cboxWorkTimeByMinute5 As System.Windows.Forms.ComboBox
	Private label15 As System.Windows.Forms.Label
	Private label14 As System.Windows.Forms.Label
	Private btnWriteWorkTime5 As System.Windows.Forms.Button
	Private txtWorkCount5 As System.Windows.Forms.TextBox
	Private panel5 As System.Windows.Forms.Panel
	Private lblItemName4 As System.Windows.Forms.Label
	Private btnPlus10_4 As System.Windows.Forms.Button
	Private btnPlus5_4 As System.Windows.Forms.Button
	Private btnPlus1_4 As System.Windows.Forms.Button
	Private btnMinus1_4 As System.Windows.Forms.Button
	Private cboxWorkTimeByHour4 As System.Windows.Forms.ComboBox
	Private cboxWorkTimeByMinute4 As System.Windows.Forms.ComboBox
	Private label12 As System.Windows.Forms.Label
	Private label11 As System.Windows.Forms.Label
	Private btnWriteWorkTime4 As System.Windows.Forms.Button
	Private txtWorkCount4 As System.Windows.Forms.TextBox
	Private panel4 As System.Windows.Forms.Panel
	Private lblItemName3 As System.Windows.Forms.Label
	Private btnPlus10_3 As System.Windows.Forms.Button
	Private btnPlus5_3 As System.Windows.Forms.Button
	Private btnPlus1_3 As System.Windows.Forms.Button
	Private btnMinus1_3 As System.Windows.Forms.Button
	Private cboxWorkTimeByHour3 As System.Windows.Forms.ComboBox
	Private cboxWorkTimeByMinute3 As System.Windows.Forms.ComboBox
	Private label9 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private btnWriteWorkTime3 As System.Windows.Forms.Button
	Private txtWorkCount3 As System.Windows.Forms.TextBox
	Private panel3 As System.Windows.Forms.Panel
	Private lblItemName2 As System.Windows.Forms.Label
	Private btnPlus10_2 As System.Windows.Forms.Button
	Private btnPlus5_2 As System.Windows.Forms.Button
	Private btnPlus1_2 As System.Windows.Forms.Button
	Private btnMinus1_2 As System.Windows.Forms.Button
	Private cboxWorkTimeByHour2 As System.Windows.Forms.ComboBox
	Private cboxWorkTimeByMinute2 As System.Windows.Forms.ComboBox
	Private label6 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private btnWriteWorkTime2 As System.Windows.Forms.Button
	Private txtWorkCount2 As System.Windows.Forms.TextBox
	Private panel2 As System.Windows.Forms.Panel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private label5 As System.Windows.Forms.Label
	Private label4 As System.Windows.Forms.Label
	Private txtWorkCount1 As System.Windows.Forms.TextBox
	Private btnWriteWorkTime1 As System.Windows.Forms.Button
	Private label2 As System.Windows.Forms.Label
	Private label3 As System.Windows.Forms.Label
	Private cboxWorkTimeByHour1 As System.Windows.Forms.ComboBox
	Private cboxWorkTimeByMinute1 As System.Windows.Forms.ComboBox
	Private lblItemName1 As System.Windows.Forms.Label
	Private btnPlus10_1 As System.Windows.Forms.Button
	Private btnPlus5_1 As System.Windows.Forms.Button
	Private btnPlus1_1 As System.Windows.Forms.Button
	Private btnMinus1_1 As System.Windows.Forms.Button
	Private panel1 As System.Windows.Forms.Panel
	Private dateTimePicker1 As System.Windows.Forms.DateTimePicker
	Private lblUserName As System.Windows.Forms.Label
	
End Class
