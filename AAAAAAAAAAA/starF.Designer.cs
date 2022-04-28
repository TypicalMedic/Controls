namespace SUPERPAINT
{
    partial class starF
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
            this.Cncel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.peaks = new System.Windows.Forms.NumericUpDown();
            this.wlabel1 = new System.Windows.Forms.Label();
            this.percents = new System.Windows.Forms.NumericUpDown();
            this.perc = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.peaks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perc)).BeginInit();
            this.SuspendLayout();
            // 
            // Cncel
            // 
            this.Cncel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cncel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cncel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cncel.Location = new System.Drawing.Point(170, 210);
            this.Cncel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cncel.Name = "Cncel";
            this.Cncel.Size = new System.Drawing.Size(96, 43);
            this.Cncel.TabIndex = 3;
            this.Cncel.Text = "Close";
            this.Cncel.UseVisualStyleBackColor = false;
            this.Cncel.Click += new System.EventHandler(this.Cncel_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OK.Location = new System.Drawing.Point(34, 210);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 43);
            this.OK.TabIndex = 2;
            this.OK.Text = "Apply";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // peaks
            // 
            this.peaks.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.peaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.peaks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.peaks.Location = new System.Drawing.Point(195, 70);
            this.peaks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.peaks.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.peaks.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.peaks.Name = "peaks";
            this.peaks.Size = new System.Drawing.Size(71, 26);
            this.peaks.TabIndex = 9;
            this.peaks.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.peaks.ValueChanged += new System.EventHandler(this.wBox1_ValueChanged);
            // 
            // wlabel1
            // 
            this.wlabel1.AutoSize = true;
            this.wlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wlabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wlabel1.Location = new System.Drawing.Point(29, 73);
            this.wlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wlabel1.Name = "wlabel1";
            this.wlabel1.Size = new System.Drawing.Size(115, 20);
            this.wlabel1.TabIndex = 11;
            this.wlabel1.Text = "Peaks amount:";
            // 
            // percents
            // 
            this.percents.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.percents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percents.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.percents.Location = new System.Drawing.Point(195, 158);
            this.percents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.percents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.percents.Name = "percents";
            this.percents.Size = new System.Drawing.Size(71, 26);
            this.percents.TabIndex = 10;
            this.percents.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.percents.ValueChanged += new System.EventHandler(this.percents_ValueChanged);
            // 
            // perc
            // 
            this.perc.AutoSize = false;
            this.perc.BackColor = System.Drawing.Color.Gray;
            this.perc.Location = new System.Drawing.Point(34, 158);
            this.perc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.perc.Maximum = 100;
            this.perc.Minimum = 1;
            this.perc.Name = "perc";
            this.perc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.perc.Size = new System.Drawing.Size(161, 30);
            this.perc.TabIndex = 12;
            this.perc.TickFrequency = 0;
            this.perc.TickStyle = System.Windows.Forms.TickStyle.None;
            this.perc.Value = 50;
            this.perc.ValueChanged += new System.EventHandler(this.perc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inner radius percent %:";
            // 
            // ImgName
            // 
            this.ImgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImgName.Location = new System.Drawing.Point(29, 22);
            this.ImgName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ImgName.MaximumSize = new System.Drawing.Size(0, 58);
            this.ImgName.Name = "ImgName";
            this.ImgName.Size = new System.Drawing.Size(0, 35);
            this.ImgName.TabIndex = 14;
            this.ImgName.Text = "Star properties";
            this.ImgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(287, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 231);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(83, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Star properties";
            // 
            // starF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(541, 273);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImgName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.wlabel1);
            this.Controls.Add(this.percents);
            this.Controls.Add(this.peaks);
            this.Controls.Add(this.Cncel);
            this.Controls.Add(this.OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "starF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "starF";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.starF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.peaks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cncel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.NumericUpDown peaks;
        private System.Windows.Forms.Label wlabel1;
        private System.Windows.Forms.NumericUpDown percents;
        private System.Windows.Forms.TrackBar perc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ImgName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}