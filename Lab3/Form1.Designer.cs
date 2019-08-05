namespace Lab3
{
    partial class GraphicEditor
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
            this.brushSizeBar = new System.Windows.Forms.TrackBar();
            this.colorPicker = new System.Windows.Forms.Button();
            this.colorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.erase = new System.Windows.Forms.Button();
            this.pen = new System.Windows.Forms.Button();
            this.brush = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.eraserSizeBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserSizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // brushSizeBar
            // 
            this.brushSizeBar.AutoSize = false;
            this.brushSizeBar.Location = new System.Drawing.Point(72, 66);
            this.brushSizeBar.Maximum = 20;
            this.brushSizeBar.Minimum = 1;
            this.brushSizeBar.Name = "brushSizeBar";
            this.brushSizeBar.Size = new System.Drawing.Size(54, 21);
            this.brushSizeBar.TabIndex = 1;
            this.brushSizeBar.Value = 1;
            this.brushSizeBar.Scroll += new System.EventHandler(this.ChangeBrushSize);
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Black;
            this.colorPicker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorPicker.Location = new System.Drawing.Point(132, 27);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(48, 33);
            this.colorPicker.TabIndex = 7;
            this.colorPicker.UseVisualStyleBackColor = false;
            this.colorPicker.Click += new System.EventHandler(this.SelectColor);
            // 
            // colorPickerDialog
            // 
            this.colorPickerDialog.FullOpen = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileButton,
            this.saveFileButton,
            this.openFileButton});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(37, 20);
            this.menu.Text = "File";
            // 
            // newFileButton
            // 
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(180, 22);
            this.newFileButton.Text = "New";
            this.newFileButton.Click += new System.EventHandler(this.CreateNewFile);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(180, 22);
            this.saveFileButton.Text = "Save";
            this.saveFileButton.Click += new System.EventHandler(this.SaveFile);
            // 
            // openFileButton
            // 
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(180, 22);
            this.openFileButton.Text = "Open";
            this.openFileButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // erase
            // 
            this.erase.BackColor = System.Drawing.Color.LightGray;
            this.erase.Image = global::Lab3.Properties.Resources.eraser;
            this.erase.Location = new System.Drawing.Point(186, 27);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(54, 33);
            this.erase.TabIndex = 13;
            this.erase.UseVisualStyleBackColor = false;
            this.erase.Click += new System.EventHandler(this.SelectEraser);
            // 
            // pen
            // 
            this.pen.BackColor = System.Drawing.Color.LightGray;
            this.pen.Image = global::Lab3.Properties.Resources.edit;
            this.pen.Location = new System.Drawing.Point(12, 27);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(54, 33);
            this.pen.TabIndex = 12;
            this.pen.UseVisualStyleBackColor = false;
            this.pen.Click += new System.EventHandler(this.SelectBrush);
            // 
            // brush
            // 
            this.brush.BackColor = System.Drawing.Color.LightGray;
            this.brush.Image = global::Lab3.Properties.Resources.paint_brush;
            this.brush.Location = new System.Drawing.Point(72, 27);
            this.brush.Name = "brush";
            this.brush.Size = new System.Drawing.Size(54, 33);
            this.brush.TabIndex = 11;
            this.brush.UseVisualStyleBackColor = false;
            this.brush.Click += new System.EventHandler(this.SelectBrush);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(0, 103);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(800, 352);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnCanvasMouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnCanvasMouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnCanvasMouseUp);
            // 
            // eraserSizeBar
            // 
            this.eraserSizeBar.AutoSize = false;
            this.eraserSizeBar.Location = new System.Drawing.Point(186, 66);
            this.eraserSizeBar.Maximum = 50;
            this.eraserSizeBar.Minimum = 1;
            this.eraserSizeBar.Name = "eraserSizeBar";
            this.eraserSizeBar.Size = new System.Drawing.Size(54, 21);
            this.eraserSizeBar.TabIndex = 14;
            this.eraserSizeBar.Value = 1;
            this.eraserSizeBar.Scroll += new System.EventHandler(this.ChangeEraserSize);
            // 
            // GraphicEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eraserSizeBar);
            this.Controls.Add(this.erase);
            this.Controls.Add(this.pen);
            this.Controls.Add(this.brush);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.brushSizeBar);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GraphicEditor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.brushSizeBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eraserSizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.TrackBar brushSizeBar;
        private System.Windows.Forms.Button colorPicker;
        private System.Windows.Forms.ColorDialog colorPickerDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem saveFileButton;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button brush;
        private System.Windows.Forms.Button pen;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.TrackBar eraserSizeBar;
        private System.Windows.Forms.ToolStripMenuItem newFileButton;
    }
}

