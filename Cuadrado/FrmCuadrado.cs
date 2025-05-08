using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Tarea_1.Cuadrado
{
    public partial class FrmCuadrado : Form
    {
        public FrmCuadrado()
        {
            InitializeComponent();
        }

        private Cuadrado objCuadrado = new Cuadrado();

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            //inicializacion de los datos y controles. 
            // llmada a la funcion initializeData.

            objCuadrado.InitializeData(txtLade, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //llamada a la funcion ReadData.
            objCuadrado.ReadData(txtLade);
            objCuadrado.PerimeterCuadrado();
            objCuadrado.AreaCuadrado();
            objCuadrado.PrintData(txtPerimeter, txtArea);
            objCuadrado.PlotShape(picCanvas);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objCuadrado.InitializeData(txtLade, txtPerimeter, txtArea, picCanvas);

        }
    }
}
