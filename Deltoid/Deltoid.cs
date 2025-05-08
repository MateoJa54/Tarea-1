using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Deltoid
{
    public class Deltoid
    {
        // Diagonal horizontal del deltoide
        private float mDiagonalH;
        // Diagonal vertical del deltoide
        private float mDiagonalV;
        // Lados del deltoide (dos pares iguales)
        private float mSideA;
        private float mSideB;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        public Deltoid()
        {
            mDiagonalH = mDiagonalV = 0.0f;
            mSideA = mSideB = 0.0f;
            mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtH, TextBox txtV)
        {
            try
            {
                mDiagonalH = float.Parse(txtH.Text);
                mDiagonalV = float.Parse(txtV.Text);
                if (mDiagonalH <= 0 || mDiagonalV <= 0)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ingrese números positivos válidos.", "Error de ingreso");
                mDiagonalH = mDiagonalV = 0.0f;
            }
        }

        public void CalculateSides()
        {
            float a = mDiagonalH / 2;
            float b = mDiagonalV / 2;
            // Lados: par A (entre extremos de diagonalV) y par B (entre extremos de diagonalH)
            mSideA = (float)Math.Sqrt(a * a + b * b);
            mSideB = mSideA;
        }

        public void PerimeterDeltoid()
        {
            mPerimeter = 2 * (mSideA + mSideB);
        }

        public void AreaDeltoid()
        {
            mArea = (mDiagonalH * mDiagonalV) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtH, TextBox txtV, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mDiagonalH = mDiagonalV = 0.0f;
            mSideA = mSideB = 0.0f;
            mPerimeter = mArea = 0.0f;
            txtH.Text = txtV.Text = "";
            txtPerimeter.Text = txtArea.Text = "";
            txtH.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Magenta, 3);

            float dh = mDiagonalH * SF;
            float dv = mDiagonalV * SF;
            float cx = picCanvas.Width / 2;
            float cy = picCanvas.Height / 2;

            PointF[] pts = new PointF[]
            {
            new PointF(cx - dh/2, cy),      // izquierda
            new PointF(cx,        cy - dv/2), // arriba
            new PointF(cx + dh/2, cy),      // derecha
            new PointF(cx,        cy + dv/2)  // abajo
            };

            mGraph.DrawPolygon(mPen, pts);
        }

    }
}
