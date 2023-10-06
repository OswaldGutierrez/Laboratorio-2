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
            SuspendLayout();
            // 
            // textBoxFuncion1
            // 
            textBoxFuncion1.Location = new Point(329, 87);
            textBoxFuncion1.Name = "textBoxFuncion1";
            textBoxFuncion1.Size = new Size(100, 23);
            textBoxFuncion1.TabIndex = 0;
            // 
            // textBoxFuncion2
            // 
            textBoxFuncion2.Location = new Point(329, 156);
            textBoxFuncion2.Name = "textBoxFuncion2";
            textBoxFuncion2.Size = new Size(100, 23);
            textBoxFuncion2.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(532, 116);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(77, 37);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
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
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(744, 27);
            label1.TabIndex = 4;
            label1.Text = "Paralelismo, perpendicularidad y puntos de intersección entre dos rectas lineales.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(273, 23);
            label2.TabIndex = 5;
            label2.Text = "Ingrese su primera ecuación lineal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 153);
            label3.Name = "label3";
            label3.Size = new Size(276, 23);
            label3.TabIndex = 6;
            label3.Text = "Ingrese su segunda ecuación lineal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 426);
            label4.Name = "label4";
            label4.Size = new Size(408, 17);
            label4.TabIndex = 7;
            label4.Text = "Por favor, introduzca los valores decimales haciendo uso de la coma ' , '\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelInterseccion);
            Controls.Add(buttonCalcular);
            Controls.Add(textBoxFuncion2);
            Controls.Add(textBoxFuncion1);
            Name = "Form1";
            Text = "Form1";
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
    }
}