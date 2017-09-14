using System;

namespace Declencheurs.Models
{
    public class Declencheur
    {
        public long DeclencheursId { get; set; }

        public string Nom { get; set; }

            public string Heure { get; set; }

            public string Composant { get; set; }

            public string Repetition { get; set; }

            public string Son { get; set; }

            public string IntervalRepetition { get; set; }
        
    }
}
