using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs71
{
    public partial class Form1 : Form
    {
        private Button[] _buttons = new Button[6];
        private FlowLayoutPanel flp;

        public void Display()
        {
            Application.Run(new Form1());
        }
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Flow Layout Panel Sample";
            this.Width = 600;
            this.Height = 100;

            flp = new FlowLayoutPanel();
            flp.Dock = DockStyle.Fill;

            for (int i = 0; i < _buttons.Length; i++)
            {
                _buttons[i] = new Button();
                _buttons[i].Text = Convert.ToString(i);
                _buttons[i].Parent = flp;
            }
            
            flp.Parent = this;
        }
    }
}