Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Public Class FormLaporan

    Dim appPath As String = Application.StartupPath
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source" + "=" & appDataPath & "\Indosoft\Billing\Customer.mdb;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand

    Public report As New ReportDocument
    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        If Application.OpenForms().OfType(Of Laporan).Any Then
            Laporan.Close()
        End If
        Dim CrConnectionInfo As New ConnectionInfo()
        If tipeLaporan.Text = "Rekap" And tipeLaporan.SelectedIndex = 0 Then
            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport3.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.VerifyDatabase()
            report.SetParameterValue("Tanggal1", tanggalAwal.Value)
            report.SetParameterValue("Tanggal2", tanggalAkhir.Value)
            report.SetParameterValue("lantai1", lantai1.Checked)
            report.SetParameterValue("lantai2", lantai2.Checked)
            Laporan.CrystalReportViewer1.ReportSource = report

            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()

            Me.Close()
        ElseIf tipeLaporan.Text = "Pelanggan belum lunas" And tipeLaporan.SelectedIndex = 1 Then
            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport5.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.VerifyDatabase()
            report.SetParameterValue("Tanggal1", tanggalAwal.Value)
            report.SetParameterValue("Tanggal2", tanggalAkhir.Value)
            Laporan.CrystalReportViewer1.ReportSource = report
            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()
            Me.Close()
        ElseIf tipeLaporan.Text = "Pelanggan sudah lunas" And tipeLaporan.SelectedIndex = 2 Then
            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport4.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.VerifyDatabase()
            report.SetParameterValue("Tanggal1", tanggalAwal.Value)
            report.SetParameterValue("Tanggal2", tanggalAkhir.Value)
            Laporan.CrystalReportViewer1.ReportSource = report
            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()
            Me.Close()
        ElseIf tipeLaporan.Text = "Pelanggan aktif & non aktif" And tipeLaporan.SelectedIndex = 3 Then

            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport6.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.SetParameterValue("Tanggal1", tanggalAwal.Value)
            report.SetParameterValue("Tanggal2", tanggalAkhir.Value)
            report.VerifyDatabase()
            Laporan.CrystalReportViewer1.ReportSource = report
            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()
            Me.Close()
        ElseIf tipeLaporan.Text = "Total pembayaran dalam periode" And tipeLaporan.SelectedIndex = 4 Then
            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport7.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.VerifyDatabase()
            report.SetParameterValue("Tanggal1", tanggalAwal.Value)
            report.SetParameterValue("Tanggal2", tanggalAkhir.Value)
            Laporan.CrystalReportViewer1.ReportSource = report
            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()
            Me.Close()
        ElseIf tipeLaporan.Text = "Rekap PBB" And tipeLaporan.SelectedIndex = 5 Then
            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport16.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.VerifyDatabase()
            report.SetParameterValue("Tahun1", tanggalAwal.Value.Year)
            report.SetParameterValue("Tahun2", tanggalAkhir.Value.Year)
            Laporan.CrystalReportViewer1.ReportSource = report
            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()
            Me.Close()
        ElseIf tipeLaporan.Text = "Pelanggan sudah bayar PBB" And tipeLaporan.SelectedIndex = 6 Then
            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport9.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.VerifyDatabase()
            Laporan.CrystalReportViewer1.ReportSource = report
            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()
            Me.Close()
        ElseIf tipeLaporan.Text = "Pelanggan belum bayar PBB" And tipeLaporan.SelectedIndex = 7 Then
            Dim CrTables As Tables
            Dim CrTableLogonInfo As New TableLogOnInfo()
            Dim CrConnectionInfo1 As New ConnectionInfo()


            report.Load(appPath & "\CrystalReport10.rpt")
            With CrConnectionInfo1
                .ServerName = appDataPath & "\Indosoft\Billing\Customer.mdb"
            End With

            CrTables = report.Database.Tables

            For Each CrTable In CrTables
                CrTableLogonInfo = CrTable.LogOnInfo
                CrTableLogonInfo.ConnectionInfo = CrConnectionInfo1
                CrTable.ApplyLogOnInfo(CrTableLogonInfo)
            Next
            report.VerifyDatabase()
            Laporan.CrystalReportViewer1.ReportSource = report
            Laporan.WindowState = FormWindowState.Maximized
            Laporan.Show()
            Laporan.Activate()
            Me.Close()
        Else
            MsgBox("Tipe Laporan tidak boleh kosong", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub tipeLaporan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipeLaporan.SelectedIndexChanged
        If tipeLaporan.Text = "Pelanggan aktif & non aktif" And tipeLaporan.SelectedIndex = 3 Then
            tanggalAwal.Enabled = False
            tanggalAkhir.Enabled = False
            lantai1.Enabled = False
            lantai2.Enabled = False
        ElseIf tipeLaporan.Text = "Rekap" And tipeLaporan.SelectedIndex = 0 Then
            lantai1.Enabled = True
            lantai2.Enabled = True
            tanggalAkhir.Enabled = True
            tanggalAwal.Enabled = True
        ElseIf tipeLaporan.Text = "Pelanggan belum bayar PBB" Or tipeLaporan.Text = "Pelanggan sudah bayar PBB" Then
            tanggalAwal.Enabled = False
            tanggalAkhir.Enabled = False
            lantai1.Enabled = False
            lantai2.Enabled = False
        Else
            tanggalAwal.Enabled = True
            tanggalAkhir.Enabled = True
            lantai1.Enabled = False
            lantai2.Enabled = False
        End If
    End Sub

End Class