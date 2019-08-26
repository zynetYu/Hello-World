using Grpc.Core;
using Helloworld;
using System;

namespace ZY.RPCService
{
    class Program
    {
        const int Port = 50051;
        static void Main(string[] args)
        {
            //启动RPC服务

            Server server = new Server
            {
                Services = {Greeter.BindService(new RPCServiceImpl()) },
                Ports = { new ServerPort("localhost",Port,ServerCredentials.Insecure)}
            };
            server.Start();
            Console.WriteLine($"RPC服务开始监听，端口号：{Port}");
            Console.WriteLine($"按任意键停止服务");
            //按任意键停止服务
            Console.ReadKey();
            server.ShutdownAsync().Wait();
        }
    }
}
