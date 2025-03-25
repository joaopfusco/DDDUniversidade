using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUniversidade.Domain.Models
{
    public class Seguidor : BaseModel
    {
        public int SegueId { get; set; }

        public int SeguidoId { get; set; }

        public Usuario Segue { get; set; }
        public Usuario Seguido { get; set; }
    }
}
