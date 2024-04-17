namespace Medical.Attendance.Domain.Producers
{
    public interface IMessageProducer<in TMessage>
    {
        void Producer(TMessage message);
    }
}
