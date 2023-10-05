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
            SuspendLayout();
            // 
            // textBoxFuncion1
            // 
            textBoxFuncion1.Location = new Point(69, 35);
            textBoxFuncion1.Name = "textBoxFuncion1";
            textBoxFuncion1.Size = new Size(100, 23);
            textBoxFuncion1.TabIndex = 0;
            // 
            // textBoxFuncion2
            // 
            textBoxFuncion2.Location = new Point(69, 96);
            textBoxFuncion2.Name = "textBoxFuncion2";
            textBoxFuncion2.Size = new Size(100, 23);
            textBoxFuncion2.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(280, 62);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "button1";
            buttonCalcular.UseVisualStyleBackColor = true;
            // 
            // labelInterseccion
            // 
            labelInterseccion.AutoSize = true;
            labelInterseccion.Location = new Point(121, 205);
            labelInterseccion.Name = "labelInterseccion";
            labelInterseccion.Size = new Size(38, 15);
            labelInterseccion.TabIndex = 3;
            labelInterseccion.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}