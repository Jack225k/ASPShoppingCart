using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    [MetadataType(typeof(CategoriesMetaData))]
    public partial class Category
    {

    }

    public class CategoriesMetaData
    {


        [Required(ErrorMessage = "The category name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a category name between 3 and 50 characters in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a category name beginning with a capital letter and made up of letters and spaces only")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

    }
}