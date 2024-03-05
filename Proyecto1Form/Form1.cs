using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto1Form.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Proyecto1Form
{
    public partial class Form1 : Form
    {
        private Lista lista;
        public Form1()
        {
            InitializeComponent();
            lista = new Lista(); // Inicializa la lista
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Insertar al Frente");
            comboBox1.Items.Add("Insertar al Final");
            comboBox1.Items.Add("Insertar en Posición");
            comboBox1.Items.Add("Insertar Ascendente");
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Insertar en Posición")
            {
                label1.Visible = true; // Mostrar etiqueta para indicar la posición
                textBox2.Visible = true; // Mostrar TextBox para ingresar la posición
            }
            else
            {
                label1.Visible = false; // Ocultar etiqueta
                textBox2.Visible = false; // Ocultar TextBox
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            string opcion = comboBox1.SelectedItem.ToString();
            int dato;
            if (!int.TryParse(textBox1.Text, out dato))
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
                return;
            }

            switch (opcion)
            {
                case "Insertar al Frente":
                    lista.Insertar(dato);
                    break;
                case "Insertar al Final":
                    lista.InsertarF(dato);
                    break;
                case "Insertar en Posición":
                    int posicion;
                    if (!int.TryParse(textBox2.Text, out posicion))
                    {
                        MessageBox.Show("Ingrese una posición numérica válida.");
                        return;
                    }
                    lista.InsertarEnPosicion(dato, posicion);
                    break;
                case "Insertar Ascendente":
                    int valorAscendente;
                    if (!int.TryParse(textBox1.Text, out valorAscendente))
                    {
                        MessageBox.Show("Ingrese un valor numérico válido.");
                        return;
                    }
                    lista.InsertarAscendente(valorAscendente);
                    break;
                default:
                    MessageBox.Show("Seleccione una acción válida.");
                    return;
            }

            ActualizarListBox();
        }

        private void ActualizarListBox()
        {
            listBox1.Items.Clear();
            foreach (int dato in lista.ObtenerDatos())
            {
                listBox1.Items.Add(dato);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int datoSeleccionado = (int)listBox1.SelectedItem;
                lista.EliminarDato(datoSeleccionado);
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento de la lista para eliminar.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
