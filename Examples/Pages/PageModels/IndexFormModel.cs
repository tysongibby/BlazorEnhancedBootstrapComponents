using System.ComponentModel.DataAnnotations;

namespace Examples.Pages.PageModels
{
    public class IndexFormModel
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Preferred Name")]
        public string PreferredName { get; set; }
    }
}
