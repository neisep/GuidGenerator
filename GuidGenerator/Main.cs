namespace GuidGenerator
{
    public partial class Main : Form
    {
        private System.Windows.Forms.Timer _timer;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guidTextBox.Text = Guid.NewGuid().ToString();

            Clipboard.SetText(guidTextBox.Text);

            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += timer_Tick;
            _timer.Interval = (int)TimeSpan.FromSeconds(5).TotalMilliseconds;

            _timer.Start();
        }

        private void timer_Tick(object? sender, EventArgs e)
        {
            _timer.Stop();
            labelStatus.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            string value = Guid.NewGuid().ToString();

            if (!checkBoxHyphens.Checked)
                value = Guid.NewGuid().ToString("N");

            if (checkBoxBraces.Checked)
                value = Guid.NewGuid().ToString("B");

            if (checkboxUpperCase.Checked)
                value = value.ToUpper();

            guidTextBox.Text = value;

            Clipboard.SetText(guidTextBox.Text);

            labelStatus.Visible = true;
            _timer.Start();
        }

        private void checkBoxBraces_CheckStateChanged(object sender, EventArgs e)
        {
            var checkboxBraces = (CheckBox)sender;

            if (checkboxBraces.CheckState == CheckState.Checked)
            {
                checkBoxHyphens.Checked = true;
                checkBoxHyphens.Enabled = false;

                return;
            }
            checkBoxHyphens.Enabled = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
            _timer.Tick -= timer_Tick;
        }
    }
}
