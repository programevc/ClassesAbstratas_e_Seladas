namespace ClassesAbstratasESeladas.Sealed
{
    public sealed class ProdutoRequest
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }
    }
}
