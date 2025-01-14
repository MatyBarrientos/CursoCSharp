namespace funciones;

class Program
{

    static void Main(string[] args)
    {
        int prueba = devolverUno();
        Console.WriteLine(prueba);

        bool bandera = true;
        int solucion = 0;

        solucion = bandera == false ? 32 : 10;

        Console.WriteLine(solucion);

    }

    static int devolverUno()
    {
        int nro = 10;
        return nro;
    }
}
