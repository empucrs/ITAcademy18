public class Cliente : ICliente
{
    public string Nome {get;}
    public DateTime? DataDaUltimaCompra {get; private set;}
    public DateTime DataDoCadastro {get;}
    public IEnumerable<IPedido> PedidosAnteriores {
        get{
            return ListaDePedidos;
        }
    } 
    private List<IPedido> ListaDePedidos = new List<IPedido>();

    public Cliente(string n, DateTime d){
        Nome=n;
        DataDoCadastro=d;
    }
    public void AdicionarPedidos(IPedido p){
        ListaDePedidos.Add(p);
        if((DataDaUltimaCompra ?? DateTime.MinValue) < p.DataDaCompra)
            DataDaUltimaCompra=p.DataDaCompra;
    }
}