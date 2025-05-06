using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Cuadrado
{
    public class Cuadrado
    {
        //Datos Miembro (Atributos)
        //ancho del cuadrado
        private float mLade;
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
        public Cuadrado()
        {
            mLade = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que lee los datos de entrada del rectangulo
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

        //Funcion que calcula el perimetro del rectangulo
        public void PerimeterCuadrado()
        {
            mPerimeter = 2 * mLade;
        }

        //Funcion que calcula el area del rectangulo
        public void AreaCuadrado()
        {
            mArea = mLade * mLade;
        }
        //Funcion que imprime el perimetro y el area del rectangula.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Funcion que inicializa los datos y controles del rectangulo 
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
        //Funcion que grafica un rectangulo.
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            //Graficar un rectangulo 
            mGraph.DrawRectangle(mPen, 0, 0, mLade * SF, mLade * SF);
        }
        //Funcion que cierra un formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
