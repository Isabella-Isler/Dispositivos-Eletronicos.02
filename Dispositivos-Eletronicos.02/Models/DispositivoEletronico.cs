namespace Dispositivos_Eletronicos._02.Models
{
    public abstract class DispositivoEletronico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoDeFabricacao {  get; set; }
        //É um método
        public abstract string ExibirDetalhes();
    }
}
