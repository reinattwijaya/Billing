Imports System.Data.OleDb
Imports System.IO

Public Class Registrasi

    Dim sSql As String
    Dim rdr As OleDbDataReader = Nothing

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim qry = "UPDATE login SET [password] = @password WHERE ID = 1"
        cmd = New OleDbCommand(qry, con)
        cmd.Parameters.AddWithValue("@password", password.Text)
        Try
            con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                'MsgBox("Berhasil!", MsgBoxStyle.Information)
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
        Me.Close()


    End Sub




End Class