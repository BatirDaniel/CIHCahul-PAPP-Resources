using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_1.Models.Entities
{
    public class Comanda
    {
        [Key]
        [MaxLength(150)]
        public string? CodComanda { get; set; }

        public DateTime? DataComanda { get; set; }

        public double SumaTotala { get; set; }

        [ForeignKey("CodClient")]
        public Client? Client { get; set; }
        public string? CodClient { get; set; }
    }
}
