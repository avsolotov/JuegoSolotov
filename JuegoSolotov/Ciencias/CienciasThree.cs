﻿using JuegoSolotov.Geografia;
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace JuegoSolotov
{
    public partial class CienciasThree : Form
    {
        public CienciasThree()
        {
            //INICIE LA INTERFAZ CIENCIAS THREE
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
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA TWO
            var geografiatwo = new GeografiaTwo();
            geografiatwo.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto1_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA TWO
            var geografiatwo = new GeografiaTwo();
            geografiatwo.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto2_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA TWO
            var geografiatwo = new GeografiaTwo();
            geografiatwo.Show();
        }

        //BOTON INCORRECTO
        private void Btnincorrecto3_Click(object sender, EventArgs e)
        {
            SoundPlayer sonido3 = new SoundPlayer(Application.StartupPath + @"\sound\boton_sonidoN.mp3");
            sonido3.Play();
            //CONTADOR DE PUNTOS DE INTERMEDIO
            Globals.pointsintermedio -= 5;
            Hide();
            //LLAME Y MUESTRE ME LA INTERFAZ GEOGRAFIA TWO
            var geografiatwo = new GeografiaTwo();
            geografiatwo.Show(); ;
        }

        //CARGAR Y LLENAR VALORES EN FORM - LEER ARCHIVOS TXT
        private void CienciasThree_Load(object sender, EventArgs e)
        {
            SoundPlayer sonido = new SoundPlayer(Application.StartupPath + @"\sound\sonido_Menu3.mp3");
            sonido.PlayLooping();
            string tempurlpuntosintermedio = "C:\\Users\\AUXILIAR\\source\\repos\\JuegoSolotov\\JuegoSolotov\\" + "estudianteintermedio" + ".txt";
            lblpuntosintermedio.Text = File.ReadAllText(tempurlpuntosintermedio);
            lblnombre.Text = Globals.nombre;
            lblpuntos.Text = Globals.pointsintermedio.ToString();
        }
    }
}
