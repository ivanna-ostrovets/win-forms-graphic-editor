using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Lab3
{
    public partial class GraphicEditor : Form
    {
        private Color brushColor = Color.Black;
        private int brushSize = 2;
        private int eraserSize = 5;
        private Bitmap bitmap;
        private Point lastPoint = Point.Empty;
        private bool isMouseDown;
        private bool isPenSelected = true;
        private bool isEraserSelected = false;
        private const string Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";

        public GraphicEditor()
        {
            InitializeComponent();

            InitBitmap();

            colorPicker.BackColor = brushColor;
            brushSizeBar.Value = brushSize;
            eraserSizeBar.Value = eraserSize;
            pen.BackColor = Color.AliceBlue;
        }

        private void InitBitmap()
        {
            bitmap = new Bitmap(canvas.Width, canvas.Height);

            using (var g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
            }

            canvas.Image = bitmap; 
        }

        private void OnCanvasMouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void OnCanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown != true) return;

            using (var g = Graphics.FromImage(canvas.Image))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.CompositingQuality = CompositingQuality.HighQuality;

                if (isEraserSelected)
                {
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(lastPoint.X, lastPoint.Y, eraserSize, eraserSize));
                } else if (isPenSelected) {
                    g.DrawLine(new Pen(brushColor, 1), lastPoint, e.Location);
                }
                else
                {
                    var myBrush = new SolidBrush(brushColor);
                    g.FillEllipse(myBrush, new Rectangle(lastPoint.X, lastPoint.Y, brushSize, brushSize));
                }
            }

            canvas.Invalidate();
            lastPoint = e.Location;
        }

        private void OnCanvasMouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void SelectBrush(object sender, EventArgs e)
        {
            isPenSelected = !isPenSelected;
            isEraserSelected = false;

            if (isPenSelected)
            {
                pen.BackColor = Color.AliceBlue;
                brush.BackColor = Color.LightGray;
            }
            else
            {
                pen.BackColor = Color.LightGray;
                brush.BackColor = Color.AliceBlue;
            }

            erase.BackColor = Color.LightGray;
        }

        private void ChangeBrushSize(object sender, EventArgs e)
        {
            brushSize = brushSizeBar.Value;
        }

        private void SelectColor(object sender, EventArgs e)
        {
            if (colorPickerDialog.ShowDialog() != DialogResult.OK) return;

            brushColor = colorPickerDialog.Color;
            colorPicker.BackColor = brushColor;
        }

        private void SelectEraser(object sender, EventArgs e)
        {
            isEraserSelected = !isEraserSelected;

            if (isEraserSelected)
            {
                pen.BackColor = Color.LightGray;
                brush.BackColor = Color.LightGray;
                erase.BackColor = Color.AliceBlue;
            }
            else
            {
                isPenSelected = true;

                pen.BackColor = Color.AliceBlue;
                brush.BackColor = Color.LightGray;
                erase.BackColor = Color.LightGray;
            }
        }

        private void ChangeEraserSize(object sender, EventArgs e)
        {
            eraserSize = eraserSizeBar.Value;
        }

        private void CreateNewFile(object sender, EventArgs e)
        {
            InitBitmap();
        }

        private void SaveFile(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "picture.bmp";
            saveFileDialog1.Filter = Filter;

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            canvas.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
        }

        private void OpenFile(object sender, EventArgs e)
        { 
            openFileDialog1.Filter = Filter;

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            canvas.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
