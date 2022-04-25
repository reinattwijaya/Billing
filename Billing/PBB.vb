Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class PBB

    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)

    Dim PBB1, PBB2 As Double

    Public noCust1, tahun1 As String
    Public test As Boolean

    Private Sub PBB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        biayaPBB.Controls.RemoveAt(0)
        subtotal.Controls.RemoveAt(0)
        saldo.Controls.RemoveAt(0)
        bayar.Controls.RemoveAt(0)
        PBBbayar.Checked = True
        SISTbayar.Checked = True

        tanggal.Value = Now

        If test = True Then
            Dim a, b As Integer
            a = noCustomer.FindString(noCust1)
            noCustomer.SelectedIndex = a
            b = tahun.FindString(tahun1)
            tahun.SelectedIndex = b
            test = False
        End If

    End Sub

    Public Sub clearTxt()
        namaPemilik.Text = ""
        noKwitansi.Text = ""
        tanggal.Value = Now
        lantai.Text = ""
        noKios.Text = ""
        luas.Value = 0
        biayaPBB.Value = 0
        subtotal.Value = 0
        saldo.Value = 0
        PBB1 = 0
        PBB2 = 0
        bayar.Value = 0
        sist.Value = 0
        denda.Value = 0
        lunas.Checked = False
        PBBbayar.Checked = True
        SISTbayar.Checked = True
    End Sub

    Public Sub GetData()
        Dim SelectQry = "SELECT Lantai, NoKios, Luas, SaldoPBB, NamaPemilik FROM customerDB WHERE NoCustomer=@NoCustomer"
        Dim SelectQry2 = "SELECT PBB1, PBB2 FROM Rate WHERE ID = 1"


        Try
            con.Open()
            Dim SampleCommand, SampleCommand2 As New OleDbCommand()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            SampleCommand.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            Dim dr As OleDbDataReader
            dr = SampleCommand.ExecuteReader
            While dr.Read


                If dr.IsDBNull(0) Then
                    lantai.Text = ""
                Else
                    lantai.Text = dr.GetString(0)
                End If
                If dr.IsDBNull(1) Then
                    noKios.Text = ""
                Else
                    noKios.Text = dr.GetString(1)
                End If
                If dr.IsDBNull(2) Then
                    luas.Value = 0
                Else
                    luas.Value = dr.GetValue(2)
                End If
                If dr.IsDBNull(3) Then
                    saldo.Value = 0
                Else
                    saldo.Value = dr.GetValue(3)
                End If
                If dr.IsDBNull(4) Then
                    namaPemilik.Text = ""
                Else
                    namaPemilik.Text = dr.GetString(4)
                End If


            End While
            dr.Close()

            SampleCommand2.CommandText = SelectQry2
            SampleCommand2.Connection = con
            Dim dr2 As OleDbDataReader
            dr2 = SampleCommand2.ExecuteReader
            While dr2.Read
                PBB1 = dr2.GetValue(0)
                PBB2 = dr2.GetValue(1)
            End While
            dr2.Close()

            If lantai.Text = "1" Then
                biayaPBB.Value = PBB1
            Else
                biayaPBB.Value = PBB2
            End If

            tahun.Items.Clear()
            Dim cmd3 As New OleDbCommand
            cmd3.CommandText = "SELECT tahun FROM PBB WHERE NoCustomer=@NoCustomer"
            cmd3.Connection = con
            cmd3.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            Dim dr3 As OleDbDataReader

            dr3 = cmd3.ExecuteReader
            If dr3.HasRows Then
                While dr3.Read
                    tahun.AutoCompleteCustomSource.Add(dr3.GetString(0))
                    tahun.Items.Add(dr3.GetString(0))
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
        Dim SelectQry = "SELECT NoKwitansi, TanggalKwitansi, SubTotal, Denda, SIST, Saldo, Total, Bayar, Lunas FROM PBB WHERE NoCustomer=@NoCustomer AND Tahun=@Tahun"

        Try
            con.Open()
            Dim SampleCommand, SampleCommand2 As New OleDbCommand()
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            SampleCommand.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            SampleCommand.Parameters.AddWithValue("@Tahun", tahun.Text)
            Dim dr As OleDbDataReader
            dr = SampleCommand.ExecuteReader
            While dr.Read

                If dr.IsDBNull(0) Then
                    noKwitansi.Text = ""
                Else
                    noKwitansi.Text = dr.GetString(0)
                End If

                If dr.IsDBNull(1) Then
                    tanggal.Value = Now
                Else
                    tanggal.Value = dr.GetValue(1)
                End If
                If dr.IsDBNull(2) Then
                    subtotal.Value = 0
                Else
                    subtotal.Value = dr.GetValue(2)
                End If
                If dr.IsDBNull(3) Then
                    denda.Value = 0
                Else
                    denda.Value = dr.GetValue(3)
                End If
                If dr.IsDBNull(4) Then
                    sist.Value = 0
                Else
                    sist.Value = dr.GetValue(4)
                End If
                If dr.IsDBNull(5) Then
                    saldo.Value = 0
                Else
                    saldo.Value = dr.GetValue(5)
                End If
                If dr.IsDBNull(6) Then
                    total.Value = 0
                Else
                    total.Value = dr.GetValue(6)
                End If
                If dr.IsDBNull(7) Then
                    bayar.Value = 0
                Else
                    bayar.Value = dr.GetValue(7)
                End If
                If dr.IsDBNull(8) Then
                    lunas.Checked = 0
                Else
                    lunas.Checked = dr.GetValue(8)
                End If



            End While
            dr.Close()

            ubah()

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

    Public Function CheckData() As Boolean
        Dim ret As Boolean
        ret = 0
        If String.IsNullOrEmpty(tahun.Text) Then
            MsgBox("Tahun tidak boleh kosong", MsgBoxStyle.Exclamation)
            ret = 1
            tahun.Focus()
        End If
        Return ret
    End Function

    Public Function CheckDataBase() As Boolean

        con.Open()
        Dim SelectQry = "SELECT Tahun FROM PBB WHERE Tahun=@Tahun AND NoCustomer=@NoCustomer"
        Dim ret As Boolean
        ret = 0
        Try
            Dim SampleCommand As New OleDbCommand()
            SampleCommand.Parameters.AddWithValue("@Tahun", tahun.Text)
            SampleCommand.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            SampleCommand.CommandText = SelectQry
            SampleCommand.Connection = con
            Dim reader As OleDbDataReader
            reader = SampleCommand.ExecuteReader
            If reader.Read() Then
                ret = 1
            End If

        Catch ex As Exception
            Throw ex
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        'MsgBox(tahun.Text + " " + noCustomer.Text + " " + Convert.ToString(ret))
        con.Close()
        Return ret
    End Function

    Public Sub Simpan()
        Dim qry3
        Dim cmd3 As OleDbCommand
        qry3 = "UPDATE customerDB SET NamaPemilik=@NamaPemilik WHERE NoCustomer=@NoCustomer"
        cmd3 = New OleDbCommand(qry3, con)
        cmd3.Parameters.AddWithValue("@NamaPemilik", namaPemilik.Text)
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

        If MsgBox("Apakah anda ingin mengupdate saldo?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "Saldo") = MsgBoxResult.Yes Then
            ' execute command
            qry3 = "UPDATE customerDB SET SaldoPBB=@SaldoPBB WHERE NoCustomer=@NoCustomer"
            cmd3 = New OleDbCommand(qry3, con)
            cmd3.Parameters.AddWithValue("@SaldoPBB", saldo.Value + bayar.Value - total.Value)
            cmd3.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            Try
                con.Open()

                If cmd3.ExecuteNonQuery() > 0 Then
                    'MsgBox("Saldo berhasil", MsgBoxStyle.Information, "Saldo")

                End If
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()

            End Try

            total.Value = subtotal.Value - saldo.Value + sist.Value + denda.Value

        Else
            saldo.Value = 0

        End If

        Dim qry
        Dim cmd As OleDbCommand
        If CheckDataBase() Then
            qry = "UPDATE PBB SET NoCustomer=@NoCustomer, Tahun=@Tahun, TanggalKwitansi=@TanggalKwitansi, NoKwitansi=@NoKwitansi, SubTotal=@SubTotal, Denda=@Denda, SIST=@SIST, Saldo=@Saldo, Total=@Total, Bayar=@Bayar, Lunas=@Lunas WHERE Tahun=@Tahun AND NoCustomer=@NoCustomer"
            cmd = New OleDbCommand(qry, con)
            cmd.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            cmd.Parameters.AddWithValue("@Tahun", tahun.Text)
            cmd.Parameters.Add(New OleDbParameter("@TanggalKwitansi", OleDbType.DBDate))
            cmd.Parameters("@TanggalKwitansi").Value = tanggal.Value
            cmd.Parameters.AddWithValue("@NoKwitansi", noKwitansi.Text)
            cmd.Parameters.AddWithValue("@SubTotal", subtotal.Value)
            cmd.Parameters.AddWithValue("@Denda", denda.Value)
            cmd.Parameters.AddWithValue("@SIST", sist.Value)
            cmd.Parameters.AddWithValue("@Saldo", saldo.Value)
            cmd.Parameters.AddWithValue("@Total", total.Value)
            cmd.Parameters.AddWithValue("@Bayar", bayar.Value)
            cmd.Parameters.AddWithValue("@Lunas", lunas.Checked)

        Else
            qry = "INSERT INTO PBB(NoCustomer, Tahun, TanggalKwitansi, NoKwitansi, SubTotal, Denda, SIST, Saldo, Total, Bayar, Lunas) VALUES (@NoCustomer, @Tahun, @TanggalKwitansi, @NoKwitansi, @SubTotal, @Denda, @SIST, @Saldo, @Total, @Bayar, @Lunas)"
            cmd = New OleDbCommand(qry, con)

            cmd.Parameters.AddWithValue("@NoCustomer", noCustomer.Text)
            cmd.Parameters.AddWithValue("@Tahun", tahun.Text)
            cmd.Parameters.Add(New OleDbParameter("@TanggalKwitansi", OleDbType.DBDate))
            cmd.Parameters("@TanggalKwitansi").Value = tanggal.Value
            cmd.Parameters.AddWithValue("@NoKwitansi", noKwitansi.Text)
            cmd.Parameters.AddWithValue("@SubTotal", subtotal.Value)
            cmd.Parameters.AddWithValue("@Denda", denda.Value)
            cmd.Parameters.AddWithValue("@SIST", sist.Value)
            cmd.Parameters.AddWithValue("@Saldo", saldo.Value)
            cmd.Parameters.AddWithValue("@Total", total.Value)
            cmd.Parameters.AddWithValue("@Bayar", bayar.Value)
            cmd.Parameters.AddWithValue("@Lunas", lunas.Checked)

        End If

        'Dim debugSQL As String = cmd.CommandText
        'For Each param As OleDbParameter In cmd.Parameters
        '    debugSQL = debugSQL.Replace(param.ParameterName, param.Value.ToString())
        'Next
        'MsgBox(debugSQL)


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
    End Sub

    Public report As New CrystalReport8

    Private Sub printPBB_Click(sender As Object, e As EventArgs) Handles printPBB.Click
        If Application.OpenForms().OfType(Of cetakPBB).Any Then
            cetakPBB.Close()
        End If
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then

        Else

            Simpan()
            List_PBB.button.PerformClick()
            report.SetParameterValue("Nama", nama.Text)
            report.SetParameterValue("NoKwitansi", noKwitansi.Text)
            report.SetParameterValue("TanggalKwitansi", tanggal.Value)
            report.SetParameterValue("Lantai", lantai.Text)
            report.SetParameterValue("NomorKios", noKios.Text)
            report.SetParameterValue("Luas", luas.Value)
            report.SetParameterValue("SubTotal", subtotal.Value + denda.Value)
            report.SetParameterValue("SIST", sist.Value)
            report.SetParameterValue("Total", total.Value)
            report.SetParameterValue("Tahun", tahun.Text)
            report.SetParameterValue("TanggalAkhir", Now.Year)

            Pengumuman.CrystalReportViewer1.ReportSource = report
            Pengumuman.WindowState = FormWindowState.Maximized
            Pengumuman.Show()
            Pengumuman.Activate()
        End If

    End Sub

    Public Sub ubah()
        subtotal.Value = Convert.ToInt64(biayaPBB.Value * luas.Value)
        total.Value = subtotal.Value + denda.Value + sist.Value
    End Sub

    Private Sub biayaPBB_ValueChanged(sender As Object, e As EventArgs) Handles biayaPBB.ValueChanged
        ubah()
    End Sub

    Private Sub denda_ValueChanged(sender As Object, e As EventArgs) Handles denda.ValueChanged
        ubah()
    End Sub

    Private Sub SIST_ValueChanged(sender As Object, e As EventArgs) Handles sist.ValueChanged
        ubah()
    End Sub

    Private Sub tahun_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tahun.SelectedIndexChanged
        GetDataBukti()
    End Sub

    Private Sub simpanTambah_Click(sender As Object, e As EventArgs) Handles simpanTambah.Click
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then

        Else
            Simpan()
            List_PBB.button.PerformClick()
            clearTxt()
            noCustomer.SelectedIndex = -1
            nama.SelectedIndex = -1
        End If
    End Sub

    Public report1 As New ReportDocument

    Private Sub cetakSemua_Click(sender As Object, e As EventArgs) Handles cetakSemua.Click
        If Application.OpenForms().OfType(Of cetakPBB).Any Then
            cetakPBB.Close()
        End If
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then

        Else

            Simpan()
            List_PBB.button.PerformClick()

            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report1.Load(appPath & "\CrystalReport11.rpt")

            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report1.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report1.VerifyDatabase()

            report1.SetParameterValue("Nama", nama.Text)
            report1.SetParameterValue("NoCustomer", noCustomer.Text)
            report1.SetParameterValue("NoCustomer", noCustomer.Text, "CrystalReport12.rpt")
            report1.SetParameterValue("NoCustomer", noCustomer.Text, "CrystalReport13.rpt")
            report1.SetParameterValue("NoCustomer", noCustomer.Text, "CrystalReport14.rpt")

            Pengumuman.CrystalReportViewer1.ReportSource = report1
            Pengumuman.WindowState = FormWindowState.Maximized
            Pengumuman.Show()
            Pengumuman.Activate()
        End If
    End Sub

    Private Sub PBBbayar_CheckedChanged(sender As Object, e As EventArgs) Handles PBBbayar.CheckedChanged
        If PBBbayar.Checked = False Then
            biayaPBB.Value = 0
        Else
            If noKios.Text = "1" Then
                biayaPBB.Value = PBB1
            Else
                biayaPBB.Value = PBB2
            End If
        End If
    End Sub

    Private Sub SISTbayar_CheckedChanged(sender As Object, e As EventArgs) Handles SISTbayar.CheckedChanged
        If SISTbayar.Checked = False Then
            sist.Value = 0
            sist.Enabled = False
        Else
            sist.Enabled = True
        End If
    End Sub

    Private Sub simpanTutup_Click(sender As Object, e As EventArgs) Handles simpanTutup.Click
        If CheckNama() Then
            MsgBox("Tidak ada customer dengan nama " & nama.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckCustomer() Then
            MsgBox("Tidak ada customer dengan nomor " & noCustomer.Text & " di database!", MsgBoxStyle.Information)
        ElseIf CheckData() Then

        Else
            Simpan()
            List_PBB.button.PerformClick()
            Me.Close()
        End If
    End Sub

    Private Sub nama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nama.SelectedIndexChanged
        If nama.SelectedIndex <> -1 Then
            noCustomer.SelectedIndex = nama.SelectedIndex
            clearTxt()
        End If
        noCustomer.Refresh()
        GetData()
    End Sub
End Class