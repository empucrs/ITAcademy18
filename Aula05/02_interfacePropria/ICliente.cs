public interface ICliente
{

    string Nome{get;}
    DateTime? DataDaUltimaCompra {get;}
    DateTime DataDoCadastro{get;}
    IEnumerable<IPedido> PedidosAnteriores{get;}

    private static decimal desconto = 0.1m;
    private static int nPedidosParaODesconto=5;
    private static TimeSpan periodo = new TimeSpan(365,0,0,0);

    public static void AlterarConfiguracao(TimeSpan t, int nPedidos, decimal d){
        desconto=d;
        nPedidosParaODesconto=nPedidos;
        periodo=t;
    }

    protected static decimal CalculaODesconto(ICliente cliente){
        DateTime agora = DateTime.Now - periodo;
        if( (cliente.DataDoCadastro<agora) && (cliente.PedidosAnteriores.Count()>nPedidosParaODesconto) )
            return desconto;
        return 0;
    }

    public decimal CalculoDoDescontoDoCliente => CalculaODesconto(this);
    
}