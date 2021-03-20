
namespace _34
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Файл = new System.Windows.Forms.MenuStrip();
            this.mb_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_load = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_create = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_ = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_openPanelDarw = new System.Windows.Forms.ToolStripMenuItem();
            this.mb_closePanelDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.l_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.p_Insturments = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.p_Color = new System.Windows.Forms.Panel();
            this.nud_BrushRadius = new System.Windows.Forms.NumericUpDown();
            this.l_Radius = new System.Windows.Forms.Label();
            this.l_Color = new System.Windows.Forms.Label();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Файл.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.p_Insturments.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BrushRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // Файл
            // 
            this.Файл.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_file,
            this.mb_});
            this.Файл.Location = new System.Drawing.Point(0, 0);
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(800, 24);
            this.Файл.TabIndex = 1;
            this.Файл.Text = "menuStrip1";
            // 
            // mb_file
            // 
            this.mb_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_load,
            this.mb_saveAs,
            this.mb_create});
            this.mb_file.Name = "mb_file";
            this.mb_file.Size = new System.Drawing.Size(48, 20);
            this.mb_file.Text = "Файл";
            this.mb_file.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mb_load
            // 
            this.mb_load.Name = "mb_load";
            this.mb_load.Size = new System.Drawing.Size(180, 22);
            this.mb_load.Text = "Загрузить";
            this.mb_load.Click += new System.EventHandler(this.mb_load_Click);
            // 
            // mb_saveAs
            // 
            this.mb_saveAs.Name = "mb_saveAs";
            this.mb_saveAs.Size = new System.Drawing.Size(180, 22);
            this.mb_saveAs.Text = "Сохранить как";
            this.mb_saveAs.Click += new System.EventHandler(this.mb_saveAs_Click);
            // 
            // mb_create
            // 
            this.mb_create.Name = "mb_create";
            this.mb_create.Size = new System.Drawing.Size(180, 22);
            this.mb_create.Text = "Создать новый";
            this.mb_create.Click += new System.EventHandler(this.mb_create_Click);
            // 
            // mb_
            // 
            this.mb_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mb_openPanelDarw,
            this.mb_closePanelDraw});
            this.mb_.Name = "mb_";
            this.mb_.Size = new System.Drawing.Size(39, 20);
            this.mb_.Text = "Вид";
            // 
            // mb_openPanelDarw
            // 
            this.mb_openPanelDarw.Name = "mb_openPanelDarw";
            this.mb_openPanelDarw.Size = new System.Drawing.Size(225, 22);
            this.mb_openPanelDarw.Text = "Открыть панель рисования";
            // 
            // mb_closePanelDraw
            // 
            this.mb_closePanelDraw.Name = "mb_closePanelDraw";
            this.mb_closePanelDraw.Size = new System.Drawing.Size(225, 22);
            this.mb_closePanelDraw.Text = "Закрыть панель рисования";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.l_status});
            this.statusStrip.Location = new System.Drawing.Point(0, 422);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // l_status
            // 
            this.l_status.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.l_status.Name = "l_status";
            this.l_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.l_status.Size = new System.Drawing.Size(74, 17);
            this.l_status.Text = "Инструмент";
            // 
            // p_Insturments
            // 
            this.p_Insturments.Controls.Add(this.groupBox);
            this.p_Insturments.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_Insturments.Location = new System.Drawing.Point(0, 24);
            this.p_Insturments.Name = "p_Insturments";
            this.p_Insturments.Size = new System.Drawing.Size(200, 398);
            this.p_Insturments.TabIndex = 4;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.p_Color);
            this.groupBox.Controls.Add(this.nud_BrushRadius);
            this.groupBox.Controls.Add(this.l_Radius);
            this.groupBox.Controls.Add(this.l_Color);
            this.groupBox.Location = new System.Drawing.Point(12, 16);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(151, 114);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Кисть";
            // 
            // p_Color
            // 
            this.p_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_Color.Location = new System.Drawing.Point(9, 34);
            this.p_Color.Name = "p_Color";
            this.p_Color.Size = new System.Drawing.Size(70, 35);
            this.p_Color.TabIndex = 6;
            this.p_Color.Click += new System.EventHandler(this.p_Color_Click);
            // 
            // nud_BrushRadius
            // 
            this.nud_BrushRadius.Location = new System.Drawing.Point(9, 88);
            this.nud_BrushRadius.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_BrushRadius.Name = "nud_BrushRadius";
            this.nud_BrushRadius.Size = new System.Drawing.Size(62, 20);
            this.nud_BrushRadius.TabIndex = 2;
            this.nud_BrushRadius.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nud_BrushRadius.ValueChanged += new System.EventHandler(this.nud_BrushRadius_ValueChanged);
            // 
            // l_Radius
            // 
            this.l_Radius.AutoSize = true;
            this.l_Radius.Location = new System.Drawing.Point(6, 72);
            this.l_Radius.Name = "l_Radius";
            this.l_Radius.Size = new System.Drawing.Size(43, 13);
            this.l_Radius.TabIndex = 1;
            this.l_Radius.Text = "Радиус";
            // 
            // l_Color
            // 
            this.l_Color.AutoSize = true;
            this.l_Color.Location = new System.Drawing.Point(6, 16);
            this.l_Color.Name = "l_Color";
            this.l_Color.Size = new System.Drawing.Size(32, 13);
            this.l_Color.TabIndex = 0;
            this.l_Color.Text = "Цвет";
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.p_Insturments);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.Файл);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Файл;
            this.Name = "Form1";
            this.Text = "Графический редактор";
            this.Файл.ResumeLayout(false);
            this.Файл.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.p_Insturments.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BrushRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Файл;
        private System.Windows.Forms.ToolStripMenuItem mb_file;
        private System.Windows.Forms.ToolStripMenuItem mb_load;
        private System.Windows.Forms.ToolStripMenuItem mb_saveAs;
        private System.Windows.Forms.ToolStripMenuItem mb_create;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel l_status;
        private System.Windows.Forms.ToolStripMenuItem mb_;
        private System.Windows.Forms.ToolStripMenuItem mb_openPanelDarw;
        private System.Windows.Forms.ToolStripMenuItem mb_closePanelDraw;
        private System.Windows.Forms.Panel p_Insturments;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel p_Color;
        private System.Windows.Forms.NumericUpDown nud_BrushRadius;
        private System.Windows.Forms.Label l_Radius;
        private System.Windows.Forms.Label l_Color;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

