using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superheroes2.Models
{
    public class Superhero
    {
        [Key]

        public int SuperheroID { get; set; }
        public string SuperheroName { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryAbility { get; set; }
        public string SecondaryAbility { get; set; }
        public string CatchPhrase { get; set; }

        public virtual DbSet<Superhero> Superhero{ get; set; }
    }
}