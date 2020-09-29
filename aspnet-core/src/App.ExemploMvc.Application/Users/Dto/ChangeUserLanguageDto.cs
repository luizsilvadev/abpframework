using System.ComponentModel.DataAnnotations;

namespace App.ExemploMvc.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}