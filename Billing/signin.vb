Imports System.Data
Imports System.Data.OleDb
Imports System.IO

Public Class signin

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If Len(Trim(username.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            username.Focus()
            Exit Sub
        End If

        If Len(Trim(password.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            password.Focus()
            Exit Sub
        End If

        Try
            Dim myConnection As OleDbConnection
            myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;")
            Dim myCommand As OleDbCommand
            myCommand = New OleDbCommand("SELECT username,password FROM login WHERE username=@username AND password=@password", myConnection)
            Dim uName As New OleDbParameter("@username", SqlDbType.VarChar)
            Dim uPassword As New OleDbParameter("@password", SqlDbType.VarChar)
            uName.Value = username.Text
            uPassword.Value = password.Text
            myCommand.Parameters.Add(uName)
            myCommand.Parameters.Add(uPassword)
            myCommand.Connection.Open()
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim Login As Object = 0
            If myReader.HasRows Then
                myReader.Read()
                Login = myReader(Login)
            End If
            If Login = Nothing Then
                MsgBox("Username atau Password salah! Coba lagi", MsgBoxStyle.Critical, "login Denied")
                username.Clear()
                password.Clear()
                username.Focus()
            Else
                Main_Menu.ToolStripStatusLabel2.Text = username.Text
                Main_Menu.Show()
                Me.Close()

            End If
            myCommand.Dispose()
            myConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Application.OpenForms.Cast(Of Form)() _
              .Except({Me}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
    End Sub
End Class
