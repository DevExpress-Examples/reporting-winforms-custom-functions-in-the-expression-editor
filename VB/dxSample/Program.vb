Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace dxSample
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New NewLineConstant())
            DevExpress.Data.Filtering.CriteriaOperator.RegisterCustomFunction(New CustomFormatFunction())

            Application.Run(New Form2())
        End Sub
    End Class
End Namespace
