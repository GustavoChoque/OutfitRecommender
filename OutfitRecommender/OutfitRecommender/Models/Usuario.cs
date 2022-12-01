using OutfitRecommender.Observers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OutfitRecommender.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        
        //private List<Guardaropa> guardaropas;

        private List<Prenda> prendas;
        
        private ITipoDeUsuario tipoDeUsuario;
        
        private List<Notificacion> notificaciones;
        
        private List<SugerenciasObserver> interesados;

        private int nivelFriolencia; //0.1 muy friolento, 1.9 muy caluroso 
    }
}
