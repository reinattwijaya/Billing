Imports System.Data.OleDb
Imports System.IO
Imports System.Linq

Public Class List_PBB

    Dim sSql As String
    Dim rdr As OleDbDataReader = Nothing

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand

    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim filter, totalRecord As Integer

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Customer.logout()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Customer.out()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        Me.Close()
        Customer.WindowState = FormWindowState.Maximized
        Customer.Show()
        Customer.Activate()
        Main_Menu.Hide()
    End Sub
    Private Sub List_PBB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Menu.WindowState = FormWindowState.Normal
        Main_Menu.Show()
        Main_Menu.Activate()
    End Sub

    Private Sub List_PBB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = signin.username.Text
        button.PerformClick()
        List_PBBData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        List_PBBData.Columns(1).Width = 150
        tanggalAkhir.Value = Now
        tanggalAwal.Value = Now
        pageNumber.Controls.RemoveAt(0)
    End Sub


    Private ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Private ReadOnly Property Connection() As OleDbConnection
        Get
            Dim connectionToFetch As New OleDbConnection(ConnectionString)
            connectionToFetch.Open()
            Return connectionToFetch
        End Get
    End Property

    Public Sub GetData()
        Dim SelectQry = "SELECT (C.NoCustomer) As [NoCustomer], (C.Nama) As [Nama], (C.NamaPemilik) As [NamaPemilik], (P.NoKwitansi) As [NoKwitansi], (P.Tahun) As [Tahun], (P.TanggalKwitansi) As [TanggalKwitansi], (P.SubTotal) As [SubTotal], (P.Denda) As [Denda], (P.SIST) As [SIST], (P.Saldo) As [Saldo], (P.Total) As [Total], (P.Bayar) As [Bayar], (P.Lunas) As [Lunas] FROM customerDB C INNER JOIN PBB P ON C.NoCustomer = P.NoCustomer ORDER BY C.NoCustomer"

        Try
            Dim SampleCommand As New OleDbCommand()
            da = New OleDbDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            da.SelectCommand = SampleCommand
            ds = New DataSet
            Dim tempDs As New DataSet
            da.Fill(tempDs)
            da.Fill(ds, filter, 20, "table")
            totalRecord = tempDs.Tables(0).Rows.Count

        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Cek()
        If filter = 0 Then
            prevButton.Enabled = False
        Else
            prevButton.Enabled = True
        End If
        If filter + 20 > totalRecord Then
            nextButton.Enabled = False
        Else
            nextButton.Enabled = True
        End If
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        GetData()
        Cek()
        pageNumber.Value = Convert.ToInt32(filter / 20) + 1
        List_PBBData.DataSource = ds.Tables(0)

    End Sub

    Private Sub cariButton_Click(sender As Object, e As EventArgs) Handles cariButton.Click
        Dim SelectQry = "SELECT (C.NoCustomer) As [NoCustomer], (C.Nama) As [Nama], (C.NamaPemilik) As [NamaPemilik], (P.NoKwitansi) As [NoKwitansi], (P.Tahun) As [Tahun], (P.TanggalKwitansi) As [TanggalKwitansi], (P.SubTotal) As [SubTotal], (P.Denda) As [Denda], (P.SIST) As [SIST], (P.Saldo) As [Saldo], (P.Total) As [Total], (P.Bayar) As [Bayar], (P.Lunas) As [Lunas] FROM customerDB C INNER JOIN PBB P ON C.NoCustomer = P.NoCustomer WHERE P.TanggalKwitansi BETWEEN @TanggalAwal1 AND @TanggalAkhir1 AND P.Lunas=@Lunas1 AND C.Nama LIKE @NAMA ORDER BY C.NoCustomer"
        Dim SampleSource As New DataSet
        Dim TableView As New DataView
        Try
            Dim SampleCommand As New OleDbCommand()
            Dim SampleDataAdapter = New OleDbDataAdapter()
            SampleCommand.Parameters.Add(New OleDbParameter("@TanggalAwal1", OleDbType.DBDate))
            SampleCommand.Parameters("@TanggalAwal1").Value = tanggalAwal.Value
            SampleCommand.Parameters.Add(New OleDbParameter("@TanggalAkhir1", OleDbType.DBDate))
            SampleCommand.Parameters("@TanggalAkhir1").Value = tanggalAkhir.Value
            SampleCommand.Parameters.AddWithValue("@Lunas1", lunas.Checked)
            SampleCommand.Parameters.AddWithValue("@Nama", "%" & nama.Text & "%")
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView

        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        List_PBBData.DataSource = TableView
    End Sub

    Private Sub tambahButton_Click(sender As Object, e As EventArgs) Handles tambahButton.Click
        If Application.OpenForms().OfType(Of PBB).Any Then
            PBB.Close()
        End If
        PBB.WindowState = FormWindowState.Normal
        PBB.Show()
        PBB.Activate()
    End Sub

    Private Sub hapusButton_Click(sender As Object, e As EventArgs) Handles hapusButton.Click
        If List_PBBData.Rows.Count = 0 Then
            MsgBox("Tidak ada List PBB", MsgBoxStyle.Information)
            Return
        End If
        Dim sql As String = "DELETE * FROM PBB WHERE NoCustomer=@NoCustomer AND Tahun=@Tahun"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@NoCustomer", List_PBBData.SelectedRows(0).Cells(0).Value)
        cmd.Parameters.AddWithValue("@Tahun", List_PBBData.SelectedRows(0).Cells(4).Value)
        If MsgBox("Apakah anda ingin hapus?", MsgBoxStyle.OkCancel Or MsgBoxStyle.Critical, "Delete") = MsgBoxResult.Ok Then
            ' execute command

            Try
                con.Open()

                If cmd.ExecuteNonQuery() > 0 Then
                    'MsgBox("Hapus berhasil!", MsgBoxStyle.Information, "Delete")

                End If
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()

            End Try

            button.PerformClick()
        End If
    End Sub

    Private Sub RateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RateToolStripMenuItem.Click
        Rate.WindowState = FormWindowState.Normal
        Rate.Show()
        Rate.Activate()


    End Sub

    Private Sub printLaporan_Click(sender As Object, e As EventArgs)
        Laporan.WindowState = FormWindowState.Maximized
        Laporan.Show()
        Laporan.Activate()
    End Sub

    Private Sub PengumumanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengumumanToolStripMenuItem.Click
        DataTagihan.WindowState = FormWindowState.Normal
        DataTagihan.Show()
        DataTagihan.Activate()
    End Sub



    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        FormLaporan.WindowState = FormWindowState.Normal
        FormLaporan.Show()
        FormLaporan.Activate()
    End Sub

    Private Sub Invoice_Click(sender As Object, e As EventArgs) Handles Invoice.Click
        DataTagihan.WindowState = FormWindowState.Normal
        DataTagihan.Show()
        DataTagihan.Activate()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationToolStripMenuItem.Click
        Registrasi.WindowState = FormWindowState.Normal
        Registrasi.Show()
        Registrasi.Activate()
    End Sub

    Private Sub ubah_Click(sender As Object, e As EventArgs) Handles ubah.Click
        If Application.OpenForms().OfType(Of PBB).Any Then
            PBB.Close()
        End If
        If List_PBBData.Rows.Count = 0 Then
            MsgBox("Tidak ada List PBB", MsgBoxStyle.Information)
            Return
        End If

        PBB.noCust1 = List_PBBData.SelectedRows(0).Cells(0).Value
        PBB.tahun1 = List_PBBData.SelectedRows(0).Cells(4).Value
        PBB.test = True

        PBB.WindowState = FormWindowState.Normal
        PBB.Show()
        PBB.Activate()

    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        button.PerformClick()
    End Sub

    Private Sub prevButton_Click(sender As Object, e As EventArgs) Handles prevButton.Click
        filter = filter - 20
        If filter <= 0 Then
            filter = 0
        End If
        ds.Clear()
        'da.Fill(ds, filter, 20, "table")
        button.PerformClick()
    End Sub

    Private Sub pageNumber_ValueChanged(sender As Object, e As EventArgs) Handles pageNumber.ValueChanged
        If 20 * (pageNumber.Value - 1) > totalRecord Then
            MsgBox("Jumlah halaman melebihi batas", MsgBoxStyle.Exclamation)
            pageNumber.Value = Math.Ceiling(totalRecord / 20)
        End If
        filter = 20 * (pageNumber.Value - 1)
        ds.Clear()
        button.PerformClick()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        filter = filter + 20
        ds.Clear()
        'da.Fill(ds, filter, 20, "table")
        button.PerformClick()
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
                End If
            End If
        End Using
    End Sub
End Class