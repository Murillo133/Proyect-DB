using BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FormReportes : Form
    {
        private ReporteBOL bol;
        private Form parent;
        public FormReportes()
        {
            InitializeComponent();
            CenterToScreen();
            bol = new ReporteBOL();
            Personas();
            EducationType();

        }
        public FormReportes(Form parent, int[] cantidades, bool comanda)
        {
            InitializeComponent();
            CenterToScreen();
            this.parent = parent;
            Personas();
        }

        public FormReportes(Form parent, LinkedList<object[]> tours)
        {
            InitializeComponent();
            CenterToScreen();
            this.parent = parent;
            EducationType();


        }


        public FormReportes(Form parent, int[] cantidades)
        {
            InitializeComponent();
            CenterToScreen();
            this.parent = parent;
           
            CantidadDeExtranjerosNacionales(cantidades);


        }



        private void Personas()
        {

       
            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Clear();
            chart1.Series["R"].Points.Clear();
            chart1.Titles.Add(new Title("OCCUPATION_TYPE", Docking.Top,
            new Font("Arial Rounded MT Bold", 10f, FontStyle.Bold), Color.Black));

        
            int[] puntos = bol.porcentajeOcupacion();
            string[] series = bol.Ocupacion();
            string[] XPointMember = new string[puntos.Length];
            int[] YPointMember = new int[puntos.Length];
            string[] label = new string[puntos.Length];
            for (int count = 0; count < series.Length; count++)
            {
             
                XPointMember[count] = series[count];
                label[count] = puntos[count].ToString();
                YPointMember[count] = puntos[count];
            }

            chart1.BackColor = Color.White;
            chart1.Series[0].Font = new Font("Arial Rounded MT", 8f, FontStyle.Bold);
            chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);
            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LegendText = "#VALX(#PERCENT{P0})\n";// escribir el porcentaje a la par del nombre.. si agrego columna lo comento
            chart1.Series[0]["PieLabelStyle"] = "Outside";// escribir el número catidad afuera del grafico
            chart1.Series[0].BorderWidth = 1;// ancho de la pata que muestra el número
            chart1.Series[0].LabelBackColor = Color.White;// color del fondo del cuadro que rodea el número
            //chart1.Series[0].LabelBorderColor = Color.Black;//color del borde del cuadro que rodea el número
            chart1.Series[0].LabelForeColor = Color.Black;//color del número 
            chart1.Series[0].BorderColor = Color.Black;//color del Borde del gráfico 
            //areas

            //Tipo de gráfico  
            chart1.Series[0].ChartType = SeriesChartType.Doughnut;
        
        }
      
      

        private void EducationType()
        {

            chart2.Palette = ChartColorPalette.Pastel;
            chart2.Titles.Clear();
            chart2.Series["R"].Points.Clear();
            chart2.Titles.Add(new Title("EDUCATION TYPE OF THE CLIENT", Docking.Top,
            new Font("Arial Rounded MT Bold", 10f, FontStyle.Bold), Color.Black));


            int[] puntos = bol.porcentajeOcupacion();
            string[] series = bol.Ocupacion();
            string[] XPointMember = new string[puntos.Length];
            int[] YPointMember = new int[puntos.Length];
            string[] label = new string[puntos.Length];
            for (int count = 0; count < series.Length; count++)
            {

                XPointMember[count] = series[count];
                label[count] = puntos[count].ToString();
                YPointMember[count] = puntos[count];
            }

            chart2.BackColor = Color.White;
            chart2.Series[0].Font = new Font("Arial Rounded MT", 8f, FontStyle.Bold);
            chart2.Series[0].Points.DataBindXY(XPointMember, YPointMember);
            chart2.Series[0].IsValueShownAsLabel = true;
            //chart2.Series[0].LegendText = "#VALX(#PERCENT{P0})\n";// escribir el porcentaje a la par del nombre.. si agrego columna lo comento
            chart2.Series[0]["PieLabelStyle"] = "Outside";// escribir el número catidad afuera del grafico
            chart2.Series[0].BorderWidth = 1;// ancho de la pata que muestra el número
            chart2.Series[0].LabelBackColor = Color.White;// color del fondo del cuadro que rodea el número
            chart2.Series[0].LabelBorderColor = Color.Black;//color del borde del cuadro que rodea el número
            chart2.Series[0].LabelForeColor = Color.Black;//color del número 
            chart2.Series[0].BorderColor = Color.Black;//color del Borde del gráfico 
            //areas

            //Tipo de gráfico  
            chart2.Series[0].ChartType = SeriesChartType.Bar;
        }

        public void CantidadDeExtranjerosNacionales(int[] cant)
        {
            chart1.Titles.Clear();
            chart1.Series["R"].Points.Clear();
            chart1.Titles.Add(new Title("Cantidad de Tours adquiridos en el mes seleccionado.", Docking.Top,
            new Font("Arial Rounded MT Bold", 18f, FontStyle.Bold), Color.Black));
            string[] series = {
                "Por Extranjeros.",
                "Por Nacionales."};
            int[] puntos = cant; // OBTENER EN UNA SOLA CONSULTA DE LA BASE DE DATOS
            string[] XPointMember = new string[puntos.Length];
            int[] YPointMember = new int[puntos.Length];
            string[] label = new string[puntos.Length];
            for (int count = 0; count < series.Length; count++)
            {
                //storing Values for X axis  
                XPointMember[count] = series[count];
                //storing values for Y Axis  
                label[count] = puntos[count].ToString();
                YPointMember[count] = puntos[count];
            }

            // Controles del chart  
            chart1.BackColor = Color.White;
            chart1.Series[0].Font = new Font("Arial Rounded MT", 12f, FontStyle.Bold);//fuente del numero
            chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);
            chart1.Series[0].IsValueShownAsLabel = true;// mostrar el número sobre el gráfico
            //chart1.Series[0].LegendText = "#VALX(#PERCENT{P0})\n";// escribir el porcentaje a la par del nombre.. si agrego columna lo comento
            chart1.Series[0]["PieLabelStyle"] = "Outside";// escribir el número catidad afuera del grafico
            chart1.Series[0].BorderWidth = 1;// ancho de la pata que muestra el número
            chart1.Series[0].LabelBackColor = Color.Aqua;// color del fondo del cuadro que rodea el número
            chart1.Series[0].LabelBorderColor = Color.Black;//color del borde del cuadro que rodea el número
            chart1.Series[0].LabelForeColor = Color.Black;//color del número 
            chart1.Series[0].BorderColor = Color.Black;//color del Borde del gráfico 
            //areas

            //Tipo de gráfico  
            chart1.Series[0].ChartType = SeriesChartType.Doughnut;
            chart1.Palette = ChartColorPalette.Bright;

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
          
        }



        private void FormReportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Salir();
        }
        private void Salir()
        {
            if (parent != null)
            {

                this.Hide();
                parent.Show();
            }
        }
    }
}
