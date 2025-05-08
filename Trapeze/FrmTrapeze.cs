using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Trapeze
{
    public partial class FrmTrapeze : Form
    {

        private Trapeze objTrapeze = new Trapeze();
        public FrmTrapeze()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTrapeze.ReadData(txtBase1, txtBase2, txtHeight, txtSide1,txtSide2);
            objTrapeze.PerimeterTrapezoid();
            objTrapeze.AreaTrapezoid();
            objTrapeze.PrintData(txtPerimeter, txtArea);
            objTrapeze.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objTrapeze.InitializeData(txtBase1, txtBase2, txtHeight, txtSide1,txtSide2, txtPerimeter, txtArea, picCanvas);
        }

        private void FrmTrapeze_Load(object sender, EventArgs e)
        {
            objTrapeze.InitializeData(txtBase1, txtBase2, txtHeight, txtSide1, txtSide2, txtPerimeter, txtArea, picCanvas);
        }
    }
}
