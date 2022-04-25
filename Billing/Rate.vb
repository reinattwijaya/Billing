Imports System.Data.OleDb
Imports System.IO
Public Class Rate

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmd1 As New OleDbCommand
        cmd1.CommandText = "SELECT * FROM Rate"
        cmd1.Connection = con
        dr = cmd1.ExecuteReader
        While dr.Read
            beban.Text = dr.GetValue(4)
            listrikPerKwh.Text = dr.GetValue(3)
            serviceA.Text = dr.GetValue(1)
            serviceB.Text = dr.GetValue(2)
            PBB1.Text = dr.GetValue(5)
            PBB2.Text = dr.GetValue(6)
        End While


        dr.Close()
        con.Close()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Dim sql As String = "UPDATE Rate SET ServiceM2A=@ServiceM2A, ServiceM2B=@ServiceM2B, ListrikPerKwh=@ListrikPerKwh, Beban=@Beban, PBB1=@PBB1, PBB2=@PBB2 WHERE ID=1"
        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@ServiceM2A", serviceA.Text)
        cmd.Parameters.AddWithValue("@ServiceM2B", serviceB.Text)
        cmd.Parameters.AddWithValue("@ListrikPerKwh", listrikPerKwh.Text)
        cmd.Parameters.AddWithValue("@Beban", beban.Text)
        cmd.Parameters.AddWithValue("@PBB1", PBB1.Text)
        cmd.Parameters.AddWithValue("@PBB2", PBB2.Text)

        Try
            con.Open()

            If cmd.ExecuteNonQuery() > 0 Then
                'MsgBox("Update berhasil!", MsgBoxStyle.Information, "Update")
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try

        Me.Close()
    End Sub

End Class