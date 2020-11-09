namespace TagdijNyilvanTartas
{
    partial class TagUj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.textbox_nev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_iranyitoszam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_orszag = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Szül. év";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Irányítószám";
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Location = new System.Drawing.Point(387, 130);
            this.numericUpDown_szulev.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown_szulev.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.numericUpDown_szulev.Name = "numericUpDown_szulev";
            this.numericUpDown_szulev.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_szulev.TabIndex = 4;
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            // 
            // textbox_nev
            // 
            this.textbox_nev.Location = new System.Drawing.Point(387, 87);
            this.textbox_nev.Name = "textbox_nev";
            this.textbox_nev.Size = new System.Drawing.Size(120, 20);
            this.textbox_nev.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ország";
            // 
            // textBox_iranyitoszam
            // 
            this.textBox_iranyitoszam.Location = new System.Drawing.Point(387, 162);
            this.textBox_iranyitoszam.Name = "textBox_iranyitoszam";
            this.textBox_iranyitoszam.Size = new System.Drawing.Size(121, 20);
            this.textBox_iranyitoszam.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Felvétel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_orszag
            // 
            this.comboBox_orszag.FormattingEnabled = true;
            this.comboBox_orszag.Items.AddRange(new object[] {
            "H",
            "RO",
            "D"});
            this.comboBox_orszag.Location = new System.Drawing.Point(387, 206);
            this.comboBox_orszag.Name = "comboBox_orszag";
            this.comboBox_orszag.Size = new System.Drawing.Size(121, 21);
            this.comboBox_orszag.TabIndex = 10;
            // 
            // TagUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_orszag);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_iranyitoszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textbox_nev);
            this.Controls.Add(this.numericUpDown_szulev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TagUj";
            this.Text = "Új tag";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TagUj_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.TextBox textbox_nev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_iranyitoszam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_orszag;
    }
}