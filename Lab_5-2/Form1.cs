using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_2
{
    public partial class RhombForm : Form
    {
        public RhombForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RhombForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point((int)this.Width/2, 0),
        new Point(0, (int)this.Height/2),
new Point((int)this.Width/2, this.Height),
new Point(this.Width, (int)this.Height/2) });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }
    }
}
