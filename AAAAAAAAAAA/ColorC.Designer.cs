
namespace AAAAAAAAAAA
{
    partial class ColorC
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
            this.components = new System.ComponentModel.Container();
            this.chooseColor = new WinFormsControlLib.ChooseColor();
            this.label2 = new System.Windows.Forms.Label();
            this.Cncel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chooseColor
            // 
            this.chooseColor.BackColor = System.Drawing.Color.Transparent;
            this.chooseColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chooseColor.Location = new System.Drawing.Point(12, 56);
            this.chooseColor.Name = "chooseColor";
            this.chooseColor.Size = new System.Drawing.Size(247, 125);
            this.chooseColor.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 53);
            this.label2.TabIndex = 19;
            this.label2.Text = "Choose color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cncel
            // 
            this.Cncel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cncel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Cncel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cncel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cncel.Location = new System.Drawing.Point(155, 195);
            this.Cncel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cncel.Name = "Cncel";
            this.Cncel.Size = new System.Drawing.Size(96, 43);
            this.Cncel.TabIndex = 18;
            this.Cncel.Text = "Cancel";
            this.Cncel.UseVisualStyleBackColor = false;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OK.Location = new System.Drawing.Point(19, 195);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(96, 43);
            this.OK.TabIndex = 17;
            this.OK.Text = "Apply";
            this.OK.UseVisualStyleBackColor = false;
            // 
            // ColorC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(271, 257);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cncel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.chooseColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ColorC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cncel;
        private System.Windows.Forms.Button OK;
        public WinFormsControlLib.ChooseColor chooseColor;
    }
}