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
            return await _context.Cargos.ToListAsync();
        }

        public async Task<Cargo> ObterPorId(int id)
        {
            return await _context.Cargos.FindAsync(id);
        }

        public async Task Add(Cargo cargo)
        {
            await _context.Cargos.AddAsync(cargo);
            await _context.SaveChangesAsync();
        }
    }
}