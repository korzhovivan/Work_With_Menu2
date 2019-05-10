using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ToolStripMenuItem item = null;
        private void btn_AddNewItem_Click(object sender, EventArgs e)
        {
            menuStrip.Items.Add(txtBox_NewItem.Text);
            item = new ToolStripMenuItem(txtBox_NewItem.Text);
        }

        private void btn_AddNewSubItem_Click(object sender, EventArgs e)
        {
            item.DropDownItems.Add(txtBox_NewSubItem.Text);
            ToolStripMenuItem itemm = (ToolStripMenuItem)menuStrip.Items[menuStrip.Items.Count - 1];
            menuStrip.Items.Remove(itemm);
            itemm.DropDownItems.Add(txtBox_NewSubItem.Text);
            menuStrip.Items.Add(itemm);
        }
    }
}
