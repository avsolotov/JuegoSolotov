using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Media;

namespace JuegoSolotov
{
    public partial class MenuTwo : Form
    {
        
        public MenuTwo()
        {
            InitializeComponent();
         
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            Hide();
            var menuone = new MenuOne();
            menuone.Show();
        }

        private void MenuTwo_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            string tempurlpuntosprincipiante = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteprincipiante" + ".txt";
            string tempurlpuntosintermedio = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteintermedio" + ".txt";
            string tempurlpuntosavanzado = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteavanzado" + ".txt";
            lblpuntosprincipiantes.Text = File.ReadAllText(tempurlpuntosprincipiante);
            lblpuntosintermedio.Text = File.ReadAllText(tempurlpuntosintermedio);
            lblpuntosavanzado.Text = File.ReadAllText(tempurlpuntosavanzado);
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            string tempurlpuntosprincipiante = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteprincipiante" + ".txt";
            string tempurlpuntosintermedio = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteintermedio" + ".txt";
            string tempurlpuntosavanzado = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteavanzado" + ".txt";
            
            string[] lines = { "PRINCIPINTE \n", File.ReadAllText(tempurlpuntosprincipiante),"INTERMEDIO \n", File.ReadAllText(tempurlpuntosintermedio),"AVANZADO \n", File.ReadAllText(tempurlpuntosavanzado)};

            File.WriteAllLines(@"C:\Users\AUXILIAR\source\repos\JuegoSolotov\JuegoSolotov\estudiantescalificados.txt", lines);

            
        }

        private void Btnenviar_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            try
            {
                string host = "smtp.gmail.com ";
                int puerto = 587;

                MailMessage correos = new MailMessage();
                SmtpClient envios = new SmtpClient(host,puerto);

                //Datos importantes no modificables para tener acceso a las cuentas

                // envios.Host = "smtp.gmail.com";
                //envios.Port = 587;

                correos.From = new MailAddress(Globals.emisor);
                correos.To.Add(Globals.destinatario.Trim());
                System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(Globals.tempurlestudiantescalificados);
                correos.Attachments.Add(archivo);
                envios.Credentials = new NetworkCredential(Globals.emisor, Globals.password);
                envios.EnableSsl = true;
                envios.Send(correos);

                MessageBox.Show("El mensaje fue enviado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
