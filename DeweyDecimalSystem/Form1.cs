using System.Runtime.InteropServices;

namespace DeweyDecimalSystem
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            OpenCHild(new Forms.LandingPage());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public void OpenCHild(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "HOME";
            OpenCHild(new Forms.LandingPage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "REPLACE BOOKS";
            OpenCHild(new Forms.ReplaceBooks());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "IDENTIFY AREAS";
            OpenCHild(new Forms.IdentifyAreas());

        }

        private void btnFindCall_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "FIND CALL NUMBERS";
            OpenCHild(new Forms.FindingCallNumbers());

        }

        private void paneltitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}