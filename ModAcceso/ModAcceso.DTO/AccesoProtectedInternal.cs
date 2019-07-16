using System;
using System.Collections.Generic;
using System.Text;

namespace ModAcceso.DTO
{
    public class AccesoProtectedInternal
    {
        public void Acceso()
        {
            EjemploProtectedInternal ejemploProtectedInternal 
                = new EjemploProtectedInternal();
            ejemploProtectedInternal.PruebaAcceso = "Funciona";
        }
    }
}
