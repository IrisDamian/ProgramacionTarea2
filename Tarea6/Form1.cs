using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea6.Vehículo;

namespace Tarea6
{
    public partial class Carro : Form
    {
        Clsvehiculo auto;
        public Carro()
        {
            InitializeComponent();
            button1.Visible = false;
            buttonStop.Visible = false;
            buttonPau.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            label3.Visible = false;
         
        }


        private void buttonCrea_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "KIA")
            {
                auto = new Clsvehiculo("KIA", "Picanto", 2000, 200);
                auto.color = "Blanco";
                MessageBox.Show($"Su vehiculo {auto.marca} {auto.modelo} {auto.A} color {auto.color} llega a {auto.maximavel} k");
                labelC.Text = "";
                labelE.Text = "";
                labelV.Text = "";
            }
            if (comboBox1.Text == "HONDA")
            {
                auto = new Clsvehiculo("HONDA", "Civic", 2008, 180);
                auto.color = "Negro";
                MessageBox.Show($"Su vehiculo {auto.marca} {auto.modelo} {auto.A} color {auto.color} llega a {auto.maximavel} k");
                labelC.Text = "";
                labelE.Text = "";
                labelV.Text = "";
            }

            if (comboBox1.Text == "BMW")
            {
                auto = new Clsvehiculo("BMW", "X1", 2018, 220);
                auto.color = "Rojo";
                MessageBox.Show($"Su vehiculo {auto.marca} {auto.modelo} {auto.A} color {auto.color} llega a {auto.maximavel} k");
                labelC.Text = "";
                labelE.Text = "";
                labelV.Text = "";
            }
            button1.Visible = false;
            buttonStop.Visible = false;
            buttonPau.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            label3.Visible = false;
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            labelE.Text = $"El vehiculo {auto.encender()}";
            button1.Visible = true;
            buttonStop.Visible = true;
            buttonPau.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            label3.Visible = true;
        }

        private void buttonAce_Click(object sender, EventArgs e)
        {
            
                if (auto == null)
                {
                    MessageBox.Show("Primero tienes que crear un vehiculo");
                }
                else
                {
                    labelV.Text = auto.acelerar();
                }
            
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            labelV.Text = auto.stop();
        }

        private void buttonCamvel_Click(object sender, EventArgs e)
        {
            labelC.Text = auto.cambiarv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void buttonPau_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
