using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorServerApp.Data
{
    public class Meal
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Le nom du plat est trop long.")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(1, 200, ErrorMessage = "Le montant doit etre compris entre 1 et 200 $")]
        public decimal Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
