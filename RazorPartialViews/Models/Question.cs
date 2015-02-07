using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPartialViews.Models
{
    public class Question
    {
        [HelpText("This is Help Text")]
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        [HelpText("This is your date of birth.")]
        public DateTime  Birthday { get; set; }
        [UIHint("ZipCode")]
        [DisplayName("Zippadee")]
        public string  ZipCode{ get; set; }
    }
}
