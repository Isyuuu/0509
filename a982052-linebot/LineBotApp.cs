using Line.Messaging;
using Line.Messaging.Webhooks;

namespace a982052_linebot;

public class LineBotApp : WebhookApplication
{
    private readonly LineMessagingClient _messagingClient;
    public LineBotApp(LineMessagingClient lineMessagingClient)
    {
        _messagingClient = lineMessagingClient;
    }

    protected override async Task OnMessageAsync(MessageEvent ev)
    {
        var result = null as List<ISendMessage>;

        switch (ev.Message)
        {
            //文字訊息
            case TextEventMessage textMessage:
            {
                //頻道Id
                var channelId = ev.Source.Id;
                //使用者Id
                var userId = ev.Source.UserId; 
                
                var text =((TextEventMessage)ev.Message).Text;

                //回傳 hellow
                result = new List<ISendMessage>
                {
                    new TextMessage("這是甜點資訊站~ 一起來了解世界各地的美食")
                };
                if (text.Contains("介紹") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("瑪卡龍（法語：macaron)")
                    };
                }
                
            }
                break;
            
        }

        if (result != null)
            await _messagingClient.ReplyMessageAsync(ev.ReplyToken, result);
    }
}