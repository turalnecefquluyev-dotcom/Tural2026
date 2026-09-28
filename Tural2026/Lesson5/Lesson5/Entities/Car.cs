namespace LinqTest.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; } = string.Empty; 
        public bool IsNew { get; set; }
    }
}