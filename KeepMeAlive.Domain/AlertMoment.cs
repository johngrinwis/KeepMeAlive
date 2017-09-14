using System;
using System.Collections.Generic;

namespace KeepMeAlive.Domain
{
    public class AlertMoment
    {
        public int Id { get; set; }
        public DateTime AlertOn { get; set; }
        public bool EnableSnooze { get; set; }
        public AlertMoment NextMoment { get; set; }
        public List<AlertAction> Actions { get; set; }
        public List<Contact> ContactsToNotify { get; set; }
        public TimeSpan NotifyMeBeforeAlert { get; set; }
    }
}