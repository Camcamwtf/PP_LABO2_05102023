using System.Text.RegularExpressions;
using static Entidades.Calculadora;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        #region Propiedades
        internal override double ValorNumerico
        {
            get 
            {
                return double.Parse(Valor); 
            }
        }
        #endregion

        #region Constructores
        public SistemaBinario(string valor) : base(valor)
        {
        }
        #endregion

        #region Métodos
        /*
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return new Numeracion(valor);
            }
            else if (sistema == ESistema.Binario)
            {
                return new Numeracion(valor);
            }
            // Devolver la numeración en el sistema recibido.
        }

        
        private static SistemaDecimal BinarioADecimal()
        {
            // Verifica que el valor de la instancia no poseaa un msgError y convertir este sistema a decimal. Si no se puede, devolver minValue de un double.
        }
        */

        protected static new bool EsNumeracionValida(string valor)
        {
            if (valor != null && valor != "")
            {
                if (EsSistemaBinarioValido(valor))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool EsSistemaBinarioValido(string valor)
        {
            Regex regex = new Regex("^[01]+$");

            return regex.IsMatch(valor);
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
        #endregion
    }
}
