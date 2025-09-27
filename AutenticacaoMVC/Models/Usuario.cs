using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoMVC.Models
{
    [Table("Usuarios")] // Opcional, mas bom para garantir o nome da tabela em plural
   public class Usuario{
        [Key]     
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string login { get; set; }

        /// <summary>/// Armazena o hash da senha gerado por um algoritmo seguro como BCrypt./// 
        /// </summary>    
        [Required]
        public required string Senha { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public int Situacao { get; set; }
    }
       
    }
