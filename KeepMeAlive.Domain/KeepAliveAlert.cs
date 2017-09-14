using System.Collections.Generic;

namespace KeepMeAlive.Domain
{
    public class KeepAliveAlert
    {
        public int Id { get; set; }
        public KeepAliveUser User { get; set; }
        public AlertInformation Information { get; set; }
        public List<Contact> PersonsToNotify { get; set; }
    }
}