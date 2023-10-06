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
            Calcular = new Button();
            labelInterseccion = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxFuncion1
            // 
            textBoxFuncion1.Location = new Point(286, 84);
            textBoxFuncion1.Name = "textBoxFuncion1";
            textBoxFuncion1.Size = new Size(100, 23);
            textBoxFuncion1.TabIndex = 0;
            // 
            // textBoxFuncion2
            // 
            textBoxFuncion2.Location = new Point(286, 140);
            textBoxFuncion2.Name = "textBoxFuncion2";
            textBoxFuncion2.Size = new Size(100, 23);
            textBoxFuncion2.TabIndex = 1;
            // 
            // Calcular
            // 
            Calcular.Location = new Point(434, 118);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(75, 23);
            Calcular.TabIndex = 2;
            Calcular.Text = "button1";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += buttonCalcular_Click;
            // 
            // labelInterseccion
            // 
            labelInterseccion.AutoSize = true;
            labelInterseccion.Location = new Point(732, 426);
            labelInterseccion.Name = "labelInterseccion";
            labelInterseccion.Size = new Size(38, 15);
            labelInterseccion.TabIndex = 3;
            labelInterseccion.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(505, 15);
            label1.TabIndex = 4;
            label1.Text = "PARALELISMO, PERPENDICULARIDAD Y PUNTOS DE INTERSECCIÓN ENTRE 2 RECTAS LINEALES\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(243, 15);
            label2.TabIndex = 5;
            label2.Text = "Por favor, ingrese su primera ecuación lineal:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(247, 15);
            label3.TabIndex = 6;
            label3.Text = "Por favor, ingrese su segunda ecuación lineal:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelInterseccion);
            Controls.Add(Calcular);
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
        private Button Calcular;
        private Label labelInterseccion;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}