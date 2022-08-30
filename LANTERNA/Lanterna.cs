using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LANTERNA
{
    public enum Lstatus
    {
        Desligado, Ligado
    }
    internal class Lanterna
    {
        public Lstatus lstatus { get; set; }
        public Bateria bateria { get; set; }
        public Lanterna()
        {
            this.bateria = new Bateria();
        }
    }
}
