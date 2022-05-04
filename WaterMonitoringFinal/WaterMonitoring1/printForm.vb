Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class printForm

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim CrReports As New ReportDocument
        CrReports.Load(Application.StartupPath & "\water_monitoring_report.rpt")
        CrReports.SetDatabaseLogon("sa", "Nydyy14324")
        '  CrReports.RecordSelectionFormula = "{TB_salesCount.purchaseDate} like '" & viewSales & "' OR {TB_salesCount.purchaseProd} like'" & viewSales & "'"
        CrReports.Refresh()
        CrystalReportViewer1.ReportSource = CrReports
    End Sub
End Class