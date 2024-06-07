using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NebulaCars.Data;
using NebulaCars.Models;
using Microsoft.EntityFrameworkCore;

namespace NebulaCars.Service
{
    public class PostVentasService
    {
        private readonly ILogger<ProductoService> _logger;
        private readonly ApplicationDbContext _context;

        public PostVentasService(ILogger<ProductoService  > logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<List<AgendarCitas>?> GetAllAgendarCitas(){
            if(_context.DataCita == null )
                return null;
            return await _context.DataCita.ToListAsync();
        }
    }
}