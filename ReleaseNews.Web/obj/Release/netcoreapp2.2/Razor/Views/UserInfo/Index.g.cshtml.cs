#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9794404534d7f53981c4672a3c4e769dc0ebdd07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserInfo_Index), @"mvc.1.0.view", @"/Views/UserInfo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserInfo/Index.cshtml", typeof(AspNetCore.Views_UserInfo_Index))]
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
#line 5 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
using ReleaseNews.Models.Response;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9794404534d7f53981c4672a3c4e769dc0ebdd07", @"/Views/UserInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5b9b23ede2d135d1779d349fb893e872c87ab0", @"/Views/_ViewImports.cshtml")]
    public class Views_UserInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    int id = 0;

#line default
#line hidden
            BeginContext(108, 55, true);
            WriteLiteral("<div class=\"content-wrap\">\r\n    <div class=\"content\">\r\n");
            EndContext();
#line 8 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
          
            var response = ViewData["Users"] as ResponseModel;
            id = response.data.F_UserId;

#line default
#line hidden
            BeginContext(281, 89, true);
            WriteLiteral("            <header class=\"article-header\">\r\n                <span class=\"article-title\">");
            EndContext();
            BeginContext(371, 24, false);
#line 12 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                                       Write(response.data.F_RealName);

#line default
#line hidden
            EndContext();
            BeginContext(395, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 13 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                 if (@response.data.F_Sex == "男")
                {

#line default
#line hidden
            BeginContext(474, 88, true);
            WriteLiteral("                    <span class=\"article-title\" style=\"color:cornflowerblue;\">♂</span>\r\n");
            EndContext();
#line 16 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(622, 81, true);
            WriteLiteral("                    <span class=\"article-title\" style=\"color:hotpink;\">♀</span>\r\n");
            EndContext();
#line 20 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(722, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 21 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                 if (ViewBag.Type == 1)
                {

#line default
#line hidden
            BeginContext(782, 786, true);
            WriteLiteral(@"                    <div class=""article-meta"">
                        <span class=""item article-meta-time"" style=""font-size:15px;"">
                            <a onclick=""addfollow()""><i class=""glyphicon glyphicon-ok"" style=""color:darkturquoise;""></i> 关注此人</a>
                        </span>
                        <span class=""item article-meta-comment"" data-toggle=""tooltip"" data-placement=""bottom"" title="""" style=""font-size:15px;"">
                            <a onclick=""deletefollow()""><i class=""glyphicon glyphicon-remove"" style=""color:orangered;""></i> 取消关注</a>
                        </span>
                        <span class=""item article-meta-comment"" data-toggle=""tooltip"" data-placement=""bottom"" title="""" style=""font-size:15px;"">
                            <a");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 1568, "\"", 1640, 3);
            WriteAttributeValue("", 1578, "sendMessage(\'550\',\'410\',\'发送消息\',\'/UserInfo/SendMessage?Id=", 1578, 57, true);
#line 31 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 1635, id, 1635, 3, false);

#line default
#line hidden
            WriteAttributeValue("", 1638, "\')", 1638, 2, true);
            EndWriteAttribute();
            BeginContext(1641, 147, true);
            WriteLiteral("><i class=\"glyphicon glyphicon-envelope\" style=\"color:cornflowerblue;\"></i> 发送消息</a>\r\n                        </span>\r\n                    </div>\r\n");
            EndContext();
#line 34 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1807, 23, true);
            WriteLiteral("            </header>\r\n");
            EndContext();
            BeginContext(1832, 86, true);
            WriteLiteral("            <article class=\"article-content\">\r\n                <p><img data-original=\"");
            EndContext();
            BeginContext(1919, 21, false);
#line 38 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                                  Write(response.data.F_Image);

#line default
#line hidden
            EndContext();
            BeginContext(1940, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1941, "\"", 1969, 1);
#line 38 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 1947, response.data.F_Image, 1947, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1970, 91, true);
            WriteLiteral(" alt=\"\" style=\"width:200px;height:200px;\" /></p>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(2062, 22, false);
#line 40 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
               Write(response.data.F_Remark);

#line default
#line hidden
            EndContext();
            BeginContext(2084, 48, true);
            WriteLiteral("\r\n                </p>\r\n            </article>\r\n");
            EndContext();
#line 43 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
             if (ViewBag.Type == 0)
            {

#line default
#line hidden
            BeginContext(2184, 176, true);
            WriteLiteral("                <div style=\"display:-webkit-flex;-webkit-justify-content:center;-webkit-align-items:center;\">\r\n                    <button type=\"button\" class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2360, "\"", 2435, 3);
            WriteAttributeValue("", 2370, "sendMessage(\'700\',\'500\',\'修改头像\',\'/UserInfo/UpdateUserInfo?Id=", 2370, 60, true);
#line 46 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 2430, id, 2430, 3, false);

#line default
#line hidden
            WriteAttributeValue("", 2433, "\')", 2433, 2, true);
            EndWriteAttribute();
            BeginContext(2436, 68, true);
            WriteLiteral("><i class=\"icon-search\"></i> 编辑资料</button>\r\n                </div>\r\n");
            EndContext();
#line 48 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2530, 86, true);
            WriteLiteral("\r\n        <div class=\"relates\">\r\n            <div class=\"title\">\r\n                <h3>");
            EndContext();
            BeginContext(2617, 20, false);
#line 53 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
               Write(ViewData["UserType"]);

#line default
#line hidden
            EndContext();
            BeginContext(2637, 27, true);
            WriteLiteral("</h3>\r\n            </div>\r\n");
            EndContext();
#line 55 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
              
                var recommonds = ViewData["PublishNews"] as ResponseModel;

#line default
#line hidden
            BeginContext(2756, 22, true);
            WriteLiteral("                <ul>\r\n");
            EndContext();
#line 58 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                     if (recommonds.code == 200)
                    {
                        foreach (var recommond in recommonds.data)
                        {

#line default
#line hidden
            BeginContext(2946, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2980, "\"", 3016, 2);
            WriteAttributeValue("", 2987, "/News/Detail?id=", 2987, 16, true);
#line 62 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 3003, recommond.Id, 3003, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3017, "\"", 3041, 1);
#line 62 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 3025, recommond.Title, 3025, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3042, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(3060, 15, false);
#line 62 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                                                                                                            Write(recommond.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3075, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 63 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3136, 23, true);
            WriteLiteral("                </ul>\r\n");
            EndContext();
            BeginContext(3174, 217, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<aside class=\"sidebar\">\r\n    <div class=\"fixed\">\r\n        <h2 style=\"font-size: 28px;margin:17px 0; margin-left :80px;font-family: \'TaurusNormal\';\">\r\n            粉丝:\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3391, "\"", 3429, 3);
            WriteAttributeValue("", 3398, "/UserInfo/Follow?Id=", 3398, 20, true);
#line 74 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 3418, id, 3418, 3, false);

#line default
#line hidden
            WriteAttributeValue("", 3421, "&&type=0", 3421, 8, true);
            EndWriteAttribute();
            BeginContext(3430, 126, true);
            WriteLiteral(" target=\"_blank\" rel=\"nofollow\" data-toggle=\"tooltip\" data-placement=\"bottom\" title=\"\" draggable=\"false\" data-original-title=\"");
            EndContext();
            BeginContext(3557, 16, false);
#line 74 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                                                                                                                                                                              Write(ViewData["Funs"]);

#line default
#line hidden
            EndContext();
            BeginContext(3573, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(3576, 16, false);
#line 74 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                                                                                                                                                                                                 Write(ViewData["Funs"]);

#line default
#line hidden
            EndContext();
            BeginContext(3592, 151, true);
            WriteLiteral("</a>\r\n        </h2>\r\n        <h2 style=\"font-size: 28px;margin: 17px 0;margin-left:80px;font-family: \'TaurusNormal\';\">\r\n            关注:\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3743, "\"", 3781, 3);
            WriteAttributeValue("", 3750, "/UserInfo/Follow?Id=", 3750, 20, true);
#line 78 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
WriteAttributeValue("", 3770, id, 3770, 3, false);

#line default
#line hidden
            WriteAttributeValue("", 3773, "&&type=1", 3773, 8, true);
            EndWriteAttribute();
            BeginContext(3782, 126, true);
            WriteLiteral(" target=\"_blank\" data-toggle=\"tooltip\" rel=\"nofollow\" data-placement=\"bottom\" title=\"\" draggable=\"false\" data-original-title=\"");
            EndContext();
            BeginContext(3909, 18, false);
#line 78 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                                                                                                                                                                              Write(ViewData["Follow"]);

#line default
#line hidden
            EndContext();
            BeginContext(3927, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(3930, 18, false);
#line 78 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                                                                                                                                                                                                   Write(ViewData["Follow"]);

#line default
#line hidden
            EndContext();
            BeginContext(3948, 238, true);
            WriteLiteral("</a>\r\n        </h2>\r\n\r\n    </div>\r\n    <div class=\"widget widget_hot\">\r\n\r\n    </div>\r\n    <div class=\"widget widget_sentence\">\r\n        <a href=\"http://study.163.com/instructor/1025318795.htm\" target=\"_blank\" rel=\"nofollow\">\r\n            ");
            EndContext();
            BeginContext(4186, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9794404534d7f53981c4672a3c4e769dc0ebdd0718185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4232, 180, true);
            WriteLiteral("\r\n        </a>\r\n    </div>\r\n    <div class=\"widget widget_sentence\">\r\n        <a href=\"http://study.163.com/instructor/1025318795.htm\" target=\"_blank\" rel=\"nofollow\">\r\n            ");
            EndContext();
            BeginContext(4412, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9794404534d7f53981c4672a3c4e769dc0ebdd0719636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4458, 512, true);
            WriteLiteral(@"
        </a>
    </div>
</aside>
<script src=""/js/bootstrap.min.js""></script>
<script src=""/js/jquery.ias.js""></script>
<script src=""/js/scripts.js""></script>
<script src=""/admin/js/H-ui.admin.js""></script>
<script src=""/admin/layer/layer.min.js""></script>
<script src=""/admin/js/H-ui.js""></script>
<script type=""text/javascript"">
    function addfollow() {
        $.ajax({
            type: 'post',
            async: true,
            url: '/UserInfo/Addfollow',
            data: { followId:");
            EndContext();
            BeginContext(4971, 2, false);
#line 108 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                        Write(id);

#line default
#line hidden
            EndContext();
            BeginContext(4973, 424, true);
            WriteLiteral(@" },
            success: function (data) {
                if (data.code == 200) {
                    alert(data.result);
                } else {
                    alert(data.result);
                }
            }
        });
    }
     function deletefollow() {
        $.ajax({
            type: 'post',
            async: true,
            url: '/UserInfo/Deletefollow',
            data: { followId:");
            EndContext();
            BeginContext(5398, 2, false);
#line 123 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\UserInfo\Index.cshtml"
                        Write(id);

#line default
#line hidden
            EndContext();
            BeginContext(5400, 259, true);
            WriteLiteral(@" },
            success: function (data) {
                if (data.code == 200) {
                    alert(data.result);
                } else {
                    alert(data.result);
                }
            }
        });
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