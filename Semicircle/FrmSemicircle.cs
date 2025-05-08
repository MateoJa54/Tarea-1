using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Semicircle
{
    public partial class FrmSemicircle : Form
    {
        private Semicircle objSemicircle = new Semicircle();
        public FrmSemicircle()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objSemicircle.ReadData(txtRadius);
            objSemicircle.PerimeterSemicircle();
            objSemicircle.AreaSemicircle();
            objSemicircle.PrintData(txtPerimeter, txtArea);
            objSemicircle.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objSemicircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void FrmSemicircle_Load(object sender, EventArgs e)
        {
            objSemicircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }
    }
}
