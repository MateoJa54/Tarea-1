using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Rhombus
{
    public class Rhombus
    {
        // Diagonal mayor del rombo (horizontal)
        private float mDiagonal1;
        // Diagonal menor del rombo (vertical)
        private float mDiagonal2;
        // Lado del rombo (calculado)
        private float mSide;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        public Rhombus()
        {
            mDiagonal1 = mDiagonal2 = mSide = mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtD1, TextBox txtD2)
        {
            try
            {
                mDiagonal1 = float.Parse(txtD1.Text);
                mDiagonal2 = float.Parse(txtD2.Text);
                if (mDiagonal1 <= 0 || mDiagonal2 <= 0)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ingresos no válidos. Sólo números positivos.", "Error");
                mDiagonal1 = mDiagonal2 = 0.0f;
            }
        }
        public void CalculateRhombus()
        {
            // Lado = sqrt((d1/2)^2 + (d2/2)^2)
            mSide = (float)Math.Sqrt((mDiagonal1 / 2) * (mDiagonal1 / 2) + (mDiagonal2 / 2) * (mDiagonal2 / 2));
            mPerimeter = 4 * mSide;
            mArea = (mDiagonal1 * mDiagonal2) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }
        public void InitializeData(TextBox txtD1, TextBox txtD2, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mDiagonal1 = mDiagonal2 = mSide = mPerimeter = mArea = 0.0f;
            txtD1.Text = txtD2.Text = txtPerimeter.Text = txtArea.Text = "";
            txtD1.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);

            float w = mDiagonal1 * SF;
            float h = mDiagonal2 * SF;
            PointF[] pts = new PointF[] {
            new PointF(w/2, 0),        // superior
            new PointF(w, h/2),        // derecha
            new PointF(w/2, h),        // inferior
            new PointF(0, h/2)         // izquierda
        };
            mGraph.DrawPolygon(mPen, pts);
        }
    }
}
