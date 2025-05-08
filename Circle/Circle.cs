using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Circle
{
    public class Circle
    {
        // Datos Miembro (Atributos)
        private float mRadio;            // radio del círculo
        private float mPerimetro;        // perímetro (circunferencia)
        private float mArea;             // área del círculo
        private Graphics mGraph;         // objeto para dibujo
        private Pen mPen;                // bolígrafo para trazo
                                         // Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;

        // Constructor sin parámetros
        public Circle()
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
        }

        // Lee el radio desde un TextBox
        public void ReadData(TextBox txtRadio)
        {
            try
            {
                mRadio = float.Parse(txtRadio.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...", "Error");
            }
        }

        // Calcula el perímetro (circunferencia)
        public void CalculatePerimetro()
        {
            mPerimetro = 2 * (float)Math.PI * mRadio;
        }

        // Calcula el área
        public void CalculateArea()
        {
            mArea = (float)Math.PI * mRadio * mRadio;
        }

        // Muestra perímetro y área en TextBoxes
        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        // Inicializa controles y datos
        public void InitializeData(TextBox txtRadio, TextBox txtPerimetro, TextBox txtArea, PictureBox picCanvas)
        {
            mRadio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            txtRadio.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";
            txtRadio.Focus();
            picCanvas.Refresh();
        }

        // Grafica el círculo en el PictureBox
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            float diametro = 2 * mRadio * SF;
            // Dibuja un círculo centrado en (0,0) desplazado para verse completo
            mGraph.DrawEllipse(mPen, 0, 0, diametro, diametro);
        }

        // Cierra el formulario
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
