using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Flot.Mvc.Extensions
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString CreateFlotData<TKey, TValue>(this HtmlHelper htmlHelper, string placeholderId, FlotSeries<TKey, TValue> flotData)
        {
            return CreateFlotData(placeholderId, flotData.Data.ToJson());
        }

        private static MvcHtmlString CreateFlotData(string placeholderId, string jsonData, string chartType = "", string jsonOptions = "")
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("var data = [{0}];", jsonData);
            tag.InnerHtml = stringBuilder.ToString();
            return new MvcHtmlString(tag.ToString());
        }
    }
}
