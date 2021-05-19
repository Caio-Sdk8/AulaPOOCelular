namespace aulaPOOcelular
{
    public class celular
    {
       public bool ligado = false;



       public string cor;

       public string modelo;

       public string tamanho;

       public string ligar()
       {
           ligado = true;
           return "Discando para....";
       }
       public string mensagem(){
           ligado = true;
           return "Sua mensagem foi enviada para";
       }
    }
}