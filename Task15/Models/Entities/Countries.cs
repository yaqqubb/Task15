using System.ComponentModel.DataAnnotations.Schema;

namespace Task15.Models.Entities
{
    public class Countries
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; } 
        public required  string Name { get; set; }

        public required int Code  { get; set; }
    }
}
