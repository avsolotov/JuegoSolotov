using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov.Sociales
{
    public partial class SocialesSeven : Form
    {
        public SocialesSeven()
        {
            InitializeComponent();
        }

        private void Btncorrecto_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado += 100;
            //CONDICION DEL LOS PUNTOS AVANZADO - GUARDAR ESTUDIANTE
            if (Globals.pointsavanzado >= Globals.highscoreavanzado)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsavanzado);
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                string nombreavanzado = Interaction.InputBox("Nombre");
                string apellidoavanzado = Interaction.InputBox("Apellido");
                string gradoavanzado = Interaction.InputBox("Grado");
                string colegioavanzado = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsintermedio.ToString(), "ESTUDIANTE:" + "\n" + nombreavanzado, apellidoavanzado, "GRADO: " + gradoavanzado, "COLEGIO:\n" + colegioavanzado };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteavanzado.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS AVANZADO - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsavanzado + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            //CONDICION DEL LOS PUNTOS AVANZADO - GUARDAR ESTUDIANTE
            if (Globals.pointsavanzado >= Globals.highscoreavanzado)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsavanzado);
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                string nombreavanzado = Interaction.InputBox("Nombre");
                string apellidoavanzado = Interaction.InputBox("Apellido");
                string gradoavanzado = Interaction.InputBox("Grado");
                string colegioavanzado = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsavanzado.ToString(), "ESTUDIANTE:" + "\n" + nombreavanzado, apellidoavanzado, "GRADO: " + gradoavanzado, "COLEGIO:\n" + colegioavanzado };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteavanzado.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS AVANZADO - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsavanzado + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            //CONDICION DEL LOS PUNTOS AVANZADO - GUARDAR ESTUDIANTE
            if (Globals.pointsavanzado >= Globals.highscoreavanzado)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsavanzado);
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                string nombreavanzado = Interaction.InputBox("Nombre");
                string apellidoavanzado = Interaction.InputBox("Apellido");
                string gradoavanzado = Interaction.InputBox("Grado");
                string colegioavanzado = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsavanzado.ToString(), "ESTUDIANTE:" + "\n" + nombreavanzado, apellidoavanzado, "GRADO: " + gradoavanzado, "COLEGIO:\n" + colegioavanzado };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteavanzado.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS AVANZADO - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsavanzado + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            //CONDICION DEL LOS PUNTOS AVANZADO - GUARDAR ESTUDIANTE
            if (Globals.pointsavanzado >= Globals.highscoreavanzado)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsavanzado);
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                string nombreavanzado = Interaction.InputBox("Nombre");
                string apellidoavanzado = Interaction.InputBox("Apellido");
                string gradoavanzado = Interaction.InputBox("Grado");
                string colegioavanzado = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsavanzado.ToString(), "ESTUDIANTE:" + "\n" + nombreavanzado, apellidoavanzado, "GRADO: " + gradoavanzado, "COLEGIO:\n" + colegioavanzado };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteavanzado.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS AVANZADO - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE AVANZADO
                Globals.contadoravanzado += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsavanzado + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        private void SocialesSeven_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            string tempurlpuntosavanzado = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteavanzado" + ".txt";
            lblpuntosavanzado.Text = File.ReadAllText(tempurlpuntosavanzado);
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsavanzado.ToString();
        }
    }
}
