using AppConcurso.Contexto;
using AppConcurso.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class CandidatoController : Controller
    {
        private readonly ContextoBD _context;

        public CandidatoController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Candidato>> ListaCandidatos()
        {
            return await _context.Candidatos.ToListAsync();
        }

        public async Task<Candidato> ObterPorCpf(string cpf)
        {
            return await _context.Candidatos.FirstOrDefaultAsync(c => c.Cpf == cpf);
        }

        public async Task Add(Candidato candidato)
        {
            if (candidato == null)
            {
                throw new ArgumentNullException(nameof(candidato));
            }

            // Log para depuração
            Console.WriteLine($"Dados recebidos no controller: Nome={candidato.Nome}, CPF={candidato.Cpf}, Data={candidato.DataNascimento}");
            
            try
            {
                _context.Candidatos.Add(candidato);
                await _context.SaveChangesAsync();
                Console.WriteLine("Dados salvos com sucesso no banco");
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"Erro ao salvar no banco: {ex.InnerException?.Message}");
                throw;
            }
        }
    }
}