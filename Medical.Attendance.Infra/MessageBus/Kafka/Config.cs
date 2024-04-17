using MassTransit;
using Medical.Attendance.Infra.MessageBus.Kafka.Consumers;
using Medical.Attendance.Infra.MessageBus.Kafka.Messages;
using Microsoft.Extensions.DependencyInjection;

namespace Medical.Attendance.Infra.MessageBus.Kafka
{
    public static class Config
    {
        public static void AddKafkaConfig(this IServiceCollection services)
        {
            //TODO add config
            var bootstrapServers = "localhost:9092";
            var nameTopic = "topic-payments";
            var groupConsumer = "payments";
            //TODO add HealthCheck

            services.AddMassTransit<IBusControl>(massTransitConfig =>
            {
                massTransitConfig.UsingInMemory((context, config) => config.ConfigureEndpoints(context));

                massTransitConfig.AddRider((rider) =>
                {
                    rider.UsingKafka((context, kafka) =>
                    {
                        kafka.Host(bootstrapServers);
                        kafka.TopicEndpoint<PaymentMessage>(nameTopic, groupConsumer, e =>
                        {
                            e.ConfigureConsumer<PaymentMessageConsumer>(context);
                        });
                    });

                    rider.AddProducer<PaymentMessage>(nameTopic);

                    rider.AddConsumer<PaymentMessageConsumer>();
                });
            });
        }
    }
}


