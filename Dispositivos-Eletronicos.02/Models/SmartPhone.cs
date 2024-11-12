﻿namespace Dispositivos_Eletronicos._02.Models
{
    public class SmartPhone : DispositivoEletronico
    {
        public bool Tem5G {  get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, SO: {(Tem5G ? "Sim" : "Não")}";
        }
    }
}
