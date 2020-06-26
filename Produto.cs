namespace AulaPOOInterface
{
    public class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Codigo { get; set; }

        public Produto () {

        }
        public Produto (int _codigo, string _nome, float _preco) {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

    
    }
}