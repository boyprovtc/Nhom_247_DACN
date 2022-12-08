using System;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace Nhom_247.Report
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomPercent = 140;
            reportViewer1.ZoomMode = ZoomMode.Percent;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BillDetail", mysql.DataSet($"select * from bill","billdetail").Tables[0]));
            reportViewer1.LocalReport.ReportPath = $"{Application.StartupPath}/Report1.rdlc";
            reportViewer1.RefreshReport();
        }

        
    }
}
