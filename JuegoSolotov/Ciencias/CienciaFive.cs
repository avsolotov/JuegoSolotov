using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov.Ciencias
{
    public partial class CienciaFive : Form
    {
        public CienciaFive()
        {
            //INICIE LA INTERFAZ CIENCIAS FIVE
            InitializeComponent();
        }

        //BOTON CORRECTO 
        private void Btncorrecto_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsintermedio += 100;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsintermedio >= Globals.highscoreintermedio)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsintermedio);
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio += 1;
                string nombreintermedio = Interaction.InputBox("Nombre");
                string apellidointermedio = Interaction.InputBox("Apellido");
                string gradointermedio = Interaction.InputBox("Grado");
                string colegiointermedio = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsintermedio.ToString(), "ESTUDIANTE:" + "\n" + nombreintermedio, apellidointermedio, "GRADO: " + gradointermedio, "COLEGIO:\n" + colegiointermedio };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteintermedio.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsintermedio + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        //BOTON INCORRECTO 
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsintermedio >= Globals.highscoreintermedio)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsintermedio);
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio += 1;
                string nombreintermedio = Interaction.InputBox("Nombre");
                string apellidointermedio = Interaction.InputBox("Apellido");
                string gradointermedio = Interaction.InputBox("Grado");
                string colegiointermedio = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsintermedio.ToString(), "ESTUDIANTE:" + "\n" + nombreintermedio, apellidointermedio, "GRADO: " + gradointermedio, "COLEGIO:\n" + colegiointermedio };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteintermedio.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsintermedio + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        //BOTON INCORRECTO 
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsintermedio >= Globals.highscoreintermedio)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsintermedio);
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio += 1;
                string nombreintermedio = Interaction.InputBox("Nombre");
                string apellidointermedio = Interaction.InputBox("Apellido");
                string gradointermedio = Interaction.InputBox("Grado");
                string colegiointermedio = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsintermedio.ToString(), "ESTUDIANTE:" + "\n" + nombreintermedio, apellidointermedio, "GRADO: " + gradointermedio, "COLEGIO:\n" + colegiointermedio };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteintermedio.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsintermedio + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        //BOTON INCORRECTO 
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsintermedio >= Globals.highscoreintermedio)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Intermedio \n" + Globals.pointsintermedio);
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio +=1;
                string nombreintermedio = Interaction.InputBox("Nombre");
                string apellidointermedio = Interaction.InputBox("Apellido");
                string gradointermedio = Interaction.InputBox("Grado");
                string colegiointermedio = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsintermedio.ToString(), "ESTUDIANTE:" + "\n" + nombreintermedio, apellidointermedio, "GRADO: " + gradointermedio, "COLEGIO:\n" + colegiointermedio };
                File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudianteintermedio.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE INTERMEDIO
                Globals.contadorintermedio += 1;
                MessageBox.Show("Haz Completado el Nivel INTERMEDIO. con : " + Globals.pointsintermedio + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void CienciaFive_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            string tempurlpuntosintermedio = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteintermedio" + ".txt";
            lblpuntosintermedio.Text = File.ReadAllText(tempurlpuntosintermedio);
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsintermedio.ToString();
        }
    }
}
