using AspNetCore.RabbitMQ.MessageConsumer_02.Advanced;
using AspNetCore.RabbitMQ.MessageConsumer_02.ExchangeDemo;
using AspNetCore.RabbitMQ.MessageConsumer_02.MessageConsumer;
using System;

namespace AspNetCore.RabbitMQ.MessageConsumer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region 20200507
                {
                    //发布订阅模式
                    //PublishSubscribeConsumer.Show();
                }
                #endregion

                #region 20200508
                {
                    //DirectExchangeConsumerLogError.Show();
                }
                {
                    //FanoutExchange.Show();
                }
                {
                    TopicExchange.Show();
                }
                #endregion

                #region 20200509
                ConsumptionACKConfirm.Show();
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
