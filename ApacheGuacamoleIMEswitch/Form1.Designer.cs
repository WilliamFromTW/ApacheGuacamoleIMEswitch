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
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            save = new Button();
            URL = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            timer1 = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
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
            tabControl1.Size = new Size(491, 439);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(save);
            tabPage1.Controls.Add(URL);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(483, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(6, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 288);
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
            label2.Location = new Point(5, 207);
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
            textBox1.Location = new Point(6, 208);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(447, 66);
            textBox1.TabIndex = 1;
            textBox1.Text = "\r\n「暫停本機左邊Shift鍵」：避免與遠端主機中文切換衝突\r\n「恢復本機左邊Shift鍵」：恢復本機切換中文功能\r\n「開啟酪梨醬(遠端連線)」：連到遠端連線網址\r\n\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources._2024_03_26_09_16_48_;
            pictureBox1.Location = new Point(10, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(184, 18);
            label1.TabIndex = 5;
            label1.Text = "預設酪梨醬遠端登入網址";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // save
            // 
            save.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(402, 53);
            save.Name = "save";
            save.Size = new Size(61, 31);
            save.TabIndex = 4;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // URL
            // 
            URL.BorderStyle = BorderStyle.FixedSingle;
            URL.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            URL.ImeMode = ImeMode.Disable;
            URL.Location = new Point(16, 53);
            URL.Name = "URL";
            URL.Size = new Size(374, 27);
            URL.TabIndex = 2;
            URL.TextChanged += URL_TextChanged;
            URL.KeyPress += URL_KeyPress;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipText = "ApacheGuacamole";
            notifyIcon1.BalloonTipTitle = "ApacheGuacamole";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "ApacheGuacamole";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseClick;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 480);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "解決酪梨醬中文切換問題  3.0";
            Activated += Form1_Activated;
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}