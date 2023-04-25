using System;
using System.Collections.Generic;
using System.Drawing;

namespace IntersectionApp
{
    public class EllipseShape : IShape
    {
        private RectangleF rect;

        public EllipseShape(float centerX, float centerY, float width, float height)
        {
            rect = new RectangleF(centerX - width / 2, centerY - height / 2, width, height);
        }

        private PointF GetCenter()//___________
        {
            return new PointF(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, rect);
        }

        public List<PointF> GetIntersectionPoints(Line line)
        {
            PointF Center = GetCenter();//___________

            List<PointF> intersections = new List<PointF>();

            // Преобразование системы координат к центру эллипса
            PointF lineStartRelativeToEllipse = new PointF(line.Start.X - Center.X, line.Start.Y - Center.Y);
            PointF lineEndRelativeToEllipse = new PointF(line.End.X - Center.X, line.End.Y - Center.Y);

            double a = rect.Width / 2.0;//___________
            double b = rect.Height / 2.0; //___________

            // Параметры линии после масштабирования по осям X и Y
            PointF scaledLineStart = new PointF((float)(lineStartRelativeToEllipse.X / a), (float)(lineStartRelativeToEllipse.Y / b));
            PointF scaledLineEnd = new PointF((float)(lineEndRelativeToEllipse.X / a), (float)(lineEndRelativeToEllipse.Y / b));

            // Точки пересечения масштабированной линии с единичной окружностью
            List<PointF> circleIntersections = CircleLineIntersection(scaledLineStart, scaledLineEnd, 1);

            // Обратное масштабирование точек пересечения и смещение к исходной системе координат
            foreach (var point in circleIntersections)
            {
                intersections.Add(new PointF((float)(point.X * a) + Center.X, (float)(point.Y * b) + Center.Y));
            }

            return intersections;
        }

        public float GetLineLengthInside(Line line)
        {
            List<PointF> intersections = GetIntersectionPoints(line);
            if (intersections.Count < 2)
            {
                return 0;
            }

            return Distance(intersections[0], intersections[1]);
        }

        public float Distance(PointF p1, PointF p2)
        {
            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        public List<PointF> CircleLineIntersection(PointF p1, PointF p2, float radius)
        {
            List<PointF> intersections = new List<PointF>();

            float dx = p2.X - p1.X;
            float dy = p2.Y - p1.Y;
            float drSquared = dx * dx + dy * dy;
            float determinant = p1.X * p2.Y - p2.X * p1.Y;

            float discriminant = radius * radius * drSquared - determinant * determinant;

            if (discriminant < 0)
            {
                return intersections;
            }

            float sqrtDiscriminant = (float)Math.Sqrt(discriminant);
            float x1 = (determinant * dy + Math.Sign(dy) * dx * sqrtDiscriminant) / drSquared;
            float y1 = (-determinant * dx + Math.Abs(dy) * sqrtDiscriminant) / drSquared;
            intersections.Add(new PointF(x1, y1));

            if (discriminant != 0)
            {
                float x2 = (determinant * dy - Math.Sign(dy) * dx * sqrtDiscriminant) / drSquared;
                float y2 = (-determinant * dx - Math.Abs(dy) * sqrtDiscriminant) / drSquared;
                intersections.Add(new PointF(x2, y2));
            }

            return intersections;
        }
    }
}
