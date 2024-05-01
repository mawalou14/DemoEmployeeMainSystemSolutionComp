
using System.Text.Json.Serialization;

namespace BaseLibary.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        //Relationship : One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }

    }
}
