﻿using JuegoSolotov.Geografia;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov
{
    public partial class CienciasOne : Form
    {
        public CienciasOne()
        {
            //INICIE LA INTERFAZ CIENCIA ONE
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
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA ONE
            var geografiaone = new GeografiaOne();
            geografiaone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA ONE
            var geografiaone = new GeografiaOne();
            geografiaone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA ONE
            var geografiaone = new GeografiaOne();
            geografiaone.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE PRINCIPIANTES
            Globals.pointsprincipiante -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA ONE
            var geografiaone = new GeografiaOne();
            geografiaone.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void CienciasOne_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            lblpuntosprincipiantes.Text = File.ReadAllText(Application.StartupPath + @"\archivo\estudianteprincipiante.txt");
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsprincipiante.ToString();
        }
    }
}
