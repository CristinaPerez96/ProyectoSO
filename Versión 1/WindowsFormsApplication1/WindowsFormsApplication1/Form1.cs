using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Para evitar problemas de Threads cruzados

        }

        //Función para atender las respuestas del servidor
        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos la respuesta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje= trozos[1].Split('\0')[0];

                switch (codigo)
                {
                    case 1: //Registra un usuario
                        MessageBox.Show(mensaje);
                        break;

                    case 2: //Inicia sesión
                        MessageBox.Show(mensaje);
                        break;

                    case 3: //Nombre del jugador que ganó en menor tiempo
                        MessageBox.Show(mensaje);
                        break;

                    case 4: //Menor tiempo en ganar del usuario
                        MessageBox.Show(mensaje);
                        break;

                    case 5: //Partidas ganadas por el usuario
                        MessageBox.Show(mensaje);
                        break;

                    case 6: //Lista conectados
                        int i = 0;
                        int n;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        int trozo = Int32.Parse(trozos[1]);
                        if (mensaje == "0")
                        {
                            MessageBox.Show("No hay conectados");
                        }
                        else
                        {
                            while (i < trozo - 1)
                            {
                                n = dataGridView1.Rows.Add();
                                i++;
                            }
                        }
                        for (i = 0; i < trozo; i++)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = trozos[i+2];
                        }
                        break;

                    case 7: //Servicios realizados
                        Cont.Text = mensaje;
                        break;
                }
            }
        }



        

        //Botón de registro de usuario
        private void Registro_Click(object sender, EventArgs e)
        {

            // Quiere realizar un registro en la BBDD
            string mensaje = "1/" + user.Text + "/" + contraseña.Text;
            // Enviamos al servidor el user tecleado y la contraseña
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

        }

        //Botón de inicio de sesión
        private void Sesion_Click(object sender, EventArgs e)
        {
            // Quiere realizar un inicio de sesión
            string mensaje = "2/" + user.Text + "/" + contraseña.Text;
            // Enviamos al servidor el user tecleado y la contraseña
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

        }

        //Desconectamos del servidor
        private void Desconectar_Click(object sender, EventArgs e)
        {

            // Se terminó el servicio. 
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9070);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
            }


            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //Pongo en marcha el thread que atenderá los mensajes del servidor
            ThreadStart ts = delegate{ AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();
        }

        //Consulta el nombre del jugador que ganó en menor tiempo
        private void radioButton1_Click(object sender, EventArgs e)
        {
            // Quiere realizar la consulta escogida
            string mensaje = "3/";
            // Enviamos al servidor el user tecleado 
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        //Consulta el mejor tiempo en el que ganó el usuario indicado en el user.TextBox
        private void radioButton2_Click(object sender, EventArgs e)
        {
            // Quiere realizar la consulta escogida
            string mensaje = "4/" + user.Text;
            // Enviamos al servidor el user tecleado 
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        //Consulta el número de partidas jugadas por el usuario indicado en el user.TextBox
        private void radioButton3_Click(object sender, EventArgs e)
        {
            // Quiere realizar la consulta escogida
            string mensaje = "5/" + user.Text;
            // Enviamos al servidor el user tecleado 
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Conectados_Click(object sender, EventArgs e)
        {
            // Quiere realizar la consulta escogida
            string mensaje = "6/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }
    }
}
