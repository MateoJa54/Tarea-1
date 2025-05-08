using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Star
{
    public partial class FrmStar : Form
    {
        public FrmStar()
        {
            InitializeComponent();
        }
        private Star objStar = new Star();
        private void btnClean_Click(object sender, EventArgs e)
        {
            objStar.InitializeData(txtOuter, txtInner, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objStar.ReadData(txtOuter, txtInner);
            objStar.PerimeterStar();
            objStar.AreaStar();
            objStar.PrintData(txtPerimeter, txtArea);
            objStar.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void FrmStar_Load(object sender, EventArgs e)
        {
            objStar.InitializeData(txtOuter, txtInner, txtPerimeter, txtArea, picCanvas);
        }
    }
}
