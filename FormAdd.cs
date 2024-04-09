using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOnetApp.Docker;
using IOnetApp.IONET;

namespace IOnetApp
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var DeviceId = DeviceIDText.Text.Trim();
            var DeviceName = DeviceNameText.Text.Trim();
            var UserID = UserIdText.Text.Trim();
            IoNetWorker.SaveDataToLocal(new IoNetWorker()
            {
                DeviceId = DeviceId,
                DeviceName = DeviceName,
                UserId = UserID
            });
        }
        private void RunCommand_Click(object sender, EventArgs e)
        {
            var worketIO = IoNetWorker.ParseWorkerFromCommand(commandText.Text);
            if (worketIO != null)
            {
                IoNetWorker.SaveDataToLocal(worketIO);
                MessageBox.Show("Run success, wait 2 mins to sync data");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("command is wrong");
            }
        }
    }
}
