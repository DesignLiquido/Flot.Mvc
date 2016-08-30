using Flot.Mvc.ComplexFlot;
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
        public static MvcHtmlString CreateFlot<TComplexFlotOptions>(this HtmlHelper htmlHelper, string canvasId, ComplexFlotBase<TComplexFlotOptions> complexFlot) where TComplexFlotOptions : ComplexFlotOptions
        {
            return CreateFlot(canvasId, complexFlot.FlotType.ToString(), complexFlot.ComplexData.ToJson(), complexFlot.FlotConfiguration.ToJson());
        }

        private static MvcHtmlString CreateFlot(string canvasId, string flotType, string jsonData, string jsonOptions)
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("var ctx = document.getElementById(\"{0}\").getContext(\"2d\");", canvasId);
            stringBuilder.AppendFormat("var data = JSON.parse('{0}');", jsonData);
            stringBuilder.AppendFormat("var options = JSON.parse('{0}');", jsonOptions);
            stringBuilder.AppendFormat("var {0}_chart = new Chart(ctx).{1}(data, options)", canvasId, flotType);
            tag.InnerHtml = stringBuilder.ToString();
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString CreateFlotData<TKey, TValue>(this HtmlHelper htmlHelper, string placeholderId, FlotSeries<TKey, TValue> flotData)
        {
            return CreateFlotData(placeholderId, flotData.Data.ToJson());
        }

        private static MvcHtmlString CreateFlotData(string placeholderId, string jsonData, string flotType = "", string jsonOptions = "")
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
