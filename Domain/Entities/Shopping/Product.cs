namespace Models.Shopping
{
    public class Product
    {
        public Product()
        {
            ID = SadrTools.Utility.NumericHelper.GetRandom();
            Title = string.Empty;
        }

        public int ID { get; }

        public string Title { get; set; }

        public int Price { get; set; }


        public override string ToString()
        {
            return $"{ID} {Title} {Price}\n";
        }
    }

}
