Imports System.Data.OleDb
Imports System.IO
Imports System.Linq

Public Class PBB_List

    Dim sSql As String
    Dim rdr As OleDbDataReader = Nothing

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
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
    Private Sub Tagihan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Menu.WindowState = FormWindowState.Normal
        Main_Menu.Show()
        Main_Menu.Activate()
    End Sub

    Private Sub Tagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = signin.username.Text
        button.PerformClick()
        TagihanData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        TagihanData.Columns(1).Width = 150
    End Sub


    Private ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Private ReadOnly Property Connection() As OleDbConnection
        Get
            Dim connectionToFetch As New OleDbConnection(ConnectionString)
            connectionToFetch.Open()
            Return connectionToFetch
        End Get
    End Property

    Public Function GetData() As DataView
        Dim SelectQry = "SELECT (C.NoCustomer) As [NoCustomer], (C.Nama) As [Nama], (C.NonAktif) As [NonAktif], (C.Luas) As [Luas], (I.NoBukti) As [NoBukti], (I.ServiceCharge) As [ServiceCharge], (I.PPn) As [PPn], (I.SCTotal) As [SCTotal], (I.Listrik) As [Listrik], (I.Saldo) As [Saldo], (I.Total) As [SubTotal], (I.Diskon) As [Diskon],(I.Denda) As [Denda], (I.SetelahDiskon) As [Total], (I.Tanggal) As [Tanggal], (I.Lunas) As [Lunas], (I.Bayar) As [Bayar], (I.Keterangan) As [Ket] FROM customerDB C INNER JOIN invoiceDB I ON C.NoCustomer = I.NoCustomer ORDER BY C.NoCustomer"
        Dim SampleSource As New DataSet
        Dim TableView As New DataView
        Try
            Dim SampleCommand As New OleDbCommand()
            Dim SampleDataAdapter = New OleDbDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView

        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return TableView
    End Function

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        TagihanData.DataSource = GetData()

    End Sub

    Private Sub cariButton_Click(sender As Object, e As EventArgs) Handles cariButton.Click
        Dim SelectQry = "SELECT (C.NoCustomer) As [NoCustomer], (C.Nama) As [Nama], (C.NonAktif) As [NonAktif], (C.Luas) As [Luas], (I.NoBukti) As [NoBukti], (I.ServiceCharge) As [ServiceCharge], (I.PPn) As [PPn], (I.SCTotal) As [SCTotal], (I.Listrik) As [Listrik], (I.Saldo) As [Saldo], (I.Total) As [Total], (I.Diskon) As [Diskon], (I.Denda) As [Denda], (I.SetelahDiskon) As [SetelahDiskon], (I.Tanggal) As [Tanggal], (I.Lunas) As [Lunas], (I.Bayar) As [Bayar], (I.Keterangan) As [Ket] FROM customerDB C INNER JOIN invoiceDB I ON C.NoCustomer = I.NoCustomer WHERE I.Tanggal BETWEEN @TanggalAwal1 AND @TanggalAkhir1 AND I.Lunas=@Lunas1 AND C.Nama LIKE @NAMA ORDER BY C.NoCustomer"
        Dim SampleSource As New DataSet
        Dim TableView As New DataView
        Try
            Dim SampleCommand As New OleDbCommand()
            Dim SampleDataAdapter = New OleDbDataAdapter()
            SampleCommand.Parameters.AddWithValue("@TanggalAwal1", tanggalAwal.Value)
            SampleCommand.Parameters.AddWithValue("@TanggalAkhir1", tanggalAkhir.Value)
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

        TagihanData.DataSource = TableView
    End Sub

    Private Sub tambahButton_Click(sender As Object, e As EventArgs) Handles tambahButton.Click
        If Application.OpenForms().OfType(Of DataTagihan).Any Then
            DataTagihan.Close()
        End If
        DataTagihan.WindowState = FormWindowState.Normal
        DataTagihan.Show()
        DataTagihan.Activate()
    End Sub

    Private Sub hapusButton_Click(sender As Object, e As EventArgs) Handles hapusButton.Click
        If TagihanData.Rows.Count = 0 Then
            MsgBox("Tidak ada tagihan", MsgBoxStyle.Information)
            Return
        End If
        Dim sql As String = "DELETE I.*, L.* FROM invoiceDB I INNER JOIN listrikDB L ON I.NoBukti=L.NoBukti AND I.NoCustomer=L.NoCustomer WHERE I.NoCustomer=@NoCustomer AND I.NoBukti=@NoBukti"
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@NoCustomer", TagihanData.SelectedRows(0).Cells(0).Value)
        cmd.Parameters.AddWithValue("@NoBukti", TagihanData.SelectedRows(0).Cells(4).Value)
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
        If Application.OpenForms().OfType(Of DataTagihan).Any Then
            DataTagihan.Close()
        End If
        If TagihanData.Rows.Count = 0 Then
            MsgBox("Tidak ada tagihan", MsgBoxStyle.Information)
            Return
        End If

        DataTagihan.noCust1 = TagihanData.SelectedRows(0).Cells(0).Value
        DataTagihan.noBukti1 = TagihanData.SelectedRows(0).Cells(4).Value
        DataTagihan.test = 1

        DataTagihan.WindowState = FormWindowState.Normal
        DataTagihan.Show()
        DataTagihan.Activate()
        'DataTagihan.init()

    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
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