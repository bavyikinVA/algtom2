using System.Drawing;

namespace IntersectionApp
{
    public class Line
    {
        public PointF Start { get; set; }
        public PointF End { get; set; }

        public Line()
        {
            Start = new PointF();
            End = new PointF();
        }

        public Line(PointF start, PointF end)
        {
            Start = start;
            End = end;
        }

        public void UpdateParameters(float a, float b)
        {
            Start = new PointF(0, b);
            End = new PointF(1, a + b);
        }

        public void Draw(Graphics g)
        {
            if (!Start.IsEmpty && !End.IsEmpty)
            {
                g.DrawLine(Pens.Black, Start, End);
            }
        }
    }
}
