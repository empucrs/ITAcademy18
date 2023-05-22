public class OutraClasse
{
    public int campoA{get;}
    public int campoB{get;set;}

    public OutraClasse()
        :this(1,2){
        Console.WriteLine("Construtor sem parametros");
    }

    public OutraClasse(int a, int b){
        campoA=a;
        campoB=b;
        Console.WriteLine("Construtor com 2 parametros");
    }
    public OutraClasse(int a):this(a,0){
        Console.WriteLine("Construtor com 1 parametro");
    }

    public static OutraClasse operator+ (int oPrimeiroOperando, OutraClasse oSegundoOperando){
        return oSegundoOperando+oPrimeiroOperando;
    }
    public static OutraClasse operator+ (OutraClasse oPrimeiroOperando, int oSegundoOperando){
        int auxA=oPrimeiroOperando.campoA+oSegundoOperando;
        int auxB=oPrimeiroOperando.campoB+oSegundoOperando;
        return new OutraClasse(auxA, auxB);
    }
    public static OutraClasse operator+ (OutraClasse oPrimeiroOperando, OutraClasse oSegundoOperando){
        int auxA=oPrimeiroOperando.campoA+oSegundoOperando.campoA;
        int auxB=oPrimeiroOperando.campoB+oSegundoOperando.campoB;
        return new OutraClasse(auxA, auxB);
    }
}