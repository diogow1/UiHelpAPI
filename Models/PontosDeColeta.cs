using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UiHelpapi.Models
{
    public class PontosDeColeta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? CNPJ { get; set; }
        public string? Nome { get; set; }

        public int Telefone { get; set; }

        public string? Email { get; set; }

        public string? Categoria { get; set; }

        public ICollection<HorarioDeFuncionamento> HorariosDeFuncionamento { get; set; } = new List<HorarioDeFuncionamento>();

    }
}