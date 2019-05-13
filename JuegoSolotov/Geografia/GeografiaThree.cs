using JuegoSolotov.Sociales;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov.Geografia
{
    public partial class GeografiaThree : Form
    {
        public GeografiaThree()
        {
            //INICIE LA INTERFAZ GEOGRAFIA THREE
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
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES THREE
            var socialesthree = new SocialesThree();
            socialesthree.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES THREE
            var socialesthree = new SocialesThree();
            socialesthree.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES THREE
            var socialesthree = new SocialesThree();
            socialesthree.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ SOCIALES THREE
            var socialesthree = new SocialesThree();
            socialesthree.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void GeografiaThree_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            lblpuntosintermedio.Text = File.ReadAllText(Application.StartupPath + @"\archivo\estudianteintermedio.txt");
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsintermedio.ToString();
        }
    }
}
