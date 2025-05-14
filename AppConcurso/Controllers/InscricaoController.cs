using AppConcurso.Contexto;
using AppConcurso.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class InscricaoController : Controller
    {
        private readonly ContextoBD _context;

        public InscricaoController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Inscricao>> ListaInscricoes()
        {
            return await _context.Inscricoes
                .Include(x => x.Cargo)
                .Include(x => x.Candidato)
                .ToListAsync();
        }

        public async Task Add(Inscricao inscricao)
        {
            inscricao.DataInscricao = DateTime.Today;
            inscricao.NumeroInsc = GerarNumeroInscricao();
            await _context.Inscricoes.AddAsync(inscricao);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Inscricao>> ObterPorCargo(int cargoId)
        {
            return await _context.Inscricoes
                .Where(i => i.CargoIdFk == cargoId)
                .Include(i => i.Candidato)
                .ToListAsync();
        }

        public async Task LancarNotas(int inscricaoId, decimal notaGerais, decimal notaEspecificos)
        {
            var inscricao = await _context.Inscricoes.FindAsync(inscricaoId);
            if (inscricao != null)
            {
                inscricao.NotaConhGerais = notaGerais;
                inscricao.NotaConhEspecificos = notaEspecificos;
                await _context.SaveChangesAsync();
            }
        }

        private string GerarNumeroInscricao()
        {
            var count = _context.Inscricoes.Count();
            return $"{DateTime.Now.Year}{count + 1:00000}";
        }
    }
}