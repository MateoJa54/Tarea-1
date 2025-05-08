using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Ellipse
{
    public partial class FrmEllipse : Form
    {
        private Ellipse objEllipse = new Ellipse();
        public FrmEllipse()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objEllipse.InitializeData(txtRx, txtRy, txtArea, txtPerimeter, picCanvas);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objEllipse.ReadData(txtRx, txtRy);
            objEllipse.CalculatePerimeter();
            objEllipse.CalculateArea();
            objEllipse.PrintData(txtPerimeter, txtArea);
            objEllipse.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void FrmEllipse_Load(object sender, EventArgs e)
        {
            objEllipse.InitializeData(txtRx, txtRy, txtArea, txtPerimeter, picCanvas);

        }
    }
}
