public class Program
{
    public static void Main(string[] args){

        PrimeiraClasseA pca = new PrimeiraClasseA(1,2);
        Console.WriteLine("O valor contido na variável é:"+pca.valorA);

        //-=-=-=-=-=-=-=-=-=-=-
        // ERRO DE COMPILAÇÃO POIS VALORB É PRIVADO
        //Console.WriteLine("O valor contido na variável é:"+pca.valorB);

        Console.WriteLine("O valor contido na variável é:"+pca.getValorB(0));
        
        //-=-=-=-=-=-=-=-=-=-=-
        pca.calculaPercentual();
        Console.WriteLine("Percentual calculado:"+pca.percentual);
        pca.percentual =  253;
        Console.WriteLine("Percentual calculado:"+pca.percentual);

        //-=-=-=-=-=-=-=-=-=-=-
        //ACESSSANDO UM VALOR CONSTANTE
        Console.WriteLine("Acessando um valor constante:"+ PrimeiraClasseA.umValorConstante );
        // ERRO DE COMPILAÇÃO. NÃO POSSO ATRIBUIR UM VALOR A UMA CONSTANTE
        //PrimeiraClasseA.umValorConstante = 12;

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //EXPLORAÇÃO DE MODIFICADORES DE PARAMETROS
        //  --> OUT
        int resultado;
        pca.adicionar1(1,2,out resultado);
        Console.WriteLine("O resultado do modificador out no método é: "+resultado);
        Console.WriteLine("O resultado do modificador out no método é: "+resultado+", "+pca.adicionar2(3,4,out resultado));
        Console.WriteLine($"O resultado do modificador out no método é: {pca.adicionar2(5,6,out resultado)}, {resultado}");
        //  --> ref
        string nome="Edson Ifarraguirre Moreno";
        Console.WriteLine("Nome do cristão: "+nome);
        pca.paraMaiusculo(ref nome);
        Console.WriteLine("Nome do cristão: "+nome);
        //  --> params  
        int [] umaListaQualquer = new int[3] {1, 2, 3};
        Console.WriteLine("uma lista");
        pca.mostraListaA(umaListaQualquer);
        Console.WriteLine("parametros");
        pca.mostraListaA(4,5,6);
        Console.WriteLine("parametros");
        pca.mostraListaB(4,5,6);

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //EXPLORAÇÃO DE PROPRIEDADES
        Console.WriteLine("O valor contido na variável é:"+pca.ValorB+" == "+pca.getValorB(0));
        pca.ValorB=10;
        Console.WriteLine("O valor contido na variável é:"+pca.ValorB+" == "+pca.getValorB(0));

        // PROPRIEDADE DESVINCULADA DE CAMPO - umaPropriedadeQualquer
        Console.WriteLine("O valor contido na propriedade é:"+pca.umaPropriedadeQualquer);
        pca.umaPropriedadeQualquer=21;
        Console.WriteLine("O valor contido na propriedade é:"+pca.umaPropriedadeQualquer);

        //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        //OVERLOAD
        //  --> Em construtores
        OutraClasse oc = new OutraClasse();
        Console.WriteLine($"Os valores em outra classe são A:{oc.campoA} e B:{oc.campoB}");        
        oc = new OutraClasse(3,4);
        Console.WriteLine($"Os valores em outra classe são A:{oc.campoA} e B:{oc.campoB}");        
        oc = new OutraClasse(5);
        Console.WriteLine($"Os valores em outra classe são A:{oc.campoA} e B:{oc.campoB}");
        //  --> Operadores
        OutraClasse a, b;
        a=new OutraClasse(1,2);
        b=new OutraClasse(3,4);
        oc=a+b;
        Console.WriteLine($"Os valores em outra classe são A:{oc.campoA} e B:{oc.campoB}");
        oc=a+3;
        Console.WriteLine($"Os valores em outra classe são A:{oc.campoA} e B:{oc.campoB}");
        oc=5+a;
        Console.WriteLine($"Os valores em outra classe são A:{oc.campoA} e B:{oc.campoB}");

    }
    
}
