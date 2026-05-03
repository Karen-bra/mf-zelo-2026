using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_zelo_2026.Models
{
    [Table("Assembleias")]
    public class Assembleia
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataReuniao { get; set; }
        public string Local { get; set; }
        public DateTime DataPublicacao { get; set; }
        public StatusAssembleia Status { get; set; }
        public int TotalUnidades { get; set; }

        public ICollection<Presenca> Presencas { get; set; } = new List<Presenca>();
    }

    public enum StatusAssembleia
    {
        Proxima,
        Realizada
    }

    public class Presenca
    {
        public int Id { get; set; }
        public int AssembleiaId { get; set; }
        [Required(ErrorMessage = "O número do apartamento é obrigatório.")]
        public string Apartamento { get; set; }
        [Required(ErrorMessage = "O nome do morador é obrigatório.")]
        public string NomeMorador { get; set; }
        public DateTime ConfirmadoEm { get; set; }

        public Assembleia Assembleia { get; set; }
    }
}
