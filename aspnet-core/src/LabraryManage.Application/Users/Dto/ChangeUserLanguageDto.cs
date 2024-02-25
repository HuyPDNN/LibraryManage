using System.ComponentModel.DataAnnotations;

namespace LabraryManage.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}