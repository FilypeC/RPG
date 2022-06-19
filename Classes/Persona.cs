using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Persona
    {
       public string Nome { get; set; }
       public string Classe { get; set; }
        public int For { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Int { get; set; }
        public int Per { get; set; }
        public int Car { get; set; }
        public List <string> Vantagem { get; set; }
        public List <string> Desvantagem { get; set; }
     
        public Persona()
        {
            Vantagem = new List<string>();
            Desvantagem = new List<string>();
        }
    }

}
