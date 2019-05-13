using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov.Sociales
{
    public partial class SocialesFour : Form
    {
        public SocialesFour()
        {
            //INICIE LA INTERFAZ SOCIALES FOUR
            InitializeComponent();
        }

        //BOTON CORRECTO
        private void Btncorrecto_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado += 100;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ MATEMATICAS SEVEN
            var matematicasseven = new MatematicasSeven();
            matematicasseven.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            Hide();
            ///LLAME Y MUESTRE ME LA INTERFAZ MATEMATICAS SEVEN
            var matematicasseven = new MatematicasSeven();
            matematicasseven.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ MATEMATICAS SEVEN
            var matematicasseven = new MatematicasSeven();
            matematicasseven.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ MATEMATICAS SEVEN
            var matematicasseven = new MatematicasSeven();
            matematicasseven.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void SocialesFour_Load(object sender, EventArgs e)
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
