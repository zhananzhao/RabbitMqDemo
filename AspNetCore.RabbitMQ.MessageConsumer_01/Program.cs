using AspNetCore.RabbitMQ.MessageConsumer_01.Advanced;
using AspNetCore.RabbitMQ.MessageConsumer_01.ExchangeDemo;
using AspNetCore.RabbitMQ.MessageConsumer_01.MessageConsumer;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.RabbitMQ.MessageConsumer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                #region 20200507
                {
                    //生产者消费者
                    //ProductionConsumer.Show();
                }

                {
                    //多生产消费者
                    //Task.Run(() => { MultiProductionConsumer.Show01(); });
                    //Task.Run(() => { MultiProductionConsumer.Show02(); });
                    //Task.Run(() => { MultiProductionConsumer.Show03(); });
                }
                {
                    //互为生产消费者
                    //Task.Run(() => { MutualProductionConsumer.ShowProductio(); });
                    //Task.Run(() => { MutualProductionConsumer.ShowConsumer(); });
                }

                {
                    //发布订阅模式
                    //PublishSubscribeConsumer.Show();
                }
                {
                    //秒杀
                    //SeckillConsumer.Show();
                }
                #endregion

                #region 20200508
                {
                    //DirectExchangeConsumerLogAll.Show();
                }
                {
                    //FanoutExchange.Show();
                }
                {
                    //TopicExchange.Show();
                }
                #endregion

                #region 20200509
                {
                   //PriorityQueue.Show();
                }
                {
                   ConsumptionACKConfirm.Show();
                }
                #endregion

                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
