namespace Tarea_1.Rhomboid
{
    partial class FrmRhomboid
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
            txtSide = new TextBox();
            txtBase = new TextBox();
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
            groupBox1.Controls.Add(txtSide);
            groupBox1.Controls.Add(txtBase);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(41, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 762);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.DodgerBlue;
            btnClean.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClean.ForeColor = Color.White;
            btnClean.Location = new Point(284, 656);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(144, 48);
            btnClean.TabIndex = 13;
            btnClean.Text = "Limpiar";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(261, 557);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 48);
            btnExit.TabIndex = 12;
            btnExit.Text = "Regresar al Menú";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.DodgerBlue;
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.Location = new Point(284, 346);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(144, 53);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(413, 501);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(197, 23);
            txtPerimeter.TabIndex = 10;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(413, 429);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(197, 23);
            txtArea.TabIndex = 9;
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHeight.Location = new Point(141, 296);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(469, 27);
            txtHeight.TabIndex = 8;
            // 
            // txtSide
            // 
            txtSide.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSide.Location = new Point(141, 222);
            txtSide.Name = "txtSide";
            txtSide.Size = new Size(469, 27);
            txtSide.TabIndex = 7;
            // 
            // txtBase
            // 
            txtBase.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBase.Location = new Point(141, 142);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(469, 27);
            txtBase.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 499);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 5;
            label6.Text = "Perímetro :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 427);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 4;
            label5.Text = "Área :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 261);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 3;
            label4.Text = "Altura :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 178);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 2;
            label3.Text = "Lado :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 102);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Base :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 43);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 0;
            label1.Text = "Cálculo del Romboide";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(849, 112);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 1;
            label7.Text = "Gráfica :";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(826, 153);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(504, 490);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmRhomboid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 841);
            Controls.Add(picCanvas);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Name = "FrmRhomboid";
            Text = "FrmRhomboid";
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
        private Button btnClean;
        private Button btnExit;
        private Button btnCalculate;
        private TextBox txtPerimeter;
        private TextBox txtArea;
        private TextBox txtHeight;
        private TextBox txtSide;
        private TextBox txtBase;
        private PictureBox picCanvas;
    }
}