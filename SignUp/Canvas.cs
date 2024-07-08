using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SignUp
{
    public partial class Canvas : Form
    {
        private List<List<Point>> drawnLines = new List<List<Point>>();
        private List<Point> currentLine = new List<Point>();

        public Canvas()
        {
            InitializeComponent();
            drawingCanvas.Paint += drawingCanvas_Paint;
        }

        private void drawingCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            currentLine.Clear();
            currentLine.Add(e.Location);
        }

        private void drawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentLine.Add(e.Location);
                drawingCanvas.Invalidate();
            }
        }

        private void drawingCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentLine.Count > 1)
            {
                drawnLines.Add(new List<Point>(currentLine));
            }
            currentLine.Clear();
            drawingCanvas.Invalidate();
        }

        private void drawingCanvas_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 5))
            {
                foreach (var line in drawnLines)
                {
                    for (int i = 1; i < line.Count; i++)
                    {
                        e.Graphics.DrawLine(pen, line[i - 1], line[i]);
                    }
                }

                if (currentLine.Count > 1)
                {
                    for (int i = 1; i < currentLine.Count; i++)
                    {
                        e.Graphics.DrawLine(pen, currentLine[i - 1], currentLine[i]);
                    }
                }
            }
        }
    }
}