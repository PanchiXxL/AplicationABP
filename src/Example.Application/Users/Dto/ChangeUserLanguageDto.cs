using System.ComponentModel.DataAnnotations;

namespace Example.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}