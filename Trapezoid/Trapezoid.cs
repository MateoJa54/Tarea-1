using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Trapezoid
{
    public class Trapezoid
    {
        private float mBase1;
        private float mBase2;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Trapezoid()
        {
            mBase1 = 0.0f; mBase2 = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        public void ReadData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight)
        {
            try
            {
                mBase1 = float.Parse(txtBase1.Text);
                mBase2 = float.Parse(txtBase2.Text);
                mHeight = float.Parse(txtHeight.Text);
                if (mBase1 <= 0 || mBase2 <= 0 || mHeight <= 0)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ingresos no válidos. Ingrese solo números positivos.", "Mensaje de error");
                mBase1 = mBase2 = mHeight = 0.0f;
            }
        }

        public void PerimeterTrapezoid()
        {
            float halfDiff = (mBase1 - mBase2) / 2;
            float side = (float)Math.Sqrt(halfDiff * halfDiff + mHeight * mHeight);
            mPerimeter = mBase1 + mBase2 + 2 * side;
        }

        public void AreaTrapezoid()
        {
            mArea = ((mBase1 + mBase2) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase1 = mBase2 = mHeight = 0.0f;
            mPerimeter = mArea = 0.0f;
            txtBase1.Text = ""; txtBase2.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtBase1.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Purple, 3);

            float b1 = mBase1 * SF;
            float b2 = mBase2 * SF;
            float h = mHeight * SF;

            float offset = (b1 - b2) / 2;

            PointF A = new PointF(0, 0);
            PointF B = new PointF(b1, 0);
            PointF C = new PointF(offset + b2, h);
            PointF D = new PointF(offset, h);

            mGraph.DrawLine(mPen, A, B);
            mGraph.DrawLine(mPen, B, C);
            mGraph.DrawLine(mPen, C, D);
            mGraph.DrawLine(mPen, D, A);
        }

    }
}
