using OutfitRecommender.Observers;

namespace OutfitRecommender.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        
        private List<Guardaropa> guardaropas;
        
        private ITipoDeUsuario tipoDeUsuario;
        
        private List<Notificacion> notificaciones;
        
        private List<SugerenciasObserver> interesados;

        private int nivelFriolencia; //0.1 muy friolento, 1.9 muy caluroso 
    }
}
