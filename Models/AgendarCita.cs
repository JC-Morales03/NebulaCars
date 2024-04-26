using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace NebulaCars.Models
{
   [Table("t_Citas")]
    public class AgendarCitas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]       
         public int? Id { get; set; }
        [NotNull]
                     
        public string? Nombre { get; set; }
        [NotNull]

        public string? Email { get; set; }
        [NotNull]
        public string? Telefono { get; set; }
        [NotNull]
    
        public string? Ciudad { get; set; }
        [NotNull]
     
        public string? TipoDocumento { get; set; }
         [NotNull]
        public string? NumeroDocumento { get; set; }
         [NotNull]
     
        public string? Marca { get; set; }
        [NotNull]

        public string? Modelo { get; set; }
        [NotNull]
    
        public int Kilometraje { get; set; }
         [NotNull]
        public string? Placa { get; set; }
    
        public string? Mensaje { get; set; }
        [NotNull]

        [DataType(DataType.Date)]
        public DateTime FechaCita { get; set; }

     
        [DataType(DataType.Time)]
        public DateTime HoraCita { get; set; }

    }
}