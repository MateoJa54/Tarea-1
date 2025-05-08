namespace Tarea_1.Star
{
    partial class FrmStar
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
            txtInner = new TextBox();
            txtOuter = new TextBox();
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
            groupBox1.Controls.Add(txtInner);
            groupBox1.Controls.Add(txtOuter);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 581);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.DodgerBlue;
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(188, 496);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(126, 51);
            btnClean.TabIndex = 12;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(169, 426);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(166, 50);
            btnExit.TabIndex = 11;
            btnExit.Text = "Regresar al Menú";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(188, 242);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(126, 49);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPerimeter.Location = new Point(254, 383);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(188, 27);
            txtPerimeter.TabIndex = 9;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(254, 324);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(188, 23);
            txtArea.TabIndex = 8;
            // 
            // txtInner
            // 
            txtInner.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInner.Location = new Point(84, 185);
            txtInner.Name = "txtInner";
            txtInner.Size = new Size(358, 27);
            txtInner.TabIndex = 7;
            // 
            // txtOuter
            // 
            txtOuter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOuter.Location = new Point(84, 114);
            txtOuter.Name = "txtOuter";
            txtOuter.Size = new Size(358, 27);
            txtOuter.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 381);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 5;
            label5.Text = "Perímetro :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 322);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 4;
            label4.Text = "Área :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 156);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 3;
            label3.Text = "Ángulo Externo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 90);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 2;
            label2.Text = "Ángulo Interno :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 24);
            label1.Name = "label1";
            label1.Size = new Size(287, 32);
            label1.TabIndex = 1;
            label1.Text = "Cálculo de una Estrellla ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(681, 78);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 1;
            label6.Text = "Gráfica :";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(681, 117);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(709, 467);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmStar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 659);
            Controls.Add(picCanvas);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "FrmStar";
            Text = "FrmStar";
            Load += FrmStar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private TextBox txtPerimeter;
        private TextBox txtArea;
        private TextBox txtInner;
        private TextBox txtOuter;
        private Button btnClean;
        private Button btnExit;
        private Button btnCalculate;
        private PictureBox picCanvas;
    }
}