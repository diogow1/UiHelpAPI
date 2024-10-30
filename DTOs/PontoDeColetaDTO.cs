using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UiHelpapi.Models;

namespace UiHelpapi.DTOs
{
    public class PontoDeColetaDTO
    {
        public string? CNPJ { get; set; }
        public string? Nome { get; set; }
        public int Telefone { get; set; }
        public string? Email { get; set; }
        public string? Categoria { get; set; }
        public List<HorarioDeFuncionamentoDTO>? HorariosDeFuncionamento { get; set; }
    }

}