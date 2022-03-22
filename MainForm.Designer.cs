namespace Finance.NET
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.siResult = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.siButton = new System.Windows.Forms.Button();
            this.si_n = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.si_r = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.si_P = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ciResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ciButton = new System.Windows.Forms.Button();
            this.ci_n = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ci_r = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ci_P = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.si_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_P)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ci_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ci_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ci_P)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.siResult);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.siButton);
            this.tabPage1.Controls.Add(this.si_n);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.si_r);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.si_P);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple Interest (SI)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siResult
            // 
            this.siResult.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siResult.Location = new System.Drawing.Point(101, 270);
            this.siResult.Name = "siResult";
            this.siResult.ReadOnly = true;
            this.siResult.Size = new System.Drawing.Size(661, 45);
            this.siResult.TabIndex = 8;
            this.siResult.Text = "---";
            this.siResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(6, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(756, 3);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // siButton
            // 
            this.siButton.BackColor = System.Drawing.SystemColors.Info;
            this.siButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.siButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siButton.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.siButton.Location = new System.Drawing.Point(262, 159);
            this.siButton.Name = "siButton";
            this.siButton.Size = new System.Drawing.Size(500, 96);
            this.siButton.TabIndex = 6;
            this.siButton.Text = "Process total interest charges!";
            this.siButton.UseVisualStyleBackColor = false;
            this.siButton.Click += new System.EventHandler(this.siButton_Click);
            // 
            // si_n
            // 
            this.si_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.si_n.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.si_n.ForeColor = System.Drawing.SystemColors.Highlight;
            this.si_n.Location = new System.Drawing.Point(262, 108);
            this.si_n.Name = "si_n";
            this.si_n.Size = new System.Drawing.Size(500, 45);
            this.si_n.TabIndex = 5;
            this.si_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period (months):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // si_r
            // 
            this.si_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.si_r.DecimalPlaces = 2;
            this.si_r.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.si_r.ForeColor = System.Drawing.SystemColors.Highlight;
            this.si_r.Location = new System.Drawing.Point(262, 57);
            this.si_r.Name = "si_r";
            this.si_r.Size = new System.Drawing.Size(500, 45);
            this.si_r.TabIndex = 3;
            this.si_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest rate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Principal amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // si_P
            // 
            this.si_P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.si_P.DecimalPlaces = 2;
            this.si_P.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.si_P.ForeColor = System.Drawing.SystemColors.Highlight;
            this.si_P.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.si_P.Location = new System.Drawing.Point(262, 6);
            this.si_P.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.si_P.Name = "si_P";
            this.si_P.Size = new System.Drawing.Size(500, 45);
            this.si_P.TabIndex = 0;
            this.si_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.si_P.ThousandsSeparator = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ciResult);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.ciButton);
            this.tabPage2.Controls.Add(this.ci_n);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ci_r);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ci_P);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compound Interest (CI)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 38);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ciResult
            // 
            this.ciResult.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ciResult.Location = new System.Drawing.Point(101, 270);
            this.ciResult.Name = "ciResult";
            this.ciResult.ReadOnly = true;
            this.ciResult.Size = new System.Drawing.Size(661, 45);
            this.ciResult.TabIndex = 18;
            this.ciResult.Text = "---";
            this.ciResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(6, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(756, 3);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ciButton
            // 
            this.ciButton.BackColor = System.Drawing.SystemColors.Info;
            this.ciButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ciButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciButton.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ciButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ciButton.Location = new System.Drawing.Point(262, 159);
            this.ciButton.Name = "ciButton";
            this.ciButton.Size = new System.Drawing.Size(500, 96);
            this.ciButton.TabIndex = 16;
            this.ciButton.Text = "Process total interest charges!";
            this.ciButton.UseVisualStyleBackColor = false;
            this.ciButton.Click += new System.EventHandler(this.ciButton_Click);
            // 
            // ci_n
            // 
            this.ci_n.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ci_n.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ci_n.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ci_n.Location = new System.Drawing.Point(262, 108);
            this.ci_n.Name = "ci_n";
            this.ci_n.Size = new System.Drawing.Size(500, 45);
            this.ci_n.TabIndex = 15;
            this.ci_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Period (months):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ci_r
            // 
            this.ci_r.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ci_r.DecimalPlaces = 2;
            this.ci_r.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ci_r.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ci_r.Location = new System.Drawing.Point(262, 57);
            this.ci_r.Name = "ci_r";
            this.ci_r.Size = new System.Drawing.Size(500, 45);
            this.ci_r.TabIndex = 13;
            this.ci_r.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(70, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 38);
            this.label7.TabIndex = 12;
            this.label7.Text = "Interest rate:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 38);
            this.label8.TabIndex = 11;
            this.label8.Text = "Principal amount:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ci_P
            // 
            this.ci_P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ci_P.DecimalPlaces = 2;
            this.ci_P.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ci_P.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ci_P.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ci_P.Location = new System.Drawing.Point(262, 6);
            this.ci_P.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ci_P.Name = "ci_P";
            this.ci_P.Size = new System.Drawing.Size(500, 45);
            this.ci_P.TabIndex = 10;
            this.ci_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ci_P.ThousandsSeparator = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance .NET";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.si_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.si_P)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ci_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ci_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ci_P)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private NumericUpDown si_P;
        private NumericUpDown si_r;
        private Label label2;
        private NumericUpDown si_n;
        private Label label3;
        private Button siButton;
        private Button button2;
        private TextBox siResult;
        private Label label4;
        private Label label5;
        private TextBox ciResult;
        private Button button1;
        private Button ciButton;
        private NumericUpDown ci_n;
        private Label label6;
        private NumericUpDown ci_r;
        private Label label7;
        private Label label8;
        private NumericUpDown ci_P;
    }
}