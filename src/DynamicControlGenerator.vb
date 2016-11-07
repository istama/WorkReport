'
' 日付: 2016/09/10
'
Public Class DynamicControlGenerator
  
  Public Shared Function CreatePanel() As ControlWrapper(Of Panel)
    Return New ControlWrapper(Of Panel)(New Panel)
  End Function
  
  Public Shared Function CreateLabel(text As String) As ControlWrapper(Of Label)
    Dim l As New Label
    l.Text = text
    Return New ControlWrapper(Of Label)(l)
  End Function
  
  Public Shared Function CreateButton(text As String) As ControlWrapper(Of Button)
    Dim b As New Button
    b.Text = text
    Return New ControlWrapper(Of Button)(b)
  End Function
  
  Public Shared Function CreateCountButton(count As Integer) As ControlWrapper(Of Button)
    Dim b As New Button
    If count > 0 Then
      b.Text = "+" & count.ToString
    Else
      b.Text = count.ToString
    End If
    
    Return New ControlWrapper(Of Button)(b)
  End Function
  
  Public Shared Function CreateComboBox(Of E)(collections As List(Of E), style As ComboBoxStyle) As ControlWrapper(Of ComboBox)
    Dim cbox As New ComboBox
    collections.ForEach(Sub(i) cbox.Items.Add(i))
    cbox.SelectedIndex = 0
    cbox.DropDownStyle = style
    Return New ControlWrapper(Of ComboBox)(cbox)
  End Function
  
  Public Shared Function CreateTextBox(text As String, Optional readMode As Boolean=False) As ControlWrapper(Of TextBox)
    Dim tbox As New TextBox
    tbox.Text = text
    tbox.ReadOnly = readMode
    Return New ControlWrapper(Of TextBox)(tbox)
  End Function
  
  Public Class ControlWrapper(Of T As Control)
    Private ReadOnly control As T
    
    Sub New(control As T)
      Me.control = control
      
      Me.control.AutoSize = False
      Me.control.Margin = New Padding(0)
    End Sub
    
    Public Function	AutoSize(enable As Boolean) As ControlWrapper(Of T)
      control.AutoSize = enable
      Return Me
    End Function
    
    Public Function Size(width As Integer, height As Integer) As ControlWrapper(Of T)
      control.Size = New Size(width, height)
      Return Me
    End Function
    
    Public Function Location(x As Integer, y As Integer) As ControlWrapper(Of T)
      control.Location = New Point(x, y)
      Return Me
    End Function
    
    Public Function Margin(all As Integer) As ControlWrapper(Of T)
      control.Margin = New Padding(all)
      Return Me
    End Function
    
    Public Function Margin(left As Integer, top As Integer, right As Integer, bottom As Integer) As ControlWrapper(Of T)
      control.Margin = New Padding(left, top, right, bottom)
      Return ME
    End Function
    
    Public Function Create() As T
      Return control
    End Function
  End Class
End Class
