namespace CS322_Domaci_zadatak_1_Nikola_Lazin_4384
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
            ime_tb = new TextBox();
            prezime_tb = new TextBox();
            adresa_tb = new TextBox();
            ime_lb = new Label();
            prezime_lb = new Label();
            adresa_lb = new Label();
            button1 = new Button();
            alert_lb = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ime_tb
            // 
            ime_tb.Location = new Point(60, 48);
            ime_tb.Name = "ime_tb";
            ime_tb.Size = new Size(223, 23);
            ime_tb.TabIndex = 0;
            // 
            // prezime_tb
            // 
            prezime_tb.Location = new Point(60, 92);
            prezime_tb.Name = "prezime_tb";
            prezime_tb.Size = new Size(223, 23);
            prezime_tb.TabIndex = 1;
            // 
            // adresa_tb
            // 
            adresa_tb.Location = new Point(60, 133);
            adresa_tb.Name = "adresa_tb";
            adresa_tb.Size = new Size(223, 23);
            adresa_tb.TabIndex = 2;
            // 
            // ime_lb
            // 
            ime_lb.AutoSize = true;
            ime_lb.Location = new Point(27, 48);
            ime_lb.Name = "ime_lb";
            ime_lb.Size = new Size(27, 15);
            ime_lb.TabIndex = 3;
            ime_lb.Text = "Ime";
            ime_lb.Click += label1_Click;
            // 
            // prezime_lb
            // 
            prezime_lb.AutoSize = true;
            prezime_lb.Location = new Point(5, 95);
            prezime_lb.Name = "prezime_lb";
            prezime_lb.Size = new Size(49, 15);
            prezime_lb.TabIndex = 5;
            prezime_lb.Text = "Prezime";
            prezime_lb.Click += label2_Click;
            // 
            // adresa_lb
            // 
            adresa_lb.AutoSize = true;
            adresa_lb.Location = new Point(11, 133);
            adresa_lb.Name = "adresa_lb";
            adresa_lb.Size = new Size(43, 15);
            adresa_lb.TabIndex = 7;
            adresa_lb.Text = "Adresa";
            // 
            // button1
            // 
            button1.Location = new Point(197, 247);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 8;
            button1.Text = "Unesi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // alert_lb
            // 
            alert_lb.AutoSize = true;
            alert_lb.ForeColor = Color.Red;
            alert_lb.Location = new Point(163, 9);
            alert_lb.Name = "alert_lb";
            alert_lb.Size = new Size(0, 15);
            alert_lb.TabIndex = 9;
            alert_lb.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(60, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(223, 56);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pol";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(123, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Zenski";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Muski";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 299);
            Controls.Add(groupBox1);
            Controls.Add(alert_lb);
            Controls.Add(button1);
            Controls.Add(adresa_lb);
            Controls.Add(prezime_lb);
            Controls.Add(ime_lb);
            Controls.Add(adresa_tb);
            Controls.Add(prezime_tb);
            Controls.Add(ime_tb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ime_tb;
        private TextBox prezime_tb;
        private TextBox adresa_tb;
        private Label ime_lb;
        private Label prezime_lb;
        private Label adresa_lb;
        private Button button1;
        private Label alert_lb;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}