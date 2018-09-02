using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PetManager {
    public class Pet {
        public string Name { get; set; }
        public string Breed { get; set; }

        public int GetHashCode()
        {
            int hash = 33;
            hash = hash * 12 + (this.Name != null ? this.Name.GetHashCode() : 0);
            hash = hash * 12 + (this.Breed != null ? this.Breed.GetHashCode() : 0);
            return hash;
        }
    }
}
