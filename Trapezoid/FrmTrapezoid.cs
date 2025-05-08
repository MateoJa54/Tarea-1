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

namespace Tarea_1.Trapezoid
{
    public partial class FrmTrapezoid : Form
    {
        public FrmTrapezoid()
        {
            InitializeComponent();
        }


        private Trapezoid objTrapezoid = new Trapezoid();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //llamada a la funcion ReadData.
            objTrapezoid.ReadData(txtBase1,txtBase2,txtHeight);
            objTrapezoid.PerimeterTrapezoid();
            objTrapezoid.AreaTrapezoid();
            objTrapezoid.PrintData(txtPerimeter, txtArea);
            objTrapezoid.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objTrapezoid.InitializeData(txtBase1, txtBase2, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {
            objTrapezoid.InitializeData(txtBase1, txtBase2, txtHeight, txtPerimeter, txtArea, picCanvas);
        }
    }
}
