using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace Laboratorio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;
        }

        // Esta función se ejecutará cuando demos click en el botón 'Calcular' de la interfaz.
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las ecuaciones ingresadas en los TextBox
            string ecuacion1 = textBoxFuncion1.Text;
            string ecuacion2 = textBoxFuncion2.Text;

            // Llamar a la función AnalizarRectasDesdeEcuaciones con las ecuaciones ingresadas
            string resultado = analizarRectasPendienteIntercepto(ecuacion1, ecuacion2);

            // Mostrar el resultado en un MessageBox
            MessageBox.Show(resultado);
        }

        private string analizarRectasPendienteIntercepto(string ecuacion1, string ecuacion2)
        {
            /**
             * Expresión regular para extraer la pendiente y el término independiente de una ecuación en el formato "y = mx + b",
             * permitiendo números decimales en la pendiente y el término independiente
            **/

            string patron = @"y\s*=\s*(-?\d+(\,\d+)?)x\s*([\+\-]\s*\d+(\,\d+)?)?$";


            // Almacenamos el patró específico en las variables match1 y match2
            Match match1 = Regex.Match(ecuacion1, patron);
            Match match2 = Regex.Match(ecuacion2, patron);

            if (match1.Success && match2.Success)
            {

                /** Obtener las pendientes y términos independientes de las ecuaciones
                 * m1 = Pendiente de la primera ecuación
                 * m2 = Pendiente de la segunda ecuación
                 * b1 = Término independiente de la primera ecuación
                 * b2 = Término independiente de la segunda ecuación
                **/

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


        // Detalles estéticos de la Interfaz
        private void buttonCalcular_MouseHover(object sender, EventArgs e)
        {
            buttonCalcular.BackColor = Color.CadetBlue;
        }

        private void buttonCalcular_MouseLeave(object sender, EventArgs e)
        {
            buttonCalcular.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Habilitamos o inhabilitamos qué panel está activado.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                panel1.Enabled = true;
                panel2.Enabled = false;
            }
            else
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
            }
        }


        // Logica para la notación punto intercepto.

        private void buttonCalcular2_Click(object sender, EventArgs e)
        {
            string ecuacion1 = textBoxFuncion3.Text;
            string ecuacion2 = textBoxFuncion4.Text;

            // Llamar a la función para calcular el punto de intersección y verificar perpendicularidad/paralelismo
            calcularInterseccion(ecuacion1, ecuacion2);
        }

        private void calcularInterseccion(string ecuacion1, string ecuacion2)
        {
            // Analizar las ecuaciones para extraer los valores y1, m y x1
            double y1 = 0.0;
            double m = 0.0;
            double x1 = 0.0;

            // Analizar ecuacion1
            analizarEcuacion(ecuacion1, out y1, out m, out x1);

            // Analizar ecuacion2
            double y2 = 0.0;
            double m2 = 0.0;
            double x2 = 0.0;

            analizarEcuacion(ecuacion2, out y2, out m2, out x2);

            // Calcular el punto de intersección
            double interseccionX = (y2 - y1) / (m - m2);
            double interseccionY = m * interseccionX + y1;

            // Verificar si las rectas son perpendiculares o paralelas
            bool sonPerpendiculares = (m * m2 == -1);
            bool sonParalelas = (m == m2);

            // Mostrar resultados
            MessageBox.Show($"Punto de intersección: ({interseccionX}, {interseccionY})\n" +
                            $"Son perpendiculares: {sonPerpendiculares}\n" +
                            $"Son paralelas: {sonParalelas}");
        }

        private void analizarEcuacion(string ecuacion, out double y1, out double m, out double x1)
        {
            // Inicializar valores predeterminados
            y1 = 0.0;
            m = 1.0;  // Valor predeterminado positivo
            x1 = 0.0;

            // Eliminar espacios en blanco y caracteres no deseados
            ecuacion = ecuacion.Replace(" ", "").Replace("y=", "").Replace("y-", "").Replace("y+", "");

            // Separar la ecuación en sus partes
            string[] partes = ecuacion.Split('=');

            if (partes.Length == 2)
            {
                string ladoIzquierdo = partes[0];
                string ladoDerecho = partes[1];

                // Analizar el lado izquierdo de la ecuación
                if (ladoIzquierdo.Contains("x"))
                {
                    string[] izquierdoPartes = ladoIzquierdo.Split('x');
                    if (izquierdoPartes.Length == 2)
                    {
                        if (double.TryParse(izquierdoPartes[0], out y1))
                        {
                            if (izquierdoPartes[1].StartsWith("+"))
                            {
                                izquierdoPartes[1] = izquierdoPartes[1].Substring(1);
                            }
                            if (izquierdoPartes[1].StartsWith("-"))
                            {
                                izquierdoPartes[1] = "-" + izquierdoPartes[1].Substring(1);
                            }
                            if (double.TryParse(izquierdoPartes[1], out x1))
                            {
                                // Éxito al analizar el lado izquierdo
                            }
                        }
                    }
                }
                else
                {
                    if (double.TryParse(ladoIzquierdo, out y1))
                    {
                        // Éxito al analizar el lado izquierdo
                    }
                }

                // Analizar el lado derecho de la ecuación
                if (ladoDerecho.Contains("x"))
                {
                    string[] derechoPartes = ladoDerecho.Split('x');
                    if (derechoPartes.Length == 2)
                    {
                        if (double.TryParse(derechoPartes[0], out m))
                        {
                            if (derechoPartes[1].StartsWith("+"))
                            {
                                derechoPartes[1] = derechoPartes[1].Substring(1);
                            }
                            if (derechoPartes[1].StartsWith("-"))
                            {
                                derechoPartes[1] = "-" + derechoPartes[1].Substring(1);
                            }
                            if (double.TryParse(derechoPartes[1], out x1))
                            {
                                // Éxito al analizar el lado derecho
                            }
                        }
                    }
                }
                else
                {
                    if (double.TryParse(ladoDerecho, out m))
                    {
                        // Éxito al analizar el lado derecho
                    }
                }
            }
        }
    }
}