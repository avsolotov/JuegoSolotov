﻿using JuegoSolotov.Geografia;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov
{
    public partial class CienciaSix : Form
    {
        public CienciaSix()
        {
            //INICIE LA INTERFAZ CIENCIA SIX
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
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA FOUR
            var geografiafour = new GeografiaFour();
            geografiafour.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA FOUR
            var geografiafour = new GeografiaFour();
            geografiafour.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA FOUR
            var geografiafour = new GeografiaFour();
            geografiafour.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE AVANZADO
            Globals.pointsavanzado -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA FOUR
            var geografiafour = new GeografiaFour();
            geografiafour.Show();
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void CienciaSix_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            lblpuntosavanzado.Text = File.ReadAllText(Application.StartupPath + @"\archivo\estudianteavanzado.txt");
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsavanzado.ToString();
        }
    }
}
