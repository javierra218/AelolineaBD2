using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using System.Data.OracleClient;
using Aerolinea.logica;

namespace Aerolinea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Avion avion = new Avion();
        Empresa emp = new Empresa();

        private void button1_Click(object sender, EventArgs e)
        {
           /* OracleConnection ora_conn = new OracleConnection(@"Data Source=LOCALHOST;User ID=aerolinea;Password=aerolinea");
            ora_conn.Open();
            MessageBox.Show("conectado");*/
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Hace Falta llenar el campo.");
            }
            else
            {
                //capturar en una variable lo escrito en la caja de texto
                int cod = int.Parse(txtBuscar.Text);

                DataSet dt = new DataSet();
                dt = avion.CONSULTARAVIONES(cod);
                dgvAviones.DataSource = dt;
                dgvAviones.DataMember = "Aviones";

            }




        }

        private void btnGuardarEmpresa_Click(object sender, EventArgs e)
        {
            

            if (txtNIT.Text == "" && txtNombre.Text=="")
            {
                MessageBox.Show("Hace Falta llenar el campo.");
            }
            else
            {
                int nitEmpresa = int.Parse(txtNIT.Text);
                string nombreEmpresa = (txtNombre.Text);
                string fechaEmpresa = (dtFecha.Text);

                if (emp.insertarEmpresa(nitEmpresa, nombreEmpresa, fechaEmpresa))
                {
                    MessageBox.Show("Registro Exitoso.");
                    txtNIT.ResetText();
                    txtNombre.ResetText();
                }
                else
                {
                    MessageBox.Show("Error en el Registro.");
                }


            }


        }

        private void btnGuardarAvion_Click(object sender, EventArgs e)
        {

            if (txtSerialAvion.Text == "" && txtIDAerolinea.Text == "" && txtAvionMarca.Text =="" && txtLongitudAvion.Text=="" && txtEnsamblePais.Text=="")
            {
                MessageBox.Show("Hace Falta llenar el campo.");
            }
            else
            {
                string serialAvion = (txtSerialAvion.Text);
                int nitEmpresa = int.Parse(txtIDAerolinea.Text);
                string marcaAvion = (txtAvionMarca.Text);
                string tipoAvion = (cbxTipoAvion.SelectedItem.ToString());
                float longitudAvion = float.Parse(txtLongitudAvion.Text);
                string paisEnsamble = (txtEnsamblePais.Text);
                string fechaEnsamble = (dtpFechaEnsamble.Text);

                if (avion.insertarAvion(nitEmpresa,serialAvion,marcaAvion,tipoAvion,longitudAvion, paisEnsamble, fechaEnsamble))
                {
                    MessageBox.Show("Registro Exitoso.");
                    
                    txtSerialAvion.ResetText();
                    txtIDAerolinea.ResetText();
                    txtAvionMarca.ResetText();
                    cbxTipoAvion.ResetText();
                    txtLongitudAvion.ResetText();
                    txtEnsamblePais.ResetText();
                    dtpFechaEnsamble.ResetText();

                }
                else
                {
                    MessageBox.Show("Error en el Registro.");
                }
                
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIDAerolinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text=="")
            {
                MessageBox.Show("Hace Falta llenar el campo.");
            }
            else
            {
          
                string serialAvion = (txtEliminar.Text);

                if (avion.eliminarAvion(serialAvion))
                {
                    MessageBox.Show("Eliminado con Exito.");
                    txtEliminar.ResetText();
                    
                }
                else
                {
                    MessageBox.Show("Error al Eliminar.");
                }

            }

        }
    }
}
