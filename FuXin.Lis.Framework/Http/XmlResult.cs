using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Serialization;

namespace FuXin.Lis.Framework.Http
{
    /// <summary>
    /// 返回xml各种响应正文
    /// </summary>
    public class XmlResult : IHttpActionResult
    {
        public XmlResult(string content, HttpRequestMessage request)
        {
            _content = content;
            _request = request;
        }
        public HttpRequestMessage Request
        {
            get
            {
                return _request;
            }
        }

        private HttpRequestMessage _request;
        public string Content
        {
            get
            {
                return _content;
            }
        }

        private string _content;
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult<HttpResponseMessage>(Execute());
        }

        internal HttpResponseMessage Execute()
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            try
            {
                httpResponseMessage.Content = new StringContent(Content);
                MediaTypeHeaderValue mediaTypeHeaderValue = new MediaTypeHeaderValue("application/xml");
                mediaTypeHeaderValue.CharSet = Encoding.UTF8.WebName;
                httpResponseMessage.Content.Headers.ContentType = mediaTypeHeaderValue;
                httpResponseMessage.RequestMessage = Request;
            }
            catch
            {
                httpResponseMessage.Dispose();
                throw;
            }
            return httpResponseMessage;
        }
    }

    /// <summary>
    /// 返回xml格式的响应正文
    /// </summary>
    /// <typeparam name="T">要序列化的数据类型</typeparam>
    public class XmlResult<T> : IHttpActionResult
    {

        public XmlResult(T data, HttpRequestMessage request)
        {
            _data = data;
            _request = request;
        }
        public T Data
        {
            get
            {
                return _data;
            }
        }

        private T _data;

        public HttpRequestMessage Request
        {
            get
            {
                return _request;
            }
        }
        private HttpRequestMessage _request;
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult<HttpResponseMessage>(Execute());
        }

        private HttpResponseMessage Execute()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));


                xmlSerializer.Serialize(stream, Data);
                using (StreamReader reader = new StreamReader(stream))
                {
                    string str = reader.ReadToEnd();
                    return new XmlResult(str, Request).Execute();
                }
            }
        }
    }
}
