using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionApp
{
    internal class HelpFunc
    {
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
