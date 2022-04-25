Imports System.Data.OleDb
Imports System.IO

Public Class Customer

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

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel4.Text = Now
        ToolStripStatusLabel2.Text = signin.username.Text
        button.PerformClick()
        Timer2.Start()
        Timer2.Interval = 1000
        MainMenuData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        MainMenuData.Columns(1).Width = 150
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
        MainMenuData.DataSource = ds.Tables(0)

    End Sub


    Public Sub GetData()
        Dim SelectQry = "SELECT(NoCustomer) as [CustNo], (Nama) as [Nama], (NPWP) as [NPWP], (Pajak) as [Pajak], (Alamat) as [Alamat], (NIK) as [NIK], (HP) as [HP], (Email) as [Email], (KeyBCA) as [AkunVirtual], (KodeTempat) as [KodeTempat], (SewaAwal) as [SewaAwal], (SewaAkhir) as [SewaAkhir], (Lantai) as [Lantai], (NoKios) as [NoKios], (Luas) as [Luas], (NonAktif) as [NonAktif], (Modal) as [Saldo], (SaldoPBB) as [SaldoPBB] FROM customerDB group by NoCustomer, KodeTempat, Nama, NPWP, Pajak, HP, Email, SewaAwal, SewaAkhir, Alamat, NIK, KeyBCA, Luas, NoKios, Lantai, NonAktif, Modal, SaldoPBB order by NoCustomer"
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

    Public Function GetDataSearch() As DataView
        Dim SelectQry = "SELECT(NoCustomer) as [CustNo], (Nama) as [Nama],(NPWP) as [NPWP], (Pajak) as [Pajak], (Alamat) as [Alamat], (NIK) as [NIK], (HP) as [HP], (Email) as [Email], (KeyBCA) as [AkunVirtual], (KodeTempat) as [KodeTempat], (SewaAwal) as [SewaAwal], (SewaAkhir) as [SewaAkhir], (Lantai) as [Lantai], (NoKios) as [NoKios], (Luas) as [Luas], (NonAktif) as [NonAktif], (Modal) as [Saldo], (SaldoPBB) as [SaldoPBB] FROM customerDB WHERE NoCustomer LIKE @NoCustomer AND NAMA LIKE @Nama"
        Dim SampleSource As New DataSet
        Dim TableView As DataView
        Try
            Dim SampleCommand As New OleDbCommand()
            Dim SampleDataAdapter = New OleDbDataAdapter()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = Connection
            SampleCommand.Parameters.AddWithValue("@NoCustomer", "%" & noCustomer.Text & "%")
            SampleCommand.Parameters.AddWithValue("@Nama", "%" & nama.Text & "%")
            SampleDataAdapter.SelectCommand = SampleCommand
            SampleDataAdapter.Fill(SampleSource)
            TableView = SampleSource.Tables(0).DefaultView
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return TableView
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'button.PerformClick()
        ToolStripStatusLabel4.Text = Now
    End Sub

    Dim selectedRow

    'Public Sub MainMenuData_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles MainMenuData.CellMouseDoubleClick
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= -1 Then
    '        selectedRow = MainMenuData.Rows(e.RowIndex)
    '        Data.Show()

    '    End If
    'End Sub

    Public Sub logout()

        My.Application.OpenForms.Cast(Of Form)() _
              .Except({signin}) _
              .ToList() _
              .ForEach(Sub(form) form.Close())
        Main_Menu.Close()
        signin.Show()
        signin.username.Text = ""
        signin.password.Text = ""
        signin.username.Focus()
    End Sub

    Public Sub out()
        Environment.Exit(0)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        logout()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        out()
    End Sub

    Private Sub tambahButton_Click(sender As Object, e As EventArgs) Handles tambahButton.Click
        If Application.OpenForms().OfType(Of Data).Any Then
            Data.Close()
        End If
        Data.sewaAwal.Value = Now
        Data.sewaAkhir.Value = Now
        Data.update.Visible = 0
        Data.berikutUpdate.Visible = 0
        Data.WindowState = FormWindowState.Normal
        Data.Show()
        Data.Activate()

    End Sub

    Private Sub ubahButton_Click(sender As Object, e As EventArgs) Handles ubahButton.Click
        If MainMenuData.Rows.Count = 0 Then
            MsgBox("Tidak ada customer", MsgBoxStyle.Information)
            Return
        End If
        If Application.OpenForms().OfType(Of Data).Any Then
            Data.Close()
        End If
        Data.noCustomer.Text = MainMenuData.SelectedRows(0).Cells(0).Value
        Data.nama.Text = MainMenuData.SelectedRows(0).Cells(1).Value
        Data.NPWP.Text = MainMenuData.SelectedRows(0).Cells(2).Value
        Data.customerPajak.Checked = MainMenuData.SelectedRows(0).Cells(3).Value
        Data.alamat.Text = MainMenuData.SelectedRows(0).Cells(4).Value
        Data.nik.Text = MainMenuData.SelectedRows(0).Cells(5).Value
        Data.hp.Text = MainMenuData.SelectedRows(0).Cells(6).Value
        Data.email.Text = MainMenuData.SelectedRows(0).Cells(7).Value
        Data.keyBCA.Text = MainMenuData.SelectedRows(0).Cells(8).Value
        Data.kodetempat.Text = MainMenuData.SelectedRows(0).Cells(9).Value
        Data.sewaAwal.Value = MainMenuData.SelectedRows(0).Cells(10).Value
        Data.sewaAkhir.Value = MainMenuData.SelectedRows(0).Cells(11).Value
        Data.lantai.Text = MainMenuData.SelectedRows(0).Cells(12).Value
        Data.noKios.Text = MainMenuData.SelectedRows(0).Cells(13).Value
        Data.luas.Value = MainMenuData.SelectedRows(0).Cells(14).Value
        Data.nonAktif.Checked = MainMenuData.SelectedRows(0).Cells(15).Value
        Data.kode = MainMenuData.SelectedRows(0).Cells(0).Value
        Data.modal.Value = MainMenuData.SelectedRows(0).Cells(16).Value
        Data.saldoPBB.Value = MainMenuData.SelectedRows(0).Cells(17).Value
        Data.tambah.Visible = 0
        Data.berikutTambah.Visible = 0
        Data.WindowState = FormWindowState.Normal
        Data.Show()
        Data.Activate()
    End Sub

    Private Sub Customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Main_Menu.WindowState = FormWindowState.Normal
        Main_Menu.Show()
        Main_Menu.Activate()
    End Sub

    Private Function CheckTagihan() As Boolean
        con.Open()
        Dim SelectQry = "SELECT NoBukti FROM listrikDB WHERE NoCustomer=@NoCustomer"
        Dim SelectQry2 = "SELECT NoBukti FROM invoiceDB WHERE NoCustomer=@NoCustomer"
        Dim ret As Boolean
        ret = 0
        Try
            Dim SampleCommand, SampleCommand2 As New OleDbCommand()
            SampleCommand.Parameters.AddWithValue("@NoCustomer", MainMenuData.SelectedRows(0).Cells(0).Value)
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            SampleCommand2.Parameters.AddWithValue("@NoCustomer", MainMenuData.SelectedRows(0).Cells(0).Value)
            SampleCommand2.CommandText = SelectQry2
            SampleCommand2.Connection = con
            Dim reader, reader2 As OleDbDataReader
            reader = SampleCommand.ExecuteReader
            reader2 = SampleCommand2.ExecuteReader
            If reader.Read() And reader2.Read() Then
                ret = 1
            End If

        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        con.Close()
        Return ret
    End Function

    Private Sub hapusButton_Click(sender As Object, e As EventArgs) Handles hapusButton.Click
        If MainMenuData.Rows.Count = 0 Then
            MsgBox("Tidak ada customer", MsgBoxStyle.Information)
            Return
        End If

        Dim sql As String = "DELETE FROM customerDB WHERE NoCustomer=@NoCustomer"
        cmd = New OleDbCommand(sql, con)

        cmd.Parameters.AddWithValue("@NoCustomer", MainMenuData.SelectedRows(0).Cells(0).Value)
        If MsgBox("Apakah anda ingin hapus?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Delete") = MsgBoxResult.Yes Then
            ' execute command

            If CheckTagihan() = True Then
                MsgBox("Customer masih memiliki tagihan, tidak dapat dihapus", MsgBoxStyle.Information)
            Else
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

        End If
    End Sub

    Private Sub TagihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem.Click
        Me.Close()
        Tagihan.WindowState = FormWindowState.Maximized
        Tagihan.Show()
        Tagihan.Activate()
        Main_Menu.Hide()
    End Sub

    Private Sub RateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RateToolStripMenuItem.Click

        Rate.WindowState = FormWindowState.Normal
        Rate.Show()
        Rate.Activate()
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

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click
        MainMenuData.DataSource = GetDataSearch()
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

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        filter = filter + 20
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