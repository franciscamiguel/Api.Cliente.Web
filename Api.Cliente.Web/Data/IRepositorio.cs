using Api.Client.Web.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Client.Web.Data
{
   public interface IRepositorio 
   {
        /// <summary>
        /// Adicionar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Adicionar<T>(T entidade) where T : class;
        /// <summary>
        /// Atualizar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Atualizar<T>(T entidade) where T : class;
        /// <summary>
        /// Excluir
        /// </summary>
        /// <typeparam name="T"></typeparam>
        void Excluir<T>(T entidade) where T : class;

        /// <summary>
        /// Excluir vários objetos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entidade"></param>
        void ExcluirVarios<T>(T[] entidade) where T : class;

        Task<bool> SalvarAteracoesAssync();

        // <summary>
        /// Buscar Cliente por Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<Cliente> BuscarCliente(int Id);


        /// <summary>
        /// Buscar clientes por nomes
        /// </summary>
        /// <param name="theme"></param>
        /// <returns></returns>
        Task<Cliente[]> BuscarClientes(string nome);

    }
}
