namespace Tarea_1.Ellipse
{
    partial class FrmEllipse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnClean = new Button();
            btnExit = new Button();
            btnCalculate = new Button();
            txtPerimeter = new TextBox();
            txtArea = new TextBox();
            txtRy = new TextBox();
            txtRx = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            picCanvas = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnClean);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(txtPerimeter);
            groupBox1.Controls.Add(txtArea);
            groupBox1.Controls.Add(txtRy);
            groupBox1.Controls.Add(txtRx);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 870);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.DodgerBlue;
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(274, 733);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(161, 58);
            btnClean.TabIndex = 11;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(256, 608);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(197, 64);
            btnExit.TabIndex = 10;
            btnExit.Text = "Regresar al Menú";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(274, 334);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(161, 55);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPerimeter.Location = new Point(396, 550);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(215, 31);
            txtPerimeter.TabIndex = 8;
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.Location = new Point(396, 439);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(215, 31);
            txtArea.TabIndex = 7;
            // 
            // txtRy
            // 
            txtRy.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRy.Location = new Point(107, 222);
            txtRy.Name = "txtRy";
            txtRy.Size = new Size(504, 31);
            txtRy.TabIndex = 6;
            // 
            // txtRx
            // 
            txtRx.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRx.Location = new Point(107, 124);
            txtRx.Name = "txtRx";
            txtRx.Size = new Size(504, 31);
            txtRx.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 546);
            label5.Name = "label5";
            label5.Size = new Size(116, 28);
            label5.TabIndex = 4;
            label5.Text = "Perímetro :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(91, 435);
            label4.Name = "label4";
            label4.Size = new Size(67, 28);
            label4.TabIndex = 3;
            label4.Text = "Área :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 181);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 2;
            label3.Text = "Semi-eje menor :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 82);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 1;
            label2.Text = "Semi-eje mayor :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 33);
            label1.Name = "label1";
            label1.Size = new Size(211, 41);
            label1.TabIndex = 0;
            label1.Text = "Cálculo Elipse";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(822, 103);
            label6.Name = "label6";
            label6.Size = new Size(98, 28);
            label6.TabIndex = 1;
            label6.Text = "Gráfico : ";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(822, 169);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(697, 644);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmEllipse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1582, 953);
            Controls.Add(picCanvas);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "FrmEllipse";
            Text = "FrmEllipse";
            Load += FrmEllipse_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnClean;
        private Button btnExit;
        private Button btnCalculate;
        private TextBox txtPerimeter;
        private TextBox txtArea;
        private TextBox txtRy;
        private TextBox txtRx;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private PictureBox picCanvas;
    }
}