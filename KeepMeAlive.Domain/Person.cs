namespace KeepMeAlive.Domain
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Initials { get; set; }
        public string SurNamePrefix { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}