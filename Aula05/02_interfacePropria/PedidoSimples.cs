public class PedidoSimples : IPedido
{
    public decimal Valor{get;}
    public DateTime DataDaCompra {get;}

    public PedidoSimples(DateTime d, decimal v){
        DataDaCompra=d;
        Valor=v;
    }
    public override string ToString()
    {
        return $"[valor:{Valor}; dataDaCompra:{DataDaCompra.ToShortDateString()}]";
    }
}