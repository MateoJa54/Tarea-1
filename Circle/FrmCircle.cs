using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Circle
{
    public partial class FrmCircle : Form
    {
        private Circle objCirculo = new Circle();

        public FrmCircle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objCirculo.ReadData(txtRadio);
            objCirculo.CalculatePerimetro();
            objCirculo.CalculateArea();
            objCirculo.PrintData(txtPerimetro, txtArea);
            objCirculo.PlotShape(picCanvas);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objCirculo.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            objCirculo.InitializeData(txtRadio, txtPerimetro, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
