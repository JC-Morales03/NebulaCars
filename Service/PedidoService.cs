using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using NebulaCars.Data;
using NebulaCars.Models;

namespace NebulaCars.Service
{
    public class PedidoService
    {
        private readonly ILogger<PedidoService> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public PedidoService (ILogger<PedidoService> logger,
        UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public async Task<List<Pedido?>> Mostrar()
        {
            var pedidos = from o in _context.DataPedido select o;
            List<Pedido> listapedido = await pedidos.Where(s => s.Status.Contains("PENDIENTE")).ToListAsync();
            return listapedido;
        }

        public async Task<List<Pedido?>> MostrarCliente(string userIDSession)
        {
            var pedidos = from o in _context.DataPedido select o;
            List<Pedido> listapedido = await pedidos.Where(w => w.UserID.Equals(userIDSession)).ToListAsync();
            return listapedido;
        }

        public List<DetallePedido> ObtenerDetallesPedido(int pedidoId)
        {
            return _context.DataDetallePedido
                .Include(detalle => detalle.Producto)
                .Include(detalle => detalle.pedido)  // Incluye la propiedad de navegación pedido
                .Where(detalle => detalle.pedido != null && detalle.pedido.ID == pedidoId)
                .ToList();
        }


        public async Task<List<Pedido?>> Get(string? userID)
        {
            if (userID == null || _context.DataPedido == null)
            {
                return null;
            }

            var pedidosUsuario = await _context.DataPedido
                .Where(p => p.UserID == userID)
                .ToListAsync();

            return pedidosUsuario;
        }
    }
}