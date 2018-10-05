using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace TaskManagement.Support.Json
{
    class Json
    {
        private string Text { get; }

        private Json(string text)
        {
            this.Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public static Json From(string url)
        {
            var hc = new HttpClient();
            var res = hc.GetAsync(url);
            var text = res.Result.Content.ReadAsStringAsync().Result;
            return new Json(text);
        }

        public T As<T>()
        {
            var js = new JsonSerializer();
            var jr = new JsonTextReader(new StringReader(this.Text));
            return JsonConvert.DeserializeObject<T>(this.Text);
        }

        public List<T> AsList<T>()
        {
            var js = new JsonSerializer();
            var jr = new JsonTextReader(new StringReader(this.Text));
            return JsonConvert.DeserializeObject<List<T>>(this.Text);
        }
    }
}
