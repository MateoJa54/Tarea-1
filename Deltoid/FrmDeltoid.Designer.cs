namespace Tarea_1.Deltoid
{
    partial class FrmDeltoid
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
            txtDV = new TextBox();
            txtDH = new TextBox();
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
            groupBox1.Controls.Add(txtDV);
            groupBox1.Controls.Add(txtDH);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(619, 591);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.DodgerBlue;
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(222, 511);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(127, 44);
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
            btnExit.Location = new Point(195, 424);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(170, 52);
            btnExit.TabIndex = 10;
            btnExit.Text = "Regresar al Menú ";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(222, 252);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(127, 44);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(316, 378);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(227, 23);
            txtPerimeter.TabIndex = 8;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(316, 316);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(227, 23);
            txtArea.TabIndex = 7;
            // 
            // txtDV
            // 
            txtDV.Location = new Point(95, 194);
            txtDV.Name = "txtDV";
            txtDV.Size = new Size(448, 23);
            txtDV.TabIndex = 6;
            // 
            // txtDH
            // 
            txtDH.Location = new Point(95, 130);
            txtDH.Name = "txtDH";
            txtDH.Size = new Size(448, 23);
            txtDH.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 376);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 4;
            label5.Text = "Perímetro :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 314);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 3;
            label4.Text = "Área :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 170);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 2;
            label3.Text = "Diagonal Menor : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 106);
            label2.Name = "label2";
            label2.Size = new Size(141, 21);
            label2.TabIndex = 1;
            label2.Text = "Diagonal Mayor :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 31);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Cálculo del Deltoide";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(742, 96);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 1;
            label6.Text = "Gráfica :";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(749, 157);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(677, 458);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmDeltoid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 659);
            Controls.Add(picCanvas);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "FrmDeltoid";
            Text = "FrmDeltoid";
            Load += FrmDeltoid_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnClean;
        private Button btnExit;
        private Button btnCalculate;
        private TextBox txtPerimeter;
        private TextBox txtArea;
        private TextBox txtDV;
        private TextBox txtDH;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private PictureBox picCanvas;
    }
}