namespace Color_RGB
{
    partial class ColorRGB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorRGB));
            btnExit = new Button();
            btnMin = new Button();
            pnlColor = new Panel();
            lblInfo = new Label();
            pnlG = new Panel();
            G = new Panel();
            pnlR = new Panel();
            R = new Panel();
            pnlB = new Panel();
            B = new Panel();
            txtR = new TextBox();
            txtG = new TextBox();
            txtB = new TextBox();
            pnlW = new Panel();
            W = new Panel();
            txtW = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlG.SuspendLayout();
            pnlR.SuspendLayout();
            pnlB.SuspendLayout();
            pnlW.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(347, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 0;
            btnExit.Text = "⚫";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnMin
            // 
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Font = new Font("Segoe UI", 7.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnMin.ForeColor = Color.Green;
            btnMin.Location = new Point(317, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 1;
            btnMin.Text = "⚫";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // pnlColor
            // 
            pnlColor.BackColor = Color.FromArgb(50, 50, 50);
            pnlColor.BorderStyle = BorderStyle.FixedSingle;
            pnlColor.Location = new Point(12, 36);
            pnlColor.Name = "pnlColor";
            pnlColor.Size = new Size(354, 172);
            pnlColor.TabIndex = 2;
            pnlColor.Click += pnlColor_Click;
            pnlColor.MouseLeave += pnlColor_MouseLeave;
            pnlColor.MouseHover += pnlColor_MouseHover;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(9, 6);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(211, 23);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Ranglar Aralashmasi (RGB)";
            lblInfo.Click += lblInfo_Click;
            // 
            // pnlG
            // 
            pnlG.BackColor = Color.Gray;
            pnlG.Controls.Add(G);
            pnlG.Cursor = Cursors.Hand;
            pnlG.Location = new Point(12, 271);
            pnlG.Name = "pnlG";
            pnlG.Size = new Size(255, 8);
            pnlG.TabIndex = 4;
            pnlG.Click += pnlG_Click;
            pnlG.MouseDown += pnlG_MouseDown;
            pnlG.MouseMove += pnlG_MouseMove;
            pnlG.MouseUp += pnlG_MouseUp;
            // 
            // G
            // 
            G.BackColor = Color.Green;
            G.Dock = DockStyle.Left;
            G.Location = new Point(0, 0);
            G.Name = "G";
            G.Size = new Size(50, 8);
            G.TabIndex = 0;
            G.Click += pnlG_Click;
            G.MouseDown += pnlG_MouseDown;
            G.MouseMove += pnlG_MouseMove;
            G.MouseUp += pnlG_MouseUp;
            // 
            // pnlR
            // 
            pnlR.BackColor = Color.Gray;
            pnlR.Controls.Add(R);
            pnlR.Cursor = Cursors.Hand;
            pnlR.Location = new Point(12, 234);
            pnlR.Name = "pnlR";
            pnlR.Size = new Size(255, 8);
            pnlR.TabIndex = 5;
            pnlR.Click += pnlR_Click;
            pnlR.MouseDown += pnlR_MouseDown;
            pnlR.MouseMove += pnlR_MouseMove;
            pnlR.MouseUp += pnlR_MouseUp;
            // 
            // R
            // 
            R.BackColor = Color.Red;
            R.Dock = DockStyle.Left;
            R.Location = new Point(0, 0);
            R.Name = "R";
            R.Size = new Size(50, 8);
            R.TabIndex = 0;
            R.Click += pnlR_Click;
            R.MouseDown += pnlR_MouseDown;
            R.MouseMove += pnlR_MouseMove;
            R.MouseUp += pnlR_MouseUp;
            // 
            // pnlB
            // 
            pnlB.BackColor = Color.Gray;
            pnlB.Controls.Add(B);
            pnlB.Cursor = Cursors.Hand;
            pnlB.Location = new Point(12, 308);
            pnlB.Name = "pnlB";
            pnlB.Size = new Size(255, 8);
            pnlB.TabIndex = 6;
            pnlB.Click += pnlB_Click;
            pnlB.MouseDown += pnlB_MouseDown;
            pnlB.MouseMove += pnlB_MouseMove;
            pnlB.MouseUp += pnlB_MouseUp;
            // 
            // B
            // 
            B.BackColor = Color.Blue;
            B.Dock = DockStyle.Left;
            B.Location = new Point(0, 0);
            B.Name = "B";
            B.Size = new Size(50, 8);
            B.TabIndex = 0;
            B.Click += pnlB_Click;
            B.MouseDown += pnlB_MouseDown;
            B.MouseMove += pnlB_MouseMove;
            B.MouseUp += pnlB_MouseUp;
            // 
            // txtR
            // 
            txtR.BackColor = Color.FromArgb(40, 40, 40);
            txtR.BorderStyle = BorderStyle.FixedSingle;
            txtR.ForeColor = Color.White;
            txtR.Location = new Point(289, 222);
            txtR.Name = "txtR";
            txtR.Size = new Size(77, 30);
            txtR.TabIndex = 7;
            txtR.Text = "50";
            txtR.TextChanged += txtR_TextChanged;
            // 
            // txtG
            // 
            txtG.BackColor = Color.FromArgb(40, 40, 40);
            txtG.BorderStyle = BorderStyle.FixedSingle;
            txtG.ForeColor = Color.White;
            txtG.Location = new Point(289, 258);
            txtG.Name = "txtG";
            txtG.Size = new Size(77, 30);
            txtG.TabIndex = 8;
            txtG.Text = "50";
            txtG.TextChanged += txtG_TextChanged;
            // 
            // txtB
            // 
            txtB.BackColor = Color.FromArgb(40, 40, 40);
            txtB.BorderStyle = BorderStyle.FixedSingle;
            txtB.ForeColor = Color.White;
            txtB.Location = new Point(289, 295);
            txtB.Name = "txtB";
            txtB.Size = new Size(77, 30);
            txtB.TabIndex = 9;
            txtB.Text = "50";
            txtB.TextChanged += txtB_TextChanged;
            // 
            // pnlW
            // 
            pnlW.BackColor = Color.Gray;
            pnlW.Controls.Add(W);
            pnlW.Location = new Point(12, 346);
            pnlW.Name = "pnlW";
            pnlW.Size = new Size(255, 8);
            pnlW.TabIndex = 10;
            pnlW.Click += pnlW_Click;
            pnlW.MouseDown += pnlW_MouseDown;
            pnlW.MouseMove += pnlW_MouseMove;
            pnlW.MouseUp += pnlW_MouseUp;
            // 
            // W
            // 
            W.BackColor = Color.White;
            W.Cursor = Cursors.Hand;
            W.Dock = DockStyle.Left;
            W.Location = new Point(0, 0);
            W.Name = "W";
            W.Size = new Size(255, 8);
            W.TabIndex = 0;
            W.Click += pnlW_Click;
            W.MouseDown += pnlW_MouseDown;
            W.MouseMove += pnlW_MouseMove;
            W.MouseUp += pnlW_MouseUp;
            // 
            // txtW
            // 
            txtW.BackColor = Color.FromArgb(40, 40, 40);
            txtW.BorderStyle = BorderStyle.FixedSingle;
            txtW.ForeColor = Color.White;
            txtW.Location = new Point(289, 331);
            txtW.Name = "txtW";
            txtW.Size = new Size(77, 30);
            txtW.TabIndex = 11;
            txtW.Text = "255";
            txtW.TextChanged += txtW_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 80;
            timer1.Tick += timer1_Tick;
            // 
            // ColorRGB
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(377, 373);
            Controls.Add(txtW);
            Controls.Add(pnlW);
            Controls.Add(txtB);
            Controls.Add(txtG);
            Controls.Add(txtR);
            Controls.Add(pnlB);
            Controls.Add(pnlR);
            Controls.Add(pnlG);
            Controls.Add(lblInfo);
            Controls.Add(pnlColor);
            Controls.Add(btnMin);
            Controls.Add(btnExit);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ColorRGB";
            Text = "Form1";
            MouseDown += ColorRGB_MouseDown;
            pnlG.ResumeLayout(false);
            pnlR.ResumeLayout(false);
            pnlB.ResumeLayout(false);
            pnlW.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnMin;
        private Panel pnlColor;
        private Label lblInfo;
        private Panel pnlG;
        private Panel G;
        private Panel pnlR;
        private Panel R;
        private Panel pnlB;
        private Panel B;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private Panel pnlW;
        private Panel W;
        private TextBox txtW;
        private System.Windows.Forms.Timer timer1;
    }
}