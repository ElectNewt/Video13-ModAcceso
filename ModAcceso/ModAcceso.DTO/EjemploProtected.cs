
namespace ModAcceso.DTO
{
    public class EjemploProtected
    {
        protected string PruebaAcceso { get; set; }
        public EjemploProtected()
        {
            PruebaAcceso = "funciona";
        }
    }
}
