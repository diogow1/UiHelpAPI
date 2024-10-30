using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UiHelpapi.Enums;

namespace UiHelpapi.DTOs
{
    public class HorarioDeFuncionamentoDTO
    {
        public DiaSemana DiaSemana { get; set; }
        public TimeSpan Horario1 { get; set; }
    
        public TimeSpan Horario2 { get; set; }
    }
}