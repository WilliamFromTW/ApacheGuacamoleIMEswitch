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
            buttonGuacamole = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            label1 = new Label();
            save = new Button();
            URL = new TextBox();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonGuacamole
            // 
            buttonGuacamole.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGuacamole.ForeColor = SystemColors.HotTrack;
            buttonGuacamole.Location = new Point(16, 113);
            buttonGuacamole.Name = "buttonGuacamole";
            buttonGuacamole.Size = new Size(713, 63);
            buttonGuacamole.TabIndex = 0;
            buttonGuacamole.Text = "按此「開啟酪梨醬(遠端連線)」";
            buttonGuacamole.UseVisualStyleBackColor = true;
            buttonGuacamole.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(758, 451);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(save);
            tabPage1.Controls.Add(URL);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(buttonGuacamole);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(750, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(16, 25);
            button2.Name = "button2";
            button2.Size = new Size(713, 61);
            button2.TabIndex = 6;
            button2.Text = "按此「停用本機左邊Shift鍵」";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(16, 204);
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
            save.Location = new Point(668, 222);
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
            URL.Location = new Point(16, 225);
            URL.Name = "URL";
            URL.Size = new Size(646, 27);
            URL.TabIndex = 2;
            URL.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Blue;
            textBox1.Location = new Point(16, 258);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(713, 117);
            textBox1.TabIndex = 1;
            textBox1.Text = "\r\n使用方式：\r\n1. 「停用本機左邊Shift鍵」暫時停止本機切換中文功能，以免與遠端主機中文切換相衝突\r\n2. 「開啟酪梨醬(遠端連線)」則帶出瀏覽器，並連到預設的遠端連線網址\r\n3. 「啟用本機左邊Shift鍵」則恢復本機切換中文功能\r\n\r\n";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 478);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.Off;
            Name = "Form1";
            Text = "解決酪梨醬中文切換問題  2.0";
            FormClosing += Form1_Closing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGuacamole;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox1;
        private TextBox URL;
        private Button save;
        private Label label1;
        private Button button2;
    }
}