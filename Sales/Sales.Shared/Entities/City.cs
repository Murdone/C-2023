using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sales.Shared.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "Cuidad")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        [MaxLength(80, ErrorMessage = "El campo{0} no puede tener más de {1} caractéres")]
        public string Name { get; set; } = null!;
        public int StateId { get; set; }
        public State? State { get; set; }
    }
}
