using System.ComponentModel.DataAnnotations.Schema;

namespace Chinook.Model.Entities
{
    public class City : BaseModel
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
    }
}
