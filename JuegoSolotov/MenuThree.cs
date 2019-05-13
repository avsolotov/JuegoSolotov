using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Media;

namespace JuegoSolotov
{
    public partial class MenuThree : Form
    {

        public MenuThree()
        {
            //INICIE LA INTERFAZ MENU THREE
            InitializeComponent();
        }

        //BOTON PRINCIPIANTE
        private void Btnprincipiante_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONDICION DEL CONTADOR - BLOQUEO DE BOTON
            if (Globals.contadorprincipiante > Globals.contador ) {
                MessageBox.Show("Ya completas te este Nivel");
            }
            else
            {
                Hide();
                Globals.nombre = Interaction.InputBox("NICKNAME");
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var matematicasone = new MatematicasOne();
                matematicasone.Show();
            }
        }

        //BOTON INTERMEDIO
        private void Btnintermedio_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONDICION DEL CONTADOR - BLOQUEO DE BOTON
            if (Globals.contadorintermedio > Globals.contador)
            {
                MessageBox.Show("Ya completas te este Nivel");
            }
            else
            {
                Hide();
                Globals.nombre = Interaction.InputBox("NICKNAME");
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var matematicasthree = new MatematicasThree();
                matematicasthree.Show();
            }
        }

        //BOTON AVANZADO
        private void Btnavanzado_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONDICION DEL CONTADOR - BLOQUEO DE BOTON
            if (Globals.contadoravanzado > Globals.contador)
            {
                MessageBox.Show("Ya completas te este Nivel");
            }
            else
            {
                Hide();
                Globals.nombre = Interaction.InputBox("NICKNAME");
                //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
                var matematicassix = new MatematicasSix();
                matematicassix.Show();
            }
        }

        //BOTON SALIR
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //COLOCAR TODO EN 0 PARA JUGAR OTRAVEZ
            Globals.contadorprincipiante = 0;
            Globals.contadorintermedio = 0;
            Globals.contadoravanzado = 0;
            Globals.pointsprincipiante = 0;
            Globals.pointsintermedio = 0;
            Globals.pointsavanzado = 0;

            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ MENU ONE
            var menuone = new MenuOne();
            menuone.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void MenuThree_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu.mp3");
            sonido.PlayLooping();
            string tempurlpuntosprincipiante = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteprincipiante" + ".txt";
            string tempurlpuntosintermedio = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteintermedio" + ".txt";
            string tempurlpuntosavanzado = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteavanzado" + ".txt";
            lblpuntosprincipiantes.Text = File.ReadAllText(tempurlpuntosprincipiante);
            lblpuntosintermedio.Text = File.ReadAllText(tempurlpuntosintermedio);
            lblpuntosavanzado.Text = File.ReadAllText(tempurlpuntosavanzado);
        }
    }
}
