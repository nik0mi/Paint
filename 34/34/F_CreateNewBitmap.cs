using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34
{
    public partial class F_CreateNewBitmap : Form
    {
        public F_CreateNewBitmap()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            Form1.diagRes.ready = false;
        }
        private void b_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Ok_Click_1(object sender, EventArgs e)
        {
            Form1.diagRes.widht = Convert.ToInt32(nud_Widht.Value);
            Form1.diagRes.height = Convert.ToInt32(nud_Height.Value);
            Form1.diagRes.ready = true;
            this.Close();
        }
    }
}
