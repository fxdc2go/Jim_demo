Option Explicit On
Option Compare Text
Imports System.Data.SqlClient
Imports System
Imports System.Configuration
Imports System.IO


Public Class clsDataAccess
	Dim cnSQL As New SqlConnection
	Private Sub cnInit()
		If cnSQL.State <> ConnectionState.Open Then
			With cnSQL
				.ConnectionString = My.Settings.cnSQL
				Try
					.Open()
				Catch ex As Exception
					MsgBox(ex.Message)
				End Try
			End With
		End If
	End Sub
	Private Sub cnClose()
		If cnSQL.State <> ConnectionState.Closed Then
			Try
				cnSQL.Close()

			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
		End If
	End Sub
	Friend Function GetCustomerInfo()
		Dim strSQL As String = "SELECT * from Employees;"
		cnInit()
		Dim com As New SqlCommand
		With com
			.Connection = cnSQL
			.CommandType = CommandType.Text
			.CommandText = strSQL
		End With
		Dim da As New SqlDataAdapter(com)
		Dim dt As New DataTable
		Try
			da.Fill(dt)
		Catch ex As Exception
			MsgBox(ex.Message & " GetCustomerInfo")
		Finally
			GetCustomerInfo = dt
			da.Dispose()
			cnClose()

		End Try


	End Function
End Class
