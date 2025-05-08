using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado.FrmCuadrado frmCuadrado = new Cuadrado.FrmCuadrado();
            frmCuadrado.Show();
            this.Hide();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Rectangle.FrmRectangle frmRectangle = new Rectangle.FrmRectangle();
            frmRectangle.Show();
            this.Hide();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle.FrmCircle frmCircle = new Circle.FrmCircle();
            frmCircle.Show();
            this.Hide();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Triangle.FrmTriangle frmTriangle = new Triangle.FrmTriangle();
            frmTriangle.Show();
            this.Hide();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Ellipse.FrmEllipse frmEllipse = new Ellipse.FrmEllipse();
            frmEllipse.Show();
            this.Hide();
        }

        private void btnSemicircle_Click(object sender, EventArgs e)
        {
            Semicircle.FrmSemicircle frmSemicircle = new Semicircle.FrmSemicircle();
            frmSemicircle.Show();
            this.Hide();
        }

        private void btnTrapeze_Click(object sender, EventArgs e)
        {
            Trapezoid.FrmTrapezoid frmTrapezoid = new Trapezoid.FrmTrapezoid();
            frmTrapezoid.Show();
            this.Hide();
        }

        private void btnTrapezoid_Click(object sender, EventArgs e)
        {
            Trapeze.FrmTrapeze frmTrapeze = new Trapeze.FrmTrapeze();
            frmTrapeze.Show();
            this.Hide();
        }

        private void btnRhombus_Click(object sender, EventArgs e)
        {
            Rhombus.FrmRhombus frmRhombus = new Rhombus.FrmRhombus();
            frmRhombus.Show();
            this.Hide();
        }

        private void btnRhomboid_Click(object sender, EventArgs e)
        {
            Rhomboid.FrmRhomboid frmRhomboid = new Rhomboid.FrmRhomboid();
            frmRhomboid.Show();
            this.Hide();
        }

        private void btnKite_Click(object sender, EventArgs e)
        {
            Deltoid.FrmDeltoid frmDeltoid = new Deltoid.FrmDeltoid();
            frmDeltoid.Show();
            this.Hide();
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            Star.FrmStar frmStar = new Star.FrmStar();
            frmStar.Show();
            this.Hide();
        }
    }
}
