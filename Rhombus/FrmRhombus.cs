using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1.Rhombus
{
    public partial class FrmRhombus : Form
    {
        public FrmRhombus()
        {
            InitializeComponent();
        }
        private Rhombus objRhombus = new Rhombus();
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objRhombus.ReadData(txtD1, txtD2);
            objRhombus.CalculateRhombus();
            objRhombus.PrintData(txtPerimeter, txtArea);
            objRhombus.PlotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();
            this.Hide();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            objRhombus.InitializeData(txtD1, txtD2, txtPerimeter, txtArea, picCanvas);
        }

        private void FrmRhombus_Load(object sender, EventArgs e)
        {
            objRhombus.InitializeData(txtD1, txtD2, txtPerimeter, txtArea, picCanvas);
        }
    }
}
