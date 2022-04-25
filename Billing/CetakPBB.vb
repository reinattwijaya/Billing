Public Class cetakPBB
    Private Sub cetakPBB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CrystalReportViewer1.ReportSource.Close()
        CrystalReportViewer1.Dispose()

        PBB.report.Close()
    End Sub
End Class