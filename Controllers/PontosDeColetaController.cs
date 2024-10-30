using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UiHelpapi.Context;
using UiHelpapi.DTOs;
using UiHelpapi.Models;

namespace UiHelpapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PontosDeColetaController : ControllerBase
    {
        private readonly DatabaseContexto _context;

        public PontosDeColetaController(DatabaseContexto context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PontoDeColetaDTO pontoDeColetaDTO)
        {
            if (pontoDeColetaDTO == null)
            {
                return BadRequest("Ponto de coleta não pode ser nulo.");
            }

            var pontosDeColeta = new PontosDeColeta
            {
                CNPJ = pontoDeColetaDTO.CNPJ,
                Nome = pontoDeColetaDTO.Nome,
                Telefone = pontoDeColetaDTO.Telefone,
                Email = pontoDeColetaDTO.Email,
                Categoria = pontoDeColetaDTO.Categoria,
                HorariosDeFuncionamento = new List<HorarioDeFuncionamento>()
            };

            if (pontoDeColetaDTO.HorariosDeFuncionamento == null) return (IActionResult)Results.Ok(pontoDeColetaDTO);

            foreach (var horario in pontoDeColetaDTO.HorariosDeFuncionamento)
            {
                if (!Enum.IsDefined(typeof(Enums.DiaSemana), horario.DiaSemana))
                {
                    return BadRequest("O dia da semana é inválido.");
                }
                var horarioDeFuncionamento = new HorarioDeFuncionamento
                {
                    DiaSemana = horario.DiaSemana.ToString(),
                    Horario1 = horario.Horario1,
                    Horario2 = horario.Horario2,
                    PontosDeColeta = pontosDeColeta 
                };

                pontosDeColeta.HorariosDeFuncionamento.Add(horarioDeFuncionamento);
            }

            _context.Add(pontosDeColeta);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Post), new { id = pontosDeColeta.Id }, pontosDeColeta);
        }


        [HttpGet]
        public IActionResult Get()
        {
            var pontosDeColeta = _context.PontosDeColeta
                .Include(p => p.HorariosDeFuncionamento)
                .ToList();

            if (!pontosDeColeta.Any())
            {
                return NotFound("Nenhum ponto de coleta encontrado.");
            }

            return Ok(pontosDeColeta);
        }
    }
    
}