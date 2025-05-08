using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Rectangle
{
    public partial class FrmRectangle : Form
    {
        public FrmRectangle()
        {
            InitializeComponent();
        }


        //Definicion de un objeto de tipo CRectangle
        private Rectangle objRectangle = new Rectangle();

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            //inicializacion de los datos y controles. 
            // llmada a la funcion initializeData.
            objRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //lectura de datos.
            //llamada a la funcion ReadData.
            objRectangle.ReadData(txtWidth, txtHeight);
            objRectangle.PerimeterRectangle();
            objRectangle.AreaRectangle();
            objRectangle.PrintData(txtPerimeter, txtArea);
            objRectangle.PlotShape(picCanvas);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }
    }
}
