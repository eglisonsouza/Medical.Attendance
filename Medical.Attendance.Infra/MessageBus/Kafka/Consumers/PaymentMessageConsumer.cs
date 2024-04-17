using MassTransit;
using Medical.Attendance.Infra.MessageBus.Kafka.Messages;

namespace Medical.Attendance.Infra.MessageBus.Kafka.Consumers;

public class PaymentMessageConsumer : IConsumer<PaymentMessage>
{
    public Task Consume(ConsumeContext<PaymentMessage> context)
    {
        throw new NotImplementedException();
    }
}