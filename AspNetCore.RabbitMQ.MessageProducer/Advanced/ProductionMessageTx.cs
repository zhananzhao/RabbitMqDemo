using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.RabbitMQ.MessageProducer.Advanced
{
    public class ProductionMessageTx
    {
        public static void Show()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "localhost";//RabbitMQ服务在本地运行
            factory.UserName = "guest";//用户名
            factory.Password = "guest";//密码 
            using (var connection = factory.CreateConnection())
            {
                //创建通道channel
                //创建通道channel
                using (var channel = connection.CreateModel())
                {
                    Console.WriteLine("生产者准备就绪....");
                    channel.QueueDeclare(queue: "MessageTxQueue01", durable: true, exclusive: false, autoDelete: false, arguments: null);
                    channel.QueueDeclare(queue: "MessageTxQueue02", durable: true, exclusive: false, autoDelete: false, arguments: null);
                    //声明交换机exchang
                    channel.ExchangeDeclare(exchange: "MessageTxQueueExchange", type: ExchangeType.Direct, durable: true, autoDelete: false, arguments: null);
                    //绑定exchange和queue
                    channel.QueueBind(queue: "MessageTxQueue01", exchange: "MessageTxQueueExchange", routingKey: "MessageTxKey01");
                    channel.QueueBind(queue: "MessageTxQueue02", exchange: "MessageTxQueueExchange", routingKey: "MessageTxKey02");
                    string message = "";
                    //发送消息
                    //在控制台输入消息，按enter键发送消息
                    while (!message.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
                    {
                        message = Console.ReadLine();
                        var body = Encoding.UTF8.GetBytes(message);
                        try
                        {
                            //开启事务机制
                            channel.TxSelect();
                            //发送消息
                            //同时给多个队列发送消息；要么都成功；要么都失败；
                            channel.BasicPublish(exchange: "MessageTxQueueExchange", routingKey: "MessageTxKey01", basicProperties: null, body: body);
                            channel.BasicPublish(exchange: "MessageTxQueueExchange", routingKey: "MessageTxKey02", basicProperties: null, body: body);
                            //事务提交
                            channel.TxCommit();
                            Console.WriteLine($"【{message}】发送到Broke成功！");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"【{message}】发送到Broker失败！");
                            channel.TxRollback(); //事务回滚
                            throw;
                        }
                    }
                    Console.Read();
                }
            }
        }
    }
}
