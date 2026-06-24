Imports System
Imports System.Windows.Forms

Namespace ambatubus
    Public Module Program
        <STAThread>
        Public Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            ' Initialize database on startup
            DatabaseHelper.InitializeDatabase()

            Application.Run(New frmMainMenu())
        End Sub
    End Module
End Namespace