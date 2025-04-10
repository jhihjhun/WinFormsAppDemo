namespace WinFormsAppDemo
{
    public partial class Form1 : Form
    {
        private readonly CancellationTokenSource _cts = new();
        private bool _isCounting = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartClock(_cts.Token);
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World!";
        }

        private async void btnCounter_Click(object sender, EventArgs e)
        {
            if (_isCounting)
            {
                return;
            }

            _isCounting = true;

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    lblCounter.Text = i.ToString();
                    await Task.Delay(500);
                }
            }
            finally
            {
                _isCounting = false;
            }
        }

        private async void StartClock(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    UpdateUI(UpdateDatetime);
                    token.ThrowIfCancellationRequested();
                    await Task.Delay(1000, token);
                }
                catch (TaskCanceledException)
                {
                    break;
                }
            }
        }

        private void UpdateUI(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
                return;
            }

            action();
        }

        private void UpdateDatetime()
        {
            lblDatetime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _cts.Cancel();
        }
    }
}
