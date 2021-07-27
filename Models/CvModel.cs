using System.ComponentModel.DataAnnotations;

namespace CV.Models
{
    public class CvModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Location { get; set; }
        [Display(Name = "Social Media Link")]
        public string  SocialMedia { get; set; }
    }
}