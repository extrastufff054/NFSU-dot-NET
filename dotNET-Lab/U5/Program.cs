// Design an application which will demonstrate the user control and crystal report

using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace UserControlsAndCrystalReports
{
    public partial class MainForm : Form
    {
        private MyUserControl myUserControl;
        
        public MainForm()
        {
            InitializeComponent();
            
            // Create an instance of the user control
            myUserControl = new MyUserControl();
            myUserControl.Dock = DockStyle.Fill;
            
            // Add the user control to the main form
            Controls.Add(myUserControl);
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            // Create an instance of the Crystal Report document
            ReportDocument reportDocument = new ReportDocument();

            // Set the path to your Crystal Report file (*.rpt)
            reportDocument.Load("path_to_your_report.rpt");

            // Set the database login credentials if required
            // reportDocument.SetDatabaseLogon("username", "password");

            // Set any required parameters
            // ParameterField parameter = new ParameterField();
            // parameter.Name = "paramName";
            // parameter.CurrentValues.Add(new ParameterDiscreteValue { Value = "paramValue" });
            // reportDocument.DataDefinition.ParameterFields["paramName"].ApplyCurrentValues(parameter.CurrentValues);

            // Create a CrystalReportViewer control
            CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            crystalReportViewer.ReportSource = reportDocument;
            
            // Create a form to display the Crystal Report
            Form reportForm = new Form();
            reportForm.Text = "Crystal Report";
            reportForm.Controls.Add(crystalReportViewer);
            reportForm.WindowState = FormWindowState.Maximized;

            // Show the Crystal Report form
            reportForm.ShowDialog();
        }
    }
}


/*In this example, you need to replace "path_to_your_report.rpt" with the actual path to your Crystal Report file. 
Additionally, you can uncomment and modify the code sections to set database login credentials and report parameters as per your specific requirements.*/