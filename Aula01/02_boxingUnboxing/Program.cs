int i = 123;
Console.WriteLine(i);
object O;
//Console.WriteLine(O);
O=i;
Console.WriteLine(O);
string S;
//Console.WriteLine(S);
S=O!.ToString();
Console.WriteLine(S);
int x;
//Console.WriteLine(x);
x= (int) O;
Console.WriteLine(x);

object u;
u=O;
Console.WriteLine(u);

O=321;
Console.WriteLine(O);
Console.WriteLine(u);

u=null;
Console.WriteLine(u);
S=null;
Console.WriteLine(S);
int? c;
c=null;
Console.WriteLine(c);

//-=-=-=-=-=-
Console.WriteLine("Inicialização sem nulable");
string first="";
string second = string.Empty;
int third=0;
DateTime dt = new();

Console.WriteLine("inicializações");
Console.WriteLine(first);
Console.WriteLine(second);
Console.WriteLine(third);
Console.WriteLine(dt);
dt = DateTime.MinValue;
Console.WriteLine(dt);

//-=-=-=-=-=-
Console.WriteLine("Inicialização COM nulable");
int? nfirst = null;
int? nsecond = null;
int? nthird = default;
int? nfourth = new();

Console.WriteLine(nfirst);
Console.WriteLine(nsecond);
Console.WriteLine(nthird);
Console.WriteLine(nfourth);

