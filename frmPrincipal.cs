﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace StayAwakeApp
{
    public partial class UI : Form
    {

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        private SoundPlayer soundPlayer;

        private CancellationTokenSource cancellationTokenSource;
        Timer timer;
        public UI()
        {
            InitializeComponent();
            buttonEmpezar.Enabled = true;
            buttonCancelar.Enabled = false;
            radioButtonHoras.Checked = false;
            radioButtonMinutos.Checked = false;
            labelTiempo.Visible = false;
            timer = new Timer();
            soundPlayer = new SoundPlayer();
        }

        ClaseClick click = new ClaseClick();
        int flag = 0;
        int conttiempo = 0;
        int tiempo = 0;
        int tiempoRestante = 0;

        private async void buttonEmpezar_Click(object sender, EventArgs e)
        {
            int limit = 30;
            int mov = 1;
            int cont = 0;
            flag = 0;
            tiempo = Convert.ToInt32(numericUpDownCantidad.Value);
            if (radioButtonHoras.Checked == true)
            {
                tiempo = tiempo * 60;
            }
            if (radioButtonMinutos.Checked == true)
            {
                tiempo = tiempo * 1;
            }
            if (radioButtonMinutos.Checked == false && radioButtonHoras.Checked == false)
            {
                MessageBox.Show("Debe elegir entre Horas o Minutos", "Seleccione una opción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tiempoRestante = tiempo * 60;
            if (radioButtonHoras.Checked == true ^ radioButtonMinutos.Checked == true)
            {

                buttonEmpezar.Enabled = false;
                buttonCancelar.Enabled = true;
                numericUpDownCantidad.Enabled = false;
                labelTiempo.Visible = true;
                radioButtonHoras.Enabled = false;
                radioButtonMinutos.Enabled = false;

                if (timer == null)
                {
                    timer = new Timer();
                }
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();

                cancellationTokenSource = new CancellationTokenSource();

                try
                {
                    await Task.Run(() =>
                    {
                        do
                        {
                            if (cancellationTokenSource.Token.IsCancellationRequested)
                                return;

                            cont = 0;

                            do
                            {
                                cont++;
                                this.Invoke(new Action(() =>
                                {
                                    Cursor = new Cursor(Cursor.Current.Handle);
                                    Cursor.Position = new Point(Cursor.Position.X - mov, Cursor.Position.Y - 0);
                                }));
                                System.Threading.Thread.Sleep(500);
                                if (cancellationTokenSource.Token.IsCancellationRequested)
                                    return;
                            } while (cont != limit);
                            cont = 0;
                            do
                            {
                                cont++;
                                this.Invoke(new Action(() =>
                                {
                                    Cursor = new Cursor(Cursor.Current.Handle);
                                    Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y - mov);
                                }));
                                System.Threading.Thread.Sleep(500);
                                if (cancellationTokenSource.Token.IsCancellationRequested)
                                    return;
                            } while (cont != limit);
                            cont = 0;
                            do
                            {
                                cont++;
                                this.Invoke(new Action(() =>
                                {
                                    Cursor = new Cursor(Cursor.Current.Handle);
                                    Cursor.Position = new Point(Cursor.Position.X + mov, Cursor.Position.Y - 0);
                                }));
                                System.Threading.Thread.Sleep(500);
                                if (cancellationTokenSource.Token.IsCancellationRequested)
                                    return;
                            } while (cont != limit);
                            cont = 0;
                            do
                            {
                                cont++;
                                this.Invoke(new Action(() =>
                                {
                                    Cursor = new Cursor(Cursor.Current.Handle);
                                    Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y + mov);
                                }));
                                System.Threading.Thread.Sleep(500);
                                if (cancellationTokenSource.Token.IsCancellationRequested)
                                    return;
                            } while (cont != limit);
                            cont = 0;


                            Point point = new Point();
                            point.X = Cursor.Position.X;
                            point.Y = Cursor.Position.Y;

                            click.leftClick(point);
                            conttiempo++;

                        } while (conttiempo != tiempo);
                    });
                }
                catch (OperationCanceledException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cancellationTokenSource.Dispose();
                    cancellationTokenSource = null;
                    conttiempo = 0;
                    tiempo = 0;
                    tiempoRestante = 0;
                }
                try
                {
                    numericUpDownCantidad.Enabled = true;
                    buttonEmpezar.Enabled = true;
                    buttonCancelar.Enabled = false;
                    labelTiempo.Visible = false;
                    radioButtonHoras.Enabled = true;
                    radioButtonMinutos.Enabled = true;
                    if (timer != null)
                    {
                        timer.Stop();
                        timer.Dispose();
                        timer = null;
                    }
                    if (flag == 0)
                    {
                        string nombreProceso = "StayAwakeApp";

                        Process[] procesos = Process.GetProcessesByName(nombreProceso);

                        if (procesos.Length > 0)
                        {
                            IntPtr mainWindowHandle = procesos[0].MainWindowHandle;
                            ShowWindow(mainWindowHandle, 9);
                            SetForegroundWindow(mainWindowHandle);
                        }
                        ReproducirSonidoDeAlarma();
                        DialogResult = MessageBox.Show("Tiempo terminado!", "Despierta!", MessageBoxButtons.OK);
                        if (DialogResult == DialogResult.OK)
                        {
                            soundPlayer.Stop();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }



            }
        }
        private void ReproducirSonidoDeAlarma()
        {
            try
            {
                // Establece la ubicación del archivo de sonido de alarma
                soundPlayer.SoundLocation = @"C:\Windows\Media\Ring07.wav"; // Cambia esto a la ubicación de tu archivo de sonido

                // Reproduce el sonido de alarma
                soundPlayer.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el sonido de alarma: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            string mensaje = "1. Coloque las horas o minutos que desea que se mueva el cursor y luego click al  boton Empezar.\n\n" +
                "2. Al terminarse el tiempo aparecera la ventana al frente, saldra un mensaje de advertencia y se reproducira un sonido de alarma. Darle Aceptar para terminar.\n\n" +
                "3. Para terminar antes haga click en Cancelar.\n\n" +
                "\n\nNota: El cursor se movera formando un cuadrado pequeño y hará un click al completarlo, colocar el cursor en un sector donde el click no haga nada.";

            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
            }
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
            labelTiempo.Text = "00:00:00";
            buttonCancelar.Enabled = false;
            labelTiempo.Visible = false;
            radioButtonHoras.Enabled = true;
            radioButtonMinutos.Enabled = true;
            flag = 1;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)
            {
                string tiempoFormateado;
                tiempoRestante--;
                TimeSpan tiempo = TimeSpan.FromSeconds(tiempoRestante);
                if (tiempo.Days > 0)
                {
                    tiempoFormateado = string.Format("{0:D2}:{1:D2}:{2:D2}:{3:D2}", tiempo.Days, tiempo.Hours, tiempo.Minutes, tiempo.Seconds);
                }
                else
                {
                    tiempoFormateado = string.Format("{0:D2}:{1:D2}:{2:D2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds);
                }
                labelTiempo.Text = tiempoFormateado;
            }
            else
            {
                labelTiempo.Text = "00:00:00";
                ((Timer)sender).Stop();
            }
        }
    }
}
