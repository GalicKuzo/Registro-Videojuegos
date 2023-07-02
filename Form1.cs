using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Registro_Videojuegos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_puntos.Text = "0";
        }
        int score = 0;
        //Funcion para registrar los juegos
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            lbl_puntos.Text = Convert.ToString(score);
            if (txt_nombre.Text.Trim() == "" || cmbox_resultado.SelectedItem == null)
            {
                MessageBox.Show("Debe llenar los espacios en blanco antes de continuar :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            rtxtbox_datos.AppendText("\n");
            rtxtbox_datos.AppendText("Nombre: " + txt_nombre.Text + "\n");
            rtxtbox_datos.AppendText("Resultado: " + cmbox_resultado.Text + "\n");
            if (cmbox_resultado.Text == "Victoria")
            {
                rtxtbox_datos.AppendText("Puntos Obtenidos: 100" + "\n");
                score = score + 100;
                lbl_puntos.Text = Convert.ToString(score);
            }
            if (cmbox_resultado.Text == "Derrota")
            {
                rtxtbox_datos.AppendText("Puntos Obtenidos: -20" + "\n");
                score = score - 20;
                lbl_puntos.Text = Convert.ToString(score);
            }
            txt_nombre.Text = "";
        }
        //Funcion para crear el archivo .txt en el escritorio y guardar los datos
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Creacion del archivo
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "base_de_informacion.txt");
            FileStream crear = new FileStream(rutaArchivo, FileMode.Create);
            crear.Close();
            //Escritura del archivo
            FileStream escribir = new FileStream(rutaArchivo, FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes(rtxtbox_datos.Text);
            byte[] bdata1 = Encoding.Default.GetBytes("\n"+ "Puntos Acumulados: " + score);
            escribir.Write(bdata, 0, bdata.Length);
            escribir.Write(bdata1, 0, bdata1.Length);
            escribir.Close();

            MessageBox.Show("Todos los datos fueron guardados en la siguiente ruta: " + rutaArchivo, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
