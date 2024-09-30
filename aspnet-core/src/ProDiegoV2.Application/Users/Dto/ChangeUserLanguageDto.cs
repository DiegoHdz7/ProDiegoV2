using System.ComponentModel.DataAnnotations;

namespace ProDiegoV2.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}