namespace AulaPOOInterface
{
    public interface ICarrinho
    {
        void AdicionarProd (Produto produto);
        void RemoverProd (Produto produto);
        void Ler ();
        void MostrarTotal ();
        void AlterarProd (int codigo, Produto _produtoNovo);
    }
}