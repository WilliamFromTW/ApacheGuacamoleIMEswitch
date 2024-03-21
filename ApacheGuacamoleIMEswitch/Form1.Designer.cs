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
            buttonGuacamole = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            save = new Button();
            URL = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGuacamole
            // 
            buttonGuacamole.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuacamole.ForeColor = SystemColors.HotTrack;
            buttonGuacamole.Location = new Point(16, 21);
            buttonGuacamole.Name = "buttonGuacamole";
            buttonGuacamole.Size = new Size(532, 63);
            buttonGuacamole.TabIndex = 0;
            buttonGuacamole.Text = "開啟酪梨醬(遠端連線)";
            buttonGuacamole.UseVisualStyleBackColor = true;
            buttonGuacamole.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(574, 348);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(save);
            tabPage1.Controls.Add(URL);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(buttonGuacamole);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(566, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 98);
            label1.Name = "label1";
            label1.Size = new Size(200, 18);
            label1.TabIndex = 5;
            label1.Text = "請設定酪梨醬遠端登入網址";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // save
            // 
            save.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(487, 123);
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
            URL.Location = new Point(16, 124);
            URL.Name = "URL";
            URL.Size = new Size(465, 27);
            URL.TabIndex = 2;
            URL.Text = "https://www.google.com";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Crimson;
            textBox1.Location = new Point(16, 174);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 117);
            textBox1.TabIndex = 1;
            textBox1.Text = "\r\n點選「開啟酪梨醬(遠端連線)」將執行以下動作：\r\n\r\n1. 暫時關閉左邊Shift鍵(停止切換中文)\r\n2. 帶出chrome瀏覽器，並連到遠端連線網址\r\n3. 當主機所有chrome瀏覽器都關閉後，將自動還原左邊Shift鍵設定\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(566, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(54, 188);
            button3.Name = "button3";
            button3.Size = new Size(442, 62);
            button3.TabIndex = 1;
            button3.Text = "啟用主機左邊Shift鍵(可切換中文)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(54, 45);
            button2.Name = "button2";
            button2.Size = new Size(442, 61);
            button2.TabIndex = 0;
            button2.Text = "停用主機左邊Shift鍵(不能切換中文)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 372);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "解決酪梨醬中文切換問題  kafeiou 1.0";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGuacamole;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private TextBox URL;
        private Button save;
        private Label label1;
    }
}