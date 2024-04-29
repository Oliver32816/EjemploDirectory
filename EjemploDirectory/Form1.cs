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
namespace EjemploDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("Temporal");
            //Para generar la carpeta en una ruta en especifico
            //Se utiliza "@" ubicación 
            if (!Directory.Exists("Temporal"))
            {
                DirectoryInfo dir = new DirectoryInfo("Temporal");
                dir.Create();
                MessageBox.Show("Se creo la carpeta");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.Move("Temporal", @"C:\Temporal");
            MessageBox.Show("Se movio la carpeta");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"C:\Temporal");
            MessageBox.Show("Se elimino  la carpeta");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DirectoryInfo Dir = new DirectoryInfo("Temporal");
            string Propiedades = Dir.LastAccessTime.ToString();
            MessageBox.Show(Propiedades);
        }
    }
}
