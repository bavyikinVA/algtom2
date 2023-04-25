using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace IntersectionApp
{
    public partial class Form1 : Form
    {
        private IShape currentShape;
        private Line line;
        private bool isLineDefined;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFigures.SelectedIndex = 0;
            line = new Line(new PointF(50, 50), new PointF(300, 300));
            isLineDefined = true;
        }

        private void cmbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Parameter1.Text);
            int b = Convert.ToInt32(Parameter2.Text);
            switch (cmbFigures.SelectedItem.ToString())
            {

                case "Rectangle":
                    currentShape = new RectangleShape(pnlDrawArea.ClientSize.Width / 2, pnlDrawArea.ClientSize.Height / 2, a, b);
                    break;
                case "Ellipse":
                    currentShape = new EllipseShape(pnlDrawArea.ClientSize.Width / 2, pnlDrawArea.ClientSize.Height / 2, a, b);
                    break;
                case "Triangle":
                    currentShape = new TriangleShape(pnlDrawArea.ClientSize.Width / 2, pnlDrawArea.ClientSize.Height / 2, a, b);
                    break;
            }
            pnlDrawArea.Invalidate();

        }

        private void pnlDrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isLineDefined)
            {
                line.Start = e.Location;
                isLineDefined = true;
            }
            else
            {
                line.End = e.Location;
                isLineDefined = false;
            }
            pnlDrawArea.Invalidate();
        }

        private void pnlDrawArea_Paint(object sender, PaintEventArgs e)
        {
            if (currentShape != null)
            {
                currentShape.Draw(e.Graphics);
                if (isLineDefined)
                {
                    line.Draw(e.Graphics);
                    var intersections = currentShape.GetIntersectionPoints(line);
                    foreach (var point in intersections)
                    {
                        e.Graphics.FillEllipse(Brushes.Red, point.X - 3, point.Y - 3, 6, 6);
                    }
                    lblResult.Text = $"Intersections: {intersections.Count}, Length: {currentShape.GetLineLengthInside(line):0.##}";
                }
            }
        }

        private void btnUpdateLine_Click(object sender, EventArgs e)
        {
            float a, b;
            if (float.TryParse(txtParamA.Text, out a) && float.TryParse(txtParamB.Text, out b))
            {
                line.UpdateParameters(a, b);
                pnlDrawArea.Invalidate();
            }
            else
            {
                MessageBox.Show("Invalid parameters for the line.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

             

    }
}
