public class PrimeiraClasseA
{

    public PrimeiraClasseA(int a, int b){
        this.valorA=a;
        this.valorB=b;
    }

    // foi inferido como um atributo/campo de classe, não de instancia 
    public const int umValorConstante = 10;
    
    public int valorA;
    private int valorB;

    public int percentual;
    public void calculaPercentual(){
        if(valorA>valorB)
            percentual=((valorB*100)/valorA);
        else
            percentual=((valorA*100)/valorB);
    }

    public int getValorB(int outroValor){
        return valorB+outroValor;
    }

    public void adicionar1(int x, int y, out int r){
        r=x+y;
    }

    public int adicionar2(int x, int y, out int r){
        r=x+y;
        return r+x+y;
    }

    public void paraMaiusculo (ref string algo){
        algo=algo.ToUpper();
    }

    public void mostraListaA(params int[] valores){
        foreach (int item in valores)
            Console.WriteLine("  valor:"+item);
    }

    public void mostraListaB(int algumaCoisa, params int[] valores){
        Console.WriteLine($"alguma coisa com o valor{algumaCoisa} foi passado");
        foreach (int item in valores)
            Console.WriteLine("  valor:"+item);
    }

    public int ValorB {
        get {return valorB;}
        set {valorB = value;}
    }

    public int umaPropriedadeQualquer{
        get; set;
    }
    
}