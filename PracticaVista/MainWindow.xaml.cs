using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaVista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Alumno> Alumnos = new List<Alumno>();

        public MainWindow()
        {
            InitializeComponent();
            Alumnos.Add(new Alumno("Juan Perez", "153697", "Lic. en Derecho"));
            Alumnos.Add(new Alumno("Pedro Lopez", "178265", "Ing. en Multimedia"));
            Alumnos.Add(new Alumno("Maria Zayas", "165279", "Ing. en Civil"));
            Alumnos.Add(new Alumno("Ana Wilson", "176532", "Lic. en Finanzas"));

            foreach(Alumno alumno in Alumnos)
            {
                lstAlumnos.Items.Add(
                    new ListBoxItem()
                    {
                        Content = alumno.Nombre
                    }
                    );
            }
        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            lblNombre.Text = Alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = Alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblNomCarrera.Text = Alumnos[lstAlumnos.SelectedIndex].Carrera;

        }
    }
}
