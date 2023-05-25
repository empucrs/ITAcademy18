public class Pessoa: IEquatable<Pessoa>, ICloneable
{
    private string nome;
    private int idade;
    public Pessoa(string n, int i){
        nome=n;
        idade=i;
    }
    public string Nome{
        get{
            return nome;
        }
    }
    public int Idade{
        get => idade;
    }

    public object Clone()
    {
        Pessoa aux = (Pessoa) MemberwiseClone();
        aux.nome=new string(nome);
        return aux;
    }

    public bool Equals(Pessoa? other)
    {
        if(other is null)
            return false;
        return ((this.nome.Equals(other.nome)) && (this.idade==other.idade));        
    }

    public override bool Equals(object? obj)
    {
        Pessoa? aux = (Pessoa) obj;
        return Equals(aux);
    }

    public override string ToString()
    {
        return $"[nome:{nome};idade:{idade}]";        
    }

    public override int GetHashCode()
    {
        return nome.GetHashCode()+idade.GetHashCode();
    }

}