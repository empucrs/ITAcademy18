public class Pessoa
{

    public string? Nome{get; set;}
    public bool Casada{get; set;}
    public DateTime DataDeNascimento {get;set;}

    public override string ToString()
    {
        
        return $"[Nome:{Nome}; DataDeNascimento:{DataDeNascimento.ToShortDateString()}; Casada:{(Casada?"SIM":"NÃO")}]";

    }
    
}