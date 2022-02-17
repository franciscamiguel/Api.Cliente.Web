namespace Api.Client.Web.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        public string Numero  { get; set; }
        public string Bairro  { get; set; }
        public string Cidade  { get; set; }
        public string UF  { get; set; }
        public string CEP  { get; set; }

        public int ClienteId  { get; set; }
        public Cliente Cliente { get; set; }

    }
}
