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


            Materia historia = new Materia("HST123", "Historia");
            Materia matematicas = new Materia("MAT456", "Matematicas");
            Materia civismo = new Materia("CIV789", "Civismo");
            Materia espanol = new Materia("ESP147", "Español");
            Materia artistica = new Materia("ART258", "Artística");


            Alumnos.Add(new Alumno("Juan Perez", "153697", "Lic. en Derecho"));
            Alumnos.Add(new Alumno("Pedro Lopez", "178265", "Ing. en Multimedia"));                 
            Alumnos.Add(new Alumno("Maria Zayas", "165279", "Ing. en Civil"));
            Alumnos.Add(new Alumno("Ana Wilson", "176532", "Lic. en Finanzas"));

            //Primer Alumno
            Alumnos[0].Materias.Add(espanol);
            Alumnos[0].Materias.Add(artistica);
            //Segundo
            Alumnos[1].Materias.Add(civismo);
            Alumnos[1].Materias.Add(matematicas);
            //Tercero
            Alumnos[2].Materias.Add(historia);
            Alumnos[2].Materias.Add(espanol);
            //Cuarto
            Alumnos[3].Materias.Add(civismo);
            Alumnos[3].Materias.Add(artistica);

            foreach (Alumno alumno in Alumnos)
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

            lstMaterias.Items.Clear();

            foreach(Materia materia in Alumnos[lstAlumnos.SelectedIndex].Materias)
            {
                lstMaterias.Items.Add(new ListBoxItem()
                {
                    Content = materia.Nombre
                });
            }

        }

        private void lstMaterias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstMaterias.SelectedIndex != -1)
            {
                lblClave.Text = Alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Clave;
                lblMateria.Text = Alumnos[lstAlumnos.SelectedIndex].Materias[lstMaterias.SelectedIndex].Nombre;
            }else
            {
                lblMateria.Text = "";
                lblClave.Text = "";
            }
        }
    }
}
