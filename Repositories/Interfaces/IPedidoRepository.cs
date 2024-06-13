using Lanches_Online.Models;

namespace Lanches_Online.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
