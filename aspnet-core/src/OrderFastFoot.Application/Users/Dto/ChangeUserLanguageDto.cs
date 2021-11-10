using System.ComponentModel.DataAnnotations;

namespace OrderFastFoot.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}