#pragma checksum "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc8bccb3d027daab7a23bce71b49c999995dd99f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8bccb3d027daab7a23bce71b49c999995dd99f", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c5b9b23ede2d135d1779d349fb893e872c87ab0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReleaseNews.Models.Response.ResponseModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form visible-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 38, true);
            WriteLiteral("<!doctype html>\r\n<html lang=\"zh-CN\">\r\n");
            EndContext();
            BeginContext(88, 1373, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "541ffcb255004ff79783da9d97429c68", async() => {
                BeginContext(94, 219, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"renderer\" content=\"webkit\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>");
                EndContext();
                BeginContext(314, 17, false);
#line 9 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(331, 1123, true);
                WriteLiteral(@"</title>
    <meta name=""keywords"" content="""">
    <meta name=""description"" content="""">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/bootstrap.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/nprogress.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/style.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/css/font-awesome.min.css"">
    <link rel=""apple-touch-icon-precomposed"" href=""/images/icon.png"">
    <link rel=""shortcut icon"" href=""/images/favicon.ico"">
    <script src=""/js/jquery-2.1.4.min.js""></script>
    <script src=""/js/nprogress.js""></script>
    <script src=""/js/jquery.lazyload.min.js""></script>
    <!--[if gte IE 9]>
      <script src=""/js/jquery-1.11.1.min.js"" type=""text/javascript""></script>
      <script src=""/js/html5shiv.min.js"" type=""text/javascript""></script>
      <script src=""/js/respond.min.js"" type=""text/javascript""></script>
      <script src=""/js/selectivizr-min.js"" type=""text/javascript""></script>
    <![endif]-->
    <!--[if");
                WriteLiteral(" lt IE 9]>\r\n      <script>window.location.href=\'upgrade-browser.html\';</script>\r\n    <![endif]-->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1461, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1463, 2354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866c5d9acd4d434bb79952a8178c04a9", async() => {
                BeginContext(1489, 455, true);
                WriteLiteral(@"
    <header class=""header"">
        <nav class=""navbar navbar-default"" id=""navbar"">
            <div class=""container"">

                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#header-navbar"" aria-expanded=""false""> <span class=""sr-only""></span> <span class=""icon-bar""></span> <span class=""icon-bar""></span> <span class=""icon-bar""></span> </button>
");
                EndContext();
                BeginContext(2064, 199, true);
                WriteLiteral("                    <h1 class=\"logo hvr-bounce-in\"><a href=\"#\">NBA篮球网</a></h1>\r\n                </div>\r\n                <div class=\"collapse navbar-collapse\" id=\"header-navbar\">\r\n                    ");
                EndContext();
                BeginContext(2263, 533, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58b7c85e009f4acfb14f5bf5c4cb1e79", async() => {
                    BeginContext(2331, 458, true);
                    WriteLiteral(@"
                        <div class=""input-group"">
                            <input type=""text"" name=""keyword"" class=""form-control"" placeholder=""请输入关键字"" maxlength=""20"" autocomplete=""off"">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default btn-search"" name=""search"" type=""submit"">搜索</button>
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
                BeginContext(2796, 117, true);
                WriteLiteral("\r\n                    <ul class=\"nav navbar-nav navbar-right\">\r\n                        <li><a href=\"/\">首页</a></li>\r\n");
                EndContext();
#line 52 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
                         if (Model.code == 200)
                        {
                            

#line default
#line hidden
#line 54 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
                             foreach (var classify in Model.data)
                            {

#line default
#line hidden
                BeginContext(3087, 38, true);
                WriteLiteral("                                <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3125, "\"", 3162, 2);
                WriteAttributeValue("", 3132, "/News/Classify?id=", 3132, 18, true);
#line 56 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3150, classify.Id, 3150, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3163, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3165, 13, false);
#line 56 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
                                                                        Write(classify.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3178, 11, true);
                WriteLiteral("</a></li>\r\n");
                EndContext();
#line 57 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
                            }

#line default
#line hidden
#line 57 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
                             
                        }

#line default
#line hidden
                BeginContext(3247, 141, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n    <section class=\"container\">\r\n      ");
                EndContext();
                BeginContext(3389, 12, false);
#line 65 "E:\asp.netcore2.1\ReleaseNews\ReleaseNews.Web\Views\Shared\_Layout.cshtml"
 Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(3401, 409, true);
                WriteLiteral(@"
    </section>
    <footer class=""footer"">
        <div class=""container"">
            <p>NBA篮球网<a target=""_blank"" href=""http://study.163.com/instructor/1025318795.htm""></a></p>
        </div>
        <div id=""gotop""><a class=""gotop""></a></div>
    </footer>
    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/jquery.ias.js""></script>
    <script src=""/js/scripts.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3817, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReleaseNews.Models.Response.ResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
