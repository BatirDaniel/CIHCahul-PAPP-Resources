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
        public int? CodComanda { get; set; }

        public DateTime? DataComanda { get; set; }

        public double SumaTotala { get; set; }

        [ForeignKey("CodClient")]
        public Client? Client { get; set; }
        public int? CodClient { get; set; }
    }
}
