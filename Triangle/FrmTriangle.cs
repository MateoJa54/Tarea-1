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

namespace Tarea_1.Triangle
{
    public partial class FrmTriangle : Form
    {
        public FrmTriangle()
        {
            InitializeComponent();
        }

        private Triangle objTriangle = new Triangle();

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            objTriangle.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objTriangle.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objTriangle.ReadData(txtSide);
            objTriangle.CalculatePerimeter();
            objTriangle.CalculateArea();
            objTriangle.PrintData(txtPerimeter, txtArea);
            objTriangle.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }
    }
}
