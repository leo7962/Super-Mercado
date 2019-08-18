using Super_Mercado.Data;
using Super_Mercado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Super_Mercado.Services
{
    public class Super_mercadoService : ISuper_MercadoService
    {
        private readonly Super_MercadoContext _context;

        public Super_mercadoService(Super_MercadoContext ctx)
        {
            _context = ctx;
        }

        Task<Producto> ISuper_MercadoService.Create(Producto producto)
        {
            return Task.Run(() =>
            {
                try
                {
                    _context.Productos.Add(producto);
                    _context.SaveChanges();

                    return producto;
                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Erro: {exp}");

                }

                return null;
            });
        }

        Task<Producto> ISuper_MercadoService.Delete(Producto producto)
        {
            return Task.Run(() =>
            {
                try
                {
                    _context.Productos.Remove(producto);
                    _context.SaveChanges();

                    return producto;
                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Erro: {exp}");

                }

                return null;
            });
        }

        Task<IEnumerable<Producto>> ISuper_MercadoService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Producto> ISuper_MercadoService.GetById(long Id)
        {
            return Task.Run(() =>
            {
                try
                {
                    var producto = _context.Productos.Where(ValueTask => ValueTask.Id == Id).First();
                    if (producto != null)
                    {
                        return producto;
                    }

                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Erro: {exp}");

                }

                return null;
            });
        }

        Task<Producto> ISuper_MercadoService.Update(Producto producto)
        {
            return Task.Run(() =>
            {
                try
                {
                    _context.Productos.Update(producto);
                    _context.SaveChanges();

                    return producto;
                }
                catch (Exception exp)
                {
                    Console.WriteLine($"Erro: {exp}");

                }

                return null;
            });
        }
    }
}
