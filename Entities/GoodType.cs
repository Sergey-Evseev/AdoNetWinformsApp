namespace AdoNetWinformsApp.Entities
{
    public class GoodType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual ICollection<Good> Goods { get; set; }
    }
}
