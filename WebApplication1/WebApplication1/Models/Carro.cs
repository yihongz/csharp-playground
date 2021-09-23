using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Carro
    {
        public virtual int CarroId { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Placa { get; set; }
    }
}
