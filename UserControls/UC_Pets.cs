using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_Town.UserControls
{
    public partial class UC_Pets : UserControl
    {
        public UC_Pets()
        {
            InitializeComponent();
            UpdateScrollbar();
         
        }
        private void UpdateScrollbar()
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;

            int totalWidth = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                totalWidth += control.Width + flowLayoutPanel1.Margin.Horizontal;
            }
        }
    }
}
