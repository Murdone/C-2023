using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(80, ErrorMessage = "El campo{0} no puede tener más de {1} caractéres")]
        public string Name { get; set; } = null!;

        public ICollection<State>? States { get; set; }
        public int StatesNumber => States == null ? 0 : States.Count;
    }
}
