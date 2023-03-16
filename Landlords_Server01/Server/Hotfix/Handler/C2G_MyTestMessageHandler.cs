using System;
using System.Net;
using ETModel;

namespace ETHotfix
{
    [MessageHandler(AppType.Gate)]
    public class C2G_MyTestMessageHandler : AMRpcHandler<C2G_MyTestMessage, G2C_MyTestMessage>
    {
        protected override async ETTask Run(Session session, C2G_MyTestMessage request, G2C_MyTestMessage response, Action reply)
        {
            response.Message = "Client Friend，Message Received<<===";
            reply();
        }
    }
}
