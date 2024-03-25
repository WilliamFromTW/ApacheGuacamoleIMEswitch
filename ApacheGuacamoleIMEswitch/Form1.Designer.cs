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
            label1 = new Label();
            save = new Button();
            URL = new TextBox();
            textBox1 = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(532, 245);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(save);
            tabPage1.Controls.Add(URL);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(524, 217);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(173, 18);
            label1.TabIndex = 5;
            label1.Text = "預設酪梨醬遠端登入網址";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // save
            // 
            save.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(444, 53);
            save.Name = "save";
            save.Size = new Size(61, 31);
            save.TabIndex = 4;
            save.Text = "save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // URL
            // 
            URL.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            URL.ImeMode = ImeMode.Disable;
            URL.Location = new Point(16, 53);
            URL.Name = "URL";
            URL.Size = new Size(407, 27);
            URL.TabIndex = 2;
            URL.TextChanged += URL_TextChanged;
            URL.KeyPress += URL_KeyPress;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(16, 104);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(489, 97);
            textBox1.TabIndex = 1;
            textBox1.Text = "\r\n本程式縮小後，會在右下角常駐，按滑鼠右鍵會出現以下功能\r\n「暫停本機左邊Shift鍵切換中文功能」：以免與遠端中文切換衝突\r\n「恢復本機左邊Shift鍵切換中文功能」：恢復本機切換中文功能\r\n「開啟酪梨醬(遠端連線)」：帶出瀏覽器，並連到預設的遠端連線網址\r\n\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
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
            ClientSize = new Size(556, 271);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "解決酪梨醬中文切換問題  3.0";
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            Resize += Form1_Resize;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
    }
}