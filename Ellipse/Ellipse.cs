using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Ellipse
{
    public class Ellipse
    {
        private float mRadiusX;
        private float mRadiusY;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20; 

        public Ellipse()
        {
            mRadiusX = mRadiusY = mPerimeter = mArea = 0.0f;
        }

        public void ReadData(TextBox txtRx, TextBox txtRy)
        {
            try
            {
                mRadiusX = float.Parse(txtRx.Text);
                mRadiusY = float.Parse(txtRy.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Error");
            }
        }

        public void CalculatePerimeter()
        {
            float a = mRadiusX;
            float b = mRadiusY;
            mPerimeter = (float)(Math.PI * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b))));
        }

        public void CalculateArea()
        {
            mArea = (float)(Math.PI * mRadiusX * mRadiusY);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        public void InitializeData(TextBox txtRx, TextBox txtRy, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadiusX = mRadiusY = mPerimeter = mArea = 0.0f;
            txtRx.Text = txtRy.Text = txtPerimeter.Text = txtArea.Text = "";
            txtRx.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3);
            mGraph.DrawEllipse(mPen, 0, 0, mRadiusX * SF * 2, mRadiusY * SF * 2);
        }
    }
}
