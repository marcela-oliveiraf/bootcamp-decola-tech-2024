using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Classes{
    
    public class Nokia : Smartphone{
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {

        }    
        // Implementação do método abstrato InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando {nomeApp} no Nokia.");            
        }
    }      
}