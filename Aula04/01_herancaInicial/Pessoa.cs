public class Pessoa
{

    public string nome{get;}
    public int idade{get; private set;}

    public Pessoa():this("João Niguém",-1){}
    public Pessoa(string n, int i){
        idade=i;
        nome=n;
    }
    public int anoDeNascimento{
        get{
            DateTime now = DateTime.Now;
            return now.Year-idade;
        }
        set{
            DateTime now = DateTime.Now;
            idade=now.Year-value;
        }    
    }

    public virtual void tahComFome(){
        Random r = new Random();
        if(r.Next()%2==1)
            Console.WriteLine("Sim");
        else    
            Console.WriteLine("Não");
    }

    public override string? ToString(){
        string resultado;
        resultado  = $"Detalhes de uma pessoa\n";
        resultado += $"  Nome:  {this.nome}\n";
        resultado += $"  Idade: {this.idade}\n";
        resultado += $"  Ano de nascimento: {this.anoDeNascimento}\n";
        return resultado;
    }

    public void conteAteTres(){
        for(int i=1; i<=3; i++)
            Console.Write(i+", ");
        Console.WriteLine();
    }


    
}