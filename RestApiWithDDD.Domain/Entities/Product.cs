using RestApiWithDDD.Domain.Entities.Base;

namespace RestApiWithDDD.Domain
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool? IsAvailable { get; set; }
    }
}
