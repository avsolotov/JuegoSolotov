using JuegoSolotov.Sociales;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov.Geografia
{
    public partial class GeografiaOne : Form
    {
        public GeografiaOne()
        {
            //INICIE LA INTERFAZ GEOGRAFIA ONE
            InitializeComponent();
        }

        //BOTON CORRECTO
        private void Btncorrecto_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante += 100;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES ONE
            var socialesone = new SocialesOne();
            socialesone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES ONE
            var socialesone = new SocialesOne();
            socialesone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES ONE
            var socialesone = new SocialesOne();
            socialesone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES ONE
            var socialesone = new SocialesOne();
            socialesone.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void GeografiaOne_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            lblpuntosprincipiantes.Text = File.ReadAllText(Application.StartupPath + @"\archivo\estudianteprincipiante.txt");
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsprincipiante.ToString();
        }
    }
}
