using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Trapeze
{
    public class Trapeze
    {
        private float mBase1;
        private float mBase2;
        private float mHeight;
        private float mSide1;
        private float mSide2;
        private float mPerimeter;
        private float mArea;

        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;

        public Trapeze()
        {
            mBase1 = mBase2 = mHeight = mSide1 = mSide2 = 0.0f;
            mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight, TextBox txtSide1, TextBox txtSide2)
        {
            try
            {
                mBase1 = float.Parse(txtBase1.Text);
                mBase2 = float.Parse(txtBase2.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);

                // Validar que sean positivos
                if (mBase1 <= 0 || mBase2 <= 0 || mHeight <= 0 || mSide1 <= 0 || mSide2 <= 0)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ingresos no válidos. Ingrese solo números positivos.", "Mensaje de error");
                mBase1 = mBase2 = mHeight = mSide1 = mSide2 = 0.0f;
            }
        }

        public void PerimeterTrapezoid()
        {
            mPerimeter = mBase1 + mBase2 + mSide1 + mSide2;
        }

        public void AreaTrapezoid()
        {
            mArea = ((mBase1 + mBase2) * mHeight) / 2;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtBase1, TextBox txtBase2, TextBox txtHeight, TextBox txtSide1, TextBox txtSide2, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase1 = mBase2 = mHeight = mSide1 = mSide2 = 0.0f;
            mPerimeter = mArea = 0.0f;
            txtBase1.Text = txtBase2.Text = txtHeight.Text = txtSide1.Text = txtSide2.Text = "";
            txtPerimeter.Text = txtArea.Text = "";
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

            float dx1 = (float)Math.Sqrt(Math.Max(0, mSide1 * mSide1 - mHeight * mHeight)) * SF;
            float dx2 = (float)Math.Sqrt(Math.Max(0, mSide2 * mSide2 - mHeight * mHeight)) * SF;

            // Punto de inicio (base mayor) con margen
            float x0 = 10;
            float y0 = 10;

            PointF A = new PointF(x0, y0 + h);                // vértice inferior izquierdo
            PointF B = new PointF(x0 + b1, y0 + h);           // vértice inferior derecho
            PointF C = new PointF(x0 + dx1 + b2, y0);         // vértice superior derecho
            PointF D = new PointF(x0 + dx1, y0);              // vértice superior izquierdo

            // Dibujo de los cuatro lados
            mGraph.DrawLine(mPen, A, B);
            mGraph.DrawLine(mPen, B, C);
            mGraph.DrawLine(mPen, C, D);
            mGraph.DrawLine(mPen, D, A);
        }

    }
}
