using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHPet.Model
{
    [Table("Cliente")]
    public class cliente

    {
        [Key]
        [Column("Id")]
        [Display(Name = "Id")]
        public int id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }
        

        [Column("Paciente")]
        [Display(Name = "Paciente")]
        public string? Paciente { get; set;}
    }

}


