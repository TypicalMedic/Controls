
namespace WinFormsControlLib
{
    partial class ChooseColor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.RadioButton radioButton1;
            this.red = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Rc = new WinFormsControlLib.NumberBox(this.components);
            this.Gc = new WinFormsControlLib.NumberBox(this.components);
            this.Bc = new WinFormsControlLib.NumberBox(this.components);
            radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButton1.Location = new System.Drawing.Point(4, 100);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(53, 22);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Dec";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.BackColor = System.Drawing.Color.Transparent;
            this.red.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.red.Location = new System.Drawing.Point(4, 3);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(36, 18);
            this.red.TabIndex = 0;
            this.red.Text = "Red";
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Transparent;
            this.Green.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Green.Location = new System.Drawing.Point(4, 33);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(52, 18);
            this.Green.TabIndex = 1;
            this.Green.Text = "Green";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.BackColor = System.Drawing.Color.Transparent;
            this.Blue.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Blue.Location = new System.Drawing.Point(4, 63);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(41, 18);
            this.Blue.TabIndex = 2;
            this.Blue.Text = "Blue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(123, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 119);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(62, 100);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 22);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Hex";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Rc
            // 
            this.Rc.Location = new System.Drawing.Point(62, 3);
            this.Rc.Name = "Rc";
            this.Rc.Size = new System.Drawing.Size(55, 23);
            this.Rc.TabIndex = 9;
            this.Rc.Text = "0";
            this.Rc.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            // 
            // Gc
            // 
            this.Gc.Location = new System.Drawing.Point(62, 34);
            this.Gc.Name = "Gc";
            this.Gc.Size = new System.Drawing.Size(55, 23);
            this.Gc.TabIndex = 10;
            this.Gc.Text = "0";
            this.Gc.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            // 
            // Bc
            // 
            this.Bc.Location = new System.Drawing.Point(62, 63);
            this.Bc.Name = "Bc";
            this.Bc.Size = new System.Drawing.Size(55, 23);
            this.Bc.TabIndex = 11;
            this.Bc.Text = "0";
            this.Bc.TextChanged += new System.EventHandler(this.RGB_TextChanged);
            // 
            // ChooseColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Bc);
            this.Controls.Add(this.Gc);
            this.Controls.Add(this.Rc);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.red);
            this.Name = "ChooseColor";
            this.Size = new System.Drawing.Size(247, 125);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label red;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private NumberBox Rc;
        private NumberBox Gc;
        private NumberBox Bc;
    }
}
