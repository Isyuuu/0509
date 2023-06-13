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
                if (text.Contains("介紹法國") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("瑪卡龍（法語：macaron）又稱作馬卡龍、法式小圓餅或少女的酥胸，是一種用色彩繽紛絢麗的法國甜點，外殼堅硬但易碎，內餡黏稠扎實，口感奇妙，因為其極度可愛優雅，馬卡龍色也成為了一種時尚配色方案。")
                    };
                }
                if (text.Contains("介紹日本") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("和菓子（日語：わがし），指的是日本人對日本傳統的糯米糰子、冰品、水果製品、甜味內餡、鹹味零食、油炸小點心、蛋糕和餅乾的一個總稱。")
                    };
                }
                if (text.Contains("介紹義大利") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("提拉米蘇（義大利語：Tiramisù），是一種著名的義大利式甜點，它是由泡過咖啡或蘭姆酒的手指餅乾，加上一層馬斯卡彭起司、蛋黃及糖的混合物，然後再在蛋糕表面灑上一層可可粉而成，口感細膩飽滿。")
                    };
                }
                if (text.Contains("介紹美國") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("蘋果派（英語：apple pie），或稱蘋果餡餅，是一種西式水果餡餅，屬於甜點分類，餡料主要材料是蘋果；蘋果派起源於歐洲，但是現在卻是象徵美國文化最具代表性的甜點之一。在西方，許多的場合都用上蘋果派，表面覆蓋了餡餅皮，內裏是切碎的蘋果。製作蘋果派時人們多是加上糖、葡萄乾、肉桂和肉豆蔻等調味品，甚至加上其他的水果和起司。")
                    };
                }
                if (text.Contains("介紹英國") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("奶油酥餅（英語：shortbread），餅乾的標準類型之一，屬於酥質餅乾。一種傳統的蘇格蘭餅乾，通常由白糖、黃油普通小麥粉製成。與許多其他餅乾和烘焙食品不同，酥餅不含發酵粉或小蘇打等任何發酵劑。")
                    };
                }
                if (text.Contains("介紹葡萄牙") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("葡式蛋塔（葡萄牙語：pastel de nata），又稱葡式鮮奶油塔，粵港澳稱葡撻，是一種小型的鮮奶油酥皮餡餅點心，屬於蛋塔的一種，焦黑的表面（是糖過度受熱後的焦糖）為其特徵。廣泛地存在於葡萄牙與葡萄牙語圈國家。")
                    };
                }
                if (text.Contains("介紹台灣") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("雙胞胎，又名兩相好、炸馬耳、喜相逢，一種常見的傳統福州、台灣小吃，以油麵粉製做的油炸甜點。吃起來的口感外皮酥脆、內裡綿密。外型為兩個窩窩頭相連，狀似雙胞胎因而得名。")
                    };
                }
                if (text.Contains("介紹德國") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("黑森林蛋糕（德語：Schwarzwälder Kirschtorte），又稱黑森林櫻桃蛋糕，是一種鮮奶蛋糕，自20世紀30年代起，風行於德國，並逐漸成為全世界最著名和最受歡迎的蛋糕之一。黑森林蛋糕的主要成分有：脆餅麵團底托、鮮奶油、櫻桃酒、黑櫻桃和巧克力碎末。")
                    };
                }
                if (text.Contains("介紹土耳其") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("巴克拉瓦（Baklava），或稱巴拉瓦餅，是一種口味濃郁、甜膩的土耳其酥皮點心。以層層酥皮製成，內餡裹入碎堅果，再搭上甜蜜的糖漿或蜂蜜，是阿拉伯、伊朗國家與前鄂圖曼等地區常見的菜餚。")
                    };
                }
                if (text.Contains("介紹俄羅斯") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("圖拉薑餅（俄語：Ту́льский пря́ник）是一種源自俄羅斯圖拉的點心，是俄式薑餅最著名的品種，餅常呈方型，並以餅模印上各種文字和圖案。材料包括黑麥麵粉、蜂蜜、雞蛋、水和香料，成型後表面塗上糖漿以增加光澤。另外，圖拉薑餅內通常都有餡料，例如是果醬或煉奶。")
                    };
                }
                if (text.Contains("介紹印度") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("萊杜（Laddu或laddoo）是一種來自印度次大陸的球形糖果，由各種成分和糖漿或粗糖製成。它被描述為“可能是最普遍和最古老的印度糖果”。Laddus通常在慶祝活動和宗教節日期間供應，尤其是那些與印度教神像甘尼薩有關的節日。")
                    };
                }
                if (text.Contains("介紹韓國") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("韓菓（韓語：한과）是韓國傳統菓子的泛稱，一般由穀物、麵粉、蜂蜜、糖、水果等原料製作，主要包括茶食（다식）、江米條、油菓、藥菓、熟實果、果片、飴、正果、饅頭菓、梅雀菓等，在韓國通常搭配傳統茶飲一同食用，也是在傳統節日祭拜不可或缺的供品和韓國人過年送禮的禮品之一。")
                    };
                }
                if (text.Contains("介紹巴西") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("brigadeiro（葡萄牙語發音：[bɾiɡaˈdejɾu]）是一種傳統的巴西甜點。這種甜點的起源尚無定論，但最普遍的說法是它是由里約熱內盧的糖果商Heloisa Nabuco de Oliveira 為宣傳Eduardo Gomes的總統候選人而創造的。它由煉乳、可可粉、黃油和覆蓋在外層的 巧克力屑製成。它是全國流行的甜點，特別是在節日活動中。")
                    };
                }
                if (text.Contains("介紹馬來西亞") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("娘惹糕（馬來文：Nyonya Kuih）為娘惹糕點的總稱，流行於馬來西亞、新加坡、汶萊、印尼及泰國南部一帶，其種類及口味繁多，有蒸、炸、烤、甜、鹹、辣等，主要製作原料為糯米、米、木薯粉等，並依照不同的口味添加不同的特殊材料，如班蘭(Pandan)、椰漿、椰絲、綠豆泥、紅豆泥、花生粉、椰糖（Gula Melaka）、叄巴（Sambal）等。大多數娘惹糕因使用糯米粉或木薯粉的緣故，口感較為軟糯，加上早期娘惹善於利用各種植物的汁液為糕點染色，鮮豔的色彩及混合各種香料的強烈香味為娘惹糕的最大特色。")
                    };
                }
                if (text.Contains("介紹荷蘭") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("荷蘭小鬆餅（荷蘭語：Poffertjes），鬆餅的一種，為荷蘭常見的傳統甜食，由酵母和蕎麥粉製成，通常不加任何餡料，口感與台灣的雞蛋糕類似，可再加上巧克力醬、鮮奶油、新鮮水果或者冰淇淋等食用。大小剛好一口一個，通常在市集或是鬧區的街邊販售。")
                    };
                }
                if (text.Contains("介紹西班牙") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("吉拿棒（西班牙語：Churros），是一種西班牙和葡萄牙的油炸麵食，亦在拉丁美洲、法國、美國及加勒比海多個以拉美人為主的島嶼流行，是當地早餐/下午茶時經常會享用的甜品。以麵粉製成的生麵團製作，但亦有用馬鈴薯粉。生麵團透過花邊擠筒擠出來，使吉拿棒帶有花紋，然後再放進油鍋裡炸。炸好的吉拿棒會灑上糖或肉桂粉，就成為一種美味的點心。")
                    };
                }
                if (text.Contains("介紹澳洲") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("萊明頓蛋糕（英語：lamington）是一種澳大利亞蛋糕，由正方形的奶油蛋糕或海綿蛋糕塗在巧克力醬的外層上，然後捲入乾燥的椰子中。稀薄的混合物被吸收到海綿蛋糕的外部並保持固定，從而使海綿蛋糕具有獨特的質地。一種常見的變化形式是在拉明頓兩半之間有一層奶油或草莓果醬。")
                    };
                }
                if (text.Contains("介紹泰國") && text.Contains("甜點"))
                {
                    result = new List<ISendMessage>
                    {
                        new TextMessage("芒果糯米飯（泰語：ข้าวเหนียวมะม่วง），是一種傳統泰國甜點，主要材料為芒果、糯米與椰奶，芒果糯米飯通常在芒果的旺季食用，通常在泰國的夏季，約4-5月之間。。")
                    };
                }
            }
                
                break;
            
        }

        if (result != null)
            await _messagingClient.ReplyMessageAsync(ev.ReplyToken, result);
    }
}