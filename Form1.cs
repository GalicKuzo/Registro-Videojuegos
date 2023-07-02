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
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            lbl_puntos.Text = Convert.ToString(score);
            if (txt_nombre.Text.Trim() == "" || cmbox_resultado.SelectedItem == null)
            {
                MessageBox.Show("Debe llenar los espacios en blanco antes de continuar :)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int n = dgv_Datos.Rows.Add();
            dgv_Datos.Rows[n].Cells[0].Value = Convert.ToString(txt_nombre.Text).ToUpper();
            dgv_Datos.Rows[n].Cells[1].Value = Convert.ToString(cmbox_resultado.Text).ToUpper();
            if (cmbox_resultado.Text == "Victoria")
            {
                dgv_Datos.Rows[n].Cells[2].Value = "100";
                score = score + 100;
                lbl_puntos.Text = Convert.ToString(score);
            }
            if (cmbox_resultado.Text == "Derrota")
            {
                dgv_Datos.Rows[n].Cells[2].Value = "-20";
                score = score - 20;
                lbl_puntos.Text = Convert.ToString(score);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Creacion del archivo
            string rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "base_de_informacion.txt");
            FileStream crear = new FileStream(rutaArchivo, FileMode.Create);
            crear.Close();
            //Escritura del archivo
            FileStream escribir = new FileStream(rutaArchivo, FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("hola");
            escribir.Write(bdata, 0, bdata.Length);
            escribir.Close();

            MessageBox.Show("Todos los datos fueron guardados en la siguiente ruta: " + rutaArchivo, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
