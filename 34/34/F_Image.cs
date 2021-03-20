using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _34
{
    public partial class F_Image : Form
    {
        Point currentPoint;
        public F_Image()
        {
            InitializeComponent();
        }

        private void F_Image_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Image_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = Form1.imageEditor.Image;
        }
        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = Form1.imageEditor.CovertCoordinates(pictureBox1, e.X, e.Y);
            tb_X.Text = Convert.ToString(currentPoint.X);
            tb_Y.Text = Convert.ToString(currentPoint.Y);
        }
        public void savePbImage(string filePath)
        {
            try
            {
                pictureBox1.Image.Save(filePath, getFormat(filePath));
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public System.Drawing.Imaging.ImageFormat getFormat (string filePath)
        {
            string extension = Path.GetExtension(filePath);
            
            switch (extension)
            {
                case (".jpg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case ("jpeg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case (".png"):
                    return System.Drawing.Imaging.ImageFormat.Png;
                default:
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawTimer.Start();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawTimer.Stop();
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            int brushRadius = Form1.imageEditor.BrushRadius;
            for (int i = currentPoint.X - brushRadius; i < currentPoint.X + brushRadius; i++)
            {
                for (int j = currentPoint.Y - brushRadius; j <= currentPoint.Y + brushRadius; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(i - currentPoint.X, 2) + Math.Pow(j - currentPoint.Y, 2));
                    if(dist <= brushRadius && i >= 0 && j >=0 
                        && i < Form1.imageEditor.Image.Width 
                        && j < Form1.imageEditor.Image.Height)

                    Form1.imageEditor.Image.SetPixel(i, j, Form1.imageEditor.BrushColor);
                }
            }
            Invalidate();
        }
    }
}
