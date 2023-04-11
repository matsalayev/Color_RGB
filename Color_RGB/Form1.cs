using System.Runtime.InteropServices;

namespace Color_RGB
{
    public partial class ColorRGB : Form
    {
        public ColorRGB()
        {
            InitializeComponent();

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void ColorRGB_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        bool fR = false;
        private void pnlR_MouseMove(object sender, MouseEventArgs e)
        {
            if ((int)(MousePosition.X - this.Location.X - pnlR.Location.X) <= 255 && fR)
            {
                R.Width = (int)(MousePosition.X - this.Location.X - pnlR.Location.X);
                txtR.Text = R.Width.ToString();
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void pnlR_MouseDown(object sender, MouseEventArgs e)
        {
            fR = true;
        }

        private void pnlR_MouseUp(object sender, MouseEventArgs e)
        {
            fR = false;
        }

        private void pnlR_Click(object sender, EventArgs e)
        {
            R.Width = (int)(MousePosition.X - this.Location.X - pnlR.Location.X);
            txtR.Text = R.Width.ToString();
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        bool fG = false;
        private void pnlG_MouseDown(object sender, MouseEventArgs e)
        {
            fG = true;
        }
        private void pnlG_MouseMove(object sender, MouseEventArgs e)
        {
            if ((int)(MousePosition.X - this.Location.X - pnlG.Location.X) <= 255 && fG)
            {
                G.Width = (int)(MousePosition.X - this.Location.X - pnlG.Location.X);
                txtG.Text = G.Width.ToString();
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void pnlG_MouseUp(object sender, MouseEventArgs e)
        {
            fG = false;
        }

        private void pnlG_Click(object sender, EventArgs e)
        {
            G.Width = (int)(MousePosition.X - this.Location.X - pnlG.Location.X);
            txtG.Text = G.Width.ToString();
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        bool fB = false;
        private void pnlB_MouseDown(object sender, MouseEventArgs e)
        {
            fB = true;
        }

        private void pnlB_MouseMove(object sender, MouseEventArgs e)
        {
            if ((int)(MousePosition.X - this.Location.X - pnlB.Location.X) <= 255 && fB)
            {
                B.Width = (int)(MousePosition.X - this.Location.X - pnlB.Location.X);
                txtB.Text = B.Width.ToString();
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void pnlB_MouseUp(object sender, MouseEventArgs e)
        {
            fB = false;
        }

        private void pnlB_Click(object sender, EventArgs e)
        {
            B.Width = (int)(MousePosition.X - this.Location.X - pnlB.Location.X);
            txtB.Text = B.Width.ToString();
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        bool fW = false;
        private void pnlW_MouseDown(object sender, MouseEventArgs e)
        {
            fW = true;
        }

        private void pnlW_MouseMove(object sender, MouseEventArgs e)
        {
            if ((int)(MousePosition.X - this.Location.X - pnlW.Location.X) <= 255 && fW)
            {
                W.Width = (int)(MousePosition.X - this.Location.X - pnlB.Location.X);
                txtW.Text = W.Width.ToString();
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void pnlW_MouseUp(object sender, MouseEventArgs e)
        {
            fW = false;
        }

        private void pnlW_Click(object sender, EventArgs e)
        {
            W.Width = (int)(MousePosition.X - this.Location.X - pnlB.Location.X);
            txtW.Text = W.Width.ToString();
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            if (txtR.Text != "")
            {
                if (int.Parse(txtR.Text) <= 255 && int.Parse(txtR.Text) >= 0)
                    R.Width = int.Parse(txtR.Text);
                else if (int.Parse(txtR.Text) < 0) txtR.Text = "0";
                else txtR.Text = "255";
            }
            else
            {
                txtR.Text = "0";
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            if (txtG.Text != "")
            {
                if (int.Parse(txtG.Text) <= 255 && int.Parse(txtG.Text) >= 0)
                    G.Width = int.Parse(txtG.Text);
                else if (int.Parse(txtG.Text) < 0) txtG.Text = "0";
                else txtG.Text = "255";
            }
            else
            {
                txtG.Text = "0";
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            if (txtB.Text != "")
            {
                if (int.Parse(txtB.Text) <= 255 && int.Parse(txtB.Text) >= 0)
                    B.Width = int.Parse(txtB.Text);
                else if (int.Parse(txtB.Text) < 0) txtB.Text = "0";
                else txtB.Text = "255";
            }
            else
            {
                txtB.Text = "0";
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {
            if (txtW.Text != "")
            {
                if (int.Parse(txtW.Text) <= 255 && int.Parse(txtW.Text) >= 0)
                    W.Width = int.Parse(txtW.Text);
                else if (int.Parse(txtW.Text) < 0) txtW.Text = "0";
                else txtW.Text = "255";
            }
            else
            {
                txtW.Text = "0";
            }
            pnlColor.BackColor = Color.FromArgb(int.Parse(txtW.Text), int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }
        TextBox rang = new TextBox();
        private void pnlColor_Click(object sender, EventArgs e)
        {
            rang.Text = int.Parse(txtW.Text) + "," + int.Parse(txtR.Text) + "," + int.Parse(txtG.Text) + "," + int.Parse(txtB.Text);
            rang.SelectAll();
            rang.Cut();
            timer1.Start();

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {


        }

        private void pnlColor_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "Rangni nusxalash uchun bosing!";
        }

        private void pnlColor_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "Ranglar Aralashmasi (RGB)";
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "Nusxalandi!";
            a += 1;
            if (a == 10)
            {
                lblInfo.Text = "Ranglar Aralashmasi (RGB)";
                timer1.Stop();
                a = 0;
            }
        }
    }
}