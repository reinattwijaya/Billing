Imports System.IO
Public Class Main_Menu

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs)
        ToolStripStatusLabel2.Text = signin.username.Text

    End Sub

    Private Sub customerButton_Click(sender As Object, e As EventArgs) Handles customerButton.Click
        Customer.WindowState = FormWindowState.Maximized
        Customer.Show()
        Customer.Activate()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Customer.logout()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Customer.out()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Customer.WindowState = FormWindowState.Maximized
        Customer.Show()
        Customer.Activate()
        Me.Hide()
    End Sub

    Private Sub tagihanButton_Click(sender As Object, e As EventArgs) Handles tagihanButton.Click
        Tagihan.WindowState = FormWindowState.Maximized
        Tagihan.Show()
        Tagihan.Activate()
        Me.Hide()
    End Sub

    Private Sub TagihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem.Click
        Tagihan.WindowState = FormWindowState.Maximized
        Tagihan.Show()
        Tagihan.Activate()
        Me.Hide()
    End Sub

    Private Sub RateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RateToolStripMenuItem.Click
        Rate.WindowState = FormWindowState.Normal
        Rate.Show()
        Rate.Activate()
    End Sub

    Private Sub Main_Menu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        signin.Show()
        signin.username.Text = ""
        signin.password.Text = ""
        signin.username.Focus()
    End Sub

    Private Sub PengumumanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengumumanToolStripMenuItem.Click
        DataTagihan.WindowState = FormWindowState.Normal
        DataTagihan.Show()
        DataTagihan.Activate()
    End Sub

    Private Sub TagihanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem1.Click
        DataTagihan.WindowState = FormWindowState.Normal
        DataTagihan.Show()
        DataTagihan.Activate()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.WindowState = FormWindowState.Normal
        FormLaporan.Show()
        FormLaporan.Activate()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Registrasi.WindowState = FormWindowState.Normal
        Registrasi.Show()
        Registrasi.Activate()
    End Sub

    Private Sub cetakButton_Click(sender As Object, e As EventArgs) Handles cetakButton.Click
        DataTagihan.WindowState = FormWindowState.Normal
        DataTagihan.Show()
        DataTagihan.Activate()
    End Sub

    Private Sub laporanButton_Click(sender As Object, e As EventArgs) Handles laporanButton.Click
        FormLaporan.WindowState = FormWindowState.Normal
        FormLaporan.Show()
        FormLaporan.Activate()
    End Sub

    Private Sub BackUpDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpDatabaseToolStripMenuItem.Click
        Dim SourcePath As String = appDataPath & "\Indosoft\Billing\Customer.mdb"

        Using saveDialog As New SaveFileDialog()
            saveDialog.CheckFileExists = False
            saveDialog.CheckPathExists = True
            saveDialog.FileName = "Customer" & Date.Now.ToString("ddMMyyyy") & ".mdb"
            saveDialog.Filter = "Microsoft Access Database (*.mdb)|*.mdb"
            saveDialog.RestoreDirectory = True

            If saveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If System.IO.File.Exists(SourcePath) Then
                    System.IO.File.Copy(SourcePath, saveDialog.FileName, True)
                Else
                    MsgBox(SourcePath)
                End If
            End If
        End Using
    End Sub

    Private Sub PBB_Click(sender As Object, e As EventArgs) Handles PBBbutton.Click
        List_PBB.WindowState = FormWindowState.Maximized
        List_PBB.Show()
        List_PBB.Activate()
    End Sub
End Class