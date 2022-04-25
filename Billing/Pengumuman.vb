Public Class Pengumuman
    Private Sub Pengumuman_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CrystalReportViewer1.ReportSource.Close()
        CrystalReportViewer1.Dispose()

        DataTagihan.report.Close()
        DataTagihan.report1.Close()
    End Sub
End Class