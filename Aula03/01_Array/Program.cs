int [] arrayDeInteiro;
arrayDeInteiro = new int[5];

Console.WriteLine($"Conteúdo de um array criado");
for(int i=0; i<arrayDeInteiro.Length; i++)
    Console.WriteLine($"  [{i}]: {arrayDeInteiro[i]}");

Console.WriteLine($"Manipulando com foreach");
foreach (var item in arrayDeInteiro)
    Console.WriteLine($"  [{item}]");

//var variavelUm=1;
//var variavelDois=1.2f;
//var variavelTres="Edson Moreno";

var variavelQuatro=new int[10];
var nroRandomico = new Random(42);

Console.WriteLine("Manipulação de variavel/array declarada como var");
for(int i=0; i<variavelQuatro.Length; i++)
    variavelQuatro[i]=nroRandomico.Next()%1001;

for(int i=0; i<variavelQuatro.Length; i++)
    Console.WriteLine($"  [{i}]: {variavelQuatro[i]}");

Console.WriteLine("Manipulação de variavel/array redifinido");
variavelQuatro = new int[] {123, 234, 46, 756, 678, 96789, 6798};
for(int i=0; i<variavelQuatro.Length; i++)
    Console.WriteLine($"  [{i}]: {variavelQuatro[i]}");

var exemploUm     = new int [10];
int[] exemploDois = {1,2,3,4,5};
var exemploTres   = new int[] {3,4,5,6};
//-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
// array multidimensional
Console.WriteLine("Apresentação de estrutura multimensional");
int [,] matrizUm = new int[2,3];
Console.WriteLine($"  length: {matrizUm.Length}");
Console.WriteLine($"  rank: {matrizUm.Rank}");
for(int linha=0; linha<2; linha++)
    for(int coluna=0; coluna<3; coluna++)
        matrizUm[linha, coluna] = nroRandomico.Next()%1001;

for(int linha=0; linha<2; linha++)
    for(int coluna=0; coluna<3; coluna++)
        Console.WriteLine($"[{linha},{coluna}]: {matrizUm[linha, coluna]}");
Console.WriteLine("foreach da matriz multidimensional")        ;
foreach (var item in matrizUm)
    Console.WriteLine($"{item}");
Console.WriteLine();

//  --> Arranjo definido como Jagged
int [][] jaggedArray = new int[2][];
jaggedArray[0] = new int[3];
jaggedArray[1] = new int[5];

Console.WriteLine("Construção do array jagged");
Console.WriteLine($"  length: {jaggedArray.Length}");
for(int i=0; i<jaggedArray.Length; i++)
    Console.WriteLine($"  length[{i}]: {jaggedArray[i].Length}");
Console.WriteLine();
for(int linha=0; linha<jaggedArray.Length; linha++)
    for(int coluna=0; coluna<jaggedArray[linha].Length; coluna++)
        jaggedArray[linha][coluna]=nroRandomico.Next()%11;

for(int linha=0; linha<jaggedArray.Length; linha++)
    for(int coluna=0; coluna<jaggedArray[linha].Length; coluna++)
        Console.WriteLine($"  [{linha},{coluna}]: {jaggedArray[linha][coluna]}" );

//explorando foreach
Console.WriteLine("Foreach em jagged array");
foreach (var item in jaggedArray)
    foreach (var inteiro in item)
        Console.WriteLine(inteiro);
