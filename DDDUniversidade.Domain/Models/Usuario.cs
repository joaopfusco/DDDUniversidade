namespace DDDUniversidade.Domain.Models
{
    public class Usuario : BaseModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Curso { get; set; }

        public ICollection<Seguidor> Seguidores { get; set; }
        public ICollection<Seguidor> Seguindo { get; set; }
        public ICollection<Postagem> Postagens { get; set; }
    }
}
