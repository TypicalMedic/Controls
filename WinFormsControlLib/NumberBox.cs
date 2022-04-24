using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsControlLib
{
    public partial class NumberBox : TextBox
    {
        public int color;
        public bool isHex = false;
        public NumberBox()
        {
            InitializeComponent();
        }
        public void OnChangeHex()
        {
            if (isHex)
            {
                Text = color.ToString("X");
            }
            else
            {
                Text = color.ToString();
            }
        }
        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            Text = Text.ToUpper();
            SelectionStart = Text.Length;
            SelectionLength = 0;
            int value;
            if (!isHex)
            {
                if (int.TryParse(Text, out value))
                {
                    if (value >= 0 && value <= 255)
                    {
                        color = value;
                    }
                    else
                    {
                        color = value < 0 ? 0 : 255;
                        Text = color.ToString();
                    }
                }
                else
                {
                    Text = color.ToString();
                }
            }
            else
            {
                if (int.TryParse(Text, System.Globalization.NumberStyles.HexNumber, null, out value))
                {
                    if (value >= 0 && value <= 255)
                    {
                        color = value;
                    }
                    else
                    {
                        color = value < 0 ? 0 : 255;
                        Text = color.ToString("X");
                    }
                }
                else
                {
                    Text = color.ToString("X");
                }

            }
            base.OnTextChanged(e);
        }

    }
}
