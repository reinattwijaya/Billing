Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Public Class DataTagihan

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim modal1, bayar1, denda1, listrikAwal1, listrikAkhir1, listrikPakai1, biayaPemakaian1, beban1, listrikPerKwh1, bpju1, administrasi1, totalListrik1, luas1, biayaPerM21, serviceM2A1, serviceM2B1, jumlah1, ppn1, totalSC1, total1, diskon1, setelahDiskon1 As Double
    Public noCust1, noBukti1 As String
    Public test, pajak1 As Boolean

    Private Sub luas_ValueChanged(sender As Object, e As EventArgs) Handles luas.ValueChanged
        luas1 = luas.Value
        UpdateDataService()
    End Sub

    Private Sub diskon_ValueChanged(sender As Object, e As EventArgs) Handles diskon.ValueChanged
        diskon1 = diskon.Value
        setelahDiskon1 = total1 - diskon1 + denda1 - modal1
        setelahDiskon.Text = setelahDiskon1
    End Sub
    Public report1 As New CrystalReport1
    Private Sub printPengumuman_Click(sender As Object, e As EventArgs) Handles printPengumuman.Click
        If Application.OpenForms().OfType(Of Pengumuman).Any Then
            Pengumuman.Close()
        End If
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then
            'MsgBox("Mohon isi seluruh data!", MsgBoxStyle.Exclamation)
        Else
            Simpan()
            'Tagihan.button.PerformClick()

            report1.SetParameterValue("Nama", nama.Text)
            report1.SetParameterValue("periodeTagihan", periodeTagihan.Text)
            report1.SetParameterValue("KodeTempat", kodeTempat.Text)
            report1.SetParameterValue("Listrik", totalListrik.Value)
            report1.SetParameterValue("ServiceCharge", totalSC.Value)
            report1.SetParameterValue("Denda", denda.Value)
            report1.SetParameterValue("Diskon", diskon.Value)
            report1.SetParameterValue("Jumlah", total.Value + denda.Value - diskon.Value)
            report1.SetParameterValue("Tanggal", tanggal.Value)
            report1.SetParameterValue("TanggalAkhir", tanggal.Value)
            Pengumuman.CrystalReportViewer1.ReportSource = report1
            Pengumuman.WindowState = FormWindowState.Maximized
            Pengumuman.Show()
            Pengumuman.Activate()
        End If

    End Sub

    Private Sub denda_ValueChanged(sender As Object, e As EventArgs) Handles denda.ValueChanged
        denda1 = denda.Value
        UpdateDataListrik()
    End Sub

    Private Sub tanggal_ValueChanged_1(sender As Object, e As EventArgs) Handles tanggal.ValueChanged
        periodeTagihan.Value = tanggal.Value.AddMonths(-1)
        If Month(tanggal.Value) = 1 Then
            periodeTagihan.Value.AddYears(-1)
        End If
    End Sub

    Public report As New CrystalReport2
    Private Sub printInvoice_Click(sender As Object, e As EventArgs) Handles printInvoice.Click
        If Application.OpenForms().OfType(Of Pengumuman).Any Then
            Pengumuman.Close()
        End If
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then
            'MsgBox("Mohon isi seluruh data!", MsgBoxStyle.Exclamation)
        Else
            Simpan()
            'Tagihan.button.PerformClick()
            Dim Akun As String
            Dim qry = "SELECT KeyBCA FROM customerDB WHERE NoCustomer=@NoCustomer"
            Dim cmd = New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            con.Open()
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                Akun = dr.GetString(0)
            End While
            dr.Close()
            con.Close()

            report.SetParameterValue("Nama", nama.Text)
            report.SetParameterValue("PeriodeTagihan", periodeTagihan.Text)
            report.SetParameterValue("NoBukti", noBukti.Text)
            report.SetParameterValue("TanggalCetak", tanggal.Value)
            report.SetParameterValue("Lantai", lantai.Text)
            report.SetParameterValue("NoKios", noKios.Text)
            report.SetParameterValue("Luas", luas.Value)
            report.SetParameterValue("Biaya", biayaPerM2.Value)
            report.SetParameterValue("Jumlah", jumlah.Value)
            report.SetParameterValue("PPN", ppn.Value)
            report.SetParameterValue("ServiceCharge", totalSC.Value)
            report.SetParameterValue("ListrikAwal", listrikAwal.Value)
            report.SetParameterValue("ListrikAkhir", listrikAkhir.Value)
            report.SetParameterValue("ListrikPakai", listrikPakai.Text)
            report.SetParameterValue("BiayaPemakaian", biayaPemakaian.Value)
            report.SetParameterValue("Beban", beban.Value)
            report.SetParameterValue("BPJU", bpju.Value)
            report.SetParameterValue("Administrasi", administrasi.Value)
            report.SetParameterValue("Listrik", totalListrik.Value)
            report.SetParameterValue("Total", setelahDiskon.Value)
            report.SetParameterValue("Denda", denda.Value)
            report.SetParameterValue("Diskon", diskon.Value)
            report.SetParameterValue("Saldo", saldo.Value)
            report.SetParameterValue("akunVirtual", Akun)
            report.SetParameterValue("Keterangan", catatan.Text)
            Pengumuman.CrystalReportViewer1.ReportSource = report
            Pengumuman.WindowState = FormWindowState.Maximized
            Pengumuman.Show()
            Pengumuman.Activate()
        End If


    End Sub



    Private Sub listrikAkhir_ValueChanged(sender As Object, e As EventArgs) Handles listrikAkhir.ValueChanged
        listrikAkhir1 = listrikAkhir.Value
        UpdateDataListrik()
    End Sub

    Private Sub listrikAwal_ValueChanged(sender As Object, e As EventArgs) Handles listrikAwal.ValueChanged
        listrikAwal1 = listrikAwal.Value
        UpdateDataListrik()
    End Sub

    Private Sub simpanTutup_Click(sender As Object, e As EventArgs) Handles simpanTutup.Click
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then
            'MsgBox("Nomor Bukti atau Tipe Servis tidak boleh kosong!", MsgBoxStyle.Exclamation)
        Else
            Simpan()
            Tagihan.button.PerformClick()
            Me.Close()
        End If
    End Sub

    Private Sub simpanTambah_Click(sender As Object, e As EventArgs) Handles simpanTambah.Click
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then
            'MsgBox("Nomor Bukti atau Tipe Servis tidak boleh kosong!", MsgBoxStyle.Exclamation)
        Else
            Simpan()
            Tagihan.button.PerformClick()
            noCustomer.SelectedIndex = -1
            nama.SelectedIndex = -1
            clearTxt()

        End If
    End Sub

    Public Sub Simpan()

        If MsgBox("Apakah anda ingin mengupdate saldo?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Saldo") = MsgBoxResult.Yes Then
            ' execute command
            Dim qry3
            Dim cmd3 As OleDbCommand
            qry3 = "UPDATE customerDB SET Modal=@Modal WHERE NoCustomer=@NoCustomer"
            cmd3 = New OleDbCommand(qry3, con)
            cmd3.Parameters.AddWithValue("@Modal", saldo.Value + bayar.Value - setelahDiskon.Value)
            cmd3.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            Try
                con.Open()

                If cmd3.ExecuteNonQuery() > 0 Then
                    'MsgBox("Hapus berhasil!", MsgBoxStyle.Information, "Delete")

                End If
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()

            End Try

            setelahDiskon1 = total1 + denda1 - diskon1 - modal1
            setelahDiskon.Value = setelahDiskon1
        Else
            saldo.Value = 0

        End If

        Dim qry, qry2
        Dim cmd, cmd2 As OleDbCommand
        If CheckDataBase() Then
            qry = "UPDATE listrikDB SET NoCustomer=@NoCustomer, NoBukti=@NoBukti, ListrikAwal=@ListrikAwal, ListrikAkhir=@ListrikAkhir, TipeServis=@TipeServis WHERE NoBukti=@NoBukti AND NoCustomer=@NoCustomer"
            qry2 = "UPDATE invoiceDB SET NoCustomer=@NoCustomer, NoBukti=@NoBukti, Listrik=@Listrik, ServiceCharge=@ServiceCharge, PPn=@PPn, SCTotal=@SCTotal, Tanggal=@Tanggal, Saldo=@Saldo, Total=@Total, SetelahDiskon=@SetelahDiskon, Lunas=@Lunas, Diskon=@Diskon, Denda=@Denda, Bayar=@Bayar, Keterangan=@Keterangan WHERE NoBukti=@NoBukti AND NoCustomer=@NoCustomer"
            cmd = New OleDbCommand(qry, con)
            cmd2 = New OleDbCommand(qry2, con)
            cmd.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            cmd.Parameters.AddWithValue("@NoBukti", noBukti.Text)
            cmd.Parameters.AddWithValue("@ListrikAwal", listrikAwal.Value)
            cmd.Parameters.AddWithValue("@ListrikAkhir", listrikAkhir.Value)
            If tipeServis.SelectedIndex = 0 Then
                cmd.Parameters.AddWithValue("@TipeServis", -1)
            Else
                cmd.Parameters.AddWithValue("@TipeServis", 0)
            End If

            cmd2.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            cmd2.Parameters.AddWithValue("@NoBukti", noBukti.Text)
            cmd2.Parameters.AddWithValue("@Listrik", totalListrik.Value)
            cmd2.Parameters.AddWithValue("@ServiceCharge", jumlah.Value)
            cmd2.Parameters.AddWithValue("@PPn", ppn.Value)
            cmd2.Parameters.AddWithValue("@SCTotal", totalSC.Value)
            cmd2.Parameters.Add(New OleDbParameter("@Tanggal", OleDbType.DBDate))
            cmd2.Parameters("@Tanggal").Value = tanggal.Value
            cmd2.Parameters.AddWithValue("@Saldo", saldo.Value)
            cmd2.Parameters.AddWithValue("@Total", total.Value)
            cmd2.Parameters.AddWithValue("@SetelahDiskon", setelahDiskon.Value)
            cmd2.Parameters.AddWithValue("@Lunas", lunas.Checked)
            cmd2.Parameters.AddWithValue("@Diskon", diskon.Value)
            cmd2.Parameters.AddWithValue("@Denda", denda.Value)
            cmd2.Parameters.AddWithValue("@Bayar", bayar.Value)
            cmd2.Parameters.AddWithValue("@Keterangan", catatan.Text)
        Else
            qry = "INSERT INTO listrikDB(NoCustomer,NoBukti,ListrikAwal,ListrikAkhir,TipeServis) VALUES (@NoCustomer, @NoBukti, @ListrikAwal, @ListrikAkhir, @TipeServis)"
            qry2 = "INSERT INTO invoiceDB(NoCustomer, NoBukti, Listrik, ServiceCharge, PPn, SCTotal, Tanggal, Saldo, Total, SetelahDiskon, Lunas, Diskon, Denda, Bayar, Keterangan) VALUES (@NoCustomer, @NoBukti, @Listrik, @ServiceCharge, @PPn, @SCTotal, @Tanggal, @Saldo, @Total, @SetelahDiskon, @Lunas, @Diskon, @Denda, @Bayar, @Keterangan)"
            cmd = New OleDbCommand(qry, con)
            cmd2 = New OleDbCommand(qry2, con)

            cmd.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            cmd.Parameters.AddWithValue("@NoBukti", noBukti.Text)
            cmd.Parameters.AddWithValue("@ListrikAwal", listrikAwal.Value)
            cmd.Parameters.AddWithValue("@ListrikAkhir", listrikAkhir.Value)
            If tipeServis.SelectedIndex = 0 Then
                cmd.Parameters.AddWithValue("@TipeServis", -1)
            Else
                cmd.Parameters.AddWithValue("@TipeServis", 0)
            End If

            cmd2.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            cmd2.Parameters.AddWithValue("@NoBukti", noBukti.Text)
            cmd2.Parameters.AddWithValue("@Listrik", totalListrik.Value)
            cmd2.Parameters.AddWithValue("@ServiceCharge", jumlah.Value)
            cmd2.Parameters.AddWithValue("@PPn", ppn.Value)
            cmd2.Parameters.AddWithValue("@SCTotal", totalSC.Value)
            cmd2.Parameters.Add(New OleDbParameter("@Tanggal", OleDbType.DBDate))
            cmd2.Parameters("@Tanggal").Value = tanggal.Value
            cmd2.Parameters.AddWithValue("@Saldo", saldo.Value)
            cmd2.Parameters.AddWithValue("@Total", total.Value)
            cmd2.Parameters.AddWithValue("@SetelahDiskon", setelahDiskon.Value)
            cmd2.Parameters.AddWithValue("@Lunas", lunas.Checked)
            cmd2.Parameters.AddWithValue("@Diskon", diskon.Value)
            cmd2.Parameters.AddWithValue("@Denda", denda.Value)
            cmd2.Parameters.AddWithValue("@Bayar", bayar.Value)
            cmd2.Parameters.AddWithValue("@Keterangan", catatan.Text)


        End If

        'Dim debugSQL As String = cmd.CommandText
        'For Each param As OleDbParameter In cmd.Parameters
        '    debugSQL = debugSQL.Replace(param.ParameterName, param.Value.ToString())
        'Next
        'MsgBox(debugSQL)


        Try
            con.Open()
            If cmd.ExecuteNonQuery() > 0 And cmd2.ExecuteNonQuery() > 0 Then
                ' MsgBox("Berhasil!", MsgBoxStyle.Information)
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try

    End Sub

    Private Sub tipeServis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipeServis.SelectedIndexChanged
        UpdateDataService()
    End Sub

    Private Sub tanggal_ValueChanged(sender As Object, e As EventArgs)
        periodeTagihan.Value = tanggal.Value.AddMonths(-1)
    End Sub

    Public Sub init()

        If test = True Then
            Dim a, b As Integer
            a = noCustomer.FindString(noCust1)
            noCustomer.SelectedIndex = a
            b = noBukti.FindString(noBukti1)
            noBukti.SelectedIndex = b
            test = 0
        End If


    End Sub

    Private Sub DataTagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        noCustomer.Items.Clear()
        nama.Items.Clear()
        Dim cmd1 As New OleDbCommand
        cmd1.CommandText = "SELECT NoCustomer, Nama FROM customerDB"

        cmd1.Connection = con

        Dim dr As OleDbDataReader
        dr = cmd1.ExecuteReader

        While dr.Read
            noCustomer.AutoCompleteCustomSource.Add(dr.GetString(0))
            nama.AutoCompleteCustomSource.Add(dr.GetString(1))
            noCustomer.Items.Add(dr.GetString(0))
            nama.Items.Add(dr.GetString(1))
        End While

        dr.Close()

        con.Close()

        tipeServis.Items.Add("Service M2 Lt 2")
        tipeServis.Items.Add("Service M2 Lt 1")
        diskon.Controls.RemoveAt(0)
        biayaPemakaian.Controls.RemoveAt(0)
        beban.Controls.RemoveAt(0)
        bpju.Controls.RemoveAt(0)
        administrasi.Controls.RemoveAt(0)
        totalListrik.Controls.RemoveAt(0)
        biayaPerM2.Controls.RemoveAt(0)
        jumlah.Controls.RemoveAt(0)
        ppn.Controls.RemoveAt(0)
        totalSC.Controls.RemoveAt(0)
        total.Controls.RemoveAt(0)
        setelahDiskon.Controls.RemoveAt(0)
        denda.Controls.RemoveAt(0)
        bayar.Controls.RemoveAt(0)
        saldo.Controls.RemoveAt(0)

        tanggal.Value = Now


        If test = True Then
            Dim a, b As Integer
            a = noCustomer.FindString(noCust1)
            noCustomer.SelectedIndex = a
            b = noBukti.FindString(noBukti1)
            noBukti.SelectedIndex = b
            test = 0
        End If
    End Sub

    Public Function CheckCustomer() As Boolean
        Dim ret As Boolean
        ret = 1
        For Each i As String In noCustomer.Items
            If i = noCustomer.Text Then
                ret = 0
            End If
        Next

        Return ret
    End Function

    Public Function CheckDataBase() As Boolean
        con.Open()
        Dim SelectQry = "SELECT NoBukti FROM listrikDB WHERE NoBukti=@NoBukti AND NoCustomer=@NoCustomer"
        Dim SelectQry2 = "SELECT NoBukti FROM invoiceDB WHERE NoBukti=@NoBukti AND NoCustomer=@NoCustomer"
        Dim ret As Boolean
        ret = 0
        Try
            Dim SampleCommand, SampleCommand2 As New OleDbCommand()
            SampleCommand.Parameters.AddWithValue("@NoBukti", noBukti.Text)
            SampleCommand.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            SampleCommand2.Parameters.AddWithValue("@NoBukti", noBukti.Text)
            SampleCommand2.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
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

    Public Function CheckNama() As Boolean
        Dim ret As Boolean
        ret = 1
        For Each i As String In nama.Items
            If i = nama.Text Then
                ret = 0
            End If
        Next
        Return ret
    End Function

    Public Function CheckData() As Boolean
        Dim ret As Boolean
        ret = 0
        If String.IsNullOrEmpty(noBukti.Text) Then
            MsgBox("Nomor Bukti tidak boleh kosong", MsgBoxStyle.Exclamation)
            ret = 1
            noBukti.Focus()
        ElseIf tipeServis.SelectedIndex = -1 Then
            MsgBox("Tipe Servis tidak boleh kosong", MsgBoxStyle.Exclamation)
            ret = 1
        End If
        Return ret
    End Function

    Public Sub UpdateDataListrik()
        listrikPakai1 = listrikAkhir1 - listrikAwal1
        biayaPemakaian1 = listrikPerKwh1 * listrikPakai1
        bpju1 = (biayaPemakaian1 + beban1) / 5
        administrasi1 = (biayaPemakaian1 + beban1 + bpju1) / 5
        totalListrik1 = biayaPemakaian1 + beban1 + bpju1 + administrasi1
        total1 = totalListrik1 + totalSC1
        setelahDiskon1 = total1 - diskon1 + denda1

        luas1 = luas.Value
        listrikPakai.Text = listrikPakai1
        biayaPemakaian.Text = biayaPemakaian1
        bpju.Text = bpju1
        administrasi.Text = administrasi1
        totalListrik.Text = totalListrik1
        total.Text = total1
        setelahDiskon.Text = setelahDiskon1
    End Sub

    Public Sub UpdateDataService()
        If tipeServis.Text = "Service M2 Lt 2" Then
            biayaPerM21 = serviceM2A1
        ElseIf tipeServis.Text = "Service M2 Lt 1" Then
            biayaPerM21 = serviceM2B1
        End If
        jumlah1 = luas1 * biayaPerM21
        If pajak1 = True Then
            ppn1 = jumlah1 / 10
        Else
            ppn1 = 0
        End If
        totalSC1 = jumlah1 + ppn1
        total1 = totalListrik1 + totalSC1
        setelahDiskon1 = total1 - diskon1 + denda1

        biayaPerM2.Text = biayaPerM21
        jumlah.Text = jumlah1
        ppn.Text = ppn1
        totalSC.Text = totalSC1
        total.Text = total1
        setelahDiskon.Text = setelahDiskon1

    End Sub

    Public Sub clearTxt()

        kodeTempat.Text = ""
        noBukti.Text = ""
        tanggal.Value = Now
        listrikAwal.Value = 0
        listrikAkhir.Value = 0
        listrikPakai.Text = ""
        biayaPemakaian.Value = 0
        beban.Value = 0
        administrasi.Value = 0
        bpju.Value = 0
        totalListrik.Value = 0
        noKios.Text = ""
        lantai.Text = ""
        catatan.Text = ""
        luas.Value = 0
        tipeServis.SelectedIndex = -1
        biayaPerM2.Value = 0
        jumlah.Value = 0
        ppn.Value = 0
        totalSC.Value = 0
        total.Value = 0
        diskon.Value = 0
        setelahDiskon.Value = 0
        saldo.Value = 0
        bayar.Value = 0
        listrikAwal1 = 0
        listrikAkhir1 = 0
        listrikPakai1 = 0
        biayaPemakaian1 = 0
        beban1 = 0
        administrasi1 = 0
        bpju1 = 0
        totalListrik1 = 0
        luas1 = 0
        biayaPerM21 = 0
        jumlah1 = 0
        ppn1 = 0
        totalSC1 = 0
        total1 = 0
        diskon1 = 0
        setelahDiskon1 = 0
        lunas.Checked = 0
        denda.Value = 0
        denda1 = 0
        modal1 = 0
        bayar1 = 0
        pajak1 = False
    End Sub

    Public Sub GetData()
        Dim SelectQry = "SELECT KodeTempat, Lantai, NoKios, Luas, Modal, Pajak FROM customerDB WHERE NoCustomer=@NoCustomer"
        Dim SelectQry2 = "SELECT ServiceM2A, ServiceM2B, ListrikPerKwh, Beban FROM Rate WHERE ID = 1"


        Try
            con.Open()
            Dim SampleCommand, SampleCommand2 As New OleDbCommand()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            SampleCommand.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            Dim dr As OleDbDataReader
            dr = SampleCommand.ExecuteReader
            While dr.Read

                kodeTempat.Text = dr.GetString(0)
                lantai.Text = dr.GetString(1)
                noKios.Text = dr.GetString(2)
                luas.Value = dr.GetDecimal(3)
                saldo.Value = dr.GetValue(4)
                pajak1 = dr.GetBoolean(5)

            End While
            dr.Close()
            modal1 = saldo.Value

            SampleCommand2.CommandText = SelectQry2
            SampleCommand2.Connection = con
            Dim dr2 As OleDbDataReader
            dr2 = SampleCommand2.ExecuteReader
            While dr2.Read
                serviceM2A1 = dr2.GetValue(0)
                serviceM2B1 = dr2.GetValue(1)
                listrikPerKwh1 = dr2.GetValue(2)
                beban1 = dr2.GetValue(3)

            End While
            dr2.Close()

            beban.Value = beban1

            UpdateDataListrik()

            noBukti.Items.Clear()
            Dim cmd3 As New OleDbCommand
            cmd3.CommandText = "SELECT NoBukti FROM invoiceDB WHERE NoCustomer=@NoCustomer"
            cmd3.Connection = con
            cmd3.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            Dim dr3 As OleDbDataReader

            dr3 = cmd3.ExecuteReader
            If dr3.HasRows Then
                While dr3.Read
                    noBukti.AutoCompleteCustomSource.Add(dr3.GetString(0))
                    noBukti.Items.Add(dr3.GetString(0))
                End While

            End If
            dr3.Close()
        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        con.Close()
    End Sub

    Public Sub GetDataBukti()
        Dim SelectQry = "SELECT I.Tanggal, L.ListrikAwal, L.ListrikAkhir, I.Diskon, I.Lunas, L.TipeServis, I.Denda, I.Bayar, I.Keterangan FROM invoiceDB I LEFT JOIN listrikDB L ON I.NoBukti=L.NoBukti WHERE I.NoBukti=@NoBukti"

        Try
            con.Open()
            Dim SampleCommand, SampleCommand2 As New OleDbCommand()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            SampleCommand.Parameters.AddWithValue("@NoBukti", noBukti.Text)
            Dim dr As OleDbDataReader
            dr = SampleCommand.ExecuteReader
            While dr.Read

                If dr.IsDBNull(0) Then
                    tanggal.Value = Now
                Else
                    tanggal.Value = dr.GetValue(0)
                End If

                If dr.IsDBNull(1) Then
                    listrikAwal.Value = 0
                Else
                    listrikAwal.Value = dr.GetValue(1)
                End If
                If dr.IsDBNull(2) Then
                    listrikAkhir.Value = 0
                Else
                    listrikAkhir.Value = dr.GetValue(2)
                End If
                If dr.IsDBNull(3) Then
                    diskon.Value = 0
                    diskon1 = 0
                Else
                    diskon.Value = dr.GetValue(3)
                    diskon1 = dr.GetValue(3)
                End If

                If dr.IsDBNull(4) Then
                    lunas.Checked = 0
                Else
                    lunas.Checked = dr.GetBoolean(4)
                End If
                If dr.IsDBNull(5) Then
                    tipeServis.SelectedIndex = -1
                Else
                    If dr.GetBoolean(5) <> 0 Then
                        tipeServis.SelectedIndex = 0
                    Else
                        tipeServis.SelectedIndex = 1
                    End If
                End If
                If dr.IsDBNull(6) Then
                    denda.Value = 0
                Else
                    denda.Value = dr.GetValue(6)
                End If
                If dr.IsDBNull(7) Then
                    bayar.Value = 0
                Else
                    bayar.Value = dr.GetValue(7)
                End If
                If dr.IsDBNull(8) Then
                    catatan.Text = ""
                Else
                    catatan.Text = dr.GetString(8)
                End If



            End While
            dr.Close()
            listrikAwal1 = listrikAwal.Value
            listrikAkhir1 = listrikAkhir.Value
            denda1 = denda.Value
            bayar1 = bayar.Value
            periodeTagihan.Value = tanggal.Value.AddMonths(-1)

            UpdateDataListrik()

        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        con.Close()
    End Sub

    Private Sub noCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles noCustomer.SelectedIndexChanged
        If noCustomer.SelectedIndex <> -1 Then
            nama.SelectedIndex = noCustomer.SelectedIndex
            clearTxt()
        End If
        nama.Refresh()
        GetData()
    End Sub
    Private Sub nama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nama.SelectedIndexChanged
        If nama.SelectedIndex <> -1 Then
            noCustomer.SelectedIndex = nama.SelectedIndex
            clearTxt()
        End If
        noCustomer.Refresh()
        GetData()
    End Sub

    Private Sub noBukti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles noBukti.SelectedIndexChanged

        GetDataBukti()
    End Sub



End Class