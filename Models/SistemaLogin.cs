using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaLogin
{
    [Table("Login")]
    public class SistemaLogin
    {
        //Criando Model, declarando quais dados serão passados e aplicando encapsulamento.
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;
        
        [Column("Username")]
        [Display(Name = "Username")]
        public string Username { get; set; } = string.Empty;
        
        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; } = string.Empty;
    }
}
