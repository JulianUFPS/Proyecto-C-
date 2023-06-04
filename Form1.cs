using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Programacion
{
    public partial class Form1 : Form
    {
        public class Gasolinera
        {
            public int CantidadGasolina { get; private set; }

            public Gasolinera()
            {
                CantidadGasolina = 0;
            }

            public void RecargarGasolina(int cantidad)
            {
                CantidadGasolina += cantidad;
            }

            public void QuitarGasolina(int cantidad)
            {
                CantidadGasolina -= cantidad;
            }
        }

        public class Vehiculo
        {
            public string Placa { get; set; }
            public int CantidadMaximaGasolina { get; set; }
            public int CantidadGasolina { get; set; }

            public Vehiculo(string placa, int cantidadMaximaGasolina)
            {
                Placa = placa;
                CantidadMaximaGasolina = cantidadMaximaGasolina;
                CantidadGasolina = 0;
            }

            public void RecibirGasolina(int cantidad)
            {
                if (CantidadGasolina + cantidad <= CantidadMaximaGasolina)
                {
                    CantidadGasolina += cantidad;
                }
            }
        }

        public class Carro : Vehiculo
        {
            public Carro(string placa) : base(placa, 5)
            {
            }
        }

        public class Moto : Vehiculo
        {
            public Moto(string placa) : base(placa, 3)
            {
            }
        }

        private List<Vehiculo> vehiculos;
        private Gasolinera gasolinera;

        public Form1()
        {
            InitializeComponent();
            vehiculos = new List<Vehiculo>();
            gasolinera = new Gasolinera();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRecargarVehiculo.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRecargarGasolineraClick(object sender, EventArgs e)
        {
            if (int.TryParse(txtRecargarGasolinera.Text, out int cantidad))
            {
                gasolinera.RecargarGasolina(cantidad);
                lblCantidadGasolinera.Text = (int.Parse(lblCantidadGasolinera.Text) + cantidad).ToString();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida de gasolina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void añadirFilaClick(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string tipoVehiculo = cbTipoVehiculo.SelectedItem.ToString();

            Vehiculo nuevoVehiculo;

            if (tipoVehiculo == "Carro")
            {
                nuevoVehiculo = new Carro(placa);
            }
            else if (tipoVehiculo == "Moto")
            {
                nuevoVehiculo = new Moto(placa);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de vehículo válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            vehiculos.Add(nuevoVehiculo);

            if (vehiculos.Count == 1)
            {
                lblPlaca.Text = vehiculos[0].Placa;
                lblTipoVehiculo.Text = tipoVehiculo;
            }
        }

        private void RecargarVehiculoClick(object sender, EventArgs e)
        {
            if (vehiculos.Count > 0)
            {
                Vehiculo primerVehiculo = vehiculos[0];

                if (int.TryParse(txtGalonesVehiculo.Text, out int cantidad))
                {
                    if (cantidad <= primerVehiculo.CantidadMaximaGasolina && cantidad<=gasolinera.CantidadGasolina)
                    {
                        primerVehiculo.RecibirGasolina(cantidad);
                        
                        gasolinera.QuitarGasolina(cantidad);
                        lblCantidadGasolinera.Text = (int.Parse(lblCantidadGasolinera.Text) - cantidad).ToString();

                        vehiculos.RemoveAt(0);

                        if (vehiculos.Count > 0)
                        {
                            lblPlaca.Text = vehiculos[0].Placa;
                            lblTipoVehiculo.Text = vehiculos[0] is Carro ? "Carro" : "Moto";
                        }
                        else
                        {
                            lblPlaca.Text = "";
                            lblTipoVehiculo.Text = "";
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: La cantidad de gasolina es mayor a la capacidad máxima del vehículo.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa una cantidad válida de gasolina.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlBotones1()
        {
            if (txtPlaca.Text.Trim() != string.Empty && txtPlaca.Text.All(Char.IsLetter))
            {
                btnRecargarVehiculo.Enabled = true;
                errorProvider1.SetError(txtPlaca, "");
            }
            else
            {
                if (!(txtPlaca.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtPlaca, "El nombre sólo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtPlaca, "Debe introducir su nombre");
                }
                btnRecargarVehiculo.Enabled = false;
                txtPlaca.Focus();
            }
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            controlBotones1();
        }

        private void controlBotones2()
        {
            if (txtGalonesVehiculo.Text.Trim() != string.Empty && txtGalonesVehiculo.Text.All(Char.IsDigit))
            {
                btnRecargarVehiculo.Enabled = true;
                errorProvider2.SetError(txtGalonesVehiculo, "");
            }
            else
            {
                if (!(txtGalonesVehiculo.Text.All(Char.IsDigit)))
                {
                    errorProvider2.SetError(txtGalonesVehiculo, "La cantidad de galones debe ser un numero");
                }
                else
                {
                    errorProvider2.SetError(txtGalonesVehiculo, "Debe introducir un Numero");
                }
                btnRecargarVehiculo.Enabled = false;
                txtGalonesVehiculo.Focus();
            }
        }

        private void txtGalonesVehiculo_TextChanged(object sender, EventArgs e)
        {
            controlBotones2();
        }
        
    }

    }
