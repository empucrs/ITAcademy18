List<Pessoa> lp = new List<Pessoa>();

Pessoa p = new Pessoa("Edson", 46);
lp.Add(p);
Console.WriteLine("Detalhes de uma pessoa");
Console.WriteLine($"  Nome:  {p.nome}");
Console.WriteLine($"  Idade: {p.idade}");
Console.WriteLine($"  Ano de Nascimento: {p.anoDeNascimento}");

p=new Pessoa();
lp.Add(p);
Console.WriteLine("Detalhes de uma pessoa");
Console.WriteLine($"  Nome:  {p.nome}");
Console.WriteLine($"  Idade: {p.idade}");
Console.WriteLine($"  Ano de Nascimento: {p.anoDeNascimento}");

Funcionario f = new Funcionario();
lp.Add(f);
Console.WriteLine("Detalhes de um funcionario");
Console.WriteLine($"  Nome:  {f.nome}");
Console.WriteLine($"  Idade: {f.idade}");
Console.WriteLine($"  Ano de Nascimento: {f.anoDeNascimento}");
Console.WriteLine($"  Salário: {f.salario}");

f = new Funcionario("Eduardo Amaral", 22);
lp.Add(f);
Console.WriteLine("Detalhes de um funcionario");
Console.WriteLine($"  Nome:  {f.nome}");
Console.WriteLine($"  Idade: {f.idade}");
Console.WriteLine($"  Ano de Nascimento: {f.anoDeNascimento}");
Console.WriteLine($"  Salário: {f.salario}");

f = new Funcionario("Natalya Goelzer", 21, 4500.23m);
lp.Add(f);
Console.WriteLine("Detalhes de um funcionario");
Console.WriteLine($"  Nome:  {f.nome}");
Console.WriteLine($"  Idade: {f.idade}");
Console.WriteLine($"  Ano de Nascimento: {f.anoDeNascimento}");
Console.WriteLine($"  Salário: {f.salario}");


Console.WriteLine("-=-==-=-=-=-=-=-=-=");
lp.ForEach(Console.WriteLine);

p.tahComFome();
f.tahComFome();

p.conteAteTres();
f.conteAteTres();

//p.conteAteDois();
//f.conteAteDois();

Console.WriteLine("-=-==-=-=-=-=-=-=-=");

object algo = new Object();
Console.WriteLine(algo);
Console.WriteLine("-=-==-=-=-=-=-=-=-= PESSOA");
algo=p;
Console.WriteLine(algo);
Console.WriteLine("é pessoa? "+(algo is Pessoa));
Console.WriteLine("é Funcinoario? "+(algo is Funcionario));
if(algo is Pessoa) ((Pessoa)algo).tahComFome();
if(algo is Pessoa) (algo as Pessoa)!.tahComFome();

if(algo is Funcionario) ((Funcionario)algo).tahComFome();
if(algo is Funcionario) (algo as Funcionario)!.tahComFome();
Console.WriteLine("-=-==-=-=-=-=-=-=-= FUNCIONARIO");
algo=f;
Console.WriteLine(algo);
Console.WriteLine("é pessoa? "+(algo is Pessoa));
Console.WriteLine("é Funcinoario? "+(algo is Funcionario));
if(algo is Pessoa) ((Pessoa)algo).tahComFome();
if(algo is Pessoa) (algo as Pessoa)!.tahComFome();

if(algo is Funcionario) ((Funcionario)algo).tahComFome();
if(algo is Funcionario) (algo as Funcionario)!.tahComFome();

