namespace OutfitRecommender.Models
{
    public class Premium : ITipoDeUsuario
    {
        public List<Prenda> agregarPrenda(List<Prenda> listaPrendas, Prenda unaPrenda)
        {
            listaPrendas.Add(unaPrenda);
            return listaPrendas;
        }
    }
}
