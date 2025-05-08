using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Rhomboid
{
    public partial class FrmRhomboid : Form
    {
        public FrmRhomboid()
        {
            InitializeComponent();
        }

        private Rhomboid objRhomboid = new Rhomboid();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //llamada a la funcion ReadData.
            objRhomboid.ReadData(txtSide, txtBase, txtHeight);
            objRhomboid.PerimeterRhomboid();
            objRhomboid.AreaRhomboid();
            objRhomboid.PrintData(txtPerimeter, txtArea);
            objRhomboid.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objRhomboid.InitializeData(txtSide,txtBase,txtHeight, txtPerimeter, txtArea, picCanvas);
        }
    }
}
