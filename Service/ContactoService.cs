using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NebulaCars.Data;
using NebulaCars.Models;
using Microsoft.EntityFrameworkCore;

namespace NebulaCars.Service
{
    public class ContactoService
    {
        private readonly ILogger<ProductoService> _logger;
        private readonly ApplicationDbContext _context;

        public ContactoService(ILogger<ProductoService  > logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<List<Contacto>?> GetAllContactos(){
            if(_context.DataProducto == null )
                return null;
            return await _context.DataContacto.ToListAsync();
        }
    }
}