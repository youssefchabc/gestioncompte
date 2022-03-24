using System;
using System.Collections.Generic;

#nullable disable

namespace gestioncompte.Models
{
    public partial class Employe
    {
        public int Idemploye { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Direction { get; set; }
        public string Secteur { get; set; }
        public string Poste { get; set; }
    }
}
