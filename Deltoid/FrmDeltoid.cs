using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Deltoid
{
    public partial class FrmDeltoid : Form
    {
        public FrmDeltoid()
        {
            InitializeComponent();
        }
        private Deltoid obj = new Deltoid();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            obj.ReadData(txtDH, txtDV);
            obj.CalculateSides();
            obj.PerimeterDeltoid();
            obj.AreaDeltoid();
            obj.PrintData(txtPerimeter, txtArea);
            obj.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            obj.InitializeData(txtDH, txtDV, txtPerimeter, txtArea, picCanvas);
        }

        private void FrmDeltoid_Load(object sender, EventArgs e)
        {
            obj.InitializeData(txtDH, txtDV, txtPerimeter, txtArea, picCanvas);
        }
    }
}
