using System.ComponentModel.DataAnnotations;

namespace localization.Models{
    public class Product{
        public int Id { get; set; }

        [Display(Name="Name")]
        [Required(ErrorMessage="{0} is Required")]
        public string Name { get; set; }

        [Display(Name="Address")]
        [Required(ErrorMessage="{0} is Required")]
        [StringLength(3, MinimumLength = 0, ErrorMessage = "Length of {0} field should be between {2} and {1}.")]
        public string Address { get; set; }
    }
}