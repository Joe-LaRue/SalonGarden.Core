using System.Collections.Generic;

namespace SalonGarden.Core.Entities
{
    public class Technique
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public TechniqueType TechniqueType { get; set; }
        public int TechniqueTypeId { get; set; }

       
    }
}