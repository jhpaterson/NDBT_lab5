using System;
using Newtonsoft.Json;

namespace NDBT_lab5.Models
{
    
    public class Copy
    {
        public int CopyId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool IsAvailable { get; set; }
        //[JsonProperty(ItemReferenceLoopHandling = ReferenceLoopHandling.Serialize)]
        public Title Title { get; set; }
        public int TitleId { get; set; }
    }
}