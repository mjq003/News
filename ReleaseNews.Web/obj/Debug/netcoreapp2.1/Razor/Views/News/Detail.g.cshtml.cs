#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef47313eb5e833327a18c2e249e97a0fe495d0a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Detail), @"mvc.1.0.view", @"/Views/News/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Detail.cshtml", typeof(AspNetCore.Views_News_Detail))]
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
#line 5 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
using ReleaseNews.Models.Response;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef47313eb5e833327a18c2e249e97a0fe495d0a3", @"/Views/News/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5b9b23ede2d135d1779d349fb893e872c87ab0", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    int id = 0;

#line default
#line hidden
            BeginContext(108, 55, true);
            WriteLiteral("<div class=\"content-wrap\">\r\n    <div class=\"content\">\r\n");
            EndContext();
#line 8 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
          
            var response = ViewData["News"] as ResponseModel;
            id = response.data.Id;

#line default
#line hidden
            BeginContext(274, 98, true);
            WriteLiteral("            <header class=\"article-header\">\r\n                <h1 class=\"article-title\"><a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 372, "\"", 400, 1);
#line 12 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
WriteAttributeValue("", 380, response.data.Title, 380, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(401, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(403, 19, false);
#line 12 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                              Write(response.data.Title);

#line default
#line hidden
            EndContext();
            BeginContext(422, 238, true);
            WriteLiteral("</a></h1>\r\n                <div class=\"article-meta\">\r\n                    <span class=\"item article-meta-time\">\r\n                        <time class=\"time\" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"\" data-original-title=\"发表时间：");
            EndContext();
            BeginContext(661, 25, false);
#line 15 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                                                       Write(response.data.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(686, 43, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-time\"></i> ");
            EndContext();
            BeginContext(730, 25, false);
#line 15 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                                                                                                                            Write(response.data.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(755, 154, true);
            WriteLiteral("</time>\r\n                    </span> <span class=\"item article-meta-category\" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"\" data-original-title=\"");
            EndContext();
            BeginContext(910, 26, false);
#line 16 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                                                                            Write(response.data.ClassifyName);

#line default
#line hidden
            EndContext();
            BeginContext(936, 54, true);
            WriteLiteral("\"><i class=\"glyphicon glyphicon-list\"></i> <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 990, "\"", 1025, 1);
#line 16 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
WriteAttributeValue("", 998, response.data.ClassifyName, 998, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1026, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1028, 26, false);
#line 16 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                                                                                                                                                                                                  Write(response.data.ClassifyName);

#line default
#line hidden
            EndContext();
            BeginContext(1054, 178, true);
            WriteLiteral("</a></span>  <span class=\"item article-meta-comment\" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"\" data-original-title=\"评论量\"><i class=\"glyphicon glyphicon-comment\"></i> ");
            EndContext();
            BeginContext(1233, 26, false);
#line 16 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(response.data.CommentCount);

#line default
#line hidden
            EndContext();
            BeginContext(1259, 142, true);
            WriteLiteral("</span>\r\n                </div>\r\n            </header>\r\n            <article class=\"article-content\">\r\n                <p><img data-original=\"");
            EndContext();
            BeginContext(1402, 19, false);
#line 20 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                  Write(response.data.Image);

#line default
#line hidden
            EndContext();
            BeginContext(1421, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1422, "\"", 1448, 1);
#line 20 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
WriteAttributeValue("", 1428, response.data.Image, 1428, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1449, 57, true);
            WriteLiteral(" alt=\"\" /></p>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1507, 22, false);
#line 22 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
               Write(response.data.Contents);

#line default
#line hidden
            EndContext();
            BeginContext(1529, 953, true);
            WriteLiteral(@"
                </p>

                <div class=""bdsharebuttonbox""><a href=""#"" class=""bds_more"" data-cmd=""more""></a><a href=""#"" class=""bds_qzone"" data-cmd=""qzone"" title=""分享到QQ空间""></a><a href=""#"" class=""bds_tsina"" data-cmd=""tsina"" title=""分享到新浪微博""></a><a href=""#"" class=""bds_tqq"" data-cmd=""tqq"" title=""分享到腾讯微博""></a><a href=""#"" class=""bds_weixin"" data-cmd=""weixin"" title=""分享到微信""></a><a href=""#"" class=""bds_tieba"" data-cmd=""tieba"" title=""分享到百度贴吧""></a><a href=""#"" class=""bds_sqq"" data-cmd=""sqq"" title=""分享到QQ好友""></a></div>

                <script>window._bd_share_config = { ""common"": { ""bdSnsKey"": {}, ""bdText"": """", ""bdMini"": ""2"", ""bdMiniList"": false, ""bdPic"": """", ""bdStyle"": ""1"", ""bdSize"": ""32"" }, ""share"": {} }; with (document) 0[(getElementsByTagName('head')[0] || body).appendChild(createElement('script')).src = 'http://bdimg.share.baidu.com/static/api/js/share.js?v=0.js?cdnversion=' + ~(-new Date() / 36e5)];</script>
            </article>
");
            EndContext();
            BeginContext(2493, 117, true);
            WriteLiteral("\r\n        <div class=\"relates\">\r\n            <div class=\"title\">\r\n                <h3>相关推荐</h3>\r\n            </div>\r\n");
            EndContext();
#line 35 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
              
                var recommonds = ViewData["RecommendNews"] as ResponseModel;

#line default
#line hidden
            BeginContext(2704, 22, true);
            WriteLiteral("                <ul>\r\n");
            EndContext();
#line 38 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                     if (recommonds.code == 200)
                    {
                        foreach (var recommond in recommonds.data)
                        {

#line default
#line hidden
            BeginContext(2894, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2928, "\"", 2964, 2);
            WriteAttributeValue("", 2935, "/News/Detail?id=", 2935, 16, true);
#line 42 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
WriteAttributeValue("", 2951, recommond.Id, 2951, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2965, "\"", 2989, 1);
#line 42 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
WriteAttributeValue("", 2973, recommond.Title, 2973, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2990, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2992, 15, false);
#line 42 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                            Write(recommond.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3007, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 43 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3068, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
            BeginContext(3106, 139, true);
            WriteLiteral("        </div>\r\n        <div class=\"title\" id=\"comment\">\r\n            <h3>评论</h3>\r\n        </div>\r\n        <div id=\"respond\">\r\n            ");
            EndContext();
            BeginContext(3245, 961, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce1b553d052147f7a950cf1802090a50", async() => {
                BeginContext(3313, 886, true);
                WriteLiteral(@"
                <div class=""comment"">
                    <div class=""comment-box"">
                        <textarea placeholder=""您的评论或留言（必填）"" name=""comment-textarea"" id=""comment-textarea"" cols=""100%"" rows=""3"" tabindex=""3""></textarea>
                        <div class=""comment-ctrl"">
                            <div class=""comment-prompt"" style=""display: none;""> <i class=""fa fa-spin fa-circle-o-notch""></i> <span class=""comment-prompt-text"">评论正在提交中...请稍后</span> </div>
                            <div class=""comment-success"" style=""display: none;""> <i class=""fa fa-check""></i> <span class=""comment-prompt-text"">评论提交成功...</span> </div>
                            <button type=""button"" name=""comment-submit"" id=""comment-submit"" onclick=""addComment()"" tabindex=""4"">评论</button>
                        </div>
                    </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4206, 109, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <div id=\"postcomments\">\r\n            <ol id=\"comment_list\" class=\"commentlist\">\r\n");
            EndContext();
#line 68 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                  
                    var comments = ViewData["Comments"] as ResponseModel;
                    if (comments.code == 200)
                    {
                        foreach (var comment in comments.data)
                        {

#line default
#line hidden
            BeginContext(4571, 80, true);
            WriteLiteral("                            <li class=\"comment-content\"><span class=\"comment-f\">");
            EndContext();
            BeginContext(4652, 13, false);
#line 74 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                           Write(comment.Floor);

#line default
#line hidden
            EndContext();
            BeginContext(4665, 112, true);
            WriteLiteral("</span><div class=\"comment-main\"><p><a class=\"address\" rel=\"nofollow\" target=\"_blank\">匿名</a><span class=\"time\">(");
            EndContext();
            BeginContext(4778, 15, false);
#line 74 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                                                                                                                                         Write(comment.AddTime);

#line default
#line hidden
            EndContext();
            BeginContext(4793, 12, true);
            WriteLiteral(")</span><br>");
            EndContext();
            BeginContext(4806, 16, false);
#line 74 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                                                                                                                                                                                                                                     Write(comment.Contents);

#line default
#line hidden
            EndContext();
            BeginContext(4822, 17, true);
            WriteLiteral("</p></div></li>\r\n");
            EndContext();
#line 75 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                        }
                    }
                

#line default
#line hidden
            BeginContext(4908, 1858, true);
            WriteLiteral(@"            </ol>
        </div>
    </div>
</div>
<aside class=""sidebar"">
    <div class=""fixed"">
        <div class=""widget widget-tabs"">
            <ul class=""nav nav-tabs"" role=""tablist"">
                <li role=""presentation"" class=""active""><a href=""#notice"" aria-controls=""notice"" role=""tab"" data-toggle=""tab"" draggable=""false"">统计信息</a></li>
                <li role=""presentation""><a href=""#contact"" aria-controls=""contact"" role=""tab"" data-toggle=""tab"" draggable=""false"">联系站长</a></li>
            </ul>
            <div class=""tab-content"">
                <div role=""tabpanel"" class=""tab-pane contact active"" id=""notice"">
                    <h2>
                        新闻总数:
                        888篇
                    </h2>
                    <h2>
                        网站运行:
                        <span id=""sitetime"">5年以上 </span>
                    </h2>
                </div>
                <div role=""tabpanel"" class=""tab-pane contact"" id=""contact"">
                    <h");
            WriteLiteral(@"2>
                        QQ:
                        <a href="""" target=""_blank"" rel=""nofollow"" data-toggle=""tooltip"" data-placement=""bottom"" title="""" draggable=""false"" data-original-title=""QQ:2835806641"">xxxxxxxx</a>
                    </h2>
                    <h2>
                        Email:
                        <a href=""mailto:xxxx@qq.com"" target=""_blank"" data-toggle=""tooltip"" rel=""nofollow"" data-placement=""bottom"" title="""" draggable=""false"" data-original-title=""Email:2835806641@qq.com"">xxxxxxx@qq.com</a>
                    </h2>
                </div>
            </div>
        </div>

    </div>
    <div class=""widget widget_hot"">

    </div>
    <div class=""widget widget_sentence"">
        <a href=""http://study.163.com/instructor/1025318795.htm"" target=""_blank"" rel=""nofollow"">
            ");
            EndContext();
            BeginContext(6766, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "46e994afaf9549c58f6825853be9cdae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6812, 180, true);
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n    <div class=\"widget widget_sentence\">\r\n        <a href=\"http://study.163.com/instructor/1025318795.htm\" target=\"_blank\" rel=\"nofollow\">\r\n            ");
            EndContext();
            BeginContext(6992, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f629d570c03c45f1bb820cc82703925d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7038, 456, true);
            WriteLiteral(@"
        </a>
    </div>
</aside>
<script src=""/js/bootstrap.min.js""></script>
<script src=""/js/jquery.ias.js""></script>
<script src=""/js/scripts.js""></script>
<script type=""text/javascript"">
    function addComment() {
        var content = $(""#comment-textarea"").val();
        if (content != """" && content != null) {
            $.ajax({
                type: 'post',
                url: '/News/AddComment',
                data:{ NewsId:");
            EndContext();
            BeginContext(7495, 2, false);
#line 138 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\News\Detail.cshtml"
                         Write(id);

#line default
#line hidden
            EndContext();
            BeginContext(7497, 696, true);
            WriteLiteral(@", Contents: content},
                success: function (data) {
                    if (data.code == 200) {
                        $(""#comment-textarea"").val('');
                        var html = '<li class=""comment-content""><span class=""comment-f"">' + data.data.floor + '</span><div class=""comment-main""><p><a class=""address"" rel=""nofollow"" target=""_blank"">匿名</a><span class=""time"">(' + data.data.addTime + ')</span><br>' + data.data.contents + '</p></div></li>';
                        $(""#comment_list"").prepend(html);
                    } else {
                        alert(data.result);
                    }
                }
            });
        }
    }
</script>
");
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
