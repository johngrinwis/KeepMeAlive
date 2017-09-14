using System;

namespace KeepMeAlive.Domain
{
    public class UserGpsLocation
    {
        public int Id { get; set; }
        public KeepAliveUser User { get; set; }
        public GpsLocation Location { get; set; }
        public DateTime Date { get; set; }
    }
}