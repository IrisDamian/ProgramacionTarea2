using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Vehículo
{
    class Clsvehiculo
    {
        public string marca { get; }
        public string modelo { get; set; }
        public int A { get; set; }
        public int maximavel { get; }
        public string color { get; set; }
        private int actualvel = 0;
        public bool Encendido { get; set; } = false;
        public Clsvehiculo(string marcavehiculo, string modelovehiculo, int Avehiculo,  int maxvel)
        {
            this.maximavel = maxvel;
            this.marca = marcavehiculo;
            this.A = Avehiculo;
            this.modelo = modelovehiculo;
        }
        public Clsvehiculo(string marcavehiculo, int maxvel, string colorvehiculo)
        {
            this.maximavel = maxvel;
            this.marca = marcavehiculo;
            this.color = colorvehiculo;
        }
        public string encender()
        {
            string result = "";
            if (Encendido)
            {
                Encendido = false;
                result = "se encuentra apagado";
            }
            else
            {
                Encendido = true;
                result = "puede seguir su camino, ¡Genial!";
            }
            actualvel = 0;
            return result;
        }
        public string stop()
        {
            if (!Encendido)
            {
                return "¡Enciende tu vehiculo!";
            }
            actualvel = 0;
            return "Su vehiculo se ha detenido";
        }
        public string acelerar()
        {
            if (!Encendido)
            {
                return "¡Enciende tu vehiculo!";
            }
            if (actualvel >= maximavel)
            {
                actualvel = maximavel;
                return $"Llegaste a la velocidad limite {maximavel} k/h";
            }
            else
            {
                actualvel = actualvel + 10;
                return $"Tu velocidad es {actualvel}k/h";
            }
        }
        public string cambiarv()
        {
            if (actualvel == 10)
            {
                return "Cambia a segunda velocidad";
            }
            if (actualvel == 20)
            {
                return "Ahora cambia a tercera velocidad";
            }
            if (actualvel == 40)
            {
                return "Realiza el cambio a cuarta velocidad";
            }
            else
            {
                actualvel = actualvel + 10;
                return "Prepara el cambio a quinta velocidad";
            }          
            
        }
    }
}


