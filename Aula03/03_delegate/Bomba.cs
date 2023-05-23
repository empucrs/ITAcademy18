public class Bomba{

    private int tics;
    public int tempoLimite {get; set;}
    public bool jaExplodiu {get; private set;}

    public event EventHandler? fazBum;

    public Bomba(int limite){
        tempoLimite=limite;
    }

    public void tictac(){
        tics++;
        if((tics>tempoLimite)&&(!jaExplodiu))
          explodeABomba();          
    }

    private void explodeABomba(){
        jaExplodiu=true;
        if(fazBum!=null)
            fazBum(this, EventArgs.Empty);
    }
    
}