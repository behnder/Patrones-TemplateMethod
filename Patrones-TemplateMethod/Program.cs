using System;

namespace Patrones_TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ROGUE COMPANY-GENERADOR DE PERSONAJES\n\n\n");

            Mack mack = new Mack();
            mack.Nombre = "MACK";
            Scorch scorch = new Scorch();
            scorch.Nombre = "SCORCH";

            mack.GenerarAgente();
            mack.RecibirDanio(14);
            mack.Atacar();
            Console.WriteLine("==========");
            scorch.GenerarAgente();
            scorch.RecibirDanio(84);
            scorch.Atacar();



            Console.ReadKey();

        }
    }
}
