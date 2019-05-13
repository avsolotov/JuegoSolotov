using System;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace JuegoSolotov
{
    public partial class MatematicasOne : Form
    {
        public MatematicasOne()
        {
            //INICIE LA INTERFAZ MATEMATICAS ONE
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
            //LLAME Y MUESTRE ME LA INTERFAZ CIENCIA ONE
            var cienciasone = new CienciasOne();
            cienciasone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ CIENCIA ONE
            var cienciasone = new CienciasOne();
            cienciasone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ CIENCIA ONE
            var cienciasone = new CienciasOne();
            cienciasone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ CIENCIA ONE
            var cienciasone = new CienciasOne();
            cienciasone.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void MatematicasOne_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            lblpuntosprincipiantes.Text = File.ReadAllText(Application.StartupPath + @"\archivo\estudianteprincipiante.txt");
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsprincipiante.ToString();
        }
    }
}
