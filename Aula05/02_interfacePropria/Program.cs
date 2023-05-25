Cliente c1 = new Cliente("Edson", new DateTime(2012,10,8));
PedidoSimples p1 = new PedidoSimples(DateTime.Now, 1.99m);
IPedido p2 = new PedidoSimples(new DateTime(2022,10,9), 10.99m);

c1.AdicionarPedidos(p1);
c1.AdicionarPedidos(p2);
c1.AdicionarPedidos(new PedidoSimples(new DateTime(2023,2,6), 1000.17m));

Console.WriteLine($"Nome:{c1.Nome};");
foreach (var item in c1.PedidosAnteriores)
{
    Console.WriteLine($"Pedido:{item};");
    Console.WriteLine($"-=-=-=-=-=-=-=\n");
}