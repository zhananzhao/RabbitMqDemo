using AspNetCore.RabbitMQ.MessageProducer.Advanced;
using AspNetCore.RabbitMQ.MessageProducer.ExchangeDemo;
using AspNetCore.RabbitMQ.MessageProducer.MessageProducer;
using System;
using System.Threading.Tasks;

namespace AspNetCore.RabbitMQ.MessageProducer
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
                    //多生产者消费者
                    //Task.Run(() => { MultiProductionConsumer.Show01(); });
                    //Task.Run(() => { MultiProductionConsumer.Show02(); });
                    //Task.Run(() => { MultiProductionConsumer.Show03(); });
                }
                {
                    //互为生产者消费者
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
                    //DirectExchange.Show();
                }
                {
                    //FanoutExchange.Show();
                }
                {
                    //TopicExchange.Show();
                }
                {
                    //HeaderExchange.Show();
                }
                #endregion

                #region 20200509
                {
                   //PriorityQueue.Show();
                }
                {
                    //ProductionMessageTx.Show();
                }
                {
                    //ProductionMessageConfirm.Show();
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
        }
    }
}
