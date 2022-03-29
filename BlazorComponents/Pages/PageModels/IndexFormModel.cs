using System.ComponentModel.DataAnnotations;

namespace BlazorComponents.Pages.PageModels
{
    public class IndexFormModel
    {
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
