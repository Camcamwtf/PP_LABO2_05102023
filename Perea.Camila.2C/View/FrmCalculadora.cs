using Entidades;
using System.Diagnostics;
using static Entidades.Calculadora;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        #region Atributos
        private Calculadora calculadora;
        #endregion

        #region Constructor
        public FrmCalculadora()
        {
            InitializeComponent();
            this.calculadora = new Calculadora("Nombre y Apellido");
        }
        #endregion

        #region Métodos
        private void btnCerrar_Click(object sender, EventArgs evento)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs evento)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }

        private void btnOperar_Click(object sender, EventArgs evento)
        {
            char operador;
            calculadora.PrimerOperando = this.GetOperando(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando = this.GetOperando(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado: {calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }
        #endregion

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private Numeracion GetOperando(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }

        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource = this.calculadora.Operaciones;
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e) => Calculadora.Sistema = ESistema.Binario;

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e) => Calculadora.Sistema = ESistema.Decimal;

        private void txtPrimerOperando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtSegundoOperando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}