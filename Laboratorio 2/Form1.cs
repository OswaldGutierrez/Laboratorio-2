using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Laboratorio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las ecuaciones ingresadas en los TextBox
            string ecuacion1 = textBoxFuncion1.Text;
            string ecuacion2 = textBoxFuncion2.Text;

            // Llamar a la función AnalizarRectasDesdeEcuaciones con las ecuaciones ingresadas
            string resultado = AnalizarRectasDesdeEcuaciones(ecuacion1, ecuacion2);

            // Mostrar el resultado en un MessageBox
            MessageBox.Show(resultado);
        }

        private string AnalizarRectasDesdeEcuaciones(string ecuacion1, string ecuacion2)
        {// Expresión regular para extraer la pendiente y el término independiente de una ecuación en el formato "y = mx + b",
         // permitiendo números decimales en la pendiente y el término independiente.
            string patron = @"y\s*=\s*(-?\d+(\,\d+)?)x\s*([\+\-]\s*\d+(\,\d+)?)?";


            Match match1 = Regex.Match(ecuacion1, patron);
            Match match2 = Regex.Match(ecuacion2, patron);

            if (match1.Success && match2.Success)
            {
                // Obtener las pendientes y términos independientes de las ecuaciones
                double m1 = double.Parse(match1.Groups[1].Value);
                double b1 = match1.Groups[3].Success ? double.Parse(match1.Groups[3].Value) : 0.0;

                double m2 = double.Parse(match2.Groups[1].Value);
                double b2 = match2.Groups[3].Success ? double.Parse(match2.Groups[3].Value) : 0.0;

                // Calcular el punto de intersección (si las rectas se cruzan)
                if (Math.Abs(m1 - m2) > double.Epsilon)
                {
                    double xInterseccion = (b2 - b1) / (m1 - m2);
                    double yInterseccion = m1 * xInterseccion + b1;


                    // Verificar si son perpendiculares
                    if (Math.Abs(m1 * m2 + 1.0) < double.Epsilon)
                    {
                        return $"Las rectas son perpendiculares y se cruzan en el punto ({xInterseccion}, {yInterseccion}).";
                    }

                    else
                    {
                        return $"Las rectas se cruzan en el punto ({xInterseccion}, {yInterseccion}).";
                    }

                }

                else
                {
                    return "Las rectas son paralelas";
                }


            }
            else
            {
                return "Formato de ecuación no válido. Use el formato 'y = mx + b'.";
            }
        }
    }
}