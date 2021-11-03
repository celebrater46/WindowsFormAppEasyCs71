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
        private TableLayoutPanel tlp;

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

            // flp = new FlowLayoutPanel();
            // flp.Dock = DockStyle.Fill;
            // flp.Dock = DockStyle.Bottom;
            // flp.Dock = DockStyle.Top;
            // flp.Dock = DockStyle.Left;
            // flp.Dock = DockStyle.Right;
            // flp.Anchor = AnchorStyles.None; // Center
            
            // for (int i = 0; i < _buttons.Length; i++)
            // {
            //     _buttons[i] = new Button();
            //     _buttons[i].Text = Convert.ToString(i);
            //     _buttons[i].Parent = flp;
            // }
            //
            // flp.Parent = this;

            tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            tlp.ColumnCount = 3;
            tlp.RowCount = 3;
            // tlp.SetColumnSpan(_buttons[0], 2); // Unite (Failed)
            // tlp.SetRowSpan(_buttons[3], 2);

            for (int j = 0; j < _buttons.Length; j++)
            {
                _buttons[j] = new Button();
                if(j == 0) { tlp.SetColumnSpan(_buttons[j], 2); } // Unite (Succeeded)
                _buttons[j].Text = Convert.ToString(j);
                _buttons[j].Parent = tlp;
            }

            tlp.Parent = this;
        }
    }
}