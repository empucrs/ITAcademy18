List<Pessoa> pessoas = new List<Pessoa> 
{ 
    new Pessoa{Nome="Ana", DataDeNascimento=new DateTime(1980,3,14), Casada=true}, 
    new Pessoa{Nome="Maria", DataDeNascimento=new DateTime(2000,1,10), Casada=false}, 
    new Pessoa{Nome="Paulo", DataDeNascimento=new DateTime(1978,10,23), Casada=true}, 
    new Pessoa{Nome="Carlos", DataDeNascimento=new DateTime(1999,12,12), Casada=false} 
};

var listaDeCasados = from p in pessoas 
                     where p.Casada
                     select p;

Console.WriteLine("-=-=-=-=-=-=-=-");
foreach (var item in pessoas)
    Console.WriteLine(item);
Console.WriteLine("-=-=-=-=-=-=-=-");
foreach (var item in listaDeCasados)
    Console.WriteLine(item);

// RESULTADOS EQUIVALENTES
// QUERY SINTAX
var outraLista = from p in pessoas 
                     where p.Casada && p.DataDeNascimento > new DateTime(1980,1,1)
                     select p;
//METHOD SYNTAX
var listaSimilar = pessoas.Where(p => p.Casada && (p.DataDeNascimento > new DateTime(1980,1,1)));


//SOH O NOME
// QUERY SINTAX
var listaDeNomes =   from p in pessoas 
                     where p.Casada && p.DataDeNascimento > new DateTime(1980,1,1)
                     select p.Nome;

// QUERY SINTAX
var listaGroupBy = from p in pessoas 
                   group p by p.Casada;

var listaGroupBy2 = from p in pessoas 
                    group p by p.Casada into grupoDePessoas
                    select new {Categoria=grupoDePessoas.Key, Pessoas=grupoDePessoas};

var nCasados = (from p in pessoas 
               where p.Casada
               select p).Count();
