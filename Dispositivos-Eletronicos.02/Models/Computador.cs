namespace Dispositivos_Eletronicos._02.Models
{
    public class Computador : DispositivoEletronico
        //Essa linha é responsável por herdar o DispositivoEletronico
    {
        public bool EhLaptop { get; set; }
        public int MemoriaRam {  get; set; }
        public string SistemaOperacional {  get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, SO: {SistemaOperacional}";
        }
    }
}
