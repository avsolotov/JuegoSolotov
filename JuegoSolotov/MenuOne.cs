using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;


namespace JuegoSolotov
{
    public partial class MenuOne : Form
    {
        public MenuOne()
        {
            //INICIE LA INTERFAZ MENU ONE
            InitializeComponent();
            //LLAME Y MUESTRE ME LA INTERFAZ BACKGROUND
            var background = new Background();
            background.Show();
        }

        //BOTON JUGAR
        private void Btnjugar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ MENU THREE
            var menuthree = new MenuThree();
            menuthree.Show();
        }

        //BOTON ADMINISTRADOR
        private void Btnadministrador_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            string usuario = Interaction.InputBox("USUARIO");
            string contrasenha = Interaction.InputBox("CONTRASEÑA");
            
            if (usuario == "solotov" && contrasenha == "123")
            {
                Hide();
                //LLAME Y MUESTRE ME LA INTERFAZ MENU TWO
                var menutwo = new MenuTwo();
                menutwo.Show();
            }
            else {
                MessageBox.Show("USUARIO/CONTRASEÑA INCORRECTA");
            }
        }
        //BOTON SOLOTOVMEDIA
        private void Btnsolotovmedia_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ MENU FOUR
            var menufour = new MenuFour();
            menufour.Show();
        }
        //BOTON SALIR
        private void Btnsalir_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            Application.Exit();
        }

        private void MenuOne_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu.mp3");
            sonido.PlayLooping();
        }
    }
}
public static class Globals
{
    //VARIABLES GLOBALES PUBLICAS

    public static int points = 0;
    public static int pointsprincipiante = 0;
    public static int pointsintermedio = 0;
    public static int pointsavanzado = 0;
    public static int contador = 0;
    public static int highscoreprincipiante = 600;
    public static int highscoreintermedio = 1000;
    public static int highscoreavanzado = 1100;
    public static int contadorprincipiante = 0;
    public static int contadorintermedio = 0;
    public static int contadoravanzado = 0;

    public static string emisor = "avsolotov@gmail.com";
    public static string destinatario = "avsolotov@gmail.com";
    public static string password = "andres55123.";
    public static string tempurlestudiantescalificados = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\estudiantescalificados.txt";
    public static string tempurlpuntosintermedio = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteintermedio" + ".txt";
    public static string tempurlpuntosavanzado = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteavanzado" + ".txt";

    public static string nombre = " ";
   
}