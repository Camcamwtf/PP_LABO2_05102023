using System.Runtime.CompilerServices;
using static Entidades.Calculadora;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
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
        public SistemaDecimal(string valor) : base(valor)
        {
        }
        #endregion

        #region Métodos
        /*
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {

            }
            else if (sistema == ESistema.Binario)
            {

            }
            // Devolver la numeración en el sistema recibido.
        }

        
        private static SistemaBinario DecimalABinario()
        {
            // Verificar que el valor a convertir sea mayor a cero.
            // Convertir la parte entera de una numeración de tipo SistemaDecimal a SistemaBinario.
            // Si no se puede convertir, mostrar un mensaje de error.
        }
        */

        protected static new bool EsNumeracionValida(string valor)
        {
            if (valor != null && valor != "")
            {
                if (EsSistemaDecimalValido(valor))
                {
                    return true;
                }
            }  
            return false;
        }

        private static bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out _);
        }

        public static implicit operator SistemaDecimal(double valor) 
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
        #endregion
    }
}
