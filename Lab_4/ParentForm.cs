using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab_4.Child_Form;

namespace Lab_4
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 1;
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
           
    }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            Child_Form newChild = new Child_Form();//Здесь по клику объявляется новая Child_Form...
            newChild.MdiParent = this;//Здесь объявляем текущую форму MdiParent...
            newChild.Show();//Так где же ошибка?...Может нужен using? Не помогло...
        }
    }
}
