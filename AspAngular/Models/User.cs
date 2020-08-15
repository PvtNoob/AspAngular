using System.ComponentModel.DataAnnotations;

namespace AspAngular.Models {
    public class User {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public int Plz { get; set; }
    }
}
