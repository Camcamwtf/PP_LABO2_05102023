using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        public enum ESistema { Binario, Decimal }

        #region Atributos
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;
        #endregion

        #region Propiedades
        public string NombreAlumno { get { return this.nombreAlumno; } set { } }
        public List<string> Operaciones { get {  return this.operaciones; } }
        public Numeracion PrimerOperando {  get { return this.primerOperando; } set { } }
        public Numeracion SegundoOperando {  get { return this.segundoOperando; } set { } }
        public Numeracion Resultado { get { return this.resultado; } }
        public static ESistema Sistema { get { return sistema; } set { } }
        #endregion

        #region Constructores
        private Calculadora()
        {
            this.nombreAlumno = NombreAlumno;
            this.operaciones = Operaciones;
            this.primerOperando = PrimerOperando;
            this.segundoOperando = SegundoOperando;
            this.resultado = Resultado;
            sistema = ESistema.Decimal;
        }

        public Calculadora(string nombreAlumno)
        {
            this.nombreAlumno = nombreAlumno;
            this.operaciones = Operaciones;
            this.primerOperando = PrimerOperando;
            this.segundoOperando = SegundoOperando;
            this.resultado = Resultado;
            sistema = ESistema.Decimal;
        }
        #endregion

        #region Métodos
        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Sistema: {sistema} - Primer Operando: {this.primerOperando} - Segundo Operando: {this.segundoOperando} - Operador: {operador}");
        }

        public void Calcular()
        {

        }

        public void Calcular(char operador)
        {

        }

        public void EliminarHistorialDeOperaciones()
        {
            
        }

        /*
        private static Numeracion MapeaResultado(double valor)
        {
            //
        }
        */
        #endregion
    }
}
