﻿using Confluent.Kafka;
using Microsoft.Extensions.Hosting;

namespace Consumer
{
    public class ApacheKafkaConsumerService : IHostedService
    {
        private readonly string topic = "DESKTOP-OJFH3E4.dbo.tb_CDCTab1";
        private readonly string groupId = "test_group";
        private readonly string bootstrapServers = "192.168.1.9:9092,localhost:9092";

        public Task StartAsync(CancellationToken cancellationToken)
        {
            var config = new ConsumerConfig
            {
                GroupId = groupId,
                BootstrapServers = bootstrapServers,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            try
            {
                using (var consumerBuilder = new ConsumerBuilder<Ignore, string>(config).Build())
                {
                    consumerBuilder.Subscribe(topic);
                    var cancelToken = new CancellationTokenSource();

                    try
                    {
                        while (true)
                        {
                            var consumer = consumerBuilder.Consume(cancelToken.Token);
                            Console.WriteLine($"Processing Order Id: {consumer.Message.Value}");
                        }
                    }
                    catch (OperationCanceledException)
                    {
                        consumerBuilder.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Task.CompletedTask;
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
