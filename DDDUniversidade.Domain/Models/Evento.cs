using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUniversidade.Domain.Models
{
    public class Evento : BaseModel
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public int Inscritos { get; set; }
        public bool Aberto { get; set; }
    }
}
