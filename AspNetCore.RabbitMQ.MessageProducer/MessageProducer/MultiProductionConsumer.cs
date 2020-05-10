using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AspNetCore.RabbitMQ.MessageProducer.MessageProducer
{
    public class MultiProductionConsumer
    {
        public static void Show01()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";//RabbitMQ服务在本地运行
            factory.UserName = "guest";//用户名
            factory.Password = "guest";//密码 
            using (var connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "MultiProducerMessage", durable: true, exclusive: false, autoDelete: false, arguments: null);
                    channel.ExchangeDeclare(exchange: "MultiProducerMessageExChange", type: ExchangeType.Direct, durable: true, autoDelete: false, arguments: null);
                    channel.QueueBind(queue: "MultiProducerMessage", exchange: "MultiProducerMessageExChange", routingKey: string.Empty, arguments: null);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("生产者001已准备就绪~~~");
                    int i = 1;
                    {
                        while (true)
                        {
                            string message = $"生产者01：消息{i}";
                            byte[] body = Encoding.UTF8.GetBytes(message);
                            channel.BasicPublish(exchange: "MultiProducerMessageExChange",
                                            routingKey: string.Empty,
                                            basicProperties: null,
                                            body: body);
                            Console.WriteLine($"消息：{message} 已发送~");
                            i++;
                            Thread.Sleep(200);
                        }
                    }
                }
            } 
        }

        public static void Show02()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";//RabbitMQ服务在本地运行
            factory.UserName = "guest";//用户名
            factory.Password = "guest";//密码 
            using (var connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "MultiProducerMessage", durable: true, exclusive: false, autoDelete: false, arguments: null);
                    channel.ExchangeDeclare(exchange: "MultiProducerMessageExChange", type: ExchangeType.Direct, durable: true, autoDelete: false, arguments: null);
                    channel.QueueBind(queue: "MultiProducerMessage", exchange: "MultiProducerMessageExChange", routingKey: string.Empty, arguments: null);
                    Console.WriteLine("生产者002已准备就绪~~~");
                    int i = 1;
                    {
                        while (true)
                        {
                            string message = $"生产者02：消息{i}";
                            byte[] body = Encoding.UTF8.GetBytes(message);
                            channel.BasicPublish(exchange: "MultiProducerMessageExChange",
                                            routingKey: string.Empty,
                                            basicProperties: null,
                                            body: body);
                            Console.WriteLine($"消息：{message} 已发送~");
                            i++;
                            Thread.Sleep(200);
                        }
                    }
                }
            }
        }

        public static void Show03()
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";//RabbitMQ服务在本地运行
            factory.UserName = "guest";//用户名
            factory.Password = "guest";//密码 
            using (var connection = factory.CreateConnection())
            {
                using (IModel channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "MultiProducerMessage", durable: true, exclusive: false, autoDelete: false, arguments: null);
                    channel.ExchangeDeclare(exchange: "MultiProducerMessageExChange", type: ExchangeType.Direct, durable: true, autoDelete: false, arguments: null);
                    channel.QueueBind(queue: "MultiProducerMessage", exchange: "MultiProducerMessageExChange", routingKey: string.Empty, arguments: null);
                    Console.WriteLine("生产者003已准备就绪~~~");
                    int i = 1;
                    {
                        while (true)
                        {
                            string message = $"生产者03：消息{i}";
                            byte[] body = Encoding.UTF8.GetBytes(message);
                            channel.BasicPublish(exchange: "MultiProducerMessageExChange",
                                            routingKey: string.Empty,
                                            basicProperties: null,
                                            body: body);
                            Console.WriteLine($"消息：{message} 已发送~");
                            i++;
                            Thread.Sleep(200);
                        }
                    }
                }
            }
        }
    }
}
