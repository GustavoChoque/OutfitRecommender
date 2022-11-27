using OutfitRecommender.Models;

namespace OutfitRecommender.Observers
{
    public abstract class SugerenciasObserver
    {
        private int id;

        public abstract void notificarSugerenciasNuevas(Usuario usuario, Evento evento); 
    }
}
