public class Funcionario: Pessoa{
    public decimal salario{get;}
    private const decimal SALARIO_MINIMO = 1320.0m;
    
    public Funcionario(string nomeDoFuncionario, int idadeDoFuncionario, decimal salarioDoFuncionario)
        :base(nomeDoFuncionario, idadeDoFuncionario)
    {
        salario=salarioDoFuncionario;
    }
    public Funcionario(string nomeDoFuncionario, int idadeDoFuncionario )
        :base(nomeDoFuncionario, idadeDoFuncionario)
    {
            salario=SALARIO_MINIMO;
    }
    public Funcionario():
        this("John Nobody",-1)
    {}

    public override string? ToString(){
        string resultado;
        resultado  = $"Detalhes de um funcionário\n";
        resultado += $"  Nome:  {this.nome}\n";
        resultado += $"  Idade: {this.idade}\n";
        resultado += $"  Ano de nascimento: {this.anoDeNascimento}\n";
        resultado += $"  Salário: R$ {this.salario}\n";
        return resultado;
    }

    public override void tahComFome()
    {
       Random r = new Random();
        if(r.Next()%2==1)
            Console.WriteLine("Sim, estou morrendo de fome.");
        else    
            Console.WriteLine("Não, tenho coisa melhor em casa."); 
    }

    //MÉTODO NÃO PODE SER EXTENDIDO
    //public override void conteAteTres(){
    //}

    public void conteAteDois(){
        Console.WriteLine("1, 2...");
    }

}