namespace Tarea_1.Rectangle
{
    partial class FrmRectangle
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPerimeter = new TextBox();
            txtArea = new TextBox();
            btnExit = new Button();
            btnCalcular = new Button();
            txtHeight = new TextBox();
            txtWidth = new TextBox();
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
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPerimeter);
            groupBox1.Controls.Add(txtArea);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(txtWidth);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 34);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(619, 697);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 501);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 10;
            label5.Text = "Perímetro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 410);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 9;
            label4.Text = "Área";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 201);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 8;
            label3.Text = "Altura:";
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(328, 498);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(250, 29);
            txtPerimeter.TabIndex = 7;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(328, 402);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(250, 29);
            txtArea.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(212, 597);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(158, 44);
            btnExit.TabIndex = 5;
            btnExit.Text = "Regresar al Menú";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DodgerBlue;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(226, 314);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(133, 44);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(57, 243);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(521, 29);
            txtHeight.TabIndex = 3;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(54, 151);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(524, 29);
            txtWidth.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 1;
            label2.Text = "Base:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 32);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de Rectángulo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(745, 81);
            label6.Name = "label6";
            label6.Size = new Size(85, 26);
            label6.TabIndex = 1;
            label6.Text = "Grafico:";
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(762, 131);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(587, 490);
            picCanvas.TabIndex = 2;
            picCanvas.TabStop = false;
            // 
            // FrmRectangle
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1384, 781);
            Controls.Add(picCanvas);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmRectangle";
            Text = "FrmRectangle";
            Load += FrmRectangle_Load;
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
        private TextBox txtHeight;
        private TextBox txtWidth;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPerimeter;
        private TextBox txtArea;
        private Button btnExit;
        private Button btnCalcular;
        private Label label6;
        private PictureBox picCanvas;
    }
}