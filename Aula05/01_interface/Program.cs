Pessoa p1 = new Pessoa ("Edson", 46);
Pessoa p2 = new Pessoa ("Edson", 46);
Pessoa p3 = p1;

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine("p1==p2");
Console.WriteLine("São a mesma pessoa (p1 e p2)?: "+(p1==p2));
Console.WriteLine("p1.Equals(p2)");
Console.WriteLine("São a mesma pessoa (p1 e p2)?: "+(p1.Equals(p2)));
Console.WriteLine("p1==p3");
Console.WriteLine("São a mesma pessoa (p1 e p3)?: "+(p1==p3));
Console.WriteLine("p1.Equals(p3)");
Console.WriteLine("São a mesma pessoa (p1 e p3)?: "+(p1.Equals(p3)));


Pessoa p4 = (Pessoa) p1.Clone();
Console.WriteLine(p4);
Console.WriteLine("p1==p4");
Console.WriteLine("São a mesma pessoa (p1 e p4)?: "+(p1==p4));
Console.WriteLine("p1.Equals(p4)");
Console.WriteLine("São a mesma pessoa (p1 e p4)?: "+(p1.Equals(p4)));

Console.WriteLine("hashCode -> p1: "+p1.GetHashCode());
Console.WriteLine("hashCode -> p2: "+p2.GetHashCode());
Console.WriteLine("hashCode -> p3: "+p3.GetHashCode());
Console.WriteLine("hashCode -> p4: "+p4.GetHashCode());

