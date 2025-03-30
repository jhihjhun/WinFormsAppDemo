namespace WinFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrDatetime.Start();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World!";
        }

        private async void btnCounter_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                lblCounter.Text = i.ToString();
                await Task.Delay(500);
            }
        }

        private void tmrDatetime_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
