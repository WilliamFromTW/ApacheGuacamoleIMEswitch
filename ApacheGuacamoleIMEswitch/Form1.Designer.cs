using System.ComponentModel;

namespace ApacheGuacamoleIMEswitch
{
    partial class Form1
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
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            label1 = new Label();
            URL = new TextBox();
            save = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            PORT = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            PWD = new TextBox();
            RDP = new TextBox();
            UID = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(577, 568);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(569, 540);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(URL);
            groupBox3.Controls.Add(save);
            groupBox3.Location = new Point(11, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(541, 81);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "「網頁」遠端連線";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(5, 37);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 5;
            label1.Text = "連線網址";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // URL
            // 
            URL.BorderStyle = BorderStyle.FixedSingle;
            URL.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            URL.ImeMode = ImeMode.Disable;
            URL.Location = new Point(89, 31);
            URL.Name = "URL";
            URL.Size = new Size(346, 27);
            URL.TabIndex = 2;
            URL.TextChanged += URL_TextChanged;
            URL.KeyPress += URL_KeyPress;
            // 
            // save
            // 
            save.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            save.Location = new Point(454, 31);
            save.Name = "save";
            save.Size = new Size(61, 31);
            save.TabIndex = 4;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(PORT);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(PWD);
            groupBox2.Controls.Add(RDP);
            groupBox2.Controls.Add(UID);
            groupBox2.Location = new Point(11, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(541, 154);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "遠端桌面連線設定";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Green;
            label8.Location = new Point(290, 77);
            label8.Name = "label8";
            label8.Size = new Size(180, 15);
            label8.TabIndex = 18;
            label8.Text = "若有網域，請輸入「網域\\帳號」";
            label8.Click += label8_Click;
            // 
            // PORT
            // 
            PORT.BorderStyle = BorderStyle.FixedSingle;
            PORT.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PORT.ImeMode = ImeMode.Disable;
            PORT.Location = new Point(345, 33);
            PORT.Name = "PORT";
            PORT.Size = new Size(90, 27);
            PORT.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(290, 35);
            label7.Name = "label7";
            label7.Size = new Size(46, 18);
            label7.TabIndex = 16;
            label7.Text = "Port";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(6, 110);
            label6.Name = "label6";
            label6.Size = new Size(40, 18);
            label6.TabIndex = 15;
            label6.Text = "密碼";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(6, 74);
            label5.Name = "label5";
            label5.Size = new Size(40, 18);
            label5.TabIndex = 14;
            label5.Text = "帳號";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 11;
            label4.Text = "連線IP";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(454, 110);
            button1.Name = "button1";
            button1.Size = new Size(61, 27);
            button1.TabIndex = 10;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // PWD
            // 
            PWD.BorderStyle = BorderStyle.FixedSingle;
            PWD.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PWD.ImeMode = ImeMode.Disable;
            PWD.Location = new Point(89, 110);
            PWD.Name = "PWD";
            PWD.PasswordChar = '*';
            PWD.Size = new Size(346, 27);
            PWD.TabIndex = 13;
            PWD.TextChanged += textBox3_TextChanged;
            // 
            // RDP
            // 
            RDP.BorderStyle = BorderStyle.FixedSingle;
            RDP.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RDP.ImeMode = ImeMode.Disable;
            RDP.Location = new Point(89, 33);
            RDP.Name = "RDP";
            RDP.Size = new Size(187, 27);
            RDP.TabIndex = 9;
            RDP.TextChanged += RDP_TextChanged;
            RDP.KeyPress += RDP_KeyPress;
            // 
            // UID
            // 
            UID.BorderStyle = BorderStyle.FixedSingle;
            UID.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UID.ImeMode = ImeMode.Disable;
            UID.Location = new Point(89, 72);
            UID.Name = "UID";
            UID.Size = new Size(187, 27);
            UID.TabIndex = 12;
            UID.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(11, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 267);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "說明";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(10, 176);
            label2.Name = "label2";
            label2.Size = new Size(111, 14);
            label2.TabIndex = 6;
            label2.Text = "滑鼠右鍵功能介紹";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(5, 25);
            label3.Name = "label3";
            label3.Size = new Size(150, 14);
            label3.TabIndex = 7;
            label3.Text = "程式縮小後常駐在右下角";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Verdana", 9.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Teal;
            textBox1.Location = new Point(10, 193);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(523, 68);
            textBox1.TabIndex = 1;
            textBox1.Text = "開啟「網頁」遠端連線：瀏覽器連到遠端連線網址\r\n開啟「遠端桌面連線」：執行微軟遠端連線程式\r\n「暫停本機左邊Shift鍵」：避免與遠端主機中文切換衝突\r\n「恢復本機左邊Shift鍵」：恢復本機切換中文功能";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._2024_03_26_09_16_48_;
            pictureBox1.Location = new Point(10, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "遠端連線幫手";
            notifyIcon1.BalloonTipTitle = "遠端連線幫手";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "遠端連線幫手";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 591);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "遠端連線幫手  3.1";
            Activated += Form1_Activated;
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox1;
        private TextBox URL;
        private Button save;
        private Label label1;
        private NotifyIcon notifyIcon1;
        private Label label2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private Button button1;
        private TextBox RDP;
        private TextBox PWD;
        private TextBox UID;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private TextBox PORT;
        private Label label7;
        private Label label8;
    }
}