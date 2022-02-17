using Api.Client.Web.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Client.Web.Data
{
    public class Repositorio : IRepositorio
    {
        private readonly DataContext context;

        public Repositorio(DataContext context)
        {
            this.context = context;
        }

        public void Adicionar<T>(T entidade) where T : class => context.Add(entidade);

        public void Atualizar<T>(T entidade) where T : class => context.Update(entidade);

        public void Excluir<T>(T entidade) where T : class => context.Remove(entidade);

        public void ExcluirVarios<T>(T[] entidade) where T : class => context.RemoveRange(entidade);

        public async Task<Cliente> BuscarCliente(int Id)
        {
            var cliente = await context.Clientes.Include(c => c.Enderecos)
                .AsNoTracking().FirstOrDefaultAsync(c => c.Id == Id);

            return cliente;
        }

        public async Task<Cliente[]> BuscarClientes(string nome)
        {
            var clientes = await context.Clientes.Include(c => c.Enderecos)
                .Where(c => c.Nome == nome).ToArrayAsync();

            return clientes;
        }

        public async Task<bool> SalvarAteracoesAssync() => await context.SaveChangesAsync() > 0;
    }
}
