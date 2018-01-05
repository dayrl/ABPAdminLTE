using System.ComponentModel.DataAnnotations;

namespace Wing.ABPTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}