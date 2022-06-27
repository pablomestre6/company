using System.ComponentModel.DataAnnotations;

namespace company.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}