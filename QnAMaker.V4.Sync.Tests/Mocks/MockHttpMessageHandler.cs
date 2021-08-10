using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace QnAMaker.V4.Sync.Tests.Mocks
{
    public class MockHttpMessageHandler : Mock<HttpMessageHandler>
    {
        public MockHttpMessageHandler MockSendAsyncReturnsOkRequest()
        {
            var responseMessage = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK
            };

            MockSendAsyncWithContent(responseMessage);
            return this;
        }

        public MockHttpMessageHandler MockSendAsyncWithContentReturnsOkRequest(string content)
        {
            var responseMessage = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(content)
            };

            MockSendAsyncWithContent(responseMessage);
            return this;
        }

        public MockHttpMessageHandler MockSendAsyncReturnsBadRequest()
        {
            var responseMessage = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.BadRequest
            };

            MockSendAsyncWithContent(responseMessage);
            return this;
        }

        public MockHttpMessageHandler MockSendAsyncWithContentReturnsBadRequest(string content)
        {
            var responseMessage = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.BadRequest,
                Content = new StringContent(content)
            };

            MockSendAsyncWithContent(responseMessage);
            return this;
        }

        private MockHttpMessageHandler MockSendAsyncWithContent(HttpResponseMessage responseMessage)
        {
            this.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(responseMessage)
                .Verifiable();

            return this;
        }
    }
}
