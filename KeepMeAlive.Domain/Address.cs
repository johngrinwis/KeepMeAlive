namespace KeepMeAlive.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public string HouseLetter { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }
}