
namespace _34
{
    partial class F_Image
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_X = new System.Windows.Forms.Label();
            this.l_Y = new System.Windows.Forms.Label();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.tb_X = new System.Windows.Forms.TextBox();
            this.tb_Y = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // l_X
            // 
            this.l_X.AutoSize = true;
            this.l_X.Location = new System.Drawing.Point(62, 17);
            this.l_X.Name = "l_X";
            this.l_X.Size = new System.Drawing.Size(14, 13);
            this.l_X.TabIndex = 1;
            this.l_X.Text = "X";
            // 
            // l_Y
            // 
            this.l_Y.AutoSize = true;
            this.l_Y.Location = new System.Drawing.Point(62, 98);
            this.l_Y.Name = "l_Y";
            this.l_Y.Size = new System.Drawing.Size(14, 13);
            this.l_Y.TabIndex = 2;
            this.l_Y.Text = "Y";
            // 
            // drawTimer
            // 
            this.drawTimer.Interval = 10;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // tb_X
            // 
            this.tb_X.Location = new System.Drawing.Point(21, 33);
            this.tb_X.Name = "tb_X";
            this.tb_X.Size = new System.Drawing.Size(100, 20);
            this.tb_X.TabIndex = 3;
            // 
            // tb_Y
            // 
            this.tb_Y.Location = new System.Drawing.Point(21, 114);
            this.tb_Y.Name = "tb_Y";
            this.tb_Y.Size = new System.Drawing.Size(100, 20);
            this.tb_Y.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(154, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 425);
            this.panel1.TabIndex = 5;
            // 
            // F_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Y);
            this.Controls.Add(this.tb_X);
            this.Controls.Add(this.l_Y);
            this.Controls.Add(this.l_X);
            this.Name = "F_Image";
            this.Text = "Холст";
            this.Shown += new System.EventHandler(this.F_Image_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.F_Image_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_X;
        private System.Windows.Forms.Label l_Y;
        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.TextBox tb_X;
        private System.Windows.Forms.TextBox tb_Y;
        private System.Windows.Forms.Panel panel1;
    }
}