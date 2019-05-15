#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8924a838a270e4d920215b49eeab19096ab3f16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Classify), @"mvc.1.0.view", @"/Views/News/Classify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Classify.cshtml", typeof(AspNetCore.Views_News_Classify))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\_ViewImports.cshtml"
using ReleaseNews.Web;

#line default
#line hidden
#line 2 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\_ViewImports.cshtml"
using ReleaseNews.Web.Models;

#line default
#line hidden
#line 4 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
using ReleaseNews.Models.Response;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8924a838a270e4d920215b49eeab19096ab3f16", @"/Views/News/Classify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5b9b23ede2d135d1779d349fb893e872c87ab0", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Classify : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(91, 125, true);
            WriteLiteral("<div class=\"content-wrap\">\r\n    <div class=\"content\">\r\n        <div class=\"title\">\r\n            <h3 style=\"line-height: 1.3\">");
            EndContext();
            BeginContext(217, 24, false);
#line 8 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                    Write(ViewData["ClassifyName"]);

#line default
#line hidden
            EndContext();
            BeginContext(241, 23, true);
            WriteLiteral("</h3>\r\n        </div>\r\n");
            EndContext();
#line 10 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
          
            var response = ViewData["NewsList"] as ResponseModel;
            if (response.code == 200)
            {
                foreach (var news in response.data)
                {

#line default
#line hidden
            BeginContext(469, 87, true);
            WriteLiteral("                    <article class=\"excerpt\">\r\n                        <a class=\"focus\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 556, "\"", 587, 2);
            WriteAttributeValue("", 563, "/News/Detail?id=", 563, 16, true);
#line 17 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 579, news.Id, 579, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 588, "\"", 607, 1);
#line 17 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 596, news.Title, 596, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(608, 51, true);
            WriteLiteral(" target=\"_blank\"><img class=\"thumb\" data-original=\"");
            EndContext();
            BeginContext(660, 10, false);
#line 17 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                                                                                                                          Write(news.Image);

#line default
#line hidden
            EndContext();
            BeginContext(670, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 671, "\"", 688, 1);
#line 17 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 677, news.Image, 677, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 689, "\"", 706, 1);
#line 17 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 695, news.Title, 695, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(707, 100, true);
            WriteLiteral(" style=\"display: inline;\"></a>\r\n                        <header>\r\n                            <h2><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 807, "\"", 838, 2);
            WriteAttributeValue("", 814, "/News/Detail?id=", 814, 16, true);
#line 19 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 830, news.Id, 830, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 839, "\"", 858, 1);
#line 19 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 847, news.Title, 847, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(859, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(877, 10, false);
#line 19 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                                                                                  Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(887, 176, true);
            WriteLiteral("</a></h2>\r\n                        </header>\r\n                        <p class=\"meta\">\r\n                            <time class=\"time\"><i class=\"glyphicon glyphicon-time\"></i> ");
            EndContext();
            BeginContext(1064, 16, false);
#line 22 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                                                                   Write(news.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(1080, 127, true);
            WriteLiteral("</time>\r\n                            <a class=\"comment\" title=\"评论\" target=\"_blank\"><i class=\"glyphicon glyphicon-comment\"></i> ");
            EndContext();
            BeginContext(1208, 17, false);
#line 23 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                                                                                                 Write(news.CommentCount);

#line default
#line hidden
            EndContext();
            BeginContext(1225, 77, true);
            WriteLiteral("</a>\r\n                        </p>\r\n                        <p class=\"note\"> ");
            EndContext();
            BeginContext(1303, 13, false);
#line 25 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                    Write(news.Contents);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 38, true);
            WriteLiteral("</p>\r\n                    </article>\r\n");
            EndContext();
#line 27 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                }
            }
        

#line default
#line hidden
            BeginContext(1399, 126, true);
            WriteLiteral("    </div>\r\n</div>\r\n<aside class=\"sidebar\">\r\n    <div class=\"fixed\">\r\n        <div class=\"widget widget_search\">\r\n            ");
            EndContext();
            BeginContext(1525, 515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ee827ca3e04ffb800a068569be7ed0", async() => {
                BeginContext(1582, 451, true);
                WriteLiteral(@"
                <div class=""input-group"">
                    <input type=""text"" name=""keyword"" id=""keyword"" class=""form-control"" size=""35"" placeholder=""请输入关键字"" maxlength=""15"" autocomplete=""off"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-default btn-search"" name=""search"" type=""button"" onclick=""searchOneNews()"">搜索</button>
                    </span>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2040, 108, true);
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"widget widget_hot\">\r\n        <h3>最新评论文章</h3>\r\n        <ul>\r\n");
            EndContext();
#line 49 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
              
                var newCommentNews = ViewData["NewCommentNews"] as ResponseModel;
                if (response.code == 200)
                {
                    foreach (var news in newCommentNews.data)
                    {

#line default
#line hidden
            BeginContext(2395, 60, true);
            WriteLiteral("                        <li>\r\n                            <a");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2455, "\"", 2474, 1);
#line 56 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 2463, news.Title, 2463, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 2475, "\"", 2506, 2);
            WriteAttributeValue("", 2482, "/News/Detail?id=", 2482, 16, true);
#line 56 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 2498, news.Id, 2498, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2507, 131, true);
            WriteLiteral(">\r\n                                <span class=\"thumbnail\">\r\n                                    <img class=\"thumb\" data-original=\"");
            EndContext();
            BeginContext(2639, 10, false);
#line 58 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                                                 Write(news.Image);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2650, "\"", 2667, 1);
#line 58 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 2656, news.Image, 2656, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2668, "\"", 2685, 1);
#line 58 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
WriteAttributeValue("", 2674, news.Title, 2674, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2686, 85, true);
            WriteLiteral(" style=\"display: block;\">\r\n                                </span><span class=\"text\">");
            EndContext();
            BeginContext(2772, 10, false);
#line 59 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                                                     Write(news.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2782, 143, true);
            WriteLiteral("</span><span class=\"muted\">\r\n                                    <i class=\"glyphicon glyphicon-time\"></i>\r\n                                    ");
            EndContext();
            BeginContext(2926, 16, false);
#line 61 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                               Write(news.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(2942, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 63 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Classify.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(3032, 1150, true);
            WriteLiteral(@"        </ul>
    </div>
    <div class=""widget widget_sentence"">
        <a href=""http://study.163.com/instructor/1025318795.htm"" target=""_blank"" rel=""nofollow"">
            <img style=""width: 100%"" src=""/images/201610241224221511.jpg"" alt=""专业网站建设"">
        </a>
    </div>
    <div class=""widget widget_sentence"">
        <a href=""http://study.163.com/instructor/1025318795.htm"" target=""_blank"" rel=""nofollow"">
            <img style=""width: 100%"" src=""/images/ad.jpg"">
        </a>
    </div>
</aside>


<script type=""text/javascript"">
    function searchOneNews() {
        var keyword = $(""#keyword"").val();
        if (keyword != """" && keyword != null) {
            $.ajax({
                type: 'get',
                url: '/Home/SearchOneNews',
                data: { keyword: keyword },
                success: function (data) {
                    if (data.code == 200) {
                        window.open(""/News/Detail?id="" + data.data);
                    } else {
             ");
            WriteLiteral("           window.open(\"/Home/Wrong\");\r\n                    }\r\n                }\r\n            });\r\n        }\r\n    }\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
