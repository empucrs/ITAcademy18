public class Cachorro: Animal{
    public Cachorro(){
        Console.WriteLine("Criando um cachorro");
    }

    public override void emiteSom()
    {
        Console.WriteLine("au au au au au");
    }
}