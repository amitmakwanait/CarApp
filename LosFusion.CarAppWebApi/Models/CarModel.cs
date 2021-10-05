using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosFusion.CarAppWebApi.Models
{
   public class CarModel
    {
        [Required]
public string Name { get; set; }
        [Required]
        public string Color {  get; set; }
        [Required]
        public string YearMade {  get; set; }
    }
}
