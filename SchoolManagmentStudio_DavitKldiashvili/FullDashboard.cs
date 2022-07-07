using SchoolManagmentStudio_DavitKldiashvili;
using SchoolManagmentSystem_DavitKldiashvili.Controllers;
using System;
using System.Windows.Forms;
namespace SchoolManagmentSystem_DavitKldiashvili
{
    public partial class FullDashboard : Dashboard
    {
        public FullDashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdmissionControl dc = new AdmissionControl();
            showControl(dc);
        }

        public void showControl(Control control)
        {
            Content.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }
    }
}
