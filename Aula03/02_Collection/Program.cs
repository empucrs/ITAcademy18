using System.Collections;

ArrayList al = new ArrayList();
Console.WriteLine("Manipulação do Arraylist");
Console.WriteLine($"  Capacidade= {al.Capacity}");
Console.WriteLine($"  Count= {al.Count}");
al.Add("Edson");
Console.WriteLine($"  Capacidade= {al.Capacity}");
Console.WriteLine($"  Count= {al.Count}");
al.Add("Ifarraguirre");
Console.WriteLine($"  Capacidade= {al.Capacity}");
Console.WriteLine($"  Count= {al.Count}");
al.Add("Moreno");
Console.WriteLine($"  Capacidade= {al.Capacity}");
Console.WriteLine($"  Count= {al.Count}");
al.Add(46);
Console.WriteLine($"  Capacidade= {al.Capacity}");
Console.WriteLine($"  Count= {al.Count}");
al.Add(1.92);
Console.WriteLine($"  Capacidade= {al.Capacity}");
Console.WriteLine($"  Count= {al.Count}");

foreach (var item in al)
    Console.WriteLine($"  -> {item}");
Console.WriteLine();

//-=-=-=-=-=-=-=-=-=-

List<string> lst = new List<string>();

Console.WriteLine("Manipulação do List<string>");
Console.WriteLine($"  Capacidade= {lst.Capacity}");
Console.WriteLine($"  Capacidade= {lst.Count}");
lst.Add("Edson");
Console.WriteLine($"  Capacidade= {lst.Capacity}");
Console.WriteLine($"  Capacidade= {lst.Count}");
lst.Add("Ifarraguirre");
Console.WriteLine($"  Capacidade= {lst.Capacity}");
Console.WriteLine($"  Capacidade= {lst.Count}");
lst.Add("Moreno");
Console.WriteLine($"  Capacidade= {lst.Capacity}");
Console.WriteLine($"  Capacidade= {lst.Count}");
lst.Add(46.ToString());
Console.WriteLine($"  Capacidade= {lst.Capacity}");
Console.WriteLine($"  Capacidade= {lst.Count}");
lst.Add(1.92.ToString());
Console.WriteLine($"  Capacidade= {lst.Capacity}");
Console.WriteLine($"  Capacidade= {lst.Count}");

foreach (var item in lst)
    Console.WriteLine($"  -> {item}");
