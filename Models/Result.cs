using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWithValidation.Models
{
    public class Result
    {
        [Required]
        [MinLength(2)]
        public string YourName { get; set; }
        [Required]
        public string DojoLocation { get; set; }
        [Required]
        public string FavoriteLanguage { get; set; }
        [MaxLength(20)]
        public string Comment { get; set; }

    }
}