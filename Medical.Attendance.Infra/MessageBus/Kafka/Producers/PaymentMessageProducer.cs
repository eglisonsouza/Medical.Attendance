using MassTransit;
using Medical.Attendance.Domain.Producers;
using Medical.Attendance.Infra.MessageBus.Kafka.Messages;

namespace Medical.Attendance.Infra.MessageBus.Kafka.Producers;

public class PaymentMessageProducer(ITopicProducer<PaymentMessage> producer) : IMessageProducer<PaymentMessage>
{
    private readonly ITopicProducer<PaymentMessage> _producer = producer;

    public void Producer(PaymentMessage message)
    {
        _producer.Produce(message);
    }
}