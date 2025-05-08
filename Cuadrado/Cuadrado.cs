using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Cuadrado
{
    public class Cuadrado
    {
        private float mLade;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;
        public Cuadrado()
        {
            mLade = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        public void ReadData(TextBox txtLade)
        {
            try
            {
                mLade = float.Parse(txtLade.Text);
            }
            catch
            {
                MessageBox.Show("Ingeso no valido ...", "Mensaje de error");
            }
        }

        public void PerimeterCuadrado()
        {
            mPerimeter = 2 * mLade;
        }

        public void AreaCuadrado()
        {
            mArea = mLade * mLade;
        }
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public void InitializeData(TextBox txtLade, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mLade = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtLade.Text = " ";
            txtPerimeter.Text = " "; txtArea.Text = " ";
            // Mantiene el cursos titilando en una caja de texto 
            txtLade.Focus();
            picCanvas.Refresh();
        }
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rectangulo 
            mGraph.DrawRectangle(mPen, 0, 0, mLade * SF, mLade * SF);
        }
    }
}
