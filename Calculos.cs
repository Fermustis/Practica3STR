using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Calculos : Form
    {
        double BWaudio, BWvideo,BWTotal, valor,EspacioVideo,EspacioAudio, EspacioTotal; 
        public Calculos()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void trackBarVideo_Scroll(object sender, EventArgs e)
        {
            labelTasaCompVideo.Text = trackBarVideo.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labeTasaCompAudio.Text = trackBar1.Value.ToString();
        }

        public double ValorResolucion()
        {
            
            if (cBRT.Text == "320X240")
            {
                valor= 320 * 240;
            }
            if (cBRT.Text == "640X480")
            {
                valor = 640 *480;
            }
            if (cBRT.Text == "1920X1080")
            {
                valor = 1920 *1080;
            }
            if (cBRT.Text == "2048X1080")
            {
                valor = 2048 *1080;
            }
            if (cBRT.Text == "4096*2160")
            {
                valor = 4096 * 2160;
            }
            return valor;


        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            //BWaudio = (frecuencia maxima *2)* bits*canales*(1-tasa de compresion)
            BWaudio = Convert.ToDouble(cBFM.Text)*2 * Convert.ToDouble(cBNB.Text) * Convert.ToDouble(cBNC.Text)* (1-Convert.ToDouble(trackBar1.Value)*0.01) ;
            LB1.Items.Add(BWaudio);
            //BWvideo = resolucion * profundidad de color * cuadros por segundo*tasa de compresion
            BWvideo = ValorResolucion() * Convert.ToDouble(cBPC.Text) * Convert.ToDouble(cBCS)* (1 - Convert.ToDouble(trackBarVideo.Value) * 0.01);
            LB1.Items.Add(BWaudio);

            BWTotal = BWaudio * BWvideo;
            LB1.Items.Add(BWTotal);

            //Espacio total video = ancho de banda* tiempofinal - tiempo inicial * 3600s (segundos de una hora)
            EspacioAudio = BWaudio * (Convert.ToDouble(textHF.Text)-Convert.ToDouble(textHI.Text))*60*60;
            LB1.Items.Add(EspacioAudio);
            //Espacio total de video
            EspacioVideo = BWvideo * (Convert.ToDouble(textHF.Text) - Convert.ToDouble(textHI.Text)) * 60 * 60;
            LB1.Items.Add(EspacioVideo);
            EspacioTotal = EspacioAudio + EspacioVideo;
            LB1.Items.Add(EspacioTotal);


        }
    }
}
