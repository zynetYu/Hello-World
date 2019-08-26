using Grpc.Core;
using Helloworld;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ZY.RPCService
{
    class RPCServiceImpl:Greeter.GreeterBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply { Message = "你好" + request.Name });
        }
    }
}
