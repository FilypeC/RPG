using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Item : Persona
    {
        public string Nome { get; set; }
        public Boolean Indestrutivel { get; set; }
        public int Preco { get; set; }
        public string Flavor { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }

    }
}
