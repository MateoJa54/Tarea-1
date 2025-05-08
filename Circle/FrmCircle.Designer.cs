namespace Tarea_1.Circle
{
    partial class FrmCircle
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
            txtPerimetro = new TextBox();
            txtArea = new TextBox();
            txtRadio = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
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
            groupBox1.Controls.Add(txtPerimetro);
            groupBox1.Controls.Add(txtArea);
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 45);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(707, 870);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.DodgerBlue;
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(277, 718);
            btnClean.Margin = new Padding(3, 4, 3, 4);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(160, 63);
            btnClean.TabIndex = 10;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(249, 609);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(208, 64);
            btnExit.TabIndex = 9;
            btnExit.Text = "Regresar al Menú";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(277, 274);
            btnCalculate.Margin = new Padding(3, 4, 3, 4);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(160, 65);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPerimetro
            // 
            txtPerimetro.Location = new Point(321, 521);
            txtPerimetro.Margin = new Padding(3, 4, 3, 4);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.Size = new Size(319, 27);
            txtPerimetro.TabIndex = 7;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(321, 415);
            txtArea.Margin = new Padding(3, 4, 3, 4);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(319, 27);
            txtArea.TabIndex = 6;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(64, 183);
            txtRadio.Margin = new Padding(3, 4, 3, 4);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(577, 27);
            txtRadio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 517);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 4;
            label4.Text = "Perímetro :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 411);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 3;
            label3.Text = "Área :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 139);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 2;
            label2.Text = "Radio :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 37);
            label1.Name = "label1";
            label1.Size = new Size(280, 41);
            label1.TabIndex = 1;
            label1.Text = "Cálculo del Circulo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(835, 129);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 1;
            label5.Text = "Gráfica :";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(835, 184);
            picCanvas.Margin = new Padding(3, 4, 3, 4);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(681, 628);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmCircle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1582, 953);
            Controls.Add(picCanvas);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCircle";
            Text = "FrmCircle";
            Load += FrmCircle_Load;
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
        private TextBox txtPerimetro;
        private TextBox txtArea;
        private TextBox txtRadio;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private PictureBox picCanvas;
    }
}