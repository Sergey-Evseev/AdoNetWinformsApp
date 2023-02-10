using System.ComponentModel.DataAnnotations;

namespace AdoNetWinformsApp.Entities
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Cost { get; set; }
        public int GoodsTypeId { get; set; }
        public virtual GoodType GoodType { get; set; }
    }
}
