Option Explicit On
Option Compare Text

Public Class frmMain
	Dim objDataAccess As New clsDataAccess
	Dim objGenerateFile As New clsGenerateFile
	Dim strFilePath As String = ""
	Private Sub btnSelectTemplate_Click(sender As Object, e As EventArgs) Handles btnSelectTemplate.Click

		OFDMain.Filter = "Select PDF Template File | *.pdf"
		OFDMain.FilterIndex = 2

		Me.OFDMain.AddExtension = True
		If Me.OFDMain.ShowDialog = Windows.Forms.DialogResult.OK Then
			strFilePath = OFDMain.FileName
		End If

		txtTemplateFilePath.Text = strFilePath




	End Sub


	Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
		With objGenerateFile
			.GeneratePDF(strFilePath, chkFlatten.CheckState)
		End With
	End Sub
End Class
