using license_maker.Connection;
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
using System.Xml;

namespace license_maker
{
    public partial class LicenseMakerForm : Form
    {
        public LicenseMakerForm()
        {
            InitializeComponent();
            periodos();
        }

        string serial_licencia;
        private AES aes = new AES();

        private void btnCrearLicencia_Click(object sender, EventArgs e)
        {
            string miCarpeta = "Licencias_" + txtSoftware.Text;
            if ( txtRuta.Text != "")
            {
                serial_licencia = "|" + txtSerialPC + "|" + txtFecha_Caducidad.Text + "|" + "PENDIENDIENTE" + "|" + txtSoftware.Text + "|";
                crear_xml();
                SavetoXML(aes.Encrypt(serial_licencia, Desencryption.appPwdUnique, int.Parse("256")));
                MessageBox.Show("Licencia Creada y guardada en: " + txtRuta.Text + miCarpeta, "Creando Licencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecciona un Disco", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SavetoXML(object dbcnString)
        {
            DateTime fechaSistema = DateTime.Now;
            int dia = fechaSistema.Day;
            int mes = fechaSistema.Month;
            int año = fechaSistema.Year;

            int hora = fechaSistema.Hour;
            int minuto = fechaSistema.Minute;
            string miCarpeta = "Licencias_" + txtSoftware.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load(txtRuta.Text + miCarpeta + @"\Licencia_" + txtSoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter(txtRuta.Text + miCarpeta + @"\Licencia_" + txtSoftware.Text + "_" + dia + "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        private void crear_xml()
        {
            string miCarpeta = "Licencias_" + txtSoftware.Text;
            if ( Directory.Exists(txtRuta.Text + miCarpeta) )
            {

            } else
            {
                Directory.CreateDirectory(txtRuta.Text + miCarpeta);
            }
            DateTime fechaSistema = DateTime.Now;
            int dia = fechaSistema.Day;
            int mes = fechaSistema.Month;
            int año = fechaSistema.Year;
            int hora = fechaSistema.Hour;
            int minuto = fechaSistema.Minute; 

            string ruta = txtRuta.Text + miCarpeta + @"\Licencia_" + txtSoftware.Text + "_" + dia+ "_" + mes + "_" + año + "_" + hora + "_" + minuto + ".xml";
            FileInfo fileInfo = new FileInfo(ruta);
            StreamWriter sw;
            try
            {
                if (File.Exists(ruta) == false)
                {
                    sw = File.CreateText(ruta);
                    sw.WriteLine(XMLparte1.Text + "hola" + xmlParte2.Text);
                    sw.Flush();
                    sw.Close();
                }
                else if (File.Exists(ruta) == true)
                {
                    File.Delete(ruta);
                    sw = File.CreateText(ruta);
                    sw.WriteLine(XMLparte1.Text + "hola" + xmlParte2.Text);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void lblGuardarEn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
                string ruta = txtRuta.Text;
                if ((ruta.Contains(@"C:\")))
                {
                    MessageBox.Show("Selecciona un Disco Diferente al Disco C:", "Ruta Invalida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRuta.Text = "";
                }
                else
                {
                    txtRuta.Text = folderBrowserDialog1.SelectedPath;
                }
            }
        }

        private Random r;
        internal void periodos()
        {
            try
            {
                DateTime today = DateTime.Now;
                DateTime fechaFinal;
                int numero_periodo = Convert.ToInt32(txtNumero.Value);

                if (txtPeriodo.Text == "mes (es)")
                {
                    fechaFinal = today.AddMonths(numero_periodo);
                    txtFecha_Caducidad.Value = fechaFinal;

                }
                if (txtPeriodo.Text == "año (s)")
                {
                    fechaFinal = today.AddYears(numero_periodo);
                    txtFecha_Caducidad.Value = fechaFinal;
                }
                if (txtPeriodo.Text == "dia (s)")
                {
                    fechaFinal = today.AddDays(numero_periodo);
                    txtFecha_Caducidad.Value = fechaFinal;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNumero_ValueChanged(object sender, EventArgs e)
        {
            periodos();
        }

        private void txtSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            periodos();
        }
    }
}
