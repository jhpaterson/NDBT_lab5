using System.Collections.Generic;
using Newtonsoft.Json;

namespace NDBT_lab5.Models
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public Shelf Shelf { get; set; }
        //[JsonProperty(ItemReferenceLoopHandling = ReferenceLoopHandling.Serialize)]
        public List<Copy> Copies { get; set; }
    }
}