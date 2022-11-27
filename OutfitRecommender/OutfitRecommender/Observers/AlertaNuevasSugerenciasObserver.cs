using OutfitRecommender.Models;

namespace OutfitRecommender.Observers
{
    public class AlertaNuevasSugerenciasObserver : SugerenciasObserver
    {
        public override void notificarSugerenciasNuevas(Usuario usuario, Evento evento)
        {
            Console.WriteLine("Se envio mail con =>: Hola nombreUsuario estan las sugerencias para el evento nombreEvento, son estas ListaDeSugerencias");
        }
    }
}
