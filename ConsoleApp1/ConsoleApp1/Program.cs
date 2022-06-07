namespace ConsoleApp1
    {
    using System;

    /// <summary>
    /// Dada una cantidad, la desglosa en billetes de 50, 20, 10.
    /// </summary>
    public class bill
        {
        /// <summary>
        /// Declaramos los campos: número de billetes.
        /// </summary>
        private int billeteCincuenta;
        private int billeteVeinte;
        private int billeteDiez;

       /// <summary>
       /// Setters y getters
       /// </summary>
        public int BilleteDiez { get => billeteDiez; set => billeteDiez = value; }
        public int BilleteCincuenta { get => billeteCincuenta; set => billeteCincuenta = value; }
        public int BilleteVeinte { get => billeteVeinte; set => billeteVeinte = value; }

        /// <sumary> constructor vacio, inicializa los atributos</sumary>
        /// <summary>
        /// Initializes a new instance of the <see cref="bill"/> class.
        /// </summary>
        public bill()
            {
            billeteCincuenta = 0;
            BilleteVeinte = 0;
            BilleteDiez = 0;
            }


        /// <summary>
        /// este método permite cambiar la cantidad total y recalcular.
        /// </summary>
        /// <param name="cantidad"> cantidad que vamos a ingresar .</param>
        public void EstablecerCantidad(int cantidad)
            {
          
            const int dividirPor10 = 10;
            const int dividirPor20 = 20;
            const int dividirPor50 = 50;


            if ((cantidad % dividirPor10) != 0)
                throw new ArgumentOutOfRangeException();

            if ((cantidad >= dividirPor50))
                {
                billeteCincuenta = (cantidad / 50);
                cantidad = cantidad - (billeteCincuenta * 50);
                }
            if ((cantidad >= dividirPor20))
                {
                BilleteVeinte = (cantidad / 20);
                cantidad = cantidad - (BilleteVeinte * 20);
                }
            if ((cantidad >= 10))
                {
                BilleteDiez = (cantidad / 10);
                cantidad = cantidad - (BilleteDiez * 10);
                }
            }
        }

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal class Program
        {
        /// <summary>
        /// <para>El siguiente programa calcula la cantidad necesaria de billetes de cada tipo para una cantidad dada.</para>
        ///<para>Sólo admite billetes de 50, 20 y 10. Si no es así, se produce una excepción</para>.
        /// </summary>
        /// <param name="args">The args<see cref="string[]"/>.</param>
        internal static void Main(string[] args)
            {
            int cantidad;
            bill billetes = new bill();

            string linea;
            Console.Write("Introduzca una cantidad: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            try
                {
                billetes.EstablecerCantidad(cantidad);
                Console.WriteLine("BILLETES DE 50 : " + billetes.BilleteCincuenta);
                Console.WriteLine("BILLETES DE 20 : " + billetes.BilleteVeinte);
                Console.WriteLine("BILLETES DE 10 : " + billetes.BilleteDiez);
                }
            catch
                {
                Console.WriteLine("Cantidad no válida.");
                }

            Console.Write("Pulse una Tecla."); Console.ReadLine();
            }
        }
    }
