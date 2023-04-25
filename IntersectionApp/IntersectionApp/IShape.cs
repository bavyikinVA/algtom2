using System.Collections.Generic;
using System.Drawing;

namespace IntersectionApp
{
    public interface IShape
    {
        void Draw(Graphics g);
        List<PointF> GetIntersectionPoints(Line line);
        float GetLineLengthInside(Line line);
    }
}