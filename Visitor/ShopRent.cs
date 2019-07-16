namespace Visitor
{
    public class ShopRent : IVisitable
    {
        public double Price { get; set; }

        public ShopRent(double price)
        {
            this.Price = price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public override string ToString()
        {
            return $"Shop price : {Price}";
        }
    }
}