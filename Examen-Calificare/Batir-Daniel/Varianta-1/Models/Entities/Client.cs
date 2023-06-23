using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta_1.Models.Entities
{
    public class Client
    {
        [Key]
        public int? CodClient { get; set; }

        [MaxLength(50)]
        public string? Nume { get; set; }

        [MaxLength(50)]
        public string? Prenume { get; set; }

        [MaxLength(80)]
        public string? Adresa { get; set; }

        [MaxLength(60)]
        public string? Email { get; set; }

        [MaxLength(14)]
        public string? Telefon { get; set; }

        public ICollection<Comanda> Comenzi = new List<Comanda>();
    }
}
