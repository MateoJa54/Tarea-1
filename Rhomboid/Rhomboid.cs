using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Rhomboid
{
    public class Rhomboid
    {
        // Base del romboide 
        private float mBase;
        // Lado lateral del romboide 
        private float mSide;
        // Altura perpendicular al lado base
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        public Rhomboid()
        {
            mBase = mSide = mHeight = 0.0f;
            mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtBase, TextBox txtSide, TextBox txtHeight)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mSide = float.Parse(txtSide.Text);
                mHeight = float.Parse(txtHeight.Text);
                if (mBase <= 0 || mSide <= 0 || mHeight <= 0)
                    throw new Exception();
            }
            catch
            {
                MessageBox.Show("Ingrese números positivos válidos.", "Error de ingreso");
                mBase = mSide = mHeight = 0.0f;
            }
        }

        public void PerimeterRhomboid()
        {
            mPerimeter = 2 * (mBase + mSide);
        }

        public void AreaRhomboid()
        {
            mArea = mBase * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtBase, TextBox txtSide, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBase = mSide = mHeight = 0.0f;
            mPerimeter = mArea = 0.0f;
            txtBase.Text = txtSide.Text = txtHeight.Text = "";
            txtPerimeter.Text = txtArea.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Orange, 3);

            float b = mBase * SF;
            float h = mHeight * SF;
            // desplazamiento horizontal del lado inclinado: sqrt(side^2 - height^2)
            float dx = (float)Math.Sqrt(Math.Max(0, mSide * mSide - mHeight * mHeight)) * SF;

            // puntos A, B, C, D para paralelogramo
            PointF A = new PointF(0, h);
            PointF B = new PointF(b, h);
            PointF C = new PointF(b + dx, 0);
            PointF D = new PointF(dx, 0);

            mGraph.DrawPolygon(mPen, new PointF[] { A, B, C, D });
        }
    }
}
