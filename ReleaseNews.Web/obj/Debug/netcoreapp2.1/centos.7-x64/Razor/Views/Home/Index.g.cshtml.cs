#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63191bd23dd63abf0ba8bc25e3cdfd0ac40ff939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63191bd23dd63abf0ba8bc25e3cdfd0ac40ff939", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5b9b23ede2d135d1779d349fb893e872c87ab0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(56, 2573, true);
            WriteLiteral(@"<div class=""content-wrap"">
    <div class=""content"">
        <div id=""focusslide"" class=""carousel slide"" data-ride=""carousel"">
            <ol class=""carousel-indicators"">
                <li data-target=""#focusslide"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#focusslide"" data-slide-to=""1""></li>
            </ol>
            <div class=""carousel-inner"" role=""listbox"">
            </div>
            <a class=""left carousel-control"" href=""#focusslide"" role=""button"" data-slide=""prev"" rel=""nofollow""> <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span> <span class=""sr-only"">上一个</span> </a> <a class=""right carousel-control"" href=""#focusslide"" role=""button"" data-slide=""next"" rel=""nofollow""> <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span> <span class=""sr-only"">下一个</span> </a>
        </div>

        <div class=""title"">
            <h3>最新发布</h3>
        </div>
        <div id=""home_news"">
        </div>
    </div>
</div>
");
            WriteLiteral(@"<aside class=""sidebar"">
    <div class=""fixed"">
        <div class=""widget widget-tabs"">
            <ul class=""nav nav-tabs"" role=""tablist"">
                <li role=""presentation"" class=""active""><a href=""#notice"" aria-controls=""notice"" role=""tab"" data-toggle=""tab"">统计信息</a></li>
                <li role=""presentation""><a href=""#contact"" aria-controls=""contact"" role=""tab"" data-toggle=""tab"">作者信息</a></li>
            </ul>
            <div class=""tab-content"">
                <div role=""tabpanel"" class=""tab-pane contact active"" id=""notice"">
                    <h2>
                        新闻总数:
                        <text id=""total_news""></text>
                    </h2>
                    <h2>
                        网站新增:
                        <span id=""sitetime"">100个用户 </span>
                    </h2>
                </div>
                <div role=""tabpanel"" class=""tab-pane contact"" id=""contact"">
                    <h2>
                        QQ:XXXXXXXX
                       ");
            WriteLiteral(@" <a href="""" target=""_blank"" rel=""nofollow"" data-toggle=""tooltip"" data-placement=""bottom"" title="""" data-original-title=""QQ:""></a>
                    </h2>
                    <h2>
                        Email:XXXXXXXX@qq.com
                        <a href=""#"" target=""_blank"" data-toggle=""tooltip"" rel=""nofollow"" data-placement=""bottom"" title="""" data-original-title=""#""></a>
                    </h2>
                </div>
            </div>
        </div>
        <div class=""widget widget_search"">
            ");
            EndContext();
            BeginContext(2629, 515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b82f2016e64c4aea88d308673d758dd4", async() => {
                BeginContext(2686, 451, true);
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
            BeginContext(3144, 292, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""widget widget_hot"">
        <h3>最新评论文章</h3>
        <ul id=""new_comment""></ul>
    </div>
    <div class=""widget widget_sentence"">
        <a href=""http://study.163.com/instructor/1025318795.htm"" target=""_blank"" rel=""nofollow"">
            ");
            EndContext();
            BeginContext(3436, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bf89e0fbd79942019bef289abd700a93", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            BeginContext(3489, 180, true);
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n    <div class=\"widget widget_sentence\">\r\n        <a href=\"http://study.163.com/instructor/1025318795.htm\" target=\"_blank\" rel=\"nofollow\">\r\n            ");
            EndContext();
            BeginContext(3669, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "11cde62cc0374af3b8f7176e43c98b67", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3715, 4457, true);
            WriteLiteral(@"
        </a>
    </div>
    <div class=""widget widget_sentence"">
        <h3>友情链接</h3>
        <div class=""widget-sentence-link"">
            <a href=""https://sports.qq.com/nba/"" title=""NBA腾讯体育"" target=""_blank"">NBA腾讯体育官方网站</a>&nbsp;&nbsp;&nbsp;
        </div>
    </div>
</aside>

<script type=""text/javascript"">
    $(function () {
        getBanner();
        getTotalNews();
        getHomeNews();
        getNewCommentNewsList();
    });
    function getBanner() {
        $.ajax({
            type: 'get',
            url: '/Home/GetBanner',
            success: function (data) {
                if (data.code == 200) {
                    $("".carousel-inner"").empty();
                    for (var i = 0; i < data.data.length; i++) {
                        var m = data.data[i];
                        var banner;
                        if (i == 0)
                            banner = '<div class=""item active""><a href = ""' + m.url + '"" target = ""_blank"" ><img src=""' + m.image + '"" ");
            WriteLiteral(@"class=""img-responsive""></a></div>';
                        else
                            banner = '<div class=""item""><a href = ""' + m.url + '"" target = ""_blank"" ><img src=""' + m.image + '"" class=""img-responsive""></a></div>';
                        $("".carousel-inner"").append(banner);
                    }
                }
            }
        });
    }
    function getTotalNews() {
        $.ajax({
            type: 'get',
            url: '/Home/GetTotalNews',
            success: function (data) {
                if (data.code == 200) {
                    $(""#total_news"").text(data.data + ""篇"");;
                }
            }
        });
    }
    function getHomeNews() {
        $.ajax({
            type: 'get',
            url: '/Home/GetHomeNews',
            success: function (data) {
                if (data.code == 200) {
                    $(""#home_news"").empty();
                    for (var i = 0; i < data.data.length; i++) {
                        var m = dat");
            WriteLiteral(@"a.data[i];
                        var news;
                        news = '<article class=""excerpt excerpt-1"" style=""""><a class=""focus"" href = ""/News/Detail?id=' + m.id + '"" title = ""' + m.title + '"" target = ""_blank"" > <img class=""thumb"" data-original=""' + m.image + '"" src=""' + m.image + '"" alt=""' + m.title + '"" style=""display: inline;""></a><header><h2><a href=""/News/Detail?id=' + m.id + '"" title=""' + m.title + '"" target=""_blank"">' + m.title + '</a></h2></header><p class=""meta""><time class=""time""><i class=""glyphicon glyphicon-time""></i> ' + m.publishDate + '</time><a class=""comment"" title=""评论"" target=""_blank""><i class=""glyphicon glyphicon-comment""></i> ' + m.commentCount + '</a></p><p class=""note"">' + m.contents + '</p></article >';
                        $(""#home_news"").append(news);
                    }
                }
            }
        });
    }
    function getNewCommentNewsList() {
        $.ajax({
            type: 'get',
            url: '/Home/GetNewCommentNewsList',
          ");
            WriteLiteral(@"  success: function (data) {
                if (data.code == 200) {
                    $(""#new_comment"").empty();
                    for (var i = 0; i < data.data.length; i++) {
                        var m = data.data[i];
                        var news;
                        news = '<li><a title = ""' + m.title + '"" href = ""/News/Detail?id=' + m.id + '"" ><span class=""thumbnail""><img class=""thumb"" data-original=""' + m.image + '"" src=""' + m.image + '"" alt=""' + m.title + '"" style=""display: block;""></span><span class=""text"">' + m.title + '</span><span class=""muted""><i class=""glyphicon glyphicon-time""></i>' + m.publishDate + '</a></li>';
                        $(""#new_comment"").append(news);
                    }
                }
            }
        });
    }
    function searchOneNews() {
        var keyword = $(""#keyword"").val();
        if (keyword != """" && keyword != null) {
            $.ajax({
                type: 'get',
                url: '/Home/SearchOneNews',
            ");
            WriteLiteral(@"    data: { keyword: keyword },
                success: function (data) {
                    if (data.code == 200) {
                        window.open(""/News/Detail?id="" + data.data);
                    } else {
                        window.open(""/Home/Wrong"");
                    }
                }
            });
        }
    }
</script>");
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
