public abstract class Animal{
    public decimal peso{get; set;}
    public decimal altura{get; set;}
    public Animal()
    {
        Console.WriteLine("Animal sendo criado");
    }
    public override string ToString()
    {
        return $"Peso:{peso}; Altura:{altura}";
    }
    public abstract void emiteSom();
}