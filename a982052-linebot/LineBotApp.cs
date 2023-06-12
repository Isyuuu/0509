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
                    new TextMessage("這是甜點資訊站 ~ ~ 一起來了解世界各地的美食!")
                };
                if (text.Contains("介紹") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("瑪卡龍（法語：macaron)又稱作馬卡龍、法式小圓餅或少女的酥胸，是一種用色彩繽紛絢麗的法國甜點，外殼堅硬但易碎，內餡黏稠扎實，口感奇妙，因為其極度可愛優雅，馬卡龍色也成為了一種時尚配色方案。")
                    };
                    {   new TextMessage("和菓子（日語：わがし ），指的是日本人對日本傳統的糯米糰子、冰品、水果製品、甜味內餡、鹹味零食、油炸小點心、蛋糕和餅乾的一個總稱。");
                    };
                }
                
            }
                break;
            
        }

        if (result != null)
            await _messagingClient.ReplyMessageAsync(ev.ReplyToken, result);
    }
}