using AppConcurso.Contexto;
using AppConcurso.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppConcurso.Controllers
{
    public class CargoController : Controller
    {
        private readonly ContextoBD _context;

        public CargoController(ContextoBD context)
        {
            _context = context;
        }

        public async Task<List<Cargo>> ListaCargos()
        {
            var cargo = await _context.Cargos.Include(x => x.Inscricoes).ToListAsync();
            return cargo;
        }
    }
}