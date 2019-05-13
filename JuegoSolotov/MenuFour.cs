using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoSolotov
{
    public partial class MenuFour : Form
    {
        public MenuFour()
        {
            InitializeComponent();
        }

        private void Btnmasinfo_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //LINK PAGINAWEB
            Process.Start("https://avsolotov.wixsite.com/solotovmedia");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //LINK CUESTIONARIO
            Process.Start("https://drive.google.com/open?id=1JAJ8OmZz9zT7vpZZMysPSqQk8Mv55Upd");
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //LLAME Y MUESTRE ME LA INTERFAZ MENU ONE
            var menuone = new MenuOne();
            menuone.Show();
        }

        private void MenuFour_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
        }
    }
}
