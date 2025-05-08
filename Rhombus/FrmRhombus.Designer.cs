namespace Tarea_1.Rhombus
{
    partial class FrmRhombus
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPerimeter = new TextBox();
            txtArea = new TextBox();
            txtD2 = new TextBox();
            txtD1 = new TextBox();
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
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPerimeter);
            groupBox1.Controls.Add(txtArea);
            groupBox1.Controls.Add(txtD2);
            groupBox1.Controls.Add(txtD1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(57, 41);
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
            btnClean.Location = new Point(276, 733);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(137, 51);
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
            btnExit.Location = new Point(248, 636);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(184, 52);
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
            btnCalculate.Location = new Point(276, 316);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(137, 49);
            btnCalculate.TabIndex = 9;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 518);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 8;
            label5.Text = "Perímetro :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(77, 425);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 7;
            label4.Text = "Área :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 198);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 6;
            label3.Text = "Diagonal 2 :";
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(370, 520);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(243, 23);
            txtPerimeter.TabIndex = 5;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(370, 427);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(243, 23);
            txtArea.TabIndex = 4;
            // 
            // txtD2
            // 
            txtD2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtD2.Location = new Point(93, 237);
            txtD2.Name = "txtD2";
            txtD2.Size = new Size(520, 27);
            txtD2.TabIndex = 3;
            // 
            // txtD1
            // 
            txtD1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtD1.Location = new Point(93, 149);
            txtD1.Name = "txtD1";
            txtD1.Size = new Size(520, 27);
            txtD1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 109);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Diagonal 1 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 32);
            label1.Name = "label1";
            label1.Size = new Size(229, 32);
            label1.TabIndex = 0;
            label1.Text = "Cálculo del Rombo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(854, 99);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 1;
            label6.Text = "Gráfica :";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(855, 163);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(647, 549);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmRhombus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 953);
            Controls.Add(picCanvas);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "FrmRhombus";
            Text = "FrmRhombus";
            Load += FrmRhombus_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtPerimeter;
        private TextBox txtArea;
        private TextBox txtD2;
        private TextBox txtD1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btnClean;
        private Button btnExit;
        private Button btnCalculate;
        private PictureBox picCanvas;
    }
}