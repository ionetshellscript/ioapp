using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOnetApp.Docker;
using IOnetApp.IONET;
using Timer = System.Threading.Timer;
namespace IOnetApp
{
    public partial class formMain : Form, INotifyPropertyChanged
    {
        public IoNetWorker Worker;
        public DataTable Table;
        public Timer TimerGetStatusContainer, TimerCheckStatusContainer;
        public formMain()
        {
            InitializeComponent();
            Table = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                // You might want to check if the column is visible or not if you intend to exclude certain columns
                if (column.Visible)
                {
                    Table.Columns.Add(column.DataPropertyName, column.ValueType ?? typeof(string));
                }
            }
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Table;
            Load += (sender, args) =>
            {
                SetupTimer();
                LoadDataWorker();
            };
        }

        public void LoadDataWorker()
        {
            var worker = IoNetWorker.LoadDataObject();
            if (worker != null)
            {
                Worker = worker;
                DeviceName.Text = $"Device name:{worker.DeviceName}";
                DeviceId.Text = $"Device ID:{worker.DeviceId}";
                UserID.Text = $"User ID:{worker.UserId}";
            }
        }
        private void GenerateNewDataValue(DockerContainer container)
        {
            Table.Rows.Add(container.ID, container.Image, container.Name, container.CPU);
            UpdateGridView();
        }


        private void UpdateGridView()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(UpdateGridView));
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Table;
            }
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.ShowDialog();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerGetStatusContainer?.Dispose();
            TimerCheckStatusContainer?.Dispose();
            if(FormLoading.GetInstance() != null)
            {
                FormLoading.GetInstance().Close();
            }
        }

        private bool isChecking = true;
        private void CreateCheckingStateTask()
        {
        }
        // This is the method to be called by the timer every 10 seconds
        private void TimerCallback(object state)
        {
            // Call your function here
            GetContainerData();
        }

// Method that setups the timer
        private void SetupTimer()
        {
            TimerGetStatusContainer = new Timer(TimerCallback, null, 0, 5000);
            TimerCheckStatusContainer = new Timer(CheckStatusWorker, null, 0, 5000);
        }

// Example of a function to be called
        private void GetContainerData()
        {
            var containers = DockerCommand.CheckContainerStatus();
            Table.Rows.Clear();
            foreach (var container in containers)
            {
                GenerateNewDataValue(container);
            }
        }
        private void CheckStatusWorker(object state)
        {
            var containers = DockerCommand.CheckContainerStatus();
            // Require number running container >= 2
            // Require at least 1 container has CPU usage >0
            bool isContainerOk = false;
            foreach (var container in containers)
            {
                var cpuUsage = float.Parse(container.CPU.Replace("%", ""));
                isContainerOk = isContainerOk || cpuUsage > 0f;
            }
            
            if (containers.Count <2  || !isContainerOk)
            {
                if (Worker != null)
                {
                    DockerCommand.RunNewWorker(Worker.DeviceName, Worker.DeviceId, Worker.UserId);
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        
    }
}