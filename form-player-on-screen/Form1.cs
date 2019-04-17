using NAudio.Wave;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_player_on_screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            outputDevice = new WaveOutEvent();
            outputDevice.PlaybackStopped += OnPlaybackStopped;
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            audioFile.Position = 0;
            if (playAlarm)
            {
                PlayAlarmSound();
            }
        }

        private void btnColetarCoordenadas_Click(object sender, EventArgs e)
        {
            btnColetarCoordenadas.Enabled = false;
            StartColetarDados();
        }

        private Timer timerColetarDados;
        public void StartColetarDados()
        {
            timerColetarDados = new Timer();
            timerColetarDados.Tick += new EventHandler(timerColetarDados_Tick);
            timerColetarDados.Interval = 5000; // in miliseconds
            timerColetarDados.Start();
        }

        private Point GetCurrentPosition()
        {
            return Control.MousePosition;
        }

        private Point pixelPoint;
        private void timerColetarDados_Tick(object sender, EventArgs e)
        {
            timerColetarDados.Stop();

            pixelPoint = GetCurrentPosition();
            txtCoordenadas.Text = "X = " + pixelPoint.X + ", Y = " + pixelPoint.Y;
            btnColetarCoordenadas.Enabled = true;
        }



        static Color GetPixelColor(Point position)
        {
            using (var bitmap = new Bitmap(1, 1))
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        private bool ligado = false;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (desiredColor == null || pixelPoint == null)
            {
                MessageBox.Show("Primeiro colete os dados");
                return;
            }

            if (!ligado)
            {
                ligado = true;
                btnIniciar.Text = "Parar";
                StartValidarPixel();
            } else
            {
                stop();
            }
        }

        private void stop()
        {
            StopValidarPixel();
            ligado = false;
            btnIniciar.Text = "Iniciar";
        }

        private Timer timerValidarPixel;
        private void StartValidarPixel()
        {
            timerValidarPixel = new Timer();
            timerValidarPixel.Tick += new EventHandler(timerValidarPixel_Tick);
            timerValidarPixel.Interval = 500; // in miliseconds
            timerValidarPixel.Start();
        }

        private void StopValidarPixel()
        {
            timerValidarPixel.Stop();
            playAlarm = false;
        }

        private Color desiredColor;
        private bool playAlarm = false;
        private void timerValidarPixel_Tick(object sender, EventArgs e)
        {
            Color currentPixelColor = GetPixelColor(pixelPoint);
            playAlarm = !desiredColor.Equals(currentPixelColor);
            Console.WriteLine("playAlarm: " + playAlarm);
            if (playAlarm)
            {
                PlayAlarmSound();
            }
        }

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private void PlayAlarmSound()
        {
            if (String.IsNullOrEmpty(txtAlarmPath.Text))
            {
                stop();
                MessageBox.Show("Procure pelo arquivo primeiro");
                return;
            }

            outputDevice.Play();
        }

        private void btnProcurarAlarme_Click(object sender, EventArgs e)
        {
            if (ofdAlarmSound.ShowDialog(this) == DialogResult.OK)
            {
                txtAlarmPath.Text = ofdAlarmSound.InitialDirectory + ofdAlarmSound.FileName;

                if (outputDevice != null)
                {
                    outputDevice.Dispose();
                }
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;

                if (audioFile != null)
                {
                    audioFile.Dispose();
                }

                audioFile = new AudioFileReader(txtAlarmPath.Text);
                outputDevice.Init(audioFile);
            }
        }

        private void btnTestarSom_Click(object sender, EventArgs e)
        {
            PlayAlarmSound();
        }

        private void btnColetarCor_Click(object sender, EventArgs e)
        {
            desiredColor = GetPixelColor(pixelPoint);
            pnlColor.BackColor = desiredColor;
        }
    }
}
