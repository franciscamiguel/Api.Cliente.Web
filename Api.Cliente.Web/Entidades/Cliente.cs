using System.Collections.Generic;


namespace Api.Client.Web.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }

        public List<Endereco> Enderecos { get; set; }
    }
}
