using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUniversidade.Domain.Models
{
    public class Postagem : BaseModel
    {
        public int AutorId { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; set; }
        public int Curtidas { get; set; }
        public int Comentarios { get; set; }

        public Usuario Autor { get; set; }
    }
}
