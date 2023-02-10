namespace AdoNetWinformsApp.Entities
{
    public class Delivery
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime DeliveryTime { get; set; }
        public int GoodsId { get; set; }
        public virtual Good Good { get; set; }
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
