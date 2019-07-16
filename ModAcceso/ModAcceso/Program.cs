using ModAcceso.DTO;
using System;

namespace ModAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            var ejemploPublic = new EjemploPublic();
            ejemploPublic.PruebaAcceso = "funciona";


            var ejemploPrivate = new EjemploPrivate();
            ejemploPrivate.PruebaAcceso = "funciona";

            var ejemploInternal = new EjemploInternal();
            ejemploInternal.PruebaAcceso = "funciona";

            EjemploProtectedInternal ejemploProtectedInternal
                = new EjemploProtectedInternal();
            ejemploProtectedInternal.PruebaAcceso = "Funciona";

            Console.ReadKey();
        }
    }
}
