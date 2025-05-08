using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Semicircle
{
    public class Semicircle
    {
        private float mRadius;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20; 
        public Semicircle()
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Mensaje de error");
            }
        }

        public void PerimeterSemicircle()
        {
            mPerimeter = (float)(Math.PI * mRadius + 2 * mRadius);
        }

        // Función que calcula el área
        public void AreaSemicircle()
        {
            mArea = (float)(Math.PI * mRadius * mRadius / 2);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void InitializeData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtRadius.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 3);

            float scaledRadius = mRadius * SF;
            float diameter = scaledRadius * 2;

            mGraph.DrawArc(mPen, 0, 0, diameter, diameter, 180, 180);
            mGraph.DrawLine(mPen, 0, diameter / 2, diameter, diameter / 2);
        }
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
