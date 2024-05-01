
using System.Text.Json.Serialization;

namespace BaseLibary.Entities
{
    public class Relationship
    {
        //Relationship : One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
