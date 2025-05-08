using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Triangle
{
    public class Triangle
    {
        // Member data (attributes)
        private float mSide;         
        private float mPerimeter;    
        private float mArea;         
        private Graphics mGraph;     
        private Pen mPen;            
        private const float SF = 20; 

        public Triangle()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input...", "Error");
            }
        }

        public void CalculatePerimeter()
        {
            mPerimeter = 3 * mSide;
        }

        public void CalculateArea()
        {
            mArea = (float)(Math.Sqrt(3) / 4 * mSide * mSide);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
            txtSide.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            float sidePx = mSide * SF;
            float heightPx = (float)(Math.Sqrt(3) / 2 * sidePx);

            PointF p1 = new PointF(0, heightPx);
            PointF p2 = new PointF(sidePx / 2, 0);
            PointF p3 = new PointF(sidePx, heightPx);

            mGraph.DrawPolygon(mPen, new PointF[] { p1, p2, p3 });
        }

        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
