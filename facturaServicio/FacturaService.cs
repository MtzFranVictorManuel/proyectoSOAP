using System.Collections.Generic;
using System.Threading.Tasks;
using FacturaDbContextNamespace;
using IFacturaServiceNamespace;
using Microsoft.EntityFrameworkCore;

namespace FacturaServiceNamespace
{
    public class FacturaService : IFacturaService
    {
        private readonly FacturaDbContext _context;

        public FacturaService(FacturaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Factura>> GetAllFacturasAsync()
        {
            return await _context.Facturas.ToListAsync();
        }

        public async Task<Factura> GetFacturaByIdAsync(int id)
        {
            return await _context.Facturas.FindAsync(id);
        }

        public async Task<Factura> CreateFacturaAsync(Factura factura)
        {
            _context.Facturas.Add(factura);
            await _context.SaveChangesAsync();
            return factura;
        }

        public async Task<Factura> UpdateFacturaAsync(Factura factura)
        {
            _context.Facturas.Update(factura);
            await _context.SaveChangesAsync();
            return factura;
        }

        public async Task<bool> DeleteFacturaAsync(int id)
        {
            var factura = await _context.Facturas.FindAsync(id);
            if (factura == null)
            {
                return false;
            }

            _context.Facturas.Remove(factura);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

