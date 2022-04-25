Public Class Laporan
    Private Sub Laporan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CrystalReportViewer1.ReportSource.Close()
        CrystalReportViewer1.Dispose()

        FormLaporan.report.Close()

    End Sub
End Class