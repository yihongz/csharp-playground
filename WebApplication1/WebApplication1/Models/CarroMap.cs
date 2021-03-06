
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarroMap : ClassMap<Carro>
    {
        public CarroMap()
        {
            Id(c => c.CarroId);
            Map(c => c.Nome);
            Map(c => c.Placa);
            Table("Carros");
        }
    }
}
