namespace Laboratorio_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFuncion1 = new TextBox();
            textBoxFuncion2 = new TextBox();
            buttonCalcular = new Button();
            labelInterseccion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label4 = new Label();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            buttonCalcular2 = new Button();
            textBoxFuncion3 = new TextBox();
            textBoxFuncion4 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxFuncion1
            // 
            textBoxFuncion1.Location = new Point(331, 27);
            textBoxFuncion1.Name = "textBoxFuncion1";
            textBoxFuncion1.Size = new Size(100, 23);
            textBoxFuncion1.TabIndex = 0;
            // 
            // textBoxFuncion2
            // 
            textBoxFuncion2.Location = new Point(331, 85);
            textBoxFuncion2.Name = "textBoxFuncion2";
            textBoxFuncion2.Size = new Size(100, 23);
            textBoxFuncion2.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(216, 153);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(77, 37);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            buttonCalcular.MouseLeave += buttonCalcular_MouseLeave;
            buttonCalcular.MouseHover += buttonCalcular_MouseHover;
            // 
            // labelInterseccion
            // 
            labelInterseccion.AutoSize = true;
            labelInterseccion.Location = new Point(732, 426);
            labelInterseccion.Name = "labelInterseccion";
            labelInterseccion.Size = new Size(10, 15);
            labelInterseccion.TabIndex = 3;
            labelInterseccion.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(278, 9);
            label1.Name = "label1";
            label1.Size = new Size(744, 27);
            label1.TabIndex = 4;
            label1.Text = "Paralelismo, perpendicularidad y puntos de intersección entre dos rectas lineales.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 27);
            label2.Name = "label2";
            label2.Size = new Size(273, 23);
            label2.TabIndex = 5;
            label2.Text = "Ingrese su primera ecuación lineal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 85);
            label3.Name = "label3";
            label3.Size = new Size(276, 23);
            label3.TabIndex = 6;
            label3.Text = "Ingrese su segunda ecuación lineal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(28, 498);
            label4.Name = "label4";
            label4.Size = new Size(408, 17);
            label4.TabIndex = 7;
            label4.Text = "Por favor, introduzca los valores decimales haciendo uso de la coma ' , '\r\n";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonCalcular);
            panel1.Controls.Add(textBoxFuncion1);
            panel1.Controls.Add(textBoxFuncion2);
            panel1.Location = new Point(28, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 326);
            panel1.TabIndex = 8;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(28, 64);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(138, 19);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pendiente Intercepto:";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(658, 64);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(116, 19);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Punto Pendiente:";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(buttonCalcular2);
            panel2.Controls.Add(textBoxFuncion3);
            panel2.Controls.Add(textBoxFuncion4);
            panel2.Location = new Point(658, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(499, 326);
            panel2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 27);
            label5.Name = "label5";
            label5.Size = new Size(273, 23);
            label5.TabIndex = 5;
            label5.Text = "Ingrese su primera ecuación lineal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(3, 85);
            label6.Name = "label6";
            label6.Size = new Size(276, 23);
            label6.TabIndex = 6;
            label6.Text = "Ingrese su segunda ecuación lineal:";
            // 
            // buttonCalcular2
            // 
            buttonCalcular2.Location = new Point(216, 153);
            buttonCalcular2.Name = "buttonCalcular2";
            buttonCalcular2.Size = new Size(77, 37);
            buttonCalcular2.TabIndex = 2;
            buttonCalcular2.Text = "Calcular";
            buttonCalcular2.UseVisualStyleBackColor = true;
            // 
            // textBoxFuncion3
            // 
            textBoxFuncion3.Location = new Point(331, 27);
            textBoxFuncion3.Name = "textBoxFuncion3";
            textBoxFuncion3.Size = new Size(100, 23);
            textBoxFuncion3.TabIndex = 0;
            // 
            // textBoxFuncion4
            // 
            textBoxFuncion4.Location = new Point(331, 85);
            textBoxFuncion4.Name = "textBoxFuncion4";
            textBoxFuncion4.Size = new Size(100, 23);
            textBoxFuncion4.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 547);
            Controls.Add(panel2);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(labelInterseccion);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFuncion1;
        private TextBox textBoxFuncion2;
        private Button buttonCalcular;
        private Label labelInterseccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label4;
        private Panel panel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private Button buttonCalcular2;
        private TextBox textBoxFuncion3;
        private TextBox textBoxFuncion4;
    }
}