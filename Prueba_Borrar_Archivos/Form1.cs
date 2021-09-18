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

namespace Prueba_Borrar_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            string validacion = txt_Ruta.Text;
            if (validacion != "" || validacion != " ")
            {
                int i = 0;
                int mesSiguiente = 1;
                string mesAutomatico = "";
                string path = txt_Ruta.Text;
                List<string> strDirectories = Directory.GetDirectories(path, "*", SearchOption.AllDirectories).ToList();
                DateTime fecha = DateTime.Today;
                foreach (string directorio in strDirectories)
                {
                    File.Delete(directorio);
                    i++;
                }
                MessageBox.Show("Archivos eliminados", "Completo");
                if (i == strDirectories.Count && i != 0)
                {
                    lb_NumeroDeArchivos.Text = i.ToString();
                    lb_fechaUltima.Text = fecha.ToString("dd/MM/yyyy");
                    lb_Estado.Text = "OK";
                    lb_Estado.ForeColor = Color.Green;
                    lb_SiguienteFecha.Text = fecha.AddMonths(mesSiguiente).ToString("dd/MM/yyyy");
                }
                else
                {
                    lb_Estado.Text = "NOK";
                    lb_Estado.ForeColor = Color.Red;
                    MessageBox.Show("ERROR", "Favor de ingresar una rut valida en el campo de texto");
                }
            }
            else
            {
                MessageBox.Show("ERROR","Favor de ingresar una ruta valida en el campo de texto");
            }
        }
    }
}
