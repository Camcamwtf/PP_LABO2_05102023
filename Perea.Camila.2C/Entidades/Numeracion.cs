using System.Runtime.CompilerServices;
using static Entidades.Calculadora;

namespace Entidades
{
    public abstract class Numeracion
    {
        #region Atributos
        protected string valor;
        protected static string msgError;
        #endregion

        #region Propiedades
        public string Valor { get; }
        internal abstract double ValorNumerico { get; }
        #endregion

        #region Constructores
        static Numeracion()
        {
            msgError = "Número inválido";
        }

        protected Numeracion(string valor) => InicializarValor(valor);
        #endregion

        #region Métodos
        //public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected bool EsNumeracionValida(string valor)
        {
            if (valor != null && valor != "")
            {
                return true;
            }
            return false;
        }

        private void InicializarValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                valor = Valor;
            }
            else
            {
                valor = msgError;
            }
            
        }

        public static explicit operator double(Numeracion numeracion) { return numeracion.ValorNumerico; }
        public static bool operator !=(Numeracion n1, Numeracion n2) { return false;  }
        public static bool operator ==(Numeracion n1, Numeracion n2) 
        { 
            if (n1.GetType() == n2.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
