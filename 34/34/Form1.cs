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
    public struct CrNewDialogRes
    {
        public int widht;
        public int height;
        public bool ready;
    }
    public partial class Form1 : Form
    {
        F_Image imageField = null;
        public static bool ImageFieldOpened = false;

        public static ImageEditor imageEditor = new ImageEditor();
        public static CrNewDialogRes diagRes = new CrNewDialogRes();
        public Form1()
        {
            InitializeComponent();

            p_Color.BackColor = Color.White;
            CreateField();
            openImageDialog.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg*";
            saveImageDialog.Filter = "All files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg*";
        }

        public void CreateField()
        {
            imageField = new F_Image();
            imageField.MdiParent = this;
            imageField.Show();
            ImageFieldOpened = true;
        }

        private void mb_create_Click(object sender, EventArgs e)
        {
            F_CreateNewBitmap createNewBitmap = new F_CreateNewBitmap();
            createNewBitmap.ShowDialog();
            if(diagRes.ready)
            {
                imageEditor = new ImageEditor(diagRes.widht, diagRes.height);
                imageField.Refresh();
                p_Color.BackColor = Color.White;
                nud_BrushRadius.Value = 30;
            }
        }
        private void mb_load_Click(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openImageDialog.FileName;
                imageEditor.LoadImage(filePath);
                imageField.Refresh();
            }
        }

        private void mb_saveAs_Click(object sender, EventArgs e)
        {
            if(saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveImageDialog.FileName;
                imageField.savePbImage(saveImageDialog.FileName);
            }
        }

        private void p_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                p_Color.BackColor = colorDialog.Color;
                imageEditor.SetBrushColor(colorDialog.Color);
            }
        }

        private void nud_BrushRadius_ValueChanged(object sender, EventArgs e)
        {
            imageEditor.SetBrushRadius(Convert.ToInt32(nud_BrushRadius.Value));
        }
    }
}
