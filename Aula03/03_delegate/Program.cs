static void tratadorDeExplosao(object? algo, EventArgs ev){
    Console.WriteLine("Bombeiros entram em ação");
}

static void tratadorDeExplosao2(object? algo, EventArgs ev){
    Console.WriteLine("A multidão corre pelas ruas");
}

Bomba b = new Bomba(4);
b.fazBum += tratadorDeExplosao;
b.fazBum += tratadorDeExplosao2;

Console.WriteLine("tic tac.. 1");
b.tictac();
Console.WriteLine("tic tac.. 2");
b.tictac();
Console.WriteLine("tic tac.. 3");
b.tictac();
Console.WriteLine("tic tac.. 4");
b.tictac();
Console.WriteLine("tic tac.. 5");
b.tictac();
Console.WriteLine("tic tac.. 6");
b.tictac();
Console.WriteLine("tic tac.. 7");
b.tictac();
