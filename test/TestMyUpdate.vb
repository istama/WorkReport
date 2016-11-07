'
' 日付: 2016/05/09
'
Imports NUnit.Framework
Imports System.IO
Imports Common.IO

<TestFixture> _
Public Class TestMyUpdate	
	Private versionFile As TextFile
	Private latestFile As TextFile
	Private u As MyUpdate
	
	<TestFixtureSetUp> _
	Public Sub Init
		Directory.CreateDirectory("./myupdate")
		Dim vPath As String = Path.GetFullPath("./testMyUpdateVersion.txt")
		Dim lDir As String  = Path.GetFullPath("./myupdate")
		Dim lPath As String = lDir & "/latest.txt"
		
		' バージョン番号ファイルと最新ファイルを作成
		versionFile = New TextFile(vPath, System.Text.Encoding.Default)
		versionFile.Write("2.0.0.0")
		latestFile = New TextFile(lPath, System.Text.Encoding.Default)
		latestFile.Write("latest version files")
		
		u = New MyUpdate(vPath, lDir)
	End Sub
	
	<Test> _
	Public Sub TestMyUpdateClass
		' スクリプトを実行
		Dim p As Process = u.RunUpdateBatch(New Version("1.0.0.0"))
		p.WaitForExit()
		
		' 最新ファイルと同じファイルがカレントディレクトリにコピーされていることをチェック
		Dim rPath As String = Path.GetFullPath("./latest.txt")
		Dim result As New TextFile(rPath, System.Text.Encoding.Default)
		Assert.True(result.Exists)
		Assert.AreEqual("latest version files", result.Read()(0))
		
		result.Delete()
	End Sub
	
	<TestFixtureTearDown> _
	Public Sub Dispose
		versionFile.Delete
		latestFile.Delete
		u.DeleteUpdateBatch
		Directory.Delete("./myupdate")
	End Sub	
End Class
