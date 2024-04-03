using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOnetApp
{
    public partial class FormLoading : Form
    {
        System.Windows.Forms.Timer timer;
        int count = 0;
        Task taskShowLoading;
        CancellationTokenSource token;
        private static FormLoading _instance;
        public static FormLoading GetInstance()
        {
            if(_instance == null)
            {
                _instance = new FormLoading();
            }

            return _instance;
        }
        private FormLoading()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 200; // Update every 50 milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 3) count = 1;
            string countDot = string.Empty;
            for(int i = 1; i <= count; i++)
            {
                countDot += ". ";
            }

            Invoke(new Action(() =>
            {
                lbDot.Text = countDot;
            }));
        }

        public void ShowLoading()
        {
            token = new CancellationTokenSource();
            taskShowLoading = Task.Factory.StartNew(new Action(()=> 
            {
                while (!token.IsCancellationRequested)
                {
                    this.ShowDialog();
                }

            }
            ), token.Token);
        }

        public void HideLoading()
        {
            token.Cancel();
        }
    }
}
