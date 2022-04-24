using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsControlLib
{
    public partial class ChooseColor : UserControl
    {
        public event EventHandler OnColorChanged;
        public Color Color
        {
            get
            {
                return Color.FromArgb(255, Rc.color, Gc.color, Bc.color);
            }
            set
            {
                Rc.Text = value.R.ToString();
                Gc.Text = value.G.ToString();
                Bc.Text = value.B.ToString();
            }
        }
        public ChooseColor()
        {
            OnColorChanged += ChooseColor_OnColorChanged;
            InitializeComponent();
        }

        private void ChooseColor_OnColorChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Rc.isHex = radioButton2.Checked;
            Gc.isHex = radioButton2.Checked;
            Bc.isHex = radioButton2.Checked;
            Rc.OnChangeHex();
            Gc.OnChangeHex();
            Bc.OnChangeHex();
        }

        private void RGB_TextChanged(object sender, EventArgs e)
        {
            OnColorChanged.Invoke(sender, e);
            pictureBox1.BackColor = Color.FromArgb(255, Rc.color, Gc.color, Bc.color);
        }
    }
}
