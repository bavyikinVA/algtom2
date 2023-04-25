using System;
using System.Collections.Generic;
using System.Drawing;

namespace IntersectionApp
{
    public class RectangleShape : IShape
    {
        private RectangleF rect;

        public RectangleShape(float centerX, float centerY, float width, float height)
        {
            rect = new RectangleF(centerX - width / 2, centerY - height / 2, width, height);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);
        }

        private PointF[] GetCorners()
        {
            return new PointF[]
            {
                new PointF(rect.X, rect.Y),
                new PointF(rect.X + rect.Width, rect.Y),
                new PointF(rect.X + rect.Width, rect.Y + rect.Height),
                new PointF(rect.X, rect.Y + rect.Height),
            };
        }

        public List<PointF> GetIntersectionPoints(Line line)
        {
            List<PointF> intersections = new List<PointF>();
            PointF[] rectPoints = GetCorners();

            for (int i = 0; i < 4; i++)
            {
                PointF intersection;
                if (LineSegmentsIntersection(line.Start, line.End, rectPoints[i], rectPoints[(i + 1) % 4], out intersection))
                {
                    intersections.Add(intersection);
                }
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

        public bool LineSegmentsIntersection(PointF p1, PointF p2, PointF p3, PointF p4, out PointF intersection)
        {
            float A1 = p2.Y - p1.Y;
            float B1 = p1.X - p2.X;
            float C1 = A1 * p1.X + B1 * p1.Y;

            float A2 = p4.Y - p3.Y;
            float B2 = p3.X - p4.X;
            float C2 = A2 * p3.X + B2 * p3.Y;

            float det = A1 * B2 - A2 * B1;
            if (Math.Abs(det) < 1e-6)
            {
                intersection = new PointF();
                return false; // параллельные или совпадающие линии
            }

            float x = (B2 * C1 - B1 * C2) / det;
            float y = (A1 * C2 - A2 * C1) / det;
            intersection = new PointF(x, y);

            if (IsPointOnLineSegment(p1, p2, intersection) && IsPointOnLineSegment(p3, p4, intersection))
            {
                return true;
            }

            return false;
        }

        public bool IsPointOnLineSegment(PointF p1, PointF p2, PointF p)
        {
            float minX = Math.Min(p1.X, p2.X);
            float maxX = Math.Max(p1.X, p2.X);
            float minY = Math.Min(p1.Y, p2.Y);
            float maxY = Math.Max(p1.Y, p2.Y);

            return p.X >= minX && p.X <= maxX && p.Y >= minY && p.Y <= maxY;
        }
    }
}
