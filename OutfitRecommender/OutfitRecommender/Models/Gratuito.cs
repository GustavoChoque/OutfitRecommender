using OutfitRecommender.Exceptions;

namespace OutfitRecommender.Models
{
    public class Gratuito : ITipoDeUsuario
    {
        private int limite = 10;
        public List<Prenda> agregarPrenda(List<Prenda> listaPrendas, Prenda unaPrenda)
        {
            if (listaPrendas.Count() < limite)
            {
                listaPrendas.Add(unaPrenda);
                return listaPrendas;
            }
            else {
                throw new LimiteListaException("No hay mas espacio para la prenda");
            
            }
        }
    }
}
