using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using UiHelpapi.Enums;

namespace UiHelpapi.Models
{
    public class HorarioDeFuncionamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? DiaSemana { get; set; }

        [Required]
        public TimeSpan Horario1 { get; set; }

        [Required]
        public TimeSpan Horario2 { get; set; }

        [ForeignKey("PontosDeColeta")]
        public int PontosDeColetaId { get; set; }

        [JsonIgnore]
        public PontosDeColeta? PontosDeColeta { get; set; }
    }
}