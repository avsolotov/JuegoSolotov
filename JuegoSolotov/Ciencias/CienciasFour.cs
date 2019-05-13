using JuegoSolotov.Geografia;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov
{
    public partial class CienciasFour : Form
    {
        public CienciasFour()
        {
            //INICIE LA INTERFAZ CIENCIA FOUR
            InitializeComponent();
        }

        //BOTON CORRECTO
        private void Btncorrecto_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio += 100;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA THREE
            var geografiathree = new GeografiaThree();
            geografiathree.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA THREE
            var geografiathree = new GeografiaThree();
            geografiathree.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA THREE
            var geografiathree = new GeografiaThree();
            geografiathree.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA THREE
            var geografiathree = new GeografiaThree();
            geografiathree.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void CienciasFour_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            lblpuntosintermedio.Text = File.ReadAllText(Application.StartupPath + @"\archivo\estudianteintermedio.txt");
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsintermedio.ToString();
        }
    }
}
