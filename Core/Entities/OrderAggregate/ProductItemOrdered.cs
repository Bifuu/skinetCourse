namespace Core.Entities.OrderAggregate
{
    public class ProductItemOrdered
    {
        public ProductItemOrdered()
        {
        }

        public ProductItemOrdered(int productItemId, string name, string pictureUrl)
        {
            ProductItemId = productItemId;
            Name = name;
            PictureUrl = pictureUrl;
        }

        public int ProductItemId { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
    }
}