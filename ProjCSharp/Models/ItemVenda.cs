namespace SalSystem.Models
{
    internal class ItemVenda
    {
        public int Id { get; set; }
        public string NameProd { get; set; }
        public int IdProdVenda { get; set; }
        public int Quantidade { get; set; }
        public double Preco {  get; set; }

        public ItemVenda (int id, int idProdVenda, int quantidade, double preco)
        {
            Id = id;
            IdProdVenda = idProdVenda;
            Quantidade = quantidade;
            Preco = preco;
        }


        public bool CadastrarProduto()
        {
            try
            {

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }


           
        }






    }
}
