using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov
{
    public partial class CienciasTwo : Form
    {
        public CienciasTwo()
        {
            //INICIE LA INTERFAZ CIENCIAS TWO
            InitializeComponent();
        }

        //BOTON CORRECTO   
        private void Btncorrecto_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante += 100;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsprincipiante >= Globals.highscoreprincipiante)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Principiantes \n" + Globals.pointsprincipiante);
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante += 1;
                string nombreprincipiantes = Interaction.InputBox("Nombre");
                string apellidoprincipiantes = Interaction.InputBox("Apellido");
                string gradoprincipiantes = Interaction.InputBox("Grado");
                string colegioprincipiantes = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO
                string[] lines = { "PUNTOS: " + Globals.pointsprincipiante.ToString(), "ESTUDIANTE:" + "\n" + nombreprincipiantes, apellidoprincipiantes, "GRADO: " + gradoprincipiantes, "COLEGIO:\n" + colegioprincipiantes };
                File.WriteAllLines(Application.StartupPath + @"\archivo\estudianteprincipiante.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante += 1;
                MessageBox.Show("Haz Completado el Nivel PRINCIPIANTE. con : " + Globals.pointsprincipiante + " Puntos ");
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
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsprincipiante >= Globals.highscoreprincipiante)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Principiantes \n" + Globals.pointsprincipiante);
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante += 1;

                string nombreprincipiantes = Interaction.InputBox("Nombre");
                string apellidoprincipiantes = Interaction.InputBox("Apellido");
                string gradoprincipiantes = Interaction.InputBox("Grado");
                string colegioprincipiantes = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO 
                string[] lines = { "PUNTOS: " + Globals.pointsprincipiante.ToString(), "ESTUDIANTE:" + "\n" + nombreprincipiantes, apellidoprincipiantes, "GRADO: " + gradoprincipiantes, "COLEGIO:\n" + colegioprincipiantes };
                File.WriteAllLines(Application.StartupPath + @"\archivo\estudianteprincipiante.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante += 1;
                MessageBox.Show("Haz Completado el Nivel PRINCIPIANTE. con : " + Globals.pointsprincipiante + " Puntos ");
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
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsprincipiante >= Globals.highscoreprincipiante)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Principiantes \n" + Globals.pointsprincipiante);
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante += 1;

                string nombreprincipiantes = Interaction.InputBox("Nombre");
                string apellidoprincipiantes = Interaction.InputBox("Apellido");
                string gradoprincipiantes = Interaction.InputBox("Grado");
                string colegioprincipiantes = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO 
                string[] lines = { "PUNTOS: " + Globals.pointsprincipiante.ToString(), "ESTUDIANTE:" + "\n" + nombreprincipiantes, apellidoprincipiantes, "GRADO: " + gradoprincipiantes, "COLEGIO:\n" + colegioprincipiantes };
                File.WriteAllLines(Application.StartupPath + @"\archivo\estudianteprincipiante.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante += 1;
                MessageBox.Show("Haz Completado el Nivel PRINCIPIANTE. con : " + Globals.pointsprincipiante + " Puntos ");
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
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - GUARDAR ESTUDIANTE
            if (Globals.pointsprincipiante >= Globals.highscoreprincipiante)
            {
                MessageBox.Show("FELICITACIONES !!" + "\n" + "Eres Digno de que Guardes tus Datos," + "\n" + "Acabas de vencer el HighScore de Principiantes \n" + Globals.pointsprincipiante);
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante = +1;

                string nombreprincipiantes = Interaction.InputBox("Nombre");
                string apellidoprincipiantes = Interaction.InputBox("Apellido");
                string gradoprincipiantes = Interaction.InputBox("Grado");
                string colegioprincipiantes = Interaction.InputBox("Colegio");
                //GUARDEME LINEA X LINEA EN ARCHIVO TXT QUE YA TENGO CREADO 
                string[] lines = { "PUNTOS: " + Globals.pointsprincipiante.ToString(), "ESTUDIANTE:" + "\n" + nombreprincipiantes, apellidoprincipiantes, "GRADO: " + gradoprincipiantes, "COLEGIO:\n" + colegioprincipiantes };
                File.WriteAllLines(Application.StartupPath + @"\archivo\estudianteprincipiante.txt", lines);
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
            //CONDICION DEL LOS PUNTOS PRINCIPIANTES - SIN GUARDAR ESTUDIANTE
            else
            {
                //CONTADOR DE PRINCIPIANTES
                Globals.contadorprincipiante += 1;
                MessageBox.Show("Haz Completado el Nivel PRINCIPIANTE. con : " + Globals.points + " Puntos ");
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var menuthree = new MenuThree();
                menuthree.Show();
            }
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void CienciasTwo_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            lblpuntosprincipiantes.Text = File.ReadAllText(Application.StartupPath + @"\archivo\estudianteprincipiante.txt");
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsprincipiante.ToString();
        }
    }
}
