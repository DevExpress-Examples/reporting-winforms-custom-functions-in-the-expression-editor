Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace dxSample
	Partial Public Class Form2
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private reportDefinitionFilePath As String = "..\..\Reports\XtraReport1.repx"
		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			reportDesigner1.OpenReport(reportDefinitionFilePath)
		End Sub
	End Class
End Namespace
