using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class SideProject
    {
        public string Id { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public override string ToString() => JsonSerializer.Serialize<SideProject>(this);
    }


}
