Option Explicit On
Option Compare Text
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml
Imports System.IO

Public Class clsGenerateFile
	Dim objDataAccess As New clsDataAccess
	Friend Sub GeneratePDF(ByVal strFilePath As String, boolFlatten As Boolean)
		'First we set up the PDF Reader and Stamper objects
		Dim pdfReader As New PdfReader(strFilePath)
		Dim pdfStamper As New PdfStamper(pdfReader, New FileStream("C:\Temp\NewForm.pdf", FileMode.Create))
		Dim pdfFormfields As AcroFields = pdfStamper.AcroFields

		' Then we get the Employees Table from our database.
		Dim dtEmployees As New DataTable
		dtEmployees = objDataAccess.GetCustomerInfo()


		Dim intRows As Integer = 1


		For Each dr In dtEmployees.Rows
			Dim strDate As String = ""
			Dim strCode As String = ""
			Dim strRecp As String = ""
			Dim strID As String = ""

			If Not TypeOf dr("Date") Is DBNull Then
				strDate = dr("Date")
			Else
				strDate = ""
			End If
			If Not TypeOf dr("Code") Is DBNull Then
				strCode = dr("Code")
			Else
				strCode = ""
			End If
			If Not TypeOf dr("Recp") Is DBNull Then
				strRecp = dr("Recp")
			Else
				strRecp = ""
			End If
			If Not TypeOf dr("ID") Is DBNull Then
				strID = dr("ID")
			Else
				strID = ""
			End If

			pdfFormfields.SetField("Date_" & intRows.ToString, strDate)
			pdfFormfields.SetField("Code_" & intRows.ToString, strCode)
			pdfFormfields.SetField("Recp_" & intRows.ToString, strRecp)
			pdfFormfields.SetField("ID_" & intRows.ToString, strID)



			intRows += 1

		Next

		pdfStamper.FormFlattening = boolFlatten

		pdfStamper.Close()


		MsgBox("File Completed!")

		Process.Start("C:\Temp\NewForm.pdf")



	End Sub
End Class
