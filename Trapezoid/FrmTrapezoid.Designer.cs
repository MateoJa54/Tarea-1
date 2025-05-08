namespace Tarea_1.Trapezoid
{
    partial class FrmTrapezoid
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
            txtHeight = new TextBox();
            txtBase2 = new TextBox();
            txtBase1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
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
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(txtBase2);
            groupBox1.Controls.Add(txtBase1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 34);
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
            btnClean.Location = new Point(270, 716);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(125, 49);
            btnClean.TabIndex = 14;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(256, 633);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(157, 47);
            btnExit.TabIndex = 13;
            btnExit.Text = "Regresar al Menú";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(270, 368);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(125, 50);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPerimeter.Location = new Point(353, 547);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(275, 27);
            txtPerimeter.TabIndex = 11;
            // 
            // txtArea
            // 
            txtArea.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtArea.Location = new Point(353, 480);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(275, 27);
            txtArea.TabIndex = 10;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(66, 273);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(562, 27);
            txtHeight.TabIndex = 9;
            // 
            // txtBase2
            // 
            txtBase2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBase2.Location = new Point(66, 212);
            txtBase2.Name = "txtBase2";
            txtBase2.Size = new Size(562, 27);
            txtBase2.TabIndex = 8;
            // 
            // txtBase1
            // 
            txtBase1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBase1.Location = new Point(66, 141);
            txtBase1.Name = "txtBase1";
            txtBase1.Size = new Size(562, 27);
            txtBase1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 545);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 6;
            label6.Text = "Perímetro :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 478);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 5;
            label5.Text = "Área :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 238);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 4;
            label4.Text = "Altura :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 181);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 3;
            label3.Text = "Base Menor :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 117);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 2;
            label2.Text = "Base Mayor :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 28);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 1;
            label1.Text = "Cálculo del trapezoide ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(812, 73);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 1;
            label7.Text = "Gráfico :";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(812, 130);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(702, 502);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmTrapezoid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 953);
            Controls.Add(picCanvas);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Name = "FrmTrapezoid";
            Text = "FrmTrapezoid";
            Load += FrmTrapezoid_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtBase2;
        private TextBox txtBase1;
        private Button btnClean;
        private Button btnExit;
        private Button btnCalculate;
        private TextBox txtPerimeter;
        private TextBox txtArea;
        private TextBox txtHeight;
        private PictureBox picCanvas;
    }
}