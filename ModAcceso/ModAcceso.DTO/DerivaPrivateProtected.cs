using System;
using System.Collections.Generic;
using System.Text;

namespace ModAcceso.DTO
{
    public class DerivaPrivateProtected : EjemploPrivateProtected
    {
        public DerivaPrivateProtected()
        {
            PruebaAcceso = "Funciona";
        }
    }
}
