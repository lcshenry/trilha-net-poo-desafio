namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            if (!string.IsNullOrEmpty(nomeApp))
            {
                Console.WriteLine("Instalando o aplicativo Nokia " + nomeApp);
            }
            else
            { 
                Console.WriteLine("O nome do aplicativo não foi fornecido."); 
            }
        }
    }
}