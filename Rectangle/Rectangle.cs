using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Rectangle
{
    public class Rectangle
    {
            //Datos Miembro (Atributos)
            //ancho del rectangulo
            private float mWidth;
            //Largo del rectangulo
            private float mHeight;
            //Perimetro del rectangulo
            private float mPerimeter;
            //Area del rectangulo
            private float mArea;
            //Objeto que activa el modo grafico
            private Graphics mGraph;
            //Constante scale factor (Zoom In/Zoom Out)
            private const float SF = 20;
            //Objeto boligrafo que dibuja o escribe en un lienzo (canvas)
            private Pen mPen;
            //Funciones Miembro (métodos)

            //constructor sin parametros
            public Rectangle()
            {
                mWidth = 0.0f; mHeight = 0.0f;
                mPerimeter = 0.0f; mArea = 0.0f;
            }
            //Funcion que lee los datos de entrada del rectangulo
            public void ReadData(TextBox txtWidth, TextBox txtHeight)
            {
                try
                {
                    mWidth = float.Parse(txtWidth.Text);
                    mHeight = float.Parse(txtHeight.Text);
                }
                catch
                {
                    MessageBox.Show("Ingeso no valido ...", "Mensaje de error");
                }
            }

            //Funcion que calcula el perimetro del rectangulo
            public void PerimeterRectangle()
            {
                mPerimeter = 2 * mWidth + 2 * mHeight;
            }

            //Funcion que calcula el area del rectangulo
            public void AreaRectangle()
            {
                mArea = mWidth * mHeight;
            }
            //Funcion que imprime el perimetro y el area del rectangula.
            public void PrintData(TextBox txtPerimeter, TextBox txtArea)
            {
                txtPerimeter.Text = mPerimeter.ToString();
                txtArea.Text = mArea.ToString();
            }
            //Funcion que inicializa los datos y controles del rectangulo 
            public void InitializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
            {
                mWidth = 0.0f; mHeight = 0.0f;
                mPerimeter = 0.0f; mArea = 0.0f;
                txtWidth.Text = " "; txtHeight.Text = " ";
                txtPerimeter.Text = " "; txtArea.Text = " ";
                // Mantiene el cursos titilando en una caja de texto 
                txtWidth.Focus();
                picCanvas.Refresh();
            }
            public void PlotShape(PictureBox picCanvas)
            {
                mGraph = picCanvas.CreateGraphics();
                mPen = new Pen(Color.Blue, 3);
                mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
            }
        }
}
