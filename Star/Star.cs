using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Star
{
    public class Star
    {
        private float mOuterRadius;
        private float mInnerRadius;
        private int mPoints = 5;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        public Star()
        {
            mOuterRadius = mInnerRadius = 0.0f;
            mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtOuter, TextBox txtInner)
        {
            try
            {
                mOuterRadius = float.Parse(txtOuter.Text);
                mInnerRadius = float.Parse(txtInner.Text);
                if (mOuterRadius <= 0 || mInnerRadius <= 0 || mInnerRadius >= mOuterRadius)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ingrese radios válidos: exterior > interior > 0.", "Error de ingreso");
                mOuterRadius = mInnerRadius = 0.0f;
            }
        }

        private PointF[] CalculateVertices()
        {
            int total = mPoints * 2;
            PointF[] pts = new PointF[total];
            double angleStep = Math.PI / mPoints;
            float orad = mOuterRadius * SF;
            float irad = mInnerRadius * SF;
            float cx = orad + 10;
            float cy = orad + 10;

            for (int i = 0; i < total; i++)
            {
                double ang = i * angleStep - Math.PI / 2;
                float r = (i % 2 == 0) ? orad : irad;
                pts[i] = new PointF(
                    cx + r * (float)Math.Cos(ang),
                    cy + r * (float)Math.Sin(ang)
                );
            }
            return pts;
        }
        public void PerimeterStar()
        {
            var pts = CalculateVertices();
            float sum = 0;
            for (int i = 0; i < pts.Length; i++)
            {
                PointF a = pts[i];
                PointF b = pts[(i + 1) % pts.Length];
                float dx = b.X - a.X;
                float dy = b.Y - a.Y;
                sum += (float)Math.Sqrt(dx * dx + dy * dy);
            }
            mPerimeter = sum;
        }

        // Calcula área por fórmula del polígono (shoelace)
        public void AreaStar()
        {
            var pts = CalculateVertices();
            double area = 0;
            int n = pts.Length;
            for (int i = 0; i < n; i++)
            {
                PointF p1 = pts[i];
                PointF p2 = pts[(i + 1) % n];
                area += p1.X * p2.Y - p2.X * p1.Y;
            }
            mArea = (float)(Math.Abs(area) / 2);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtOuter, TextBox txtInner, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mOuterRadius = mInnerRadius = 0.0f;
            mPerimeter = mArea = 0.0f;
            txtOuter.Text = txtInner.Text = "";
            txtPerimeter.Text = txtArea.Text = "";
            txtOuter.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Gold, 3);
            var pts = CalculateVertices();
            mGraph.DrawPolygon(mPen, pts);
        }

    }
}
