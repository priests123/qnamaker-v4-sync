using QnAMaker.V4.Sync.Models.KB;
using QnAMaker.V4.Sync.Models.Settings;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace QnAMaker.V4.Sync.HttpClients
{
    public class QnAHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly KnowledgeBaseSettings _kbSettings;

        public QnAHttpClient(KnowledgeBaseSettings kbSettings, HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", kbSettings.SubscriptionKey);
            httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
            _httpClient = httpClient;
            _kbSettings = kbSettings;
        }

        public async Task<KnowledgeBaseModel> GetCurrentKnowledgeBase()
        {

        }
    }
}
