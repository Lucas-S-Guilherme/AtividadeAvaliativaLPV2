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
            await _context.Candidatos.AddAsync(candidato);
            await _context.SaveChangesAsync();
        }
    }
}