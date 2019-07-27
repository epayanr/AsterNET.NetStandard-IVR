namespace CDRManagement.DataAccess.AsterNet.Manager.Event
{
    public class MeetmeTalkRequestEvent : AbstractMeetmeEvent
    {
        public MeetmeTalkRequestEvent(ManagerConnection source)
            : base(source)
        {
        }

        public bool Status { get; set; }
    }
}