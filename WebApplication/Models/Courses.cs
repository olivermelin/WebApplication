using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Language { get; set; }

        public int Grade { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Course>(this);
    }
}
