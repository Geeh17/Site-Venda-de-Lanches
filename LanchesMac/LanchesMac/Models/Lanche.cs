namespace LanchesMac.Models
{
    public class Lanches
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public string Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public string IsLanchePreferido { get; set; }
        public string EmEstoque { get; set; }
    
    }
}
